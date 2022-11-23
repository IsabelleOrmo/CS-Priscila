using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    class Modalidade
    {

        private string Nome;
        private string Descricao;
        private float Preco;
        private int QntdAlunos;
        private int QntdAulas;
        private int Id;

        public int IdModalidade { get => Id; set => Id = value; }

        public Modalidade(string nome, string descricao, float preco, int qntdAlunos, int qntdAulas)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl201176", "cl201176", "cl*17122005");
            SetNome(nome);
            SetDescricao(descricao);
            SetPreco(preco);
            SetQntdAlunos(qntdAlunos);
            SetQntdAulas(qntdAulas);
        }
        public Modalidade(string nome)
        {
            Nome = nome;
        }


        //get e set

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetDescricao(string Descricao)
        {
            this.Descricao = Descricao;
        }

        public string GetDescricao()
        {
            return this.Descricao;
        }

        public void SetPreco(float Preco)
        {
            this.Preco = Preco;
        }

        public float GetPreco()
        {
            return this.Preco;
        }

        public void SetQntdAlunos(int QntdAlunos)
        {
            this.QntdAlunos = QntdAlunos;
        }

        public int GetQntdAlunos()
        {
            return this.QntdAlunos;
        }


        public void SetQntdAulas(int QntdAulas)
        {
            this.QntdAulas = QntdAulas;
        }

        public int GetQntdAulas()
        {
            return this.QntdAulas;
        }

        // construtores

        public Modalidade()
        {

        }

        //Excluir

        public bool ExcluirModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Modalidade SET ativo " + "= 1 WHERE Nome ='" + Nome + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        // cadastro da modalidade no banco
        public bool CadModalidade()
        {
            bool cadastro = false;
            try
            {
                DAO_Conexao.con.Open(); // abre a conexão com o banco
                MySqlCommand inserir = new MySqlCommand("INSERT into Estudio_Modalidade (Nome, Descricao, Preco, QntdAlunos, QntdAulas )values('" + Nome + "','" + Descricao + "','" + Preco + "','" + QntdAlunos +  "','" + QntdAulas + "')", DAO_Conexao.con); // insere os dados
                inserir.ExecuteNonQuery(); // nonquery pois não tem resultado
                cadastro = true; // se rodar o cadastro sera validado
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close(); // fecha a conexao
            }
            return cadastro; //retorna o estado do cadastro
        }


        public bool attModalidade()
        {
            bool atualizar = false;
            try
            {
                DAO_Conexao.con.Open();
                string sql = "UPDATE Estudio_Modalidade set Nome ='" + Nome +"', Descricao ='" + Descricao + "', Preco ='" + Preco + "', QntdAlunos ='" + QntdAlunos + "', QntdAulas ='"+ QntdAulas + "' WHERE Nome ='" + Nome + "' limit 1";
                MySqlCommand confirmar = new MySqlCommand(sql, DAO_Conexao.con);
                confirmar.ExecuteNonQuery();
                atualizar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return atualizar;
        }
    

        }
        

    }
