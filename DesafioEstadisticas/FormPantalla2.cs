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
    public partial class FormPantalla2 : Form
    {
        public FormPantalla2()
        {
            InitializeComponent();
        }

        private void btncerrar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void FormPantalla2_Load(object sender, EventArgs e)
        {
            string[] series = { "Informativos", "Ficción", "Culturales", "Entretenimiento", "Deportes", "Otros" };
            int[] puntos = { 26, 21, 19, 16, 13, 6 };

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
    }
}
