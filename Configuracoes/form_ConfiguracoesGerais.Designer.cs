
using System.Windows.Forms;

namespace Configuracoes
{
    partial class form_ConfiguracoesGerais : Form
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
            this.mtb_CNPJEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CNPJEmpresa = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 216);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(62, 33);
            this.btn_Voltar.TabIndex = 0;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // mtb_CNPJEmpresa
            // 
            this.mtb_CNPJEmpresa.BackColor = System.Drawing.Color.White;
            this.mtb_CNPJEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_CNPJEmpresa.Location = new System.Drawing.Point(99, 93);
            this.mtb_CNPJEmpresa.Mask = "00000000000000";
            this.mtb_CNPJEmpresa.Name = "mtb_CNPJEmpresa";
            this.mtb_CNPJEmpresa.Size = new System.Drawing.Size(130, 25);
            this.mtb_CNPJEmpresa.TabIndex = 0;
            this.mtb_CNPJEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_CNPJEmpresa
            // 
            this.lbl_CNPJEmpresa.AutoSize = true;
            this.lbl_CNPJEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CNPJEmpresa.Location = new System.Drawing.Point(78, 60);
            this.lbl_CNPJEmpresa.Name = "lbl_CNPJEmpresa";
            this.lbl_CNPJEmpresa.Size = new System.Drawing.Size(187, 17);
            this.lbl_CNPJEmpresa.TabIndex = 2;
            this.lbl_CNPJEmpresa.Text = "Informe o CNPJ da Empresa :";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(236, 216);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(86, 33);
            this.btn_Confirmar.TabIndex = 1;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // form_ConfiguracoesGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.lbl_CNPJEmpresa);
            this.Controls.Add(this.mtb_CNPJEmpresa);
            this.Controls.Add(this.btn_Voltar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "form_ConfiguracoesGerais";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confiigurações Gerais";
            this.Load += new System.EventHandler(this.form_ConfiguracoesGerais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Voltar;
        private MaskedTextBox mtb_CNPJEmpresa;
        private Label lbl_CNPJEmpresa;
        private Button btn_Confirmar;
    }
}

