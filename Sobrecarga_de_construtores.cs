using System;

public class Jogador {// criação de nova classe e uma boa prática iniçiar nomes das classes  com letras maiusculas
    public int energia;

    public bool vivo;       // propriedades

    public string nome;

    public Jogador() {// sobrecarga de construtor sem parâmetro
        energia = 100;
        vivo = true;
        nome = "Luis henque silva ferreira";
    }

    public Jogador(string n) {      // método 'construtor' com parâmetro 'string n'
        energia = 100;
        vivo = true;
        nome = n;       // atribuindo o valor passado à 'n' à variável 'nome'
    }

    public Jogador(string n, int e) {      // método 'construtor' com parâmetro 'n' nome e 'e' energia
        energia = e;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e, bool v) {      // método 'construtor' com parâmetro 'n' nome , 'e' energia e 'v' parâmetro boleano
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info() {     // método 'info' imprime os valores das variáveis
    Console.WriteLine("O nome é: {0}", nome);
    Console.WriteLine("O energia é: {0}", energia);
    Console.WriteLine("O estado é: {0}\n", vivo);
    }
}

class Sobrecarga_de_construtores {
    static void Main() {
        Jogador j1 = new Jogador();     // instanciação padrão objeto da classe 'Jogador'
        Jogador j2 = new Jogador("Luis");       // 'new' reserva um espaço na memória RAM para o objeto intançiado
        Jogador j3 = new Jogador("Henrique", 100);      // 'J3' recebe 'nome e energia'
        Jogador j4 = new Jogador("Siva", 80, true);          // 'J4' recebe 'nome, energia, e indica se está vivo
        Jogador j5 = new Jogador("Ferreira", 0, false);

        j1.info();      // fazenso imprenção das informações dos jogadores
        j2.info();
        j3.info();
        j4.info();
        j5.info();
    }
}