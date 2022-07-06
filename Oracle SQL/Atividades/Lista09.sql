-- DROPS 
/*
DROP TABLE results;
DROP TABLE students;
DROP TABLE teacher_class;
DROP TABLE classes;
DROP TABLE financials;
DROP TABLE shifts;
DROP TABLE tests;
DROP TABLE teachers;
DROP TABLE subjects;
*/

-- CREATES
CREATE TABLE subjects (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(255),
	
	CONSTRAINT pk_subject_id PRIMARY KEY (id)
);

CREATE TABLE teachers (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(255),
	subject NUMBER,
	
	CONSTRAINT pk_teacher_id PRIMARY KEY (id),
	CONSTRAINT fk_teacher_subject_id FOREIGN KEY (subject) REFERENCES subjects (id)
);

CREATE TABLE tests (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(255),
	subject NUMBER,
    teacher NUMBER,
	
	CONSTRAINT pk_test_id PRIMARY KEY (id),
	CONSTRAINT fk_test_subject FOREIGN KEY (subject) REFERENCES subjects (id),
    CONSTRAINT fk_test_teacher FOREIGN KEY (teacher) REFERENCES teachers (id)
);

CREATE TABLE shifts (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(255),
	
	CONSTRAINT pk_shift PRIMARY KEY(id)
);

CREATE TABLE financials (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	value NUMBER,
	
	CONSTRAINT pk_financial PRIMARY KEY (id)
);

CREATE TABLE classes (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(255),
	shift NUMBER,
	
	CONSTRAINT pk_class PRIMARY KEY (id),
    CONSTRAINT fk_class_shift FOREIGN KEY (shift) REFERENCES shifts (id)
);

CREATE TABLE teacher_class (
	teacher NUMBER,
	class NUMBER,
	
	CONSTRAINT fk_teacher_class_teacher FOREIGN KEY (teacher) REFERENCES teachers (id),
    CONSTRAINT fk_teacher_class_class FOREIGN KEY (class) REFERENCES classes (id)
);

CREATE TABLE students (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(255),
	class NUMBER,
	financial NUMBER,
	
	CONSTRAINT pk_student PRIMARY KEY (id),
	CONSTRAINT fk_student_class FOREIGN KEY (class) REFERENCES classes (id),
	CONSTRAINT fk_student_financial FOREIGN KEY (financial) REFERENCES financials (id)
);

CREATE TABLE results (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	test NUMBER,
	grade NUMBER,
	student NUMBER,
	
	CONSTRAINT pk_result PRIMARY KEY (id),
	CONSTRAINT fk_result_test FOREIGN KEY (test) REFERENCES tests (id),
	CONSTRAINT fk_result_student FOREIGN KEY (student) REFERENCES students (id)
);
-- END CREATES

-- INSERTS 

INSERT INTO subjects (name) VALUES ('Português'); -- 1
INSERT INTO subjects (name) VALUES ('Inglês'); -- 2
INSERT INTO subjects (name) VALUES ('Matemática'); -- 3
INSERT INTO subjects (name) VALUES ('Ciências'); -- 4
SELECT * FROM subjects;


INSERT INTO teachers (name, subject) VALUES ('Marcelo', 1); -- 1
INSERT INTO teachers (name, subject) VALUES ('Rodrigo', 2); -- 2
INSERT INTO teachers (name, subject) VALUES ('Juliana', 3); -- 3
INSERT INTO teachers (name, subject) VALUES ('Márcia', 4); -- 4
INSERT INTO teachers (name, subject) VALUES ('Cátia', 1); -- 5
INSERT INTO teachers (name, subject) VALUES ('José', 2); -- 6
INSERT INTO teachers (name, subject) VALUES ('Jonathan', 3); -- 7
INSERT INTO teachers (name, subject) VALUES ('Maria', 4); -- 8
SELECT 
	teachers.id,
	teachers.name AS Professor, 
	subjects.name AS Matéria
FROM teachers INNER JOIN subjects ON (subjects.id = teachers.subject);


INSERT INTO tests (name, subject, teacher) VALUES ('Prova Português', 1, 1); -- 1
INSERT INTO tests (name, subject, teacher) VALUES ('Prova Português', 1, 5); -- 2
INSERT INTO tests (name, subject, teacher) VALUES ('Prova Inglês', 2, 2); -- 3
INSERT INTO tests (name, subject, teacher) VALUES ('Prova Inglês', 2, 6); -- 4
INSERT INTO tests (name, subject, teacher) VALUES ('Prova Matemática', 3, 3); -- 5
INSERT INTO tests (name, subject, teacher) VALUES ('Prova Matemática', 3, 7); -- 6
INSERT INTO tests (name, subject, teacher) VALUES ('Prova Ciências', 4, 4); -- 7
INSERT INTO tests (name, subject, teacher) VALUES ('Prova Ciências', 4, 8); -- 8
SELECT
	tests.name AS Prova,
	subjects.name AS Matéria,
	teachers.name AS Professor
FROM tests
INNER JOIN subjects ON (subjects.id = tests.subject)
INNER JOIN teachers ON (teachers.id = tests.teacher)
ORDER BY subjects.name;


INSERT INTO shifts (name) VALUES ('Matutino'); -- 1
INSERT INTO shifts (name) VALUES ('Vespertino'); -- 2
INSERT INTO shifts (name) VALUES ('Noturno'); -- 3
SELECT * FROM shifts;


INSERT INTO financials (value) VALUES (800); -- 1
INSERT INTO financials (value) VALUES (1050); -- 2
SELECT * FROM financials;


INSERT INTO classes (name, shift) VALUES ('Turma 1', 1); -- 1
INSERT INTO classes (name, shift) VALUES ('Turma 2', 2); -- 2
INSERT INTO classes (name, shift) VALUES ('Turma 3', 3); -- 3
INSERT INTO classes (name, shift) VALUES ('Turma 4', 1); -- 4
INSERT INTO classes (name, shift) VALUES ('Turma 5', 2); -- 5
INSERT INTO classes (name, shift) VALUES ('Turma 6', 3); -- 6
SELECT
	classes.name AS Turma,
	shifts.name AS Turno
FROM classes
INNER JOIN shifts ON (shifts.id = classes.shift);


INSERT INTO teacher_class (teacher, class) VALUES (1, 1); -- 1
INSERT INTO teacher_class (teacher, class) VALUES (2, 1); -- 2
INSERT INTO teacher_class (teacher, class) VALUES (3, 1); -- 3
INSERT INTO teacher_class (teacher, class) VALUES (4, 1); -- 4
INSERT INTO teacher_class (teacher, class) VALUES (5, 2); -- 5
INSERT INTO teacher_class (teacher, class) VALUES (6, 2); -- 6
INSERT INTO teacher_class (teacher, class) VALUES (7, 2); -- 7
INSERT INTO teacher_class (teacher, class) VALUES (8, 2); -- 8
SELECT 
	teachers.name AS Professor,
	classes.name AS Turma
FROM teacher_class
INNER JOIN teachers ON (teachers.id = teacher_class.teacher)
INNER JOIN classes ON (classes.id = teacher_class.class);


INSERT INTO students (name, class, financial) VALUES ('João', 1, 1); -- 1
INSERT INTO students (name, class, financial) VALUES ('Camila', 1, 1); -- 2
INSERT INTO students (name, class, financial) VALUES ('Richard', 1, 1); -- 3
INSERT INTO students (name, class, financial) VALUES ('Enzo', 1, 1); -- 4
INSERT INTO students (name, class, financial) VALUES ('Kauani', 1, 1); -- 5
INSERT INTO students (name, class, financial) VALUES ('Samuel', 2, 2); -- 6
INSERT INTO students (name, class, financial) VALUES ('Vitor', 2, 2); -- 7
INSERT INTO students (name, class, financial) VALUES ('Gabriel', 2, 2); -- 8
INSERT INTO students (name, class, financial) VALUES ('Henrique', 2, 2); -- 9
INSERT INTO students (name, class, financial) VALUES ('William', 2, 2); -- 10
SELECT 
	students.id AS ID,
	students.name AS Estudante,
	classes.name AS Turma,
	financials.value AS Mensalidade
FROM students
INNER JOIN classes ON (classes.id = students.class)
INNER JOIN financials ON (financials.id = students.financial);


INSERT INTO results (test, grade, student) VALUES (1, 7.5, 1); -- 1
INSERT INTO results (test, grade, student) VALUES (1, 9.2, 2); -- 2
INSERT INTO results (test, grade, student) VALUES (1, 8.7, 3); -- 3
INSERT INTO results (test, grade, student) VALUES (1, 6.5, 4); -- 4
INSERT INTO results (test, grade, student) VALUES (1, 8.8, 5); -- 5

INSERT INTO results (test, grade, student) VALUES (8, 7.5, 6); -- 6
INSERT INTO results (test, grade, student) VALUES (8, 9.2, 7); -- 7
INSERT INTO results (test, grade, student) VALUES (8, 8.7, 8); -- 8
INSERT INTO results (test, grade, student) VALUES (8, 6.5, 9); -- 9
INSERT INTO results (test, grade, student) VALUES (8, 8.8, 10); -- 10

SELECT
	students.name AS Estudante,
	classes.name AS Turma,
	tests.name AS Prova,
	results.grade AS Nota,
	subjects.name AS Matéria,
	teachers.name AS Professor
FROM results
INNER JOIN students ON (students.id = results.student)
INNER JOIN tests ON (tests.id = results.test)
INNER JOIN subjects ON (subjects.id = tests.subject)
INNER JOIN teachers ON (teachers.id = tests.teacher)
INNER JOIN classes ON (classes.id = students.class)
ORDER BY classes.name ASC, students.name ASC;
-- END INSERTS
