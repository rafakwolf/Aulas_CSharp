using System.IO;
using System.Windows.Forms;

namespace Aula06
{
    public class Arquivos
    {

        public Arquivos()
        {
        }

        public static void GravarELerArquivo()
        {
            if (!File.Exists("D:\\aula6.txt"))
            {

                var meuArquivo = File.CreateText("D:\\aula6.txt");
                meuArquivo.WriteLine("teste 123");
                meuArquivo.Close();
            }

            var lendoArquivo = File.ReadAllText("D:\\aula6.txt");
            MessageBox.Show(lendoArquivo);
        }

    }
}
