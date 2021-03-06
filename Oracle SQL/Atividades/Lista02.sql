CREATE TABLE produtos (
       nome    VARCHAR2(40),
       marca   VARCHAR2(40),
       valor   NUMBER,
       estoque NUMBER
);

TRUNCATE TABLE produtos;

INSERT INTO produtos VALUES ('Teclado', 'Microsoft', 220.00, 60);
INSERT INTO produtos VALUES ('Monitor 32', 'Samsung', 3700.00, 20);
INSERT INTO produtos VALUES ('Mouse', 'Logitech', 129.90, 45);
INSERT INTO produtos VALUES ('Impressora', 'Epson', 430.00, 15);
INSERT INTO produtos VALUES ('Mouse', 'Microsoft', 199.90, 50);
INSERT INTO produtos VALUES ('Monitor 27', 'LG', 1990.80, 30);
INSERT INTO produtos VALUES ('Cadeira Gamer', 'Multilaser', 1170.00, 20);
INSERT INTO produtos VALUES ('Teclado', 'Dell', 110.00, 50);
INSERT INTO produtos VALUES ('Mouse', 'HP', 80.00, 70);
INSERT INTO produtos VALUES ('Placa de v�deo - GeForce GTX 1660', 'ASUS', 2800.00, 10);
INSERT INTO produtos VALUES ('SSD de 256GB', 'Kingston', 400.00, 15);
INSERT INTO produtos VALUES ('Processador Core i5 - 10� gera��o', 'Intel', 1800.00, 10);
INSERT INTO produtos VALUES ('Mouse', 'Multilaser', 44.90, 70);
INSERT INTO produtos VALUES ('Monitor 23', 'Dell', 1080.00, 40);
INSERT INTO produtos VALUES ('Teclado', 'HP', 119.90, 25);

SELECT DISTINCT(marca) FROM produtos;

SELECT AVG(valor) AS MediaDosValores FROM produtos;

SELECT COUNT(*), marca FROM produtos GROUP BY marca;

SELECT nome, valor FROM produtos WHERE valor = (SELECT MAX(valor) FROM produtos);

SELECT * FROM produtos WHERE valor >= (SELECT AVG(valor) FROM produtos);

SELECT * FROM produtos WHERE estoque = (SELECT MAX(estoque) FROM produtos);

SELECT * FROM produtos WHERE valor BETWEEN 100 AND 500;

SELECT nome, marca, valor FROM produtos WHERE LOWER(nome) LIKE 'mouse' ORDER BY valor;

SELECT nome, LENGTH(nome) as TamanhoNome FROM produtos;

UPDATE produtos SET marca = 'Alienware' WHERE marca = 'Dell';

SELECT * FROM produtos;

DROP TABLE produtos;
