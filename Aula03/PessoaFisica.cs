﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class PessoaFisica: Pessoa
    {
        public PessoaFisica()
        {
            this.ValidaNome();
        }

        public override void ValidaDocumento()
        {
            throw new NotImplementedException();
        }
    }
}
