using System;
using System.Collections.Generic;

public class Produto
{
    public string Nome { get; set; }
    public double Valor { get; set; }
    public int QuantidadeEstoque { get; set; }

    public Produto(string nome, double valor, int quantidadeEstoque)
    {
        Nome = nome;
        Valor = valor;
        QuantidadeEstoque = quantidadeEstoque;
    }
}