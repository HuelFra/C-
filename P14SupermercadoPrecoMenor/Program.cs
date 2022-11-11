using SupermercadoMenorPreco;

Produtos informacoes1 = new Produtos();
informacoes1.nome = "Sabão em Pó";
informacoes1.fabricante = "Minuano";
informacoes1.valor_unitario = 8.50;
informacoes1.quantidade_estoque = 4;
informacoes1.valor_compra = 8.50;

Produtos informacoes2 = new Produtos();
informacoes2.nome = "Desinfetante Pinho Sol Lavanda 1L";
informacoes2.fabricante = "Pinho Sol";
informacoes2.valor_unitario = 10.71;
informacoes2.quantidade_estoque = 2;
informacoes2.valor_compra = 10.71;

double total = (informacoes1.valor_compra + informacoes2.valor_compra);


Console.WriteLine("Os produtos comprados foram:"); 
Console.WriteLine (" - " + informacoes1.nome + " | Fabricante: " + informacoes1.fabricante + " | " + "R$ " + informacoes1.valor_unitario);
Console.WriteLine (" - " + informacoes2.nome + " | Fabricante: " + informacoes2.fabricante + " | " + "R$ " + informacoes2.valor_unitario);
Console.WriteLine();
Console.WriteLine("o valor da compra é " + total);

