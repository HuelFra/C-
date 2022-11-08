using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
    }
}
