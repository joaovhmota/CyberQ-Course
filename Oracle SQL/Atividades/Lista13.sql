/* Create Tables */
CREATE TABLE people (
	id INTEGER NOT NULL,
	name VARCHAR2(155) NOT NULL,
	birthday DATE NOT NULL,
	sign VARCHAR(15)
);
ALTER TABLE people ADD CONSTRAINT pk_people_id PRIMARY KEY(id);
CREATE SEQUENCE sq_people_auto_increment MINVALUE 1 START WITH 1 INCREMENT BY 1;


/* Triggers */
CREATE TRIGGER tg_people_auto_increment BEFORE INSERT ON people 
FOR EACH ROW
BEGIN
	:new.id := sq_people_auto_increment.NEXTVAL;
END;

CREATE OR REPLACE TRIGGER tg_people_sign BEFORE INSERT ON people
FOR EACH ROW
DECLARE
	birthday_day INTEGER;
	birthday_month INTEGER;
	people_sign VARCHAR2(15);
BEGIN


	birthday_day := EXTRACT(DAY FROM :new.birthday);
	birthday_month := EXTRACT(MONTH FROM :new.birthday);
	
    -- Áries
    /*
	IF birthday_month = 3 THEN
		IF birthday_day >= 21 AND birthday_day <= 31 THEN people_sign := 'Áries' END IF;
    ELSIF birthday_month = 4 THEN
		IF birthday_day >= 1 AND birthday_day <= 20 THEN people_sign := 'Áries' END IF;
	END IF;
  */
	-- Touros
    IF birthday_month = 4 THEN
		--IF birthday_day >= 21 AND birthday_day <= 31 THEN people_sign := 'Touros' END IF;
        people_sign := 'Touros';
    ELSIF birthday_month = 5 THEN
		--IF birthday_day >= 1 AND birthday_day <= 20 THEN people_sign := 'Touros' END IF;
        people_sign := 'Touros';
	END IF;
/*
	-- Gêmeos
	IF birthday_month = 5 THEN
		IF birthday_day >= 21 AND birthday_day <= 31 THEN people_sign := 'Gêmeos' END IF;
    ELSIF birthday_month = 6 THEN
		IF birthday_day >= 1 AND birthday_day <= 20 THEN people_sign := 'Gêmeos' END IF;
	END IF;
    
    -- Câncer
	IF birthday_month = 6 THEN
		IF birthday_day >= 21 AND birthday_day <= 31 THEN people_sign := 'Câncer' END IF;
    ELSIF birthday_month = 7 THEN
		IF birthday_day >= 1 AND birthday_day <= 21 THEN people_sign := 'Câncer' END IF;
	END IF;
    
    -- Leão 
	IF birthday_month = 7 THEN
		IF birthday_day >= 22 AND birthday_day <= 31 THEN people_sign := 'Leão' END IF;
    ELSIF birthday_month = 8 THEN
		IF birthday_day >= 1 AND birthday_day <= 22 THEN people_sign := 'Leão' END IF;
	END IF;
    
    -- Virgem  
	IF birthday_month = 8 THEN
		IF birthday_day >= 23 AND birthday_day <= 31 THEN people_sign := 'Virgem' END IF;
    ELSIF birthday_month = 9 THEN
		IF birthday_day >= 1 AND birthday_day <= 22 THEN people_sign := 'Virgem' END IF;
	END IF; 
    
    -- Libra  
	IF birthday_month = 9 THEN
		IF birthday_day >= 23 AND birthday_day <= 31 THEN people_sign := 'Libra' END IF;
    ELSIF birthday_month = 10 THEN
		IF birthday_day >= 1 AND birthday_day <= 22 THEN people_sign := 'Libra' END IF;
	END IF; 
    
    -- Escorpião  
	IF birthday_month = 10 THEN
		IF birthday_day >= 23 AND birthday_day <= 31 THEN people_sign := 'Escorpião' END IF;
    ELSIF birthday_month = 11 THEN
		IF birthday_day >= 1 AND birthday_day <= 21 THEN people_sign := 'Escorpião' END IF;
	END IF; 
    
    -- Sagitário   
	IF birthday_month = 11 THEN
		IF birthday_day >= 22 AND birthday_day <= 31 THEN people_sign := 'Sagitário' END IF;
    ELSIF birthday_month = 12 THEN
		IF birthday_day >= 1 AND birthday_day <= 21 THEN people_sign := 'Sagitário' END IF;
	END IF; 
    
    -- Capricórnio   
	IF birthday_month = 12 THEN
		IF birthday_day >= 22 AND birthday_day <= 31 THEN people_sign := 'Capricórnio' END IF;
    ELSIF birthday_month = 1 THEN
		IF birthday_day >= 1 AND birthday_day <= 20 THEN people_sign := 'Capricórnio' END IF;
	END IF; 
    
    -- Aquário    
	IF birthday_month = 1 THEN
		IF birthday_day >= 21 AND birthday_day <= 31 THEN people_sign := 'Aquário' END IF;
    ELSIF birthday_month = 2 THEN
		IF birthday_day >= 1 AND birthday_day <= 19 THEN people_sign := 'Aquário' END IF;
	END IF; 
    
    -- Peixes     
	IF birthday_month = 2 THEN
		IF birthday_day >= 20 AND birthday_day <= 31 THEN people_sign := 'Peixes' END IF;
    ELSIF birthday_month = 3 THEN
		IF birthday_day >= 1 AND birthday_day <= 20 THEN people_sign := 'Peixes' END IF;
	END IF; 
    */
    :new.sign := people_sign;
    
    dbms_output.put_line('ae');
END;

/* Inserts */
INSERT INTO people (name, birthday) VALUES ('João', To_DATE('4/4/2005', 'dd/mm/yyyy'));

/* Selects */
SELECT * FROM people;

/* DROPS */
DROP TRIGGER tg_people_auto_increment;
DROP TRIGGER tg_people_sign;
DROP SEQUENCE sq_people_auto_increment;
DROP TABLE people;
