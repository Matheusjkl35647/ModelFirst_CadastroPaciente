using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFirst_6320048_Prova
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private Form Tela;

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            Tela?.Close();
            Tela = new CadastroPaciente
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            panel2.Controls.Add(Tela);
            Tela.Show();
        }

        private void btnCadastrarExame_Click(object sender, EventArgs e)
        {
            Tela?.Close();
            Tela = new CadastroExame
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            panel2.Controls.Add(Tela);
            Tela.Show();
        }
    }
}
