using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smith;

namespace SmithyAsociados
{
    public partial class AccesoTitular : Form
    {
        public AccesoTitular()
        {
            InitializeComponent();
        }
        ConexionBD con = new ConexionBD();        
        public  int ID3;
        public   string tipo;

        public void ValidarTitular()
        {
          //  setID(con.consultarID("Select id_usuario from usuarioabogado where nombreusuario = (" + "'" + txtUsuario.Text + "'" + ") and (contraseña = (" + "'" + txtContraseña.Text + "'" + "));"));
            //setTipo(con.consultarTipo("Select tipoabogado from abogado where ID_abogado = (" + ID3 + ")"));
          
            if ((String.IsNullOrEmpty(txtContraseña.Text)) || (String.IsNullOrEmpty(txtUsuario.Text)))
            {
                MessageBox.Show("Debe llenar los campos correspondientes"); 
            }else //BORRAR ESTE ELSE DESPUES DE AGEGAR EL PRIMER ABOGADO TITULAR.
        //    else if ((this.ID3 <= 0) || (tipo.Equals("Auxiliar")))
        //  {
        //     MessageBox.Show("Error al tratar de accesar, es probable que no tenga privilegios para esta configuracion");
               
        // }
        //else if (this.tipo.Equals("Titular"))
            {
                TipoUsuario T = new TipoUsuario();
                T.Show();
                this.Hide();
            }
        }
        public void setID(int BID)
        {

            this.ID3 = BID;
        }
        public void setTipo(string t)
        {

            this.tipo = t;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidarTitular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            this.Hide();
        }
    }
}
