//Resolução do Exercício proposto - LacoDeRepeticaoWhile
using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o exercício proposto (Adaptado) - LacoDeRepeticaoWhile");
        Console.WriteLine("Soma números inteiros de 1 a 18");
        Console.WriteLine();

        int Soma = 0;
        int i = 0;

        while(i < 18)
        {
            Soma++;
            i++;
            Console.WriteLine("O valor da Soma é:" + Soma + " e o valor de i é:" + i);
        }
        
        Console.WriteLine();
    
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}
