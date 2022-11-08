//Resolução od Exercício proposto - Desafio Alíquota
using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 11 - Calcula Poupança");
        Console.WriteLine();

        double investimento = 1000.0;


        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }

        /*
         while(mes <=12)
         {
             investimento = investimento + investimento * 0.005;
             Console.WriteLine("No mes " + mes + " você tem R$ " + investimento);

             mes += 1;
         }
        */

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
     
    }
}
