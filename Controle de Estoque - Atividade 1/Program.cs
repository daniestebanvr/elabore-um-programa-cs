// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main()
    {
        //Criando um Controlador de estoque de produto
        
        List<Produto> produtos = new List<Produto>();
        int opcaoDigitada, contaProduto = 0;
        string nome;
        double valor;
        int quantidadeEstoque, quantidadeAtualEstoque;

        do
        {
            Console.Clear();
            Console.WriteLine("\n=== Menu de Opções ===");
            Console.WriteLine("1. Cadastrar produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Buscar Produto por Nome");
            Console.WriteLine("4. Atualizar Estoque");
            Console.WriteLine("5. Sair");
            Console.WriteLine("Escolha a opção:");
            opcaoDigitada = int.Parse(Console.ReadLine());

            if (opcaoDigitada == 1)
            {
                Console.Clear();

                Console.WriteLine("Nome do produto:");
                nome = Console.ReadLine().ToLower();
                Console.WriteLine("Valor do produto:");
                valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade em Estoque do produto:");
                quantidadeEstoque = int.Parse(Console.ReadLine());

                produtos.Add(new Produto(nome, valor, quantidadeEstoque));

                Console.Clear();

                Console.WriteLine($"Produto cadastrado com sucesso!");
                Console.WriteLine($"Nome: {produtos[contaProduto].Nome} - Preço: {produtos[contaProduto].Valor} - Quantidade em Estoque: {produtos[contaProduto].QuantidadeEstoque}");
                contaProduto++;

                Thread.Sleep(3000);
            }
            else if (opcaoDigitada == 2)
            {
                Console.Clear();
                foreach (Produto p in produtos)
                {
                    Console.WriteLine($"Nome: {p.Nome} - Preço: {p.Valor} - Quantidade em Estoque: {p.QuantidadeEstoque}");
                }
                Thread.Sleep(3000);
            }
            else if (opcaoDigitada == 3)
            {
                Console.Clear();

                Console.WriteLine("Nome do produto que deseja encontrar:");
                nome = Console.ReadLine().ToLower();

                foreach (Produto p in produtos)
                {
                    if (p.Nome == nome)
                    {
                        Console.WriteLine($"Nome: {p.Nome} - Preço: {p.Valor} - Quantidade em Estoque: {p.QuantidadeEstoque}");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.WriteLine("Procurando");
                        Console.Clear();
                        Thread.Sleep(700);
                        Console.WriteLine("Procurando.");
                        Thread.Sleep(700);
                        Console.Clear();
                        Console.WriteLine("Procurando..");
                        Thread.Sleep(700);
                        Console.Clear();
                        Console.WriteLine("Procurando...");
                        Thread.Sleep(700);
                        Console.Clear();
                    }
                }
            }
            else if (opcaoDigitada == 4)
            {
                Console.Clear();

                Console.WriteLine("Nome do produto que Atualizará o estoque:");
                nome = Console.ReadLine().ToLower();

                foreach (Produto p in produtos)
                {
                    if (p.Nome == nome)
                    {
                        Console.WriteLine($"Quantidade atual de estoque ({p.Nome})");
                        quantidadeAtualEstoque = int.Parse(Console.ReadLine());
                        p.QuantidadeEstoque = quantidadeAtualEstoque;
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.WriteLine("Procurando");
                        Console.Clear();
                        Thread.Sleep(700);
                        Console.WriteLine("Procurando.");
                        Thread.Sleep(700);
                        Console.Clear();
                        Console.WriteLine("Procurando..");
                        Thread.Sleep(700);
                        Console.Clear();
                        Console.WriteLine("Procurando...");
                        Thread.Sleep(700);
                        Console.Clear();
                    }
                }
            }
        } while (opcaoDigitada != 5);
    }
}