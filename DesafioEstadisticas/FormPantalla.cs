using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DesafioEstadisticas
{
    public partial class FormPantalla : Form
    {
        public FormPantalla()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
        }

        private void FormPantalla_Load(object sender, EventArgs e)
        {
            string[] series = { "Terror", "Ficción", "Bélico", "Fantasía", "otros" };
            int[] puntos = { 58 , 43 , 30, 18, 17 };

            for( int i = 0; i< series.Length;i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
    }
}
