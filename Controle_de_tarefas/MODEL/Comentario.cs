
namespace MODEL
{
    public class Comentario
    {
        private int id;
        private int id_Tarefa;
        private int id_Usuario;
        private string descricao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public int Id_tarefa
        {
            get { return id_Tarefa; }
            set { id_Tarefa = value; }
        }


        public int Id_Usuario
        {
            get { return id_Usuario; }
            set { id_Usuario = value; }
        }


        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


    }
}
