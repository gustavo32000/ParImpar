using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
         int numero;

           Console.WriteLine ("Digite um número: ");
               numero = int.Parse(Console.ReadLine());

         if (numero % 2 == 0) {
           Console.WriteLine ("O número digitado é par!");
                Console.Beep(3000,2000); 
             }
        
         else {
           Console.WriteLine ("O número digitado é impar!");
                Console.Beep(500,2000);
             }
        }  

        
    }
}
