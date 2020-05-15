using System;
using System.Collections.Generic;
using System.Text;

namespace InfnetBanking
{
    // Classe abstrata: https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members
    // uma classe "incompleta", que pode conter membros não implementados que devem ser implementados por classes derivadas
    // Palavra reservada abstract: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/abstract
    public abstract class Pessoa
    {
        public string CadastroPessoa { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<ContaBancaria> ContasBancarias { get; set; }

        // Método abstrato: deve ser implementado por todas as classes derivadas.
        public abstract bool CalcularAniversario();


        //
        // Palavra reservada virtual: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/virtual
        public virtual string ListarEnderecos()
        {
            string listaEnderecos = "";
            int contador = 1;
            foreach(var endereco in Enderecos)
            {
                listaEnderecos += "Endereço " + contador + Environment.NewLine;
                listaEnderecos += endereco.ToString() + Environment.NewLine + Environment.NewLine;

                contador++;
                /*
                 * Endereço 1
                 * Rua São José, 90, 2º, 4º e 5º andares
                 * Centro, Rio de Janeiro, RJ, Brasil
                 * CEP 200020-001
                 * 
                 * Endereço 2
                 * Rua do Rosário, 136
                 * Centro, Rio de Janeiro, RJ, Brasil
                 * CEP 200020-002
                 */
            }

            return listaEnderecos;
        }
    }
}