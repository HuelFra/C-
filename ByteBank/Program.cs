using ByteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;



Console.WriteLine("Saldo da conta do André é de R$ " + contaDoAndre.saldo);
contaDoAndre.Depositar(100); //Simulando depósitos
Console.WriteLine("Saldo da conta do André pós-deposito é de R$ " + contaDoAndre.saldo);
Console.WriteLine();

//Criando o objeto do tipo ContaCorrente
ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da Conta: {conta.titular}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.numero_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

Console.ReadKey();
