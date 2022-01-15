
using PontoDeVenda.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda.Model
{
    class ClientDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public ClientDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Client client)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Client VALUES (@name, @cpf, @email, @fone)";

            Cmd.Parameters.AddWithValue("@name", client.Name);
            Cmd.Parameters.AddWithValue("@cpf", client.Cpf);
            Cmd.Parameters.AddWithValue("@email", client.Email);
            Cmd.Parameters.AddWithValue("@fone", client.Fone);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir cliente no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Update(Client custToBeUpdated)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Client SET Name_Client = @name, CPF_Client = @cpf, Email_Client = @email, Fone_Client = @fone WHERE Id_Client = @id";
            Cmd.Parameters.AddWithValue("@id", custToBeUpdated.Id);
            Cmd.Parameters.AddWithValue("@name", custToBeUpdated.Name);
            Cmd.Parameters.AddWithValue("@cpf", custToBeUpdated.Cpf);
            Cmd.Parameters.AddWithValue("@email", custToBeUpdated.Email);
            Cmd.Parameters.AddWithValue("@fone", custToBeUpdated.Fone);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar cliente no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }

        public void Delete(int clientId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Client WHERE Id_Client = @id";
            Cmd.Parameters.AddWithValue("@id", clientId);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao deletar o cliente do banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Client> ListAllClients()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Client";

            List<Client> listOfClients = new();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Client client = new Client((int)rd["Id_Client"], (string)rd["Name_Client"], (string)rd["CPF_Client"], (string)rd["Email_Client"], (string)rd["Fone_Client"]);
                    listOfClients.Add(client);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar a leitura do banco. \n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listOfClients;
        }



    }

}
