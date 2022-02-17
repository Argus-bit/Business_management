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
    public partial class frmCadastroClientes : Form
    {
        //Método para hábilitar campo Pessoa Física
        private void habilitarCampos_pf()
        {
            txtPaciente.Enabled = true;
            mtbCpf.Enabled = true;
            dtpDataDeNascimento.Enabled = true;
            txtResponsavel.Enabled = true;
            txtTelefoneUm.Enabled = true;
            mtbTelefoneUm.Enabled = true;
            txtTelefone2.Enabled = true;
            mtbTelefone2.Enabled = true;
            txtTelefone3.Enabled = true;
            mtbTelefone3.Enabled = true;
            txtTelefone4.Enabled = true;
            mtbTelefone4.Enabled = true;
            txtEmail.Enabled = true;

            mtbCep.Enabled = true;
            txtRua.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cboUf.Enabled = true;
            txtPais.Enabled = true;
            txtComplemento.Enabled = true;
        }
        //Método para hábilitar campo Pessoa Jurídica
        private void habilitarCampos_pj()
        {
            mtbCnpj.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtResponsavelpj.Enabled = true;
            mtbInscricaoEstadual.Enabled = true;
            mtbInscricaoMunicipal.Enabled = true;
            txtTelefone1pj.Enabled = true;
            mtbTelefone1pj.Enabled = true;
            txtTelefone2pj.Enabled = true;
            mtbTelefone2pj.Enabled = true;
            txtTelefone3pj.Enabled = true;
            mtbTelefone3pj.Enabled = true;
            txtTelefone4pj.Enabled = true;
            mtbTelefone4pj.Enabled = true;
            mtbEmailpj.Enabled = true;
            mtbSite.Enabled = true;
            mtbCeppj.Enabled = true;
            mtbRua.Enabled = true;
            txtNumeropj.Enabled = true;
            txtBairropj.Enabled = true;
            txtCidadepj.Enabled = true;
            cboUfpj.Enabled = true;
            txtPaispj.Enabled = true;
            txtComplementopj.Enabled = true;
        }

        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos_pf();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            habilitarCampos_pj();
        }
    }
}
