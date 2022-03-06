using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DesafioEstadisticas
{
    public partial class FormPantalla1 : Form
    {
        public FormPantalla1()
        {
            InitializeComponent();
        }

        private void btncerrar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormPantalla1_Load(object sender, EventArgs e)
        {
            string[] series = { "Python", "JAVA", "Javascript", "PHP", "C y C++", "otros" };
            int[] puntos = { 26, 21, 8, 8, 7, 15 };

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

        }
    }
}
