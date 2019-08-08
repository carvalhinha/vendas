using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VendaProduto
{
    class Menu
    {
        string path = @"C:\Users\Treinamento 3\source\repos\VendaProduto\produto.Json";
        string path2 = @"C:\Users\Treinamento 3\source\repos\VendaProduto\cliente.Json";
        string path3 = @"C:\Users\Treinamento 3\source\repos\VendaProduto\venda.Json";
        List<Produto> produtos = new List<Produto>();
        List<Cliente> clientes = new List<Cliente>();
        List<Pedido> pedidos = new List<Pedido>();
        public void Tela()
        {

            string cadastro;
            do
            {
                Console.WriteLine("Digite 1 para cadastrar Produto\nDigite 2 para cadastrar Cliente" +
                "\nDigite 3 para mostrar todos Produtos cadastrados\nDigite 4 para mostrar todos clientes cadastrados" +
                "\nDigite 5 para efetuar a venda do produto.\nDigite 6 para mostrar todas as vendas\ndigite 7 para sair");
                cadastro = Console.ReadLine();
                Console.Clear();
                switch (cadastro)
                {
                    case "1":
                        {

                            Console.Write("Digite quantos produtos deseja cadastrar. ");
                            int numero = int.Parse(Console.ReadLine());
                            for (int i = 0; i < numero; i++)
                            {
                                Produto produto = new Produto();
                                produto.dadosProduto();
                                produtos.Add(produto);

                                Guid g = Guid.NewGuid();
                            }
                            File.WriteAllText(path, JsonConvert.SerializeObject(produtos));
                            Console.Clear();
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Digite quantos clientes deseja cadastrar. ");
                            int numero = int.Parse(Console.ReadLine());
                            for (int i = 0; i < numero; i++)
                            {
                                Cliente cliente = new Cliente();
                                cliente.DadosCliente();
                                clientes.Add(cliente);

                                Guid gg = Guid.NewGuid();
                            }
                            File.WriteAllText(path2, JsonConvert.SerializeObject(clientes));
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Lista de todos os Produtos cadastrados.");
                            foreach (var p in produtos)
                            {
                                Console.WriteLine(p);
                            }
                            Console.WriteLine();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Lista de todos os Clientes cadastrados. ");
                            foreach (var c in clientes)
                            {
                                Console.WriteLine(c);
                            }
                            Console.WriteLine();
                            break;
                        }
                    case "5":
                        {
                            Pedido pedido = new Pedido();
                            pedido.DadosPedido(produtos, clientes);
                            pedidos.Add(pedido);

                            Guid ggg = Guid.NewGuid();
                            File.WriteAllText(path3, JsonConvert.SerializeObject(pedidos));
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Lista de todas as vendas. ");
                            foreach (var pe in pedidos)
                            {
                                Console.WriteLine(pe);
                            }
                            Console.WriteLine();
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("Você saiu: ");
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite uma opcao valida!");
                            break;
                        }
                }

            } while (cadastro != "7");
        }
        public void TelaD()
        {
            produtos = JsonConvert.DeserializeObject<List<Produto>>(File.ReadAllText(path));
            clientes = JsonConvert.DeserializeObject<List<Cliente>>(File.ReadAllText(path2));
            pedidos = JsonConvert.DeserializeObject<List<Pedido>>(File.ReadAllText(path3));
        }
    }
}
