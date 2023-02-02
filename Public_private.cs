using System;

class Jogador {     // classe 'Jogador'
    private int energia;     // membros 'private' só pode ser usado por dentro da classe

    private string nome;          


    public Jogador(string nome) {        // construtor
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia() {       // métodos para que permite a alteração dos membros 'private'
        return energia;
    }

    public string getNome() {       // métodos para que permite a alteração dos membros 'private'
        return nome;
    }
}

class public_private {
    static void Main() {
        Jogador j1 = new Jogador("LHSF");      // instançiando objeto da classe 'Jogador

        Console.WriteLine("Nome...: {0}", j1.getNome());     // ultiizando o método 'getNome' para obter o nome
        Console.WriteLine("Energia: {0}", j1.getEnergia());     // ultiizando o método 'getEnergia' para obter a energia 
    }
}
