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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201176", "cl201176", "cl*17122005"))
                Console.WriteLine("Conectado, parabéns!");
            else
                Console.WriteLine("Falha :(");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.Login(textBoxLogin.Text, textBoxSenha.Text);
            if (tipo == 0)
            { 
                MessageBox.Show("Usuário/Senha inválido~~");

            }


            if (tipo == 1)
            {
                MessageBox.Show("Usuário é adm!");
                groupBoxValidacao.Visible = false;
                menuStrip1.Enabled = true;
                arquivoToolStripMenuItem.Visible = true;
                modalidadeToolStripMenuItem.Visible = true;
            }

            if (tipo == 2)
            {
                MessageBox.Show("Usuário com acesso restrito~");
                groupBoxValidacao.Visible = false;
                menuStrip1.Enabled = true;
                arquivoToolStripMenuItem.Visible = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;

            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadAluno form2 = new cadAluno();
            form2.MdiParent = this;
            form2.Show();
            
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsuario form3 = new CadUsuario();
            form3.MdiParent = this;
            form3.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPF form4 = new CPF();
            form4.MdiParent = this;
            form4.Show();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadastroModalidade>().Count() == 0) { 
            CadastroModalidade cadastroModalidade = new CadastroModalidade();
            cadastroModalidade.MdiParent = this;
            cadastroModalidade.Show();
            }
        }

        private void aTUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AttModalidade>().Count() == 0)
            { 
            AttModalidade att = new AttModalidade();
            att.MdiParent = this;
            att.Show();
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<ExcluirModalidade>().Count() == 0)
            { 
            ExcluirModalidade exc = new ExcluirModalidade();
            exc.MdiParent = this;
            exc.Show();
            }
        }

        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TurmaCadastro>().Count() == 0)
            {
                TurmaCadastro cad = new TurmaCadastro();
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
