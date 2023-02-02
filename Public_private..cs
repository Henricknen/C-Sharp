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

    public void setEnergia(int e) {     // método que vai filtrar o valor que está sendo atribuido na energia
        if(e < 0) {     // valor negativo
            if(energia +e < 0) {
                energia = 0;        // se valor for menor que 0 valor será dado um print do valor minimo da energia
            } else {
                energia += e;
            }
        } else if(e > 0) {
            if(energia +e > 100) {
               energia = 100;        // valor maximo da energia
            } else {
                energia += e;
            }
        }
    }
}

class public_private {
    static void Main() {
        Jogador j1 = new Jogador("LHSF");      // instançiando objeto da classe 'Jogador

        j1.setEnergia(-150);     // passando valor para método public 'setEnergia'

        Console.WriteLine("Nome...: {0}", j1.getNome());     // ultiizando o método 'getNome' para obter o nome
        Console.WriteLine("Energia: {0}", j1.getEnergia());     // ultiizando o método 'getEnergia' para obter a energia 
    }
}
