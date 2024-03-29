﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

//https://pt.activebarcode.com/codes/checkdigit/modulo11.html
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
                Random codNumerico = new Random();
                int valorModelo = retornarValorModelo(cb_Modelo.Text);
                int valorUF = retornarValorUF(cb_UF.Text);
                int valorEmissao = retornarValorEmissao(cb_Emissao.Text);
                string valor = $"{valorUF}{mtb_Data.Text}{mtb_CNPJ.Text}{valorModelo}{tb_Serie.Text}{tb_NF.Text}{valorEmissao}{codNumerico.Next(10000000, 99999999)}";
                string valorDV = retornaValorDV(valor);
                #region Armazenando dados em um .txt
                using (StreamWriter txt_DadoArmazenado = new StreamWriter(@"C:\DB_Configurações\DadoArmazenado.txt"))
                    txt_DadoArmazenado.Write(rtb_NFe.Text = valorDV);
                #endregion 
            }
        }
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
        private string retornaValorDV(string chave)
        {
            //char[] chave43 = valorDV.ToCharArray();
            //int[] DV = new int[] { 2, 3, 4, 5, 6, 7 };

            //int DVCount = 0;
            //string result = string.Empty;
            //for (int i = 0; i < chave43.Length; i++)
            //{
            //    result += (Convert.ToInt32((chave43[i]) * DV[DVCount])/9).ToString();

            //    if (DVCount >= (DV.Length - 1))
            //        DVCount = 0;
            //    else
            //        DVCount++;
            //}
            int soma = 0;
            int resto = 0;
            int[] peso = { 2 ,3,4,5,6,7};
            int digitoRetorno;

            for (int i = 0; i < chave.Length; i++)
            {
                soma += peso[i % 6] * (int.Parse(chave.Substring(i, 1)));
            }

            resto = soma % 11;
            if (resto == 0 || resto == 1)
            {
                digitoRetorno = 0;
            }
            else
            {
                digitoRetorno = 11 - resto;
            }

            return chave + digitoRetorno.ToString();

        }
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
    }
}