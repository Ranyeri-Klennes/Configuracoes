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
    }
}
