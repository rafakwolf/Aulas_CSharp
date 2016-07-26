using System;

namespace Aula04
{
    public class AlunoMestrado: Pessoa
    {
        public override void ImprimeEstudo()
        {
            base.ImprimeEstudo();

            Console.WriteLine("Estudos Mestrado");
        }
    }
}
