namespace CapaPresentacion.Formularios
{
	partial class FrmHistorialExamen
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
			this.btnAgregarPaciente = new FrameworkTest.SATAButton();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rbExamen = new Sunny.UI.UIRadioButton();
			this.sataTextBox8 = new SATATextBox();
			this.rbComparar = new Sunny.UI.UIRadioButton();
			this.sataTextBox1 = new SATATextBox();
			this.spcContenedor = new System.Windows.Forms.SplitContainer();
			this.rpvExamen1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.btnSeleccionarExamen1 = new FrameworkTest.SATAButton();
			this.label3 = new System.Windows.Forms.Label();
			this.rpvExamen2 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.btnSeleccionarExamen2 = new FrameworkTest.SATAButton();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombrePaciente = new Sunny.UI.UITextBox();
			this.txtDNIPaciente = new Sunny.UI.UITextBox();
			((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).BeginInit();
			this.spcContenedor.Panel1.SuspendLayout();
			this.spcContenedor.Panel2.SuspendLayout();
			this.spcContenedor.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregarPaciente
			// 
			this.btnAgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarPaciente.ButtonText = "+";
			this.btnAgregarPaciente.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarPaciente.CheckedForeColor = System.Drawing.Color.White;
			this.btnAgregarPaciente.CheckedImageTint = System.Drawing.Color.White;
			this.btnAgregarPaciente.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarPaciente.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnAgregarPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarPaciente.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnAgregarPaciente.HoverForeColor = System.Drawing.Color.White;
			this.btnAgregarPaciente.HoverImage = null;
			this.btnAgregarPaciente.HoverImageTint = System.Drawing.Color.White;
			this.btnAgregarPaciente.HoverOutline = System.Drawing.Color.Empty;
			this.btnAgregarPaciente.Image = null;
			this.btnAgregarPaciente.ImageAutoCenter = false;
			this.btnAgregarPaciente.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnAgregarPaciente.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnAgregarPaciente.ImageTint = System.Drawing.Color.White;
			this.btnAgregarPaciente.IsToggleButton = false;
			this.btnAgregarPaciente.IsToggled = false;
			this.btnAgregarPaciente.Location = new System.Drawing.Point(224, 37);
			this.btnAgregarPaciente.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnAgregarPaciente.Name = "btnAgregarPaciente";
			this.btnAgregarPaciente.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnAgregarPaciente.NormalForeColor = System.Drawing.Color.White;
			this.btnAgregarPaciente.NormalOutline = System.Drawing.Color.Empty;
			this.btnAgregarPaciente.OutlineThickness = 2F;
			this.btnAgregarPaciente.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnAgregarPaciente.PressedForeColor = System.Drawing.Color.White;
			this.btnAgregarPaciente.PressedImageTint = System.Drawing.Color.White;
			this.btnAgregarPaciente.PressedOutline = System.Drawing.Color.Empty;
			this.btnAgregarPaciente.Rounding = new System.Windows.Forms.Padding(0);
			this.btnAgregarPaciente.Size = new System.Drawing.Size(46, 42);
			this.btnAgregarPaciente.TabIndex = 150;
			this.btnAgregarPaciente.TextAutoCenter = true;
			this.btnAgregarPaciente.TextOffset = new System.Drawing.Point(0, 0);
			this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(18, 7);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(75, 23);
			this.label13.TabIndex = 148;
			this.label13.Text = "Paciente";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(95, 7);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(21, 25);
			this.label14.TabIndex = 149;
			this.label14.Text = "*";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(329, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 23);
			this.label1.TabIndex = 153;
			this.label1.Text = "Nombre del Paciente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 23);
			this.label2.TabIndex = 154;
			this.label2.Text = "Modo de visualización";
			// 
			// rbExamen
			// 
			this.rbExamen.BackColor = System.Drawing.Color.White;
			this.rbExamen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbExamen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExamen.Location = new System.Drawing.Point(224, 129);
			this.rbExamen.Margin = new System.Windows.Forms.Padding(4);
			this.rbExamen.MinimumSize = new System.Drawing.Size(1, 1);
			this.rbExamen.Name = "rbExamen";
			this.rbExamen.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
			this.rbExamen.RectSize = 2;
			this.rbExamen.Size = new System.Drawing.Size(40, 36);
			this.rbExamen.TabIndex = 155;
			this.rbExamen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rbExamen.CheckedChanged += new System.EventHandler(this.rbExamen_CheckedChanged);
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
			this.sataTextBox8.Location = new System.Drawing.Point(23, 126);
			this.sataTextBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sataTextBox8.Multiline = false;
			this.sataTextBox8.Name = "sataTextBox8";
			this.sataTextBox8.PasswordChar = false;
			this.sataTextBox8.PlaceholderColor = System.Drawing.Color.Black;
			this.sataTextBox8.PlaceholderText = "Ver un examen";
			this.sataTextBox8.Size = new System.Drawing.Size(247, 41);
			this.sataTextBox8.TabIndex = 156;
			this.sataTextBox8.Text = "Ver un examen";
			this.sataTextBox8.Texts = "";
			this.sataTextBox8.UnderlinedStyle = false;
			// 
			// rbComparar
			// 
			this.rbComparar.BackColor = System.Drawing.Color.White;
			this.rbComparar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbComparar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbComparar.Location = new System.Drawing.Point(498, 129);
			this.rbComparar.Margin = new System.Windows.Forms.Padding(4);
			this.rbComparar.MinimumSize = new System.Drawing.Size(1, 1);
			this.rbComparar.Name = "rbComparar";
			this.rbComparar.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
			this.rbComparar.RectSize = 2;
			this.rbComparar.Size = new System.Drawing.Size(40, 36);
			this.rbComparar.TabIndex = 157;
			this.rbComparar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rbComparar.CheckedChanged += new System.EventHandler(this.rbComparar_CheckedChanged);
			// 
			// sataTextBox1
			// 
			this.sataTextBox1.BackColor = System.Drawing.Color.White;
			this.sataTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
			this.sataTextBox1.BorderFocusColor = System.Drawing.Color.Black;
			this.sataTextBox1.BorderRadius = 3;
			this.sataTextBox1.BorderSize = 1;
			this.sataTextBox1.Enabled = false;
			this.sataTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.sataTextBox1.ForeColor = System.Drawing.Color.Black;
			this.sataTextBox1.Icon = null;
			this.sataTextBox1.IconSize = new System.Drawing.Size(20, 20);
			this.sataTextBox1.Location = new System.Drawing.Point(297, 126);
			this.sataTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sataTextBox1.Multiline = false;
			this.sataTextBox1.Name = "sataTextBox1";
			this.sataTextBox1.PasswordChar = false;
			this.sataTextBox1.PlaceholderColor = System.Drawing.Color.Black;
			this.sataTextBox1.PlaceholderText = "Comparar exámenes";
			this.sataTextBox1.Size = new System.Drawing.Size(247, 41);
			this.sataTextBox1.TabIndex = 158;
			this.sataTextBox1.Text = "Comparar exámenes";
			this.sataTextBox1.Texts = "";
			this.sataTextBox1.UnderlinedStyle = false;
			// 
			// spcContenedor
			// 
			this.spcContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.spcContenedor.Location = new System.Drawing.Point(22, 194);
			this.spcContenedor.Name = "spcContenedor";
			// 
			// spcContenedor.Panel1
			// 
			this.spcContenedor.Panel1.Controls.Add(this.rpvExamen1);
			this.spcContenedor.Panel1.Controls.Add(this.btnSeleccionarExamen1);
			this.spcContenedor.Panel1.Controls.Add(this.label3);
			// 
			// spcContenedor.Panel2
			// 
			this.spcContenedor.Panel2.Controls.Add(this.rpvExamen2);
			this.spcContenedor.Panel2.Controls.Add(this.btnSeleccionarExamen2);
			this.spcContenedor.Panel2.Controls.Add(this.label4);
			this.spcContenedor.Size = new System.Drawing.Size(1103, 685);
			this.spcContenedor.SplitterDistance = 540;
			this.spcContenedor.TabIndex = 159;
			// 
			// rpvExamen1
			// 
			this.rpvExamen1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rpvExamen1.Location = new System.Drawing.Point(15, 51);
			this.rpvExamen1.Name = "rpvExamen1";
			this.rpvExamen1.ServerReport.BearerToken = null;
			this.rpvExamen1.Size = new System.Drawing.Size(510, 621);
			this.rpvExamen1.TabIndex = 158;
			this.rpvExamen1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
			// 
			// btnSeleccionarExamen1
			// 
			this.btnSeleccionarExamen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen1.ButtonText = "+";
			this.btnSeleccionarExamen1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen1.CheckedForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.CheckedImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeleccionarExamen1.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnSeleccionarExamen1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionarExamen1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnSeleccionarExamen1.HoverForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.HoverImage = null;
			this.btnSeleccionarExamen1.HoverImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.HoverOutline = System.Drawing.Color.Empty;
			this.btnSeleccionarExamen1.Image = null;
			this.btnSeleccionarExamen1.ImageAutoCenter = false;
			this.btnSeleccionarExamen1.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnSeleccionarExamen1.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnSeleccionarExamen1.ImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.IsToggleButton = false;
			this.btnSeleccionarExamen1.IsToggled = false;
			this.btnSeleccionarExamen1.Location = new System.Drawing.Point(200, 12);
			this.btnSeleccionarExamen1.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnSeleccionarExamen1.Name = "btnSeleccionarExamen1";
			this.btnSeleccionarExamen1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen1.NormalForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.NormalOutline = System.Drawing.Color.Empty;
			this.btnSeleccionarExamen1.OutlineThickness = 2F;
			this.btnSeleccionarExamen1.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnSeleccionarExamen1.PressedForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.PressedImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen1.PressedOutline = System.Drawing.Color.Empty;
			this.btnSeleccionarExamen1.Rounding = new System.Windows.Forms.Padding(0);
			this.btnSeleccionarExamen1.Size = new System.Drawing.Size(36, 32);
			this.btnSeleccionarExamen1.TabIndex = 157;
			this.btnSeleccionarExamen1.TextAutoCenter = true;
			this.btnSeleccionarExamen1.TextOffset = new System.Drawing.Point(0, 0);
			this.btnSeleccionarExamen1.Click += new System.EventHandler(this.btnSeleccionarExamen1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 23);
			this.label3.TabIndex = 156;
			this.label3.Text = "Seleccionar examen";
			// 
			// rpvExamen2
			// 
			this.rpvExamen2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rpvExamen2.Location = new System.Drawing.Point(15, 50);
			this.rpvExamen2.Name = "rpvExamen2";
			this.rpvExamen2.ServerReport.BearerToken = null;
			this.rpvExamen2.Size = new System.Drawing.Size(529, 621);
			this.rpvExamen2.TabIndex = 155;
			this.rpvExamen2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
			// 
			// btnSeleccionarExamen2
			// 
			this.btnSeleccionarExamen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen2.ButtonText = "+";
			this.btnSeleccionarExamen2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen2.CheckedForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.CheckedImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeleccionarExamen2.CustomDialogResult = System.Windows.Forms.DialogResult.None;
			this.btnSeleccionarExamen2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionarExamen2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
			this.btnSeleccionarExamen2.HoverForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.HoverImage = null;
			this.btnSeleccionarExamen2.HoverImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.HoverOutline = System.Drawing.Color.Empty;
			this.btnSeleccionarExamen2.Image = null;
			this.btnSeleccionarExamen2.ImageAutoCenter = false;
			this.btnSeleccionarExamen2.ImageExpand = new System.Drawing.Point(-2, -2);
			this.btnSeleccionarExamen2.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnSeleccionarExamen2.ImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.IsToggleButton = false;
			this.btnSeleccionarExamen2.IsToggled = false;
			this.btnSeleccionarExamen2.Location = new System.Drawing.Point(201, 11);
			this.btnSeleccionarExamen2.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
			this.btnSeleccionarExamen2.Name = "btnSeleccionarExamen2";
			this.btnSeleccionarExamen2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.btnSeleccionarExamen2.NormalForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.NormalOutline = System.Drawing.Color.Empty;
			this.btnSeleccionarExamen2.OutlineThickness = 2F;
			this.btnSeleccionarExamen2.PressedBackground = System.Drawing.Color.MidnightBlue;
			this.btnSeleccionarExamen2.PressedForeColor = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.PressedImageTint = System.Drawing.Color.White;
			this.btnSeleccionarExamen2.PressedOutline = System.Drawing.Color.Empty;
			this.btnSeleccionarExamen2.Rounding = new System.Windows.Forms.Padding(0);
			this.btnSeleccionarExamen2.Size = new System.Drawing.Size(36, 32);
			this.btnSeleccionarExamen2.TabIndex = 154;
			this.btnSeleccionarExamen2.TextAutoCenter = true;
			this.btnSeleccionarExamen2.TextOffset = new System.Drawing.Point(0, 0);
			this.btnSeleccionarExamen2.Click += new System.EventHandler(this.btnSeleccionarExamen2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 23);
			this.label4.TabIndex = 153;
			this.label4.Text = "Seleccionar examen";
			// 
			// txtNombrePaciente
			// 
			this.txtNombrePaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombrePaciente.FillReadOnlyColor = System.Drawing.Color.White;
			this.txtNombrePaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNombrePaciente.Location = new System.Drawing.Point(514, 37);
			this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombrePaciente.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtNombrePaciente.Name = "txtNombrePaciente";
			this.txtNombrePaciente.Padding = new System.Windows.Forms.Padding(5);
			this.txtNombrePaciente.ReadOnly = true;
			this.txtNombrePaciente.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtNombrePaciente.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtNombrePaciente.ShowText = false;
			this.txtNombrePaciente.Size = new System.Drawing.Size(337, 41);
			this.txtNombrePaciente.TabIndex = 160;
			this.txtNombrePaciente.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtNombrePaciente.Watermark = "";
			this.txtNombrePaciente.WatermarkColor = System.Drawing.Color.DimGray;
			// 
			// txtDNIPaciente
			// 
			this.txtDNIPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDNIPaciente.FillReadOnlyColor = System.Drawing.Color.White;
			this.txtDNIPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDNIPaciente.Location = new System.Drawing.Point(22, 37);
			this.txtDNIPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDNIPaciente.MinimumSize = new System.Drawing.Size(1, 16);
			this.txtDNIPaciente.Name = "txtDNIPaciente";
			this.txtDNIPaciente.Padding = new System.Windows.Forms.Padding(5);
			this.txtDNIPaciente.ReadOnly = true;
			this.txtDNIPaciente.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtDNIPaciente.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
			this.txtDNIPaciente.ShowText = false;
			this.txtDNIPaciente.Size = new System.Drawing.Size(191, 41);
			this.txtDNIPaciente.TabIndex = 161;
			this.txtDNIPaciente.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtDNIPaciente.Watermark = "";
			this.txtDNIPaciente.WatermarkColor = System.Drawing.Color.DimGray;
			// 
			// FrmHistorialExamen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 891);
			this.Controls.Add(this.txtDNIPaciente);
			this.Controls.Add(this.txtNombrePaciente);
			this.Controls.Add(this.spcContenedor);
			this.Controls.Add(this.rbComparar);
			this.Controls.Add(this.sataTextBox1);
			this.Controls.Add(this.rbExamen);
			this.Controls.Add(this.sataTextBox8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAgregarPaciente);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmHistorialExamen";
			this.Text = "FrmHistorialExamen";
			this.Load += new System.EventHandler(this.FrmHistorialExamen_Load);
			this.spcContenedor.Panel1.ResumeLayout(false);
			this.spcContenedor.Panel1.PerformLayout();
			this.spcContenedor.Panel2.ResumeLayout(false);
			this.spcContenedor.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).EndInit();
			this.spcContenedor.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private FrameworkTest.SATAButton btnAgregarPaciente;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Sunny.UI.UIRadioButton rbExamen;
		private SATATextBox sataTextBox8;
		private Sunny.UI.UIRadioButton rbComparar;
		private SATATextBox sataTextBox1;
		private System.Windows.Forms.SplitContainer spcContenedor;
		private Microsoft.Reporting.WinForms.ReportViewer rpvExamen1;
		private FrameworkTest.SATAButton btnSeleccionarExamen1;
		private System.Windows.Forms.Label label3;
		private Microsoft.Reporting.WinForms.ReportViewer rpvExamen2;
		private FrameworkTest.SATAButton btnSeleccionarExamen2;
		private System.Windows.Forms.Label label4;
		private Sunny.UI.UITextBox txtNombrePaciente;
		private Sunny.UI.UITextBox txtDNIPaciente;
	}
}