CREATE TABLE people (
	person_name VARCHAR2(155),
	amount_consoants INTEGER,
	amount_vowels INTEGER
);

CREATE OR REPLACE PROCEDURE registerPerson(input_name VARCHAR2) AS
amount_consoants INTEGER;
amount_vowels INTEGER;
str_index INTEGER;
current_char CHAR;
BEGIN
	amount_consoants := 0;
    amount_vowels := 0;
    str_index := 1;
    
	WHILE str_index < LENGTH(input_name) + 1
    LOOP
    	SELECT SUBSTR(input_name, str_index, 1) INTO current_char FROM dual;
        dbms_output.put(current_char || ' ');
    	IF (UPPER(current_char) IN ('A', 'E', 'I', 'O', 'U')) THEN
        	amount_vowels := amount_vowels + 1;
        ELSE 
        	amount_consoants := amount_consoants + 1;
        END IF;
        str_index := str_index + 1;
    END LOOP;
    
    dbms_output.put_line('');
    dbms_output.put_line('Vogais: ' || amount_vowels);
    dbms_output.put_line('Consoantes: ' || amount_consoants);
    INSERT INTO people VALUES (input_name, amount_consoants, amount_vowels);
END;

BEGIN registerPerson('Joao'); END;
BEGIN registerPerson('Henrique'); END;
BEGIN registerPerson('William'); END;

SELECT * FROM people;
