namespace CapaPresentacion.Formularios
{
	partial class FrmSolicitud
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnEliminar = new FrameworkTest.SATAButton();
			this.btnModificar = new FrameworkTest.SATAButton();
			this.btnAgregar = new FrameworkTest.SATAButton();
			this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DNIPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DNIMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkFecha = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBNombres = new Sunny.UI.UITextBox();
			this.txtBDNI = new Sunny.UI.UITextBox();
			this.btnLimpiar = new FrameworkTest.SATAButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnVolver = new FrameworkTest.SATAButton();
			this.btnInsertar = new FrameworkTest.SATAButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnEliminar.ButtonText = "Eliminar";
			this.btnEliminar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnEliminar.CheckedForeColor = System.Drawing.Color.White;
			this.btnEliminar.CheckedImageTint = System.Drawing.Color.White;
			this.btnEliminar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnEliminar.HoverForeColor = System.Drawing.Color.White;
			this.btnEliminar.HoverImage = null;
			this.btnEliminar.HoverImageTint = System.Drawing.Color.White;
			this.btnEliminar.HoverOutline = System.Drawing.Color.Empty;
			this.btnEliminar.Image = null;
			this.btnEliminar.ImageAutoCenter = false;
			this.btnEliminar.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnEliminar.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnEliminar.ImageTint = System.Drawing.Color.White;
			this.btnEliminar.IsToggleButton = false;
			this.btnEliminar.IsToggled = false;
			this.btnEliminar.Location = new System.Drawing.Point(596, 25);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnEliminar.NormalForeColor = System.Drawing.Color.White;
			this.btnEliminar.NormalOutline = System.Drawing.Color.Empty;
			this.btnEliminar.OutlineThickness = 2F;
			this.btnEliminar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnEliminar.PressedForeColor = System.Drawing.Color.White;
			this.btnEliminar.PressedImageTint = System.Drawing.Color.White;
			this.btnEliminar.PressedOutline = System.Drawing.Color.Empty;
			this.btnEliminar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnEliminar.Size = new System.Drawing.Size(224, 52);
			this.btnEliminar.TabIndex = 22;
			this.btnEliminar.TextAutoCenter = true;
			this.btnEliminar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
			this.btnModificar.ButtonText = "Modificar";
			this.btnModificar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnModificar.CheckedForeColor = System.Drawing.Color.White;
			this.btnModificar.CheckedImageTint = System.Drawing.Color.White;
			this.btnModificar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnModificar.HoverForeColor = System.Drawing.Color.White;
			this.btnModificar.HoverImage = null;
			this.btnModificar.HoverImageTint = System.Drawing.Color.White;
			this.btnModificar.HoverOutline = System.Drawing.Color.Empty;
			this.btnModificar.Image = null;
			this.btnModificar.ImageAutoCenter = false;
			this.btnModificar.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnModificar.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnModificar.ImageTint = System.Drawing.Color.White;
			this.btnModificar.IsToggleButton = false;
			this.btnModificar.IsToggled = false;
			this.btnModificar.Location = new System.Drawing.Point(318, 25);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
			this.btnModificar.NormalForeColor = System.Drawing.Color.White;
			this.btnModificar.NormalOutline = System.Drawing.Color.Empty;
			this.btnModificar.OutlineThickness = 2F;
			this.btnModificar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnModificar.PressedForeColor = System.Drawing.Color.White;
			this.btnModificar.PressedImageTint = System.Drawing.Color.White;
			this.btnModificar.PressedOutline = System.Drawing.Color.Empty;
			this.btnModificar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnModificar.Size = new System.Drawing.Size(224, 52);
			this.btnModificar.TabIndex = 21;
			this.btnModificar.TextAutoCenter = true;
			this.btnModificar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
			this.btnAgregar.Location = new System.Drawing.Point(39, 25);
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
			this.btnAgregar.TabIndex = 20;
			this.btnAgregar.TextAutoCenter = true;
			this.btnAgregar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// dgvSolicitudes
			// 
			this.dgvSolicitudes.AllowUserToAddRows = false;
			this.dgvSolicitudes.AllowUserToDeleteRows = false;
			this.dgvSolicitudes.AllowUserToResizeRows = false;
			this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FechaSolicitud,
            this.IDPersona,
            this.DNIPaciente,
            this.Paciente,
            this.IDMedico,
            this.DNIMedico,
            this.Medico,
            this.Estado});
			this.dgvSolicitudes.EnableHeadersVisualStyles = false;
			this.dgvSolicitudes.Location = new System.Drawing.Point(32, 273);
			this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(4);
			this.dgvSolicitudes.MultiSelect = false;
			this.dgvSolicitudes.Name = "dgvSolicitudes";
			this.dgvSolicitudes.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSolicitudes.RowHeadersVisible = false;
			this.dgvSolicitudes.RowHeadersWidth = 51;
			this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSolicitudes.Size = new System.Drawing.Size(1084, 450);
			this.dgvSolicitudes.TabIndex = 25;
			this.dgvSolicitudes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellDoubleClick);
			this.dgvSolicitudes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSolicitudes_CellMouseDown);
			this.dgvSolicitudes.SelectionChanged += new System.EventHandler(this.dgvSolicitudes_SelectionChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.FillWeight = 61.17647F;
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 50;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// FechaSolicitud
			// 
			this.FechaSolicitud.DataPropertyName = "FechaSolicitud";
			this.FechaSolicitud.FillWeight = 61.17647F;
			this.FechaSolicitud.HeaderText = "FechaSolicitud";
			this.FechaSolicitud.MinimumWidth = 120;
			this.FechaSolicitud.Name = "FechaSolicitud";
			this.FechaSolicitud.ReadOnly = true;
			// 
			// IDPersona
			// 
			this.IDPersona.DataPropertyName = "IDPersona";
			this.IDPersona.HeaderText = "IDPersona";
			this.IDPersona.MinimumWidth = 6;
			this.IDPersona.Name = "IDPersona";
			this.IDPersona.ReadOnly = true;
			this.IDPersona.Visible = false;
			// 
			// DNIPaciente
			// 
			this.DNIPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.DNIPaciente.DataPropertyName = "DNIPaciente";
			this.DNIPaciente.FillWeight = 488.2353F;
			this.DNIPaciente.HeaderText = "DNI Paciente";
			this.DNIPaciente.MinimumWidth = 120;
			this.DNIPaciente.Name = "DNIPaciente";
			this.DNIPaciente.ReadOnly = true;
			this.DNIPaciente.Width = 120;
			// 
			// Paciente
			// 
			this.Paciente.DataPropertyName = "Paciente";
			this.Paciente.FillWeight = 61.17647F;
			this.Paciente.HeaderText = "Paciente";
			this.Paciente.MinimumWidth = 200;
			this.Paciente.Name = "Paciente";
			this.Paciente.ReadOnly = true;
			// 
			// IDMedico
			// 
			this.IDMedico.DataPropertyName = "IDMedico";
			this.IDMedico.HeaderText = "IDMedico";
			this.IDMedico.MinimumWidth = 6;
			this.IDMedico.Name = "IDMedico";
			this.IDMedico.ReadOnly = true;
			this.IDMedico.Visible = false;
			// 
			// DNIMedico
			// 
			this.DNIMedico.DataPropertyName = "DNIMedico";
			this.DNIMedico.HeaderText = "DNIMedico";
			this.DNIMedico.MinimumWidth = 6;
			this.DNIMedico.Name = "DNIMedico";
			this.DNIMedico.ReadOnly = true;
			this.DNIMedico.Visible = false;
			// 
			// Medico
			// 
			this.Medico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Medico.DataPropertyName = "Medico";
			this.Medico.FillWeight = 61.17647F;
			this.Medico.HeaderText = "Médico";
			this.Medico.MinimumWidth = 200;
			this.Medico.Name = "Medico";
			this.Medico.ReadOnly = true;
			this.Medico.Width = 200;
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "Estado";
			this.Estado.FillWeight = 61.17647F;
			this.Estado.HeaderText = "Estado";
			this.Estado.MinimumWidth = 80;
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtBNombres);
			this.groupBox1.Controls.Add(this.txtBDNI);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(29, 123);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1087, 123);
			this.groupBox1.TabIndex = 35;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros de búsqueda";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkFecha);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dtpHasta);
			this.groupBox2.Controls.Add(this.dtpDesde);
			this.groupBox2.Location = new System.Drawing.Point(639, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(365, 65);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fecha de Solicitud";
			// 
			// chkFecha
			// 
			this.chkFecha.AutoSize = true;
			this.chkFecha.Location = new System.Drawing.Point(231, 1);
			this.chkFecha.Name = "chkFecha";
			this.chkFecha.Size = new System.Drawing.Size(18, 17);
			this.chkFecha.TabIndex = 52;
			this.chkFecha.UseVisualStyleBackColor = true;
			this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(169, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 22);
			this.label5.TabIndex = 51;
			this.label5.Text = "a";
			// 
			// dtpHasta
			// 
			this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpHasta.Location = new System.Drawing.Point(207, 29);
			this.dtpHasta.Name = "dtpHasta";
			this.dtpHasta.Size = new System.Drawing.Size(136, 30);
			this.dtpHasta.TabIndex = 1;
			this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
			// 
			// dtpDesde
			// 
			this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDesde.Location = new System.Drawing.Point(16, 29);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(136, 30);
			this.dtpDesde.TabIndex = 0;
			this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(311, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 22);
			this.label2.TabIndex = 23;
			this.label2.Text = "Nombre del Paciente";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 22);
			this.label1.TabIndex = 21;
			this.label1.Text = "DNI Paciente";
			// 
			// txtBNombres
			// 
			this.txtBNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtBNombres.Location = new System.Drawing.Point(312, 57);
			this.txtBNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBNombres.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtBNombres.Name = "txtBNombres";
			this.txtBNombres.Padding = new System.Windows.Forms.Padding(5);
			this.txtBNombres.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtBNombres.RectSize = 2;
			this.txtBNombres.ShowText = false;
			this.txtBNombres.Size = new System.Drawing.Size(204, 38);
			this.txtBNombres.TabIndex = 22;
			this.txtBNombres.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtBNombres.Watermark = "";
			this.txtBNombres.TextChanged += new System.EventHandler(this.txtBNombres_TextChanged);
			this.txtBNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNombres_KeyPress);
			// 
			// txtBDNI
			// 
			this.txtBDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtBDNI.Location = new System.Drawing.Point(7, 57);
			this.txtBDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBDNI.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtBDNI.Name = "txtBDNI";
			this.txtBDNI.Padding = new System.Windows.Forms.Padding(5);
			this.txtBDNI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtBDNI.RectSize = 2;
			this.txtBDNI.ShowText = false;
			this.txtBDNI.Size = new System.Drawing.Size(204, 38);
			this.txtBDNI.TabIndex = 20;
			this.txtBDNI.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtBDNI.Watermark = "";
			this.txtBDNI.TextChanged += new System.EventHandler(this.txtBDNI_TextChanged);
			this.txtBDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBDNI_KeyPress);
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
			this.btnLimpiar.Location = new System.Drawing.Point(879, 25);
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
			this.btnLimpiar.TabIndex = 36;
			this.btnLimpiar.TextAutoCenter = true;
			this.btnLimpiar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.btnVolver, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnInsertar, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 751);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1153, 67);
			this.tableLayoutPanel2.TabIndex = 154;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnVolver.ButtonText = "Cancelar";
			this.btnVolver.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnVolver.CheckedForeColor = System.Drawing.Color.White;
			this.btnVolver.CheckedImageTint = System.Drawing.Color.White;
			this.btnVolver.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVolver.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnVolver.HoverForeColor = System.Drawing.Color.White;
			this.btnVolver.HoverImage = null;
			this.btnVolver.HoverImageTint = System.Drawing.Color.White;
			this.btnVolver.HoverOutline = System.Drawing.Color.Empty;
			this.btnVolver.Image = null;
			this.btnVolver.ImageAutoCenter = false;
			this.btnVolver.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnVolver.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnVolver.ImageTint = System.Drawing.Color.White;
			this.btnVolver.IsToggleButton = false;
			this.btnVolver.IsToggled = false;
			this.btnVolver.Location = new System.Drawing.Point(365, 4);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.btnVolver.NormalForeColor = System.Drawing.Color.White;
			this.btnVolver.NormalOutline = System.Drawing.Color.Empty;
			this.btnVolver.OutlineThickness = 2F;
			this.btnVolver.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.btnVolver.PressedForeColor = System.Drawing.Color.White;
			this.btnVolver.PressedImageTint = System.Drawing.Color.White;
			this.btnVolver.PressedOutline = System.Drawing.Color.Empty;
			this.btnVolver.Rounding = new System.Windows.Forms.Padding(0);
			this.btnVolver.Size = new System.Drawing.Size(204, 43);
			this.btnVolver.TabIndex = 152;
			this.btnVolver.TextAutoCenter = true;
			this.btnVolver.TextOffset = new System.Drawing.Point(0, 0);
			this.btnVolver.Visible = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// btnInsertar
			// 
			this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnInsertar.ButtonText = "Insertar";
			this.btnInsertar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnInsertar.CheckedForeColor = System.Drawing.Color.White;
			this.btnInsertar.CheckedImageTint = System.Drawing.Color.White;
			this.btnInsertar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInsertar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnInsertar.HoverForeColor = System.Drawing.Color.White;
			this.btnInsertar.HoverImage = null;
			this.btnInsertar.HoverImageTint = System.Drawing.Color.White;
			this.btnInsertar.HoverOutline = System.Drawing.Color.Empty;
			this.btnInsertar.Image = null;
			this.btnInsertar.ImageAutoCenter = false;
			this.btnInsertar.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnInsertar.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnInsertar.ImageTint = System.Drawing.Color.White;
			this.btnInsertar.IsToggleButton = false;
			this.btnInsertar.IsToggled = false;
			this.btnInsertar.Location = new System.Drawing.Point(583, 4);
			this.btnInsertar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnInsertar.NormalForeColor = System.Drawing.Color.White;
			this.btnInsertar.NormalOutline = System.Drawing.Color.Empty;
			this.btnInsertar.OutlineThickness = 2F;
			this.btnInsertar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnInsertar.PressedForeColor = System.Drawing.Color.White;
			this.btnInsertar.PressedImageTint = System.Drawing.Color.White;
			this.btnInsertar.PressedOutline = System.Drawing.Color.Empty;
			this.btnInsertar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnInsertar.Size = new System.Drawing.Size(204, 43);
			this.btnInsertar.TabIndex = 153;
			this.btnInsertar.TextAutoCenter = true;
			this.btnInsertar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnInsertar.Visible = false;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// FrmSolicitud
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 818);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvSolicitudes);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmSolicitud";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmSolicitud";
			this.Load += new System.EventHandler(this.FrmSolicitud_Load);
			this.Click += new System.EventHandler(this.FrmSolicitud_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private FrameworkTest.SATAButton btnEliminar;
		private FrameworkTest.SATAButton btnModificar;
		private FrameworkTest.SATAButton btnAgregar;
		private System.Windows.Forms.DataGridView dgvSolicitudes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDPersona;
		private System.Windows.Forms.DataGridViewTextBoxColumn DNIPaciente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDMedico;
		private System.Windows.Forms.DataGridViewTextBoxColumn DNIMedico;
		private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkFecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpHasta;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Sunny.UI.UITextBox txtBNombres;
		private Sunny.UI.UITextBox txtBDNI;
		private FrameworkTest.SATAButton btnLimpiar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private FrameworkTest.SATAButton btnVolver;
		private FrameworkTest.SATAButton btnInsertar;
	}
}