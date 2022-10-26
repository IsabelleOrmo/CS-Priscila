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
    public partial class CadastroModalidade : Form
    {
        public CadastroModalidade()
        {
            InitializeComponent();
        }

        private void btnCadastrarModalidade_Click(object sender, EventArgs e)
        {
            int nomeMol = 0;
            if (comboBoxModalidade.SelectedIndex == 0)
                nomeMol = 1;
            Modalidade modalidade = new Modalidade(comboBoxModalidade.Text, txtBoxDescricao.Text, maskedTextBoxPreco.Text, maskedTextBoxAlunos.Text, maskedTextBoxAulas.Text);
            try {
                if (modalidade.CadModalidade())
                    MessageBox.Show("Modalidade cadastrado!");
                else
                    MessageBox.Show("Não foi possível fazer o cadastro");
            }
            finally
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void comboBoxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
