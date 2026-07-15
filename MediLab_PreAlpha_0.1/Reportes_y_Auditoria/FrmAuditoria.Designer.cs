namespace CapaPresentacion.Formularios
{
    partial class FrmAuditoria
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAgregarUsuario = new FrameworkTest.SATAButton();
			this.label13 = new System.Windows.Forms.Label();
			this.btnLimpiar = new FrameworkTest.SATAButton();
			this.dgvAuditoria = new System.Windows.Forms.DataGridView();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbModulo = new System.Windows.Forms.ComboBox();
			this.cmbAccion = new System.Windows.Forms.ComboBox();
			this.txtBUsuario = new Sunny.UI.UITextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkFecha = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregarUsuario
			// 
			this.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarUsuario.ButtonText = "+";
			this.btnAgregarUsuario.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarUsuario.CheckedForeColor = System.Drawing.Color.White;
			this.btnAgregarUsuario.CheckedImageTint = System.Drawing.Color.White;
			this.btnAgregarUsuario.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarUsuario.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarUsuario.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnAgregarUsuario.HoverForeColor = System.Drawing.Color.White;
			this.btnAgregarUsuario.HoverImage = null;
			this.btnAgregarUsuario.HoverImageTint = System.Drawing.Color.White;
			this.btnAgregarUsuario.HoverOutline = System.Drawing.Color.Empty;
			this.btnAgregarUsuario.Image = null;
			this.btnAgregarUsuario.ImageAutoCenter = false;
			this.btnAgregarUsuario.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnAgregarUsuario.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnAgregarUsuario.ImageTint = System.Drawing.Color.White;
			this.btnAgregarUsuario.IsToggleButton = false;
			this.btnAgregarUsuario.IsToggled = false;
			this.btnAgregarUsuario.Location = new System.Drawing.Point(208, 53);
			this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnAgregarUsuario.Name = "btnAgregarUsuario";
			this.btnAgregarUsuario.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarUsuario.NormalForeColor = System.Drawing.Color.White;
			this.btnAgregarUsuario.NormalOutline = System.Drawing.Color.Empty;
			this.btnAgregarUsuario.OutlineThickness = 2F;
			this.btnAgregarUsuario.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnAgregarUsuario.PressedForeColor = System.Drawing.Color.White;
			this.btnAgregarUsuario.PressedImageTint = System.Drawing.Color.White;
			this.btnAgregarUsuario.PressedOutline = System.Drawing.Color.Empty;
			this.btnAgregarUsuario.Rounding = new System.Windows.Forms.Padding(0);
			this.btnAgregarUsuario.Size = new System.Drawing.Size(51, 47);
			this.btnAgregarUsuario.TabIndex = 154;
			this.btnAgregarUsuario.TextAutoCenter = true;
			this.btnAgregarUsuario.TextOffset = new System.Drawing.Point(0, 0);
			this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(11, 30);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 23);
			this.label13.TabIndex = 152;
			this.label13.Text = "Usuario";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
			this.btnLimpiar.ButtonText = "Limpiar";
			this.btnLimpiar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnLimpiar.CheckedForeColor = System.Drawing.Color.White;
			this.btnLimpiar.CheckedImageTint = System.Drawing.Color.White;
			this.btnLimpiar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnLimpiar.Location = new System.Drawing.Point(1099, 52);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
			this.btnLimpiar.NormalForeColor = System.Drawing.Color.White;
			this.btnLimpiar.NormalOutline = System.Drawing.Color.Empty;
			this.btnLimpiar.OutlineThickness = 2F;
			this.btnLimpiar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnLimpiar.PressedForeColor = System.Drawing.Color.White;
			this.btnLimpiar.PressedImageTint = System.Drawing.Color.White;
			this.btnLimpiar.PressedOutline = System.Drawing.Color.Empty;
			this.btnLimpiar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnLimpiar.Size = new System.Drawing.Size(149, 43);
			this.btnLimpiar.TabIndex = 162;
			this.btnLimpiar.TextAutoCenter = true;
			this.btnLimpiar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// dgvAuditoria
			// 
			this.dgvAuditoria.AllowUserToAddRows = false;
			this.dgvAuditoria.AllowUserToDeleteRows = false;
			this.dgvAuditoria.AllowUserToResizeRows = false;
			this.dgvAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAuditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAuditoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAuditoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Accion,
            this.Modulo,
            this.Fecha,
            this.Descripcion});
			this.dgvAuditoria.EnableHeadersVisualStyles = false;
			this.dgvAuditoria.Location = new System.Drawing.Point(27, 171);
			this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(4);
			this.dgvAuditoria.MultiSelect = false;
			this.dgvAuditoria.Name = "dgvAuditoria";
			this.dgvAuditoria.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAuditoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAuditoria.RowHeadersVisible = false;
			this.dgvAuditoria.RowHeadersWidth = 51;
			this.dgvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAuditoria.Size = new System.Drawing.Size(1263, 663);
			this.dgvAuditoria.TabIndex = 163;
			// 
			// Usuario
			// 
			this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Usuario.DataPropertyName = "Usuario";
			this.Usuario.HeaderText = "Usuario";
			this.Usuario.MinimumWidth = 100;
			this.Usuario.Name = "Usuario";
			this.Usuario.ReadOnly = true;
			this.Usuario.Width = 125;
			// 
			// Accion
			// 
			this.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Accion.DataPropertyName = "Accion";
			this.Accion.HeaderText = "Accion";
			this.Accion.MinimumWidth = 150;
			this.Accion.Name = "Accion";
			this.Accion.ReadOnly = true;
			this.Accion.Width = 150;
			// 
			// Modulo
			// 
			this.Modulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Modulo.DataPropertyName = "Modulo";
			this.Modulo.HeaderText = "Modulo";
			this.Modulo.MinimumWidth = 150;
			this.Modulo.Name = "Modulo";
			this.Modulo.ReadOnly = true;
			this.Modulo.Width = 150;
			// 
			// Fecha
			// 
			this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Fecha.DataPropertyName = "Fecha";
			dataGridViewCellStyle2.Format = "G";
			dataGridViewCellStyle2.NullValue = null;
			this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
			this.Fecha.HeaderText = "Fecha y Hora";
			this.Fecha.MinimumWidth = 150;
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			this.Fecha.Width = 150;
			// 
			// Descripcion
			// 
			this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descripcion.DataPropertyName = "Descripcion";
			this.Descripcion.HeaderText = "Descripcion del movimiento";
			this.Descripcion.MinimumWidth = 6;
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbModulo);
			this.groupBox1.Controls.Add(this.cmbAccion);
			this.groupBox1.Controls.Add(this.txtBUsuario);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.btnAgregarUsuario);
			this.groupBox1.Controls.Add(this.btnLimpiar);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(27, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1263, 110);
			this.groupBox1.TabIndex = 164;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros de búsqueda";
			// 
			// cmbModulo
			// 
			this.cmbModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbModulo.FormattingEnabled = true;
			this.cmbModulo.Items.AddRange(new object[] {
            "Pacientes",
            "Medicos",
            "Solicitudes",
            "Registro Examen",
            "Facturacion",
            "Usuarios",
            "Precios",
            "Roles y Permisos"});
			this.cmbModulo.Location = new System.Drawing.Point(511, 57);
			this.cmbModulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbModulo.Name = "cmbModulo";
			this.cmbModulo.Size = new System.Drawing.Size(191, 37);
			this.cmbModulo.TabIndex = 157;
			this.cmbModulo.Text = "Módulo";
			this.cmbModulo.SelectedIndexChanged += new System.EventHandler(this.cmbModulo_SelectedIndexChanged_1);
			// 
			// cmbAccion
			// 
			this.cmbAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAccion.FormattingEnabled = true;
			this.cmbAccion.Items.AddRange(new object[] {
            "Registrar",
            "Modificar",
            "Eliminar"});
			this.cmbAccion.Location = new System.Drawing.Point(285, 57);
			this.cmbAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbAccion.Name = "cmbAccion";
			this.cmbAccion.Size = new System.Drawing.Size(191, 37);
			this.cmbAccion.TabIndex = 156;
			this.cmbAccion.Text = "Acción";
			this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.cmbAccion_SelectedIndexChanged_1);
			// 
			// txtBUsuario
			// 
			this.txtBUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtBUsuario.Location = new System.Drawing.Point(15, 57);
			this.txtBUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBUsuario.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtBUsuario.Name = "txtBUsuario";
			this.txtBUsuario.Padding = new System.Windows.Forms.Padding(5);
			this.txtBUsuario.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtBUsuario.RectSize = 2;
			this.txtBUsuario.ShowText = false;
			this.txtBUsuario.Size = new System.Drawing.Size(182, 38);
			this.txtBUsuario.TabIndex = 155;
			this.txtBUsuario.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtBUsuario.Watermark = "";
			this.txtBUsuario.TextChanged += new System.EventHandler(this.txtBUsuario_TextChanged_1);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkFecha);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dtpHasta);
			this.groupBox2.Controls.Add(this.dtpDesde);
			this.groupBox2.Location = new System.Drawing.Point(729, 35);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(344, 65);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fecha de la acción";
			// 
			// chkFecha
			// 
			this.chkFecha.AutoSize = true;
			this.chkFecha.Location = new System.Drawing.Point(213, 1);
			this.chkFecha.Name = "chkFecha";
			this.chkFecha.Size = new System.Drawing.Size(18, 17);
			this.chkFecha.TabIndex = 52;
			this.chkFecha.UseVisualStyleBackColor = true;
			this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(162, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 22);
			this.label5.TabIndex = 51;
			this.label5.Text = "a";
			// 
			// dtpHasta
			// 
			this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpHasta.Location = new System.Drawing.Point(191, 29);
			this.dtpHasta.Name = "dtpHasta";
			this.dtpHasta.Size = new System.Drawing.Size(136, 30);
			this.dtpHasta.TabIndex = 1;
			// 
			// dtpDesde
			// 
			this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDesde.Location = new System.Drawing.Point(16, 29);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(136, 30);
			this.dtpDesde.TabIndex = 0;
			// 
			// FrmAuditoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1323, 877);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvAuditoria);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmAuditoria";
			this.Text = "FrmAuditoria";
			this.Load += new System.EventHandler(this.FrmAuditoria_Load);
			this.Click += new System.EventHandler(this.FrmAuditoria_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private FrameworkTest.SATAButton btnAgregarUsuario;
        private System.Windows.Forms.Label label13;
        private FrameworkTest.SATAButton btnLimpiar;
		private System.Windows.Forms.DataGridView dgvAuditoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkFecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpHasta;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private Sunny.UI.UITextBox txtBUsuario;
		private System.Windows.Forms.ComboBox cmbAccion;
		private System.Windows.Forms.ComboBox cmbModulo;
	}
}