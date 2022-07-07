/* TABLES */
CREATE TABLE students (
	id INTEGER,
	name VARCHAR2(155) NOT NULL,
	gradeA NUMBER NOT NULL,
	gradeB NUMBER NOT NULL,
	avarage NUMBER
);
ALTER TABLE students ADD CONSTRAINT pk_student PRIMARY KEY (id);
CREATE SEQUENCE student_auto_increment MINVALUE 1 START WITH 1 INCREMENT BY 1;
/* END TABLES */

/* TRIGGERS */
CREATE OR REPLACE TRIGGER tr_student_increment
BEFORE INSERT ON students
FOR EACH ROW
BEGIN
	:new.id := student_auto_increment.NEXTVAL;
END;

CREATE OR REPLACE TRIGGER tr_student_setAvarage
BEFORE INSERT ON students
FOR EACH ROW
BEGIN
	:new.avarage := (:new.gradeA + :new.gradeB) / 2;
END;
/* END TRIGGERS */

TRUNCATE TABLE students;

INSERT INTO students (name, gradea, gradeb) VALUES ('João', 10, 8.5);
INSERT INTO students (name, gradea, gradeb) VALUES ('Henrique', 5, 6);

SELECT * FROM students;


/* DROPS */
DROP TABLE students;
DROP SEQUENCE student_auto_increment;
DROP TRIGGER tr_student_increment;
DROP TRIGGER tr_student_setAvarage;
