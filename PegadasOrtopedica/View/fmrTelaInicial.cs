using PegadasOrtopedica.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegadasOrtopedica
{
    
    public partial class frmPrincipal : Form
    {
        private Button currentButton;
        //private int tempIndex;
        public Form activeForm;
        



        public frmPrincipal()
        {
            InitializeComponent();
            btnHome.Visible = false;
        }

         private void ActivateButton ( object btnSender )  
         {
            if ( btnSender != null ) 
            {
                if ( currentButton != ( Button ) btnSender ) 
                {
                    DisableButton() ;
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnHome.Visible = true;
                }
            }
         }
        private void DisableButton ()  
        {
            foreach (Control previousBtn in pnlMenu.Controls) 
            {
                if ( previousBtn.GetType() == typeof ( Button )) 
                {
                    previousBtn.BackColor = Color.FromArgb ( 51 , 51 , 76 ) ;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            //Função: Fechar painel da Home para que outros forms apareçam.
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            lblTitle.Text = childForm.Text;
            childForm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        //Utilizado para que seja maximizado porém apresentado a barra de tarefas inferior
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)

        {
            OpenChildForm(new frmEmpresa(), sender);//Chama Form frmEmpresa dentro do Panel
        }
        
        private void btnCliente_Click(object sender, EventArgs e) //Chama Form frmClientes dentro do Panel
        {
            OpenChildForm(new frmClientes(), sender);
        }
        
        private void btnFornecedor_Click(object sender, EventArgs e) //Chama Form frmFornecedor dentro do Panel
        {
            OpenChildForm(new frmFornecedor(), sender);
        }
        
        private void btnEstoque_Click(object sender, EventArgs e) //Chama Form frmfrmEstoque dentro do Panel
        {
            OpenChildForm(new frmEstoque(), sender);
        }
        
        private void btnRH_Click(object sender, EventArgs e) //Chama Form frmRecursosHumanos dentro do Panel
        {
            OpenChildForm(new frmRecursosHumanos(), sender);
        }
        
        private void btnVenda_Click(object sender, EventArgs e) //Chama Form frmVendas dentro do Panel
        {
            OpenChildForm(new frmVendas(), sender);
        }
        
        private void btnCompra_Click(object sender, EventArgs e) //Chama Form frmCompras dentro do Panel
        {
            OpenChildForm(new frmCompras(), sender);
        }
        
        private void btnRelatorio_Click(object sender, EventArgs e) //Chama Form frmRelatorio dentro do Panel
        {
            OpenChildForm(new frmRelatorio(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            currentButton = null;
            btnHome.Visible = false;
        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        //Botão para fechar o programa.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*Botão que realiza a função de Maximizar
         * Deixando o botão de cima invisível
         */
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        /*Botão par realizar a restauação de aba
         deixando o botão de baixo invisível*/

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        //Método para Minimizar Aba.
        private void btnMinimiar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Possibilita movimento pelo Painel de apresentação

        bool mover = false;
        Point posicaoInicial;
        private void panelTitleBar_Paint(object sender, PaintEventArgs e) {}

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
            if(mover)//Se a variável mover for true
            {

                Point novo = PointToScreen(e.Location);//Declaramos um novo ponto com as cordenadas do mouse (e.Location)
                Location = new Point(novo.X - posicaoInicial.X, novo.Y - posicaoInicial.Y);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmLançamentoFinanceiro sh = new frmLançamentoFinanceiro();
            sh.ShowDialog();
            sh.Dispose();
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
