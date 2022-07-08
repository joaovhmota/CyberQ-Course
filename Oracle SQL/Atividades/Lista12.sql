/* PART 1 */
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
/* END PART 1*/


/* PART 2 */
CREATE TABLE product (
	id INTEGER,
	name VARCHAR2(155),
	price NUMBER,
	promotional_price NUMBER
);

CREATE SEQUENCE sq_product MINVALUE 1 START WITH 1 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER tr_product_auto_increment
BEFORE INSERT ON product
FOR EACH ROW
BEGIN
	:new.id := sq_product.Nextval;
END;

CREATE OR REPLACE TRIGGER tr_discount_product
BEFORE INSERT ON product
FOR EACH ROW
BEGIN
	:new.promotional_price := (:new.price * 0.9);
END;

INSERT INTO product (name, price) VALUES ('Celular', 1000);
INSERT INTO product (name, price) VALUES ('Celular, só que mais caro', 10000);

SELECT * FROM product;
/* END PART 2 */
