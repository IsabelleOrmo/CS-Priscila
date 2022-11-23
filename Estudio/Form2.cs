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
    public partial class ExcluirModalidade : Form
    {
        public ExcluirModalidade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExcluirModalidade_Load(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand consulta = new MySqlCommand("select Nome, Id from Estudio_Modalidade where ativo =0", DAO_Conexao.con);
            MySqlDataReader leia = consulta.ExecuteReader();
            while (leia.Read())
            {
                cmbExcluir.Items.Add(leia["Nome"].ToString());
                cmbExcluir.DisplayMember = (leia["Nome"].ToString());
                cmbExcluir.ValueMember = (leia["Id"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void cmbExcluir_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(cmbExcluir.Text);
            try
            {
                if (modalidade.ExcluirModalidade())
                    MessageBox.Show("Modalidade excluída");
                else
                    MessageBox.Show("Não foi possível excluir a modalidade selecionada");
            }
            finally
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }



    }
}
