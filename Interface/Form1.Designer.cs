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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toggleButtonDarkTheme = new Interface.Controls.ToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(104)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1902, 40);
            this.panelTitle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.panel1.Location = new System.Drawing.Point(778, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 208);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Presión",
            "Temperatura",
            "Acerelerómetro",
            "Giroscopio",
            "Magnetometro"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(210, 154);
            this.checkedListBox1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(42, 531);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 318);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(800, 310);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // toggleButtonDarkTheme
            // 
            this.toggleButtonDarkTheme.Location = new System.Drawing.Point(42, 64);
            this.toggleButtonDarkTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonDarkTheme.Name = "toggleButtonDarkTheme";
            this.toggleButtonDarkTheme.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonDarkTheme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonDarkTheme.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.toggleButtonDarkTheme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonDarkTheme.Size = new System.Drawing.Size(72, 33);
            this.toggleButtonDarkTheme.TabIndex = 5;
            this.toggleButtonDarkTheme.UseVisualStyleBackColor = true;
            this.toggleButtonDarkTheme.CheckedChanged += new System.EventHandler(this.toggleButtonDarkTheme_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1902, 933);
            this.Controls.Add(this.toggleButtonDarkTheme);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Controls.ToggleButton toggleButtonDarkTheme;
    }
}

