DECLARE 
	TYPE estrutura_vetor IS VARRAY(3) OF VARCHAR2(30);
	cores estrutura_vetor;
	total INTEGER;

BEGIN
	cores := estrutura_vetor('Azul', 'Vermelho', 'Verde');
	total := cores.count;
	
	FOR i IN 1 .. total LOOP
    dbms_output.put_line(cores(i));
    END LOOP;
END;
