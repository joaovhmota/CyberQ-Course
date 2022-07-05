CREATE TABLE clientes (
       nome   VARCHAR2(20),
       cidade VARCHAR2(20),
       idade  NUMBER
);

TRUNCATE TABLE clientes;
INSERT INTO clientes VALUES ('Érica', 'Curitiba', 28);
INSERT INTO clientes VALUES ('Lucas', 'Blumenau', 16);
INSERT INTO clientes VALUES ('Larissa', 'Florianópolis', 36);
INSERT INTO clientes VALUES ('Murilo', 'Joinville', 23);
INSERT INTO clientes VALUES ('Cristiane', 'Blumenau', 31);
INSERT INTO clientes VALUES ('Robson', 'Joinville', 42);
INSERT INTO clientes VALUES ('Mariana', null, 37);
INSERT INTO clientes VALUES ('Jean', 'Blumenau', 43);
INSERT INTO clientes VALUES ('Luana', 'Pomerode', 19);
INSERT INTO clientes VALUES ('Cleber', 'Brusque', 34);
INSERT INTO clientes VALUES ('Hellen', 'Bluemanau', 28);
INSERT INTO clientes VALUES ('Paulo', 'Joinville', 44);
INSERT INTO clientes VALUES ('Alessandra', 'São Paulo', 28);
INSERT INTO clientes VALUES ('Dênis', 'Blumenau', 37);
INSERT INTO clientes VALUES ('Bianca', 'Campinas', 23);
INSERT INTO clientes VALUES ('Gabriel', 'São Paulo', 26);

SELECT * FROM clientes;

SELECT COUNT(*) AS Registros FROM clientes;

SELECT nome, idade FROM clientes WHERE idade = (SELECT MAX(idade) FROM clientes);

SELECT DISTINCT(cidade) FROM clientes WHERE cidade IS NOT NULL;

SELECT COUNT(*), cidade FROM clientes GROUP BY cidade;

SELECT nome, idade FROM clientes WHERE cidade IS NULL;

SELECT AVG(idade) AS MediaDasIdadades FROM clientes;

SELECT nome, idade FROM clientes WHERE idade = (SELECT MIN(idade) FROM clientes);

SELECT nome, idade FROM clientes WHERE idade >= (SELECT AVG(idade) FROM clientes);

SELECT nome, idade, cidade FROM clientes WHERE idade BETWEEN 20 AND 30;

SELECT nome, idade, cidade FROM clientes WHERE (cidade = 'Blumenau') AND (idade >= 30); 

SELECT nome, cidade FROM clientes WHERE cidade IN ('Curitiba', 'Florianópolis');

SELECT nome, idade FROM clientes WHERE UPPER(nome) LIKE '%L%';

SELECT nome FROM clientes ORDER BY nome;

UPDATE clientes SET cidade = 'Blumenau' WHERE cidade IS NULL;

DELETE FROM clientes WHERE cidade <> 'Blumenau';

DROP TABLE clientes;
