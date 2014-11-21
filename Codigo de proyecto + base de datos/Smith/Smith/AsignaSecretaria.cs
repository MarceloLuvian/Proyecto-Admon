using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmithyAsociados;

namespace Smith
{
    public partial class AsignacionSecretaria : Form
    {
        public AsignacionSecretaria()
        {
            InitializeComponent();
        }

        ConexionBD con = new ConexionBD();
        Principal P = new Principal();
        String boton = Principal.boton;
        public static int ID;


        public void Buscar()
        {

            setID(ID = con.consultarID("Select id_abogado from abogado where nombre = (" + "'" + txtNombre.Text + "'" + ");"));
            MessageBox.Show("es: " + ID);
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar los campos correspondientes");
            }
            else if ((ID <= 0))
            {
                MessageBox.Show("ABOGADO NO ENCONTRADO, FAVOR DE REVISAR EL NOMBRE.");
            
            }
            else
            {
                NuevaSecretaria n = new NuevaSecretaria();
                n.Show();
                this.Hide();
            }

        }
        public void setID(int ide)
        {
            ID = ide;
        }
        public int getID()
        {
            return ID;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            this.Hide();
            i.Show();
        }
    }
}
