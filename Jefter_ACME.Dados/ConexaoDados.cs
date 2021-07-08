using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jefter_ACME.Dados
{
    public class ConexaoDados
    {
        SqlConnection con = new SqlConnection();

        public ConexaoDados()
        {
            con.ConnectionString = @"Data Source=DESKTOP-CIU1G9F\SQLEXPRESS;Initial Catalog=acme;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
