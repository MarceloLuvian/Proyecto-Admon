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
    public partial class NuevaSecretaria : Form
    {
        public NuevaSecretaria()
        {
            InitializeComponent();
        }


        ConexionBD c = new ConexionBD();
        AsignacionSecretaria a = new AsignacionSecretaria();
        int ID;
        

        public void GuardarSecretaria()    {


                ID = a.getID();
                MessageBox.Show("es: a");

            String com1 = ("INSERT INTO bfabogados.secretaria ( Nombre, Direccion, Correo, Telefono, abogado_id_abogado) VALUES (" + "'" + txtNombre.Text + "'" + ", " + "'" + txtDireccion.Text + "'" + ", " + "'" + txtCorreo.Text + "'" + ", " + "'" + txtTelefono.Text + "'" + ","+ ID  + " );");
            c.ejecutar(com1);


            int ID2 = c.consultarID("SELECT ID_secretaria FROM bfabogados.secretaria where nombre = (" + "'" + txtNombre.Text + "'" + ");");

            String com2 = ("INSERT INTO bfabogados.usuariosecretaria ( nombreusuario, contraseña, secretaria_id_secretaria) VALUES (" + "'" + txtUsuario.Text + "'" + ", " + "'" + txtContraseña.Text + "'" + "," + "'" + ID2 + "'" + " );");
            c.ejecutar(com2);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarSecretaria();
            Inicio i = new Inicio();
            i.Show();
            this.Hide();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio I = new Inicio();
            I.Show();
            this.Hide();

        }

        private void NuevaSecretaria_Load(object sender, EventArgs e)
        {

        }

    }
}
