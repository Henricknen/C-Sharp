using System;
class Loop_do_while {
    static void Main() {

        int num = 5;
        do {        // 'do while' executa os comandos primeiro e depois testa
            Console.WriteLine("Codificando C#");
        } while(num < 5);

        string senha = "123";
        string senhauser;
        int tentativas = 0;

        do{
            Console.Clear();        // limpa a tela
            Console.WriteLine("Digite a senha");
            senhauser = Console.ReadLine();
            tentativas++;
        } while(senha != senhauser);

        Console.Clear();
        Console.WriteLine("Senha correta, tentativas:{0}", tentativas);
    }
}