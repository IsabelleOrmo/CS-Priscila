using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{

    class DAO_Conexao
    {
        public static MySqlConnection con; // um atributo static pertence a classe logo não precisa ser instanciado 


        public static Boolean CadUsuario(string usuario, string senha, int tipo)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Login (usuario, senha, tipo) " +
                    "values ('" + usuario + "','" + senha + "'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return cad;
        }

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";user ID=" + user + ";database=" + banco + ";password=" + senha + "; SslMode = none");
                retorno = true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // finally
            {
                //Con.Close;
            }
            return retorno;
        }



        public static int Login(String usuario, String senha)
        {
            int tipo = 0; //0 quando não encontra
            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select * from Estudio_Login where usuario='" + usuario + "' and senha='" + senha + "'", con);
                MySqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString()); // pode usar parse int para converter tmb,
                    // necessario conversão pq tudo dentro do mysql é enviado como string
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally // executa msm depois do try catch 
            {
                con.Close();
            }

            return tipo;
        }

       
    }
    }


