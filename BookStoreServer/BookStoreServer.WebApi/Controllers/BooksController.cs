using AutoMapper;
using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookStoreServer.WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public sealed class BooksController : ControllerBase
{
    //Dependency Injection
    private readonly IMapper _mapper;
    private readonly AppDbContext _context;

    public BooksController(IMapper mapper, AppDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }



    //Kitapları Listele
    [HttpPost]
    public IActionResult GetAll(RequestDto request)
    {
        List<Book> books = new();
        if(request.CategoryId == null) //Tüm kitapları getir.
        {
            books = _context.Books
                .Where(p => p.IsActive == true && p.IsDeleted == false)
                .Where(p => p.Title.ToLower().Contains(request.Search.ToLower()) || p.ISBN.Contains(request.Search))
                .OrderBy(p => p.CreateAt)
                .Take(request.PageSize)
                .ToList();
        }
        else
        {
            books = _context.BookCategories
                .Where(p => p.CategoryId == request.CategoryId)
                .Include(p => p.Book) //Left Join
                .Select(s => s.Book)
                .Where(p => p.IsActive == true && p.IsDeleted == false)
                .Where(p => p.Title.ToLower().Contains(request.Search.ToLower()) || p.ISBN.Contains(request.Search))
                .OrderByDescending(propa => propa.CreateAt)
                .Take(request.PageSize)
                .ToList();
        }

        List<BookDto> requestDto = new();
        foreach (var book in books)
        {
            BookDto bookDto = _mapper.Map<BookDto>(book); // <Dönüştürülecek Tipi>(Dönüştürelecek olan)
            bookDto.Categories = _context.BookCategories
                                 .Where(p => p.BookId == book.Id)
                                 .Include(p => p.Category)
                                 .Select(s => s.Category.Name)
                                 .ToList();

            //tip dönüştürülmesi yapılarak raitingler basıldı
            var raiting = _context.Orders.Where(p => p.BookId == book.Id && p.Raiting != null).Average(p => p.Raiting);
            bookDto.Raiting = (short)(raiting == null ? 0 : Convert.ToInt16(Math.Round((decimal)raiting)));

            requestDto.Add(bookDto);
        }

        return Ok(requestDto);
    }
}