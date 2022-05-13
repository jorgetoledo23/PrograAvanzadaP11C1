using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        public AuthController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }


        [Route("Registro")][HttpPost]
        public IActionResult Registro(UsuarioDTO userDTO)
        {
            Usuario usuario = new Usuario();
            usuario.Username = userDTO.Username;
            usuario.Email = userDTO.Correo;
            usuario.Name = userDTO.Name;

            CreatePasswordHash(userDTO.Password,
                out byte[] passwordHash, out byte[] passwordSalt);

            usuario.PasswordHash = passwordHash;
            usuario.PasswordSalt = passwordSalt;

            _context.Add(usuario);
            _context.SaveChanges();

            return Ok();

        }



        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login(LoginDTO userDto)
        {
            var user = _context.Usuarios
                .FirstOrDefault(u => u.Username == userDto.Username);
            if (user == null) return BadRequest("User not found!");

            if (!VerifyPassword(userDto.Password, 
                user.PasswordHash, user.PasswordSalt))
                return BadRequest("Bad Credentials!");
            string Token = CreateToken(user);
            return Ok(Token);

            //Authentication
            //Authorization
            //Claims
            //ClaimsIdentity
            //ClaimsPrincipal
        }




        private void CreatePasswordHash(string password, 
            out byte[] passwordhash, out byte[] passwordsalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordsalt = hmac.Key;
                passwordhash = hmac.ComputeHash(System.Text.Encoding.UTF8
                    .GetBytes(password));
            }
        }

        private bool VerifyPassword(string password, 
            byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8
                    .GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateToken(Usuario user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, "Free")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));
            var credential = new SigningCredentials(key, 
                SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credential
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }




    }
}
