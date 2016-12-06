using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Aula06
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            SerializacaoJson();
            //Arquivos();
            //LendoArquivos();
            
        }

        private void MetodoLevantaExcecao()
        {
            throw new Exception("Exceção para demonstração");
        }

        private void MetodoQualquer()
        {
            try
            {
                MetodoLevantaExcecao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Deu um errinho aqui!" + e.Message);
            }
        }

        private void MetodoQualquerComFinally()
        {
            try
            {
                MetodoLevantaExcecao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Deu um errinho aqui!" + e.Message);
            }
            finally
            {
                MessageBox.Show("Mas eu passo por aqui mesmo que der erro!");
            }
        }

        private void MetodoQualquerRepassaExcecao()
        {
            try
            {
                MetodoLevantaExcecao();
            }
            catch
            {
                throw;
            }
        }

        class MinhaExcecacao : Exception
        {
            public MinhaExcecacao(string mensagem) : base(mensagem)
            {
            }
        }

        private void MetodoQualquerFiltraExcecao()
        {
            try
            {
                MetodoLevantaExcecao();
            }
            catch (Exception e)
            {
                if (e is MinhaExcecacao)
                    MessageBox.Show("Minha exceção!");
                else
                    throw;
            }
        }

        private void MetodoQualquerFiltraExcecao2()
        {
            try
            {
                MetodoLevantaExcecao();
            }
            catch (Exception e) when (e.Message.Contains("capturar"))
            {
                MessageBox.Show("Exceção tem \"capturar\" no texto.");
            }
        }

        private void aArquivos()
        {
            var arquivo = File.CreateText("D:\\arquivoTexto.txt");
            arquivo.WriteLine("escrevendo alguma coisa no arquivo");
            arquivo.Close();
        }

        private void LendoArquivos()
        {
            var arquivo = File.ReadAllText("d:\\arquivoTexto.txt");
            MessageBox.Show(arquivo);
        }

        [Serializable]
        public class TesteSerializacao
        {
            public int member1;
            public string member2;
            public string member3;
            public double member4;

            // Esta propriedade não será serializada
            [NonSerialized]
            public string member5;

            public TesteSerializacao()
            {

                member1 = 11;
                member2 = "hello";
                member3 = "hello";
                member4 = 3.14159265;
                member5 = "hello world!";
            }

            public void Print()
            {
                Console.WriteLine("member1 = '{0}'", member1);
                Console.WriteLine("member2 = '{0}'", member2);
                Console.WriteLine("member3 = '{0}'", member3);
                Console.WriteLine("member4 = '{0}'", member4);
                Console.WriteLine("member5 = '{0}'", member5);
            }
        }

        private void Serializacao()
        {
            // Inicializa o objeto.
            var obj = new TesteSerializacao();

            Console.WriteLine("Verificando os valores das propriedades:");
            obj.Print();

            // Abrimos um arquivo no disco.
            Stream stream = File.Open("D:\\objetoSerializado.bin", FileMode.Create);
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            stream.Close();

            // Limpamos a instancia de obj.
            obj = null;

            // Agora vamos ler o arquivo criado
            stream = File.Open("D:\\objetoSerializado.bin", FileMode.Open);

            obj = (TesteSerializacao)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("");
            Console.WriteLine("Verificando novamente os valores das propriedades: ");
            obj.Print();
        }

        private void SerializacaoJson()
        {
            // Inicializa o objeto.
            var obj = new TesteSerializacao();

            Console.WriteLine("Verificando os valores das propriedades:");
            obj.Print();

            // Serialização para JSON
            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(obj);

            // Gravamos o arquivo no disco
            var jsonFile = File.CreateText("D:\\objetoSerializado.json");
            jsonFile.WriteLine(serializedResult);
            jsonFile.Close();


            // Limpamos a instancia de obj.
            obj = null;

            // Agora vamos ler o arquivo criado
            var jsonFileRead = File.ReadAllText("D:\\objetoSerializado.json");

            obj = (TesteSerializacao)serializer.Deserialize(jsonFileRead,typeof(TesteSerializacao));            

            Console.WriteLine("");
            Console.WriteLine("Verificando novamente os valores das propriedades: ");
            obj.Print();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Arquivos.GravarELerArquivo();
        }
    }
}
