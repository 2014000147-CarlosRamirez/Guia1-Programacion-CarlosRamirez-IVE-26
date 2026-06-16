internal class Program
{
    private static void Main(string[] args)
    {
        int[] edadesPersonas = new int[7];

        int indice, cantidadMayoresEdad;
        cantidadMayoresEdad = 0;

        for (indice = 1; indice <= 7; indice++)
        {
            Console.Write("Ingrese la edad de la persona " + indice + ": ");
            edadesPersonas[indice - 1] = int.Parse(Console.ReadLine());

            if (edadesPersonas[indice - 1] >= 18)
            {
                cantidadMayoresEdad = cantidadMayoresEdad + 1;
            }
        }

        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresEdad);
    }
}
