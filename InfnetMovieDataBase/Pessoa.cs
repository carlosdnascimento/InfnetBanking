using System;

namespace InfnetBanking
{
    public class Pessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Endereco Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public string ImprimirNome()
        {
            return Nome + " " + Sobrenome;
        }
    }
}