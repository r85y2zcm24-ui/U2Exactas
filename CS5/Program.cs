using System;
// Espacio de nombre
namespace CS5
{

    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccions while 30092026
            // Sintaxis: while (condicion) {instrucciones}
            // inicializacion de variables
            // while(expresion)
            //{
            // Bloque de instrucciones
            // iterador;
            //}
            // Iterar: instruccion que me permite repetir
            // Ejemplo 1: Ciclo Ascendente (rango 1 - 3)
            int m = 1;  // inicializacion
            while (m <= 3) // condicion
            {
                 // bloque de instrucciones
                Console.WriteLine($" m: {m}");
                m += 1;// iterador
            }
            // ejercitacion
            // 1- Definir un ciclo para imprimir tu nombre 5 veces
            // Nota: Para la expresion utilizar el operador <.
            // a. Ciclo ASCENDENTE
            int n = 0; // inicializacion
            while (n < 5) // condicion
            {
                Console.WriteLine($"Nombre: Omar Torres");
                n += 1; // iterador
            }
            // B. Ciclo DESCENDENTE
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            // c. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int i = 3;
            while (i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
           
          }
          // d. Decrementos
          // 1. Definir un ciclo para imprimir "331" 8 veces
          // Nota: Para la solucion, define un ciclo descendente con decrementos de dos unidades
            int s = 15; 
            while (s >= 1)
            {
                Console.WriteLine($"Salón: 331");
                s -= 2;
            }
            
            // ACtividad 1: Ciclo infinito 
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la solucion, utilizar el operador de diferencia
            int x = 0;
            while (x != 1)
            {
                Console.WriteLine($"x: {x}");
                x += 1;
            }

            int y = 1;
            while (y == 1)
            {
                Console.WriteLine($"y: {y}");
            }
        }
    }
}
    

