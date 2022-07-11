DROP PROCEDURE removerPessoaViaEmail;
DROP PROCEDURE removerPessoaViaNome;
DROP PROCEDURE editarPessoa;
DROP PROCEDURE cadastrarPessoa;
DROP TRIGGER tr_gerar_id_cliente;
DROP SEQUENCE sq_cliente;
DROP TABLE clientes;

CREATE TABLE clientes (
	codigo INTEGER,
	nome VARCHAR2(155),
	email VARCHAR2(155)
);

CREATE SEQUENCE sq_cliente MINVALUE 1 START WITH 1 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER tr_gerar_id_cliente BEFORE INSERT ON clientes FOR EACH ROW
BEGIN
	:NEW.codigo := sq_cliente.nextval;
END;

CREATE OR REPLACE PROCEDURE cadastrarPessoa(nome_input VARCHAR2, email_input VARCHAR2) AS
quantidade_registros INTEGER;
quantidade_email INTEGER;
quantidade_arroba INTEGER;
BEGIN
	SELECT COUNT(*) INTO quantidade_registros FROM clientes WHERE nome_input = nome;
    SELECT COUNT(*) INTO quantidade_email  FROM clientes WHERE email_input = email;
    SELECT LENGTH(email_input) - LENGTH(REPLACE(email_input, '@', NULL)) INTO quantidade_arroba FROM dual;
    
    IF quantidade_registros <> 0 THEN
    	dbms_output.put_line('Já existe um registro com esse nome');
    ELSIF quantidade_email <> 0 THEN
    	dbms_output.put_line('Já existe um registro com esse email');
    ELSIF quantidade_arroba <> 1 THEN
    	dbms_output.put_line('Quantidade de arroba inválidas'); 
    ELSE 
    	IF nome_input IS NULL OR email_input IS NULL THEN
           dbms_output.put_line('Nome ou email estão vazios');
        ELSE 
        	INSERT INTO clientes (nome, email) VALUES (nome_input, email_input);
        END IF;
    END IF;
END;

CREATE OR REPLACE PROCEDURE editarPessoa(target VARCHAR2, novo_nome VARCHAR2, novo_email VARCHAR2) AS
BEGIN
	IF target IS NULL THEN
		dbms_output.put_line('Usuário nulo');
    ELSE
    	UPDATE clientes SET nome = novo_nome, email = novo_email WHERE nome = target;
    END IF;
END;

CREATE OR REPLACE PROCEDURE removerPessoaViaNome(target VARCHAR2) AS
BEGIN
	DELETE clientes WHERE nome = target;
END;


CREATE OR REPLACE PROCEDURE removerPessoaViaEmail(target VARCHAR2) AS
BEGIN
	DELETE clientes WHERE email = target;
END;

BEGIN cadastrarPessoa('João', 'joao@email.com'); END;
BEGIN cadastrarPessoa('João', 'joao@email.com'); END;
BEGIN cadastrarPessoa('Henrique', 'henrique'); END;
BEGIN cadastrarPessoa('Henrique', 'henrique@email.com'); END;
BEGIN cadastrarPessoa('Matheus', 'joao@email.com'); END;

BEGIN removerPessoaViaNome('João'); END;
BEGIN removerPessoaViaEmail('henrique@email.com'); END;
SELECT * FROM clientes;
