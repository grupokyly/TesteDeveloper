using System;
using System.Collections.Generic;

namespace TesteDeveloper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Lista de referências e estoques
            IList<EstoqueProduto> estoqueProdutos = new List<EstoqueProduto>
            {
                new EstoqueProduto{Referencia = "A2342", SaldoEstoque = 10},
                new EstoqueProduto{Referencia = "B8765", SaldoEstoque = 4},
                new EstoqueProduto{Referencia = "C9546", SaldoEstoque = 6},
                new EstoqueProduto{Referencia = "D7862", SaldoEstoque = 45},
                new EstoqueProduto{Referencia = "E6423", SaldoEstoque = 7}
            };

            //Inicializa classe gestora do estoque
            GerenciadorEstoque gerenciadorEstoque = new GerenciadorEstoque(estoqueProdutos);

            //Verifica disponível da referência A2342 para uma retirada de 10 unidades
            var estoqueDisponivel = gerenciadorEstoque.EstoqueDisponivel("A2342", 10);
            Console.WriteLine($"Estoque disponível: {estoqueDisponivel}");

            //Busca saldo de estoque da referência A2342
            var saldo = gerenciadorEstoque.GetSaldo("A2342");
            Console.WriteLine($"Saldo: {saldo}");

            //Imprime o estoque
            Console.WriteLine(gerenciadorEstoque.ToString());
        }
    }
}