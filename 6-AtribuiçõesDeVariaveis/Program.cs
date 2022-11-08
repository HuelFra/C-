using System; //O bloco using provê ao desenvolvedor a habilidade de se criar um bloco de código
              //isolado dentro de um determinado programa.

class Programa
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Executando projeto 6 - Atribuição de Variáveis");
        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();//Lê o que deve ser feito, no caso,não tem nada para fazer.                      
    }
}
