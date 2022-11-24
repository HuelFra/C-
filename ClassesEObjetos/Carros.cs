//Modificadores de Acesso:
// public = O código é acessível para todas as classes.
// private = O código só é acessível dentro da mesma classe.
// protected = O código é acessível na mesma classe ou em uma classe herdada dessa classe.
// internal =  O código só é acessível dentro de seu próprio conjunto, não de outro conjunto.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEObjetos.Carros
{
     class Carros
    {
        public string cor = "verde";
        public int velocidademax = 200;
        public string modelo;
        public int ano;

        public void aceleracaoTotal() //método
        {
            Console.WriteLine("O carro está acima da velocidade");
        }

        //Criando o construtor da Classe
        public Carros()
        {
            modelo = "Onix"; //Carregando um valor inicial para o campo modelo
        }

        //Um Construtor pode receber parãmetros que são usados para inicializar os campos.
        //Criando um construtor com parâmetro
        public Carros(string modelonome,string cornome, int anonome)
        {
            modelo = modelonome;
            cor = cornome;
            ano = anonome;
        }

    }
}
