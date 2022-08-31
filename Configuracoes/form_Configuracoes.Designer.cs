
namespace Configuracoes
{
    partial class form_Configuracoes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ConfiguracoesGerais = new System.Windows.Forms.Button();
            this.btn_ConfigurarConexao = new System.Windows.Forms.Button();
            this.btn_GerarChaveNFe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ConfiguracoesGerais
            // 
            this.btn_ConfiguracoesGerais.Location = new System.Drawing.Point(86, 56);
            this.btn_ConfiguracoesGerais.Name = "btn_ConfiguracoesGerais";
            this.btn_ConfiguracoesGerais.Size = new System.Drawing.Size(156, 35);
            this.btn_ConfiguracoesGerais.TabIndex = 0;
            this.btn_ConfiguracoesGerais.Text = "Configurações Gerais";
            this.btn_ConfiguracoesGerais.UseVisualStyleBackColor = true;
            this.btn_ConfiguracoesGerais.Click += new System.EventHandler(this.btn_ConfiguracoesGerais_Click);
            // 
            // btn_ConfigurarConexao
            // 
            this.btn_ConfigurarConexao.Location = new System.Drawing.Point(86, 108);
            this.btn_ConfigurarConexao.Name = "btn_ConfigurarConexao";
            this.btn_ConfigurarConexao.Size = new System.Drawing.Size(156, 35);
            this.btn_ConfigurarConexao.TabIndex = 1;
            this.btn_ConfigurarConexao.Text = "Configurar Conexão";
            this.btn_ConfigurarConexao.UseVisualStyleBackColor = true;
            this.btn_ConfigurarConexao.Click += new System.EventHandler(this.btn_ConfigurarConexao_Click);
            // 
            // btn_GerarChaveNFe
            // 
            this.btn_GerarChaveNFe.Location = new System.Drawing.Point(86, 159);
            this.btn_GerarChaveNFe.Name = "btn_GerarChaveNFe";
            this.btn_GerarChaveNFe.Size = new System.Drawing.Size(156, 35);
            this.btn_GerarChaveNFe.TabIndex = 2;
            this.btn_GerarChaveNFe.Text = "Gerar Chave NF-e";
            this.btn_GerarChaveNFe.UseVisualStyleBackColor = true;
            this.btn_GerarChaveNFe.Click += new System.EventHandler(this.btn_GerarChaveNFe_Click);
            // 
            // form_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btn_GerarChaveNFe);
            this.Controls.Add(this.btn_ConfigurarConexao);
            this.Controls.Add(this.btn_ConfiguracoesGerais);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "form_Configuracoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confiigurações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ConfiguracoesGerais;
        private System.Windows.Forms.Button btn_ConfigurarConexao;
        private System.Windows.Forms.Button btn_GerarChaveNFe;
    }
}

