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
        public form_GerarChaveNFe()
        {
            InitializeComponent();
        }
        #region Tela Principal
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

        } 
        #endregion
        
        #region Campos
        private void cb_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Códigos UFs
            int RO = 11, AC = 12, AM = 13, RR = 14, PA = 15, AP = 16, TO = 17, MA = 21, PI = 22, CE = 23, RN = 24, PB = 25, PE = 26, AL = 27, SE = 28, BA = 29, MG = 31, ES = 32, RJ = 33, SP = 35, PR = 41, SC = 42, RS = 43, MS = 50, MT = 51, GO = 52, DF = 53;
        }
        private void cb_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int "NF - E" = 55,"NFC - E" = 65, "CT - E" = 57, "MDF - E" = 25;
            //int "NFE" = 55, "NFCE"= 65, "CTE" = 57, "MDFE" = 25;
        }
        private void cb_Emissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Emissao = "NORMAL")
            {
                cb_Emissao = 1;
            }
            else cb_Emissao = 9;
        }

            #endregion}

        #region Botões
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

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=MR1xYaNAnPc 
            int  cb_UF, tb_NF, tb_Serie, mtb_CNPJ, mtb_Data, cb_Emissao,cb_Modelo;

            if (ValidarForm())
            {
                //Armazenando dados em um .txt---------------------
                using (StreamWriter txt_DadoArmazenado = new StreamWriter(@"C:\DB_Configurações\DadoArmazenado.txt"))
                    
                txt_DadoArmazenado.WriteLine("UF: " + cb_UF.Text + "\n" 
                    + "NF: "+ tb_NF.Text + "\n" 
                    + "SÉRIE: " + tb_Serie.Text + "\n" 
                    + "CNPJ: " + mtb_CNPJ.Text + "\n" 
                    + "AA/MM: " + mtb_Data.Text + "\n" 
                    + "EMISSÃO: " + cb_Emissao.Text + "\n" 
                    + "MODELO: " + cb_Modelo.Text);
                //-------------------------------------------------
            }
        }
        #region Validando Campos
        private bool ValidarForm()
        {
            bool FormValido = true;

            if (cb_UF.Text == "")
            {
                MessageBox.Show("Informe o UF do Estado!");
                cb_UF.Focus();
                FormValido = false;
            }
            else if (tb_NF.Text == "")
            {
                MessageBox.Show("Informe o número da NF!");
                tb_NF.Focus();
                FormValido = false;
            }
            else if (tb_Serie.Text == "")
            {
                MessageBox.Show("Informe o número de Série!");
                tb_Serie.Focus();
                FormValido = false;
            }
            else if (mtb_CNPJ.Text == "")
            {
                MessageBox.Show("Informe o CNPJ!");
                mtb_CNPJ.Focus();
                FormValido = false;
            }
            else if (mtb_Data.Text == "")
            {
                MessageBox.Show("Informe a Data!");
                mtb_Data.Focus();
                FormValido = false;
            }
            else if (cb_Emissao.Text == "")
            {
                MessageBox.Show("Informe a forma de Emissão!");
                cb_Emissao.Focus();
                FormValido = false;
            }
            else if (cb_Modelo.Text == "")
            {
                MessageBox.Show("Informe o Modelo do documento!");
                cb_Modelo.Focus();
                FormValido = false;
            }
            else FormValido = true;
            return FormValido;
        }
        #endregion

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            //btn_copiar.DialogResult = DialogResult.Copiado!;
            //O botão ao clicado tem que mudar o nome.


        }
        #endregion


    }
}