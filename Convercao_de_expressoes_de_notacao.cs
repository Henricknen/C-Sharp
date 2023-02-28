using System;
using System.Collections.Generic;       // 'System.Collections.Generic 'fornece classes para trabalhar com tipos de dados básicos e estruturas de dados genéricas

class Program {
    static int GetPrecedence(char op) {
        switch (op) {
            case '+':
            case '-':
                return 1;
            case '*':
                return 2;
            default:
                return 0;
        }
    }

    static string InfixToPostfix(string infix) {        // o método 'InfixToPostfix' é a função principal que converte uma expressão infixa em uma expressão pós-fixa
        Stack<char> stack = new Stack<char>();      // algoritmo de conversão é implementado usando uma pilha, representada pela classe Stack<char> 
        string postfix = "";        // 'postfix' é usada para acumular a string da expressão em notação pós-fixa

        foreach (char c in infix) {     // 'infix' é o método que percorre cada caractere da string 
            if (Char.IsLetter(c)) {
                
                postfix += c;       // se o caractere for uma letra, ele é um operando e é adicionado à string 'postfix'
            } else if (c == '(') {
                
                stack.Push(c);      // Se for um parêntese esquerdo, ele é empilhado na pilha 'stack'
            } else if (c == ')') {
                
                while (stack.Count > 0 && stack.Peek() != '(') {    // Se for um parêntese direito os operadores na pilha stack são desempilhados e adicionados à string 'postfix'
                    postfix += stack.Pop();
                }
                if (stack.Count > 0 && stack.Peek() == '(') {
                    stack.Pop();
                }
            } else {
                
                while (stack.Count > 0 && GetPrecedence(stack.Peek()) >= GetPrecedence(c)) {        // se for um operador  todos os operadores são desempilhados e adicionados à string 'postfix'
                    postfix += stack.Pop();
                }
                stack.Push(c);
            }
        }

        while (stack.Count > 0) {
            postfix += stack.Pop();
        }

        return postfix;
    }

    static void Main(string[] args) {
        string infix = "(A+B)*(C-D)";
        string postfix = InfixToPostfix(infix);
        Console.WriteLine(postfix);
    }
}
