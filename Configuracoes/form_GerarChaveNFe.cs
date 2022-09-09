using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

//https://enotas.com.br/blog/tipos-de-contingencia/#
//https://www.invoisys.com.br/blog/como-e-formada-a-chave-de-acesso/
namespace Configuracoes
{
    public partial class form_GerarChaveNFe : Form
    {        
        private const string NFE = "NF-E";
        private const string NFCE = "NFC-E";
        private const string CTE = "CT-E";
        private const string MDFE = "MDF-E";
        public form_GerarChaveNFe()
        {
            InitializeComponent();
        }
        private void form_GerarChaveNFe_Load(object sender, EventArgs e)
        {
            //Criar diretório de armazenamento automatico ---------------------------------
            DirectoryInfo dir_Armazenamento = new DirectoryInfo(@"C:\DB_Configurações");

            if (dir_Armazenamento.Exists)
            {
                return;
            }
            else
            {
                dir_Armazenamento.Create();
            }
            //-----------------------------------------------------------------------------

        } //Janela Principal
        #region Botões
        #region btn_Voltar
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(voltarParaConfiguracoes);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void voltarParaConfiguracoes()
        {
            Application.Run(new form_Configuracoes());
        }
        #endregion
        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                int valorModelo = retornarValorModelo(cb_Modelo.Text);
                int valorUF = retornarValorUF(cb_UF.Text);
                int valorEmissao = retornarValorEmissao(cb_Emissao.Text);
            #region Armazenando dados em um .txt
            using (StreamWriter txt_DadoArmazenado = new StreamWriter(@"C:\DB_Configurações\DadoArmazenado.txt"))
            txt_DadoArmazenado.WriteLine($"UF: {valorUF} \nNF: {tb_NF.Text} \nSÉRIE: {tb_Serie.Text} \nCNPJ: {mtb_CNPJ.Text} \nAAAA/MM: {mtb_Data.Text} \nEMISSÃO: {valorEmissao} \nMODELO: {valorModelo}");
                rtb_NFe.Text = $"{valorUF}{tb_NF.Text}{tb_Serie.Text}{mtb_CNPJ.Text}{mtb_Data.Text}{valorEmissao}{valorModelo}";
            #endregion
            }
        }
        private int retornarValorEmissao(string valorEmissao)
        {
            switch (valorEmissao)
            {
                case "CONTIGÊNCIA":
                    return 9;
                case "NORMAL":
                    return 1;
                default:
                    return 0;
            }
        }//Aplicando valores nas Emissões
        private int retornarValorUF(string valorUF)
        {
            switch (valorUF)
            {
                case "RO":
                    return 11;
                case "AC":
                    return 12;
                case "AM":
                    return 13;
                case "RR":
                    return 14;
                case "PA":
                    return 15;
                case "AP":
                    return 16;
                case "TO":
                    return 17;
                case "MA":
                    return 21;
                case "PI":
                    return 22;
                case "CE":
                    return 23;
                case "RN":
                    return 24;
                case "PB":
                    return 25;
                case "PE":
                    return 26;
                case "AL":
                    return 27;
                case "SE":
                    return 28;
                case "BA":
                    return 29;
                case "MG":
                    return 31;
                case "ES":
                    return 32;
                case "RJ":
                    return 33;
                case "SP":
                    return 35;
                case "PR":
                    return 41;
                case "SC":
                    return 42;
                case "RS":
                    return 43;
                case "MS":
                    return 50;
                case "MT":
                    return 51;
                case "GO":
                    return 52;
                case "DF":
                    return 53;
                default:
                    return 0;
            }
        }//Aplicando valores nas UFs
        private int retornarValorModelo(string valorModelo)
        {
            switch (valorModelo)
            {
                case NFE:
                    return 55;
                case NFCE:
                    return 65;
                case CTE:
                    return 57;
                case MDFE:
                    return 25;
                default:
                    return 0;
            }
        }//Aplicando valores naos Modelos
        private bool ValidarForm()
        {
             bool FormValido = true;

            if (cb_UF.Text == string.Empty)
            {
                MessageBox.Show("Informe o UF do Estado!");
                cb_UF.Focus();
                FormValido = false;
            }
            else if (tb_NF.Text == string.Empty)
            {
                MessageBox.Show("Informe o número da NF!");
                tb_NF.Focus();
                FormValido = false;
            }
            else if (tb_Serie.Text == string.Empty)
            {
                MessageBox.Show("Informe o número de Série!");
                tb_Serie.Focus();
                FormValido = false;
            }
            else if (mtb_CNPJ.Text == string.Empty)
            {
                MessageBox.Show("Informe o CNPJ!");
                mtb_CNPJ.Focus();
                FormValido = false;
            }
            else if (mtb_Data.Text == string.Empty)
            {
                MessageBox.Show("Informe a Data!");
                mtb_Data.Focus();
                FormValido = false;
            }
            else if (cb_Emissao.Text == string.Empty)
            {
                MessageBox.Show("Informe a forma de Emissão!");
                cb_Emissao.Focus();
                FormValido = false;
            }
            else if (string.IsNullOrEmpty(cb_Modelo.Text))
            {
                MessageBox.Show("Informe o Modelo do documento!");
                cb_Modelo.Focus();
                FormValido = false;
            }
            else FormValido = true;
            return FormValido;
        }//Validando Campos
        private void btn_copiar_Click(object sender, EventArgs e)
        {
            //btn_copiar.DialogResult = DialogResult.Copiado!;
            //O botão ao clicado tem que mudar o nome.
            
            //rtb_NFe.Copy();
        }
        #endregion
    }
}