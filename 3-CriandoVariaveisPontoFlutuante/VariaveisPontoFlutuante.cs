using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante"); //Título

        double salario; //double tipo de variável que reconhece valores com vírgulas, porém se trabalha com valores int, devolve o valor int
        salario = 3000.15; //Usamos o . ao invés de ,

        Console.WriteLine(salario);

        double idade;
        idade = 7.0 / 5.0;
        Console.WriteLine(idade);

        Console.WriteLine("Nota de Alunos");
        double nota1;
        nota1 = 5.6;
        Console.WriteLine("Nota 1:" + nota1);

        double nota2;
        nota2 = 7.0;
        Console.WriteLine("Nota 2:" + nota2);

        double nota3;
        nota3 = 7.0;
        Console.WriteLine("Nota 3:" + nota3);

        double nota4;
        nota4 = 6.5;
        Console.WriteLine("Nota 4:" + nota4);

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
