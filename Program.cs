using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Condicionais:

        // O else e if é mais usado para quando você quer fazer uma condicional apenas uma vez ou poucas vezes com uma variavel
        Console.WriteLine("Digite um numero de 1 a 7: ");
        int diaSemana = int.Parse(Console.ReadLine());

        if (diaSemana == 1)
        {
            Console.WriteLine("Segunda");
        }
       else if (diaSemana == 2)
        {
            Console.WriteLine("terça");
        }
       else if (diaSemana == 3)
        {
            Console.WriteLine("quarta");
        }

        // Quando a variavel vai ser utilizada varias vezes, como nesse exemplo, é mais organizado e didatico usar o switch case:

        String nomeDiaSemana = "";

        switch (diaSemana)
        {
            case 1:
                nomeDiaSemana = "Segunda feira";
                break;
            case 2:
                nomeDiaSemana = "Terça feira";
                break;
            case 3:
                nomeDiaSemana = "Quarta feira";
                break;
            case 4:
                nomeDiaSemana = "Quinta feira";
                break;
            case 5:
                nomeDiaSemana = "Sexta feira";
                break;
        }
        Console.WriteLine(nomeDiaSemana);
    }

}