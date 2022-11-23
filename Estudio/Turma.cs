using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    class Turma
    {
        private string professor;
        private string dia_semana;
        private string hora;
        private string nomemodalidade;
        private int matricula;
        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public string NomeModalidade { get => nomemodalidade; set => nomemodalidade = value; }
        public int Matricula { get => matricula; set => matricula = value; }

        public Turma(string nomemodalidade, string professor, string dia_semana, string hora)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl201176", "cl201176", "cl*17122005");
            NomeModalidade = nomemodalidade;
            Professor = professor;
            Dia_semana = dia_semana;
            Hora = hora;
        }

        public Turma(int modalidade)
        {

        }



        //metodos

        public bool cadTurma()
        {
            bool cadturma = false;
            try
            { 
                DAO_Conexao.con.Open();
                MessageBox.Show("INSERT into Estudio_Turma (nomeModalidade, professorTurma, diaSemanaTurma, horaTurma) values ('" + NomeModalidade + "','" + Professor + "','" + Dia_semana + "','" + Hora + "')");
                MySqlCommand inserir = new MySqlCommand("INSERT into Estudio_Turma (nomeModalidade, professorTurma, diaSemanaTurma, horaTurma) values ('" + NomeModalidade + "','" + Professor + "','" + Dia_semana + "','" + Hora+"')", DAO_Conexao.con);
                inserir.ExecuteNonQuery(); 
                cadturma = true; 
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close(); 
            }
            return cadturma; 
        }

    }
}
