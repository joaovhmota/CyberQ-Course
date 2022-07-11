CREATE TABLE colaboradores (
	nome VARCHAR2(30),
    cargo VARCHAR(40),
    salario NUMBER
);

INSERT ALL
	INTO colaboradores VALUES ('Alice', 'Engenheira de software', 6000)
    INTO colaboradores VALUES ('Dênis', 'Desenvolvedor Java', 4000)
    INTO colaboradores VALUES ('Gabriela', 'Analista de sistemas', 5000)
    INTO colaboradores VALUES ('Henrique', 'Desenvolvedor C#', 3500)
    INTO colaboradores VALUES ('Lucas', 'Administrador de Banco de dados', 8000)
SELECT * FROM dual;

SELECT * FROM colaboradores;

DECLARE
	linhas NUMBER;
BEGIN
	UPDATE colaboradores SET salario = salario + 500;
	
    IF SQL%NOTFOUND THEN
    	dbms_output.put_line('Não há colaboradores registrados');
    ELSIF SQL%FOUND THEN
    	linhas := SQL%ROWCOUNT;
        dbms_output.put_line(linhas || ' colaboradores com salário alterado');
    END IF;
END;

DROP TABLE colaboradores;
