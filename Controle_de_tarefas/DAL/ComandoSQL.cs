using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ComandoSQL
    {
        private SqlCommand comando;
        private List<ParametrosSQL> parametros;
        
        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }


        public List<ParametrosSQL> Parametros
        {
            get { return parametros; }
            set { parametros = value;}
        }


    }
}
