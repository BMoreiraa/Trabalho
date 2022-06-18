using System.IO;
using System.Text;

namespace Infra
{
    public class Arquivo
    {
        public void GravarTextoNoFinalDoAquivo(string _texto, string _arquivo)
        {
            FileStream fileStream = new FileStream(_arquivo, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);

            streamWriter.WriteLine(_texto);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }
    }
}
