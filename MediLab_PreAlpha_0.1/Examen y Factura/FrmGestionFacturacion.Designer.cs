namespace CapaDatos
{
    partial class FrmGestionFacturacion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnLimpiar = new FrameworkTest.SATAButton();
			this.btnAgregar = new FrameworkTest.SATAButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.chkFecha = new System.Windows.Forms.CheckBox();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDNI = new Sunny.UI.UITextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSolicitud = new Sunny.UI.UITextBox();
			this.txtIDFactura = new Sunny.UI.UITextBox();
			this.dgvGestionFactura = new System.Windows.Forms.DataGridView();
			this.IDFACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDSOLICITUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnEnviarCorreo = new FrameworkTest.SATAButton();
			this.btnImprimir = new FrameworkTest.SATAButton();
			this.btnAnular = new FrameworkTest.SATAButton();
			this.btnReactivar = new FrameworkTest.SATAButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGestionFactura)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.btnLimpiar.ButtonText = "Limpiar filtros";
			this.btnLimpiar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnLimpiar.CheckedForeColor = System.Drawing.Color.White;
			this.btnLimpiar.CheckedImageTint = System.Drawing.Color.White;
			this.btnLimpiar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnLimpiar.HoverForeColor = System.Drawing.Color.White;
			this.btnLimpiar.HoverImage = null;
			this.btnLimpiar.HoverImageTint = System.Drawing.Color.White;
			this.btnLimpiar.HoverOutline = System.Drawing.Color.Empty;
			this.btnLimpiar.Image = null;
			this.btnLimpiar.ImageAutoCenter = false;
			this.btnLimpiar.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnLimpiar.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnLimpiar.ImageTint = System.Drawing.Color.White;
			this.btnLimpiar.IsToggleButton = false;
			this.btnLimpiar.IsToggled = false;
			this.btnLimpiar.Location = new System.Drawing.Point(965, 54);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.btnLimpiar.NormalForeColor = System.Drawing.Color.White;
			this.btnLimpiar.NormalOutline = System.Drawing.Color.Empty;
			this.btnLimpiar.OutlineThickness = 2F;
			this.btnLimpiar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnLimpiar.PressedForeColor = System.Drawing.Color.White;
			this.btnLimpiar.PressedImageTint = System.Drawing.Color.White;
			this.btnLimpiar.PressedOutline = System.Drawing.Color.Empty;
			this.btnLimpiar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnLimpiar.Size = new System.Drawing.Size(224, 52);
			this.btnLimpiar.TabIndex = 34;
			this.btnLimpiar.TextAutoCenter = true;
			this.btnLimpiar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
			this.btnAgregar.ButtonText = "Agregar";
			this.btnAgregar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregar.CheckedForeColor = System.Drawing.Color.White;
			this.btnAgregar.CheckedImageTint = System.Drawing.Color.White;
			this.btnAgregar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnAgregar.HoverForeColor = System.Drawing.Color.White;
			this.btnAgregar.HoverImage = null;
			this.btnAgregar.HoverImageTint = System.Drawing.Color.White;
			this.btnAgregar.HoverOutline = System.Drawing.Color.Empty;
			this.btnAgregar.Image = null;
			this.btnAgregar.ImageAutoCenter = false;
			this.btnAgregar.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnAgregar.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnAgregar.ImageTint = System.Drawing.Color.White;
			this.btnAgregar.IsToggleButton = false;
			this.btnAgregar.IsToggled = false;
			this.btnAgregar.Location = new System.Drawing.Point(71, 54);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
			this.btnAgregar.NormalForeColor = System.Drawing.Color.White;
			this.btnAgregar.NormalOutline = System.Drawing.Color.Empty;
			this.btnAgregar.OutlineThickness = 2F;
			this.btnAgregar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnAgregar.PressedForeColor = System.Drawing.Color.White;
			this.btnAgregar.PressedImageTint = System.Drawing.Color.White;
			this.btnAgregar.PressedOutline = System.Drawing.Color.Empty;
			this.btnAgregar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnAgregar.Size = new System.Drawing.Size(224, 52);
			this.btnAgregar.TabIndex = 31;
			this.btnAgregar.TextAutoCenter = true;
			this.btnAgregar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDNI);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSolicitud);
			this.groupBox1.Controls.Add(this.txtIDFactura);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(37, 145);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(1265, 110);
			this.groupBox1.TabIndex = 35;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros de búsqueda";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dtpHasta);
			this.groupBox2.Controls.Add(this.chkFecha);
			this.groupBox2.Controls.Add(this.dtpDesde);
			this.groupBox2.Location = new System.Drawing.Point(660, 30);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(365, 65);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fecha de Emisión";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(169, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 22);
			this.label5.TabIndex = 54;
			this.label5.Text = "a";
			// 
			// dtpHasta
			// 
			this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpHasta.Location = new System.Drawing.Point(207, 28);
			this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpHasta.Name = "dtpHasta";
			this.dtpHasta.Size = new System.Drawing.Size(136, 30);
			this.dtpHasta.TabIndex = 53;
			this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
			// 
			// chkFecha
			// 
			this.chkFecha.AutoSize = true;
			this.chkFecha.Location = new System.Drawing.Point(231, 1);
			this.chkFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkFecha.Name = "chkFecha";
			this.chkFecha.Size = new System.Drawing.Size(18, 17);
			this.chkFecha.TabIndex = 52;
			this.chkFecha.UseVisualStyleBackColor = true;
			this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
			// 
			// dtpDesde
			// 
			this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDesde.Location = new System.Drawing.Point(16, 30);
			this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(136, 30);
			this.dtpDesde.TabIndex = 0;
			this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(461, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 22);
			this.label3.TabIndex = 25;
			this.label3.Text = "DNI";
			// 
			// txtDNI
			// 
			this.txtDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtDNI.Location = new System.Drawing.Point(463, 57);
			this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDNI.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Padding = new System.Windows.Forms.Padding(5);
			this.txtDNI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtDNI.RectSize = 2;
			this.txtDNI.ShowText = false;
			this.txtDNI.Size = new System.Drawing.Size(163, 38);
			this.txtDNI.TabIndex = 24;
			this.txtDNI.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtDNI.Watermark = "";
			this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(233, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 22);
			this.label2.TabIndex = 23;
			this.label2.Text = "IDSolicitud";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 22);
			this.label1.TabIndex = 21;
			this.label1.Text = "IDFactura";
			// 
			// txtSolicitud
			// 
			this.txtSolicitud.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtSolicitud.Location = new System.Drawing.Point(235, 57);
			this.txtSolicitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSolicitud.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtSolicitud.Name = "txtSolicitud";
			this.txtSolicitud.Padding = new System.Windows.Forms.Padding(5);
			this.txtSolicitud.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtSolicitud.RectSize = 2;
			this.txtSolicitud.ShowText = false;
			this.txtSolicitud.Size = new System.Drawing.Size(204, 38);
			this.txtSolicitud.TabIndex = 22;
			this.txtSolicitud.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtSolicitud.Watermark = "";
			this.txtSolicitud.TextChanged += new System.EventHandler(this.txtSolicitud_TextChanged);
			this.txtSolicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSolicitud_KeyPress);
			// 
			// txtIDFactura
			// 
			this.txtIDFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIDFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtIDFactura.Location = new System.Drawing.Point(7, 57);
			this.txtIDFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtIDFactura.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtIDFactura.Name = "txtIDFactura";
			this.txtIDFactura.Padding = new System.Windows.Forms.Padding(5);
			this.txtIDFactura.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtIDFactura.RectSize = 2;
			this.txtIDFactura.ShowText = false;
			this.txtIDFactura.Size = new System.Drawing.Size(204, 38);
			this.txtIDFactura.TabIndex = 20;
			this.txtIDFactura.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtIDFactura.Watermark = "";
			this.txtIDFactura.TextChanged += new System.EventHandler(this.txtIDFactura_TextChanged);
			this.txtIDFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDFactura_KeyPress);
			// 
			// dgvGestionFactura
			// 
			this.dgvGestionFactura.AllowUserToAddRows = false;
			this.dgvGestionFactura.AllowUserToDeleteRows = false;
			this.dgvGestionFactura.AllowUserToResizeRows = false;
			this.dgvGestionFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGestionFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGestionFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvGestionFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvGestionFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvGestionFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGestionFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFACTURA,
            this.IDSOLICITUD,
            this.FECHA_EMISION,
            this.DNI,
            this.NOMBRES,
            this.APELLIDOS,
            this.TOTAL,
            this.ESTADO});
			this.dgvGestionFactura.EnableHeadersVisualStyles = false;
			this.dgvGestionFactura.Location = new System.Drawing.Point(37, 284);
			this.dgvGestionFactura.Margin = new System.Windows.Forms.Padding(4);
			this.dgvGestionFactura.MultiSelect = false;
			this.dgvGestionFactura.Name = "dgvGestionFactura";
			this.dgvGestionFactura.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvGestionFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvGestionFactura.RowHeadersVisible = false;
			this.dgvGestionFactura.RowHeadersWidth = 51;
			this.dgvGestionFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvGestionFactura.Size = new System.Drawing.Size(1265, 402);
			this.dgvGestionFactura.TabIndex = 43;
			this.dgvGestionFactura.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGestionFactura_CellFormatting);
			this.dgvGestionFactura.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGestionFactura_DataBindingComplete);
			this.dgvGestionFactura.SelectionChanged += new System.EventHandler(this.dgvGestionFactura_SelectionChanged);
			// 
			// IDFACTURA
			// 
			this.IDFACTURA.DataPropertyName = "IDFACTURA";
			this.IDFACTURA.HeaderText = "IdFactura";
			this.IDFACTURA.MinimumWidth = 6;
			this.IDFACTURA.Name = "IDFACTURA";
			this.IDFACTURA.ReadOnly = true;
			// 
			// IDSOLICITUD
			// 
			this.IDSOLICITUD.DataPropertyName = "IDSOLICITUDEXAMEN";
			this.IDSOLICITUD.HeaderText = "IdSolicitud";
			this.IDSOLICITUD.MinimumWidth = 6;
			this.IDSOLICITUD.Name = "IDSOLICITUD";
			this.IDSOLICITUD.ReadOnly = true;
			// 
			// FECHA_EMISION
			// 
			this.FECHA_EMISION.DataPropertyName = "FECHA_EMISION";
			this.FECHA_EMISION.HeaderText = "FechaEmision";
			this.FECHA_EMISION.MinimumWidth = 6;
			this.FECHA_EMISION.Name = "FECHA_EMISION";
			this.FECHA_EMISION.ReadOnly = true;
			// 
			// DNI
			// 
			this.DNI.DataPropertyName = "DNI";
			this.DNI.HeaderText = "DNI";
			this.DNI.MinimumWidth = 6;
			this.DNI.Name = "DNI";
			this.DNI.ReadOnly = true;
			// 
			// NOMBRES
			// 
			this.NOMBRES.DataPropertyName = "NOMBRES";
			this.NOMBRES.HeaderText = "Nombres";
			this.NOMBRES.MinimumWidth = 6;
			this.NOMBRES.Name = "NOMBRES";
			this.NOMBRES.ReadOnly = true;
			// 
			// APELLIDOS
			// 
			this.APELLIDOS.DataPropertyName = "APELLIDOS";
			this.APELLIDOS.HeaderText = "Apellidos";
			this.APELLIDOS.MinimumWidth = 6;
			this.APELLIDOS.Name = "APELLIDOS";
			this.APELLIDOS.ReadOnly = true;
			// 
			// TOTAL
			// 
			this.TOTAL.DataPropertyName = "TOTAL";
			this.TOTAL.HeaderText = "Total";
			this.TOTAL.MinimumWidth = 6;
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			// 
			// ESTADO
			// 
			this.ESTADO.DataPropertyName = "ESTADO";
			this.ESTADO.HeaderText = "Estado";
			this.ESTADO.MinimumWidth = 6;
			this.ESTADO.Name = "ESTADO";
			this.ESTADO.ReadOnly = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.btnEnviarCorreo, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnImprimir, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 752);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1341, 66);
			this.tableLayoutPanel2.TabIndex = 179;
			// 
			// btnEnviarCorreo
			// 
			this.btnEnviarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
			this.btnEnviarCorreo.ButtonText = "Enviar por Correo";
			this.btnEnviarCorreo.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnEnviarCorreo.CheckedForeColor = System.Drawing.Color.White;
			this.btnEnviarCorreo.CheckedImageTint = System.Drawing.Color.White;
			this.btnEnviarCorreo.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEnviarCorreo.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnEnviarCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviarCorreo.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnEnviarCorreo.HoverForeColor = System.Drawing.Color.White;
			this.btnEnviarCorreo.HoverImage = null;
			this.btnEnviarCorreo.HoverImageTint = System.Drawing.Color.White;
			this.btnEnviarCorreo.HoverOutline = System.Drawing.Color.Empty;
			this.btnEnviarCorreo.Image = null;
			this.btnEnviarCorreo.ImageAutoCenter = false;
			this.btnEnviarCorreo.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnEnviarCorreo.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnEnviarCorreo.ImageTint = System.Drawing.Color.White;
			this.btnEnviarCorreo.IsToggleButton = false;
			this.btnEnviarCorreo.IsToggled = false;
			this.btnEnviarCorreo.Location = new System.Drawing.Point(459, 4);
			this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnEnviarCorreo.Name = "btnEnviarCorreo";
			this.btnEnviarCorreo.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
			this.btnEnviarCorreo.NormalForeColor = System.Drawing.Color.White;
			this.btnEnviarCorreo.NormalOutline = System.Drawing.Color.Empty;
			this.btnEnviarCorreo.OutlineThickness = 2F;
			this.btnEnviarCorreo.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnEnviarCorreo.PressedForeColor = System.Drawing.Color.White;
			this.btnEnviarCorreo.PressedImageTint = System.Drawing.Color.White;
			this.btnEnviarCorreo.PressedOutline = System.Drawing.Color.Empty;
			this.btnEnviarCorreo.Rounding = new System.Windows.Forms.Padding(0);
			this.btnEnviarCorreo.Size = new System.Drawing.Size(204, 43);
			this.btnEnviarCorreo.TabIndex = 153;
			this.btnEnviarCorreo.TextAutoCenter = true;
			this.btnEnviarCorreo.TextOffset = new System.Drawing.Point(0, 0);
			this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.btnImprimir.ButtonText = "Imprimir";
			this.btnImprimir.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnImprimir.CheckedForeColor = System.Drawing.Color.White;
			this.btnImprimir.CheckedImageTint = System.Drawing.Color.White;
			this.btnImprimir.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImprimir.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnImprimir.HoverForeColor = System.Drawing.Color.White;
			this.btnImprimir.HoverImage = null;
			this.btnImprimir.HoverImageTint = System.Drawing.Color.White;
			this.btnImprimir.HoverOutline = System.Drawing.Color.Empty;
			this.btnImprimir.Image = null;
			this.btnImprimir.ImageAutoCenter = false;
			this.btnImprimir.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnImprimir.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnImprimir.ImageTint = System.Drawing.Color.White;
			this.btnImprimir.IsToggleButton = false;
			this.btnImprimir.IsToggled = false;
			this.btnImprimir.Location = new System.Drawing.Point(677, 4);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
			this.btnImprimir.NormalForeColor = System.Drawing.Color.White;
			this.btnImprimir.NormalOutline = System.Drawing.Color.Empty;
			this.btnImprimir.OutlineThickness = 2F;
			this.btnImprimir.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.btnImprimir.PressedForeColor = System.Drawing.Color.White;
			this.btnImprimir.PressedImageTint = System.Drawing.Color.White;
			this.btnImprimir.PressedOutline = System.Drawing.Color.Empty;
			this.btnImprimir.Rounding = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Size = new System.Drawing.Size(204, 43);
			this.btnImprimir.TabIndex = 152;
			this.btnImprimir.TextAutoCenter = true;
			this.btnImprimir.TextOffset = new System.Drawing.Point(0, 0);
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// btnAnular
			// 
			this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnAnular.ButtonText = "Anular Factura";
			this.btnAnular.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAnular.CheckedForeColor = System.Drawing.Color.White;
			this.btnAnular.CheckedImageTint = System.Drawing.Color.White;
			this.btnAnular.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnular.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnular.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnAnular.HoverForeColor = System.Drawing.Color.White;
			this.btnAnular.HoverImage = null;
			this.btnAnular.HoverImageTint = System.Drawing.Color.White;
			this.btnAnular.HoverOutline = System.Drawing.Color.Empty;
			this.btnAnular.Image = null;
			this.btnAnular.ImageAutoCenter = false;
			this.btnAnular.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnAnular.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnAnular.ImageTint = System.Drawing.Color.White;
			this.btnAnular.IsToggleButton = false;
			this.btnAnular.IsToggled = false;
			this.btnAnular.Location = new System.Drawing.Point(361, 54);
			this.btnAnular.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnAnular.Name = "btnAnular";
			this.btnAnular.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnAnular.NormalForeColor = System.Drawing.Color.White;
			this.btnAnular.NormalOutline = System.Drawing.Color.Empty;
			this.btnAnular.OutlineThickness = 2F;
			this.btnAnular.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnAnular.PressedForeColor = System.Drawing.Color.White;
			this.btnAnular.PressedImageTint = System.Drawing.Color.White;
			this.btnAnular.PressedOutline = System.Drawing.Color.Empty;
			this.btnAnular.Rounding = new System.Windows.Forms.Padding(0);
			this.btnAnular.Size = new System.Drawing.Size(224, 52);
			this.btnAnular.TabIndex = 33;
			this.btnAnular.TextAutoCenter = true;
			this.btnAnular.TextOffset = new System.Drawing.Point(0, 0);
			this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
			// 
			// btnReactivar
			// 
			this.btnReactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(210)))), ((int)(((byte)(128)))));
			this.btnReactivar.ButtonText = "Reactivar Factura";
			this.btnReactivar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnReactivar.CheckedForeColor = System.Drawing.Color.White;
			this.btnReactivar.CheckedImageTint = System.Drawing.Color.White;
			this.btnReactivar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnReactivar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReactivar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnReactivar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReactivar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnReactivar.HoverForeColor = System.Drawing.Color.White;
			this.btnReactivar.HoverImage = null;
			this.btnReactivar.HoverImageTint = System.Drawing.Color.White;
			this.btnReactivar.HoverOutline = System.Drawing.Color.Empty;
			this.btnReactivar.Image = null;
			this.btnReactivar.ImageAutoCenter = false;
			this.btnReactivar.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnReactivar.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnReactivar.ImageTint = System.Drawing.Color.White;
			this.btnReactivar.IsToggleButton = false;
			this.btnReactivar.IsToggled = false;
			this.btnReactivar.Location = new System.Drawing.Point(665, 54);
			this.btnReactivar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnReactivar.Name = "btnReactivar";
			this.btnReactivar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(210)))), ((int)(((byte)(128)))));
			this.btnReactivar.NormalForeColor = System.Drawing.Color.White;
			this.btnReactivar.NormalOutline = System.Drawing.Color.Empty;
			this.btnReactivar.OutlineThickness = 2F;
			this.btnReactivar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnReactivar.PressedForeColor = System.Drawing.Color.White;
			this.btnReactivar.PressedImageTint = System.Drawing.Color.White;
			this.btnReactivar.PressedOutline = System.Drawing.Color.Empty;
			this.btnReactivar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnReactivar.Size = new System.Drawing.Size(224, 52);
			this.btnReactivar.TabIndex = 180;
			this.btnReactivar.TextAutoCenter = true;
			this.btnReactivar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
			// 
			// FrmGestionFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1341, 818);
			this.Controls.Add(this.btnReactivar);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.dgvGestionFactura);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnAnular);
			this.Controls.Add(this.btnAgregar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.Name = "FrmGestionFacturacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmFacturacion";
			this.Load += new System.EventHandler(this.FrmGestionFacturacion_Load);
			this.Click += new System.EventHandler(this.FrmGestionFacturacion_Click);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGestionFactura)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private FrameworkTest.SATAButton btnLimpiar;
        private FrameworkTest.SATAButton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txtSolicitud;
        private Sunny.UI.UITextBox txtIDFactura;
        private System.Windows.Forms.DataGridView dgvGestionFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FrameworkTest.SATAButton btnEnviarCorreo;
        private FrameworkTest.SATAButton btnImprimir;
        private FrameworkTest.SATAButton btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFACTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSOLICITUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private FrameworkTest.SATAButton btnReactivar;
    }
}