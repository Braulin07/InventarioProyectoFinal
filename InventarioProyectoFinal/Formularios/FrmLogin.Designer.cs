namespace InventarioProyectoFinal
{
    partial class FrmLogin
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblLema = new Label();
            errorUsuarioVacio = new ErrorProvider(components);
            errorContraseñaVacia = new ErrorProvider(components);
            pictureBoxLogo = new PictureBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            lblMensajeError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)errorUsuarioVacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContraseñaVacia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblLema
            // 
            lblLema.AutoSize = true;
            lblLema.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLema.ForeColor = Color.Indigo;
            lblLema.Location = new Point(646, 42);
            lblLema.Name = "lblLema";
            lblLema.Size = new Size(408, 58);
            lblLema.TabIndex = 7;
            lblLema.Text = "Sistema de invetario #1\r\nGestión simple, resultados grandes.";
            lblLema.TextAlign = ContentAlignment.TopCenter;
            // 
            // errorUsuarioVacio
            // 
            errorUsuarioVacio.ContainerControl = this;
            // 
            // errorContraseñaVacia
            // 
            errorContraseñaVacia.ContainerControl = this;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Log_in_Logo;
            pictureBoxLogo.Location = new Point(-1, -1);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(615, 592);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(723, 177);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 23);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(723, 278);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(123, 23);
            lblContraseña.TabIndex = 10;
            lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Animated = true;
            txtUsuario.AutoRoundedCorners = true;
            txtUsuario.BorderColor = Color.Indigo;
            txtUsuario.BorderRadius = 29;
            txtUsuario.CustomizableEdges = customizableEdges5;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(697, 204);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 15;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderForeColor = Color.DimGray;
            txtUsuario.PlaceholderText = "Introduzca su Usuario";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtUsuario.Size = new Size(286, 60);
            txtUsuario.TabIndex = 11;
            // 
            // txtContraseña
            // 
            txtContraseña.Animated = true;
            txtContraseña.AutoRoundedCorners = true;
            txtContraseña.BorderColor = Color.Indigo;
            txtContraseña.BorderRadius = 29;
            txtContraseña.CustomizableEdges = customizableEdges3;
            txtContraseña.DefaultText = "";
            txtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Font = new Font("Segoe UI", 9F);
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Location = new Point(697, 305);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '●';
            txtContraseña.PlaceholderForeColor = Color.DimGray;
            txtContraseña.PlaceholderText = "Introduzca su Contraseña";
            txtContraseña.SelectedText = "";
            txtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtContraseña.Size = new Size(286, 60);
            txtContraseña.TabIndex = 12;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Animated = true;
            btnIniciarSesion.AutoRoundedCorners = true;
            btnIniciarSesion.BackColor = Color.Transparent;
            btnIniciarSesion.BorderColor = Color.FromArgb(0, 192, 0);
            btnIniciarSesion.BorderRadius = 25;
            btnIniciarSesion.CustomizableEdges = customizableEdges1;
            btnIniciarSesion.DisabledState.BorderColor = Color.DarkGray;
            btnIniciarSesion.DisabledState.CustomBorderColor = Color.DarkGray;
            btnIniciarSesion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnIniciarSesion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnIniciarSesion.FillColor = Color.Black;
            btnIniciarSesion.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(738, 397);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.PressedColor = Color.White;
            btnIniciarSesion.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnIniciarSesion.Size = new Size(213, 53);
            btnIniciarSesion.TabIndex = 13;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.BackColor = Color.Transparent;
            lblMensajeError.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(677, 142);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(3, 2);
            lblMensajeError.TabIndex = 14;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 591);
            Controls.Add(lblMensajeError);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblLema);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iStore BPG - Log In";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errorUsuarioVacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContraseñaVacia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button3;
        private Label lblLema;
        private ErrorProvider errorUsuarioVacio;
        private ErrorProvider errorContraseñaVacia;
        private PictureBox pictureBoxLogo;
        private Label lblUsuario;
        private Label lblContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMensajeError;
    }
}
