namespace InventarioProyectoFinal.Formularios
{
    partial class UCEstadisticas
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cmbCampoFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            txtValorFiltro = new Guna.UI2.WinForms.Guna2TextBox();
            dgvMovimientos = new Guna.UI2.WinForms.Guna2DataGridView();
            CodigoProducto = new DataGridViewTextBoxColumn();
            TipoMovimiento = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            lblStock = new Label();
            lblVendido = new Label();
            lblVentas = new Label();
            lblRangoFechas = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            btnGenerarCSV = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            scottPlotBarras = new ScottPlot.FormsPlot();
            scottPlotLineas = new ScottPlot.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.Checked = true;
            dtpDesde.CustomizableEdges = customizableEdges1;
            dtpDesde.FillColor = Color.Indigo;
            dtpDesde.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dtpDesde.Format = DateTimePickerFormat.Long;
            dtpDesde.Location = new Point(75, 23);
            dtpDesde.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDesde.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpDesde.Size = new Size(250, 45);
            dtpDesde.TabIndex = 3;
            dtpDesde.Value = new DateTime(2025, 7, 6, 19, 55, 27, 230);
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // dtpHasta
            // 
            dtpHasta.Checked = true;
            dtpHasta.CustomizableEdges = customizableEdges3;
            dtpHasta.FillColor = Color.Indigo;
            dtpHasta.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpHasta.Format = DateTimePickerFormat.Long;
            dtpHasta.Location = new Point(435, 23);
            dtpHasta.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpHasta.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpHasta.Size = new Size(250, 45);
            dtpHasta.TabIndex = 4;
            dtpHasta.Value = new DateTime(2025, 7, 6, 19, 55, 27, 230);
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // cmbCampoFiltro
            // 
            cmbCampoFiltro.BackColor = Color.Transparent;
            cmbCampoFiltro.BorderColor = Color.Indigo;
            cmbCampoFiltro.CustomizableEdges = customizableEdges5;
            cmbCampoFiltro.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCampoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCampoFiltro.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbCampoFiltro.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbCampoFiltro.Font = new Font("Segoe UI", 10F);
            cmbCampoFiltro.ForeColor = Color.FromArgb(68, 88, 112);
            cmbCampoFiltro.ItemHeight = 30;
            cmbCampoFiltro.Location = new Point(75, 94);
            cmbCampoFiltro.Name = "cmbCampoFiltro";
            cmbCampoFiltro.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbCampoFiltro.Size = new Size(250, 36);
            cmbCampoFiltro.TabIndex = 5;
            // 
            // txtValorFiltro
            // 
            txtValorFiltro.BorderColor = Color.Indigo;
            txtValorFiltro.CustomizableEdges = customizableEdges7;
            txtValorFiltro.DefaultText = "";
            txtValorFiltro.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtValorFiltro.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtValorFiltro.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtValorFiltro.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtValorFiltro.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtValorFiltro.Font = new Font("Segoe UI", 9F);
            txtValorFiltro.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtValorFiltro.Location = new Point(435, 94);
            txtValorFiltro.Margin = new Padding(3, 4, 3, 4);
            txtValorFiltro.Name = "txtValorFiltro";
            txtValorFiltro.PlaceholderText = "";
            txtValorFiltro.SelectedText = "";
            txtValorFiltro.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtValorFiltro.Size = new Size(250, 60);
            txtValorFiltro.TabIndex = 6;
            txtValorFiltro.TextChanged += txtValorFiltro_TextChanged;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovimientos.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Indigo;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMovimientos.ColumnHeadersHeight = 50;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { CodigoProducto, TipoMovimiento, Cantidad, Subtotal, Fecha, Usuario });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMovimientos.GridColor = Color.FromArgb(231, 229, 255);
            dgvMovimientos.Location = new Point(15, 407);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersVisible = false;
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.Size = new Size(978, 239);
            dgvMovimientos.TabIndex = 9;
            dgvMovimientos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvMovimientos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvMovimientos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvMovimientos.ThemeStyle.BackColor = Color.White;
            dgvMovimientos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvMovimientos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvMovimientos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMovimientos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvMovimientos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvMovimientos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMovimientos.ThemeStyle.HeaderStyle.Height = 50;
            dgvMovimientos.ThemeStyle.ReadOnly = true;
            dgvMovimientos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMovimientos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMovimientos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMovimientos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMovimientos.ThemeStyle.RowsStyle.Height = 29;
            dgvMovimientos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMovimientos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            // 
            // TipoMovimiento
            // 
            TipoMovimiento.HeaderText = "Tipo Movimiento";
            TipoMovimiento.MinimumWidth = 6;
            TipoMovimiento.Name = "TipoMovimiento";
            TipoMovimiento.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(15, 370);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(63, 22);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock:";
            // 
            // lblVendido
            // 
            lblVendido.AutoSize = true;
            lblVendido.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblVendido.Location = new Point(280, 370);
            lblVendido.Name = "lblVendido";
            lblVendido.Size = new Size(90, 22);
            lblVendido.TabIndex = 11;
            lblVendido.Text = "Vendido:";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblVentas.Location = new Point(532, 370);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(75, 22);
            lblVentas.TabIndex = 12;
            lblVentas.Text = "Ventas:";
            // 
            // lblRangoFechas
            // 
            lblRangoFechas.AutoSize = true;
            lblRangoFechas.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblRangoFechas.Location = new Point(784, 370);
            lblRangoFechas.Name = "lblRangoFechas";
            lblRangoFechas.Size = new Size(79, 22);
            lblRangoFechas.TabIndex = 14;
            lblRangoFechas.Text = "Fechas:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(15, 32);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(54, 20);
            lblDesde.TabIndex = 15;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(379, 32);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(50, 20);
            lblHasta.TabIndex = 16;
            lblHasta.Text = "Hasta:";
            // 
            // btnGenerarCSV
            // 
            btnGenerarCSV.Animated = true;
            btnGenerarCSV.AutoRoundedCorners = true;
            btnGenerarCSV.BackColor = Color.Transparent;
            btnGenerarCSV.BorderColor = Color.Indigo;
            btnGenerarCSV.BorderRadius = 27;
            btnGenerarCSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btnGenerarCSV.CustomizableEdges = customizableEdges9;
            btnGenerarCSV.DisabledState.BorderColor = Color.DarkGray;
            btnGenerarCSV.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGenerarCSV.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGenerarCSV.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGenerarCSV.FillColor = Color.Black;
            btnGenerarCSV.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnGenerarCSV.ForeColor = Color.White;
            btnGenerarCSV.Location = new Point(740, 58);
            btnGenerarCSV.Name = "btnGenerarCSV";
            btnGenerarCSV.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnGenerarCSV.Size = new Size(214, 56);
            btnGenerarCSV.TabIndex = 17;
            btnGenerarCSV.Text = "Generar Reporte";
            btnGenerarCSV.Click += btnGenerarCSV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 94);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 19;
            label1.Text = "Criterio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 110);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 20;
            label2.Text = "Filtrar:";
            // 
            // scottPlotBarras
            // 
            scottPlotBarras.Location = new Point(38, 162);
            scottPlotBarras.Margin = new Padding(5, 4, 5, 4);
            scottPlotBarras.Name = "scottPlotBarras";
            scottPlotBarras.Size = new Size(467, 186);
            scottPlotBarras.TabIndex = 21;
            // 
            // scottPlotLineas
            // 
            scottPlotLineas.Location = new Point(515, 162);
            scottPlotLineas.Margin = new Padding(5, 4, 5, 4);
            scottPlotLineas.Name = "scottPlotLineas";
            scottPlotLineas.Size = new Size(478, 191);
            scottPlotLineas.TabIndex = 22;
            // 
            // UCEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(scottPlotLineas);
            Controls.Add(scottPlotBarras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerarCSV);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblRangoFechas);
            Controls.Add(lblVentas);
            Controls.Add(lblVendido);
            Controls.Add(lblStock);
            Controls.Add(dgvMovimientos);
            Controls.Add(txtValorFiltro);
            Controls.Add(cmbCampoFiltro);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Name = "UCEstadisticas";
            Size = new Size(1014, 649);
            Load += UCEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCampoFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtValorFiltro;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMovimientos;
        private Label lblStock;
        private Label lblVendido;
        private Label lblVentas;
        private Label lblRangoFechas;
        
        private Label lblDesde;
        private Label lblHasta;
        private Guna.UI2.WinForms.Guna2Button btnGenerarCSV;
        private Label label1;
        private Label label2;
        private ScottPlot.FormsPlot scottPlotBarras;
        private ScottPlot.FormsPlot scottPlotLineas;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn TipoMovimiento;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Usuario;
    }
}
