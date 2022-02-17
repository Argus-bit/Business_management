using PegadasOrtopedica.Forms.FormsCadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegadasOrtopedica.Forms
{
    public partial class frmRecursosHumanos : Form
    {
        public frmRecursosHumanos()
        {
            InitializeComponent();
        }

        private void frmRecursosHumanos_Load(object sender, EventArgs e)
        {
            pictApresentacao.Location = new Point(Width / 2, Height / 2 - 300);
            lblListagemDeFuncionario.Location = new Point(Width / 2 - 20, Height / 2 - 150);
            dgvRH.Location = new Point(Width / 2- 65, Height / 2 - 100);
            btnNovoCadastro.Location = new Point(Width / 2 + 200 , Height / 2 + 200);
            btnEditarCadastro.Location = new Point(Width / 2, Height / 2 + 200);
            btnExcluirCadastro.Location = new Point(Width / 2 - 200 , Height / 2 + 200);
        }
        private void pictApresentacao_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroDeFuncionario sh = new frmCadastroDeFuncionario();
            sh.ShowDialog();
            sh.Dispose();
        }
    }
}
