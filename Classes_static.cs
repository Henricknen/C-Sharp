using System;

static public class Jogador {      // uma classe 'static' não pde ter construtor
    static public int energia;          // os menbros preçisam ser iniçiaçizaos com 'static'

    static public bool vivo;       // membros

    static public string nome;

     static public void iniciar(string n) {     // métofo 'iniçiar' envia um parâmetro 'n' para á variável 'nome'
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info() {     // método 'info' imprime os valores das variáveis
        Console.WriteLine("O nome é: {0}", nome);
        Console.WriteLine("O energia é: {0}", energia);
        Console.WriteLine("O estado é: {0}\n", vivo);
    }
}

class Inimigo {     // classe 'Inimigo' não é estatica
    static public bool alerta;

    public string nome;     // propriedades

    public Inimigo(string n) {      // construtor 'Inimigo' recebendo um a string
        alerta = false;
        nome = n;
    }

    public void info() {     // método imprime as informações de 'Inimigo'
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("---------------------");
    }
}

class Classes_static {
    static void Main() {
        
        Jogador.iniciar("L.H.S.F.");
        Jogador.info();      // acessando a propria classe 'Jogador' se tem o acesso dos elementos

        Inimigo i1 = new Inimigo("mal");       // instançiando 'Inimigos'
        Inimigo i2 = new Inimigo("ruim");
        Inimigo i3 = new Inimigo("muito mal");

        Inimigo.alerta = true;      // acessando o alerta da classe Inimigo e alterando o seu estado prara 'true'

        i1.info();
        i2.info();      // chamando método 'info'
        i3.info();
    }
}