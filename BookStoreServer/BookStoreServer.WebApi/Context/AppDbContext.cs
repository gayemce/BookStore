using BookStoreServer.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreServer.WebApi.Context;

public sealed class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-I7G56NT\\SQLEXPRESS;Initial Catalog=YMYP_BookStoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Composite Key
        modelBuilder.Entity<BookCategory>().HasKey(p => new { p.BookId, p.CategoryId });

        //Domain Driven Design - Value Object

        modelBuilder.Entity<Book>().OwnsOne(p => p.Price, price =>
        {
            price.Property(p => p.Value).HasColumnType("money");
            price.Property(p => p.Currency).HasMaxLength(5); // Assuming you want a max length for Currency
        });//Value Object


        #region Book Price

        //Value Object yapıldığı için gerek kalmadı
        //modelBuilder.Entity<Book>().Property(p => p.Price).HasColumnType("money");

        #endregion

        #region Seed Data
        //Note: Value Object kullanılınca Seed Data yapılamıyor.

        //List<Category> categories = new();
        //for (int i = 0; i < 10; i++)
        //{
        //    var category = new Category()
        //    {
        //        Id = i + 1,
        //        Name = "Category" + (i + 1),
        //        IsActive = true,
        //        IsDeleted = false,
        //    };
        //    categories.Add(category);
        //}

        //modelBuilder.Entity<Category>().HasData(categories);

        //List<Book> books = new();
        //for (int i = 0; i < 100; i++)
        //{
        //    var book = new Book()
        //    {
        //        Id = i + 1,
        //        Title = $"Book {i + 1}",
        //        Author = "Author " + (i + 1),
        //        ISBN = "978-0321125217",
        //        IsActive = true,
        //        IsDeleted = false,
        //        Price = new(i*10, "₺"),
        //        Quantity = 10,
        //        Summary = "",
        //        CoverImageUrl = "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg",
        //        CreateAt = DateTime.Now,
        //    };

        //    books.Add(book);
        //}

        //modelBuilder.Entity<Book>().HasData(books.ToArray());

        ////Aralarında ilişki kurmak 
        //List<BookCategory> bookCategories = new();
        //foreach (var book in books)
        //{
        //    var bookCategory = new BookCategory()
        //    {
        //        BookId = book.Id,
        //        CategoryId = categories[new Random().Next(0, 10)].Id
        //    };

        //    bookCategories.Add(bookCategory);
        //}

        //modelBuilder.Entity<BookCategory>().HasData(bookCategories);

        #endregion

    }
}
