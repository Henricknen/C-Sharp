using System;

public class Jogador {// criação de nova classe e uma boa prática iniçiar nomes das classes  com letras maiusculas
    public int energia = 100;       // propriedade 'int' energia
    public bool vivo = true;
}
class Classes_e_objetos {
    static void Main() {
        Jogador j1 = new Jogador();     // instançiando objeto da classe 'Jogador' 'new' reseva um espaço na memória RAM para o objeto intançiado
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;        // 'energia' por ser uma propeiedade pública é possível  fazer alteração
        Console.WriteLine("Energia do Jogador1: {0}", j1.energia);
        Console.WriteLine("Energia do Jogador2: {0}", j2.energia);      // cada 'Jogador' funcionará de forma indepedente
    }
}