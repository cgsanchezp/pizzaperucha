using PizzaPeruchaApp.Data;
using PizzaPeruchaApp.Models;

namespace PizzaPeruchaApp
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
            // Configuración de fuente para Labels
            lblID.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNombre.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblPrecio.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTipo.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Configuración de fuente para TextBoxes
            txtID.Font = new Font("Segoe UI", 10);
            txtNombre.Font = new Font("Segoe UI", 10);
            txtPrecio.Font = new Font("Segoe UI", 10);
            cboTipo.Font = new Font("Segoe UI", 10);

            // Configuración de fuente para Botones
            btnAgregar.Font = new Font("Segoe UI", 12);
            btnEditar.Font = new Font("Segoe UI", 12);
            btnEliminar.Font = new Font("Segoe UI", 12);
            btnGuardar.Font = new Font("Segoe UI", 12);

            // Configuración de fuente para DataGridView
            dataGridViewProductos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

        }

        private void LoadProductos()
        {
            using (var context = new PizzaPeruchaDbContext())
            {
                var productos = context.Productos.ToList();
                dataGridViewProductos.DataSource = productos;
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            LoadProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var context = new PizzaPeruchaDbContext())
            {
                var producto = new Producto
                {
                    NombreProducto = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    TipoProducto = cboTipo.SelectedItem.ToString()
                };

                context.Productos.Add(producto);
                context.SaveChanges();
            }
            LoadProductos();
        }
    }
}
