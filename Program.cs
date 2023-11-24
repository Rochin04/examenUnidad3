namespace Examen_Unidad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listaenlazada listaenlazada= new Listaenlazada();
            Console.WriteLine("ingresa la cantidad de registros");
            int cantRegistros = int.Parse(Console.ReadLine());
            for(int i = 0; i < cantRegistros; i++)
            {
                Console.WriteLine($"/////{i}/////");
                Console.WriteLine("Ingresa el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad");
                int edad = int.Parse(Console.ReadLine());
                Persona persona = new Persona(nombre, edad);
                listaenlazada.AgregarFinlaPersona(persona);
                listaenlazada.Mostrar();
                listaenlazada.Ordenar();
            }
        }
    }
}