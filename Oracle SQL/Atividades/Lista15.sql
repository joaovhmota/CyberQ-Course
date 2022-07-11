DROP TRIGGER tr_set_class_average_2;
DROP TRIGGER tr_set_class_average;
DROP TRIGGER tr_generate_student_situation;
DROP TRIGGER tr_set_student_average;
DROP TRIGGER tr_generate_student_grade_c;
DROP TRIGGER tr_generate_student_grade_b;
DROP TRIGGER tr_generate_student_grade_a;
DROP TRIGGER tr_generate_class_id;
DROP TRIGGER tr_generate_student_id;
DROP SEQUENCE sq_classes;
DROP SEQUENCE sq_student;
DROP SEQUENCE sq_shift;
DROP TABLE students;
DROP TABLE classes;
DROP TABLE shifts;


/* Tables */
CREATE TABLE shifts (
	shift_id INTEGER,
	c VARCHAR2(155)
);
CREATE TABLE students (
	student_id INTEGER,
    student_name VARCHAR2(155),
	grade_a NUMBER,
	grade_b NUMBER,
	grade_c NUMBER,
	average NUMBER,
	situation VARCHAR(15),
	actual_class INTEGER
);
CREATE TABLE classes (
	class_id INTEGER,
    class_name VARCHAR2(155),
	average NUMBER,
	shift INTEGER
);

/* Sequences */
CREATE SEQUENCE sq_student MINVALUE 1 START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE sq_classes MINVALUE 1 START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE sq_shift MINVALUE 1 START WITH 1 INCREMENT BY 1;

/* Primary Keys */
ALTER TABLE students ADD CONSTRAINT pk_student PRIMARY KEY (student_id);
ALTER TABLE classes ADD CONSTRAINT pk_class PRIMARY KEY (class_id);
ALTER TABLE shifts ADD CONSTRAINT pk_shift PRIMARY KEY (shift_id);

ALTER TABLE students ADD CONSTRAINT fk_class FOREIGN KEY (actual_class) REFERENCES classes (class_id);
ALTER TABLE classes ADD CONSTRAINT fk_shift FOREIGN KEY (shift) REFERENCES shifts (shift_id);

/* Triggers */
-- Gerar Id turno
CREATE OR REPLACE TRIGGER tr_generate_shift_id BEFORE INSERT ON shifts FOR EACH ROW
BEGIN
	:new.shift_id := sq_shift.nextval;
END;

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

-- Gerar média do aluno 
CREATE OR REPLACE TRIGGER tr_set_student_average BEFORE INSERT ON students FOR EACH ROW
FOLLOWS tr_generate_student_grade_c
BEGIN
	:new.average := ROUND(((:new.grade_a + :new.grade_b + :new.grade_c) / 3), 2);
END;

-- Gerar situação do aluno
CREATE OR REPLACE TRIGGER tr_generate_student_situation BEFORE INSERT ON students FOR EACH ROW
FOLLOWS tr_set_student_average
BEGIN
	IF (:new.average > 8) THEN 
    	:new.situation := 'Aprovado';
	ELSIF (:new.average > 5) THEN 
    	:new.situation := 'Em exame';
	ELSE
    	:new.situation := 'Reprovado';
	END IF;
END;

-- Gerar média da turma
CREATE OR REPLACE TRIGGER tr_set_class_average AFTER INSERT ON students
BEGIN
	UPDATE classes 
    SET average = (
    	SELECT ROUND(AVG(average), 2) 
        FROM students 
        WHERE actual_class = class_id
    );
END;

-- Gerar média da turma após deletar aluno
CREATE OR REPLACE TRIGGER tr_set_class_average_2 AFTER DELETE ON students
BEGIN
	UPDATE classes 
    SET average = (
    	SELECT ROUND(AVG(average),2)
        FROM students 
        WHERE actual_class = class_id
    );
END;

/* Inserts */
DELETE students;

INSERT INTO shifts (shift_name) VALUES ('Matutino');
INSERT INTO shifts (shift_name) VALUES ('Vespertino');
INSERT INTO shifts (shift_name) VALUES ('Noturno');
SELECT * FROM shifts;

INSERT INTO classes (class_name, shift) VALUES ('1A', 1);
INSERT INTO classes (class_name, shift) VALUES ('1B', 2);
INSERT INTO classes (class_name, shift) VALUES ('1C', 3);
SELECT * FROM classes
INNER JOIN shifts ON (shift_id = shift);

INSERT INTO students (student_name, actual_class) VALUES ('João', 1);
INSERT INTO students (student_name, actual_class) VALUES ('Henrique', 2);
INSERT INTO students (student_name, actual_class) VALUES ('Wesley', 3);
INSERT INTO students (student_name, actual_class) VALUES ('Victor', 1);
INSERT INTO students (student_name, actual_class) VALUES ('Samuel', 2);
INSERT INTO students (student_name, actual_class) VALUES ('Gabriel', 3);
INSERT INTO students (student_name, actual_class) VALUES ('Gustavo', 1);
INSERT INTO students (student_name, actual_class) VALUES ('André', 2);
INSERT INTO students (student_name, actual_class) VALUES ('Lucas', 3);
SELECT student_name, classes.class_name, grade_a, grade_b, grade_c, students.average FROM students
INNER JOIN classes ON (actual_class = class_id);
