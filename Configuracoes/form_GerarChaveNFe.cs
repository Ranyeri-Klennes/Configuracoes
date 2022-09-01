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

namespace Configuracoes
{
    public partial class form_GerarChaveNFe : Form
    {
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
            }//-----------------------------------------------------------------------------
        }




        //Thread para btn_Voltar ----------------------------------
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
        }//---------------------------------------------------------


        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                using (StreamWriter txt_DadoArmazenado = new StreamWriter(@"C:\DB_Configurações\DadoArmazenado.txt"))
                {
                    //Formatação para chave acesso de NF-e, NFC-e, CT-e e MDF-e
                    string[] lista_dadosFornecidosGerarNFs = new string[] 
                    {mtb_CNPJ.Text, mtb_Data.Text, cb_UF.Text, tb_Serie.Text, cb_Modelo.Text, tb_NF.Text, cb_Emissao.Text};
                    
                    txt_DadoArmazenado.WriteLine(lista_dadosFornecidosGerarNFs);
                }
            }
        }

        //Validando informações obrigatórias ---------------------------
        private bool ValidarForm()
        {
            bool FormValido = true;

            if (mtb_CNPJ.Text == "")
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
            else if (cb_UF.Text == "")
            {
                MessageBox.Show("Informe o UF do Estado!");
                cb_UF.Focus();
                FormValido = false;
            }
            else if (tb_Serie.Text == "")
            {
                MessageBox.Show("Informe o número de Série!");
                tb_Serie.Focus();
                FormValido = false;
            }
            else if (cb_Modelo.Text == "")
            {
                MessageBox.Show("Informe o Modelo do documento!");
                cb_Modelo.Focus();
                FormValido = false;
            }
            else if (cb_Emissao.Text == "")
            {
                MessageBox.Show("Informe a forma de Emissão!");
                cb_Emissao.Focus();
                FormValido = false;
            }
            else if (tb_NF.Text == "")
            {
                MessageBox.Show("Informe o número da NF!");
                tb_NF.Focus();
                FormValido = false;
            }
            else FormValido = true;
            return FormValido;
        }//-------------------------------------------------------------





        private void btn_copiar_Click(object sender, EventArgs e)
        {
            //btn_copiar.DialogResult = DialogResult.Copiado!;
            //O botão ao clicado tem que mudar o nome.
        }
    }
}
