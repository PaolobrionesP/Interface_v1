using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 10;
            foreach (Series series in chart1.Series)
            {
                series.Points.AddXY(10, i); 
                series.Points.AddXY(20, i+10);
                series.Points.AddXY(30, i+10);
                series.Points.AddXY(40, i+10);
                series.Points.AddXY(50, i+10);
                i += 10;
            }

            
        }

        private void toggleButtonDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            // Obtiene la leyenda del chart
            Legend chartLegend = chart1.Legends["Legend1"];
            ChartArea chartArea = chart1.ChartAreas["ChartArea1"];

            List<string> panelNames = new List<string> { "panel2", "panel3", "panel4", "panel5", "panel6" };
            Color myColor1 = Color.FromArgb(46, 52, 59);  // Fondo de subpaneles oscuro
            Color myColor2 = SystemColors.InactiveCaption;  // Fondo de subpaneles claro


            // DARK THEME
            if (toggleButtonDarkTheme.Checked)
            {
                this.BackColor = Color.FromArgb(33, 37, 41);

                // Color de Subpaneles Parametros
                foreach (Panel panel in panelParameters.Controls.OfType<Panel>())
                {
                    if (panelNames.Contains(panel.Name))
                    {
                        panel.BackColor = myColor1;
                    }
                }

                // Tema oscuro para el chart: fondo, leyenda, ejes
                chart1.BackColor = Color.FromArgb(42, 46, 50);
                chartLegend.BackColor = Color.FromArgb(42, 46, 50);
                chartLegend.ForeColor = Color.White;
                chartArea.AxisX.LineColor = Color.LightGray;
                chartArea.AxisY.LineColor = Color.LightGray;
                chartArea.AxisX.MajorTickMark.LineColor = Color.LightGray;
                chartArea.AxisY.MajorTickMark.LineColor = Color.LightGray;
                chartArea.AxisX.LabelStyle.ForeColor = Color.White;
                chartArea.AxisY.LabelStyle.ForeColor = Color.White;
                
                
                // Paneles
                panelTitle.BackColor= Color.FromArgb(55, 60, 64);
                panelTP.BackColor = Color.FromArgb(55, 60, 64);
                panelTT.BackColor = Color.FromArgb(55, 60, 64);
                panelTPort.BackColor = Color.FromArgb(55, 60, 64);
                panelParameters.BackColor = Color.FromArgb(42, 46, 50);
                panelPuerto.BackColor = Color.FromArgb(42, 46, 50);
                panelTelemetria.BackColor = Color.FromArgb(42, 46, 50);

                // Etiquetas
                labelPara.ForeColor = Color.White;
                labelTele.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                value1.ForeColor = Color.White;
                value2.ForeColor = Color.White;
                value3.ForeColor = Color.White;
                value4.ForeColor = Color.White;
                value5.ForeColor = Color.White;
                labelPort.ForeColor = Color.White;
                labelBaud.ForeColor = Color.White;

                // Color del texto de las checkBox
                checkBox1.ForeColor = SystemColors.Window;
                checkBox2.ForeColor = SystemColors.Window;
                checkBox3.ForeColor = SystemColors.Window;
                checkBox4.ForeColor = SystemColors.Window;
                checkBox5.ForeColor = SystemColors.Window;
            }

            // LIGHT THEME
            else
            {
                this.BackColor = SystemColors.Control;

                // Color de Subpaneles Parametros
                foreach (Panel panel in panelParameters.Controls.OfType<Panel>())
                {
                    if (panelNames.Contains(panel.Name))
                    {
                        panel.BackColor = myColor2;
                    }
                }

                // Tema claro para el chart: fondo, leyenda, ejes
                chart1.BackColor = Color.FromArgb(208, 213, 220);
                chartLegend.BackColor = Color.FromArgb(208, 213, 220);
                chartLegend.ForeColor = SystemColors.WindowText;
                chartArea.AxisX.LineColor = Color.Black;
                chartArea.AxisY.LineColor = Color.Black;
                chartArea.AxisX.LabelStyle.ForeColor = Color.Black;
                chartArea.AxisY.LabelStyle.ForeColor = Color.Black;
                chartArea.AxisX.MajorTickMark.LineColor = Color.Black;
                chartArea.AxisY.MajorTickMark.LineColor = Color.Black;

                // Paneles
                panelTitle.BackColor = Color.FromArgb(77, 84, 104);
                panelTP.BackColor = Color.FromArgb(86, 112, 150);
                panelTT.BackColor = Color.FromArgb(86, 112, 150);
                panelTPort.BackColor = Color.FromArgb(86, 112, 150);
                panelPuerto.BackColor = Color.FromArgb(208, 213, 220);
                panelParameters.BackColor = Color.FromArgb(208, 213, 220);
                panelTelemetria.BackColor = Color.FromArgb(208, 213, 220);

                // Etiquetas
                labelPara.ForeColor = Color.White;
                labelTele.ForeColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                value1.ForeColor = Color.Black;
                value2.ForeColor = Color.Black;
                value3.ForeColor = Color.Black;
                value4.ForeColor = Color.Black;
                value5.ForeColor = Color.Black;
                labelPort.ForeColor = Color.Black;
                labelBaud.ForeColor = Color.Black;

                // Color del texto de las checkBox
                checkBox1.ForeColor = SystemColors.WindowText;
                checkBox2.ForeColor = SystemColors.WindowText;
                checkBox3.ForeColor = SystemColors.WindowText;
                checkBox4.ForeColor = SystemColors.WindowText;
                checkBox5.ForeColor = SystemColors.WindowText;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Text = "Visible";
                chart1.Series["Presion"].Enabled = true;
            }
            else
            {
                checkBox1.Text = "Oculto";
                chart1.Series["Presion"].Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Visible";
                chart1.Series["Temperatura"].Enabled = true;
            }
            else
            {
                checkBox2.Text = "Oculto";
                chart1.Series["Temperatura"].Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Visible";
                chart1.Series["Acelerometro"].Enabled = true;
            }
            else
            {
                checkBox3.Text = "Oculto";
                chart1.Series["Acelerometro"].Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Text = "Visible";
                chart1.Series["Giroscopio"].Enabled = true;
            }
            else
            {
                checkBox4.Text = "Oculto";
                chart1.Series["Giroscopio"].Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Text = "Visible";
                chart1.Series["Magnetometro"].Enabled = true;
            }
            else
            {
                checkBox5.Text = "Oculto";
                chart1.Series["Magnetometro"].Enabled = false;
            }
        }

        private void save1_Click(object sender, EventArgs e)
        {
            // Seleccionar la serie que se va a guardar
            var selectedSeries = chart1.Series[0];

            // Crear un objeto StringBuilder para almacenar los datos de la serie
            StringBuilder sb = new StringBuilder();

            // Agregar los puntos de datos de la serie al StringBuilder
            foreach (var point in selectedSeries.Points)
            {
                sb.AppendLine(point.XValue.ToString() + "," + point.YValues[0].ToString());
            }

            // Guardar los datos de la serie en un archivo de texto
            File.WriteAllText("datos_serie.txt", sb.ToString());

            MessageBox.Show("Los datos de la serie se han guardado correctamente en el archivo datos_serie.txt.");
        }
    }
}
