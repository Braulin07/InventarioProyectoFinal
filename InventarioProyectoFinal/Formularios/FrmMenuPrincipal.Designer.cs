namespace InventarioProyectoFinal.Formularios
{
    partial class FrmMenuPrincipal
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            sidebar = new FlowLayoutPanel();
            panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            MenuBoton = new Guna.UI2.WinForms.Guna2ImageButton();
            pictureBoxLogoMenu = new PictureBox();
            panel2 = new Panel();
            btnEstadisticas = new Button();
            panel3 = new Panel();
            btnInventario = new Button();
            panel4 = new Panel();
            btnUsuarios = new Button();
            btnAcercaDe = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panelMain = new Panel();
            PanelLateralUsuario = new Panel();
            ImgLogOut = new Guna.UI2.WinForms.Guna2ImageButton();
            lblNombreUsuario = new Label();
            pictureBoxUsuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            sidebar.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoMenu).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            PanelLateralUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Indigo;
            sidebar.Controls.Add(panelMenu);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(btnAcercaDe);
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(288, 649);
            sidebar.MinimumSize = new Size(87, 649);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(288, 649);
            sidebar.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(MenuBoton);
            panelMenu.Controls.Add(pictureBoxLogoMenu);
            panelMenu.CustomizableEdges = customizableEdges2;
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.ShadowDecoration.CustomizableEdges = customizableEdges3;
            panelMenu.Size = new Size(292, 153);
            panelMenu.TabIndex = 1;
            // 
            // MenuBoton
            // 
            MenuBoton.CheckedState.ImageSize = new Size(64, 64);
            MenuBoton.Cursor = Cursors.Hand;
            MenuBoton.HoverState.ImageSize = new Size(64, 64);
            MenuBoton.Image = Properties.Resources.menu_icon_white;
            MenuBoton.ImageOffset = new Point(0, 0);
            MenuBoton.ImageRotate = 0F;
            MenuBoton.ImageSize = new Size(48, 48);
            MenuBoton.Location = new Point(-12, 3);
            MenuBoton.Name = "MenuBoton";
            MenuBoton.PressedState.ImageSize = new Size(64, 64);
            MenuBoton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            MenuBoton.Size = new Size(99, 147);
            MenuBoton.TabIndex = 0;
            MenuBoton.Click += MenuBoton_Click_1;
            // 
            // pictureBoxLogoMenu
            // 
            pictureBoxLogoMenu.Image = Properties.Resources.Main_Logo_Indigo_sin_fondo;
            pictureBoxLogoMenu.Location = new Point(83, -3);
            pictureBoxLogoMenu.Name = "pictureBoxLogoMenu";
            pictureBoxLogoMenu.Size = new Size(199, 156);
            pictureBoxLogoMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoMenu.TabIndex = 1;
            pictureBoxLogoMenu.TabStop = false;
            pictureBoxLogoMenu.Click += pictureBoxLogoMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEstadisticas);
            panel2.Location = new Point(3, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 75);
            panel2.TabIndex = 2;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Dock = DockStyle.Left;
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEstadisticas.ForeColor = Color.White;
            btnEstadisticas.Image = Properties.Resources.estadistica_3d_icon_4;
            btnEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.Location = new Point(0, 0);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(282, 75);
            btnEstadisticas.TabIndex = 1;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnInventario);
            panel3.Location = new Point(3, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 75);
            panel3.TabIndex = 3;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Left;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = Properties.Resources.inventario_3d_icon_2;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 0);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(282, 75);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnUsuarios);
            panel4.Location = new Point(3, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(285, 75);
            panel4.TabIndex = 4;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Left;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = Properties.Resources.boy_avatar_icon;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(282, 75);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAcercaDe.ForeColor = Color.White;
            btnAcercaDe.Image = Properties.Resources.About_picture;
            btnAcercaDe.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcercaDe.Location = new Point(3, 405);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(282, 75);
            btnAcercaDe.TabIndex = 2;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += slidebarTimer_Tick;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(291, 0);
            panelMain.MaximumSize = new Size(1229, 649);
            panelMain.MinimumSize = new Size(1014, 649);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1014, 649);
            panelMain.TabIndex = 1;
            // 
            // PanelLateralUsuario
            // 
            PanelLateralUsuario.BackColor = SystemColors.Control;
            PanelLateralUsuario.Controls.Add(ImgLogOut);
            PanelLateralUsuario.Controls.Add(lblNombreUsuario);
            PanelLateralUsuario.Controls.Add(pictureBoxUsuario);
            PanelLateralUsuario.Location = new Point(75, 0);
            PanelLateralUsuario.Name = "PanelLateralUsuario";
            PanelLateralUsuario.Size = new Size(220, 649);
            PanelLateralUsuario.TabIndex = 0;
            PanelLateralUsuario.Paint += PanelLateralUsuario_Paint;
            // 
            // ImgLogOut
            // 
            ImgLogOut.BackColor = Color.Transparent;
            ImgLogOut.CheckedState.ImageSize = new Size(64, 64);
            ImgLogOut.HoverState.ImageSize = new Size(64, 64);
            ImgLogOut.Image = Properties.Resources.Log_out_icon;
            ImgLogOut.ImageOffset = new Point(0, 0);
            ImgLogOut.ImageRotate = 0F;
            ImgLogOut.ImageSize = new Size(45, 45);
            ImgLogOut.ImeMode = ImeMode.NoControl;
            ImgLogOut.Location = new Point(53, 529);
            ImgLogOut.Name = "ImgLogOut";
            ImgLogOut.PressedState.ImageSize = new Size(64, 64);
            ImgLogOut.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ImgLogOut.Size = new Size(127, 117);
            ImgLogOut.TabIndex = 0;
            ImgLogOut.Click += ImgLogOut_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(68, 185);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(30, 27);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "...";
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.BackColor = Color.Transparent;
            pictureBoxUsuario.ImageRotate = 0F;
            pictureBoxUsuario.Location = new Point(32, 22);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pictureBoxUsuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pictureBoxUsuario.Size = new Size(148, 147);
            pictureBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuario.TabIndex = 0;
            pictureBoxUsuario.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1302, 649);
            Controls.Add(sidebar);
            Controls.Add(PanelLateralUsuario);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iStore BPG";
            Load += FrmMenuPrincipal_Load;
            sidebar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoMenu).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            PanelLateralUsuario.ResumeLayout(false);
            PanelLateralUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Panel panel2;
        private Button btnEstadisticas;
        private Panel panel3;
        private Button btnInventario;
        private Panel panel4;
        private Button btnUsuarios;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox pictureBoxLogoMenu;
        private Panel panelMain;
        private Panel PanelLateralUsuario;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxUsuario;
        private Guna.UI2.WinForms.Guna2ImageButton ImgLogOut;
        private Label lblNombreUsuario;
        private Guna.UI2.WinForms.Guna2ImageButton MenuBoton;
        private Button btnAcercaDe;
    }
}