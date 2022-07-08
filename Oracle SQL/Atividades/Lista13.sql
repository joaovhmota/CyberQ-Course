/* PART 1 */
/* Create Tables *//
CREATE TABLE people (
	person_id INTEGER NOT NULL,
	person_name VARCHAR2(155) NOT NULL,
	person_birthday DATE NOT NULL,
	person_sign VARCHAR(15)
);

ALTER TABLE people ADD CONSTRAINT pk_people_id PRIMARY KEY(person_id);
CREATE SEQUENCE sq_people_auto_increment MINVALUE 1 START WITH 1 INCREMENT BY 1;


/* Triggers */
CREATE OR REPLACE TRIGGER tg_people_auto_increment BEFORE INSERT ON people 
FOR EACH ROW
BEGIN
	:new.person_id := sq_people_auto_increment.NEXTVAL;
END;


CREATE OR REPLACE TRIGGER tg_people_sign BEFORE INSERT ON people
FOR EACH ROW
DECLARE
	birthday_day NUMBER;
	birthday_month NUMBER;
	result_sign VARCHAR2(15);
BEGIN
	birthday_day := EXTRACT(DAY FROM :new.person_birthday);
	birthday_month := EXTRACT(MONTH FROM :new.person_birthday);
	result_sign := '<Unknown>';
    
    -- Março
	IF birthday_month = 3 THEN
		IF birthday_day <= 20 THEN
    		result_sign := 'Peixes';
        ELSE 
        	result_sign := 'Áries';
        END IF;
	END IF;
    
    -- Abril
    IF birthday_month = 4 THEN
		IF birthday_day <= 20 THEN
    		result_sign := 'Áries';
        ELSE 
        	result_sign := 'Touros';
        END IF;
	END IF;
	
    
    -- Maio
    IF birthday_month = 5 THEN
		IF birthday_day <= 20 THEN
    		result_sign := 'Touros';
        ELSE 
        	result_sign := 'Gêmeos';
        END IF;
	END IF;
    
    -- Junho
    IF birthday_month = 6 THEN
		IF birthday_day <= 20 THEN
    		result_sign := 'Gêmeos';
        ELSE 
        	result_sign := 'Câncer';
        END IF;
	END IF;
    
    -- Julho
    IF birthday_month = 7 THEN
		IF birthday_day <= 21 THEN
    		result_sign := 'Câncer';
        ELSE 
        	result_sign := 'Leão';
        END IF;
	END IF;
    
    -- Agosto
    IF birthday_month = 8 THEN
		IF birthday_day <= 22 THEN
    		result_sign := 'Leão';
        ELSE 
        	result_sign := 'Virgem';
        END IF;
	END IF;
    
    -- Setembro
    IF birthday_month = 9 THEN
		IF birthday_day <= 22 THEN
    		result_sign := 'Virgem';
        ELSE 
        	result_sign := 'Libra';
        END IF;
	END IF;
    
    -- Outubro
    IF birthday_month = 10 THEN
		IF birthday_day <= 22 THEN
    		result_sign := 'Libra';
        ELSE 
        	result_sign := 'Escorpião';
        END IF;
	END IF;
    
    -- Novembro
    IF birthday_month = 11 THEN
		IF birthday_day <= 21 THEN
    		result_sign := 'Escorpião';
        ELSE 
        	result_sign := 'Sagitário';
        END IF;
	END IF;
    
    -- Dezembro
    IF birthday_month = 12 THEN
		IF birthday_day <= 21 THEN
    		result_sign := 'Sagitário';
        ELSE 
        	result_sign := 'Capricórnio';
        END IF;
	END IF;
    
    -- Janeiro
    IF birthday_month = 1 THEN
		IF birthday_day <= 20 THEN
    		result_sign := 'Capricórnio';
        ELSE 
        	result_sign := 'Aquário';
        END IF;
	END IF;
    
    -- Fevereiro
    IF birthday_month = 2 THEN
		IF birthday_day <= 19 THEN
    		result_sign := 'Aquário';
        ELSE 
        	result_sign := 'Peixes';
        END IF;
	END IF;
    
	:new.person_sign := result_sign;
END;



/* Inserts */
INSERT INTO people (person_name, person_birthday) VALUES ('João', To_DATE('4/4/2005', 'dd/mm/yyyy'));
INSERT INTO people (person_name, person_birthday) VALUES ('Henrique', To_DATE('8/8/2005', 'dd/mm/yyyy'));
INSERT INTO people (person_name, person_birthday) VALUES ('Wesley', To_DATE('13/5/2003', 'dd/mm/yyyy'));
INSERT INTO people (person_name, person_birthday) VALUES ('Adegas', To_DATE('29/5/2003', 'dd/mm/yyyy'));
INSERT INTO people (person_name, person_birthday) VALUES ('William', To_DATE('27/1/2002', 'dd/mm/yyyy'));
INSERT INTO people (person_name, person_birthday) VALUES ('Samuca', To_DATE('13/9/2004', 'dd/mm/yyyy'));

/* Selects */
SELECT * FROM people;

/* DROPS */
DROP TRIGGER tg_people_auto_increment;
DROP TRIGGER tg_people_sign;
DROP SEQUENCE sq_people_auto_increment;
DROP TABLE people;

/* END PART 1 */


------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


/* PART 2 */
CREATE TABLE triangles (
	triangle_id INTEGER,
	side_a NUMBER,
	side_b NUMBER,
	side_c NUMBER,
	triangle_type VARCHAR2(15)
);
CREATE SEQUENCE sq_triangle_id MINVALUE 1 START WITH 1 INCREMENT BY 1;

CREATE TRIGGER tr_triangle_auto_increment
BEFORE INSERT ON triangles
FOR EACH ROW
BEGIN
	:new.triangle_id := sq_triangle_id.Nextval;
END;

CREATE TRIGGER tr_set_triangle_type
BEFORE INSERT ON triangles
FOR EACH ROW
DECLARE
	result_type VARCHAR2(15);
	side_a NUMBER;
	side_b NUMBER;
	side_c NUMBER;
BEGIN
	side_a := :new.side_a;
    side_b := :new.side_b;
    side_c := :new.side_c;
	
	IF side_a = side_b AND side_b = side_c THEN
    	result_type := 'Equilátero';
    ELSIF side_a <> side_b AND side_b <> side_c AND side_c <> side_a THEN
    	result_type := 'Escaleno';
   	ELSE
    	result_type := 'Isóceles';
    END IF;
    
    :new.triangle_type := result_type;
END;


INSERT INTO triangles (side_a, side_b, side_c) VALUES (10, 10, 10);
INSERT INTO triangles (side_a, side_b, side_c) VALUES (10, 10, 9);
INSERT INTO triangles (side_a, side_b, side_c) VALUES (3, 4, 5);

SELECT * FROM triangles;


DROP TABLE triangles;
DROP SEQUENCE sq_triangle_id;
DROP TRIGGER tr_triangle_auto_increment;
DROP TRIGGER tr_set_triangle_type;
/* END PART 2 */
