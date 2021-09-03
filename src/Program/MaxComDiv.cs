/* Queda todo comentado para integrarlo en el program
using System;

namespace Program
{
    public class MaxComDiv
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


        //Aplicando teorema de euclides
        do
        {
          resultado = b;
          b = a%b;
          a = resultado;  
        } while (b!=0);

        //Mostramos como resultado el último resto no nulo
        Console.WriteLine($"El mcd entre {num1} y {num2} es: {resultado}");
        Console.ReadKey(true);
    }  
}
*/