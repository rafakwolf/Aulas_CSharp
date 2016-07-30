using System.Collections.Generic;

namespace Aula5.Exercicio
{
    public interface IPersistencia
    {
        bool Consultar(Cidade c);
        void Salvar(Cidade c);
        void Excluir(Cidade c);

        List<Cidade> Listar();
    }
}