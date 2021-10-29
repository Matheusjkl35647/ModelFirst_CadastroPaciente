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
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void carrega_datagridview()
        {
            using (var context = new ModelContainer())
            {
                var paci = new ModelContainer().Paciente.ToList();
                dtgPaciente.AutoGenerateColumns = false;
                dtgPaciente.DataSource = paci;
            }
        }

        private void CadastroPaciente_Load(object sender, EventArgs e)
        {
            carrega_datagridview();
        }

        private void dtgPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Paciente paciente = (Paciente)dtgPaciente.Rows[e.RowIndex].DataBoundItem;
            txtId.Text = paciente.Id.ToString();
            txtNome.Text = paciente.Nome;
            mskCPF.Text = paciente.Cpf;
            mskCelular.Text = paciente.Celular;
            txtEmail.Text = paciente.Email;
            btnSalvar.Text = "Atualizar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                using (var context = new ModelContainer())
                {
                    var paciente = new Paciente { Nome = txtNome.Text, Cpf = mskCPF.Text, Celular = mskCelular.Text, Email = txtEmail.Text };
                    context.Paciente.Add(paciente);
                    context.SaveChanges();
                }
            } else
            {
                using (var context = new ModelContainer())
                {
                    var update = context.Paciente.Find(int.Parse(txtId.Text));
                    update.Nome = txtNome.Text;
                    update.Cpf = mskCPF.Text;
                    update.Celular = mskCelular.Text;
                    update.Email = txtEmail.Text;
                    context.Entry(update).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            carrega_datagridview();
            limpar();
        }

        private void limpar()
        {
            txtId.Focus();
            txtNome.Text = null;
            mskCPF.Text = null;
            mskCelular.Text = null;
            txtEmail.Text = null;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                using (var context = new ModelContainer())
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var busca = context.Paciente.Where(c => c.Id.Equals(id)).ToList();
                    txtNome.Text = busca[0].Nome;
                    mskCPF.Text = busca[0].Cpf;
                    mskCelular.Text = busca[0].Celular;
                    txtEmail.Text = busca[0].Email; 
                }
            }
        }
    }
}
