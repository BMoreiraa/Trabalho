using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public class ComentarioBLL
    {
        public Comentario Inserir (Comentario _comentario)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Inserir(_comentario);
        }

        public DataTable Buscar(string _filtro)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Buscar(_filtro);
        }


    }
}
