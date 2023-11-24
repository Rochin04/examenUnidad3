using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    class Persona
    {
        //private string nombre
        //private int edad
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
