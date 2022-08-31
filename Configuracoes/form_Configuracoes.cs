using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Configuracoes
{
    public partial class form_Configuracoes : Form
    {
        public form_Configuracoes()
        {
            InitializeComponent();
        }




        //Botão para abrir a janela de Configurações Gerais -----------------------
        private void btn_ConfiguracoesGerais_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(abrirConfiguracoesGerais);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void abrirConfiguracoesGerais()
        {
            Application.Run(new form_ConfiguracoesGerais());
        }
        //------------------------------------------------------------------------




        //Botão para abrir a janela de Configurar Conexão ------------------------
        private void btn_ConfigurarConexao_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(abrirConfigurarConexao);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void abrirConfigurarConexao()
        {
            Application.Run(new form_ConfigurarConexao());
        }
        //-----------------------------------------------------------------------




        //Botão para abrir a janela de Gerar Chave NF-e ------------------------
        private void btn_GerarChaveNFe_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(abrirGerarChaveNFe);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void abrirGerarChaveNFe()
        {
            Application.Run(new form_GerarChaveNFe());
        }
        //-----------------------------------------------------------------------
    }
}
