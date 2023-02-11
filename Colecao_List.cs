using System;
using System.Collections.Generic;       // biblioteca 'Generic'

class Colecao_List {
    static void Main() {

        List<string> carros = new List<string>();     // criação de array 'dinamico'
        string[] carros2 = new string[10]; 

        carros.Add("Golf");     // método 'Add' adiçiona elementos
        carros.Add("Gol");
        carros.Add("Vectra");
        carros.Add("Palio");

        // carros2.AddRange(carros);        // método 'AddRange' adiçiona uma sequencia, serie de elementos adiçionando os elementos de 'crro' em 'carros2' com 'AddRange'

        // carros.Clear();      // 'Clear' apaga elementos
        if(carros.Constains("Gol")) {       // método 'Constains' verifica se tem um elemento na lista retorna true ou false
            Console.WriteLine("Esta na lista");
        } else {
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2, 2);     // copiando elemento para 'carro2'
        

        foreach(string c in carros2) {      
            Console.WriteLine("Carro: {0}", c);
        }

        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(c);        // 'IndexOf' retorna o indiçe do primeiro elemento que encontrar

        Console.WriteLine("Carro {0} esta na poisição {1}", ca, pos);

    }
}