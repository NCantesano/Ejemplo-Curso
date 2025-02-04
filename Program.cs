using System;

namespace Acumuladores_Contadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Acumuladorse y Acumuladores:
            int contador = 0 , edad1 = 20 , edad2 = 13, edad3 = 30;
            int acumulador = 0 , promedio;
            // contador = contador + 1,
            // ++
            // --
            // +=
            // -=
            if(edad1 > 18 ){
                contador ++;
                acumulador += edad1;
            }
            if (edad2 > 18){
                contador = contador +1;
                acumulador = acumulador + edad2;
            }
    
            if (edad3 > 18){
                contador = contador + 1;
                acumulador += edad3;
            }
            promedio = acumulador/contador;
            Console.WriteLine ("el promedio es: " + promedio);

        }
    }
}
