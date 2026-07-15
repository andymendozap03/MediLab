namespace CapaPresentacion.Usuarios_y_Seguridad
{
	partial class FrmEspecialidad
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
			this.dgvEspecialidad = new System.Windows.Forms.DataGridView();
			this.IDEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreEspecialidad = new Sunny.UI.UITextBox();
			this.btnEliminar = new FrameworkTest.SATAButton();
			this.btnModificar = new FrameworkTest.SATAButton();
			this.btnAgregar = new FrameworkTest.SATAButton();
			this.btnVolver = new FrameworkTest.SATAButton();
			this.btnInsertar = new FrameworkTest.SATAButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEspecialidad
			// 
			this.dgvEspecialidad.AllowUserToAddRows = false;
			this.dgvEspecialidad.AllowUserToDeleteRows = false;
			this.dgvEspecialidad.AllowUserToResizeRows = false;
			this.dgvEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEspecialidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvEspecialidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEspecialidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEspecialidad,
            this.Especialidad});
			this.dgvEspecialidad.EnableHeadersVisualStyles = false;
			this.dgvEspecialidad.Location = new System.Drawing.Point(31, 205);
			this.dgvEspecialidad.Margin = new System.Windows.Forms.Padding(4);
			this.dgvEspecialidad.MultiSelect = false;
			this.dgvEspecialidad.Name = "dgvEspecialidad";
			this.dgvEspecialidad.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEspecialidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvEspecialidad.RowHeadersVisible = false;
			this.dgvEspecialidad.RowHeadersWidth = 51;
			this.dgvEspecialidad.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.dgvEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEspecialidad.Size = new System.Drawing.Size(680, 366);
			this.dgvEspecialidad.TabIndex = 27;
			this.dgvEspecialidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidad_CellClick);
			this.dgvEspecialidad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidad_CellDoubleClick);
			// 
			// IDEspecialidad
			// 
			this.IDEspecialidad.DataPropertyName = "IDEspecialidad";
			this.IDEspecialidad.FillWeight = 61.17647F;
			this.IDEspecialidad.HeaderText = "IDEspecialidad";
			this.IDEspecialidad.MinimumWidth = 50;
			this.IDEspecialidad.Name = "IDEspecialidad";
			this.IDEspecialidad.ReadOnly = true;
			// 
			// Especialidad
			// 
			this.Especialidad.DataPropertyName = "Especialidad";
			this.Especialidad.HeaderText = "Especialidad";
			this.Especialidad.MinimumWidth = 6;
			this.Especialidad.Name = "Especialidad";
			this.Especialidad.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 20);
			this.label1.TabIndex = 29;
			this.label1.Text = "Nombre especialidad";
			// 
			// txtNombreEspecialidad
			// 
			this.txtNombreEspecialidad.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombreEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtNombreEspecialidad.Location = new System.Drawing.Point(31, 61);
			this.txtNombreEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombreEspecialidad.MaxLength = 50;
			this.txtNombreEspecialidad.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
			this.txtNombreEspecialidad.Padding = new System.Windows.Forms.Padding(5);
			this.txtNombreEspecialidad.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
			this.txtNombreEspecialidad.RectSize = 2;
			this.txtNombreEspecialidad.ShowText = false;
			this.txtNombreEspecialidad.Size = new System.Drawing.Size(218, 38);
			this.txtNombreEspecialidad.TabIndex = 28;
			this.txtNombreEspecialidad.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtNombreEspecialidad.Watermark = "";
			this.txtNombreEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEspecialidad_KeyPress);
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
			this.btnEliminar.Location = new System.Drawing.Point(511, 130);
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
			this.btnEliminar.Size = new System.Drawing.Size(200, 52);
			this.btnEliminar.TabIndex = 36;
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
			this.btnModificar.Location = new System.Drawing.Point(274, 130);
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
			this.btnModificar.Size = new System.Drawing.Size(188, 52);
			this.btnModificar.TabIndex = 35;
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
			this.btnAgregar.Location = new System.Drawing.Point(31, 130);
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
			this.btnAgregar.Size = new System.Drawing.Size(198, 52);
			this.btnAgregar.TabIndex = 34;
			this.btnAgregar.TextAutoCenter = true;
			this.btnAgregar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
			this.btnVolver.Location = new System.Drawing.Point(148, 608);
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
			this.btnVolver.TabIndex = 78;
			this.btnVolver.TextAutoCenter = true;
			this.btnVolver.TextOffset = new System.Drawing.Point(0, 0);
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
			this.btnInsertar.Location = new System.Drawing.Point(387, 608);
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
			this.btnInsertar.TabIndex = 77;
			this.btnInsertar.TextAutoCenter = true;
			this.btnInsertar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// FrmEspecialidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 689);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombreEspecialidad);
			this.Controls.Add(this.dgvEspecialidad);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEspecialidad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEspecialidad";
			this.Load += new System.EventHandler(this.FrmEspecialidad_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvEspecialidad;
		private System.Windows.Forms.Label label1;
		private Sunny.UI.UITextBox txtNombreEspecialidad;
		private FrameworkTest.SATAButton btnEliminar;
		private FrameworkTest.SATAButton btnModificar;
		private FrameworkTest.SATAButton btnAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDEspecialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
		private FrameworkTest.SATAButton btnVolver;
		private FrameworkTest.SATAButton btnInsertar;
	}
}