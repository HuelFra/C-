using System;

class Programa
{
    static void Main(String[] args) 
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos"); //Título

        char letra = 'a'; //abreviação de caracter. Para o char, usamos aspas ''(simples)
        Console.WriteLine(letra);

        letra = (char)65; //entende o caracter como um número, para isso convertemos o número em char
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia "; //variável = frase, observe aspas duplas
        Console.WriteLine(primeiraFrase + 2022);//Aqui o + é usado para concatenar a frase

        string vazia = "";
        Console.WriteLine(vazia); //Podemos ter uma string vazia, mas não podemos ter um caracter vazio.

        
        string cursos = @"Cursos Disponíveis: 
- Go 
- C# 
- Phyton 
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}