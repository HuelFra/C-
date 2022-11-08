//Resolução od Exercício proposto 
using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 12 - Investimento a Longo Prazo");
        Console.WriteLine();

        double fatorRendimento = 1.005;
        double investimento = 1000;

       for (int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <=12; mes ++)
            {
                investimento *= fatorRendimento;
            }
           fatorRendimento = fatorRendimento + 0.001;
        }
        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

       

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}
