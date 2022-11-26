using Heranca;
using System;

class program
{
    static void Main(String[] args)
    {
        Carro meucarro = new Carro(); //Criando o objeto meucarro
        meucarro.buzinar(); //Chamando o método buzinar() 
        Console.WriteLine(meucarro.marca + " " + meucarro.modeloNome);
    }
}
