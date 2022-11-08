using System; //O bloco using provê ao desenvolvedor a habilidade de se criar um bloco de código
              //isolado dentro de um determinado programa.

class Programa
{
    static void Main(string[] args) //o método Main() é o ponto onde o programa inicia sua execução.
                                    //Ele deve estar dentro de uma classe ou struct e deve ser declarado com o modificador static.
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis"); //WriteLine, mostra na tela o texto desejado.
        
        int idade; //declarando a variável idade, criando a variável e o seu tipo
        int CPF;
        int RG;
        int celular;

        CPF = 01234567890;
        Console.WriteLine("Número do CPF é:" + CPF);

        RG = 01234567890;
        Console.WriteLine("Número do RG é:" + RG);
        Console.WriteLine("Sabia que o número do RG está sendo emitido com o mesmo número do CPF. Isso para documentos emitidos atualmente!");

        idade = 27;//atribuindo valor para a variável
        Console.WriteLine("minha idade é:" + idade);//Aqui não usamos a "", porque queremos que ele mostre a variável e não um texto.

        celular = 998765432;
        Console.WriteLine("Contato:" + celular);
        Console.WriteLine("Procuro oportunidade para atuar como desenvolvedora de Software");

        idade = 27 - 5; //Modificando o valor da variável
        Console.WriteLine("minha idade é:" + idade);


        idade = (5 * 2) - 6;//CSharp segue a regra da matemática (1º resolve Potenciação ou Exponenciação, 2º Multiplicação ou Divisão e 3º Adição ou Subtração.
        Console.WriteLine("minha idade é:" + idade);


        idade = (5 - 2) * 3; //Se desejarmos que ele resolva primeiro uma subtração, antes da multiplicação, devemos usar o parênteses para isso.
        Console.Write("minha idade é:" + idade);//Imprime a informação, mas não faz a quebra de linha como em WriteLine


        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();//Lê o que deve ser feito, no caso,não tem nada para fazer.                      
    }
}
