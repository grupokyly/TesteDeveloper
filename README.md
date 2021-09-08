# Desafio de lógica de programação.

A classe [GerenciadorEstoque.cs](https://github.com/grupokyly/TesteDeveloper/blob/master/TesteDeveloper/GerenciadorEstoque.cs) não está completa. 
Precisamos implementar a lógica para alguns métodos de nossa classe de gestão do estoque. Veja os requisitos abaixo:

- [GetSaldo(string referencia)](https://github.com/grupokyly/TesteDeveloper/blob/master/TesteDeveloper/GerenciadorEstoque.cs#L42) - Esse método deve retornar o saldo de estoque da referência
 ```cs
        /// <summary>
        /// Buscar saldo de estoque da referência
        /// </summary>
        /// <param name="referencia">Identificador da referência/produto</param>
        /// <returns>Saldo de estoque</returns>
        public int GetSaldo(string referencia)
        {
            //TODO - Implemente sua lógica para buscar e retornar o estoque da referência
            //Dica: Os estoques estão na lista _estoques inicializada no construtor
        }
```


- [EstoqueDisponivel(string referencia, int quantidadeRequerida)](https://github.com/grupokyly/TesteDeveloper/blob/master/TesteDeveloper/GerenciadorEstoque.cs#L31) - Esse método deve retornar verdadeiro se há estoque suficiente para atender a quantidade requerida para referência e falso quando a quantidade de estoque for insuficiente.
```cs
        /// <summary>
        /// Verifica se a quantidade requerida existe no estoque da referência
        /// </summary>
        /// <param name="referencia">Identificador da referência/produto</param>
        /// <param name="quantidadeRequerida">Quantidade requerida</param>
        /// <returns>Indica se a quantidade requerida existe ou não no estoque</returns>
        public bool EstoqueDisponivel(string referencia, int quantidadeRequerida)
        {
            //TODO - Implemente sua lógica para validar o estoque da referência contra a quantidade requerida
            //Dica: Os estoques estão na lista _estoques inicializada no construtor
        }
```

- [ToString()](https://github.com/grupokyly/TesteDeveloper/blob/master/TesteDeveloper/GerenciadorEstoque.cs#L57) - Esse método deve retornar uma string com o extrato do estoque
```cs
        /// <summary>
        /// Gera string com os estoques no formato [Referência: {Referencia} Saldo: {SaldoEstoque}] com uma linha para cada referência
        /// Ex: 
        /// Referência: A345 Saldo: 98
        /// Referência: B456 Saldo: 15
        /// 
        /// </summary>
        /// <returns>String formatada</returns>
        public override string ToString()
        {
            //TODO - Implemente sua lógica para formatar uma string no formato esperado
            //Dica: Os estoques estão na lista _estoques inicializada no construtor
        }
```

<hr/>

A implementação deve ser feita na linguagem C#. Para o projeto foi utilizado o [dotnetcore 3.1](https://dotnet.microsoft.com/download)

Clone ou faça download deste repositório e envie a implementação para [rafael@grupokyly.com.br](mailto:rafael@grupokyly.com.br?subject=Teste%20Developer%20Grupo%20Kyly). 

Pode enviar o link do seu próprio repositório (Deixe o repositório público) ou o arquivo compactado com a implementação.
