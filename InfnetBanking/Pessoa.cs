using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace InfnetBanking
{
    public class Pessoa : IComparable<Pessoa>, IEquatable<Pessoa>
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<ContaBancaria> Contas { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string cpf, string nome, string sobrenome)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public int CompareTo(Pessoa p)
        {
            int comp_nomes = this.Nome.CompareTo(p.Nome);
            if (comp_nomes != 0) //Se os nomes forem diferentes
            {
                return comp_nomes; 
            } else //Se os nomes forem iguais
            {
                //Compare os sobrenomes
                int comp_sobrenomes = this.Sobrenome.CompareTo(p.Sobrenome); 
                if (comp_sobrenomes == 0) //Se os sobrenomes forem iguais
                {
                    //Compare os CPFs
                    return this.Cpf.CompareTo(p.Cpf);
                }
                else return comp_sobrenomes;
            }
        }

        public bool Equals(Pessoa p)
        {
            if(this.Nome.Equals(p.Nome) 
                && this.Sobrenome.Equals(p.Sobrenome) 
                && this.Cpf.Equals(p.Cpf))
            {
                return true;
            } else
            {
                return false; 
            }
        }

        public string ImprimirNome()
        {
            return Nome + " " + Sobrenome;
        }
    }
}