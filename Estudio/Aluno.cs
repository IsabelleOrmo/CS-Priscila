using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
       
       // private byte[] foto;
       private bool ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cidade, string estado, string telefone, string email)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl201176", "cl201176", "cl*17122005");
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
        }

        public Aluno (string cpf)
        {
            setCPF(cpf);
        }

        public bool excluirAluno() 
        { 
            bool exc = false;
        try
        {
            DAO_Conexao.con.Open();
            MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Aluno SET ativoAluno " + "= 1 WHERE CPFAluno ='" + CPF + "'", DAO_Conexao.con);
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

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno " + "WHERE CPFAluno= '" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
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

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setRua(string Rua)
        {
            this.Rua = Rua;
        }


        public string getRua()
        {
            return this.Rua;
        }

        public void setNumero(string Numero)
        {
            this.Numero = Numero;
        }

        public string getNumero()
        {
            return this.Numero;
        }
        public void setBairro(string Bairro)
        {
            this.Bairro = Bairro;
        }

        public string getBairro()
        {
            return this.Bairro;
        }
        public void setComplemento(string Complemento)
        {
            this.Complemento = Complemento;
        }

        public string getComplemento()
        {
            return this.Complemento;
        }

        public void setCidade(string Cidade)
        {
            this.Cidade = Cidade;
        }

        public string getCidade()
        {
            return this.Cidade;
        }

        public void setEstado(string Estado)
        {
            this.Estado = Estado;
        }

        public string getEstado()
        {
            return this.Estado;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }
        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public bool CadAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email+"')", DAO_Conexao.con);
                //insere.Parameters.AddWithValue("foto", this.foto);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
    }

   
}
