namespace CapaPresentacion.Usuarios_y_Seguridad
{
	partial class FrmRol
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBRol = new Sunny.UI.UITextBox();
			this.dgvRol = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEliminar = new FrameworkTest.SATAButton();
			this.btnModificar = new FrameworkTest.SATAButton();
			this.btnAgregar = new FrameworkTest.SATAButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnVolver = new FrameworkTest.SATAButton();
			this.btnInsertar = new FrameworkTest.SATAButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
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
			this.btnLimpiar.Location = new System.Drawing.Point(980, 80);
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
			this.btnLimpiar.TabIndex = 28;
			this.btnLimpiar.TextAutoCenter = true;
			this.btnLimpiar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtBRol);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(41, 158);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(505, 110);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros de búsqueda";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 22);
			this.label1.TabIndex = 21;
			this.label1.Text = "Rol";
			// 
			// txtBRol
			// 
			this.txtBRol.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtBRol.Location = new System.Drawing.Point(7, 57);
			this.txtBRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBRol.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtBRol.Name = "txtBRol";
			this.txtBRol.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.txtBRol.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtBRol.RectSize = 2;
			this.txtBRol.ShowText = false;
			this.txtBRol.Size = new System.Drawing.Size(457, 38);
			this.txtBRol.TabIndex = 20;
			this.txtBRol.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtBRol.Watermark = "";
			this.txtBRol.TextChanged += new System.EventHandler(this.txtBRol_TextChanged);
			this.txtBRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBRol_KeyPress);
			// 
			// dgvRol
			// 
			this.dgvRol.AllowUserToAddRows = false;
			this.dgvRol.AllowUserToDeleteRows = false;
			this.dgvRol.AllowUserToResizeRows = false;
			this.dgvRol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvRol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ROL});
			this.dgvRol.EnableHeadersVisualStyles = false;
			this.dgvRol.Location = new System.Drawing.Point(47, 287);
			this.dgvRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvRol.MultiSelect = false;
			this.dgvRol.Name = "dgvRol";
			this.dgvRol.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRol.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRol.RowHeadersVisible = false;
			this.dgvRol.RowHeadersWidth = 51;
			this.dgvRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRol.Size = new System.Drawing.Size(1209, 450);
			this.dgvRol.TabIndex = 26;
			this.dgvRol.SelectionChanged += new System.EventHandler(this.dgvRol_SelectionChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// ROL
			// 
			this.ROL.DataPropertyName = "ROL";
			this.ROL.HeaderText = "ROL";
			this.ROL.MinimumWidth = 6;
			this.ROL.Name = "ROL";
			this.ROL.ReadOnly = true;
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
			this.btnEliminar.Location = new System.Drawing.Point(667, 80);
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
			this.btnEliminar.TabIndex = 25;
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
			this.btnModificar.Location = new System.Drawing.Point(355, 80);
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
			this.btnModificar.TabIndex = 24;
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
			this.btnAgregar.Location = new System.Drawing.Point(47, 80);
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
			this.btnAgregar.TabIndex = 23;
			this.btnAgregar.TextAutoCenter = true;
			this.btnAgregar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 752);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1347, 66);
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
			this.btnVolver.Location = new System.Drawing.Point(462, 4);
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
			this.btnInsertar.Location = new System.Drawing.Point(680, 4);
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
			// FrmRol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 818);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvRol);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmRol";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmRol";
			this.Load += new System.EventHandler(this.FrmRol_Load);
			this.Click += new System.EventHandler(this.FrmRol_Click);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private FrameworkTest.SATAButton btnLimpiar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private Sunny.UI.UITextBox txtBRol;
		private System.Windows.Forms.DataGridView dgvRol;
		private FrameworkTest.SATAButton btnEliminar;
		private FrameworkTest.SATAButton btnModificar;
		private FrameworkTest.SATAButton btnAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ROL;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private FrameworkTest.SATAButton btnVolver;
		private FrameworkTest.SATAButton btnInsertar;
	}
}