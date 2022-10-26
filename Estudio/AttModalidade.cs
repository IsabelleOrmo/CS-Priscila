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
            int tipoConsulta = 0;
            if(comboBoxConsulta == 0)

            Modalidade modalidade = new Modalidade(comboBoxConsulta.Text);
            if(e.KeyChar == 13)
            {
                if (modalidade.consultarModalidade())
                {
                    MessageBox.Show("Modalidade cadastrada");
                }
                else
                {
                    comboBoxConsulta.Focus();
                }
            }
            }

        private void comboBoxConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
