using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VendaProduto
{
    class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(int id, string nomeProduto, int valor, int quantidade)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Valor = valor;
            Quantidade = quantidade;
        }

        public void dadosProduto()
        {
            Random rnd = new Random();
            Id = rnd.Next(100, 999);
            Console.Write($"Digite o Id do Produto: {Id}");            
            Console.Write("\ndigite o nome do Produto: ");
            NomeProduto = Console.ReadLine();
            Console.Write($"Digite o valor do(a) {NomeProduto} R$: ");
            Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Digite a quantidade do(a) {NomeProduto}: ");
            Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Id: {Id} - nome: {NomeProduto} - valor: {Valor.ToString("f2", CultureInfo.InvariantCulture)} - quantidade: {Quantidade}";
        }
    }
}
