using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PegadasOrtopedica;

namespace PegadasOrtopedica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Botão Conectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }
        private void ChamarLogin()
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                //Se estiverem Vazios aparecerá a mensagem "Preencha os Campos"
                MessageBox.Show("Preencha os Campos");
                //Leva o cursor para o txtUsuário
                txtUsuario.Focus();
                //Retorna o teste para finalizar.
                return;
            }
            //Caso passe pelo teste o form abre a Tela inicial
            frmPrincipal sh = new frmPrincipal();
            this.Hide();
            Limpar();
            sh.Show();
        }
        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }


        bool mover = false;
        Point posicaoInicial;

        private void geral_MouseDown(object sender, MouseEventArgs e)//Evento que ocorre quando o botão direito do mouse é prescionado
        {

            mover = true;// variavel mover fica true

            posicaoInicial = new Point(e.X, e.Y);//declarado pontos do atribudo Point
        }
        private void geral_MouseUp(object sender, MouseEventArgs e)//Evento que ocorre após despressionar o botão
        {
            mover = false;
        }

        private void geral_MouseMove(object sender, MouseEventArgs e) //Evento do movimento do mouse enquanto precionado
        {
            if (mover)//Se a variável mover for true
            {

                Point novo = PointToScreen(e.Location);//Declaramos um novo ponto com as cordenadas do mouse (e.Location)
                Location = new Point(novo.X - posicaoInicial.X, novo.Y - posicaoInicial.Y);
            }
        }



        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
