
using Fase2_Aula12_Atividade;

Console.WriteLine("Hello, World!");

Produto produto1 = new Produto();



produto1.nome = "Salgado";
produto1.descricao = "Frango com catupiry";
produto1.quantidade = 1;
produto1.preco = 4.00;
produto1.status = true;
produto1.desativa();
produto1.mostra();


Produto produto2 = new Produto();


produto2.nome = "Bolo";
produto2.descricao = "Leite Ninho";
produto2.quantidade = 0;
produto2.preco = 12.00;
produto2.status = true;
produto2.desativa();
produto2.mostra();



Produto produto3 = new Produto();


produto3.nome = "Brigadeiro";
produto3.descricao = "Chocolate";
produto3.quantidade = 5;
produto3.preco = 2.00;
produto3.status = true;

produto3.mostra();













Console.ReadKey();
