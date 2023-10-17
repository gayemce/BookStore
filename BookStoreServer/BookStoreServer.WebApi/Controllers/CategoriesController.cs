using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using GSF.FuzzyStrings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    //Kategori Ekleme
    [HttpPost]
    public IActionResult Create(CreateCategoryDto request)
    {
        AppDbContext context = new();

        var checkNameIsUnique = context.Categories.Any(p => p.Name == request.Name);
        if(checkNameIsUnique)
        {
            return BadRequest("Kategori adı daha önce kullanılmıştır.");
        }

        Category category = new()
        {
            Name = request.Name,
            IsActive = true,
            IsDeleted = false
        };

        
        context.Categories.Add(category);
        context.SaveChanges();
        return Ok(category);
    }


    //Kategori Silme - IsDeleted == true yapılacak
    [HttpGet("{id}")]
    public IActionResult RemoveById(int id)
    {
        AppDbContext context = new();
        var category = context.Categories.Find(id); //Select * From Categories Where Id = 1
        if (category == null)
        {
            return NoContent();
        }

        category.IsDeleted = true;
        context.SaveChanges();
        return Ok(GetAllCategories());
    }

    //Kategori Güncelleme
    [HttpPost]
    public IActionResult UpdateById(UpdateCategoryDto request)
    {
        AppDbContext context = new();
        var category = context.Categories.Find(request.Id);
        if(category == null)
        {
            return NoContent();
        }

        category.Name = request.Name;
        context.SaveChanges();
        return Ok(GetAllCategories());
    }

    //Databasedeki Kategorileri Listeler
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(GetAllCategories());
    }

    private List<Category> GetAllCategories()
    {
        AppDbContext context = new(); //conn

        /* Select * From Categories Where IsActive = 1 and IsDeleted = 0 Order By Name */
        var categories = context.Categories
            .Where(c => c.IsActive == true && c.IsDeleted == false)
            .OrderBy(c => c.Name)
            .ToList();

        return categories;
    }
}
