
namespace PegadasOrtopedica.Forms
{
    partial class frmRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.pictRelatorio = new System.Windows.Forms.PictureBox();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.dgvSaida = new System.Windows.Forms.DataGridView();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // pictRelatorio
            // 
            this.pictRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("pictRelatorio.Image")));
            this.pictRelatorio.Location = new System.Drawing.Point(328, -66);
            this.pictRelatorio.Name = "pictRelatorio";
            this.pictRelatorio.Size = new System.Drawing.Size(190, 189);
            this.pictRelatorio.TabIndex = 0;
            this.pictRelatorio.TabStop = false;
            this.pictRelatorio.Click += new System.EventHandler(this.pictRelatorio_Click);
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(165, 138);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.Size = new System.Drawing.Size(240, 254);
            this.dgvEntrada.TabIndex = 1;
            // 
            // dgvSaida
            // 
            this.dgvSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaida.Location = new System.Drawing.Point(450, 138);
            this.dgvSaida.Name = "dgvSaida";
            this.dgvSaida.Size = new System.Drawing.Size(240, 254);
            this.dgvSaida.TabIndex = 2;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInicio.Location = new System.Drawing.Point(160, 425);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(216, 20);
            this.dtpInicio.TabIndex = 3;
            this.dtpInicio.Value = new System.DateTime(2021, 3, 3, 0, 0, 0, 0);
            // 
            // dtpFim
            // 
            this.dtpFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFim.Location = new System.Drawing.Point(450, 425);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(240, 20);
            this.dtpFim.TabIndex = 4;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 517);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dgvSaida);
            this.Controls.Add(this.dgvEntrada);
            this.Controls.Add(this.pictRelatorio);
            this.Name = "frmRelatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictRelatorio;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.DataGridView dgvSaida;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
    }
}