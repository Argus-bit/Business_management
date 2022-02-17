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
    public partial class frmCadastroDaEmpresa : Form
    {
        public frmCadastroDaEmpresa()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarcampos();
        }
        private void habilitarcampos ()
        {
            mtbCnpj.Enabled = true;
            mtbRazaoSocial.Enabled = true;
            txtNomeFatasia.Enabled = true;
            txtInscricaoEstadual.Enabled = true;
            txtInscricaoMunicipal.Enabled = true;
            dtpDatadeAbertura.Enabled = true;
            cboTipodeAtividade.Enabled = true;
            cboCrt.Enabled = true;
            cboCnaePricipal.Enabled = true;
            cboRegimeEspecialServico.Enabled = true;
            mtbCep.Enabled = true;
            mtbRua.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cboUf.Enabled = true;
            txtPais.Enabled = true;
            txtComplemento.Enabled = true;
            btnLimpar.Enabled = true;
        }
    }
}
