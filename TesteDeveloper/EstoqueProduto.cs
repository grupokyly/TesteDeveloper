using System;
using System.Collections.Generic;

namespace TesteDeveloper
{
    /// <summary>
    /// Estrutura para saldo de estoque da referência
    /// </summary>
    public class EstoqueProduto : IEquatable<EstoqueProduto>
    {
        /// <summary>
        /// Identificador da referência/produto
        /// </summary>
        public string Referencia { get; set; }

        /// <summary>
        /// Quantidade em estoque
        /// </summary>
        public int SaldoEstoque { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as EstoqueProduto);
        }

        public bool Equals(EstoqueProduto other)
        {
            return other != null &&
                   Referencia == other.Referencia;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Referencia);
        }

        public static bool operator ==(EstoqueProduto left, EstoqueProduto right)
        {
            return EqualityComparer<EstoqueProduto>.Default.Equals(left, right);
        }

        public static bool operator !=(EstoqueProduto left, EstoqueProduto right)
        {
            return !(left == right);
        }
    }
}