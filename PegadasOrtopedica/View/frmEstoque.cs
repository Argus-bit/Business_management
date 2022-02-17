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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroDeProduto sh = new frmCadastroDeProduto();
            sh.Show();
        }
    }
}
