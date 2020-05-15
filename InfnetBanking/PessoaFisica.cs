using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace InfnetBanking
{
    public class PessoaFisica : Pessoa, IComparable<PessoaFisica>, IEquatable<PessoaFisica>
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<PessoaFisica> Dependentes { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string cpf, string nome, string sobrenome)
        {
            this.CadastroPessoa = cpf;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public int CompareTo(PessoaFisica p)
        {
            int comp_nomes = this.Nome.CompareTo(p.Nome);
            if (comp_nomes != 0) //Se os nomes forem diferentes
            {
                return comp_nomes;
            }
            else //Se os nomes forem iguais
            {
                //Compare os sobrenomes
                int comp_sobrenomes = this.Sobrenome.CompareTo(p.Sobrenome);
                if (comp_sobrenomes == 0) //Se os sobrenomes forem iguais
                {
                    //Compare os CPFs
                    return this.CadastroPessoa.CompareTo(p.CadastroPessoa);
                }
                else return comp_sobrenomes;
            }
        }

        public bool Equals(PessoaFisica p)
        {
            if (this.Nome.Equals(p.Nome)
                && this.Sobrenome.Equals(p.Sobrenome)
                && this.CadastroPessoa.Equals(p.CadastroPessoa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ImprimirNome()
        {
            return Nome + " " + Sobrenome;
        }

        // Toda classe derivada deve implementar todos os membros abstratos da classe base.
        // Neste cenário, usamos a palavra reservada override
        // https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/override
        public override bool CalcularAniversario()
        {
            if (DateTime.Now.Day == DataNascimento.Day && DateTime.Now.Month == DataNascimento.Month)
            {
                return true;
            }
            return false;
        }

        public override string ListarEnderecos()
        {
            var enderecos = "Atenção: Todos os endereços de uma Pessoa Física são endereços residenciais." + Environment.NewLine + Environment.NewLine;
            enderecos += base.ListarEnderecos();
            return enderecos;
        }

    }
}