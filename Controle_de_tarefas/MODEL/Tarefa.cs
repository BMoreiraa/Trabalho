
namespace MODEL
{
    public class Tarefa
    {
        private int id;
        private int id_Usuario;
        private int descricao;
        private int estatus;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public int Id_Usuario
        {
            get { return id_Usuario; }
            set { id_Usuario = value; }
        }

        public int Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }

    }
}
