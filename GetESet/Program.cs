// private = as variáveis só podem ser acessadas dentro da mesma classe (uma classe externa não tem acesso a ela).
// Para acessar as variáveis private, usamos os métodos Get e Set.
// Get = Obter e Set = Definir

using GetESet.Pessoas;
using System;
using System.Runtime.CompilerServices;

namespace NovasPessoas
{
    class Pessoa
    {
        static void Main(string[] args)
        {
            Pessoas meuObjeto = new Pessoas();
            meuObjeto.Nome = "João";
            Console.WriteLine("Nome: " + meuObjeto.Nome);
        }
    }
}

