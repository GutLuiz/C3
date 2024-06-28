using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //While

        Console.WriteLine("Digite um numero positivo: ");
        int valor = int.Parse(Console.ReadLine());

        while (valor < 5)
        {
            Console.WriteLine(  "Valor é: " + valor);
            valor++;

        }
    }

}