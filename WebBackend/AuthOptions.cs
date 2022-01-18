using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace WebBackend.Models;

public class AuthOptions
{
    public const string Issuer = "http://localhost:9000"; // издатель токена
    public const string Audience = "http://localhost"; // потребитель токена
    private const string Key = "814710b369fb236c0c01b8f738593db9"; // ключ для шифрации
    public const int Lifetime = 60; // время жизни токена - 1 минута

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
    }
}