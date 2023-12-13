using System;

class Program
{
    static void Main()
    {
        //creacion de la variable edad y su inicializacion
        int edad = 19;
        //Comparamos el valor de la edad con 18 para saber si es mayor de edad o no 
        if (edad >= 18) {
            //Imoresion del mensaje si es mayor de edad
            Console.WriteLine("La persona es mayor de Edad");
        }
        else
        {
            //impresion del mensaje si es menor de edad
            Console.WriteLine("La persona es menor de edad");
        }
    }
}