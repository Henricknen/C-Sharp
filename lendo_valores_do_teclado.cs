using System;

class leituraDoTeclado {
    static void Main() {
        int v1, v2, soma;
        string nome;

        Console.WriteLine("Digite seu nome aqui: ");
        nome = Console.ReadLine();      // faz o armazenamento do nome digitado na variavel nome
        Console.WriteLine("Nome digitado: {0}", nome);      // imprimindo o que contem na varivel nome

        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());      // fazendo a conversão do tipo string para int
        Console.WriteLine("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());       // fazendo a conversão do tipo string para int
        soma = v1 + v2;

    Console.WriteLine("A soma entre o primeiro valor: {0} e do segundo: {1} é: {2}", v1, v2, soma);
    }

}