
namespace PizzaPeruchaApp.Presentation
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ssToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            tsmiGestionProductos = new ToolStripMenuItem();
            gestionDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            registrarPedidoToolStripMenuItem = new ToolStripMenuItem();
            verPedidosToolStripMenuItem = new ToolStripMenuItem();
            activosToolStripMenuItem = new ToolStripMenuItem();
            generarFacturaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            ventasDiariasToolStripMenuItem = new ToolStripMenuItem();
            ventasMensualesToolStripMenuItem = new ToolStripMenuItem();
            reporteDeInventariosToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            preferenciaDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            configurarUsuariosYRolesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ssToolStripMenuItem, gestionToolStripMenuItem, toolStripMenuItem1, pedidosToolStripMenuItem, reportesToolStripMenuItem, configuracionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ssToolStripMenuItem
            // 
            ssToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, salirToolStripMenuItem });
            ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            ssToolStripMenuItem.Size = new Size(60, 20);
            ssToolStripMenuItem.Text = "Archivo";
            ssToolStripMenuItem.Click += ssToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(143, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(143, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiGestionProductos, gestionDeEmpleadosToolStripMenuItem, gestionDeUsuariosToolStripMenuItem });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(59, 20);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // tsmiGestionProductos
            // 
            tsmiGestionProductos.Name = "tsmiGestionProductos";
            tsmiGestionProductos.Size = new Size(191, 22);
            tsmiGestionProductos.Text = "Gestion de productos";
            tsmiGestionProductos.Click += gestionDeProductosToolStripMenuItem_Click;
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            gestionDeEmpleadosToolStripMenuItem.Size = new Size(191, 22);
            gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            gestionDeUsuariosToolStripMenuItem.Size = new Size(191, 22);
            gestionDeUsuariosToolStripMenuItem.Text = "Gestion de usuarios";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarPedidoToolStripMenuItem, verPedidosToolStripMenuItem, activosToolStripMenuItem, generarFacturaToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // registrarPedidoToolStripMenuItem
            // 
            registrarPedidoToolStripMenuItem.Name = "registrarPedidoToolStripMenuItem";
            registrarPedidoToolStripMenuItem.Size = new Size(179, 22);
            registrarPedidoToolStripMenuItem.Text = "Registrar Pedido";
            // 
            // verPedidosToolStripMenuItem
            // 
            verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            verPedidosToolStripMenuItem.Size = new Size(179, 22);
            verPedidosToolStripMenuItem.Text = "Ver Pedidos Activos";
            // 
            // activosToolStripMenuItem
            // 
            activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            activosToolStripMenuItem.Size = new Size(179, 22);
            activosToolStripMenuItem.Text = "Historial de Pedidos";
            activosToolStripMenuItem.Click += activosToolStripMenuItem_Click;
            // 
            // generarFacturaToolStripMenuItem
            // 
            generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            generarFacturaToolStripMenuItem.Size = new Size(179, 22);
            generarFacturaToolStripMenuItem.Text = "Generar Factura";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasDiariasToolStripMenuItem, ventasMensualesToolStripMenuItem, reporteDeInventariosToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventasDiariasToolStripMenuItem
            // 
            ventasDiariasToolStripMenuItem.Name = "ventasDiariasToolStripMenuItem";
            ventasDiariasToolStripMenuItem.Size = new Size(192, 22);
            ventasDiariasToolStripMenuItem.Text = "Ventas Diarias";
            // 
            // ventasMensualesToolStripMenuItem
            // 
            ventasMensualesToolStripMenuItem.Name = "ventasMensualesToolStripMenuItem";
            ventasMensualesToolStripMenuItem.Size = new Size(192, 22);
            ventasMensualesToolStripMenuItem.Text = "Ventas Mensuales";
            // 
            // reporteDeInventariosToolStripMenuItem
            // 
            reporteDeInventariosToolStripMenuItem.Name = "reporteDeInventariosToolStripMenuItem";
            reporteDeInventariosToolStripMenuItem.Size = new Size(192, 22);
            reporteDeInventariosToolStripMenuItem.Text = "Reporte de Inventarios";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferenciaDelSistemaToolStripMenuItem, cambiarContraseñaToolStripMenuItem, configurarUsuariosYRolesToolStripMenuItem });
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(95, 20);
            configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // preferenciaDelSistemaToolStripMenuItem
            // 
            preferenciaDelSistemaToolStripMenuItem.Name = "preferenciaDelSistemaToolStripMenuItem";
            preferenciaDelSistemaToolStripMenuItem.Size = new Size(219, 22);
            preferenciaDelSistemaToolStripMenuItem.Text = "Preferencia del sistema";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(219, 22);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // configurarUsuariosYRolesToolStripMenuItem
            // 
            configurarUsuariosYRolesToolStripMenuItem.Name = "configurarUsuariosYRolesToolStripMenuItem";
            configurarUsuariosYRolesToolStripMenuItem.Size = new Size(219, 22);
            configurarUsuariosYRolesToolStripMenuItem.Text = "Configurar Usuarios y Roles";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuForm";
            Text = "FrmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is ProductosForm)
                {
                    form.Activate();
                    return;
                }
            }

            var productosForm = new ProductosForm();
            productosForm.MdiParent = this;
            productosForm.Show();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ssToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem tsmiGestionProductos;
        private ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem registrarPedidoToolStripMenuItem;
        private ToolStripMenuItem verPedidosToolStripMenuItem;
        private ToolStripMenuItem activosToolStripMenuItem;
        private ToolStripMenuItem generarFacturaToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem ventasDiariasToolStripMenuItem;
        private ToolStripMenuItem ventasMensualesToolStripMenuItem;
        private ToolStripMenuItem reporteDeInventariosToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem preferenciaDelSistemaToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private ToolStripMenuItem configurarUsuariosYRolesToolStripMenuItem;
    }
}