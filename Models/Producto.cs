using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPeruchaApp.Models
{
    public class Producto
    {
        public int ProductoID {  get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio {  get; set; }
        public string TipoProducto {  get; set; }

    }
}
