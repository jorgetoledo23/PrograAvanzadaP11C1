using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
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




    }
}
