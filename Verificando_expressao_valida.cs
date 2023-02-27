using System;
using System.Collections.Generic;

class Verificando_expressao_valida {
    static void Main(string[] args) {
        string expressao = "while (m < (n[8] + o)) { m = m + 1; }";
        if (VerificarExpressao(expressao)) {
            Console.WriteLine("Expressão válida!");
        } else {
            Console.WriteLine("Expressão inválida!");
        }
    }

    static bool VerificarExpressao(string expressao) {
        
        Dictionary<char, char> pares = new Dictionary<char, char>();        // criando um dicionário com os pares de caracteres a serem verificados
        pares.Add('(', ')');
        pares.Add('[', ']');
        pares.Add('{', '}');
        
        Stack<char> pilha = new Stack<char>();      // criando uma pilha para armazenar os caracteres de abertura
        // Percorre cada caractere da expressão
        foreach (char caractere in expressao) {
            
            if (pares.ContainsKey(caractere)) {     // se o caractere for um caractere de abertura, adiciona na pilha
                pilha.Push(caractere);
            }
            
            if (pares.ContainsValue(caractere)) {       // se o caractere for um caractere de fechamento, verifica se é correspondente
                
                if (pilha.Count == 0 || pares[pilha.Peek()] != caractere) {     // se a pilha estiver vazia ou o último caractere adicionado não for o correspondente, retorna falso
                    return false;
                }
                
                pilha.Pop();        // remove o último caractere adicionado da pilha
            }
        }
        
        return (pilha.Count == 0);      // se a pilha estiver vazia, a expressão é válida
    }
}
