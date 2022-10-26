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
    public partial class CadUsuario : Form
    {
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (cmbBoxTipo.SelectedIndex == 0)
                tipo = 1;
            else if (cmbBoxTipo.SelectedIndex == 1)
                tipo = 2;
            try { 
            if (DAO_Conexao.CadUsuario(txtBoxUsuario.Text, txtBoxSenha.Text, tipo))
                MessageBox.Show("Novo usuário cadastrado!");
            else
                MessageBox.Show("O usuário não pode ser cadastrado...");
            }
            finally
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void cmbBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
