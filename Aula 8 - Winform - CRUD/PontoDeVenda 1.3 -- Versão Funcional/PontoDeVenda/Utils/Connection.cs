using System;
using System.Data;
using System.Data.SqlClient;

namespace PontoDeVenda.Utils
{
    class Connection
    {
        private readonly SqlConnection con;
        private readonly string DataBase = "PDV";

        public Connection()
        {
            
            string stringConnection = @"Data Source = Nell; Initial Catalog = PDV; Integrated Security = True";
            con = new SqlConnection(stringConnection);
            con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public SqlConnection ReturnConnection()
        {
            return con;
        }

    }
}
