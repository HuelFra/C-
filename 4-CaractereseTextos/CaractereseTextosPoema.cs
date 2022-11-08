using System;

class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos"); //Título
        Console.WriteLine("Poema - Canção do Exílio - Gonçalves Dias");
        Console.WriteLine();    

        string estrofe1 = @"Minha terra tem palmeiras
Onde canta o Sabiá,
As aves, que aqui gorjeiam,
Não gorjeiam como lá.";

        char primeiraletra = 'N';
        char segundaletra = 'o';
        char terceiraletra = 's';

        string estrofe2 = @" céu tem mais estrelas,
Nossas várzeas têm mais flores,
Nossos bosques têm mais vida,
Nossa vida mais amores.";

        char quartaletra = (char)(69); //E
        char quintaletra = (char)(109);//m

        string estrofe3 = @" cismar, sozinho, à noite,
Mais prazer encontro eu lá;
Minha terra tem palmeiras,
Onde canta o Sabiá.";

        string estrofe4 = @"Minha terra tem primores,
Que tais não encontro eu cá;
Em cismar – sozinho, à noite –
Mais prazer encontro eu lá;
Minha terra tem palmeiras,
Onde canta o Sabiá.";

        char sextaletra = (char)(198); //ã

        string estrofe5 = @"permita Deus que eu morra,
Sem que eu volte para lá;
Sem que desfrute os primores
Que não encontro por cá;
Sem qu’inda aviste as palmeiras,
Onde canta o Sabiá.";

        Console.WriteLine(estrofe1);
        Console.WriteLine();
        Console.Write(primeiraletra);
        Console.Write(segundaletra);
        Console.Write(terceiraletra);
        Console.Write(terceiraletra);
        Console.Write(segundaletra);
        Console.WriteLine(estrofe2);
        Console.WriteLine();
        Console.Write(quartaletra); 
        Console.Write(quintaletra);
        Console.WriteLine(estrofe3);
        Console.WriteLine();
        Console.WriteLine(estrofe4);
        Console.WriteLine();
        Console.Write(primeiraletra);
        Console.Write(sextaletra);
        Console.Write(segundaletra);
        Console.WriteLine(estrofe5);
        Console.WriteLine();

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
