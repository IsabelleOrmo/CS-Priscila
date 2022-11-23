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
    public partial class AttModalidade : Form
    {

        public AttModalidade()
        {
            InitializeComponent();
        }

        private void comboBoxConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           
        }

        private void comboBoxConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
           DAO_Conexao.con.Open();
            MySqlCommand consultar = new MySqlCommand("select Descricao, Preco, QntdAlunos, QntdAulas from Estudio_Modalidade where Nome= '" +comboBoxConsulta.SelectedItem+"'", DAO_Conexao.con);
           MySqlDataReader leia = consultar.ExecuteReader();
          while (leia.Read())
           {
                txtDescConsulta.Text = leia[0].ToString();
                txtPrecoConsulta.Text = leia[1].ToString();
                txtAlunos.Text = leia[2].ToString();
                txtAulas.Text = leia[3].ToString();
          }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AttModalidade_Load(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand consulta = new MySqlCommand("select Nome, Id from Estudio_Modalidade where ativo =0", DAO_Conexao.con);
            MySqlDataReader leia = consulta.ExecuteReader();
            while (leia.Read())
            {
                comboBoxConsulta.Items.Add(leia["Nome"].ToString());
                comboBoxConsulta.DisplayMember = (leia["Nome"].ToString());
                comboBoxConsulta.ValueMember = (leia["Id"].ToString());
            }

            DAO_Conexao.con.Close();
         
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            txtAlunos.Enabled = true;
            txtDescConsulta.Enabled = true;
            txtPrecoConsulta.Enabled = true;
            txtAulas.Enabled = true;
            btnConfirmar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBoxConsulta.Text, txtDescConsulta.Text, float.Parse(txtPrecoConsulta.Text.Replace(".", ",")), int.Parse(txtAlunos.Text), int.Parse(txtAulas.Text));
            try
            {
                if (modalidade.attModalidade())
                    MessageBox.Show("Modalidade atualizada com sucesso!");
                else
                    MessageBox.Show("Não foi possível atualizar a modalidade selecionada");
            }
            finally
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void txtDescConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
