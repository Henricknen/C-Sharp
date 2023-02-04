using System;

sealed class Veiculo {        // os membros de uma classe 'sealed' não pode ser herdada

}

class Carro: Veiculo {          // a Classe 'Carro' não herdará 'Veiculo'

}

class Classe_sealed {
    static void Main() {
        Carro c1 = new Carro();     // instançiando objeto da classe'Carro'
    }
}