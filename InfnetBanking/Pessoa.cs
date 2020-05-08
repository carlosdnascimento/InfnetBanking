using System;
using System.Collections.Generic;

namespace InfnetBanking
{
    public class Pessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<ContaBancaria> Contas { get; set; }

        public string ImprimirNome()
        {
            return Nome + " " + Sobrenome;
        }
    }
}