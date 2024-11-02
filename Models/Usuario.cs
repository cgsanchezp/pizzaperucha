using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPeruchaApp.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Username { get; set; }
        public string PasswordHash {  get; set; }
        public string Rol { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
