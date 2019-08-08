using System;
using System.Collections.Generic;
using System.Text;

namespace VendaProduto
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string nomeCliente)
        {
            IdCliente = id;
            NomeCliente = nomeCliente;
        }

        public void DadosCliente()
        {
            Random rnd = new Random();
            IdCliente = rnd.Next(10, 99);
            Console.Write($"Digite o Id do cliente: {IdCliente}");
            Console.Write("\ndigite o nome do cliente: ");
            NomeCliente = Console.ReadLine();
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Id: {IdCliente} - nome: {NomeCliente}";
        }
    }
}
