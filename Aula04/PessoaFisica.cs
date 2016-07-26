using System;

namespace Aula04
{
    public class PessoaFisica: Pessoa, IDisposable
    {
        public string CPF { get; set; }
        public string RG { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
