using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFirst_6320048_Prova
{
    public partial class CadastroExame : Form
    {
        public CadastroExame()
        {
            InitializeComponent();
        }

        private void carrega_combobox()
        {
            using (var context = new ModelContainer())
            {
                var paciente = new ModelContainer().Paciente.ToList();
                cbxPaciente.DataSource = paciente;
                cbxPaciente.ValueMember = "Id";
                cbxPaciente.DisplayMember = "Nome";
                cbxPaciente.Text = "Selecione o paciente...";
            }
        }

        private void CadastroExame_Load(object sender, EventArgs e)
        {
            carrega_combobox();
        }

        int linha = 0;

        private void btnAdicionaExame_Click(object sender, EventArgs e)
        {
            this.dtgExame.Rows.Insert(linha);
            dtgExame.Rows[linha].Cells["Id"].Value = cbxPaciente.Text;
            dtgExame.Rows[linha].Cells["PacienteId"].Value = cbxPaciente.Text;
            dtgExame.Rows[linha].Cells["Nome"].Value = txtNome.Text;
            dtgExame.Rows[linha].Cells["Medico"].Value = txtMedico.Text;
            dtgExame.Rows[linha].Cells["Data"].Value = DateTime.Parse(mskData.Text);
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
            {
                using (var context = new ModelContainer())
                {
                    var exame = new Exame { PacienteId = Convert.ToInt32(cbxPaciente.SelectedValue), Nome = txtNome.Text, Medico = txtMedico.Text, Data = Convert.ToDateTime(mskData.Text) };
                    context.Exame.Add(exame);
                    context.SaveChanges();
                }
                limpar();
            } else
            {
                using (var context = new ModelContainer())
                {
                    for(int i =0; i <dtgExame.RowCount; i++)
                    {
                        var update = context.Exame.Find(int.Parse(txtId.Text));
                        update.Nome = txtNome.Text;
                        update.PacienteId = Convert.ToInt32(cbxPaciente.SelectedValue);
                        update.Medico = txtMedico.Text;
                        update.Data = DateTime.Parse(mskData.Text);
                        context.Entry(update).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                    }

                    limpar();
                }
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                int numero = int.Parse(txtId.Text);
                dtgExame.Rows.Clear();
                using (var context = new ModelContainer())
                {
                    var exame = context.Exame.Where(c => c.Paciente.Id.Equals(numero)).ToList();

                    if (exame.Count == 0)
                    {
                        MessageBox.Show("Pedido não encontrado");
                    }
                    else
                    {
                        cbxPaciente.SelectedValue = exame[0].Paciente.Id;
                        for (int i = 0; i < exame.Count; i++)
                        {
                            this.dtgExame.Rows.Add();
                            dtgExame.Rows[i].Cells["Id"].Value = exame[i].Id;
                            dtgExame.Rows[i].Cells["PacienteId"].Value = exame[i].Paciente.Nome;
                            dtgExame.Rows[i].Cells["Nome"].Value = exame[i].Nome;
                            dtgExame.Rows[i].Cells["Medico"].Value = exame[i].Medico;
                            dtgExame.Rows[i].Cells["Data"].Value = exame[i].Data;
                        }

                    }

                }
                btnSalvar.Text = "Atualizar";
            }
        }

        private void limpar()
        {
            txtId.Focus();
            txtNome.Text = null;
            cbxPaciente.Text = null;
            txtMedico.Text = null;
            mskData.Text = null;
        }

        private void btnExcluirExame_Click(object sender, EventArgs e)
        {
            int row = dtgExame.SelectedCells[0].RowIndex;
            int numero = Convert.ToInt32(dtgExame.Rows[row].Cells["Id"].Value);
            using (var context = new ModelContainer())
            {
                var delete = context.Exame.Find(numero);
                context.Entry(delete).State = System.Data.Entity.EntityState.Modified;
                context.Exame.Remove(delete);
                context.SaveChanges();

                dtgExame.Rows.Remove(dtgExame.Rows[row]);
            }
        }
    }
}