using System;
using System.Collections.Generic;
using System.Text;

namespace VendaProduto
{
    class Pedido : Cliente
    {
        public string IdPedido { get; set; }
        public DateTime Data { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Produto> produtos { get; set; }
        public double ValorTotal { get; set; }

        public Pedido()
        {
        }

        public Pedido(string id, DateTime data, List<Cliente> clientes, List<Produto> produtos, double valorTotal)
        {
            IdPedido = id;
            Data = data;
            Clientes = clientes;
            this.produtos = produtos;
            ValorTotal = valorTotal;
        }
        string idC;
        public void DadosPedido(List<Produto> produtos, List<Cliente> cliente)
        {
            string idPro = "";
            double valorFinal = 0, va=0;
            int quant = 0;
            Console.Write("Digite o Id do pedido: ");
            IdPedido = Console.ReadLine();
            Console.WriteLine($"Data do pedido: { Data = DateTime.Now}");

            Console.WriteLine("--------Clientes:--------");
            foreach (var c in cliente)
            {
                Console.WriteLine($"Nome do cliente: {c.NomeCliente} - Id do cliente: {c.IdCliente}");
            }
            Console.Write($"Id de um cliente: ");
            idC = Console.ReadLine();
            while (!(cliente.Exists(x => x.IdCliente == idC)))
            {
                Console.Write("Digite um Id correto: ");
                idC = Console.ReadLine();
            }
            if (cliente.Exists(x => x.IdCliente == idC))
            {
                Console.WriteLine("--------Produtos:--------");
                foreach (var p in produtos)
                {
                    Console.WriteLine($"Id do produto: {p.Id} - nome do produto: {p.NomeProduto} - valor do produto: {va = p.Valor} - quantidade do produto: {p.Quantidade}");
                }
                Console.Write("digite quantos produtos diferentes irá comprar:");
                var qntPro = int.Parse(Console.ReadLine());
                for (int i = 0; i < qntPro; i++)
                {
                    Console.Write("digite o Id de um produto: ");
                    idPro = Console.ReadLine();
                    while (!(produtos.Exists(x => x.Id == idPro)))
                    {
                        Console.Write("Digite um id correto: ");
                        idPro = Console.ReadLine();
                    }
                    if (produtos.Exists(x => x.Id == idPro))
                    {
                        Console.Write("Digite a quantidade que deseja comprar desse produto: ");
                        quant = int.Parse(Console.ReadLine());
                     
                    }
                    valorFinal += ( va * quant);
                }

                if (valorFinal >= 100 && valorFinal < 300)
                    ValorTotal = valorFinal - (valorFinal * 5) / 100;
                else if (valorFinal >= 300)
                    ValorTotal = valorFinal - (valorFinal * 10) / 100;

                Console.WriteLine($"Compra do(a) cliente com Id: {idC} finalizada. ");
                Console.WriteLine($"Cliente com Id: {idC} gastou R$ {ValorTotal}");
            }
            
        }

        public override string ToString()
        {
            return $"Número do pedido: {IdPedido} - data do pedido: {Data} - Id do cliente: {idC} - Valor total da compra: {ValorTotal}";
        }
    } 
}
