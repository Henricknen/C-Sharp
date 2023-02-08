using System;

class Try_catch {
    static void Main() {

        int n1, n2, res;        // criação de variáveis do tipo 'int'
        res = n1 = n2 = 0;  // iniçializando todas variáveis de uma vez

        n1 = 10;
        n2 = 0;     // atribuindo valores as 'variáveis

        try {       // bloco 'try'é quem executa as operações
            res = n1 / n2;      // operação
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);        // se apresentar 'erro' não será apresentado na tela, pois ao executar o 'erro' é interrompida a operação
        } catch(Exception e) {       // caso haja algum erro na operação, o erro será tratado e entrará no bloco 'catch', 'Exception e' faz a interçiptação e emite a menssagem de erro
            Console.WriteLine("ERROR:{0}", e.Message);      // '.Message' mostra a menssagem do erro
            Console.WriteLine("Ex:{0}", e);     // 'e' mostra o tipo e a excessão espeçifica
        }

        
    }
}