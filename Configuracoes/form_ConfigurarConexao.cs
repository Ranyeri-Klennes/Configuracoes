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

        }
    }
}
