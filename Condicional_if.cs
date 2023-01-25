using System;
class Condicional_if {
    static void Main() {

        int n1, n2, n3, n4, res;
        res = n1 = n2 =n3 =n4 = 0;      // variáveis iniçializadas em 0
        string resultado = "Reprovado";

        Console.Write("Digite a primeira nota: ");      // lendo um valor do teclado e armazenando na variável 'n1'
        n1 = int.Parse(Console.ReadLine());         // e fazendo uma operação de cast com 'int.Parse' para converter a 'string' em 'int' para ser armazenada como 'int' na variável

        Console.Write("Digite a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terçeira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;         

        if(res >= 60) {
            resultado = "Aprovado";     // mudando o valor da variável caso a condição 'if' seja sastisfeita
        }

        Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);      // imprimindo a menssagem final
    }
}