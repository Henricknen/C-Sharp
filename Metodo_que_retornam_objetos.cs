using System;

class Galinha {        // classe

    private string nomeGalinha;     // controle de nome
    private int numOvo;     // controle de de numero de ovos

    public Galinha(string nomeGalinha) {        // construtor
        this.nomeGalinha = nomeGalinha;     // quando uma nova 'Galinha' for criada ja terá um nome atribuido a ela
        numOvo = 0;     // iniçializado o controle de 'Ovo' da Galinha
    }

    public Ovo botar() {        // método que retorna o objeto "ovo'
        numOvo++;       // incrementando ovo da galinha e este incremento será passado para 'new Ovo'
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo {

    private string minhaGalinha;
    private int numOvo;
    public Ovo(int numOvo, string minhaGalinha) {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado:{0} - {1}", this.numOvo, this.minhaGalinha);
    }
}
class Metodo_que_retornam_objetos {
    static void Main() {

        Galinha g1 = new Galinha("Carijó");     // criação de nova 'Galinha' com nome
        Galinha g2 = new Galinha("Florentina");
        Galinha g3 = new Galinha("Cocoricó");

        g1.botar();     // a fazendo a impressão das galinhas e ovos botados
        g1.botar();
        g1.botar();

        g2.botar();
        g2.botar();

        g3.botar();
    }
}