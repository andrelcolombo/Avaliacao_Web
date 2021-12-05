CREATE DATABASE BDprodutos;

CREATE TABLE Produtos
(
	IDproduto  int primary key,
	NomeProduto varchar(50) NOT NULL,
	Categoria varchar(20) NOT NULL,
	Quantidade int NOT NULL,
	preco decimal
)

SELECT IDproduto as 'ID Produto', NomeProduto as 'Nome do Produto', Categoria, Quantidade, preco as 'Preço' FROM Produtos