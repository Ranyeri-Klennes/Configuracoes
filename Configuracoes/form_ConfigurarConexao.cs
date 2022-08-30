using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //Lib para escrita
using System.Linq;
using System.Text;
using System.Threading; //Lib para criação de caminhos (threads)
using System.Windows.Forms; //Lib para criação de winforms (windows forms)

namespace Configuracoes
{
    public partial class form_ConfigurarConexao : Form
    {
        //MySqlConnection conexao;


        public form_ConfigurarConexao()
        {
            InitializeComponent();
        }


        //Thread para botão voltar ---------------------------
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
        //-----------------------------------------------------


        private void form_ConfigurarConexao_Load(object sender, EventArgs e) //Classe iniciada da Janela Configurar Conexão
        { 
            //Indicando o caminho para criação do diretório de armazenamento ---
            DirectoryInfo dir_Armazenamento = new DirectoryInfo(@"C:\DB_Configurações");

            if (dir_Armazenamento.Exists)
            {
                return;
            }
            else
            {
                dir_Armazenamento.Create();
            }
            //-------------------------------------------------------------------
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Conexão com o BD --------------------------------------------------
            //try
            //{
            //    conexao = new MySqlConnection("serve=localhost;database=db_configuracoes;username=root;password="); //Conectar db

            //    //https://www.youtube.com/watch?v=tKuaT0RXJXc
            //    //https://www.youtube.com/watch?v=M3aSq3GPXq8&t=1255s
            //    string sql = "INSERT INTO tb_configurarconexao (nomeUsuario, nomeConexao, ipServidor, porta, senha)" + "VALUES" + "('" + cb_NomeConexao.Text + "','" + mtb_IpServidor.Text + "','" + mtb_Porta.Text + "','" + tb_NomeUsuario.Text + "','" + tb_Senha.Text + "')"; //Inserir os dados no db

            //    MySqlCommand comando = new MySqlCommand(sql,conexao);

            //    conexao.Open();
            //    comando.ExecuteReader();

            //    MessageBox.Show("Conectado!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            //-----------------------------------------------------------------

            if (ValidarForm())
            {
                MessageBox.Show("Conectado!");
            }
            
            //https://www.youtube.com/watch?v=L5DLbVuA7IQ
            //https://www.youtube.com/watch?v=nKclVupjtBQ
            //Armazenando dados no txt

        }
        //Validando informações obrigatórias -----------------------
        //https://www.youtube.com/watch?v=jsVLeQF9IuY&list=PLW83fkbt3BqnNZuIrGHBl4Il9iR-_-pOF&index=58
        //https://www.youtube.com/watch?v=a1yb5g3wDYk
        private bool ValidarForm()
        {
            bool FormValido = true;

            if (cb_NomeConexao.Text == "")
            {
                MessageBox.Show("Selecione uma Conexão!");
                cb_NomeConexao.Focus();
                FormValido = false;
            }
            else if (mtb_IpServidor.Text == "")
            {
                MessageBox.Show("Informe o IP do Servidor!");
                mtb_IpServidor.Focus();
                FormValido = false;
            }
            else if (mtb_Porta.Text == "")
            {
                MessageBox.Show("Informe a Porta!");
                mtb_Porta.Focus();
                FormValido = false;
            }
            else if (tb_NomeUsuario.Text == "")
            {
                MessageBox.Show("Informe o Nome de Usuário!");
                tb_NomeUsuario.Focus();
                FormValido = false;
            }
            else if (tb_Senha.Text == "")
            {
                MessageBox.Show("Informe a Senha de acesso!");
                tb_Senha.Focus();
                FormValido = false;
            }
            else FormValido = true;
            return FormValido;
        }
        //---------------------------------------------------------


    }
}
