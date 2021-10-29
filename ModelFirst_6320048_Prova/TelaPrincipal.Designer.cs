
namespace ModelFirst_6320048_Prova
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarExame = new System.Windows.Forms.Button();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadastrarExame);
            this.panel1.Controls.Add(this.btnCadastrarPaciente);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnCadastrarExame
            // 
            this.btnCadastrarExame.Location = new System.Drawing.Point(6, 75);
            this.btnCadastrarExame.Name = "btnCadastrarExame";
            this.btnCadastrarExame.Size = new System.Drawing.Size(128, 43);
            this.btnCadastrarExame.TabIndex = 1;
            this.btnCadastrarExame.Text = "Cadastrar Exame";
            this.btnCadastrarExame.UseVisualStyleBackColor = true;
            this.btnCadastrarExame.Click += new System.EventHandler(this.btnCadastrarExame_Click);
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(6, 14);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(128, 43);
            this.btnCadastrarPaciente.TabIndex = 0;
            this.btnCadastrarPaciente.Text = "Cadastrar Paciente";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = true;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(138, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 448);
            this.panel2.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrarExame;
        private System.Windows.Forms.Button btnCadastrarPaciente;
        private System.Windows.Forms.Panel panel2;
    }
}

