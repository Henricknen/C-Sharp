using System;

class Area {        // classe que calculará area de figura geométrica
    public static float Quad(float bas, float alt) {       // método que calucula área do 'quadradado'
        if(bas == 0 || alt == 0) {
            throw new Exception("Base ou Altura não pode ser igual a 0");       // 'throw' dispara um erro
        }
        return bas * alt;
    }
}

class Try_catch {
    static void Main() {

        float area = 0;     // variável

        try {       // bloco 'try'é quem executa as operações
            area = Area.Quad(10F, 8F);      // variável  'area' recebe valores para calculo
            Console.WriteLine("Area do quadrado: {0}", area);        // fazendo a impressão da area
        } catch(Exception e) {       // caso haja algum erro na operação, o erro será tratado e entrará no bloco 'catch', 'Exception e' faz a interçiptação e emite a menssagem de erro
            Console.WriteLine("ERROR:{0}", e.Message);      // '.Message' mostra a menssagem do erro
        } finally {     // o bloco 'finally' será executado 'independentemente se for disparado o 'throw new Exception' ou não, e tem finalidade de executar algo ao final de todo o 'try'
            Console.WriteLine("Fim do processo...");
        }        
    }
}