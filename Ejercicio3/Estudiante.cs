using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Estudiante
    {
        //Creacion de la propiedad nombre 
        private string Nombre { get; set; }
        //Creacion de la propiedad edad
        private int Edad { get; set; }
        //Creacion de la propiedad calificcion
        private float Calificacion { get; set; }
        //Creacion del constructor 
        public Estudiante(string Nombre1, int edad1, float Calificacion1 )
        {
            //Asigancion de valores
            this.Nombre=Nombre1;
            this.Edad=edad1;
            this.Calificacion= Calificacion1;
        }
        //Retorna el nombre 
        public String nombre()
        {
            return Nombre;
        }
        //Retorna la edad
        public int edad()
        {
            return Edad;
        }
        //retorna la calificacion
        public float calificacion()
        {
            return Calificacion;
        }
        //Muestra la informacion ingresada en el constructor 
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre del estudiante: " + Nombre);
            Console.WriteLine("Edad del estudiante: " + Edad);
            Console.WriteLine("Calificacion del estudiante: " + Calificacion);
        }
    }
}
