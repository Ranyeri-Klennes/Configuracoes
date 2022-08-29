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
    public partial class form_ConfigurarConexao : Form
    {
        public form_ConfigurarConexao()
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

        private void form_ConfigurarConexao_Load(object sender, EventArgs e)
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
                txt_DadoArmazenado.WriteLine(lbl_NomeUsuario.Text, "\t", lbl_NomeConexao.Text);
                //txt_DadoArmazenado.WriteLine(lbl_IpServidor.Text);
                //txt_DadoArmazenado.WriteLine(lbl_Porta.Text);
                MessageBox.Show("Dado Armazenado!");
            }
        } 
    }
}
