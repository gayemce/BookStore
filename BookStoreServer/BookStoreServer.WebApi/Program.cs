using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Options;
using BookStoreServer.WebApi.Utilities;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

/* AutoMapper Asembly ile IMapper Interface g�r�nce projedeki Profile inherit edilmi� class� bulur 
 * ve newler b�ylelikle instance olarak t�retir (Dependency Injection i�in) */
builder.Services.AddAutoMapper(typeof(Program).Assembly);

//AppDbContextin instancesini t�retir
builder.Services.AddScoped<AppDbContext>();

builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


//Authentication => kullan�c� kontrol�
//Authorization => Yetki kontrol�

//Authentication i�lemi yap�laca�� belirtildi, Jwt k�t�phanesi i�in default bir optimizasyon ger�ekle�tirildi.
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

//appsetting i�erisinde yaz�lan EmailSettings i�in
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

//Ya��m�z Email service dahil edildi
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

//app.UseAuthorization(); gerek. kalmad�

app.MapControllers();

app.Run();
