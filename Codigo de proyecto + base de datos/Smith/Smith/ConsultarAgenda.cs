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
    public partial class ConsultarAgenda : Form
    {
        public ConsultarAgenda()
        {
            InitializeComponent();
            llenarAgenda();
        }
        ConexionBD con = new ConexionBD();
        Busqueda B = new Busqueda();
        int _BuID = Busqueda.ID;


        public void llenarAgenda()
        {

            String _SQL = "SELECT fecha, descripcion, nombre, correo from Agenda, Abogado where agenda.abogado_id_abogado = (" + _BuID + ") and (abogado.id_abogado = (" + _BuID + "));";
            con.ActualizarTabla(dataAgendas, _SQL);
        }
        private void ConsultarAgenda_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarAgenda m = new ModificarAgenda();
            m.Show();
            this.Hide();
        }

        private void btnRegresarPrincipal_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
