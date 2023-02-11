using System;

class Fila {
    static void Main() {

        string[] vs = {"Carro", "Moto", "Navio", "Avião"};      // 'vs' array de string
        Queue<string>veiculos = new Queue<string>(vs);      // declaração da 'fila' ultilizando 'Queue'

        veiculos.Enqueue("Biçicleta");        // método 'Enqueue' adiçiona elementos no 'final' da fila
        veiculos.Enqueue("Patinete");
        veiculos.Enqueue("Patins");
        veiculos.Enqueue("Carrinho de mão");

        string v = "Trator";
        if(veiculos.Contains(v)) {      // se 'Contains' encontrar o que estiver declarado na variável 'v' será retornado true
            Console.WriteLine("Veiculo " + v + " encontrado");
        } else {
            Console.WriteLine("Veiculo " + v + " não está na fila");
        }
        Console.WriteLine("---------------------------------");


        // veiculos.Clear();       // 'Clear' limpa toda 'fila'
        

        Console.WriteLine("Primeiro veiculo será removido: " + veiculos.Dequeue());          // 'Dequeue' retorna o elemento e remove este elemento da 'fila'
        Console.WriteLine("veiculo atual do iniçio não será removido: " + veiculos.Peek());      // 'Peek' retorna o primeiro elemento mas não o remove da 'fila'
        Console.WriteLine("---------------------------------");


        // foreach(string veic in veiculos) {
        //     Console.WriteLine("Veiculos da fila: " + veic);
        // }
        // Console.WriteLine("---------------------------------");


        Console.WriteLine("O tamanho da fila é: " + veiculos.Count);        // imprimindo a quantidade de elementos da fila ultilizando 'Count'
        Console.WriteLine("---------------------------------");


        while(veiculos.Count > 0) {        // loop percorre toda 'fila' e remove todos elementos
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("---------------------------------");


        Console.WriteLine("O tamanho da fila é: " + veiculos.Count);

    }
}