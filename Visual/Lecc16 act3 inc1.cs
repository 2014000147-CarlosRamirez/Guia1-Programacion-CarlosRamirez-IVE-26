internal class Program
{
    private static void Main(string[] args)
    {
        int[] numerosEnteros = new int[15];

        int indice, comparador;
        bool existeRepetido;

        existeRepetido = false;

        for (indice = 1; indice <= 15; indice++)
        {
            Console.Write("Ingrese el número " + indice + ": ");
            numerosEnteros[indice - 1] = int.Parse(Console.ReadLine());
        }

        for (indice = 1; indice <= 14; indice++)
        {
            for (comparador = indice + 1; comparador <= 15; comparador++)
            {
                if (numerosEnteros[indice - 1] == numerosEnteros[comparador - 1])
                {
                    existeRepetido = true;
                }
            }
        }

        if (existeRepetido)
        {
            Console.WriteLine("Sí existe al menos un número repetido.");
        }
        else
        {
            Console.WriteLine("No existe ningún número repetido.");
        }
    }
}