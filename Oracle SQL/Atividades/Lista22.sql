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
	cursor_nome colaboradores.nome%TYPE;
    cursor_cargo colaboradores.cargo%TYPE;
    cursor_salario colaboradores.salario%TYPE;
	
    CURSOR cursor_cargos IS SELECT nome, cargo, salario FROM colaboradores;
BEGIN
	OPEN cursor_cargos;
    LOOP
    	FETCH cursor_cargos INTO cursor_nome, cursor_cargo, cursor_salario;
        EXIT WHEN cursor_cargos%NOTFOUND;
        
        dbms_output.put_line('Nome: ' || cursor_nome);
        dbms_output.put_line('Cargo: ' || cursor_cargo);
        dbms_output.put_line('Salário: ' || cursor_salario);
        dbms_output.put_line('');
    END LOOP;
    CLOSE cursor_cargos;
END;

DROP TABLE colaboradores;
