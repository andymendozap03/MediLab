namespace CapaPresentacion.Formularios
{
    partial class FrmFacturacion
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
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new FrameworkTest.SATAButton();
            this.txtGenero = new Sunny.UI.UITextBox();
            this.txtEdad = new Sunny.UI.UITextBox();
            this.txtPaciente = new Sunny.UI.UITextBox();
            this.txtSolicitud = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarSolicitud = new FrameworkTest.SATAButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new FrameworkTest.SATAButton();
            this.btnGuardar = new FrameworkTest.SATAButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new Sunny.UI.UITextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.AllowUserToAddRows = false;
            this.dgvFacturacion.AllowUserToDeleteRows = false;
            this.dgvFacturacion.AllowUserToResizeRows = false;
            this.dgvFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Examen,
            this.Precio});
            this.dgvFacturacion.EnableHeadersVisualStyles = false;
            this.dgvFacturacion.Location = new System.Drawing.Point(27, 256);
            this.dgvFacturacion.MultiSelect = false;
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturacion.RowHeadersVisible = false;
            this.dgvFacturacion.RowHeadersWidth = 51;
            this.dgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturacion.Size = new System.Drawing.Size(723, 167);
            this.dgvFacturacion.TabIndex = 42;
            // 
            // Examen
            // 
            this.Examen.HeaderText = "Examen";
            this.Examen.Name = "Examen";
            this.Examen.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.btnLimpiar.ButtonText = "Limpiar";
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
            this.btnLimpiar.Location = new System.Drawing.Point(582, 45);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
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
            this.btnLimpiar.Size = new System.Drawing.Size(168, 42);
            this.btnLimpiar.TabIndex = 191;
            this.btnLimpiar.TextAutoCenter = true;
            this.btnLimpiar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenero.FillReadOnlyColor = System.Drawing.Color.White;
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGenero.Location = new System.Drawing.Point(509, 129);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGenero.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Padding = new System.Windows.Forms.Padding(4);
            this.txtGenero.ReadOnly = true;
            this.txtGenero.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtGenero.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtGenero.ShowText = false;
            this.txtGenero.Size = new System.Drawing.Size(105, 33);
            this.txtGenero.TabIndex = 190;
            this.txtGenero.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGenero.Watermark = "";
            this.txtGenero.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // txtEdad
            // 
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.FillReadOnlyColor = System.Drawing.Color.White;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEdad.Location = new System.Drawing.Point(345, 129);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEdad.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Padding = new System.Windows.Forms.Padding(4);
            this.txtEdad.ReadOnly = true;
            this.txtEdad.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtEdad.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtEdad.ShowText = false;
            this.txtEdad.Size = new System.Drawing.Size(89, 33);
            this.txtEdad.TabIndex = 189;
            this.txtEdad.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEdad.Watermark = "";
            this.txtEdad.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaciente.FillReadOnlyColor = System.Drawing.Color.White;
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaciente.Location = new System.Drawing.Point(93, 129);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaciente.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Padding = new System.Windows.Forms.Padding(4);
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtPaciente.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtPaciente.ShowText = false;
            this.txtPaciente.Size = new System.Drawing.Size(191, 33);
            this.txtPaciente.TabIndex = 188;
            this.txtPaciente.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPaciente.Watermark = "";
            this.txtPaciente.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSolicitud.FillReadOnlyColor = System.Drawing.Color.White;
            this.txtSolicitud.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSolicitud.Location = new System.Drawing.Point(33, 54);
            this.txtSolicitud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSolicitud.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.Padding = new System.Windows.Forms.Padding(4);
            this.txtSolicitud.ReadOnly = true;
            this.txtSolicitud.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtSolicitud.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtSolicitud.ShowText = false;
            this.txtSolicitud.Size = new System.Drawing.Size(137, 33);
            this.txtSolicitud.TabIndex = 187;
            this.txtSolicitud.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSolicitud.Watermark = "";
            this.txtSolicitud.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 186;
            this.label5.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 185;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 184;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 183;
            this.label1.Text = "Datos del paciente";
            // 
            // btnAgregarSolicitud
            // 
            this.btnAgregarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnAgregarSolicitud.ButtonText = "+";
            this.btnAgregarSolicitud.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnAgregarSolicitud.CheckedForeColor = System.Drawing.Color.White;
            this.btnAgregarSolicitud.CheckedImageTint = System.Drawing.Color.White;
            this.btnAgregarSolicitud.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnAgregarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSolicitud.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarSolicitud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSolicitud.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
            this.btnAgregarSolicitud.HoverForeColor = System.Drawing.Color.White;
            this.btnAgregarSolicitud.HoverImage = null;
            this.btnAgregarSolicitud.HoverImageTint = System.Drawing.Color.White;
            this.btnAgregarSolicitud.HoverOutline = System.Drawing.Color.Empty;
            this.btnAgregarSolicitud.Image = null;
            this.btnAgregarSolicitud.ImageAutoCenter = false;
            this.btnAgregarSolicitud.ImageExpand = new System.Drawing.Point(-2, -2);
            this.btnAgregarSolicitud.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAgregarSolicitud.ImageTint = System.Drawing.Color.White;
            this.btnAgregarSolicitud.IsToggleButton = false;
            this.btnAgregarSolicitud.IsToggled = false;
            this.btnAgregarSolicitud.Location = new System.Drawing.Point(184, 54);
            this.btnAgregarSolicitud.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregarSolicitud.Name = "btnAgregarSolicitud";
            this.btnAgregarSolicitud.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnAgregarSolicitud.NormalForeColor = System.Drawing.Color.White;
            this.btnAgregarSolicitud.NormalOutline = System.Drawing.Color.Empty;
            this.btnAgregarSolicitud.OutlineThickness = 2F;
            this.btnAgregarSolicitud.PressedBackground = System.Drawing.Color.MidnightBlue;
            this.btnAgregarSolicitud.PressedForeColor = System.Drawing.Color.White;
            this.btnAgregarSolicitud.PressedImageTint = System.Drawing.Color.White;
            this.btnAgregarSolicitud.PressedOutline = System.Drawing.Color.Empty;
            this.btnAgregarSolicitud.Rounding = new System.Windows.Forms.Padding(0);
            this.btnAgregarSolicitud.Size = new System.Drawing.Size(38, 38);
            this.btnAgregarSolicitud.TabIndex = 182;
            this.btnAgregarSolicitud.TextAutoCenter = true;
            this.btnAgregarSolicitud.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAgregarSolicitud.Click += new System.EventHandler(this.btnAgregarSolicitud_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 180;
            this.label13.Text = "Solicitud";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(88, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 20);
            this.label14.TabIndex = 181;
            this.label14.Text = "*";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitulo.Controls.Add(this.label6);
            this.pnlTitulo.Location = new System.Drawing.Point(35, 197);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(694, 37);
            this.pnlTitulo.TabIndex = 193;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 37);
            this.label6.TabIndex = 159;
            this.label6.Text = "PRECIO EXAMENES";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 492);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(773, 54);
            this.tableLayoutPanel2.TabIndex = 195;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnCancelar.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelar.CheckedImageTint = System.Drawing.Color.White;
            this.btnCancelar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
            this.btnCancelar.HoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverImage = null;
            this.btnCancelar.HoverImageTint = System.Drawing.Color.White;
            this.btnCancelar.HoverOutline = System.Drawing.Color.Empty;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageAutoCenter = false;
            this.btnCancelar.ImageExpand = new System.Drawing.Point(-2, -2);
            this.btnCancelar.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCancelar.ImageTint = System.Drawing.Color.White;
            this.btnCancelar.IsToggleButton = false;
            this.btnCancelar.IsToggled = false;
            this.btnCancelar.Location = new System.Drawing.Point(228, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnCancelar.NormalForeColor = System.Drawing.Color.White;
            this.btnCancelar.NormalOutline = System.Drawing.Color.Empty;
            this.btnCancelar.OutlineThickness = 2F;
            this.btnCancelar.PressedBackground = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.PressedForeColor = System.Drawing.Color.White;
            this.btnCancelar.PressedImageTint = System.Drawing.Color.White;
            this.btnCancelar.PressedOutline = System.Drawing.Color.Empty;
            this.btnCancelar.Rounding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Size = new System.Drawing.Size(153, 35);
            this.btnCancelar.TabIndex = 153;
            this.btnCancelar.TextAutoCenter = true;
            this.btnCancelar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(391, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
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
            this.btnGuardar.Size = new System.Drawing.Size(153, 35);
            this.btnGuardar.TabIndex = 154;
            this.btnGuardar.TextAutoCenter = true;
            this.btnGuardar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 15);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 19);
            this.lblTotal.TabIndex = 194;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.FillReadOnlyColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotal.Location = new System.Drawing.Point(48, 8);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(4);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtTotal.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.txtTotal.ShowText = false;
            this.txtTotal.Size = new System.Drawing.Size(105, 33);
            this.txtTotal.TabIndex = 191;
            this.txtTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTotal.Watermark = "";
            this.txtTotal.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 47);
            this.panel1.TabIndex = 196;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(608, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 47);
            this.panel2.TabIndex = 195;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtSolicitud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarSolicitud);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private FrameworkTest.SATAButton btnLimpiar;
        private Sunny.UI.UITextBox txtGenero;
        private Sunny.UI.UITextBox txtEdad;
        private Sunny.UI.UITextBox txtPaciente;
        private Sunny.UI.UITextBox txtSolicitud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FrameworkTest.SATAButton btnAgregarSolicitud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FrameworkTest.SATAButton btnCancelar;
        private FrameworkTest.SATAButton btnGuardar;
        private System.Windows.Forms.Label lblTotal;
        private Sunny.UI.UITextBox txtTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}