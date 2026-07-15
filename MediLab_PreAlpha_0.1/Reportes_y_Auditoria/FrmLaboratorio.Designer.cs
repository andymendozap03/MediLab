namespace CapaPresentacion.Formularios
{
    partial class FrmLaboratorio
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
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.btnGenerar = new FrameworkTest.SATAButton();
            this.rvLaboratorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.lblDiaMes1 = new System.Windows.Forms.Label();
            this.cmbDiaSem = new SATAComboBox();
            this.lblHorasMes2 = new System.Windows.Forms.Label();
            this.cmbMes = new SATAComboBox();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCantidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSolicitados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msAgrupar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiaSemana = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHora = new System.Windows.Forms.ToolStripMenuItem();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlIntervalo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new SATAUiFramework.Controls.SATADateTimePicker();
            this.dtpDesde = new SATAUiFramework.Controls.SATADateTimePicker();
            this.btnLimpiar = new FrameworkTest.SATAButton();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.rbFiltro = new System.Windows.Forms.RadioButton();
            this.rbIntervalo = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.pnlIntervalo.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(11, 40);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(193, 19);
            this.lblSeleccion.TabIndex = 146;
            this.lblSeleccion.Text = "Tipo de reporte seleccionado:";
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(208, 40);
            this.lblTipoReporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(0, 19);
            this.lblTipoReporte.TabIndex = 152;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnGenerar.ButtonText = "Generar";
            this.btnGenerar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnGenerar.CheckedForeColor = System.Drawing.Color.White;
            this.btnGenerar.CheckedImageTint = System.Drawing.Color.White;
            this.btnGenerar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
            this.btnGenerar.HoverForeColor = System.Drawing.Color.White;
            this.btnGenerar.HoverImage = null;
            this.btnGenerar.HoverImageTint = System.Drawing.Color.White;
            this.btnGenerar.HoverOutline = System.Drawing.Color.Empty;
            this.btnGenerar.Image = null;
            this.btnGenerar.ImageAutoCenter = false;
            this.btnGenerar.ImageExpand = new System.Drawing.Point(-2, -2);
            this.btnGenerar.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnGenerar.ImageTint = System.Drawing.Color.White;
            this.btnGenerar.IsToggleButton = false;
            this.btnGenerar.IsToggled = false;
            this.btnGenerar.Location = new System.Drawing.Point(537, 190);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnGenerar.NormalForeColor = System.Drawing.Color.White;
            this.btnGenerar.NormalOutline = System.Drawing.Color.Empty;
            this.btnGenerar.OutlineThickness = 2F;
            this.btnGenerar.PressedBackground = System.Drawing.Color.MidnightBlue;
            this.btnGenerar.PressedForeColor = System.Drawing.Color.White;
            this.btnGenerar.PressedImageTint = System.Drawing.Color.White;
            this.btnGenerar.PressedOutline = System.Drawing.Color.Empty;
            this.btnGenerar.Rounding = new System.Windows.Forms.Padding(0);
            this.btnGenerar.Size = new System.Drawing.Size(153, 35);
            this.btnGenerar.TabIndex = 141;
            this.btnGenerar.TextAutoCenter = true;
            this.btnGenerar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rvLaboratorio
            // 
            this.rvLaboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvLaboratorio.Location = new System.Drawing.Point(12, 231);
            this.rvLaboratorio.Name = "rvLaboratorio";
            this.rvLaboratorio.ServerReport.BearerToken = null;
            this.rvLaboratorio.ShowToolBar = false;
            this.rvLaboratorio.Size = new System.Drawing.Size(841, 435);
            this.rvLaboratorio.TabIndex = 140;
            this.rvLaboratorio.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(11, 68);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(88, 19);
            this.lblFiltro.TabIndex = 154;
            this.lblFiltro.Text = "Agrupar por:";
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFiltro.Location = new System.Drawing.Point(103, 68);
            this.lblTipoFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(57, 19);
            this.lblTipoFiltro.TabIndex = 155;
            this.lblTipoFiltro.Text = "General";
            // 
            // lblDiaMes1
            // 
            this.lblDiaMes1.AutoSize = true;
            this.lblDiaMes1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaMes1.Location = new System.Drawing.Point(280, 7);
            this.lblDiaMes1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaMes1.Name = "lblDiaMes1";
            this.lblDiaMes1.Size = new System.Drawing.Size(117, 19);
            this.lblDiaMes1.TabIndex = 60;
            this.lblDiaMes1.Text = "Dia de la Semana";
            // 
            // cmbDiaSem
            // 
            this.cmbDiaSem.BackColor = System.Drawing.Color.Transparent;
            this.cmbDiaSem.BackgroundColor = System.Drawing.Color.White;
            this.cmbDiaSem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmbDiaSem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbDiaSem.BorderThickness = 1;
            this.cmbDiaSem.CornerRadius = 5;
            this.cmbDiaSem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiaSem.Items = new string[] {
        "Domingo",
        "Lunes",
        "Martes",
        "Miercoles",
        "Jueves",
        "Viernes",
        "Sabado"};
            this.cmbDiaSem.Keys = null;
            this.cmbDiaSem.Location = new System.Drawing.Point(269, 33);
            this.cmbDiaSem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDiaSem.Name = "cmbDiaSem";
            this.cmbDiaSem.SelectedIndex = -1;
            this.cmbDiaSem.Size = new System.Drawing.Size(144, 33);
            this.cmbDiaSem.TabIndex = 156;
            this.cmbDiaSem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbDiaSem.TextOffset = new System.Windows.Forms.Padding(0);
            // 
            // lblHorasMes2
            // 
            this.lblHorasMes2.AutoSize = true;
            this.lblHorasMes2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasMes2.Location = new System.Drawing.Point(181, 8);
            this.lblHorasMes2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorasMes2.Name = "lblHorasMes2";
            this.lblHorasMes2.Size = new System.Drawing.Size(35, 19);
            this.lblHorasMes2.TabIndex = 162;
            this.lblHorasMes2.Text = "Mes";
            // 
            // cmbMes
            // 
            this.cmbMes.BackColor = System.Drawing.Color.Transparent;
            this.cmbMes.BackgroundColor = System.Drawing.Color.White;
            this.cmbMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmbMes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbMes.BorderThickness = 1;
            this.cmbMes.CornerRadius = 5;
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMes.Items = new string[] {
        "Enero",
        "Febrero",
        "Marzo",
        "Abril",
        "Mayo",
        "Junio",
        "Julio",
        "Agosto",
        "Septiembre",
        "Octubre",
        "Noviembre",
        "Diciembre"};
            this.cmbMes.Keys = null;
            this.cmbMes.Location = new System.Drawing.Point(140, 33);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.SelectedIndex = -1;
            this.cmbMes.Size = new System.Drawing.Size(120, 33);
            this.cmbMes.TabIndex = 161;
            this.cmbMes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbMes.TextOffset = new System.Windows.Forms.Padding(0);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCantidad,
            this.mnuSolicitados});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(171, 23);
            this.reportesToolStripMenuItem.Text = "Seleccionar tipo reporte";
            // 
            // mnuCantidad
            // 
            this.mnuCantidad.Name = "mnuCantidad";
            this.mnuCantidad.Size = new System.Drawing.Size(340, 24);
            this.mnuCantidad.Text = "Cantidad de examens realizados (General)";
            this.mnuCantidad.Click += new System.EventHandler(this.reporteGeneralToolStripMenuItem_Click);
            // 
            // mnuSolicitados
            // 
            this.mnuSolicitados.Name = "mnuSolicitados";
            this.mnuSolicitados.Size = new System.Drawing.Size(340, 24);
            this.mnuSolicitados.Text = "Examenes más solicitados";
            this.mnuSolicitados.Click += new System.EventHandler(this.examenesToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.msAgrupar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(865, 27);
            this.menuStrip1.TabIndex = 142;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msAgrupar
            // 
            this.msAgrupar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAno,
            this.mnuMes,
            this.mnuDiaSemana,
            this.mnuHora});
            this.msAgrupar.Name = "msAgrupar";
            this.msAgrupar.Size = new System.Drawing.Size(96, 23);
            this.msAgrupar.Text = "Agrupar por";
            // 
            // mnuAno
            // 
            this.mnuAno.Name = "mnuAno";
            this.mnuAno.Size = new System.Drawing.Size(186, 24);
            this.mnuAno.Text = "Año";
            this.mnuAno.Click += new System.EventHandler(this.mnuAno_Click);
            // 
            // mnuMes
            // 
            this.mnuMes.Name = "mnuMes";
            this.mnuMes.Size = new System.Drawing.Size(186, 24);
            this.mnuMes.Text = "Mes";
            this.mnuMes.Click += new System.EventHandler(this.mnuMes_Click);
            // 
            // mnuDiaSemana
            // 
            this.mnuDiaSemana.Name = "mnuDiaSemana";
            this.mnuDiaSemana.Size = new System.Drawing.Size(186, 24);
            this.mnuDiaSemana.Text = "Dia de la Semana";
            this.mnuDiaSemana.Click += new System.EventHandler(this.mnuDiaSemana_Click);
            // 
            // mnuHora
            // 
            this.mnuHora.Name = "mnuHora";
            this.mnuHora.Size = new System.Drawing.Size(186, 24);
            this.mnuHora.Text = "Hora";
            this.mnuHora.Click += new System.EventHandler(this.mnuHora_Click);
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.nudAno.Location = new System.Drawing.Point(5, 37);
            this.nudAno.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(120, 25);
            this.nudAno.TabIndex = 165;
            this.nudAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAno.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 164;
            this.label5.Text = "Año";
            // 
            // pnlIntervalo
            // 
            this.pnlIntervalo.BackColor = System.Drawing.Color.Silver;
            this.pnlIntervalo.Controls.Add(this.label1);
            this.pnlIntervalo.Controls.Add(this.label2);
            this.pnlIntervalo.Controls.Add(this.dtpHasta);
            this.pnlIntervalo.Controls.Add(this.dtpDesde);
            this.pnlIntervalo.Location = new System.Drawing.Point(438, 140);
            this.pnlIntervalo.Name = "pnlIntervalo";
            this.pnlIntervalo.Size = new System.Drawing.Size(415, 44);
            this.pnlIntervalo.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.BackColor = System.Drawing.Color.Transparent;
            this.dtpHasta.BackgroundColor = System.Drawing.Color.White;
            this.dtpHasta.BorderColor = System.Drawing.Color.LightGray;
            this.dtpHasta.BorderThickness = 1;
            this.dtpHasta.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Checked = false;
            this.dtpHasta.CornerRadius = 5;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(257, 12);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(116, 25);
            this.dtpHasta.TabIndex = 93;
            // 
            // dtpDesde
            // 
            this.dtpDesde.BackColor = System.Drawing.Color.Transparent;
            this.dtpDesde.BackgroundColor = System.Drawing.Color.White;
            this.dtpDesde.BorderColor = System.Drawing.Color.LightGray;
            this.dtpDesde.BorderThickness = 1;
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Checked = false;
            this.dtpDesde.CornerRadius = 5;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(69, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(116, 25);
            this.dtpDesde.TabIndex = 92;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
            this.btnLimpiar.ButtonText = "Limpiar Filtros";
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
            this.btnLimpiar.Location = new System.Drawing.Point(700, 190);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
            this.btnLimpiar.NormalForeColor = System.Drawing.Color.White;
            this.btnLimpiar.NormalOutline = System.Drawing.Color.Empty;
            this.btnLimpiar.OutlineThickness = 2F;
            this.btnLimpiar.PressedBackground = System.Drawing.Color.MidnightBlue;
            this.btnLimpiar.PressedForeColor = System.Drawing.Color.White;
            this.btnLimpiar.PressedImageTint = System.Drawing.Color.White;
            this.btnLimpiar.PressedOutline = System.Drawing.Color.Empty;
            this.btnLimpiar.Rounding = new System.Windows.Forms.Padding(0);
            this.btnLimpiar.Size = new System.Drawing.Size(153, 35);
            this.btnLimpiar.TabIndex = 167;
            this.btnLimpiar.TextAutoCenter = true;
            this.btnLimpiar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "Cantidad de examens realizados (General)",
            "Examenes más solicitados"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(732, 48);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReporte.TabIndex = 153;
            this.cmbTipoReporte.Visible = false;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.Silver;
            this.pnlFiltro.Controls.Add(this.cmbDiaSem);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Controls.Add(this.cmbMes);
            this.pnlFiltro.Controls.Add(this.lblHorasMes2);
            this.pnlFiltro.Controls.Add(this.lblDiaMes1);
            this.pnlFiltro.Controls.Add(this.nudAno);
            this.pnlFiltro.Location = new System.Drawing.Point(12, 140);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(420, 76);
            this.pnlFiltro.TabIndex = 169;
            // 
            // rbFiltro
            // 
            this.rbFiltro.AutoSize = true;
            this.rbFiltro.Location = new System.Drawing.Point(14, 117);
            this.rbFiltro.Name = "rbFiltro";
            this.rbFiltro.Size = new System.Drawing.Size(93, 17);
            this.rbFiltro.TabIndex = 170;
            this.rbFiltro.TabStop = true;
            this.rbFiltro.Text = "Habilitar Filtros";
            this.rbFiltro.UseVisualStyleBackColor = true;
            this.rbFiltro.CheckedChanged += new System.EventHandler(this.rbFiltro_CheckedChanged);
            // 
            // rbIntervalo
            // 
            this.rbIntervalo.AutoSize = true;
            this.rbIntervalo.Location = new System.Drawing.Point(438, 117);
            this.rbIntervalo.Name = "rbIntervalo";
            this.rbIntervalo.Size = new System.Drawing.Size(107, 17);
            this.rbIntervalo.TabIndex = 171;
            this.rbIntervalo.TabStop = true;
            this.rbIntervalo.Text = "Habilitar Intervalo";
            this.rbIntervalo.UseVisualStyleBackColor = true;
            this.rbIntervalo.CheckedChanged += new System.EventHandler(this.rbIntervalo_CheckedChanged);
            // 
            // FrmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 678);
            this.Controls.Add(this.rbIntervalo);
            this.Controls.Add(this.rbFiltro);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlIntervalo);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblTipoFiltro);
            this.Controls.Add(this.cmbTipoReporte);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.lblTipoReporte);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.rvLaboratorio);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLaboratorio";
            this.Text = "FrmLaboratorio";
            this.Load += new System.EventHandler(this.FrmLaboratorio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.pnlIntervalo.ResumeLayout(false);
            this.pnlIntervalo.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblTipoReporte;
        private FrameworkTest.SATAButton btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer rvLaboratorio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.Label lblDiaMes1;
        private SATAComboBox cmbDiaSem;
        private System.Windows.Forms.Label lblHorasMes2;
        private SATAComboBox cmbMes;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCantidad;
        private System.Windows.Forms.ToolStripMenuItem mnuSolicitados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msAgrupar;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlIntervalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SATAUiFramework.Controls.SATADateTimePicker dtpHasta;
        private SATAUiFramework.Controls.SATADateTimePicker dtpDesde;
        private FrameworkTest.SATAButton btnLimpiar;
        private System.Windows.Forms.ToolStripMenuItem mnuAno;
        private System.Windows.Forms.ToolStripMenuItem mnuMes;
        private System.Windows.Forms.ToolStripMenuItem mnuDiaSemana;
        private System.Windows.Forms.ToolStripMenuItem mnuHora;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.RadioButton rbFiltro;
        private System.Windows.Forms.RadioButton rbIntervalo;
    }
}