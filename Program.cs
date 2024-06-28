using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
     // do While

    int preço = 0;
        do
        {
            if (preço == 5)
                Console.WriteLine(" o preço é: " + preço);

            preço++;
        } while (preço < 10);
    }

}