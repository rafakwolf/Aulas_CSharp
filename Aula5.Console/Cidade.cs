﻿namespace Aula5.Exercicio
{
    public class Cidade
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }


        public override bool Equals(object obj)
        {
            return ((Cidade) obj).Codigo == Codigo;
        }

        public override string ToString()
        {
            return "Código " +Codigo + ", Nome "+Nome+ ", Estado "+Uf;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}