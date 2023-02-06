using System;
struct Carro {      // estrutura 'Carro'
    public string modelo;
    public string cor;


    public void info() {        // classe que retornará os valores, informações dos 'membros'
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
        Console.WriteLine("---------------------");
    }
}
class Array_de_struct {
    static void Main() {

        Carro[] carros = new Carro[4];       // criando um 'array' do tipo 'Carro'

        carros[0].modelo = "HRV" ;      // atribuindo valores para carros
        carros[0].cor = "Preto";

        carros[1].modelo = "Golf";
        carros[1].cor = "Vermelho";

        carros[2].modelo = "Astra";
        carros[2].cor = "Branco";

        carros[3].modelo = "Porche";
        carros[3].cor = "Azul";

        for(int i = 0; i < carros.Length; i++) {        // loop
            carros[i].info();     // chamando o método 'info' de acordo com o indiçe do loop
        }
    }
}