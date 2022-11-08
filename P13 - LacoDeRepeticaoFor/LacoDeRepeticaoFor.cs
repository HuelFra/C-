using System;

public class Programa
{
    public static void Main(string[] args)
     {
        Console.WriteLine("Executando o Exercício LacoDeRepeticaoFor");
		Console.WriteLine("Fatorial de um número");
        Console.WriteLine();

        int numero = 5;
		int fatorial = 1;

        for (int contador = 1; contador <= numero; contador++)
		{
			fatorial = fatorial * contador;
			Console.WriteLine("O fatorial de "+ numero + " é : " + fatorial);
		}
		
		Console.WriteLine();
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
