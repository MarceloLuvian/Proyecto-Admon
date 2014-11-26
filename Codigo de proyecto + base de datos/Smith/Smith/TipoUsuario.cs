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
    public partial class TipoUsuario : Form
    {
        public TipoUsuario()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            NuevoAbogado N = new NuevoAbogado();
            N.Show();
            this.Hide();
        }

        private void btnSecretaria_Click(object sender, EventArgs e)
        {
            AsignacionSecretaria  a = new AsignacionSecretaria();
            a.Show();
            this.Hide();
        }
    }
}
