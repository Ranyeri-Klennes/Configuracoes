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
        }
        //---------------------------------------------------------

        private void form_GerarChaveNFe_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir_Armazenamento = new DirectoryInfo(@"C:\DB_Configurações");

            if (dir_Armazenamento.Exists)
            {
                return;
            }
            else
            {
                dir_Armazenamento.Create();
            }
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            using (StreamWriter txt_DadoArmazenado = new StreamWriter(@"C:\DB_Configurações\DadoArmazenado.txt"))
            {
                txt_DadoArmazenado.WriteLine(mtb_CNPJ.Text);
                txt_DadoArmazenado.WriteLine(mtb_Data.Text);
                MessageBox.Show("Dado Armazenado!");
            }
        }
    }
}
