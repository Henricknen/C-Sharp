using  System;
class Calculos {            // classe 'Calculos'
    public int v1;      // propriedades

    public int v2;

    public Calculos(int v1, int v2) {       // método que recebe dois valores
         this.v1 = v1;      // 'this' faz uma referência do objeto da classe 'Calculos'
         this.v2 = v2;
    }

    public int Somar() {        // método que retorna a soma
        return v1 + v2;
    }
}
class This {
    static void Main() {
        Calculos c = new Calculos(10, 2);       // declarando objeto 'Calculos'

        Console.WriteLine(c.Somar());
    }
}