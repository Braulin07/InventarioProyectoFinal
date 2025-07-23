namespace InventarioProyectoFinal.Formularios
{
    partial class UCInicio
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblBienvenida = new Label();
            gunaImgUsuarios = new Guna.UI2.WinForms.Guna2PictureBox();
            gunaImgEstadisticas = new Guna.UI2.WinForms.Guna2PictureBox();
            gunaImgInventario = new Guna.UI2.WinForms.Guna2PictureBox();
            lblEstadisticas = new Label();
            lblInventario = new Label();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)gunaImgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gunaImgEstadisticas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gunaImgInventario).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.Indigo;
            lblBienvenida.Location = new Point(253, 59);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(200, 40);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            lblBienvenida.TextAlign = ContentAlignment.TopCenter;
            // 
            // gunaImgUsuarios
            // 
            gunaImgUsuarios.BackColor = Color.Transparent;
            gunaImgUsuarios.BorderRadius = 30;
            gunaImgUsuarios.Cursor = Cursors.Hand;
            gunaImgUsuarios.CustomizableEdges = customizableEdges13;
            gunaImgUsuarios.Image = Properties.Resources.homebotonUsuario1;
            gunaImgUsuarios.ImageRotate = 0F;
            gunaImgUsuarios.Location = new Point(674, 173);
            gunaImgUsuarios.Name = "gunaImgUsuarios";
            gunaImgUsuarios.ShadowDecoration.CustomizableEdges = customizableEdges14;
            gunaImgUsuarios.Size = new Size(277, 292);
            gunaImgUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            gunaImgUsuarios.TabIndex = 3;
            gunaImgUsuarios.TabStop = false;
            gunaImgUsuarios.Click += gunaImgUsuarios_Click;
            // 
            // gunaImgEstadisticas
            // 
            gunaImgEstadisticas.BackColor = Color.Transparent;
            gunaImgEstadisticas.BorderRadius = 30;
            gunaImgEstadisticas.Cursor = Cursors.Hand;
            gunaImgEstadisticas.CustomizableEdges = customizableEdges15;
            gunaImgEstadisticas.FillColor = SystemColors.Control;
            gunaImgEstadisticas.Image = Properties.Resources.gomebotonEstadisticas;
            gunaImgEstadisticas.ImageRotate = 0F;
            gunaImgEstadisticas.Location = new Point(62, 173);
            gunaImgEstadisticas.Name = "gunaImgEstadisticas";
            gunaImgEstadisticas.ShadowDecoration.CustomizableEdges = customizableEdges16;
            gunaImgEstadisticas.Size = new Size(254, 292);
            gunaImgEstadisticas.SizeMode = PictureBoxSizeMode.StretchImage;
            gunaImgEstadisticas.TabIndex = 4;
            gunaImgEstadisticas.TabStop = false;
            gunaImgEstadisticas.Click += gunaImgEstadisticas_Click;
            // 
            // gunaImgInventario
            // 
            gunaImgInventario.BackColor = Color.Transparent;
            gunaImgInventario.BorderRadius = 30;
            gunaImgInventario.Cursor = Cursors.Hand;
            gunaImgInventario.CustomizableEdges = customizableEdges17;
            gunaImgInventario.FillColor = SystemColors.Control;
            gunaImgInventario.Image = Properties.Resources.homebotonInventario;
            gunaImgInventario.ImageRotate = 0F;
            gunaImgInventario.Location = new Point(373, 173);
            gunaImgInventario.Name = "gunaImgInventario";
            gunaImgInventario.ShadowDecoration.CustomizableEdges = customizableEdges18;
            gunaImgInventario.Size = new Size(254, 292);
            gunaImgInventario.SizeMode = PictureBoxSizeMode.StretchImage;
            gunaImgInventario.TabIndex = 5;
            gunaImgInventario.TabStop = false;
            gunaImgInventario.Click += gunaImgInventario_Click;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblEstadisticas.Location = new Point(126, 479);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(121, 23);
            lblEstadisticas.TabIndex = 6;
            lblEstadisticas.Text = "Estadisticas";
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblInventario.Location = new Point(452, 479);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(107, 23);
            lblInventario.TabIndex = 7;
            lblInventario.Text = "Inventario";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblUsuario.Location = new Point(774, 479);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(90, 23);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "Usuarios";
            // 
            // UCInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblUsuario);
            Controls.Add(lblInventario);
            Controls.Add(lblEstadisticas);
            Controls.Add(gunaImgInventario);
            Controls.Add(gunaImgEstadisticas);
            Controls.Add(gunaImgUsuarios);
            Controls.Add(lblBienvenida);
            Name = "UCInicio";
            Size = new Size(1014, 649);
            Load += UCInicio_Load;
            ((System.ComponentModel.ISupportInitialize)gunaImgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)gunaImgEstadisticas).EndInit();
            ((System.ComponentModel.ISupportInitialize)gunaImgInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Guna.UI2.WinForms.Guna2PictureBox gunaImgUsuarios;
        private Guna.UI2.WinForms.Guna2PictureBox gunaImgEstadisticas;
        private Guna.UI2.WinForms.Guna2PictureBox gunaImgInventario;
        private Label lblEstadisticas;
        private Label lblInventario;
        private Label lblUsuario;
    }
}
