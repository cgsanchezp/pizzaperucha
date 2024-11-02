namespace PizzaPeruchaApp
{
    partial class ProductosForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProductos = new DataGridView();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            cboTipo = new ComboBox();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblTipo = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            lblID = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(101, 239);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(628, 217);
            dataGridViewProductos.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(314, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(314, 85);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(183, 23);
            txtPrecio.TabIndex = 2;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(314, 123);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(183, 23);
            cboTipo.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(207, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(207, 93);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(207, 131);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(232, 190);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(310, 190);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 30);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(391, 190);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 30);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(472, 190);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(210, 27);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 11;
            lblID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(314, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 12;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTipo);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(cboTipo);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(dataGridViewProductos);
            Name = "ProductosForm";
            Text = "Gestion de productos";
            Load += ProductosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private ComboBox cboTipo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblTipo;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Label lblID;
        private TextBox txtID;
    }
}
