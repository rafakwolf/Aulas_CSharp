using System.Collections.Generic;

namespace Aula5.Exercicio
{
    public class PersistenciaCidade: IPersistencia
    {
        private readonly List<Cidade> _cidades = new List<Cidade>();

        public bool Consultar(Cidade c)
        {
            return _cidades.IndexOf(c) >= 0;
        }

        public void Salvar(Cidade c)
        {
            if (Consultar(c))
              Excluir(c);
            
            _cidades.Add(c);
        }

        public void Excluir(Cidade c)
        {
            var i = _cidades.IndexOf(c);
            var cidade = _cidades.GetRange(i, 1)[0];

            _cidades.Remove(cidade);
        }

        public List<Cidade> Listar()
        {
            return _cidades;
        }

   }
}