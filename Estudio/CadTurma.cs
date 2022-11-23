using MySql.Data.MySqlClient;
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
    public partial class TurmaCadastro : Form
    {
        public TurmaCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadTurma_Click(object sender, EventArgs e)
        {

            Turma turma = new Turma(comboBoxCadTurma.Text, txtBoxProfessor.Text, txtBoxSemana.Text, maskedTextBox1.Text);
            try
            {
                if (turma.cadTurma())
                    MessageBox.Show("Turma cadastrada!");
                else
                    MessageBox.Show("Não foi possível fazer o cadastro");
            }
            finally
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void comboBoxCadTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TurmaCadastro_Load(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand consulta = new MySqlCommand("select Nome, Id from Estudio_Modalidade where ativo =0", DAO_Conexao.con);
            MySqlDataReader leia = consulta.ExecuteReader();
            while (leia.Read())
            {
                comboBoxCadTurma.Items.Add(leia["Nome"].ToString());
                comboBoxCadTurma.DisplayMember = (leia["Nome"].ToString());
                comboBoxCadTurma.ValueMember = (leia["Id"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void maskedHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

