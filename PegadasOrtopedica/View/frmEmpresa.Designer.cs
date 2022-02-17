
namespace PegadasOrtopedica.Forms
{
    partial class frmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresa));
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lalDadosEmpresariais = new System.Windows.Forms.Label();
            this.pnlEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmpresa.BackgroundImage")));
            this.pnlEmpresa.Controls.Add(this.button1);
            this.pnlEmpresa.Location = new System.Drawing.Point(250, 51);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(258, 255);
            this.pnlEmpresa.TabIndex = 2;
            this.pnlEmpresa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmpresa_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(17, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 227);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lalDadosEmpresariais
            // 
            this.lalDadosEmpresariais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lalDadosEmpresariais.AutoSize = true;
            this.lalDadosEmpresariais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalDadosEmpresariais.Location = new System.Drawing.Point(265, 309);
            this.lalDadosEmpresariais.Name = "lalDadosEmpresariais";
            this.lalDadosEmpresariais.Size = new System.Drawing.Size(205, 25);
            this.lalDadosEmpresariais.TabIndex = 3;
            this.lalDadosEmpresariais.Text = "Dados Empresariais";
            this.lalDadosEmpresariais.Click += new System.EventHandler(this.lalDadosEmpresariais_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lalDadosEmpresariais);
            this.Controls.Add(this.pnlEmpresa);
            this.Name = "frmEmpresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.pnlEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lalDadosEmpresariais;
    }
}