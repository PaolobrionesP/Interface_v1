namespace Interface
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelPuerto = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTP = new System.Windows.Forms.Panel();
            this.labelPara = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.Label();
            this.value3 = new System.Windows.Forms.Label();
            this.value4 = new System.Windows.Forms.Label();
            this.value5 = new System.Windows.Forms.Label();
            this.panelTelemetria = new System.Windows.Forms.Panel();
            this.panelTT = new System.Windows.Forms.Panel();
            this.labelTele = new System.Windows.Forms.Label();
            this.panelTPort = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.save2 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.save3 = new System.Windows.Forms.Button();
            this.save4 = new System.Windows.Forms.Button();
            this.save5 = new System.Windows.Forms.Button();
            this.toggleButtonDarkTheme = new Interface.Controls.ToggleButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelPuerto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelParameters.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTP.SuspendLayout();
            this.panelTelemetria.SuspendLayout();
            this.panelTT.SuspendLayout();
            this.panelTPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(104)))));
            this.panelTitle.Controls.Add(this.toggleButtonDarkTheme);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1602, 40);
            this.panelTitle.TabIndex = 1;
            // 
            // panelPuerto
            // 
            this.panelPuerto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.panelPuerto.Controls.Add(this.labelBaud);
            this.panelPuerto.Controls.Add(this.labelPort);
            this.panelPuerto.Controls.Add(this.comboBoxBaud);
            this.panelPuerto.Controls.Add(this.comboBoxPort);
            this.panelPuerto.Controls.Add(this.panelTPort);
            this.panelPuerto.Location = new System.Drawing.Point(1092, 63);
            this.panelPuerto.Name = "panelPuerto";
            this.panelPuerto.Size = new System.Drawing.Size(422, 293);
            this.panelPuerto.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 392);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Presion";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            series2.YValuesPerPoint = 4;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Acelerometro";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Giroscopio";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Magnetometro";
            series5.YValuesPerPoint = 3;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(879, 335);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // panelParameters
            // 
            this.panelParameters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.panelParameters.Controls.Add(this.panel4);
            this.panelParameters.Controls.Add(this.panel3);
            this.panelParameters.Controls.Add(this.panel6);
            this.panelParameters.Controls.Add(this.panel5);
            this.panelParameters.Controls.Add(this.panel2);
            this.panelParameters.Controls.Add(this.panelTP);
            this.panelParameters.Location = new System.Drawing.Point(28, 63);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(1058, 293);
            this.panelParameters.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.save3);
            this.panel4.Controls.Add(this.value3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Location = new System.Drawing.Point(425, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 195);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.save2);
            this.panel3.Controls.Add(this.value2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Location = new System.Drawing.Point(219, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 195);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.save5);
            this.panel6.Controls.Add(this.value5);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.checkBox5);
            this.panel6.Location = new System.Drawing.Point(837, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 195);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.save4);
            this.panel5.Controls.Add(this.value4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.checkBox4);
            this.panel5.Location = new System.Drawing.Point(631, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 195);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.save1);
            this.panel2.Controls.Add(this.value1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(13, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 195);
            this.panel2.TabIndex = 0;
            // 
            // panelTP
            // 
            this.panelTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(115)))), ((int)(((byte)(155)))));
            this.panelTP.Controls.Add(this.labelPara);
            this.panelTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTP.Location = new System.Drawing.Point(0, 0);
            this.panelTP.Name = "panelTP";
            this.panelTP.Size = new System.Drawing.Size(1058, 44);
            this.panelTP.TabIndex = 0;
            // 
            // labelPara
            // 
            this.labelPara.AutoSize = true;
            this.labelPara.Font = new System.Drawing.Font("Consolas", 22F);
            this.labelPara.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPara.Location = new System.Drawing.Point(217, 0);
            this.labelPara.Name = "labelPara";
            this.labelPara.Size = new System.Drawing.Size(219, 43);
            this.labelPara.TabIndex = 0;
            this.labelPara.Text = "PARAMETROS";
            this.labelPara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox1.Location = new System.Drawing.Point(18, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 22);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Visible";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox2.Location = new System.Drawing.Point(23, 155);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 22);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Visible";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox3.Location = new System.Drawing.Point(24, 155);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 22);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Visible";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox4.Location = new System.Drawing.Point(20, 155);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 22);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Visible";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox5.Location = new System.Drawing.Point(16, 155);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 22);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Visible";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(39, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRESION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "TEMPERATURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(20, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "GIROSCOPIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(16, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "ACELEROMETRO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "MAGNETOMETRO";
            // 
            // value1
            // 
            this.value1.AutoSize = true;
            this.value1.Location = new System.Drawing.Point(50, 83);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(40, 16);
            this.value1.TabIndex = 3;
            this.value1.Text = "value";
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.Location = new System.Drawing.Point(42, 83);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(40, 16);
            this.value2.TabIndex = 3;
            this.value2.Text = "value";
            // 
            // value3
            // 
            this.value3.AutoSize = true;
            this.value3.Location = new System.Drawing.Point(42, 83);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(40, 16);
            this.value3.TabIndex = 3;
            this.value3.Text = "value";
            // 
            // value4
            // 
            this.value4.AutoSize = true;
            this.value4.Location = new System.Drawing.Point(60, 83);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(40, 16);
            this.value4.TabIndex = 3;
            this.value4.Text = "value";
            // 
            // value5
            // 
            this.value5.AutoSize = true;
            this.value5.Location = new System.Drawing.Point(63, 83);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(40, 16);
            this.value5.TabIndex = 3;
            this.value5.Text = "value";
            // 
            // panelTelemetria
            // 
            this.panelTelemetria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTelemetria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.panelTelemetria.Controls.Add(this.panelTT);
            this.panelTelemetria.Location = new System.Drawing.Point(913, 392);
            this.panelTelemetria.Name = "panelTelemetria";
            this.panelTelemetria.Size = new System.Drawing.Size(601, 335);
            this.panelTelemetria.TabIndex = 0;
            // 
            // panelTT
            // 
            this.panelTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(115)))), ((int)(((byte)(155)))));
            this.panelTT.Controls.Add(this.labelTele);
            this.panelTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTT.Location = new System.Drawing.Point(0, 0);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(601, 44);
            this.panelTT.TabIndex = 1;
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Font = new System.Drawing.Font("Consolas", 22F);
            this.labelTele.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTele.Location = new System.Drawing.Point(183, 0);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(219, 43);
            this.labelTele.TabIndex = 0;
            this.labelTele.Text = "TELEMETRIA";
            this.labelTele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTPort
            // 
            this.panelTPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(115)))), ((int)(((byte)(155)))));
            this.panelTPort.Controls.Add(this.label6);
            this.panelTPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTPort.Location = new System.Drawing.Point(0, 0);
            this.panelTPort.Name = "panelTPort";
            this.panelTPort.Size = new System.Drawing.Size(422, 44);
            this.panelTPort.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 22F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(76, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 43);
            this.label6.TabIndex = 0;
            this.label6.Text = "PUERTO SERIAL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(101, 146);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(60, 31);
            this.save2.TabIndex = 4;
            this.save2.Text = "Save";
            this.save2.UseVisualStyleBackColor = true;
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(96, 146);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(60, 31);
            this.save1.TabIndex = 4;
            this.save1.Text = "Save";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // save3
            // 
            this.save3.Location = new System.Drawing.Point(114, 146);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(60, 31);
            this.save3.TabIndex = 4;
            this.save3.Text = "Save";
            this.save3.UseVisualStyleBackColor = true;
            // 
            // save4
            // 
            this.save4.Location = new System.Drawing.Point(114, 146);
            this.save4.Name = "save4";
            this.save4.Size = new System.Drawing.Size(60, 31);
            this.save4.TabIndex = 4;
            this.save4.Text = "Save";
            this.save4.UseVisualStyleBackColor = true;
            // 
            // save5
            // 
            this.save5.Location = new System.Drawing.Point(109, 146);
            this.save5.Name = "save5";
            this.save5.Size = new System.Drawing.Size(60, 31);
            this.save5.TabIndex = 4;
            this.save5.Text = "Save";
            this.save5.UseVisualStyleBackColor = true;
            // 
            // toggleButtonDarkTheme
            // 
            this.toggleButtonDarkTheme.Location = new System.Drawing.Point(28, 7);
            this.toggleButtonDarkTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonDarkTheme.Name = "toggleButtonDarkTheme";
            this.toggleButtonDarkTheme.OffBackColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonDarkTheme.OffToggleColor = System.Drawing.Color.DarkGray;
            this.toggleButtonDarkTheme.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toggleButtonDarkTheme.OnToggleColor = System.Drawing.SystemColors.Window;
            this.toggleButtonDarkTheme.Size = new System.Drawing.Size(56, 26);
            this.toggleButtonDarkTheme.TabIndex = 5;
            this.toggleButtonDarkTheme.UseVisualStyleBackColor = true;
            this.toggleButtonDarkTheme.CheckedChanged += new System.EventHandler(this.toggleButtonDarkTheme_CheckedChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(214, 83);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(152, 24);
            this.comboBoxPort.TabIndex = 3;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(214, 188);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(152, 24);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPort.Location = new System.Drawing.Point(81, 86);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(112, 20);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Puerto COM :";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBaud.Location = new System.Drawing.Point(81, 191);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(98, 20);
            this.labelBaud.TabIndex = 4;
            this.labelBaud.Text = "Baud Rate :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1602, 793);
            this.Controls.Add(this.panelParameters);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelTelemetria);
            this.Controls.Add(this.panelPuerto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelPuerto.ResumeLayout(false);
            this.panelPuerto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelParameters.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTP.ResumeLayout(false);
            this.panelTP.PerformLayout();
            this.panelTelemetria.ResumeLayout(false);
            this.panelTT.ResumeLayout(false);
            this.panelTT.PerformLayout();
            this.panelTPort.ResumeLayout(false);
            this.panelTPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelPuerto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Controls.ToggleButton toggleButtonDarkTheme;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Panel panelTP;
        private System.Windows.Forms.Label labelPara;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label value3;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Label value5;
        private System.Windows.Forms.Label value4;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Panel panelTelemetria;
        private System.Windows.Forms.Panel panelTT;
        private System.Windows.Forms.Label labelTele;
        private System.Windows.Forms.Panel panelTPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Button save5;
        private System.Windows.Forms.Button save4;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

