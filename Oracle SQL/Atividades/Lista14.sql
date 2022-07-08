-- DROPS
/*
	DROP TRIGGER tr_set_employee_net_salary;
	DROP TRIGGER tr_set_employee_food_voucher;
	DROP TRIGGER tr_set_employee_transportation_voucher;
	DROP TRIGGER tr_set_employee_income_tax;
	DROP TRIGGER tr_set_employee_role;
	DROP TRIGGER tr_employees_auto_increment;
	DROP SEQUENCE sq_employees;
	DROP TABLE employees;
*/

CREATE TABLE employees (
	employee_id INTEGER,
	employee_name VARCHAR2(155),
	employee_role VARCHAR2(40),
	employee_gross_salary number,
	employee_income_tax NUMBER,
	employee_transport_voucher NUMBER,
	employee_food_voucher NUMBER,
	employee_net_salary NUMBER
);
CREATE SEQUENCE sq_employees MINVALUE 1 START WITH 1 INCREMENT BY 1;

-- 会社員の「Auto increment」を設定する。
CREATE OR REPLACE TRIGGER tr_employees_auto_increment
BEFORE INSERT ON employees
FOR EACH ROW
BEGIN
	:new.employee_id := sq_employees.nextval;
END;

-- 会社員の税込み（ぜいこみ）を設定する。
CREATE OR REPLACE TRIGGER tr_set_employee_role
BEFORE INSERT ON employees
FOR EACH ROW
FOLLOWS tr_employees_auto_increment
DECLARE
	employee_role VARCHAR2(40);
BEGIN
	employee_role := :new.employee_role;

	IF employee_role = 'Desenvolvedor C#' THEN
		:new.employee_gross_salary := 5000;
        
	ELSIF employee_role = 'Desenvolvedor PHP' THEN
		:new.employee_gross_salary := 4300;
        
	ELSIF employee_role = 'Desenvolvedor Java' THEN
		:new.employee_gross_salary := 5700;
        
	ELSIF employee_role = 'Desenvolvedor Python' THEN
		:new.employee_gross_salary := 4800;
        
	END IF;
END;

-- 会社員の所得税（しょとくぜん）を設定する。
CREATE OR REPLACE TRIGGER tr_set_employee_income_tax
BEFORE INSERT ON employees
FOR EACH ROW
FOLLOWS tr_set_employee_role
BEGIN
	IF    :new.employee_gross_salary >= 5000 THEN :new.employee_income_tax := (:new.employee_gross_salary * 0.2);
	ELSIF :new.employee_gross_salary >= 4500 THEN :new.employee_income_tax := (:new.employee_gross_salary * 0.15);
	ELSIF :new.employee_gross_salary >= 2000 THEN :new.employee_income_tax := (:new.employee_gross_salary * 0.1);
	END IF;
END;

-- 会社員の旅行券（りょこうけん）の価格（かかく）を設定する。
CREATE OR REPLACE TRIGGER tr_set_employee_transportation_voucher
BEFORE INSERT ON employees
FOR EACH ROW
FOLLOWS tr_set_employee_income_tax
BEGIN
	:new.employee_transport_voucher := (:new.employee_gross_salary * 0.06);
END;

-- 会社員の食券（しょっけん）を設定する。
CREATE OR REPLACE TRIGGER tr_set_employee_food_voucher
BEFORE INSERT ON employees
FOR EACH ROW
FOLLOWS tr_set_employee_transportation_voucher
BEGIN
	:new.employee_food_voucher := :new.employee_gross_salary * 0.08;
END;

-- 会社員の手取り（てどり）を設定する。
CREATE OR REPLACE TRIGGER tr_set_employee_net_salary
BEFORE INSERT ON employees
FOR EACH ROW
FOLLOWS tr_set_employee_food_voucher
DECLARE
	total_to_discount NUMBER;
BEGIN
	total_to_discount := (:new.employee_food_voucher +  :new.employee_transport_voucher +  :new.employee_income_tax);
	:new.employee_net_salary := (:new.employee_gross_salary - total_to_discount);
END;



-- テーブルにデータを入れる
TRUNCATE TABLE employees;
INSERT INTO employees (employee_name, employee_role) VALUES ('João', 'Desenvolvedor C#');
INSERT INTO employees (employee_name, employee_role) VALUES ('Henrique', 'Desenvolvedor PHP');
INSERT INTO employees (employee_name, employee_role) VALUES ('William', 'Desenvolvedor Java');
INSERT INTO employees (employee_name, employee_role) VALUES ('Wesley', 'Desenvolvedor Python');

-- テーブルにデータを読む。
SELECT * FROM employees;
