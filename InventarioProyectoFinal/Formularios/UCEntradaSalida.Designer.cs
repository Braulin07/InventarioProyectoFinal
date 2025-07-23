namespace InventarioProyectoFinal.Formularios
{
    partial class UCEntradaSalida
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbProductos = new Guna.UI2.WinForms.Guna2ComboBox();
            txtCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            dgvCarrito = new Guna.UI2.WinForms.Guna2DataGridView();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnAgregarCarrito = new Guna.UI2.WinForms.Guna2Button();
            btnConfirmarSalida = new Guna.UI2.WinForms.Guna2Button();
            btnConfirmarEntrada = new Guna.UI2.WinForms.Guna2Button();
            panelVistaPrevia = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            picVistaPrevia = new PictureBox();
            lblStockVista = new Label();
            lblPrecioVista = new Label();
            lblNombreVista = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panelVistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVistaPrevia).BeginInit();
            SuspendLayout();
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.Transparent;
            cmbProductos.CustomizableEdges = customizableEdges1;
            cmbProductos.DrawMode = DrawMode.OwnerDrawFixed;
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbProductos.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbProductos.Font = new Font("Segoe UI", 10F);
            cmbProductos.ForeColor = Color.FromArgb(68, 88, 112);
            cmbProductos.ItemHeight = 30;
            cmbProductos.Location = new Point(430, 303);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbProductos.Size = new Size(175, 36);
            cmbProductos.TabIndex = 0;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.Transparent;
            txtCantidad.CustomizableEdges = customizableEdges3;
            txtCantidad.Font = new Font("Segoe UI", 9F);
            txtCantidad.Location = new Point(634, 293);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCantidad.Size = new Size(171, 46);
            txtCantidad.TabIndex = 1;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Indigo;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.ColumnHeadersHeight = 50;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { CodigoProducto, NombreProducto, Cantidad, PrecioVenta, SubTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCarrito.GridColor = Color.FromArgb(231, 229, 255);
            dgvCarrito.Location = new Point(30, 345);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(950, 224);
            dgvCarrito.TabIndex = 2;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCarrito.ThemeStyle.BackColor = SystemColors.Control;
            dgvCarrito.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCarrito.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCarrito.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCarrito.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCarrito.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCarrito.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCarrito.ThemeStyle.HeaderStyle.Height = 50;
            dgvCarrito.ThemeStyle.ReadOnly = true;
            dgvCarrito.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCarrito.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCarrito.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCarrito.ThemeStyle.RowsStyle.Height = 29;
            dgvCarrito.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCarrito.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Stock";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(30, 572);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(135, 27);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: $0.00";
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.CustomizableEdges = customizableEdges5;
            btnAgregarCarrito.DisabledState.BorderColor = Color.DarkGray;
            btnAgregarCarrito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregarCarrito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregarCarrito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregarCarrito.Font = new Font("Segoe UI", 9F);
            btnAgregarCarrito.ForeColor = Color.White;
            btnAgregarCarrito.Location = new Point(834, 293);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAgregarCarrito.Size = new Size(130, 46);
            btnAgregarCarrito.TabIndex = 4;
            btnAgregarCarrito.Text = "Agregar al carrito";
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // btnConfirmarSalida
            // 
            btnConfirmarSalida.AutoRoundedCorners = true;
            btnConfirmarSalida.CustomizableEdges = customizableEdges7;
            btnConfirmarSalida.DisabledState.BorderColor = Color.DarkGray;
            btnConfirmarSalida.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirmarSalida.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirmarSalida.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirmarSalida.FillColor = Color.Black;
            btnConfirmarSalida.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnConfirmarSalida.ForeColor = Color.White;
            btnConfirmarSalida.Location = new Point(532, 575);
            btnConfirmarSalida.Name = "btnConfirmarSalida";
            btnConfirmarSalida.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnConfirmarSalida.Size = new Size(221, 56);
            btnConfirmarSalida.TabIndex = 20;
            btnConfirmarSalida.Text = "Confirmar Salida";
            btnConfirmarSalida.Click += btnConfirmarSalida_Click;
            // 
            // btnConfirmarEntrada
            // 
            btnConfirmarEntrada.AutoRoundedCorners = true;
            btnConfirmarEntrada.CustomizableEdges = customizableEdges9;
            btnConfirmarEntrada.DisabledState.BorderColor = Color.DarkGray;
            btnConfirmarEntrada.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirmarEntrada.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirmarEntrada.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirmarEntrada.FillColor = Color.Black;
            btnConfirmarEntrada.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnConfirmarEntrada.ForeColor = Color.White;
            btnConfirmarEntrada.Location = new Point(759, 575);
            btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            btnConfirmarEntrada.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnConfirmarEntrada.Size = new Size(221, 56);
            btnConfirmarEntrada.TabIndex = 21;
            btnConfirmarEntrada.Text = "Confirmar Entrada";
            btnConfirmarEntrada.Click += btnConfirmarEntrada_Click;
            // 
            // panelVistaPrevia
            // 
            panelVistaPrevia.BorderRadius = 25;
            panelVistaPrevia.Controls.Add(picVistaPrevia);
            panelVistaPrevia.Controls.Add(lblStockVista);
            panelVistaPrevia.Controls.Add(lblPrecioVista);
            panelVistaPrevia.Controls.Add(lblNombreVista);
            panelVistaPrevia.CustomizableEdges = customizableEdges11;
            panelVistaPrevia.FillColor = Color.Indigo;
            panelVistaPrevia.FillColor2 = Color.Navy;
            panelVistaPrevia.FillColor4 = Color.Indigo;
            panelVistaPrevia.Location = new Point(39, 124);
            panelVistaPrevia.Name = "panelVistaPrevia";
            panelVistaPrevia.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelVistaPrevia.Size = new Size(375, 215);
            panelVistaPrevia.TabIndex = 22;
            // 
            // picVistaPrevia
            // 
            picVistaPrevia.Location = new Point(13, 13);
            picVistaPrevia.Name = "picVistaPrevia";
            picVistaPrevia.Size = new Size(153, 154);
            picVistaPrevia.SizeMode = PictureBoxSizeMode.StretchImage;
            picVistaPrevia.TabIndex = 1;
            picVistaPrevia.TabStop = false;
            // 
            // lblStockVista
            // 
            lblStockVista.AutoSize = true;
            lblStockVista.BackColor = Color.Transparent;
            lblStockVista.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockVista.ForeColor = Color.White;
            lblStockVista.Location = new Point(184, 148);
            lblStockVista.Name = "lblStockVista";
            lblStockVista.Size = new Size(58, 22);
            lblStockVista.TabIndex = 6;
            lblStockVista.Text = "Stock";
            // 
            // lblPrecioVista
            // 
            lblPrecioVista.AutoSize = true;
            lblPrecioVista.BackColor = Color.Transparent;
            lblPrecioVista.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioVista.ForeColor = Color.White;
            lblPrecioVista.Location = new Point(184, 92);
            lblPrecioVista.Name = "lblPrecioVista";
            lblPrecioVista.Size = new Size(71, 22);
            lblPrecioVista.TabIndex = 2;
            lblPrecioVista.Text = "Precio:";
            // 
            // lblNombreVista
            // 
            lblNombreVista.AutoSize = true;
            lblNombreVista.BackColor = Color.Transparent;
            lblNombreVista.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreVista.ForeColor = Color.White;
            lblNombreVista.Location = new Point(184, 32);
            lblNombreVista.Name = "lblNombreVista";
            lblNombreVista.Size = new Size(167, 22);
            lblNombreVista.TabIndex = 0;
            lblNombreVista.Text = "Nombre Producto";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(397, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(214, 34);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Entrada/Salida";
            // 
            // UCEntradaSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTitulo);
            Controls.Add(panelVistaPrevia);
            Controls.Add(btnConfirmarEntrada);
            Controls.Add(btnConfirmarSalida);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(lblTotal);
            Controls.Add(dgvCarrito);
            Controls.Add(txtCantidad);
            Controls.Add(cmbProductos);
            MinimumSize = new Size(1014, 649);
            Name = "UCEntradaSalida";
            Size = new Size(1014, 649);
            Load += UCEntradaSalida_Load;
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panelVistaPrevia.ResumeLayout(false);
            panelVistaPrevia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVistaPrevia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbProductos;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtCantidad;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCarrito;
        private Label lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnAgregarCarrito;
        private Guna.UI2.WinForms.Guna2Button btnConfirmarSalida;
        private Guna.UI2.WinForms.Guna2Button btnConfirmarEntrada;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelVistaPrevia;
        private PictureBox picVistaPrevia;
        private Label lblStockVista;
        private Label lblPrecioVista;
        private Label lblNombreVista;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn SubTotal;
        private Label lblTitulo;
    }
}
