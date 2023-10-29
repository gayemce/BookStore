using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Options;
using BookStoreServer.WebApi.Utilities;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

/* AutoMapper Asembly ile IMapper Interface görünce projedeki Profile inherit edilmiþ classý bulur 
 * ve newler böylelikle instance olarak türetir (Dependency Injection için) */
builder.Services.AddAutoMapper(typeof(Program).Assembly);

//AppDbContextin instancesini türetir
builder.Services.AddScoped<AppDbContext>();

builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


//Authentication => kullanýcý kontrolü
//Authorization => Yetki kontrolü

//Authentication iþlemi yapýlacaðý belirtildi, Jwt kütüphanesi için default bir optimizasyon gerçekleþtirildi.
builder.Services.AddAuthentication().AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "Issuer",
        ValidAudience = "Audience",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("My secret key my secret key my secret key my secret key"))
    };
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//appsetting içerisinde yazýlan EmailSettings için
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

//Yaðýmýz Email service dahil edildi
builder.Services.CreateServiceTool(); 


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

//app.UseAuthorization(); gerek. kalmadý

app.MapControllers();

app.Run();
