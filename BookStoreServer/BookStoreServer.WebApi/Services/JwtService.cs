using BookStoreServer.WebApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookStoreServer.WebApi.Services;

public static class JwtService
{
    public static string CreatToken(User user)
    {
        //Claim: Api de taşınacak veriler, token içerisine bu veriler eklenmiş olur.
        var claims = new Claim[]
        {
            new("UserId", user.Id.ToString()),
            new("UserName", user.Name + " " + user.Lastname)
        };

        //Service JwtSecurityToken isimli bir class ister ve default değerler alır.
        JwtSecurityToken handler = new(
            issuer: "Issuer",
            audience: "audience",
            claims: claims,
            notBefore: DateTime.Now,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("My secret key my secret key my secret key my secret key")), SecurityAlgorithms.HmacSha256));

        //token üretildi
        string token = new JwtSecurityTokenHandler().WriteToken(handler);
        return token; //karşı tarafa gönderildi
    }
}
