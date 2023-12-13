using Ejercicio3;
using System;

class Program
{
    static void Main()
    {
        //Creacion del objeto estudiante e inicializacion con valores 
        Console.WriteLine("-------------------EJERCICIO 3--------------------");
        Estudiante estudiante1 = new Estudiante("Jeimy Morales", 21, 23.6f);
        Console.WriteLine("Nombre: "+ estudiante1.nombre());
        Console.WriteLine("Edad: " + estudiante1.edad());
        Console.WriteLine("Calificacion"+ estudiante1.calificacion());

        //Llamada a la funcion que nos muestra la informacion del estudnate 
        Console.WriteLine("-------------------EJERCICIO 4--------------------");
        estudiante1.MostrarInformacion();

        
        Console.WriteLine("-------------------EJERCICIO 5--------------------");
        //Creacion del objeto que ereda a estudiante 
        EstudianteGraduado graduado1 = new EstudianteGraduado("Juan Jose", 18, 19.5f,"Informatica");
        graduado1.MostrarInformacion();
        Console.WriteLine("Titulo: " + graduado1.Titulo());
    }
}