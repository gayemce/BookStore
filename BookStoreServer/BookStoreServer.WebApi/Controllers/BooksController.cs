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
    //Kitapları Listele
    [HttpPost]
    public IActionResult GetAll(RequestDto request)
    {
        AppDbContext context = new();

        List<Book> books = new();
        if(request.CategoryId == null) //Tüm kitapları getir.
        {
            books = context.Books
                .Where(p => p.IsActive == true && p.IsDeleted == false)
                .Where(p => p.Title.ToLower().Contains(request.Search.ToLower()) || p.ISBN.Contains(request.Search))
                .OrderByDescending(p => p.CreateAt)
                .Take(request.PageSize)
                .ToList();
        }
        else
        {
            books = context.BookCategories
                .Where(p => p.CategoryId == request.CategoryId)
                .Include(p => p.Book) //Left Join
                .Select(s => s.Book)
                .Where(p => p.IsActive == true && p.IsDeleted == false)
                .Where(p => p.Title.ToLower().Contains(request.Search.ToLower()) || p.ISBN.Contains(request.Search))
                .OrderByDescending(propa => propa.CreateAt)
                .Take(request.PageSize)
                .ToList();
        }

        return Ok(books);
    }
}