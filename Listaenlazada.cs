using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    class Listaenlazada
    {
        private Nodo primero;
        public Listaenlazada()
        {
            primero = null;
        }
        public void AgregarPersona(Persona persona)
        {
            Nodo nodo = new Nodo(persona);
            nodo.siguienteN = primero;
            primero = nodo;
        }
        public void AgregarFinlaPersona(Persona persona1)
        {
            Nodo nodoF = new Nodo(persona1);
            //nodo.siguienteN = primero;
            //primero= nodo;
            if (primero == null)
            {
                primero = nodoF;
            }
            else
            {
                Nodo actualF = primero;
                while(actualF.siguienteN != null)
                {
                    actualF = actualF.siguienteN;
                }
                actualF.siguienteN = nodoF;
            }
        }
        public void Mostrar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                 Console.WriteLine($"Nombre {actual.persona.Nombre}, Edad {actual.persona.Edad}");
                 actual = actual.siguienteN;
            }
            
            //BuscarElemento(actual.persona.Nombre);
        }
        //public void BuscarElemento(string nombreBuscado)
        //{
        //    Nodo actualB = primero;
        //    while(actualB.siguienteN == nombreBuscado)
        //    {

        //    }
        //}
        //public void Ordenar(Nodo nodo, Persona persona)
        //{
        //    Nodo actual = primero;
        //    int uno = actual.persona.Edad;
        //    int dos = actual.siguienteN.persona.Edad;
        //    if (uno < dos)
        //    {
        //        Console.WriteLine($"Nombre {actual.persona.Nombre}, Edad {actual.persona.Edad}");
        //    }
        //}
    }
}
