namespace InventarioProyectoFinal.Formularios
{
    partial class UCVerProductos
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtBuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            flowProductos = new FlowLayoutPanel();
            panelEditorProducto = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            button1 = new Button();
            btnGuardarCambios = new Guna.UI2.WinForms.Guna2Button();
            txtPrecioVenta = new TextBox();
            txtPrecioCompra = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            chkActivo = new CheckBox();
            picProducto = new PictureBox();
            lblVistaNombre = new Label();
            lbldividir = new Label();
            lblTitulo = new Label();
            panelEditorProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.BorderColor = Color.Indigo;
            txtBuscarProducto.CustomizableEdges = customizableEdges1;
            txtBuscarProducto.DefaultText = "";
            txtBuscarProducto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarProducto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarProducto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarProducto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarProducto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarProducto.Font = new Font("Segoe UI", 9F);
            txtBuscarProducto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarProducto.Location = new Point(31, 57);
            txtBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "";
            txtBuscarProducto.SelectedText = "";
            txtBuscarProducto.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscarProducto.Size = new Size(340, 60);
            txtBuscarProducto.TabIndex = 1;
            // 
            // flowProductos
            // 
            flowProductos.BackColor = Color.White;
            flowProductos.Location = new Point(18, 124);
            flowProductos.Name = "flowProductos";
            flowProductos.Size = new Size(656, 472);
            flowProductos.TabIndex = 2;
            // 
            // panelEditorProducto
            // 
            panelEditorProducto.BorderRadius = 25;
            panelEditorProducto.Controls.Add(button1);
            panelEditorProducto.Controls.Add(btnGuardarCambios);
            panelEditorProducto.Controls.Add(txtPrecioVenta);
            panelEditorProducto.Controls.Add(txtPrecioCompra);
            panelEditorProducto.Controls.Add(txtNombre);
            panelEditorProducto.Controls.Add(txtCodigo);
            panelEditorProducto.Controls.Add(chkActivo);
            panelEditorProducto.Controls.Add(picProducto);
            panelEditorProducto.Controls.Add(lblVistaNombre);
            panelEditorProducto.Controls.Add(lbldividir);
            panelEditorProducto.CustomizableEdges = customizableEdges5;
            panelEditorProducto.FillColor = Color.Indigo;
            panelEditorProducto.FillColor2 = Color.Navy;
            panelEditorProducto.FillColor4 = Color.Indigo;
            panelEditorProducto.Location = new Point(680, 124);
            panelEditorProducto.Name = "panelEditorProducto";
            panelEditorProducto.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelEditorProducto.Size = new Size(320, 432);
            panelEditorProducto.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(223, 64);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 14;
            button1.Text = "Cambiar\r\nImagen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.AutoRoundedCorners = true;
            btnGuardarCambios.BackColor = Color.Transparent;
            btnGuardarCambios.CustomizableEdges = customizableEdges3;
            btnGuardarCambios.DisabledState.BorderColor = Color.DarkGray;
            btnGuardarCambios.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardarCambios.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardarCambios.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardarCambios.Font = new Font("Segoe UI", 9F);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(46, 345);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnGuardarCambios.Size = new Size(225, 56);
            btnGuardarCambios.TabIndex = 13;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(171, 291);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "Precio Venta";
            txtPrecioVenta.Size = new Size(111, 27);
            txtPrecioVenta.TabIndex = 12;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(29, 291);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.PlaceholderText = "Precio Compra";
            txtPrecioCompra.Size = new Size(111, 27);
            txtPrecioCompra.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 212);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Categoria";
            txtNombre.Size = new Size(94, 27);
            txtNombre.TabIndex = 10;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(46, 212);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Codigo";
            txtCodigo.Size = new Size(94, 27);
            txtCodigo.TabIndex = 8;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.BackColor = Color.Transparent;
            chkActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkActivo.ForeColor = Color.White;
            chkActivo.Location = new Point(122, 248);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(76, 24);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = false;
            // 
            // picProducto
            // 
            picProducto.Location = new Point(89, 16);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(131, 135);
            picProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            picProducto.TabIndex = 1;
            picProducto.TabStop = false;
            // 
            // lblVistaNombre
            // 
            lblVistaNombre.AutoSize = true;
            lblVistaNombre.BackColor = Color.Transparent;
            lblVistaNombre.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblVistaNombre.ForeColor = Color.White;
            lblVistaNombre.Location = new Point(85, 180);
            lblVistaNombre.Name = "lblVistaNombre";
            lblVistaNombre.Size = new Size(167, 22);
            lblVistaNombre.TabIndex = 0;
            lblVistaNombre.Text = "Nombre Producto";
            // 
            // lbldividir
            // 
            lbldividir.AutoSize = true;
            lbldividir.BackColor = Color.Transparent;
            lbldividir.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldividir.ForeColor = Color.White;
            lbldividir.Location = new Point(146, 215);
            lbldividir.Name = "lbldividir";
            lbldividir.Size = new Size(19, 19);
            lbldividir.TabIndex = 9;
            lbldividir.Text = "|";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(412, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(204, 34);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Ver Productos";
            // 
            // UCVerProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitulo);
            Controls.Add(panelEditorProducto);
            Controls.Add(flowProductos);
            Controls.Add(txtBuscarProducto);
            Name = "UCVerProductos";
            Size = new Size(1014, 649);
            Load += UCVerProductos_Load;
            panelEditorProducto.ResumeLayout(false);
            panelEditorProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProducto;
        private FlowLayoutPanel flowProductos;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelEditorProducto;
        private PictureBox picProducto;
        private Label lblVistaNombre;
        private CheckBox chkActivo;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label lbldividir;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCambios;
        private Button button1;
        private Label lblTitulo;
    }
}
