using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace VendaProduto
{
    class Pedido
    {
        public int IdPedido { get; set; }
        public string Data { get; set; }
        public double ValorTotal { get; set; }
        public int idC { get; set; }

        public Pedido()
        {
        }

        public Pedido(int idPedido, string data, double valorTotal, int idc)
        {
            IdPedido = idPedido;
            Data = data;
            ValorTotal = valorTotal;
            idC = idc;
        }

       
        public void DadosPedido(List<Produto> produtos, List<Cliente> cliente)
        {
            Random rnd = new Random();
            double valorFinal = 0, va = 0;
            int quant = 0, q = 0, idPro;
            IdPedido = rnd.Next(1000, 9999);
            Console.Write($"Digite o Id do pedido: {IdPedido}");

            Console.WriteLine($"\nData do pedido: {Data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}");

            Console.WriteLine("--------Clientes:--------");
            foreach (var c in cliente)
            {
                Console.WriteLine($"Nome do cliente: {c.NomeCliente} - Id do cliente: {c.IdCliente}");
            }
            Console.Write($"Id de um cliente: ");
            idC = int.Parse(Console.ReadLine());
            while (!(cliente.Exists(x => x.IdCliente == idC)))
            {
                Console.Write("Digite um Id correto: ");
                idC = int.Parse(Console.ReadLine());
            }
            if (cliente.Exists(x => x.IdCliente == idC))
            {
                Console.WriteLine("--------Produtos:--------");
                foreach (var p in produtos)
                {
                    Console.WriteLine($"Id do produto: {p.Id} - nome do produto: {p.NomeProduto} - valor do produto: {p.Valor} - quantidade do produto: {q = p.Quantidade}");
                }
                Console.Write("digite quantos produtos diferentes irá comprar: ");
                var qntPro = int.Parse(Console.ReadLine());
                for (int i = 0; i < qntPro; i++)
                {
                    Console.Write("digite o Id de um produto: ");
                    idPro = int.Parse(Console.ReadLine());
                    while (!(produtos.Exists(x => x.Id == idPro)))
                    {
                        Console.Write("Digite um id correto: ");
                        idPro = int.Parse(Console.ReadLine());
                    }
                    if (produtos.Exists(x => x.Id == idPro))
                    {
                        Console.Write("Digite a quantidade que deseja comprar desse produto: ");
                        quant = int.Parse(Console.ReadLine());
                        while (quant <= 0 || quant > q)
                        {
                            Console.Write("Digite uma quantidade correta: ");
                            quant = int.Parse(Console.ReadLine());
                        }

                    }
                    va = produtos.Sum(p => p.Valor);
                    valorFinal = (va * quant);

                }

                if (valorFinal >= 100 && valorFinal < 300)
                    ValorTotal = valorFinal - (valorFinal * 5) / 100;
                else if (valorFinal >= 300)
                    ValorTotal = valorFinal - (valorFinal * 10) / 100;

                Console.WriteLine($"Compra do(a) cliente com Id: {idC} finalizada. ");
                Console.WriteLine($"Cliente com Id: {idC} gastou R$ {ValorTotal.ToString("f2", CultureInfo.InvariantCulture)}");
            }

        }

        public override string ToString()
        {
            return $"Número do pedido: {IdPedido} - data do pedido: {Data} - Id do cliente: {idC} - Valor total da compra: {ValorTotal.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
