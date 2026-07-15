namespace CapaPresentacion.Formularios
{
    partial class FrmGestionPaciente
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
			this.lblBuscar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.rbHombre = new Sunny.UI.UIRadioButton();
			this.sataTextBox7 = new SATATextBox();
			this.rbMujer = new Sunny.UI.UIRadioButton();
			this.sataTextBox8 = new SATATextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.btnVolver = new FrameworkTest.SATAButton();
			this.btnGuardar = new FrameworkTest.SATAButton();
			this.txtDNI = new Sunny.UI.UITextBox();
			this.txtNombre = new Sunny.UI.UITextBox();
			this.txtApellido = new Sunny.UI.UITextBox();
			this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.txtCorreo = new Sunny.UI.UITextBox();
			this.txtDireccion = new Sunny.UI.UITextBox();
			this.txtTelefono = new Sunny.UI.UITextBox();
			this.SuspendLayout();
			// 
			// lblBuscar
			// 
			this.lblBuscar.AutoSize = true;
			this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Location = new System.Drawing.Point(25, 27);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(40, 23);
			this.lblBuscar.TabIndex = 20;
			this.lblBuscar.Text = "DNI";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 22;
			this.label1.Text = "Nombres";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 210);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 23);
			this.label2.TabIndex = 24;
			this.label2.Text = "Fecha de nacimiento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 308);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "Dirección";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(337, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 23);
			this.label4.TabIndex = 28;
			this.label4.Text = "Correo electrónico";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(337, 308);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "Teléfono";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(337, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 23);
			this.label6.TabIndex = 32;
			this.label6.Text = "Apellidos";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(108, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 25);
			this.label7.TabIndex = 33;
			this.label7.Text = "*";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(71, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 25);
			this.label8.TabIndex = 34;
			this.label8.Text = "*";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(421, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(21, 25);
			this.label9.TabIndex = 35;
			this.label9.Text = "*";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(203, 212);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(21, 25);
			this.label10.TabIndex = 36;
			this.label10.Text = "*";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(497, 212);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(21, 25);
			this.label11.TabIndex = 37;
			this.label11.Text = "*";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(415, 309);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(21, 25);
			this.label12.TabIndex = 38;
			this.label12.Text = "*";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(101, 406);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(21, 25);
			this.label15.TabIndex = 46;
			this.label15.Text = "*";
			// 
			// rbHombre
			// 
			this.rbHombre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbHombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbHombre.Location = new System.Drawing.Point(296, 441);
			this.rbHombre.Margin = new System.Windows.Forms.Padding(4);
			this.rbHombre.MinimumSize = new System.Drawing.Size(1, 1);
			this.rbHombre.Name = "rbHombre";
			this.rbHombre.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
			this.rbHombre.RectSize = 2;
			this.rbHombre.Size = new System.Drawing.Size(40, 36);
			this.rbHombre.TabIndex = 44;
			this.rbHombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.sataTextBox7.Location = new System.Drawing.Point(208, 437);
			this.sataTextBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sataTextBox7.Multiline = false;
			this.sataTextBox7.Name = "sataTextBox7";
			this.sataTextBox7.PasswordChar = false;
			this.sataTextBox7.PlaceholderColor = System.Drawing.Color.Black;
			this.sataTextBox7.PlaceholderText = "Hombre";
			this.sataTextBox7.Size = new System.Drawing.Size(139, 41);
			this.sataTextBox7.TabIndex = 45;
			this.sataTextBox7.Text = "Mujer";
			this.sataTextBox7.Texts = "";
			this.sataTextBox7.UnderlinedStyle = false;
			// 
			// rbMujer
			// 
			this.rbMujer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbMujer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMujer.Location = new System.Drawing.Point(121, 441);
			this.rbMujer.Margin = new System.Windows.Forms.Padding(4);
			this.rbMujer.MinimumSize = new System.Drawing.Size(1, 1);
			this.rbMujer.Name = "rbMujer";
			this.rbMujer.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
			this.rbMujer.RectSize = 2;
			this.rbMujer.Size = new System.Drawing.Size(40, 36);
			this.rbMujer.TabIndex = 42;
			this.rbMujer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.sataTextBox8.Location = new System.Drawing.Point(33, 437);
			this.sataTextBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sataTextBox8.Multiline = false;
			this.sataTextBox8.Name = "sataTextBox8";
			this.sataTextBox8.PasswordChar = false;
			this.sataTextBox8.PlaceholderColor = System.Drawing.Color.Black;
			this.sataTextBox8.PlaceholderText = "Mujer";
			this.sataTextBox8.Size = new System.Drawing.Size(139, 41);
			this.sataTextBox8.TabIndex = 43;
			this.sataTextBox8.Text = "Mujer";
			this.sataTextBox8.Texts = "";
			this.sataTextBox8.UnderlinedStyle = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(28, 406);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(66, 23);
			this.label16.TabIndex = 41;
			this.label16.Text = "Género";
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
			this.btnVolver.Location = new System.Drawing.Point(93, 514);
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
			this.btnVolver.TabIndex = 48;
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
			this.btnGuardar.Location = new System.Drawing.Point(332, 514);
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
			this.btnGuardar.TabIndex = 47;
			this.btnGuardar.TextAutoCenter = true;
			this.btnGuardar.TextOffset = new System.Drawing.Point(0, 0);
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtDNI
			// 
			this.txtDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDNI.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDNI.Location = new System.Drawing.Point(31, 59);
			this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDNI.MaxLength = 25;
			this.txtDNI.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Padding = new System.Windows.Forms.Padding(5);
			this.txtDNI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtDNI.ShowText = false;
			this.txtDNI.Size = new System.Drawing.Size(253, 41);
			this.txtDNI.TabIndex = 56;
			this.txtDNI.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtDNI.Watermark = "";
			this.txtDNI.WatermarkColor = System.Drawing.Color.DimGray;
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNombre.Location = new System.Drawing.Point(29, 149);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombre.MaxLength = 50;
			this.txtNombre.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Padding = new System.Windows.Forms.Padding(5);
			this.txtNombre.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtNombre.ShowText = false;
			this.txtNombre.Size = new System.Drawing.Size(253, 41);
			this.txtNombre.TabIndex = 57;
			this.txtNombre.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtNombre.Watermark = "";
			this.txtNombre.WatermarkColor = System.Drawing.Color.DimGray;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtApellido
			// 
			this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtApellido.Location = new System.Drawing.Point(341, 149);
			this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtApellido.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Padding = new System.Windows.Forms.Padding(5);
			this.txtApellido.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtApellido.ShowText = false;
			this.txtApellido.Size = new System.Drawing.Size(253, 41);
			this.txtApellido.TabIndex = 58;
			this.txtApellido.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtApellido.Watermark = "";
			this.txtApellido.WatermarkColor = System.Drawing.Color.DimGray;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(29, 242);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(253, 38);
			this.dtpFechaNacimiento.TabIndex = 59;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCorreo.Location = new System.Drawing.Point(341, 242);
			this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCorreo.MaxLength = 50;
			this.txtCorreo.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Padding = new System.Windows.Forms.Padding(5);
			this.txtCorreo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtCorreo.ShowText = false;
			this.txtCorreo.Size = new System.Drawing.Size(253, 41);
			this.txtCorreo.TabIndex = 59;
			this.txtCorreo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtCorreo.Watermark = "";
			this.txtCorreo.WatermarkColor = System.Drawing.Color.DimGray;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDireccion.Location = new System.Drawing.Point(29, 336);
			this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDireccion.MaxLength = 150;
			this.txtDireccion.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Padding = new System.Windows.Forms.Padding(5);
			this.txtDireccion.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtDireccion.ShowText = false;
			this.txtDireccion.Size = new System.Drawing.Size(253, 41);
			this.txtDireccion.TabIndex = 59;
			this.txtDireccion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtDireccion.Watermark = "";
			this.txtDireccion.WatermarkColor = System.Drawing.Color.DimGray;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtTelefono.Location = new System.Drawing.Point(341, 339);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTelefono.MaxLength = 15;
			this.txtTelefono.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Padding = new System.Windows.Forms.Padding(5);
			this.txtTelefono.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtTelefono.ShowText = false;
			this.txtTelefono.Size = new System.Drawing.Size(253, 41);
			this.txtTelefono.TabIndex = 60;
			this.txtTelefono.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtTelefono.Watermark = "";
			this.txtTelefono.WatermarkColor = System.Drawing.Color.DimGray;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
			// 
			// FrmGestionPaciente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(633, 583);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.dtpFechaNacimiento);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.rbHombre);
			this.Controls.Add(this.sataTextBox7);
			this.Controls.Add(this.rbMujer);
			this.Controls.Add(this.sataTextBox8);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.lblBuscar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmGestionPaciente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAgregarPacientes";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private Sunny.UI.UIRadioButton rbHombre;
        private SATATextBox sataTextBox7;
        private Sunny.UI.UIRadioButton rbMujer;
        private SATATextBox sataTextBox8;
        private System.Windows.Forms.Label label16;
        private FrameworkTest.SATAButton btnVolver;
        private FrameworkTest.SATAButton btnGuardar;
		private Sunny.UI.UITextBox txtDNI;
		private Sunny.UI.UITextBox txtNombre;
		private Sunny.UI.UITextBox txtApellido;
		private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
		private Sunny.UI.UITextBox txtCorreo;
		private Sunny.UI.UITextBox txtDireccion;
		private Sunny.UI.UITextBox txtTelefono;
	}
}