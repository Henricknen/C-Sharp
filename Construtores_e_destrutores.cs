using System;

public class Jogador {// criação de nova classe e uma boa prática iniçiar nomes das classes  com letras maiusculas
    public int energia;

    public bool vivo;       // propriedades

    public string nome;

    public Jogador(string n) {      // método 'construtor' com parâmetro 'string n'
        energia = 100;
        vivo = true;
        nome = n;       // atribuindo o valor passado à 'n' à variável 'nome'
    }

    ~Jogador() {      // método 'destrutor' precisa ser anteçedido por um '~' e remove os objetos criados
        Console.WriteLine("Jogador {0} foi destruido", nome);
    }
}

class Classes_e_objetos {
    static void Main() {
        // Jogador j1 = new Jogador();     // instanciação padrão objeto da classe 'Jogador'
        string nome;
        Console.WriteLine("Digite outro nome: ");
        nome = Console.ReadLine();      // fazendo leitura de nome digitado e aramzenando n variável 'nome'
        Jogador j2 = new Jogador("Luis");       // 'new' reserva um espaço na memória RAM para o objeto intançiado
        Jogador j3 = new Jogador(nome);

        // j1.energia = 50;        // 'energia' por ser uma propeiedade pública é possível  fazer alteração
        // Console.WriteLine("Energia do Jogador2: {0}", j1.energia);
        Console.WriteLine("Primeiro nome: {0}", j2.nome);
        Console.WriteLine("Segundo nome: {0}", j3.nome);      // cada 'Jogador' funcionará de forma indepedente
    }
}