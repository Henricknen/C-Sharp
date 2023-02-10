using System;
using System.Collections.Generic;       // biblioteca 'Generic'

class Colecao_List {
    static void Main() {

        List<string> carros = new List<string>();     // criação de array 'dinamico'
        List<string> carros2 = new List<string>();

        carros.Add("Golf");     // método 'Add' adiçiona elementos
        carros.Add("Gol");
        carros.Add("Vectra");
        carros.Add("Palio");

        carros2.AddRange(carros);        // método 'AddRange' adiçiona uma sequencia, serie de eementos

        // carros.Clear();      // 'Clear' apaga elementos
        if(carros.Constains("Gol")) {       // método 'Constains' retorna true ou false
            Console.WriteLine("Esta na lista");
        } else {
            Console.WriteLine("Não encontrado");
        }

        foreach(string c in carros2) {      
            Console.WriteLine("Carro: {0}", c);
        }

    }
}