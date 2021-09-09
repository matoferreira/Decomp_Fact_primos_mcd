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


            do
            {
                 //Tomamos al numero menor y lo guardamos en el resultado
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


            //Empieza descomp. factorial en números primos
            //Nos falta imprimir en pantalla la descomposición factorial en numeros primos
            //Declaro una variable x = 2, primer numero primo
            int x = 2;

            Console.WriteLine($"La descomposición en números primos de {num1} es: ");
            while (num1 != 1) //Mi condición es que el número no puede ser 1, ya que no se lo puede descomponer
            {
                if (num1 % x == 0) //si el resto de la división entre el num1 y x es 0, agrego ese divisor a la lista, si no, sumo 1 a x y vuelvo a iterar
                {
                    Console.Write(x + " x ");
                    num1 = num1 / x;
                }
                else
                {
                    x = x+1;
                }
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("\b \b");

            int y = 2;
            Console.WriteLine("\n");
            Console.WriteLine($"La descomposición en números primos de {num2} es: ");
            while (num2 != 1)
            {
                if (num2 % y == 0)
                {
                    Console.Write(y + " x ");
                    num2 = num2 / y;
                }
                else
                {
                    y = y+1;
                }
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("\b \b");

        }
    }
}
