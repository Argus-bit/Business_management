using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PegadasOrtopedica.Forms.FormsCadastro;
namespace PegadasOrtopedica.Forms
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSolicitacaoDePedido sh = new frmSolicitacaoDePedido();
            sh.Show();
        }
    }
}
