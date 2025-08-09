namespace InventarioProyectoFinal.Formularios
{
    partial class UCResultadoBusquedaUsuario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblUsuarioBusqueda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblRolBusqueda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblEstadoBusqueda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ImagenBusqueda = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)ImagenBusqueda).BeginInit();
            SuspendLayout();
            // 
            // lblUsuarioBusqueda
            // 
            lblUsuarioBusqueda.BackColor = Color.Transparent;
            lblUsuarioBusqueda.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblUsuarioBusqueda.Location = new Point(115, 16);
            lblUsuarioBusqueda.Name = "lblUsuarioBusqueda";
            lblUsuarioBusqueda.Size = new Size(74, 25);
            lblUsuarioBusqueda.TabIndex = 1;
            lblUsuarioBusqueda.Text = "Usuario";
            // 
            // lblRolBusqueda
            // 
            lblRolBusqueda.BackColor = Color.Transparent;
            lblRolBusqueda.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRolBusqueda.Location = new Point(115, 47);
            lblRolBusqueda.Name = "lblRolBusqueda";
            lblRolBusqueda.Size = new Size(29, 23);
            lblRolBusqueda.TabIndex = 2;
            lblRolBusqueda.Text = "Rol";
            // 
            // lblEstadoBusqueda
            // 
            lblEstadoBusqueda.BackColor = Color.Transparent;
            lblEstadoBusqueda.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoBusqueda.Location = new Point(115, 76);
            lblEstadoBusqueda.Name = "lblEstadoBusqueda";
            lblEstadoBusqueda.Size = new Size(63, 23);
            lblEstadoBusqueda.TabIndex = 3;
            lblEstadoBusqueda.Text = "Estado";
            // 
            // ImagenBusqueda
            // 
            ImagenBusqueda.ImageRotate = 0F;
            ImagenBusqueda.InitialImage = Properties.Resources.ImagenPorDefecto;
            ImagenBusqueda.Location = new Point(15, 16);
            ImagenBusqueda.Name = "ImagenBusqueda";
            ImagenBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ImagenBusqueda.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ImagenBusqueda.Size = new Size(90, 80);
            ImagenBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenBusqueda.TabIndex = 4;
            ImagenBusqueda.TabStop = false;
            // 
            // UCResultadoBusquedaUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ImagenBusqueda);
            Controls.Add(lblEstadoBusqueda);
            Controls.Add(lblRolBusqueda);
            Controls.Add(lblUsuarioBusqueda);
            Cursor = Cursors.Hand;
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "UCResultadoBusquedaUsuario";
            Size = new Size(515, 113);
            Load += UCResultadoBusquedaUsuario_Load;
            Click += UCResultadoBusquedaUsuario_Click;
            ((System.ComponentModel.ISupportInitialize)ImagenBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsuarioBusqueda;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRolBusqueda;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoBusqueda;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ImagenBusqueda;
    }
}
