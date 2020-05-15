using System;
using System.Collections.Generic;

namespace InfnetBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quando dizemos que p é do tipo Pessoa:
            // 1. Não podemos instanciar como new Pessoa();
            // 2. Mesmo instanciando como new PessoaFisica() ou new PessoaJuridica(), só temos acesso aos membros de Pessoa
            // 2.1 Ou seja: mesmo sendo new PessoaFisica(), não temos acesso à propriedade Nome, por exemplo.
            Pessoa  p = new PessoaFisica();
            p.CadastroPessoa = "453.178.287-91";
            p.Enderecos = new List<Endereco>();
            Endereco e = new Endereco
            {
                TipoLogradouro = "",
                Logradouro = "Palácio da Alvorada",
                Numero = "", 
                Complemento = "",
                Bairro = "",
                Municipio = "Brasília",
                Uf = "DF",
                Pais = "Brasil",
                Cep = ""
            };
            p.Enderecos.Add(e);

            Console.WriteLine(p.ListarEnderecos());
            ContaBancaria c1 = new ContaBancaria();
            c1.Titular = p;

        }

        private static void Exemplo20200515_1()
        {
            Endereco e1 = new Endereco
            {
                TipoLogradouro = "Rua",
                Logradouro = "São José",
                Numero = "90",
                Complemento = "2º, 4º e 5º andares",
                Bairro = "Centro",
                Municipio = "Rio de Janeiro",
                Uf = "RJ",
                Pais = "Brasil",
                Cep = "20010-020"
            };

            Endereco e2 = new Endereco
            {
                TipoLogradouro = "Rua",
                Logradouro = "do Rosário",
                Numero = "129",
                Complemento = "",
                Bairro = "Centro",
                Municipio = "Rio de Janeiro",
                Uf = "RJ",
                Pais = "Brasil",
                Cep = "20041-005"
            };

            Pessoa p = new PessoaJuridica();
            p.CadastroPessoa = "00.673.757/0001-46";
            p.Email = "infnet@infnet.edu.br";
            p.Telefone = "(21) 2122-8800";
            p.Enderecos = new List<Endereco>();
            p.Enderecos.Add(e1);
            p.Enderecos.Add(e2);

            var enderecos = p.ListarEnderecos();
            Console.WriteLine(enderecos);
        }

        private static void Exemplo20200513()
        {
            var clientes = new List<Pessoa>();
            Console.WriteLine("Informe os nomes dos clientes a seguir.");
            while (true)
            {
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                string sobrenome = Console.ReadLine();
                PessoaFisica p = new PessoaFisica(cpf, nome, sobrenome);
                clientes.Add(p);
                Console.Write("Digite qualquer tecla para continuar, 0 para sair... ");
                string opcao = Console.ReadLine();
                if (opcao == "0")
                {
                    break;
                }
            }
        }

        private static void Exemplo20200508()
        {
            ContaPoupanca conta1 = new ContaPoupanca();
            conta1.DataAniversario = new DateTime(2020, 01, 08);
            conta1.Depositar(1000);
            Console.WriteLine(conta1.Saldo);
            conta1.CalcularRentabilidade();
            Console.WriteLine(conta1.Saldo);
        }

    }
}
