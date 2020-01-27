using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ImportaDados.Model;

namespace ImportaDados.DAO
{
    public class PassagemDAO
    {
        //Editar a string de conexão de acordo com a configuracao do BD local usado.
        string conexao = "SERVER=localhost; DATABASE=PassagemDB; UID=root; PWD=;";
        MySqlConnection connectionString = null;
        MySqlCommand comando;
              

        public void Inserir(Passagem obj)
        {
            try
            {
                connectionString = new MySqlConnection(conexao);
                connectionString.Open();
                string insertQuery = "INSERT INTO PASSAGEMDB.PASSAGEM(placa, data, hora, equipamento, faixa) VALUES('" + obj.Placa + "', '" + obj.Data + "', '" + obj.Hora + "', '" + obj.Equipamento + "', '" + obj.Faixa + "')";
                comando = new MySqlCommand(insertQuery, connectionString);
                comando.ExecuteNonQuery();
                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Model.ListaPassagem lista()
        {
            try
            {
                Model.ListaPassagem listarPassagem = new ListaPassagem();
                connectionString = new MySqlConnection(conexao);
                comando = new MySqlCommand("SELECT * FROM passagem", connectionString);
                connectionString.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                comando.Parameters.Clear();
                if(dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Passagem objPassagem = new Passagem();
                        objPassagem.Placa = dr["placa"].ToString();
                        objPassagem.Data = dr["data"].ToString();
                        objPassagem.Hora = dr["hora"].ToString();
                        objPassagem.Equipamento = dr["equipamento"].ToString();
                        objPassagem.Faixa = dr["faixa"].ToString();
                        listarPassagem.Add(objPassagem);
                    }
                }
                return listarPassagem;
            }
            catch (MySqlException sEx)
            {
                throw new Exception(sEx.Message);
            }
            catch
            {
                throw new InvalidOperationException("Oops algo inesperado aconteceu ╮(￣ω￣;)╭");
            }
            finally
            {
                connectionString.Close();
            }
        }
    }
}
