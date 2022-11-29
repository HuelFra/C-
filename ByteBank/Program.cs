using ByteBank.Titular;
using ByteBank.ContaCorrente;
using System;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André é de R$ " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria é de R$ " + contaDaMaria.saldo);

////Realizando a transferência
//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.conta);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine();

//ContaCorrente ExibirInformacoesGerais = new ContaCorrente();
//ExibirInformacoesGerais.titular = "Joaquim Teste";
//ExibirInformacoesGerais.conta = "1010-22";
//ExibirInformacoesGerais.numero_agencia = 22;

//Console.WriteLine("Numero_agencia: " + ExibirInformacoesGerais.numero_agencia);
//Console.WriteLine("Conta: " + ExibirInformacoesGerais.conta);
//Console.WriteLine("titular: " + ExibirInformacoesGerais.titular);
//Console.WriteLine("Saldo: " + ExibirInformacoesGerais.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Nº da Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("Número da Agência: " + conta.numero_agencia);

//Cliente cliente = new Cliente(); //Criando dados de um cliente 
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente; //Criando a referência para o objeto tipo cliente
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Número da Agência = " + conta.numero_agencia);
//Console.WriteLine("Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular.nome = "José Souza";
//conta2.titular.cpf = "987654321";
//conta2.titular.profissao = "Tester";
//conta2.conta = "999-X";
//conta2.numero_agencia = 20;
//conta2.saldo = 500;

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-X";
//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1011-X");
//conta4.SetSaldo(500);
//conta4.titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.conta);

ContaCorrente conta5 = new ContaCorrente(234, "1234-X");
ContaCorrente conta6 = new ContaCorrente(432, "2314-X");
ContaCorrente conta7 = new ContaCorrente(332, "1111-X");
ContaCorrente conta8 = new ContaCorrente(765, "0984-X");
Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalContasCriadas);

Cliente cliente1 = new Cliente();
cliente1.nome = "Maria Fulana";
cliente1.profissao = "Administradora";
cliente1.cpf = "12345678-90";

Cliente cliente2 = new Cliente();
cliente2.nome = "José Cicrano";
cliente2.profissao = "Analista de Dados";
cliente2.cpf = "08765438-36";

Cliente cliente3 = new Cliente();
cliente3.nome = "Ana Beltrana";
cliente3.profissao = "Empresária";
cliente3.cpf = "432576549-17";

Console.WriteLine("Total de clientes: " + Cliente.TotalClientes);
