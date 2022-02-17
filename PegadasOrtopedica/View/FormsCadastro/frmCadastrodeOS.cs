using PegadasOrtopedica.Forms.GerarRecibo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegadasOrtopedica.Forms.FormsCadastro
{
    public partial class frmCadastrodeOS : Form
    {
        public frmCadastrodeOS()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGerarRecibo sh = new frmGerarRecibo();
            sh.ShowDialog();
            sh.Dispose();
        }
    }
}
