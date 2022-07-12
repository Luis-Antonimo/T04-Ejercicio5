using System;

namespace T04Ejercicio5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba el día de la semana:");
            String dia = Console.ReadLine();
            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "martes":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "miercoles":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "jueves":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "viernes":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "sábado":
                    Console.WriteLine("Es fin de semana.");
                    break;
                case "domingo":
                    Console.WriteLine("Es fin de semana.");
                    break;
                //default se utiliza para indicar si ha habido un error 
                default:
                    Console.WriteLine("Lo que ha escrito no corresponde con un día de la semana.");
                    break;
            }
        }
    }
}