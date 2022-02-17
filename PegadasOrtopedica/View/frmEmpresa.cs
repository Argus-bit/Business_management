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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            pnlEmpresa.Location = new Point(Width / 2 - 129, Height / 2 - 127); //posiciona o painel ao centro
            lalDadosEmpresariais.Location = new Point(Width / 2 - 102, Height / 2 + 150);//posiciona o laybel ao centro
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroDaEmpresa sh = new frmCadastroDaEmpresa();
            sh.Show();
        }

        private void pnlEmpresa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lalDadosEmpresariais_Click(object sender, EventArgs e)
        {

        }
    }
}
