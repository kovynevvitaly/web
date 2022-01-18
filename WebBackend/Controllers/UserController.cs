#nullable disable
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebBackend.Controllers.Models;
using WebBackend.Models;

namespace WebBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly WebDbContext _context;
        private static readonly MD5 Md5 = MD5.Create();

        public UserController(WebDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("/api/[controller]/Login")]
        public async Task<ActionResult<User>> Login(LoginModel loginModel)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == loginModel.Email);

            if (user == null)
            {
                return BadRequest("User with specified not found");
            }

            var passwordHash = Convert.ToHexString(Md5.ComputeHash(Encoding.ASCII.GetBytes(loginModel.Password)));

            if (passwordHash != user.Password)
            {
                return BadRequest("Password is incorrect");
            }

            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.Audience,
                notBefore: DateTime.UtcNow,
                claims: GetIdentity(user).Claims,
                expires: DateTime.UtcNow.AddMinutes(AuthOptions.Lifetime),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                accessToken = encodedJwt,
                email = loginModel.Email
            };

            return new OkObjectResult(response);
        }

        [HttpPost]
        [Route("/api/[controller]/Register")]
        public async Task<ActionResult<User>> Register(RegisterModel registerModel)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == registerModel.Email);

            if (user != null)
            {
                return BadRequest("User with specified email exists");
            }

            var passwordHash = Convert.ToHexString(Md5.ComputeHash(Encoding.ASCII.GetBytes(registerModel.Password)));

            var newUser = new User
            {
                Email = registerModel.Email,
                Password = passwordHash
            };

            _context.Users.Add(newUser);

            await _context.SaveChangesAsync();

            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.Audience,
                notBefore: DateTime.UtcNow,
                claims: GetIdentity(newUser).Claims,
                expires: DateTime.UtcNow.AddMinutes(AuthOptions.Lifetime),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                accessToken = encodedJwt,
                email = registerModel.Email
            };

            return new OkObjectResult(response);
        }
        
        private static ClaimsIdentity GetIdentity(User user)
        {
            var claims = new List<Claim>
            {
                new(ClaimsIdentity.DefaultNameClaimType, user.Email),
            };
            var claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity;
        }
    }
}
