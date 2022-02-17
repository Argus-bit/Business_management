using System;
using System.Windows.Forms;
using PegadasOrtopedica.Forms;
using PegadasOrtopedica.Forms.FormsCadastro;

namespace PegadasOrtopedica.Forms
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroClientes sh = new frmCadastroClientes();
            sh.ShowDialog();
            sh.Dispose();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
