using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Configuracoes
{
    public partial class form_ConfiguracoesGerais : Form
    {
        public form_ConfiguracoesGerais()
        {
            InitializeComponent();
        }

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

        private void form_ConfiguracoesGerais_Load(object sender, EventArgs e)
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

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            using (StreamWriter txt_DadoArmazenado = new StreamWriter(@"C:\DB_Configurações\DadoArmazenado.txt"))
            {
                txt_DadoArmazenado.WriteLine(mtb_CNPJEmpresa.Text);
                MessageBox.Show("Dado Armazenado!");
            }
        }
    }
}
