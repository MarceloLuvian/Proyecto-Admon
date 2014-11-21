using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmithyAsociados
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        ConexionBD con = new ConexionBD();
        public  int ID2;
        public  string tipo;



        public void ValidarUsuario()
        {
            setID(ID2 = con.consultarID("Select id_usuario from usuarioabogado where nombreusuario = (" + "'" + txtUsuario.Text + "'" + ") and (contraseña = (" + "'" + txtContraseña.Text + "'" + "));"));
            if ((String.IsNullOrEmpty(txtContraseña.Text)) || (String.IsNullOrEmpty(txtUsuario.Text)))
            {
                MessageBox.Show("Debe llenar los campos correspondientes");
            }
            else if ((this.ID2 <= 0)) //
            {
                MessageBox.Show("Error al tratar de accesar");

            }
            else if (this.ID2 >= 1)
            {
                Principal P = new Principal();                
                P.Show();
                this.Hide();
            }            
        }
        public void setID(int BID)
        {

            this.ID2 = BID;
        }
        public void setTipo(string t)
        {

            this.tipo = t;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
         
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void lblNuevoUsuario_Click(object sender, EventArgs e)
        {
            AccesoTitular A = new AccesoTitular();
            A.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
