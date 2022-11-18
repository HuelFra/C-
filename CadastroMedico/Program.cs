using CadastroMedico;

CadastrosMedico cadastroDaMaria = new CadastrosMedico();
cadastroDaMaria.nome = "Maria Beltrano";
cadastroDaMaria.idade = 52;
cadastroDaMaria.altura = 1.60;
cadastroDaMaria.peso = 60;
cadastroDaMaria.IMC = (cadastroDaMaria.peso / (cadastroDaMaria.altura * cadastroDaMaria.altura));


Console.WriteLine("Nome: " + cadastroDaMaria.nome);
Console.WriteLine("Idade: " + cadastroDaMaria.idade);
Console.WriteLine("Altura: " + cadastroDaMaria.altura);
Console.WriteLine("Peso: " + cadastroDaMaria.peso);
Console.WriteLine("IMC: " + cadastroDaMaria.IMC);
Console.WriteLine();

CadastrosMedico cadastroDoJoao = new CadastrosMedico();
cadastroDoJoao.nome = "João Fulano";
cadastroDoJoao.idade = 45;
cadastroDoJoao.altura = 1.64;
cadastroDoJoao.peso = 93;
cadastroDoJoao.IMC = (cadastroDoJoao.peso / (cadastroDoJoao.altura * cadastroDoJoao.altura));

Console.WriteLine("Nome: " + cadastroDoJoao.nome);
Console.WriteLine("Idade: " + cadastroDoJoao.idade);
Console.WriteLine("Altura: " + cadastroDoJoao.altura);
Console.WriteLine("Peso: " + cadastroDoJoao.peso);
Console.WriteLine("IMC: " + cadastroDoJoao.IMC);



