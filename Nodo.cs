using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    class Nodo
    {
        public Persona persona;
        public Nodo siguienteN;
        public Nodo(Persona persona1)
        {
            persona = persona1;
            siguienteN = null;
        }
    }
}
