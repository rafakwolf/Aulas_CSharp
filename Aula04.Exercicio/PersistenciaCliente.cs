using System.Collections.Generic;

namespace Aula04.Exercicio
{
    public class PersistenciaCliente : Persistencia
    {
        private List<Cliente> _clientes;

        public override void InsereCliente(Cliente c)
        {
            if (_clientes == null)
                _clientes = new List<Cliente>();

            _clientes.Add(c);
        }

        public override string Listar()
        {
            string clientesStr = "";

            foreach (var item in _clientes)
            {
                clientesStr += clientesStr + "/n";
            }

            return clientesStr;
        }
    }
}
