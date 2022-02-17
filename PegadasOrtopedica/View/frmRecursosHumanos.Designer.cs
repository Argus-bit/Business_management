
namespace PegadasOrtopedica.Forms
{
    partial class frmRecursosHumanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecursosHumanos));
            this.pictApresentacao = new System.Windows.Forms.PictureBox();
            this.lblListagemDeFuncionario = new System.Windows.Forms.Label();
            this.dgvRH = new System.Windows.Forms.DataGridView();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictApresentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRH)).BeginInit();
            this.SuspendLayout();
            // 
            // pictApresentacao
            // 
            this.pictApresentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictApresentacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictApresentacao.BackgroundImage")));
            this.pictApresentacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictApresentacao.Location = new System.Drawing.Point(460, 36);
            this.pictApresentacao.Name = "pictApresentacao";
            this.pictApresentacao.Size = new System.Drawing.Size(147, 147);
            this.pictApresentacao.TabIndex = 0;
            this.pictApresentacao.TabStop = false;
            this.pictApresentacao.Click += new System.EventHandler(this.pictApresentacao_Click);
            // 
            // lblListagemDeFuncionario
            // 
            this.lblListagemDeFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListagemDeFuncionario.AutoSize = true;
            this.lblListagemDeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagemDeFuncionario.Location = new System.Drawing.Point(457, 200);
            this.lblListagemDeFuncionario.Name = "lblListagemDeFuncionario";
            this.lblListagemDeFuncionario.Size = new System.Drawing.Size(151, 13);
            this.lblListagemDeFuncionario.TabIndex = 1;
            this.lblListagemDeFuncionario.Text = "Listagem de Funcionários";
            // 
            // dgvRH
            // 
            this.dgvRH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRH.Location = new System.Drawing.Point(413, 228);
            this.dgvRH.MaximumSize = new System.Drawing.Size(240, 500);
            this.dgvRH.Name = "dgvRH";
            this.dgvRH.Size = new System.Drawing.Size(240, 237);
            this.dgvRH.TabIndex = 2;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoCadastro.Location = new System.Drawing.Point(633, 502);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(159, 23);
            this.btnNovoCadastro.TabIndex = 3;
            this.btnNovoCadastro.Text = "Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarCadastro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarCadastro.Location = new System.Drawing.Point(449, 502);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(159, 23);
            this.btnEditarCadastro.TabIndex = 4;
            this.btnEditarCadastro.Text = "Editar Cadastro";
            this.btnEditarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirCadastro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluirCadastro.Location = new System.Drawing.Point(269, 502);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(159, 23);
            this.btnExcluirCadastro.TabIndex = 5;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.UseVisualStyleBackColor = true;
            // 
            // frmRecursosHumanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(997, 599);
            this.Controls.Add(this.btnExcluirCadastro);
            this.Controls.Add(this.btnEditarCadastro);
            this.Controls.Add(this.btnNovoCadastro);
            this.Controls.Add(this.dgvRH);
            this.Controls.Add(this.lblListagemDeFuncionario);
            this.Controls.Add(this.pictApresentacao);
            this.DoubleBuffered = true;
            this.Name = "frmRecursosHumanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos";
            this.Load += new System.EventHandler(this.frmRecursosHumanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictApresentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictApresentacao;
        private System.Windows.Forms.Label lblListagemDeFuncionario;
        private System.Windows.Forms.DataGridView dgvRH;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
    }
}