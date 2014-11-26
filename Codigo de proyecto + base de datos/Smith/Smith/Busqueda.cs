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
    public partial class Busqueda : Form
    {
        public Busqueda()
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
                        identificar(boton);
                    }
                    
                }
                public void identificar(String boton)
                {
                    if (boton.Equals("Modificar agenda"))
                    {
                        ModificarAgenda M = new ModificarAgenda();
                        M.Show();
                        this.Hide();

                    }
                    else
                    {
                    
                        ConsultarAgenda C = new ConsultarAgenda();
                        C.Show();
                        this.Hide();
                    }

                }
                public void setID(int BID)
                {

                    ID = BID;
                }
               

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Buscar();
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal i = new Principal();
            i.Show();
            this.Hide();
        }

       

       
    }
}
