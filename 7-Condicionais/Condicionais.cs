using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");

        int idadeJoao = 16;
        int acompanhante = 22;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
            Console.WriteLine();
        }
        else
        {
            if (quantidadePessoas > 0 && acompanhante >= 18)
            {
                Console.WriteLine("Seu(s) acompanhante(s) tem mais de 18 anos. Vocês podem entrar!");
            }
            else
            {
                Console.WriteLine("Só para maiores de 18 anos, você não pode entrar!");
                Console.WriteLine();
            }
        }


        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
