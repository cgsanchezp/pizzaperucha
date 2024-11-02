using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPeruchaApp.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }

        public int? UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
