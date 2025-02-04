using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por 
            // pantalla si los mismos se encuentran ordenados de forma decreciente .


           int n1,n2,n3,n4;

           Console.WriteLine("ingrese un numero:");
           n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese un numero:");
           n2 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese un numero:");
           n3 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese un numero:");
           n4 = int.Parse(Console.ReadLine());

           if (n1 > n2 && n2 > n3 && n3 > n4)
              Console.WriteLine("ESTAN ORDENADOS EN FORMA DECRECIENTE:");
              else
              Console.WriteLine("NO ESTAN ORDENADOS:");

              
                
              
         
                
            


           
        }
    }
}
