
using System.Windows.Forms;

namespace Configuracoes
{
    partial class form_GerarChaveNFe
    {
        private void InitializeComponent()
        {
            this.lbl_CNPJ = new System.Windows.Forms.Label();
            this.mtb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Data = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.rtb_NFe = new System.Windows.Forms.RichTextBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CNPJ
            // 
            this.lbl_CNPJ.AutoSize = true;
            this.lbl_CNPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CNPJ.Location = new System.Drawing.Point(41, 40);
            this.lbl_CNPJ.Name = "lbl_CNPJ";
            this.lbl_CNPJ.Size = new System.Drawing.Size(112, 17);
            this.lbl_CNPJ.TabIndex = 0;
            this.lbl_CNPJ.Text = "Informe o CNPJ :";
            // 
            // mtb_CNPJ
            // 
            this.mtb_CNPJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_CNPJ.Location = new System.Drawing.Point(156, 38);
            this.mtb_CNPJ.Mask = "00.000.000/0000-00";
            this.mtb_CNPJ.Name = "mtb_CNPJ";
            this.mtb_CNPJ.PromptChar = ' ';
            this.mtb_CNPJ.Size = new System.Drawing.Size(128, 23);
            this.mtb_CNPJ.TabIndex = 0;
            this.mtb_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtb_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_Data
            // 
            this.mtb_Data.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_Data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_Data.Location = new System.Drawing.Point(156, 73);
            this.mtb_Data.Mask = "00/00/0000";
            this.mtb_Data.Name = "mtb_Data";
            this.mtb_Data.PromptChar = ' ';
            this.mtb_Data.Size = new System.Drawing.Size(128, 23);
            this.mtb_Data.TabIndex = 1;
            this.mtb_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtb_Data.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_Data.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(45, 75);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(109, 17);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Informe a Data :";
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gerar.Location = new System.Drawing.Point(198, 216);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(86, 33);
            this.btn_Gerar.TabIndex = 3;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = true;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // rtb_NFe
            // 
            this.rtb_NFe.Location = new System.Drawing.Point(1, 148);
            this.rtb_NFe.Multiline = false;
            this.rtb_NFe.Name = "rtb_NFe";
            this.rtb_NFe.Size = new System.Drawing.Size(333, 33);
            this.rtb_NFe.TabIndex = 5;
            this.rtb_NFe.TabStop = false;
            this.rtb_NFe.Text = "";
            this.rtb_NFe.WordWrap = false;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Voltar.Location = new System.Drawing.Point(56, 216);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(86, 33);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // form_GerarChaveNFe
            // 
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.rtb_NFe);
            this.Controls.Add(this.btn_Gerar);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.mtb_Data);
            this.Controls.Add(this.mtb_CNPJ);
            this.Controls.Add(this.lbl_CNPJ);
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "form_GerarChaveNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Chave NF-e";
            this.Load += new System.EventHandler(this.form_GerarChaveNFe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lbl_CNPJ;
        private System.Windows.Forms.MaskedTextBox mtb_CNPJ;
        private System.Windows.Forms.MaskedTextBox mtb_Data;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Button btn_Gerar;
        private System.Windows.Forms.RichTextBox rtb_NFe;
        private System.Windows.Forms.Button btn_Voltar;
    }
}

