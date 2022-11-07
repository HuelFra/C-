using System; //O bloco using provê ao desenvolvedor a habilidade de se criar um bloco de código
              //isolado dentro de um determinado programa.
class Programa
{
    static void Main(string[] args) //o método Main() é o ponto onde o programa inicia sua execução.Ele deve estar dentro de uma classe ou struct e deve ser declarado com o modificador static.
    {
        Console.WriteLine("Olá mundo!");//WriteLine, grava a representação de texto dos objetos especificados
        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();//Quando for lido algo que o usuário fez, ele fecha a execução. Ele lê e não tem mais nada para fazer.                      
    }
}
