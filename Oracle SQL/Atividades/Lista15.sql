DROP TRIGGER tr_generate_student_situation;
DROP TRIGGER tr_generate_student_grade_c;
DROP TRIGGER tr_generate_student_grade_b;
DROP TRIGGER tr_generate_student_grade_a;
DROP TRIGGER tr_generate_class_id;
DROP TRIGGER tr_generate_student_id;
DROP SEQUENCE sq_classes;
DROP SEQUENCE sq_student;
DROP TABLE students;
DROP TABLE classes;

 /* Tables */
CREATE TABLE students (
	student_id INTEGER,
    student_name VARCHAR2(155),
	grade_a NUMBER,
	grade_b NUMBER,
	grade_c NUMBER,
	situation VARCHAR(15),
	actual_class INTEGER
);
CREATE TABLE classes (
	class_id INTEGER,
    class_name VARCHAR2(155),
	avarage NUMBER
);

/* Sequences */
CREATE SEQUENCE sq_student MINVALUE 1 START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE sq_classes MINVALUE 1 START WITH 1 INCREMENT BY 1;

/* Primary Keys */
ALTER TABLE students ADD CONSTRAINT pk_student PRIMARY KEY (student_id);
ALTER TABLE classes ADD CONSTRAINT pk_class PRIMARY KEY (class_id);

ALTER TABLE students ADD CONSTRAINT fk_class FOREIGN KEY (actual_class) REFERENCES classes (class_id);

/* Triggers */

-- Gerar Id aluno
CREATE OR REPLACE TRIGGER tr_generate_student_id BEFORE INSERT ON students FOR EACH ROW
BEGIN
	:new.student_id := sq_student.nextval;
END;

-- Gerar Id turma
CREATE OR REPLACE TRIGGER tr_generate_class_id BEFORE INSERT ON classes FOR EACH ROW
BEGIN
	:new.class_id := sq_classes.nextval;
END;

-- Gerar Nota 1 do Aluno
CREATE OR REPLACE TRIGGER tr_generate_student_grade_a BEFORE INSERT ON students FOR EACH ROW
BEGIN
	:new.grade_a := TRUNC(dbms_random.value(0, 10), 0);
END;

-- Gerar Nota 2 do Aluno
CREATE OR REPLACE TRIGGER tr_generate_student_grade_b BEFORE INSERT ON students FOR EACH ROW
FOLLOWS tr_generate_student_grade_a
BEGIN
	:new.grade_b := TRUNC(dbms_random.value(0, 10), 0);
END;

-- Gerar Nota 3 do Aluno
CREATE OR REPLACE TRIGGER tr_generate_student_grade_c BEFORE INSERT ON students FOR EACH ROW
FOLLOWS tr_generate_student_grade_b
BEGIN
	:new.grade_c := TRUNC(dbms_random.value(0, 10), 0);
END;

-- Gerar situação do aluno
CREATE OR REPLACE TRIGGER tr_generate_student_situation BEFORE INSERT ON students FOR EACH ROW
FOLLOWS tr_generate_student_grade_c
DECLARE
	student_avarage NUMBER;
BEGIN
    student_avarage := ((:new.grade_a + :new.grade_b + :new.grade_c) / 3);
    
	IF (student_avarage > 8) THEN 
    	:new.situation := 'Aprovado';
	ELSIF (student_avarage > 5) THEN 
    	:new.situation := 'Em exame';
	ELSE
    	:new.situation := 'Reprovado';
	END IF;
END;

/* Inserts */
TRUNCATE TABLE students;
TRUNCATE TABLE classes;

INSERT INTO classes (class_name) VALUES ('1A');
INSERT INTO classes (class_name) VALUES ('1B');
INSERT INTO classes (class_name) VALUES ('1C');
SELECT * FROM classes;

INSERT INTO students (student_name, actual_class) VALUES ('João', 1);
INSERT INTO students (student_name, actual_class) VALUES ('Henrique', 2);
INSERT INTO students (student_name, actual_class) VALUES ('Wesley', 3);
SELECT * FROM students;
