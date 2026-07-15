namespace CapaPresentacion.Formularios
{
	partial class FrmModificarPerfil
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
			this.components = new System.ComponentModel.Container();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.pbFoto = new Sunny.UI.UIAvatar();
			this.btnImagen = new FrameworkTest.SATAButton();
			this.btnVolver = new FrameworkTest.SATAButton();
			this.btnGuardar = new FrameworkTest.SATAButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
			this.txtContrasenaActual = new Sunny.UI.UITextBox();
			this.txtContrasenaNueva = new Sunny.UI.UITextBox();
			this.txtRepetirContrasena = new Sunny.UI.UITextBox();
			this.ttReglas = new System.Windows.Forms.ToolTip(this.components);
			this.ptbVer3 = new System.Windows.Forms.PictureBox();
			this.ptbVer2 = new System.Windows.Forms.PictureBox();
			this.ptbVer = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ptbVer3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbVer2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbVer)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBuscar
			// 
			this.lblBuscar.AutoSize = true;
			this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Location = new System.Drawing.Point(22, 18);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(113, 23);
			this.lblBuscar.TabIndex = 21;
			this.lblBuscar.Text = "Foto de perfil";
			// 
			// pbFoto
			// 
			this.pbFoto.AvatarSize = 100;
			this.pbFoto.BackColor = System.Drawing.SystemColors.Control;
			this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFoto.FillColor = System.Drawing.Color.White;
			this.pbFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.pbFoto.ForeColor = System.Drawing.Color.White;
			this.pbFoto.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
			this.pbFoto.Image = global::CapaPresentacion.Properties.Resources.usuario;
			this.pbFoto.Location = new System.Drawing.Point(188, 45);
			this.pbFoto.MinimumSize = new System.Drawing.Size(1, 1);
			this.pbFoto.Name = "pbFoto";
			this.pbFoto.Size = new System.Drawing.Size(140, 135);
			this.pbFoto.TabIndex = 135;
			this.pbFoto.Text = "uiAvatar1";
			// 
			// btnImagen
			// 
			this.btnImagen.ButtonText = "Seleccionar Foto";
			this.btnImagen.CheckedBackground = System.Drawing.Color.DodgerBlue;
			this.btnImagen.CheckedForeColor = System.Drawing.Color.White;
			this.btnImagen.CheckedImageTint = System.Drawing.Color.White;
			this.btnImagen.CheckedOutline = System.Drawing.Color.DodgerBlue;
			this.btnImagen.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnImagen.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnImagen.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
			this.btnImagen.HoverForeColor = System.Drawing.Color.White;
			this.btnImagen.HoverImage = null;
			this.btnImagen.HoverImageTint = System.Drawing.Color.White;
			this.btnImagen.HoverOutline = System.Drawing.Color.Empty;
			this.btnImagen.Image = null;
			this.btnImagen.ImageAutoCenter = true;
			this.btnImagen.ImageExpand = new System.Drawing.Point(0, 0);
			this.btnImagen.ImageOffset = new System.Drawing.Point(0, 0);
			this.btnImagen.ImageTint = System.Drawing.Color.White;
			this.btnImagen.IsToggleButton = false;
			this.btnImagen.IsToggled = false;
			this.btnImagen.Location = new System.Drawing.Point(188, 182);
			this.btnImagen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnImagen.Name = "btnImagen";
			this.btnImagen.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
			this.btnImagen.NormalForeColor = System.Drawing.Color.White;
			this.btnImagen.NormalOutline = System.Drawing.Color.Empty;
			this.btnImagen.OutlineThickness = 2F;
			this.btnImagen.PressedBackground = System.Drawing.Color.RoyalBlue;
			this.btnImagen.PressedForeColor = System.Drawing.Color.White;
			this.btnImagen.PressedImageTint = System.Drawing.Color.White;
			this.btnImagen.PressedOutline = System.Drawing.Color.Empty;
			this.btnImagen.Rounding = new System.Windows.Forms.Padding(5);
			this.btnImagen.Size = new System.Drawing.Size(140, 44);
			this.btnImagen.TabIndex = 134;
			this.btnImagen.TextAutoCenter = true;
			this.btnImagen.TextOffset = new System.Drawing.Point(0, 0);
			this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
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
			this.btnVolver.Location = new System.Drawing.Point(24, 479);
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
			this.btnVolver.TabIndex = 137;
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
			this.btnGuardar.Location = new System.Drawing.Point(276, 479);
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
			this.btnGuardar.TabIndex = 136;
			this.btnGuardar.TextAutoCenter = true;
			this.btnGuardar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 23);
			this.label1.TabIndex = 138;
			this.label1.Text = "Cambiar Contraseña";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 296);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 23);
			this.label2.TabIndex = 139;
			this.label2.Text = "Contraseña actual";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 356);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 23);
			this.label3.TabIndex = 141;
			this.label3.Text = "Contraseña nueva";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 413);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 23);
			this.label4.TabIndex = 143;
			this.label4.Text = "Repetir contraseña";
			// 
			// txtContrasenaActual
			// 
			this.txtContrasenaActual.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtContrasenaActual.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtContrasenaActual.Location = new System.Drawing.Point(200, 296);
			this.txtContrasenaActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtContrasenaActual.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtContrasenaActual.Name = "txtContrasenaActual";
			this.txtContrasenaActual.Padding = new System.Windows.Forms.Padding(5);
			this.txtContrasenaActual.PasswordChar = '*';
			this.txtContrasenaActual.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtContrasenaActual.ShowText = false;
			this.txtContrasenaActual.Size = new System.Drawing.Size(253, 41);
			this.txtContrasenaActual.TabIndex = 145;
			this.txtContrasenaActual.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtContrasenaActual.Watermark = "";
			this.txtContrasenaActual.WatermarkColor = System.Drawing.Color.DimGray;
			// 
			// txtContrasenaNueva
			// 
			this.txtContrasenaNueva.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtContrasenaNueva.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtContrasenaNueva.Location = new System.Drawing.Point(200, 353);
			this.txtContrasenaNueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtContrasenaNueva.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtContrasenaNueva.Name = "txtContrasenaNueva";
			this.txtContrasenaNueva.Padding = new System.Windows.Forms.Padding(5);
			this.txtContrasenaNueva.PasswordChar = '*';
			this.txtContrasenaNueva.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtContrasenaNueva.ShowText = false;
			this.txtContrasenaNueva.Size = new System.Drawing.Size(253, 41);
			this.txtContrasenaNueva.TabIndex = 146;
			this.txtContrasenaNueva.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtContrasenaNueva.Watermark = "";
			this.txtContrasenaNueva.WatermarkColor = System.Drawing.Color.DimGray;
			// 
			// txtRepetirContrasena
			// 
			this.txtRepetirContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRepetirContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtRepetirContrasena.Location = new System.Drawing.Point(200, 407);
			this.txtRepetirContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtRepetirContrasena.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtRepetirContrasena.Name = "txtRepetirContrasena";
			this.txtRepetirContrasena.Padding = new System.Windows.Forms.Padding(5);
			this.txtRepetirContrasena.PasswordChar = '*';
			this.txtRepetirContrasena.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtRepetirContrasena.ShowText = false;
			this.txtRepetirContrasena.Size = new System.Drawing.Size(253, 41);
			this.txtRepetirContrasena.TabIndex = 147;
			this.txtRepetirContrasena.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtRepetirContrasena.Watermark = "";
			this.txtRepetirContrasena.WatermarkColor = System.Drawing.Color.DimGray;
			// 
			// ptbVer3
			// 
			this.ptbVer3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ptbVer3.Image = global::CapaPresentacion.Properties.Resources.eye;
			this.ptbVer3.Location = new System.Drawing.Point(460, 413);
			this.ptbVer3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.ptbVer3.Name = "ptbVer3";
			this.ptbVer3.Size = new System.Drawing.Size(47, 32);
			this.ptbVer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbVer3.TabIndex = 148;
			this.ptbVer3.TabStop = false;
			this.ptbVer3.Click += new System.EventHandler(this.ptbVer3_Click);
			// 
			// ptbVer2
			// 
			this.ptbVer2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ptbVer2.Image = global::CapaPresentacion.Properties.Resources.eye;
			this.ptbVer2.Location = new System.Drawing.Point(460, 356);
			this.ptbVer2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.ptbVer2.Name = "ptbVer2";
			this.ptbVer2.Size = new System.Drawing.Size(47, 32);
			this.ptbVer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbVer2.TabIndex = 149;
			this.ptbVer2.TabStop = false;
			this.ptbVer2.Click += new System.EventHandler(this.ptbVer2_Click);
			// 
			// ptbVer
			// 
			this.ptbVer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ptbVer.Image = global::CapaPresentacion.Properties.Resources.eye;
			this.ptbVer.Location = new System.Drawing.Point(460, 300);
			this.ptbVer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.ptbVer.Name = "ptbVer";
			this.ptbVer.Size = new System.Drawing.Size(47, 32);
			this.ptbVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbVer.TabIndex = 150;
			this.ptbVer.TabStop = false;
			this.ptbVer.Click += new System.EventHandler(this.ptbVer_Click);
			// 
			// FrmModificarPerfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 535);
			this.Controls.Add(this.ptbVer);
			this.Controls.Add(this.ptbVer2);
			this.Controls.Add(this.ptbVer3);
			this.Controls.Add(this.txtRepetirContrasena);
			this.Controls.Add(this.txtContrasenaNueva);
			this.Controls.Add(this.txtContrasenaActual);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.pbFoto);
			this.Controls.Add(this.btnImagen);
			this.Controls.Add(this.lblBuscar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmModificarPerfil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmModificarPerfil";
			this.Load += new System.EventHandler(this.FrmModificarPerfil_Load);
			((System.ComponentModel.ISupportInitialize)(this.ptbVer3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbVer2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbVer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblBuscar;
		private Sunny.UI.UIAvatar pbFoto;
		private FrameworkTest.SATAButton btnImagen;
		private FrameworkTest.SATAButton btnVolver;
		private FrameworkTest.SATAButton btnGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.OpenFileDialog ofdImagen;
		private Sunny.UI.UITextBox txtContrasenaActual;
		private Sunny.UI.UITextBox txtContrasenaNueva;
		private Sunny.UI.UITextBox txtRepetirContrasena;
		private System.Windows.Forms.ToolTip ttReglas;
		private System.Windows.Forms.PictureBox ptbVer3;
		private System.Windows.Forms.PictureBox ptbVer2;
		private System.Windows.Forms.PictureBox ptbVer;
	}
}