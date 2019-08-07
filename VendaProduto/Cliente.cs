using System;
using System.Collections.Generic;
using System.Text;

namespace VendaProduto
{
    class Cliente
    {
        public string IdCliente { get; set; }
        public string NomeCliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(string id, string nomeCliente)
        {
            IdCliente = id;
            NomeCliente = nomeCliente;
        }

        public void DadosCliente()
        {
            Console.Write("Digite o Id do cliente: ");
            IdCliente = Console.ReadLine();
            Console.Write("digite o nome do cliente: ");
            NomeCliente = Console.ReadLine();
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Id: {IdCliente} - nome: {NomeCliente}";
        }
    }
}
