using ByteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André é de R$ " + contaDoAndre.saldo);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria é de R$ " + contaDaMaria.saldo);

//Realizando a transferência
contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.titular = "Pedro Silva";
Console.WriteLine(contaDoPedro.titular);
Console.WriteLine(contaDoPedro.conta);
Console.WriteLine(contaDoPedro.numero_agencia);
Console.WriteLine(contaDoPedro.saldo);
Console.WriteLine();

ContaCorrente ExibirInformacoesGerais = new ContaCorrente();
ExibirInformacoesGerais.titular = "Joaquim Teste";
ExibirInformacoesGerais.conta = "1010-22";
ExibirInformacoesGerais.numero_agencia = 22;

Console.WriteLine("Numero_agencia: " + ExibirInformacoesGerais.numero_agencia);
Console.WriteLine("Conta: " + ExibirInformacoesGerais.conta);
Console.WriteLine("titular: " + ExibirInformacoesGerais.titular);
Console.WriteLine("Saldo: " + ExibirInformacoesGerais.saldo);
