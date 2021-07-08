using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jefter_ACME.Dominio;

namespace Jefter_ACME.Dados
{
    public class VooDados
    {
        ConexaoDados conexao = new ConexaoDados();

        public List<VooDominio> Buscar(VooDominio objVoo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT ID_VOO FROM TB_VOO WHERE  ID_VOO = @ID_VOO";

            comando.Parameters.Add("ID_VOO", SqlDbType.Int).Value = objVoo.Id_voo;

            comando.Connection = conexao.conectar();

            SqlDataReader dr;
            List<VooDominio> lista = new List<VooDominio>();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    VooDominio dado = new VooDominio();

                    dado.Id_voo = Convert.ToInt32(dr["ID_VOO"]);

                    lista.Add(dado);
                }
            }
            return lista;

        }

        public int Salvar(VooDominio objVoo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.CommandText = "INSERT INTO TB_VOO ([DATA_VOO], [CUSTO], [DISTANCIA], [CAPTURA], [NIVEL_DOR]) VALUES (@DATA_VOO, @CUSTO, @DISTANCIA, @CAPTURA, @NIVEL_DOR)";

            comando.Parameters.Add("DATA_VOO", SqlDbType.DateTime).Value = objVoo.Data_voo;
            comando.Parameters.Add("CUSTO", SqlDbType.Decimal).Value = objVoo.Custo;
            comando.Parameters.Add("DISTANCIA", SqlDbType.Int).Value = objVoo.Distancia;
            comando.Parameters.Add("CAPTURA", SqlDbType.Char).Value = objVoo.Captura;
            comando.Parameters.Add("NIVEL_DOR", SqlDbType.Int).Value = objVoo.Nivel_dor;

            comando.Connection = conexao.conectar();

            int qtd = comando.ExecuteNonQuery();
            Console.Write(qtd);
            return qtd;

        }

        public int Atualizar(VooDominio objVoo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.CommandText = "UPDATE TB_VOO SET DATA_VOO = @DATA_VOO, CUSTO = @CUSTO, DISTANCIA = @DISTANCIA, CAPTURA = @CAPTURA, NIVEL_DOR = @NIVEL_DOR WHERE ID_VOO = @ID_VOO";

            comando.Parameters.Add("ID_VOO", SqlDbType.Int).Value = objVoo.Id_voo;
            comando.Parameters.Add("DATA_VOO", SqlDbType.DateTime).Value = objVoo.Data_voo;
            comando.Parameters.Add("CUSTO", SqlDbType.Decimal).Value = objVoo.Custo;
            comando.Parameters.Add("DISTANCIA", SqlDbType.Int).Value = objVoo.Distancia;
            comando.Parameters.Add("CAPTURA", SqlDbType.Char).Value = objVoo.Captura;
            comando.Parameters.Add("NIVEL_DOR", SqlDbType.Int).Value = objVoo.Nivel_dor;

            comando.Connection = conexao.conectar();

            int qtd = comando.ExecuteNonQuery();
            Console.Write(qtd);
            return qtd;
        }

        public int Excluir(VooDominio objVoo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.CommandText = "DELETE FROM TB_VOO WHERE ID_VOO = @ID_VOO";

            comando.Parameters.Add("ID_VOO", SqlDbType.Int).Value = objVoo.Id_voo;

            comando.Connection = conexao.conectar();

            int qtd = comando.ExecuteNonQuery();
            Console.Write(qtd);
            return qtd;
        }

        public List<VooDominio> Lista()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT * FROM TB_VOO ORDER BY DATA_VOO";

            comando.Connection = conexao.conectar();

            SqlDataReader dr;
            List<VooDominio> lista = new List<VooDominio>();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    VooDominio dado = new VooDominio();

                    dado.Id_voo = Convert.ToInt32(dr["ID_VOO"]);
                    dado.Data_voo = Convert.ToDateTime(dr["DATA_VOO"]);
                    dado.Custo = Convert.ToDouble(dr["CUSTO"]);
                    dado.Distancia = Convert.ToInt32(dr["DISTANCIA"]);
                    dado.Captura = Convert.ToString(dr["CAPTURA"]);
                    dado.Nivel_dor = Convert.ToInt32(dr["NIVEL_DOR"]);

                    lista.Add(dado);
                }
            }
            return lista;
        }
    }
}
