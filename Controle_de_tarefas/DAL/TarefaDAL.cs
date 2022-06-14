using MODEL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TarefaDAL
    {
        public Tarefa Inserir(Tarefa _tarefa)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.ConexaoBanco;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirTarefa";

                //-------------------------------------
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _tarefa.Id
                };
                cmd.Parameters.Add(pId);

                SqlParameter pId_Usuario = new SqlParameter("@Id_Usuario", SqlDbType.Int)
                {
                    Value = _tarefa.Id_Usuario
                };
                cmd.Parameters.Add(pId_Usuario);

                SqlParameter pDescricao = new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _tarefa.Descricao
                };
                cmd.Parameters.Add(pDescricao);

                SqlParameter pEstatus = new SqlParameter("@Estatus", SqlDbType.VarChar)
                {
                    Value = _tarefa.Estatus
                };
                cmd.Parameters.Add(pEstatus);


                cn.Open();
                _tarefa.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _tarefa;
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

        public DataTable Buscar(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BuscarTarefa";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

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

        public Tarefa Alterar(Tarefa _tarefa)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.ConexaoBanco; ;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarTarefa";

                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _tarefa.Id
                };
                cmd.Parameters.Add(pId);

                SqlParameter pId_Usuario = new SqlParameter("@Id_Usuario", SqlDbType.Int)
                {
                    Value = _tarefa.Id_Usuario
                };
                cmd.Parameters.Add(pId_Usuario);

                SqlParameter pDescricao = new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _tarefa.Descricao
                };
                cmd.Parameters.Add(pDescricao);

                SqlParameter pEstatus = new SqlParameter("@Estatus", SqlDbType.VarChar)
                {
                    Value = _tarefa.Estatus
                };
                cmd.Parameters.Add(pEstatus);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _tarefa;

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

        public void Excluir(int _Id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.ConexaoBanco;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirTarefa";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _Id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não foi posivel excluir o usuario: " + _Id.ToString());

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
