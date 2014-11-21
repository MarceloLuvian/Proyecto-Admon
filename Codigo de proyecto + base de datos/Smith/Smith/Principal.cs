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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public static String boton;

        
        public void SetdesactivarBoton()
        {
            btnMAgenda.Visible = false;
        }
        private void btnMAgenda_Click(object sender, EventArgs e)
        {

            boton = btnMAgenda.Text;           
            Busqueda b = new Busqueda();
            b.Show();
            this.Hide();
            
            
        }

        private void btnCAgenda_Click(object sender, EventArgs e)
        {
            boton = btnCAgenda.Text;            
            Busqueda b = new Busqueda();
            b.Show();
            this.Hide();
          
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            this.Hide();
        }
    }
}
