using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SmithyAsociados
{
    public partial class NuevoAbogado : Form
    {
        public NuevoAbogado()
        {
            InitializeComponent();
        }
        public int id;
        public void GuardarAbogado()
        {
         
            ConexionBD c = new ConexionBD();
           
            String com1 = ("INSERT INTO bfabogados.abogado ( Nombre, TipoAbogado, Direccion, Correo, Telefono) VALUES (" + "'" + txtNombre.Text + "'" + ", " + "'" + txtTipo.Text + "'" + ", " + "'" + txtDireccion.Text + "'" + ", " + "'" + txtCorreo.Text + "'" + ", " + "'" + txtTelefono.Text + "'" + " );");
            c.ejecutar(com1);
             id = c.consultarID("SELECT ID_Abogado FROM bfabogados.abogado where nombre = (" + "'" + txtNombre.Text + "'" + ");");
            
             String com2 = ("INSERT INTO bfabogados.usuarioabogado ( nombreusuario, contraseña, abogado_id_abogado) VALUES (" + "'" + txtUsuario.Text + "'" + ", " + "'" + txtContraseña.Text + "'" + "," + "'" + id + "'" + " );");
             c.ejecutar(com2);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarAbogado();
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

        

       
    }
}
