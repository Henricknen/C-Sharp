using System;
using System.Collections.Generic;        // fazendo a inclusão de biblioteca e ultilizando 'Generic' para trabalha com as coleções genéricas

class  Colecao_Dictionary {
     static void Main() {

        Dictionary <int, String> veiculos = new Dictionary <int, String>();     // criando um 'diçionario' do tipo 'Dictionary' ultilizando chave 'int' e valor 'string'

        veiculos.Add(10,"Triçiculo");       // adiçionando elementos ao 'Dictionary' com método 'Add'
        veiculos.Add(5,"Aviao");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Carro");
        veiculos.Add(15, "Moto");

        // veiculos.Clear();       // método 'Clear' limpa o 'Dictionary'

        veiculos.Remove(20);      // removendo um valor específico a coleção com método 'remove' e a chave do elemento que se quer remove

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);      // propriedade 'Count' irá retorna o tamanho do 'Dictionary'
        int chave = 20;
        if(veiculos.ContainsKey(chave)) {      // método 'ContainsKey' verifica se o diçionario contém o elemento com a chave espeçifiada
            Console.WriteLine("A chave: {0} esta na Coleção", chave);
        } else {
            Console.WriteLine("A chave: {0} não esta na Coleção", chave);
        }

        veiculos[10] = "Trator";        // mundando o valor da chave 10 

        string valor = "Trator";
        if(veiculos.ContainsValue(valor)) {      // método 'ContainsValue' verifica se tem um valor na 'coleção
            Console.WriteLine("O valor: {0} esta na Coleção", valor);
        } else {
            Console.WriteLine("O valor: {0} não esta na Coleção", valor);
        }

        foreach(KeyValuePair<int, string> v in veiculos) {      // 'foreach' ira ler e imprimir todos elementos do 'Dictionary', convertendo v para tipo 'KeyValuePair'
            Console.WriteLine(v.Value);       // imprimindo todos valores da coleção
        }

     }
}