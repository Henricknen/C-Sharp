using System;
class Lendo_valores_do_teclado {
    static void Main() {
        int v1, v2, soma;       // atribuição de variáveis
        string nome;


        Console.WriteLine("Digite seu nome aqui: ");
        nome = Console.ReadLine();      // faz o armazenamento do nome digitado na variavel nome
        Console.WriteLine("Nome digitado: {0}", nome);      // imprimindo o que contem na varivel nome

        Console.Write("Digite o primeiro valor: ");     // para escrever no console se usa os método 'Write' ou 'WriteLine'
        v1 = Convert.ToInt32(Console.ReadLine());      // para lêr o que está vindo do teclado se usa métodos 'Read' ou 'ReadLine' e 'Convert.ToInt32()' converte tipo 'string' em 'int'

        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());     
        soma = v1 + v2;     // variável 'soma' recebe soma de 'v1' com 'v2'
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);
    }
}