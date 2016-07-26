using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class FormMain : Form
    {


        List<string> lista = new List<string>();


        public FormMain()
        {
            InitializeComponent();

            iniciaArray();

            lista.Add("aaaaa");
            lista.Add("aaaaa");
            lista.Add("aaaaa");
            lista.Add("aaaaa");
            lista.Add("aaaaa");
            lista.Add("aaaaa");

            lista.ForEach((item) =>
            {
                Console.WriteLine(item);
            });

        }


        public void iniciaArray()
        {
            int[] arrayDeInteiros = new int[3];
            arrayDeInteiros[0] = 10;
            arrayDeInteiros[1] = 100;
            arrayDeInteiros[2] = 200;

            String[] arrayDeString = { "um", "dois", "tres" };
            int[] arrayDeInteiro2 = { 10, 100, 200 };

            for (int i = 0; i < arrayDeString.Length; i++)
            {
                Console.WriteLine("Elemento na posição " + i
                + " contem valor " + arrayDeString[i]);
            }

            String[][] matrizDeString = new String[2][];

            matrizDeString[0] = new string[3];
            matrizDeString[1] = new string[3];
            

            matrizDeString[0][0] = "um";
            matrizDeString[0][1] = "dois";

            matrizDeString[1][0] = "tres";
            matrizDeString[1][1] = "quatro";

            for (int i = 0; i < matrizDeString.Length; i++)
            {
                for (int j = 0; j < matrizDeString[i].Length; j++)
                {
                    Console.WriteLine("Elemento na posição " + i + "," + j
                                        + " contem valor " + matrizDeString[i][j]);
                }
            }

            string s1 = "meutexto";

            string s2 = "Meu texto";

            s2 = s2 + " concatenado ";
            s2 = s2 + 10;
            Console.WriteLine(s2);
        }
    }
}
