using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        bool valor = false;
        bool valor2 = Convert.ToBoolean(true);

        if (valor == true)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }

        if (valor2 == true)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }

}