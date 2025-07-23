namespace InventarioProyectoFinal.Formularios
{
    partial class UCVerUsuarios
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowUsuarios = new FlowLayoutPanel();
            btnCrearUsuario = new Guna.UI2.WinForms.Guna2Button();
            txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panelEditorUsuario = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // flowUsuarios
            // 
            flowUsuarios.AutoScroll = true;
            flowUsuarios.BackColor = SystemColors.Control;
            flowUsuarios.Location = new Point(16, 166);
            flowUsuarios.Name = "flowUsuarios";
            flowUsuarios.Padding = new Padding(10);
            flowUsuarios.Size = new Size(673, 391);
            flowUsuarios.TabIndex = 0;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Animated = true;
            btnCrearUsuario.AutoRoundedCorners = true;
            btnCrearUsuario.BackColor = Color.Transparent;
            btnCrearUsuario.BorderColor = Color.Indigo;
            btnCrearUsuario.BorderRadius = 27;
            btnCrearUsuario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btnCrearUsuario.CustomizableEdges = customizableEdges1;
            btnCrearUsuario.DisabledState.BorderColor = Color.DarkGray;
            btnCrearUsuario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCrearUsuario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCrearUsuario.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCrearUsuario.FillColor = Color.Black;
            btnCrearUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCrearUsuario.ForeColor = Color.White;
            btnCrearUsuario.Location = new Point(373, 579);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCrearUsuario.Size = new Size(214, 56);
            btnCrearUsuario.TabIndex = 5;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderColor = Color.Indigo;
            txtBuscar.CustomizableEdges = customizableEdges3;
            txtBuscar.DefaultText = "";
            txtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscar.Location = new Point(22, 99);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderForeColor = Color.Gray;
            txtBuscar.PlaceholderText = "Buscar por Usuario...";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBuscar.Size = new Size(394, 60);
            txtBuscar.TabIndex = 6;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panelEditorUsuario
            // 
            panelEditorUsuario.BorderRadius = 25;
            panelEditorUsuario.CustomizableEdges = customizableEdges5;
            panelEditorUsuario.FillColor = Color.Indigo;
            panelEditorUsuario.FillColor2 = Color.Navy;
            panelEditorUsuario.FillColor4 = Color.Indigo;
            panelEditorUsuario.Location = new Point(695, 166);
            panelEditorUsuario.Name = "panelEditorUsuario";
            panelEditorUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelEditorUsuario.Size = new Size(316, 391);
            panelEditorUsuario.TabIndex = 22;
            // 
            // UCVerUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelEditorUsuario);
            Controls.Add(txtBuscar);
            Controls.Add(btnCrearUsuario);
            Controls.Add(flowUsuarios);
            Name = "UCVerUsuarios";
            Size = new Size(1014, 649);
            Load += UCVerUsuarios_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnCrearUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelEditorUsuario;
    }
}
