using Microsoft.EntityFrameworkCore;
using PizzaPeruchaApp.Data;
using PizzaPeruchaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPeruchaApp.Business
{
    public class UsuarioService
    {
        private readonly PizzaPeruchaDbContext _context;

        public UsuarioService(PizzaPeruchaDbContext context)
        {
            _context = context;
        }

        public async Task CrearUsuarioAsync(string username,string password,string rol)
        {
            var passwordHash = HashPassword(password);
            var usuario = new Usuario
            {
                Username = username,
                PasswordHash = passwordHash,
                Rol = rol,
                FechaCreacion = DateTime.Now
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario> AutenticarAsync(string username,string password)
        {
            var passwordHash = HashPassword(password);
            return await _context.Usuarios.FirstOrDefaultAsync(u => u.Username == username && u.PasswordHash == passwordHash);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
