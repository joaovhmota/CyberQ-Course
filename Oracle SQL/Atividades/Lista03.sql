CREATE TABLE alunos (
	nome VARCHAR2(40),
	turma VARCHAR2(20),
	nota1 NUMBER,
	nota2 NUMBER,
	nota3 NUMBER,
	turno VARCHAR2(10)
);

INSERT INTO alunos VALUES ('Ana Paula', '7A', 5, 8, 7, 'Vespertino');
INSERT INTO alunos VALUES ('Caio Neves', '8B', 3, 4, 2, 'Matutino');
INSERT INTO alunos VALUES ('Isabella Fontana', '7C', 9, 8.5, 9, 'Vespertino');
INSERT INTO alunos VALUES ('Daniel Luz', '8A', 2, 5, 4, 'Vespertino');
INSERT INTO alunos VALUES ('Gabriela Braga', '8A', 10, 10, 10, 'Vespertino');
INSERT INTO alunos VALUES ('Ellen Souza', '7A', 5, 8, 7, 'Matutino');
INSERT INTO alunos VALUES ('Luciana Biltz', '8B', 9.5, 10, 10, 'Vespertino');
INSERT INTO alunos VALUES ('Paulo Almeida', '8A', 10, 10, 10, 'Matutino');
INSERT INTO alunos VALUES ('Carla Malta', '7B', 3, 7, 9, 'Matutino');
INSERT INTO alunos VALUES ('Diogo Andrade', '8C', 10, 9, 10, 'Vespertino');
INSERT INTO alunos VALUES ('M�nica Mota', '8A', 7, 7, 8, 'Vespertino');
INSERT INTO alunos VALUES ('Juliana Lima', '8C', 9, 8, 2, 'Vespertino');
INSERT INTO alunos VALUES ('Marcelo Matos', '7A', 9, 10, 5, 'Matutino');

SELECT * FROM alunos;

SELECT	nome, 
		((nota1 + nota2 + nota3) / 3) as media ,
		(CASE WHEN ((nota1 + nota2 + nota3) / 3) >= 7 THEN 'Aprovado' ELSE 'Reprovado' END) as situação
FROM alunos;

SELECT COUNT(*), turno FROM alunos GROUP BY turno;

SELECT COUNT(*), turma FROM alunos GROUP BY turma;

SELECT nome, ((nota1 + nota2 + nota3) / 3) as media FROM aluno WHERE ((nota1 + nota2 + nota3) / 3) >= 7;

SELECT COUNT(*) FROM alunos WHERE ((nota1 + nota2 + nota3) / 3) < 7 AND turno = 'Vespertino';

SELECT * FROM alunos WHERE ((nota1 + nota2 + nota3) / 3) = (SELECT MAX(((nota1 + nota2 + nota3) / 3)) FROM alunos);

SELECT AVG((nota1 + nota2 + nota3) / 3) as media, turma FROM alunos GROUP BY turma;

UPDATE alunos SET turma = '8A' WHERE turma = '8B';

DROP TABLE alunos;
