using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class EstudianteGraduado:Estudiante
    {
        private string titulo;
        public EstudianteGraduado(string Nombre1, int edad1, float Calificacion1, string titulo) : base(Nombre1, edad1,Calificacion1)
        {
            this.titulo = titulo;
        }
        public string Titulo()
        {
            return titulo;
        }
    }
}
