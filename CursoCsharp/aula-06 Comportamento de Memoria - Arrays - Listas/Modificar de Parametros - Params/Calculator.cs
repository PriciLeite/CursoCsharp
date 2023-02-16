namespace CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Params
{
    internal class Calculator
    {
        /* Não é ideal por ser repetitivo:
         
            public static int Sum(int n1, int n2) {
                return n1 + n2;
            }
            public static int Sum(int n1, int n2, int n3) {
                 return n1 + n2 + n3;
            }
            public static int Sum(int n1, int n2, int n3, int n4) {
                return n1 + n2 + n3 + n4;
            }
          
         */




        // Criando uma classe e fazendo a solução com VETOR:
       /*
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
       */


        // Criando a Classe e fazendo a Solução com modificador params:
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;




        }
    
    
    
    
    }



}