using System;

namespace CalcArea1 {        // 'namespace' surge com o intuito de controlar o escopo, é um método de organizção
    class Area {        
        public static float Quad(float bas, float alt) {       
            if(bas == 0 || alt == 0) {
                throw new Exception("Base ou Altura não pode ser igual a 0");       
            }
            return bas * alt;
        }
    }
}

namespace CalcArea2 {
    class Area {        // pode ser ter 'class' iguais desde que estetejam em 'namespace' diferentes
        public static float Quad(float bas, float alt) {       
            if(bas == 0 || alt == 0) {
                throw new Exception("Base ou Altura não pode ser igual a 0");       
            }
            return bas * alt;
        }
    }
}



class Try_catch {
    static void Main() {

        float area = 0;     

        try {   
            area = CalcArea1.Area.Quad(10F, 8F);      // na chamada da classe 'Area' é obrigatorio informar qual 'namespace' ela pertence
            Console.WriteLine("Area do quadrado: {0}", area);        
        } catch(Exception e) {       
            Console.WriteLine("ERROR:{0}", e.Message);      
        } finally {     
            Console.WriteLine("Fim do processo...");
        }        
    }
}