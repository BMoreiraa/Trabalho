using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Banco
    {

        public string vqueryUsuarios = @"SELECT Id, Nome FROM Usuario order by Id";
        

        public static DataTable dql (string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection();

                cn.ConnectionString = Conexao.ConexaoBanco;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, cn);
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
