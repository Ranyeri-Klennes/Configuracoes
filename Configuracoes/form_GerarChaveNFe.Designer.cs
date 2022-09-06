
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Copiar = new System.Windows.Forms.Button();
            this.cb_UF = new System.Windows.Forms.ComboBox();
            this.lbl_UF = new System.Windows.Forms.Label();
            this.tb_Serie = new System.Windows.Forms.TextBox();
            this.lbl_Serie = new System.Windows.Forms.Label();
            this.lbl_Emissao = new System.Windows.Forms.Label();
            this.cb_Emissao = new System.Windows.Forms.ComboBox();
            this.lbl_NF = new System.Windows.Forms.Label();
            this.tb_NF = new System.Windows.Forms.TextBox();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.cb_Modelo = new System.Windows.Forms.ComboBox();
            this.rtb_NFe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_CNPJ
            // 
            this.lbl_CNPJ.AutoSize = true;
            this.lbl_CNPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CNPJ.Location = new System.Drawing.Point(6, 61);
            this.lbl_CNPJ.Name = "lbl_CNPJ";
            this.lbl_CNPJ.Size = new System.Drawing.Size(47, 17);
            this.lbl_CNPJ.TabIndex = 0;
            this.lbl_CNPJ.Text = "CNPJ :";
            // 
            // mtb_CNPJ
            // 
            this.mtb_CNPJ.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_CNPJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_CNPJ.Location = new System.Drawing.Point(55, 57);
            this.mtb_CNPJ.Mask = "00.000.000/0000-00";
            this.mtb_CNPJ.Name = "mtb_CNPJ";
            this.mtb_CNPJ.PromptChar = ' ';
            this.mtb_CNPJ.Size = new System.Drawing.Size(127, 23);
            this.mtb_CNPJ.TabIndex = 3;
            this.mtb_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtb_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_Data
            // 
            this.mtb_Data.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_Data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_Data.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtb_Data.Location = new System.Drawing.Point(231, 55);
            this.mtb_Data.Mask = "00/00";
            this.mtb_Data.Name = "mtb_Data";
            this.mtb_Data.PromptChar = ' ';
            this.mtb_Data.Size = new System.Drawing.Size(93, 23);
            this.mtb_Data.TabIndex = 4;
            this.mtb_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtb_Data.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_Data.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(185, 58);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(45, 17);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Data :";
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gerar.Location = new System.Drawing.Point(124, 214);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(86, 33);
            this.btn_Gerar.TabIndex = 7;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = true;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Voltar.Location = new System.Drawing.Point(12, 214);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(86, 33);
            this.btn_Voltar.TabIndex = 9;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Copiar.Location = new System.Drawing.Point(238, 214);
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(86, 33);
            this.btn_Copiar.TabIndex = 8;
            this.btn_Copiar.Text = "Copiar";
            this.btn_Copiar.UseVisualStyleBackColor = true;
            this.btn_Copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // cb_UF
            // 
            this.cb_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_UF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_UF.FormattingEnabled = true;
            this.cb_UF.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cb_UF.Location = new System.Drawing.Point(41, 22);
            this.cb_UF.Name = "cb_UF";
            this.cb_UF.Size = new System.Drawing.Size(40, 23);
            this.cb_UF.TabIndex = 0;
            this.cb_UF.SelectedIndexChanged += new System.EventHandler(this.cb_UF_SelectedIndexChanged);
            // 
            // lbl_UF
            // 
            this.lbl_UF.AutoSize = true;
            this.lbl_UF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UF.Location = new System.Drawing.Point(7, 26);
            this.lbl_UF.Name = "lbl_UF";
            this.lbl_UF.Size = new System.Drawing.Size(32, 17);
            this.lbl_UF.TabIndex = 8;
            this.lbl_UF.Text = "UF :";
            // 
            // tb_Serie
            // 
            this.tb_Serie.Location = new System.Drawing.Point(277, 22);
            this.tb_Serie.MaxLength = 3;
            this.tb_Serie.Name = "tb_Serie";
            this.tb_Serie.Size = new System.Drawing.Size(45, 23);
            this.tb_Serie.TabIndex = 2;
            this.tb_Serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Serie
            // 
            this.lbl_Serie.AutoSize = true;
            this.lbl_Serie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Serie.Location = new System.Drawing.Point(230, 25);
            this.lbl_Serie.Name = "lbl_Serie";
            this.lbl_Serie.Size = new System.Drawing.Size(46, 17);
            this.lbl_Serie.TabIndex = 10;
            this.lbl_Serie.Text = "Série :";
            // 
            // lbl_Emissao
            // 
            this.lbl_Emissao.AutoSize = true;
            this.lbl_Emissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Emissao.Location = new System.Drawing.Point(7, 98);
            this.lbl_Emissao.Name = "lbl_Emissao";
            this.lbl_Emissao.Size = new System.Drawing.Size(66, 17);
            this.lbl_Emissao.TabIndex = 12;
            this.lbl_Emissao.Text = "Emissão :";
            // 
            // cb_Emissao
            // 
            this.cb_Emissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Emissao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_Emissao.FormattingEnabled = true;
            this.cb_Emissao.Items.AddRange(new object[] {
            "NORMAL",
            "CONTIGÊNCIA"});
            this.cb_Emissao.Location = new System.Drawing.Point(74, 95);
            this.cb_Emissao.Name = "cb_Emissao";
            this.cb_Emissao.Size = new System.Drawing.Size(113, 23);
            this.cb_Emissao.TabIndex = 5;
            this.cb_Emissao.SelectedIndexChanged += new System.EventHandler(this.cb_Emissao_SelectedIndexChanged);
            // 
            // lbl_NF
            // 
            this.lbl_NF.AutoSize = true;
            this.lbl_NF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NF.Location = new System.Drawing.Point(93, 25);
            this.lbl_NF.Name = "lbl_NF";
            this.lbl_NF.Size = new System.Drawing.Size(33, 17);
            this.lbl_NF.TabIndex = 14;
            this.lbl_NF.Text = "NF :";
            // 
            // tb_NF
            // 
            this.tb_NF.Location = new System.Drawing.Point(127, 22);
            this.tb_NF.MaxLength = 6;
            this.tb_NF.Name = "tb_NF";
            this.tb_NF.Size = new System.Drawing.Size(88, 23);
            this.tb_NF.TabIndex = 1;
            this.tb_NF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Modelo.Location = new System.Drawing.Point(191, 98);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(63, 17);
            this.lbl_Modelo.TabIndex = 16;
            this.lbl_Modelo.Text = "Modelo :";
            // 
            // cb_Modelo
            // 
            this.cb_Modelo.AutoCompleteCustomSource.AddRange(new string[] {
            "NF-E",
            "NFC-E"});
            this.cb_Modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Modelo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_Modelo.FormattingEnabled = true;
            this.cb_Modelo.Items.AddRange(new object[] {
            "NF-E",
            "NFC-E",
            "CT-E",
            "MDF-E"});
            this.cb_Modelo.Location = new System.Drawing.Point(255, 94);
            this.cb_Modelo.Name = "cb_Modelo";
            this.cb_Modelo.Size = new System.Drawing.Size(69, 23);
            this.cb_Modelo.TabIndex = 6;
            this.cb_Modelo.SelectedIndexChanged += new System.EventHandler(this.cb_Modelo_SelectedIndexChanged);
            // 
            // rtb_NFe
            // 
            this.rtb_NFe.AutoWordSelection = true;
            this.rtb_NFe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtb_NFe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtb_NFe.Location = new System.Drawing.Point(2, 158);
            this.rtb_NFe.MaxLength = 44;
            this.rtb_NFe.Multiline = false;
            this.rtb_NFe.Name = "rtb_NFe";
            this.rtb_NFe.ReadOnly = true;
            this.rtb_NFe.ShortcutsEnabled = false;
            this.rtb_NFe.Size = new System.Drawing.Size(330, 33);
            this.rtb_NFe.TabIndex = 20;
            this.rtb_NFe.TabStop = false;
            this.rtb_NFe.Text = "";
            this.rtb_NFe.WordWrap = false;
            // 
            // form_GerarChaveNFe
            // 
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lbl_Modelo);
            this.Controls.Add(this.cb_Modelo);
            this.Controls.Add(this.lbl_NF);
            this.Controls.Add(this.tb_NF);
            this.Controls.Add(this.lbl_Emissao);
            this.Controls.Add(this.cb_Emissao);
            this.Controls.Add(this.lbl_Serie);
            this.Controls.Add(this.tb_Serie);
            this.Controls.Add(this.lbl_UF);
            this.Controls.Add(this.cb_UF);
            this.Controls.Add(this.btn_Copiar);
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
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button btn_Voltar;
        private Button btn_Copiar;
        private ComboBox cb_UF;
        private Label lbl_UF;
        private TextBox tb_Serie;
        private Label lbl_Serie;
        private Label lbl_Emissao;
        private ComboBox cb_Emissao;
        private Label lbl_NF;
        private TextBox tb_NF;
        private Label lbl_Modelo;
        private ComboBox cb_Modelo;
        private RichTextBox rtb_NFe;
    }
}

