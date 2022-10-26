using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class cadAluno : Form
    {
        public cadAluno()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {

            // byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(maskedTxtBoxCPF.Text, txtBoxNome.Text, txtBoxEndereco.Text, textBoxBairro.Text,textBoxCidade.Text ,txtBoxEstado.Text, textBoxComplemento.Text, maskedTxtBoxN.Text, maskedTxtBoxTelefone.Text, txtBoxEmail.Text);
            try
            {
                if (aluno.CadAluno())
                    MessageBox.Show("Aluno cadastrado!");
                else
                    MessageBox.Show("ErRo :(");
            }
            finally
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTxtBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTxtBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTxtBoxCPF.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado!");
                }
                else
                {
                    maskedTxtBoxCPF.Focus();
                }
            }
        }
    }
}
