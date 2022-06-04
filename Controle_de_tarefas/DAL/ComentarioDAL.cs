using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class ComentarioDAL
    {
        public Comentario Inserir(Comentario _comentario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.ConexaoBanco;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirComentario";

                //-------------------------------------
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _comentario.Id
                };
                cmd.Parameters.Add(pId);

                SqlParameter pId_Usuario = new SqlParameter("@Id_Usuario", SqlDbType.Int)
                {
                    Value = _comentario.Id_Usuario
                };
                cmd.Parameters.Add(pId_Usuario);

                SqlParameter pDescricao = new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _comentario.Descricao
                };
                cmd.Parameters.Add(pDescricao);

                SqlParameter pId_Tarefa = new SqlParameter("@Id_Tarefa", SqlDbType.Int)
                {
                    Value = _comentario.Id_tarefa
                };
                cmd.Parameters.Add(pId_Tarefa);


                cn.Open();
                _comentario.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _comentario;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public DataTable Buscar(string _Id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.ConexaoBanco;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarComentario";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                pId.Value = _Id;
                da.SelectCommand.Parameters.Add(pId);

                cn.Open();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
