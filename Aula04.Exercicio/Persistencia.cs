using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Exercicio
{
    public abstract class Persistencia
    {
        public abstract void InsereCliente(Cliente c);
        public abstract string Listar();
    }
}
