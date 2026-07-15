namespace CapaPresentacion.Usuarios_y_Seguridad
{
	partial class FrmGestionRol
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
			this.txtNombreRol = new Sunny.UI.UITextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvPermisos = new System.Windows.Forms.DataGridView();
			this.IDPERMISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PERMISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Registrar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnVolver = new FrameworkTest.SATAButton();
			this.btnGuardar = new FrameworkTest.SATAButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombreRol
			// 
			this.txtNombreRol.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombreRol.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNombreRol.Location = new System.Drawing.Point(25, 59);
			this.txtNombreRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombreRol.MaxLength = 25;
			this.txtNombreRol.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtNombreRol.Name = "txtNombreRol";
			this.txtNombreRol.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.txtNombreRol.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtNombreRol.ShowText = false;
			this.txtNombreRol.Size = new System.Drawing.Size(253, 41);
			this.txtNombreRol.TabIndex = 60;
			this.txtNombreRol.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtNombreRol.Watermark = "";
			this.txtNombreRol.WatermarkColor = System.Drawing.Color.DimGray;
			this.txtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRol_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 23);
			this.label1.TabIndex = 58;
			this.label1.Text = "Nombre del rol";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(153, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 25);
			this.label7.TabIndex = 59;
			this.label7.Text = "*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(460, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 28);
			this.label2.TabIndex = 61;
			this.label2.Text = "LISTA DE MÓDULOS";
			// 
			// dgvPermisos
			// 
			this.dgvPermisos.AllowUserToAddRows = false;
			this.dgvPermisos.AllowUserToDeleteRows = false;
			this.dgvPermisos.AllowUserToResizeRows = false;
			this.dgvPermisos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPERMISO,
            this.PERMISO,
            this.Ver,
            this.Registrar,
            this.Modificar,
            this.Eliminar});
			this.dgvPermisos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvPermisos.EnableHeadersVisualStyles = false;
			this.dgvPermisos.Location = new System.Drawing.Point(25, 186);
			this.dgvPermisos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvPermisos.MultiSelect = false;
			this.dgvPermisos.Name = "dgvPermisos";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPermisos.RowHeadersVisible = false;
			this.dgvPermisos.RowHeadersWidth = 51;
			this.dgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvPermisos.Size = new System.Drawing.Size(1072, 450);
			this.dgvPermisos.TabIndex = 62;
			this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
			this.dgvPermisos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellValueChanged);
			this.dgvPermisos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPermisos_CurrentCellDirtyStateChanged);
			// 
			// IDPERMISO
			// 
			this.IDPERMISO.DataPropertyName = "IDPERMISO";
			this.IDPERMISO.HeaderText = "IDPERMISO";
			this.IDPERMISO.MinimumWidth = 6;
			this.IDPERMISO.Name = "IDPERMISO";
			this.IDPERMISO.Visible = false;
			// 
			// PERMISO
			// 
			this.PERMISO.DataPropertyName = "PERMISO";
			this.PERMISO.HeaderText = "Modulo";
			this.PERMISO.MinimumWidth = 6;
			this.PERMISO.Name = "PERMISO";
			// 
			// Ver
			// 
			this.Ver.DataPropertyName = "Ver";
			this.Ver.HeaderText = "Ver";
			this.Ver.MinimumWidth = 6;
			this.Ver.Name = "Ver";
			// 
			// Registrar
			// 
			this.Registrar.DataPropertyName = "Registrar";
			this.Registrar.HeaderText = "Registrar";
			this.Registrar.MinimumWidth = 6;
			this.Registrar.Name = "Registrar";
			// 
			// Modificar
			// 
			this.Modificar.DataPropertyName = "Modificar";
			this.Modificar.HeaderText = "Modificar";
			this.Modificar.MinimumWidth = 6;
			this.Modificar.Name = "Modificar";
			// 
			// Eliminar
			// 
			this.Eliminar.DataPropertyName = "Eliminar";
			this.Eliminar.HeaderText = "Eliminar";
			this.Eliminar.MinimumWidth = 6;
			this.Eliminar.Name = "Eliminar";
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
			this.btnVolver.Location = new System.Drawing.Point(351, 667);
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
			this.btnVolver.TabIndex = 64;
			this.btnVolver.TextAutoCenter = true;
			this.btnVolver.TextOffset = new System.Drawing.Point(0, 0);
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnGuardar.ButtonText = "Guardar";
			this.btnGuardar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnGuardar.CheckedForeColor = System.Drawing.Color.White;
			this.btnGuardar.CheckedImageTint = System.Drawing.Color.White;
			this.btnGuardar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnGuardar.HoverForeColor = System.Drawing.Color.White;
			this.btnGuardar.HoverImage = null;
			this.btnGuardar.HoverImageTint = System.Drawing.Color.White;
			this.btnGuardar.HoverOutline = System.Drawing.Color.Empty;
			this.btnGuardar.Image = null;
			this.btnGuardar.ImageAutoCenter = false;
			this.btnGuardar.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnGuardar.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnGuardar.ImageTint = System.Drawing.Color.White;
			this.btnGuardar.IsToggleButton = false;
			this.btnGuardar.IsToggled = false;
			this.btnGuardar.Location = new System.Drawing.Point(589, 667);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnGuardar.NormalForeColor = System.Drawing.Color.White;
			this.btnGuardar.NormalOutline = System.Drawing.Color.Empty;
			this.btnGuardar.OutlineThickness = 2F;
			this.btnGuardar.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnGuardar.PressedForeColor = System.Drawing.Color.White;
			this.btnGuardar.PressedImageTint = System.Drawing.Color.White;
			this.btnGuardar.PressedOutline = System.Drawing.Color.Empty;
			this.btnGuardar.Rounding = new System.Windows.Forms.Padding(0);
			this.btnGuardar.Size = new System.Drawing.Size(204, 43);
			this.btnGuardar.TabIndex = 63;
			this.btnGuardar.TextAutoCenter = true;
			this.btnGuardar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// FrmGestionRol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1127, 737);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvPermisos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombreRol);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmGestionRol";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmGestionRol";
			this.Load += new System.EventHandler(this.FrmGestionRol_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Sunny.UI.UITextBox txtNombreRol;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvPermisos;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDPERMISO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PERMISO;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Ver;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Registrar;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Modificar;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
		private FrameworkTest.SATAButton btnVolver;
		private FrameworkTest.SATAButton btnGuardar;
	}
}