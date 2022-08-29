
using System.Windows.Forms;

namespace Configuracoes
{
    partial class form_ConfigurarConexao : Form
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.tb_NomeUsuario = new System.Windows.Forms.TextBox();
            this.mtb_IpServidor = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Porta = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.lbl_NomeConexao = new System.Windows.Forms.Label();
            this.lbl_IpServidor = new System.Windows.Forms.Label();
            this.lbl_Porta = new System.Windows.Forms.Label();
            this.tb_NomeConexao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 216);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(62, 33);
            this.btn_Voltar.TabIndex = 5;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(226, 216);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(86, 33);
            this.btn_Confirmar.TabIndex = 4;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // tb_NomeUsuario
            // 
            this.tb_NomeUsuario.Location = new System.Drawing.Point(153, 50);
            this.tb_NomeUsuario.Name = "tb_NomeUsuario";
            this.tb_NomeUsuario.Size = new System.Drawing.Size(140, 25);
            this.tb_NomeUsuario.TabIndex = 0;
            this.tb_NomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtb_IpServidor
            // 
            this.mtb_IpServidor.Location = new System.Drawing.Point(153, 118);
            this.mtb_IpServidor.Mask = "000000000000";
            this.mtb_IpServidor.Name = "mtb_IpServidor";
            this.mtb_IpServidor.Size = new System.Drawing.Size(100, 25);
            this.mtb_IpServidor.TabIndex = 2;
            this.mtb_IpServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtb_Porta
            // 
            this.mtb_Porta.Location = new System.Drawing.Point(153, 153);
            this.mtb_Porta.Mask = "0000";
            this.mtb_Porta.Name = "mtb_Porta";
            this.mtb_Porta.Size = new System.Drawing.Size(56, 25);
            this.mtb_Porta.TabIndex = 3;
            this.mtb_Porta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_NomeUsuario
            // 
            this.lbl_NomeUsuario.AutoSize = true;
            this.lbl_NomeUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeUsuario.Location = new System.Drawing.Point(26, 54);
            this.lbl_NomeUsuario.Name = "lbl_NomeUsuario";
            this.lbl_NomeUsuario.Size = new System.Drawing.Size(124, 17);
            this.lbl_NomeUsuario.TabIndex = 6;
            this.lbl_NomeUsuario.Text = "Nome do Usuário :";
            // 
            // lbl_NomeConexao
            // 
            this.lbl_NomeConexao.AutoSize = true;
            this.lbl_NomeConexao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeConexao.Location = new System.Drawing.Point(21, 88);
            this.lbl_NomeConexao.Name = "lbl_NomeConexao";
            this.lbl_NomeConexao.Size = new System.Drawing.Size(129, 17);
            this.lbl_NomeConexao.TabIndex = 7;
            this.lbl_NomeConexao.Text = "Nome da Conexão :";
            // 
            // lbl_IpServidor
            // 
            this.lbl_IpServidor.AutoSize = true;
            this.lbl_IpServidor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IpServidor.Location = new System.Drawing.Point(46, 122);
            this.lbl_IpServidor.Name = "lbl_IpServidor";
            this.lbl_IpServidor.Size = new System.Drawing.Size(104, 17);
            this.lbl_IpServidor.TabIndex = 8;
            this.lbl_IpServidor.Text = "Ip do Servidor :";
            // 
            // lbl_Porta
            // 
            this.lbl_Porta.AutoSize = true;
            this.lbl_Porta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Porta.Location = new System.Drawing.Point(101, 157);
            this.lbl_Porta.Name = "lbl_Porta";
            this.lbl_Porta.Size = new System.Drawing.Size(49, 17);
            this.lbl_Porta.TabIndex = 9;
            this.lbl_Porta.Text = "Porta :";
            // 
            // tb_NomeConexao
            // 
            this.tb_NomeConexao.Location = new System.Drawing.Point(153, 84);
            this.tb_NomeConexao.Name = "tb_NomeConexao";
            this.tb_NomeConexao.Size = new System.Drawing.Size(140, 25);
            this.tb_NomeConexao.TabIndex = 10;
            this.tb_NomeConexao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // form_ConfigurarConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.tb_NomeConexao);
            this.Controls.Add(this.lbl_Porta);
            this.Controls.Add(this.lbl_IpServidor);
            this.Controls.Add(this.lbl_NomeConexao);
            this.Controls.Add(this.lbl_NomeUsuario);
            this.Controls.Add(this.mtb_Porta);
            this.Controls.Add(this.mtb_IpServidor);
            this.Controls.Add(this.tb_NomeUsuario);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_Voltar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "form_ConfigurarConexao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confiigurar Conexão";
            this.Load += new System.EventHandler(this.form_ConfigurarConexao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Voltar;
        private Button btn_Confirmar;
        private TextBox tb_NomeUsuario;
        private MaskedTextBox mtb_IpServidor;
        private MaskedTextBox mtb_Porta;
        private Label lbl_NomeUsuario;
        private Label lbl_NomeConexao;
        private Label lbl_IpServidor;
        private Label lbl_Porta;
        private TextBox tb_NomeConexao;
    }
}

