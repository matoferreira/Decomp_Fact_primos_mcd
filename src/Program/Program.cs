using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pido al usuario que ingrese los números
            Console.WriteLine("Ingrese el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Comparo los dos números y verifico cual es el mayor
            //al mayor le asigno la variable "a", al menor la variable "b"

            int a = Math.Max (num1, num2);
            int b = Math.Min (num1, num2);

            //Creo una variable resultado
            int resultado;


            //Aplicando algoritmo de Euclides
            do
            {
                 //Para hacer el algoritmo de euclides tomamos al numero menor y lo guardamos en el resultado
                 //seguidamente, hacemos a/b, si el resto = 0, es el MCD y se termina el bucle while
                 //si el resto es distinto de 0, ese resto lo guardamos en a
                 //ahora dividimos el dividendo anterior (b) por este resto y verificamos si el nuevo resto es = 0 o si continuamos el bucle
                 //hasta encontrar el MCD
                resultado = b;
                b = a%b;
                a = resultado;  
            } while (b!=0);

            //Mostramos como resultado el último resto no nulo
            Console.WriteLine($"El mcd entre {num1} y {num2} es: {resultado}");

            //Nos falta imprimir en pantalla la descomposición factorial en numeros primos

            
        }
    }
}
