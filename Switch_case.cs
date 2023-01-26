using System;

class Switch_case {
    static void Main() {

        int tempo = 0;      // variáveis
        char escolha;

        Console.WriteLine("Martinopolis-SP a São Paulo");
        Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Onibus ");

        escolha = char.Parse(Console.ReadLine());       // fazendo a leitura da 'escolha' e 'char.Parce' faz uma conversão typecast

        switch(escolha) {
            case 'a':      // 'case' teste
            case 'A':
                tempo = 50;
                break;      // com 'break' sai do switch e continua o programa
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:        // caso nenhuma das opções acima seja correspondente a variável cai no valor 'default'
                tempo = -1;
                break;
        }

        if(tempo < 0) {     // imprimido o resultado
            Console.WriteLine("Transporte indisponivel...");
        } else {
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }
    }
}