namespace PizzaPeruchaApp.Presentation
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(258, 125);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 28);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(289, 38);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(151, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(289, 78);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(151, 23);
            txtContrasenia.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(175, 46);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario :";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(175, 86);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(73, 15);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(263, 174);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 277);
            Controls.Add(linkLabel1);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Label lblUsuario;
        private Label lblContrasenia;
        private LinkLabel linkLabel1;
    }
}