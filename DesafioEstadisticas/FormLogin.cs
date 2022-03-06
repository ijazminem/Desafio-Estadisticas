using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesafioEstadisticas

{


    public partial class FormLogin : Form


    {

        public FormLogin()
        {
            InitializeComponent();



        }
        

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
        
        private void iniciarsesion_Click(object sender, EventArgs e)
        {

            Usuarios[] arrayUsuarios = new Usuarios[6];
            arrayUsuarios[0] = new Usuarios("pablo1", "abc123", "libros");
            arrayUsuarios[1] = new Usuarios("julio2", "xyz000", "programacion");
            arrayUsuarios[2] = new Usuarios("ana95", "lapiz", "tv");
            arrayUsuarios[3] = new Usuarios("roxyx", "arbol", "programacion");
            arrayUsuarios[4] = new Usuarios("josejose", "gato", "tv");
            arrayUsuarios[5] = new Usuarios("jessyj", "coco", "libros");

            string user = txtusuario.Text;
            string clave = txtcontra.Text;
            Boolean ingreso = false;



            if (user.Equals(arrayUsuarios[0].getusername()) && (clave.Equals(arrayUsuarios[0].getpass())))
            {

                this.Hide();
                ingreso = true;
                FormPantalla fpantalla = new FormPantalla();
                fpantalla.ShowDialog();

            }
            if (user.Equals(arrayUsuarios[1].getusername()) && (clave.Equals(arrayUsuarios[1].getpass())))
            {

                this.Hide();
                ingreso = true;
                FormPantalla1 fpantalla1 = new FormPantalla1();
                fpantalla1.ShowDialog();

            }
            if (user.Equals(arrayUsuarios[2].getusername()) && (clave.Equals(arrayUsuarios[2].getpass())))
            {

                this.Hide();
                ingreso = true;
                FormPantalla2 fpantalla2 = new FormPantalla2();
                fpantalla2.ShowDialog();

            }
            if (user.Equals(arrayUsuarios[3].getusername()) && (clave.Equals(arrayUsuarios[3].getpass())))
            {

                this.Hide();
                ingreso = true;
                FormPantalla1 fpantalla1 = new FormPantalla1();
                fpantalla1.ShowDialog();

            }
            if (user.Equals(arrayUsuarios[4].getusername()) && (clave.Equals(arrayUsuarios[4].getpass())))
            {

                this.Hide();
                ingreso = true;
                FormPantalla2 fpantalla2 = new FormPantalla2();
                fpantalla2.ShowDialog();

            }
            if (user.Equals(arrayUsuarios[5].getusername()) && (clave.Equals(arrayUsuarios[5].getpass())))
            {

                this.Hide();
                ingreso = true;
                FormPantalla fpantalla = new FormPantalla();
                fpantalla.ShowDialog();

            }
            if (ingreso == false) 
            {
                MessageBox.Show("El usuario que ingresó no está registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


    }

    public class Usuarios
    {


        public Usuarios(string username, string pass, string tipo)
        {
            this.username = username;
            this.pass = pass;
            this.tipo = tipo;


        }

        public string getusername()
        {
            return username;
        }

        public string getpass()
        {
            return pass;
        }

  

        string username;
        string pass;
        string tipo;


    }
}
