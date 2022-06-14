using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public class TarefaBLL
    {
        public Tarefa Inserir(Tarefa _tarefa)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Inserir(_tarefa);
        }

        public DataTable Buscar(string _filtro)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Buscar(_filtro);
        }

        public Tarefa Alterar(Tarefa _tarefa)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Alterar(_tarefa);
        }

        public void Excluir(int _ID)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            tarefaDAL.Excluir(_ID);
        }
    }
}
