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
    public partial class ModificarAgenda : Form
    {
        public ModificarAgenda()
        {
            InitializeComponent();
            llenarAgenda();
           
        }
        ConexionBD con = new ConexionBD();
        Busqueda B = new Busqueda();
        int _BuID = Busqueda.ID ;
        string nombre ;
        public static int id_a;
        public static string Des;

        
        public void llenarAgenda()
          
        {
            String _SQL = "SELECT fecha, descripcion, nombre, correo from Agenda, Abogado where agenda.abogado_id_abogado = (" + _BuID + ") and (abogado.id_abogado = (" + _BuID + "));";
            con.ActualizarTabla(dataAgendas, _SQL);
            
        }

        public void NuevoDatoAgenda(String fecha, String descripcion , int ID)
        {
            con.ejecutar("INSERT INTO agenda (fecha, descripcion, abogado_id_abogado) values (" + "'" + fecha + "'" + ", " + "'" + descripcion + "'" + "," +  ID  + ")");
        }
        public void actualizar(int ID)
        {
           
            String sqlcomando;
            sqlcomando = "UPDATE agenda SET fecha = (" + "'" + txtfecha.Text + "'" + "), descripcion = (" + "'" + txtDescripcion.Text + "'" + ") where id_agenda = ("+ ID+") ";
            con.ejecutar(sqlcomando);
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataAgendas.Rows[e.RowIndex];
                txtfecha.Text = row.Cells["Fecha"].Value.ToString();
              Des =  txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
              
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevoDatoAgenda(txtfecha.Text,txtDescripcion.Text, _BuID);
            llenarAgenda();
            txtDescripcion.Text = "";
            txtfecha.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

          
             id_a = con.consultarID("select id_Agenda from agenda where descripcion = ('"+Des+"')");
           
            actualizar(id_a);
            llenarAgenda();
            txtDescripcion.Text = "";
            txtfecha.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }
    }
}
