using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nome_idade_pessoa
{
    public partial class FRMPrincipal : Form
    {
        public FRMPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            lblNome2.Text = txtnome.Text;
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            lblIdade.Text = txtIdade.Text;
        }
    }
}
