using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoadicional;

        if (acompanhado == true) //Comparando os valores (==)
        {
            textoadicional = "João está acompanhado";//Atribuindo valores (=)
        }
        else
        {
            textoadicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoadicional);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
            Console.WriteLine();
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
