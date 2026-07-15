namespace CapaPresentacion.Formularios
{
    partial class FrmUsuario
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvUsuario = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnLimpiar = new FrameworkTest.SATAButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkFecha = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.rbHombre = new Sunny.UI.UIRadioButton();
			this.sataTextBox7 = new SATATextBox();
			this.rbMujer = new Sunny.UI.UIRadioButton();
			this.sataTextBox8 = new SATATextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBDNI = new Sunny.UI.UITextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBApellidos = new Sunny.UI.UITextBox();
			this.txtBNombres = new Sunny.UI.UITextBox();
			this.btnEliminar = new FrameworkTest.SATAButton();
			this.btnModificar = new FrameworkTest.SATAButton();
			this.btnAgregar = new FrameworkTest.SATAButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnVolver = new FrameworkTest.SATAButton();
			this.btnInsertar = new FrameworkTest.SATAButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvUsuario
			// 
			this.dgvUsuario.AllowUserToAddRows = false;
			this.dgvUsuario.AllowUserToDeleteRows = false;
			this.dgvUsuario.AllowUserToResizeRows = false;
			this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDPersona,
            this.DNI,
            this.Nombres,
            this.Apellidos,
            this.FechaNacimiento,
            this.Genero,
            this.CorreoElectronico,
            this.Telefono,
            this.Direccion,
            this.NombreUsuario,
            this.Rol,
            this.FechaRegistro});
			this.dgvUsuario.EnableHeadersVisualStyles = false;
			this.dgvUsuario.Location = new System.Drawing.Point(76, 313);
			this.dgvUsuario.Margin = new System.Windows.Forms.Padding(4);
			this.dgvUsuario.MultiSelect = false;
			this.dgvUsuario.Name = "dgvUsuario";
			this.dgvUsuario.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvUsuario.RowHeadersVisible = false;
			this.dgvUsuario.RowHeadersWidth = 51;
			this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuario.Size = new System.Drawing.Size(1188, 461);
			this.dgvUsuario.TabIndex = 25;
			this.dgvUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellDoubleClick);
			this.dgvUsuario.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuario_CellMouseDown);
			this.dgvUsuario.SelectionChanged += new System.EventHandler(this.dgvUsuario_SelectionChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "IDUsuario";
			this.ID.FillWeight = 61.17647F;
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 50;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// IDPersona
			// 
			this.IDPersona.DataPropertyName = "IDPersona";
			this.IDPersona.HeaderText = "ID Persona";
			this.IDPersona.MinimumWidth = 80;
			this.IDPersona.Name = "IDPersona";
			this.IDPersona.ReadOnly = true;
			// 
			// DNI
			// 
			this.DNI.DataPropertyName = "DNI";
			this.DNI.FillWeight = 488.2353F;
			this.DNI.HeaderText = "DNI";
			this.DNI.MinimumWidth = 95;
			this.DNI.Name = "DNI";
			this.DNI.ReadOnly = true;
			// 
			// Nombres
			// 
			this.Nombres.DataPropertyName = "Nombres";
			this.Nombres.FillWeight = 61.17647F;
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.MinimumWidth = 150;
			this.Nombres.Name = "Nombres";
			this.Nombres.ReadOnly = true;
			// 
			// Apellidos
			// 
			this.Apellidos.DataPropertyName = "Apellidos";
			this.Apellidos.FillWeight = 61.17647F;
			this.Apellidos.HeaderText = "Apellidos";
			this.Apellidos.MinimumWidth = 150;
			this.Apellidos.Name = "Apellidos";
			this.Apellidos.ReadOnly = true;
			// 
			// FechaNacimiento
			// 
			this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
			this.FechaNacimiento.FillWeight = 61.17647F;
			this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
			this.FechaNacimiento.MinimumWidth = 100;
			this.FechaNacimiento.Name = "FechaNacimiento";
			this.FechaNacimiento.ReadOnly = true;
			// 
			// Genero
			// 
			this.Genero.DataPropertyName = "Genero";
			this.Genero.FillWeight = 61.17647F;
			this.Genero.HeaderText = "Genero";
			this.Genero.MinimumWidth = 80;
			this.Genero.Name = "Genero";
			this.Genero.ReadOnly = true;
			// 
			// CorreoElectronico
			// 
			this.CorreoElectronico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.CorreoElectronico.DataPropertyName = "CorreoElectronico";
			this.CorreoElectronico.FillWeight = 61.17647F;
			this.CorreoElectronico.HeaderText = "Correo Electronico";
			this.CorreoElectronico.MinimumWidth = 150;
			this.CorreoElectronico.Name = "CorreoElectronico";
			this.CorreoElectronico.ReadOnly = true;
			this.CorreoElectronico.Width = 163;
			// 
			// Telefono
			// 
			this.Telefono.DataPropertyName = "Telefono";
			this.Telefono.FillWeight = 61.17647F;
			this.Telefono.HeaderText = "Telefono";
			this.Telefono.MinimumWidth = 100;
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			// 
			// Direccion
			// 
			this.Direccion.DataPropertyName = "Direccion";
			this.Direccion.FillWeight = 61.17647F;
			this.Direccion.HeaderText = "Direccion";
			this.Direccion.MinimumWidth = 200;
			this.Direccion.Name = "Direccion";
			this.Direccion.ReadOnly = true;
			// 
			// NombreUsuario
			// 
			this.NombreUsuario.DataPropertyName = "NombreUsuario";
			this.NombreUsuario.HeaderText = "Usuario";
			this.NombreUsuario.MinimumWidth = 80;
			this.NombreUsuario.Name = "NombreUsuario";
			this.NombreUsuario.ReadOnly = true;
			// 
			// Rol
			// 
			this.Rol.DataPropertyName = "Rol";
			this.Rol.HeaderText = "Rol";
			this.Rol.MinimumWidth = 80;
			this.Rol.Name = "Rol";
			this.Rol.ReadOnly = true;
			// 
			// FechaRegistro
			// 
			this.FechaRegistro.DataPropertyName = "FechaRegistro";
			this.FechaRegistro.FillWeight = 61.17647F;
			this.FechaRegistro.HeaderText = "Fecha Registro";
			this.FechaRegistro.MinimumWidth = 100;
			this.FechaRegistro.Name = "FechaRegistro";
			this.FechaRegistro.ReadOnly = true;
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
			this.btnLimpiar.Location = new System.Drawing.Point(1009, 64);
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
			this.btnLimpiar.TabIndex = 30;
			this.btnLimpiar.TextAutoCenter = true;
			this.btnLimpiar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.rbHombre);
			this.groupBox1.Controls.Add(this.sataTextBox7);
			this.groupBox1.Controls.Add(this.rbMujer);
			this.groupBox1.Controls.Add(this.sataTextBox8);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtBDNI);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtBApellidos);
			this.groupBox1.Controls.Add(this.txtBNombres);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(70, 142);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1265, 110);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros de búsqueda";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkFecha);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dtpHasta);
			this.groupBox2.Controls.Add(this.dtpDesde);
			this.groupBox2.Location = new System.Drawing.Point(894, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(365, 65);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fecha de Nacimiento";
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
			// rbHombre
			// 
			this.rbHombre.BackColor = System.Drawing.Color.White;
			this.rbHombre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbHombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbHombre.Location = new System.Drawing.Point(829, 60);
			this.rbHombre.Margin = new System.Windows.Forms.Padding(4);
			this.rbHombre.MinimumSize = new System.Drawing.Size(1, 1);
			this.rbHombre.Name = "rbHombre";
			this.rbHombre.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
			this.rbHombre.RectSize = 2;
			this.rbHombre.Size = new System.Drawing.Size(31, 31);
			this.rbHombre.TabIndex = 48;
			this.rbHombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rbHombre.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
			// 
			// sataTextBox7
			// 
			this.sataTextBox7.BackColor = System.Drawing.Color.White;
			this.sataTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
			this.sataTextBox7.BorderFocusColor = System.Drawing.Color.Black;
			this.sataTextBox7.BorderRadius = 3;
			this.sataTextBox7.BorderSize = 1;
			this.sataTextBox7.Enabled = false;
			this.sataTextBox7.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.sataTextBox7.ForeColor = System.Drawing.Color.Black;
			this.sataTextBox7.Icon = null;
			this.sataTextBox7.IconSize = new System.Drawing.Size(20, 20);
			this.sataTextBox7.Location = new System.Drawing.Point(753, 54);
			this.sataTextBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sataTextBox7.Multiline = false;
			this.sataTextBox7.Name = "sataTextBox7";
			this.sataTextBox7.PasswordChar = false;
			this.sataTextBox7.PlaceholderColor = System.Drawing.Color.Black;
			this.sataTextBox7.PlaceholderText = "Hombre";
			this.sataTextBox7.Size = new System.Drawing.Size(110, 41);
			this.sataTextBox7.TabIndex = 49;
			this.sataTextBox7.Text = "Mujer";
			this.sataTextBox7.Texts = "";
			this.sataTextBox7.UnderlinedStyle = false;
			// 
			// rbMujer
			// 
			this.rbMujer.BackColor = System.Drawing.Color.White;
			this.rbMujer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbMujer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMujer.Location = new System.Drawing.Point(711, 60);
			this.rbMujer.Margin = new System.Windows.Forms.Padding(4);
			this.rbMujer.MinimumSize = new System.Drawing.Size(1, 1);
			this.rbMujer.Name = "rbMujer";
			this.rbMujer.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
			this.rbMujer.RectSize = 2;
			this.rbMujer.Size = new System.Drawing.Size(31, 31);
			this.rbMujer.TabIndex = 46;
			this.rbMujer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rbMujer.CheckedChanged += new System.EventHandler(this.rbMujer_CheckedChanged);
			// 
			// sataTextBox8
			// 
			this.sataTextBox8.BackColor = System.Drawing.Color.White;
			this.sataTextBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
			this.sataTextBox8.BorderFocusColor = System.Drawing.Color.Black;
			this.sataTextBox8.BorderRadius = 3;
			this.sataTextBox8.BorderSize = 1;
			this.sataTextBox8.Enabled = false;
			this.sataTextBox8.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.sataTextBox8.ForeColor = System.Drawing.Color.Black;
			this.sataTextBox8.Icon = null;
			this.sataTextBox8.IconSize = new System.Drawing.Size(20, 20);
			this.sataTextBox8.Location = new System.Drawing.Point(654, 54);
			this.sataTextBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sataTextBox8.Multiline = false;
			this.sataTextBox8.Name = "sataTextBox8";
			this.sataTextBox8.PasswordChar = false;
			this.sataTextBox8.PlaceholderColor = System.Drawing.Color.Black;
			this.sataTextBox8.PlaceholderText = "Mujer";
			this.sataTextBox8.Size = new System.Drawing.Size(93, 41);
			this.sataTextBox8.TabIndex = 47;
			this.sataTextBox8.Text = "Mujer";
			this.sataTextBox8.Texts = "";
			this.sataTextBox8.UnderlinedStyle = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(650, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 22);
			this.label4.TabIndex = 26;
			this.label4.Text = "Género";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(462, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 22);
			this.label3.TabIndex = 25;
			this.label3.Text = "DNI";
			// 
			// txtBDNI
			// 
			this.txtBDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtBDNI.Location = new System.Drawing.Point(463, 57);
			this.txtBDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBDNI.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtBDNI.Name = "txtBDNI";
			this.txtBDNI.Padding = new System.Windows.Forms.Padding(5);
			this.txtBDNI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtBDNI.RectSize = 2;
			this.txtBDNI.ShowText = false;
			this.txtBDNI.Size = new System.Drawing.Size(163, 38);
			this.txtBDNI.TabIndex = 24;
			this.txtBDNI.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtBDNI.Watermark = "";
			this.txtBDNI.TextChanged += new System.EventHandler(this.txtBDNI_TextChanged);
			this.txtBDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBDNI_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(233, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 22);
			this.label2.TabIndex = 23;
			this.label2.Text = "Apellidos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 22);
			this.label1.TabIndex = 21;
			this.label1.Text = "Nombres";
			// 
			// txtBApellidos
			// 
			this.txtBApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtBApellidos.Location = new System.Drawing.Point(234, 57);
			this.txtBApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBApellidos.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtBApellidos.Name = "txtBApellidos";
			this.txtBApellidos.Padding = new System.Windows.Forms.Padding(5);
			this.txtBApellidos.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtBApellidos.RectSize = 2;
			this.txtBApellidos.ShowText = false;
			this.txtBApellidos.Size = new System.Drawing.Size(204, 38);
			this.txtBApellidos.TabIndex = 22;
			this.txtBApellidos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtBApellidos.Watermark = "";
			this.txtBApellidos.TextChanged += new System.EventHandler(this.txtBApellidos_TextChanged);
			this.txtBApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBApellidos_KeyPress);
			// 
			// txtBNombres
			// 
			this.txtBNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtBNombres.Location = new System.Drawing.Point(7, 57);
			this.txtBNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBNombres.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtBNombres.Name = "txtBNombres";
			this.txtBNombres.Padding = new System.Windows.Forms.Padding(5);
			this.txtBNombres.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtBNombres.RectSize = 2;
			this.txtBNombres.ShowText = false;
			this.txtBNombres.Size = new System.Drawing.Size(204, 38);
			this.txtBNombres.TabIndex = 20;
			this.txtBNombres.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtBNombres.Watermark = "";
			this.txtBNombres.TextChanged += new System.EventHandler(this.txtBNombres_TextChanged);
			this.txtBNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNombres_KeyPress);
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
			this.btnEliminar.Location = new System.Drawing.Point(695, 64);
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
			this.btnEliminar.TabIndex = 28;
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
			this.btnModificar.Location = new System.Drawing.Point(384, 64);
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
			this.btnModificar.TabIndex = 27;
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
			this.btnAgregar.Location = new System.Drawing.Point(76, 64);
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
			this.btnAgregar.TabIndex = 26;
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
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 787);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1341, 67);
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
			this.btnVolver.Location = new System.Drawing.Point(459, 4);
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
			this.btnInsertar.Location = new System.Drawing.Point(677, 4);
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
			// FrmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1341, 854);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgvUsuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmUsuarios";
			this.Load += new System.EventHandler(this.FrmUsuario_Load);
			this.Click += new System.EventHandler(this.FrmUsuario_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.DataGridView dgvUsuario;
		private FrameworkTest.SATAButton btnLimpiar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkFecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpHasta;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private Sunny.UI.UIRadioButton rbHombre;
		private SATATextBox sataTextBox7;
		private Sunny.UI.UIRadioButton rbMujer;
		private SATATextBox sataTextBox8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private Sunny.UI.UITextBox txtBDNI;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Sunny.UI.UITextBox txtBApellidos;
		private Sunny.UI.UITextBox txtBNombres;
		private FrameworkTest.SATAButton btnEliminar;
		private FrameworkTest.SATAButton btnModificar;
		private FrameworkTest.SATAButton btnAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDPersona;
		private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
		private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private FrameworkTest.SATAButton btnVolver;
		private FrameworkTest.SATAButton btnInsertar;
	}
}