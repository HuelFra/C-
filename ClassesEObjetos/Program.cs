using System;
using System.Security.Cryptography.X509Certificates;
using ClassesEObjetos.Carros;

namespace carros
{
    class car
    {
        static void Main(string[] args)
        {
            Carros meuObjeto = new Carros();
            Console.WriteLine("A cor do carro é: " + meuObjeto.cor);
            Console.WriteLine("Atenção!! A velocidade máxima do carro é: " + meuObjeto.velocidademax +" km/h");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            Carros Ford = new Carros();
            Ford.modelo = "Mustang";
            Ford.cor = "azul";
            Ford.ano = 1969;

            Carros Opel = new Carros();
            Opel.modelo = "Astra";
            Opel.cor = "Prata";
            Opel.ano = 2022;

            Console.WriteLine("O modelo do carro é: " + Ford.modelo);
            Console.WriteLine("A cor do carro é: " + Ford.cor);
            Console.WriteLine("O ano do carro é: " + Ford.ano);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("O modelo do carro é: " + Opel.modelo);
            Console.WriteLine("A cor do carro é: " + Opel.cor);
            Console.WriteLine("O ano do carro é: " + Opel.ano);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            Carros meuObjeto1 = new Carros();
            Console.WriteLine("A cor do carro novo é: " + meuObjeto1.cor);
            Console.WriteLine("A velocidade máxima do carro é: " + meuObjeto1.velocidademax + " km/h");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            meuObjeto.aceleracaoTotal(); //Chamando o método

            Carros Uno = new Carros(); //Criando um objeto vinculado a classe Carros
            Console.WriteLine(Uno.modelo);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            //Um Construtor pode receber parãmetros que são usados para inicializar os campos.
            //Criando um construtor com parâmetro
            Carros Volkswagen = new Carros("Palio", "Prata", 2021);
            Console.WriteLine("A cor do carro é: " + Volkswagen.cor + "." + " " + "O ano do carro é: " + Volkswagen.ano + "." + " " + "O modelo do carro é: " + Volkswagen.modelo + ".");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
