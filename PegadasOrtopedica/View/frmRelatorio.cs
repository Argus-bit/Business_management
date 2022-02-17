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
    public partial class frmRelatorio : Form
    {

        public frmRelatorio()
        {
            InitializeComponent();
            {

            }
        }

        public void frmRelatorio_Load(object sender, EventArgs e)
        {
            pictRelatorio.Location = new Point(Width / 2 - 80, Height / 2 - 300);
            dgvEntrada.Location = new Point(Width / 2 - 270, Height / 2 - 100);
            dgvSaida.Location = new Point(Width / 2 + 60, Height / 2 - 100);
            dtpInicio.Location = new Point(Width / 2 - 260, Height / 2 + 200 );
            dtpFim.Location = new Point(Width / 2 + 60, Height / 2 + 200);
        }

        private void pictRelatorio_Click(object sender, EventArgs e)
        {

        }

    }
}
