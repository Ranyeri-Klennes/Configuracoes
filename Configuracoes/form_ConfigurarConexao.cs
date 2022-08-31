using MySql.Data.MySqlClient; //Lib que disponibiliza classes de conexão com o db
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
    public partial class form_ConfigurarConexao : Form //Formulário instanciado
    {

        MySqlConnection conexao; //Propiedade utilizada para criar a variável que armazena as informações da conexão


        public form_ConfigurarConexao()
        {
            InitializeComponent();
        }



        //Thread para btn_Voltar ---------------------------
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





        private void form_ConfigurarConexao_Load(object sender, EventArgs e) //Janela de Configurar Conexão
        { 
            //Indicando o caminho para criação do diretório de armazenamento -------------
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


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
  
            //Conexão com o db --------------------------------------------------
            try
            {
                conexao = new MySqlConnection("server=localhost;database=db_configuracoes;username=root;password=root;port=3306"); //Conectar db

                string inserirDados = "INSERT INTO tb_configurarconexao (nomeUsuario, nomeConexao, ipServidor, porta, senha)" + "VALUES" + "('" + tb_NomeUsuario.Text + "','" + cb_NomeConexao.Text + "','" + mtb_IpServidor.Text + "','" + mtb_Porta.Text + "','" + tb_Senha.Text + "')"; //Inserir os dados no db

                MySqlCommand comando = new MySqlCommand(inserirDados, conexao);

                conexao.Open();

                comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            //-----------------------------------------------------------------





            if (ValidarForm())
            {
                using (StreamWriter txt_DadoArmazenado = new StreamWriter(@"C:\DB_Configurações\DadoArmazenado.txt"))
                
                    txt_DadoArmazenado.WriteLine("Nome da Conexão: " + cb_NomeConexao.Text + "\n" + 
                    "Ip do Servidor: " + mtb_IpServidor.Text + "\n" + 
                    "Porta: " + mtb_Porta.Text + "\n" +
                    "Nome do Usuário: " + tb_NomeUsuario.Text + "\n" +
                    "Senha: " + tb_Senha.Text);
                
                MessageBox.Show("Conectado!");
            }

            //https://www.youtube.com/watch?v=L5DLbVuA7IQ
            
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
