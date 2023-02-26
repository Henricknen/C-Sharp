 using System;

class Palavras_invertidas {
    static void Main() {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        string[] palavras = frase.Split(' ');       // método 'Split' para dividir a frase em um array de palavras, considerando o espaço como separador
        string fraseInvertida = "";     // variável 'fraseInvertida' para armazenar a frase invertida
        foreach (string palavra in palavras) {      //  'loop foreach' irá percorrer todas as palavras da frase
            string palavraInvertida = "";       //  variável 'palavraInvertida' armazenará a palavra invertida
            for (int i = palavra.Length - 1; i >= 0; i--) {
                palavraInvertida += palavra[i];
            }
            fraseInvertida += palavraInvertida + " ";
        }
        Console.WriteLine("Frase invertida: " + fraseInvertida.TrimEnd());      // método 'TrimEnd()' remove o espaço em branco no final da frase
    }
}
