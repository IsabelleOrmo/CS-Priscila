using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {

        private string Nome;
        private string Descricao;
        private string Preco;
        private string QntdAlunos;
        private string QntdAulas;

        public Modalidade(string nome, string descricao, string preco, string qntdAlunos, string qntdAulas)
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
            SetNome(nome);
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

        public void SetPreco(string Preco)
        {
            this.Preco = Preco;
        }

        public string GetPreco()
        {
            return this.Preco;
        }

        public void SetQntdAlunos(string QntdAlunos)
        {
            this.QntdAlunos = QntdAlunos;
        }

        public string GetQntdAlunos()
        {
            return this.QntdAlunos;
        }


        public void SetQntdAulas(string QntdAulas)
        {
            this.QntdAulas = QntdAulas;
        }

        public string GetQntdAulas()
        {
            return this.QntdAulas;
        }

        // construtores

        public Modalidade()
        {

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

        // consultar modalidade
        public bool consultarModalidade()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("SELECT * from Estudio_Modalidade" + "WHERE Nome '" + Nome + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consultar.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }

    }
}