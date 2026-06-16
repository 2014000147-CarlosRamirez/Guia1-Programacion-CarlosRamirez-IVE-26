internal class Program
{
    private static void Main(string[] args)
    {
        int[] numerosEnteros = new int[8];

        int indice, numeroMayor, posicionMayor;
        numeroMayor = 0;
        posicionMayor = 0;

        for (indice = 1; indice <= 8; indice++)
        {
            Console.Write("Ingrese el número " + indice + ": ");
            numerosEnteros[indice - 1] = int.Parse(Console.ReadLine());

            if (indice == 1)
            {
                numeroMayor = numerosEnteros[indice - 1];
                posicionMayor = indice;
            }
            else
            {
                if (numerosEnteros[indice - 1] > numeroMayor)
                {
                    numeroMayor = numerosEnteros[indice - 1];
                    posicionMayor = indice;
                }
            }
        }

        Console.WriteLine("El número mayor es: " + numeroMayor);
        Console.WriteLine("Se encuentra en la posición: " + posicionMayor);
    }
}