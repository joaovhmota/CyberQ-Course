-- DROPS
/*
DROP TABLE employees;
DROP TABLE locations;
DROP TABLE addresses;
DROP TABLE cities;
DROP TABLE states;
DROP TABLE countries;
DROP TABLE sector_project;
DROP TABLE projects;
DROP TABLE sectors;
DROP TABLE roles;
DROP TABLE shifts;
*/

-- Shifts
CREATE TABLE shifts (
	id         NUMBER       GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name       VARCHAR2(15) NOT NULL,
	start_hour INTEGER      NOT NULL,
	end_hour   INTEGER      NOT NULL,
	CONSTRAINT pk_shifts PRIMARY KEY (id)
);
TRUNCATE TABLE shifts;
INSERT INTO shifts (name, start_hour, end_hour) VALUES ('Matutino',    9, 18);
INSERT INTO shifts (name, start_hour, end_hour) VALUES ('Vespertino', 17, 00);
INSERT INTO shifts (name, start_hour, end_hour) VALUES ('Noturno',    00,  9);
SELECT * FROM shifts;


-- Roles
CREATE TABLE roles (
	id     NUMBER        GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name   VARCHAR2(155) NOT NULL,
	salary NUMBER        NOT NULL,
	CONSTRAINT pk_roles PRIMARY KEY (id)
);
TRUNCATE TABLE roles;
INSERT INTO roles (name, salary) VALUES ('Desenvolvedor de Sistemas', 6500);
INSERT INTO roles (name, salary) VALUES ('Analista de Sistemas',      6500);
INSERT INTO roles (name, salary) VALUES ('Gerente de TI',             10000);
INSERT INTO roles (name, salary) VALUES ('Designer',                  5500);
INSERT INTO roles (name, salary) VALUES ('Secretário',                3500);
INSERT INTO roles (name, salary) VALUES ('Atendente de Suporte',      3500);
INSERT INTO roles (name, salary) VALUES ('Faxineiro',                 2000);
SELECT * FROM roles;


-- Sectors
CREATE TABLE sectors (
	id   NUMBER        GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(155) NOT NULL,
	CONSTRAINT pk_sectors PRIMARY KEY(id)
);
TRUNCATE TABLE sectors;
INSERT INTO sectors (name) VALUES ('Desenvolvimento');
INSERT INTO sectors (name) VALUES ('RH');
INSERT INTO sectors (name) VALUES ('Suporte');
INSERT INTO sectors (name) VALUES ('Marketing');
INSERT INTO sectors (name) VALUES ('Limpeza');
SELECT * FROM sectors;


-- Projects
CREATE TABLE projects (
	id         NUMBER        GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name       VARCHAR2(155) NOT NULL,
	start_date DATE          NOT NULL,
	end_date   DATE          DEFAULT NULL,
	CONSTRAINT pk_projects PRIMARY KEY (id)
);
TRUNCATE TABLE projects;
INSERT INTO projects (name, start_date, end_date) VALUES ('QFome',                '20-10-2017', '15-7-2019');
INSERT INTO projects (name, start_date, end_date) VALUES ('QEntregas',            '22-04-2019', null);
INSERT INTO projects (name, start_date, end_date) VALUES ('QSaúde',               '31-05-2021', null);
INSERT INTO projects (name, start_date, end_date) VALUES ('Desing da fachada',    '03-03-2020', '04-04-2020');
INSERT INTO projects (name, start_date, end_date) VALUES ('Nova logo da empresa', '03-03-2020', '04-04-2020');
SELECT * FROM projects;


-- Sector_Project
CREATE TABLE sector_project (
	sector  INTEGER NOT NULL,
	project INTEGER NOT NULL,
	CONSTRAINT fk_sector_projects_sector FOREIGN KEY (sector) REFERENCES sectors (id),
	CONSTRAINT fk_sector_projects_project FOREIGN KEY (project) REFERENCES projects (id)
);
TRUNCATE TABLE sector_project;
INSERT INTO sector_project VALUES (1, 1);
INSERT INTO sector_project VALUES (1, 2);
INSERT INTO sector_project VALUES (1, 3);
INSERT INTO sector_project VALUES (4, 4);
INSERT INTO sector_project VALUES (4, 5);
SELECT
	sectors.name AS Setor,
	projects.name AS Projeto
FROM sector_project
INNER JOIN sectors ON (sectors.id = sector_project.sector)
INNER JOIN projects ON (projects.id = sector_project.project);


-- Countries
CREATE TABLE countries (
	id   NUMBER        GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(155) NOT NULL,
	CONSTRAINT pk_country PRIMARY KEY (id)
);
TRUNCATE TABLE countries;
INSERT INTO countries (name) VALUES ('Brasil');
INSERT INTO countries (name) VALUES ('Estados Unidos');
INSERT INTO countries (name) VALUES ('Japão');
INSERT INTO countries (name) VALUES ('Alemanha');
INSERT INTO countries (name) VALUES ('País de Gales');


-- States
CREATE TABLE states (
	id      NUMBER        GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name    VARCHAR2(155) NOT NULL,
	country INTEGER NOT NULL,
	CONSTRAINT pk_state PRIMARY KEY (id),
	CONSTRAINT fk_contry FOREIGN KEY (country) REFERENCES countries (id)
);
TRUNCATE TABLE states;
INSERT INTO states (name, country) VALUES ('Santa Catarina', 1);
INSERT INTO states (name, country) VALUES ('Ohio',           2);
INSERT INTO states (name, country) VALUES ('Kanto',          3);
INSERT INTO states (name, country) VALUES ('Hesse',          4);
INSERT INTO states (name, country) VALUES ('Anglesey',       5);


-- Cities
CREATE TABLE cities (
	id      NUMBER        GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name    VARCHAR2(155) NOT NULL,
	state INTEGER NOT NULL,
	CONSTRAINT pk_city PRIMARY KEY (id),
	CONSTRAINT fk_state FOREIGN KEY (state) REFERENCES states (id)
);
TRUNCATE TABLE cities;
INSERT INTO cities (name, state) VALUES ('Pomerode',                                                   1);
INSERT INTO cities (name, state) VALUES ('Washington',                                                 2);
INSERT INTO cities (name, state) VALUES ('Tóquio',                                                     3);
INSERT INTO cities (name, state) VALUES ('Dillenburg',                                                 4);
INSERT INTO cities (name, state) VALUES ('Llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch', 5);


-- Addresses
CREATE TABLE addresses (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	street VARCHAR2(155) NOT NULL,
	number_ NUMBER NOT NULL,
	city NUMBER NOT NULL,
	CONSTRAINT pk_address PRIMARY KEY (id),
	CONSTRAINT fk_city FOREIGN KEY (city) REFERENCES cities (id)
);
TRUNCATE TABLE addresses;
INSERT INTO addresses (street, number_, city) VALUES ('Rua Tiradentes', 171, 1);
INSERT INTO addresses (street, number_, city) VALUES ('Rua Short',      172, 2);
INSERT INTO addresses (street, number_, city) VALUES ('Rua Yojuin',     173, 3);
INSERT INTO addresses (street, number_, city) VALUES ('Schlehenweg',    174, 4);
INSERT INTO addresses (street, number_, city) VALUES ('Rua Holyhead',   175, 5);


-- Locations
CREATE TABLE locations (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	address NUMBER NOT NULL,
	CONSTRAINT pk_locations PRIMARY KEY (id),
	CONSTRAINT fk_address FOREIGN KEY (address) REFERENCES addresses (id)
);
TRUNCATE TABLE locations;
INSERT INTO locations (address) VALUES (1);
INSERT INTO locations (address) VALUES (2);
INSERT INTO locations (address) VALUES (3);
INSERT INTO locations (address) VALUES (4);
INSERT INTO locations (address) VALUES (5);

-- Employees
CREATE TABLE employees (
	id NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name VARCHAR2(155) NOT NULL,
	birthday DATE,
	role INTEGER ,
	sector INTEGER ,
	shift  INTEGER,
	CONSTRAINT pk_employee PRIMARY KEY(id),
	CONSTRAINT fk_role FOREIGN KEY (role) REFERENCES roles (id),
	CONSTRAINT fk_sector FOREIGN KEY (sector) REFERENCES sectors (id),
	CONSTRAINT fk_shift FOREIGN KEY (shift) REFERENCES shifts (id)
);
TRUNCATE TABLE employees;
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('Ralf Lima',          TO_DATE('1/1/2000', 'dd/mm/yyyy'), 3,    null, 1);
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('Samuca',             TO_DATE('1/1/2005', 'dd/mm/yyyy'), 7,    5,    1);
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('Victor',             TO_DATE('1/1/2005', 'dd/mm/yyyy'), 7,    5,    1);
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('Adegas',             TO_DATE('1/1/2003', 'dd/mm/yyyy'), 7,    5,    2);
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('Aeges',              TO_DATE('1/1/2003', 'dd/mm/yyyy'), 1,    1,    2);
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('Henrique',           TO_DATE('1/1/2006', 'dd/mm/yyyy'), 1,    1,    3);
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('Rei da Sinuca',      TO_DATE('1/1/2005', 'dd/mm/yyyy'), null, null, null);
INSERT INTO employees (name, birthday, role, sector, shift) VALUES ('William 5 Galinhas', TO_DATE('1/1/2002', 'dd/mm/yyyy'), 4,    4,    3);
SELECT 
	employees.id AS ID,
	employees.name AS Funcionario,
	employees.birthday AS Nascimento,
	roles.name AS Cargo,
	sectors.name AS Setor,
	shifts.name AS Turno
FROM employees
LEFT JOIN roles ON (roles.id = employees.role)
LEFT JOIN sectors ON (sectors.id = employees.sector)
LEFT JOIN shifts ON (shifts.id = employees.shift)
ORDER BY employees.id;


-- QUESTÕES


-- 1 Mostrar todos quantas localizações a empresa possuí
SELECT COUNT(*) FROM locations;

-- 2 Mostrar todos os endereços da empresas (rua, cidade, estado, país)
SELECT 
	addresses.street AS Rua,
	addresses.number_ AS Número,
	cities.name AS Cidade,
	states.name AS Estado,
	countries.name AS País
FROM addresses
INNER JOIN cities ON (cities.id = addresses.city)
INNER JOIN states ON (states.id = cities.state)
INNER JOIN countries ON (countries.id = states.country)


-- 3 Mostrar todos os funcionários que trabalham no período Matutino
SELECT 
	employees.name AS Funcionario,
	employees.birthday AS Nascimento,
	roles.name AS Cargo,
	sectors.name AS Setor,
	shifts.name AS Turno
FROM employees
INNER JOIN roles ON (roles.id = employees.role)
INNER JOIN sectors ON (sectors.id = employees.sector)
INNER JOIN shifts ON (shifts.id = employees.shift)
WHERE shifts.name = 'Matutino';


-- 4 Mostre todos os funcionários que nasceram antes de 2005
SELECT 
	employees.name AS Funcionario,
	employees.birthday AS Nascimento,
	roles.name AS Cargo,
	sectors.name AS Setor,
	shifts.name AS Turno
FROM employees
INNER JOIN roles ON (roles.id = employees.role)
INNER JOIN sectors ON (sectors.id = employees.sector)
INNER JOIN shifts ON (shifts.id = employees.shift)
WHERE (EXTRACT(YEAR FROM employees.birthday) < 2005);

-- 5 Mostre todos funcionários que trabalham no setor de marketing
SELECT 
	employees.name AS Funcionario,
	sectors.name AS Setor,
FROM employees
INNER JOIN sectors ON (sectors.id = employees.sector)
WHERE (sectors.name = 'Marketing');


-- 6 Mostre todos os setores registrados
SELECT * FROM sectors;


-- 7 Mostre todos os functionários, incluíndo os que ainda não tem setor, turno ou cargo definido
SELECT 
	employees.name AS Funcionario,
	employees.birthday AS Nascimento,
	roles.name AS Cargo,
	sectors.name AS Setor,
	shifts.name AS Turno
FROM employees
LEFT JOIN roles ON (roles.id = employees.role)
LEFT JOIN sectors ON (sectors.id = employees.sector)
LEFT JOIN shifts ON (shifts.id = employees.shift);


-- 8 Selecione os funcionários que recebem o menor salário
SELECT 
	employees.name AS Funcionario,
	employees.birthday AS Nascimento,
	roles.name AS Cargo,
    roles.salary AS Salário
FROM employees
INNER JOIN roles ON (roles.id = employees.role)
WHERE roles.salary = (
	SELECT 
        MIN(roles.salary)
    FROM employees
    INNER JOIN roles ON (roles.id = employees.role)
);


-- 8 Selecione os funcionários que recebem o maior salário
SELECT 
	employees.name AS Funcionario,
	employees.birthday AS Nascimento,
	roles.name AS Cargo,
    roles.salary AS Salário
FROM employees
INNER JOIN roles ON (roles.id = employees.role)
WHERE roles.salary = (
	SELECT 
        MAX(roles.salary)
    FROM employees
    INNER JOIN roles ON (roles.id = employees.role)
);


-- 9 Mostre a quantidade de funcionários que trabalham no setor de limpeza
SELECT 
	COUNT(*) AS Quantidade,
	sectors.name AS Setor
FROM employees
RIGHT JOIN sectors ON (sectors.id = employees.sector)
WHERE sectors.name = 'Limpeza'
GROUP BY sectors.name;


-- 10 Faça a soma dos salários de todos os funcionários
SELECT 
	SUM(roles.salary) AS Total
FROM employees
RIGHT JOIN roles ON (roles.id = employees.role);


-- 11 Ordene os salários por ordem crescente
SELECT * FROM roles ORDER BY salary;


-- 12 Ordene os funcionários por salário (Decrescente)
SELECT 
	employees.name AS Funcionario,
    roles.salary AS Salário
FROM employees
INNER JOIN roles ON (roles.id = employees.role)
ORDER BY roles.salary DESC;


-- 13 Mostre a média dos salários
SELECT ROUND(AVG(salary),2) FROM roles;


-- 14 Mostre todos os funcionários dos quais o nome incluam um número ou uma letra acentuada
SELECT * FROM employees 
WHERE 
	name LIKE '%0%' OR 
	name LIKE '%1%' OR 
	name LIKE '%2%' OR
    name LIKE '%3%' OR 
    name LIKE '%4%' OR 
    name LIKE '%5%' OR 
    name LIKE '%6%' OR 
    name LIKE '%7%' OR 
    name LIKE '%8%' OR 
    name LIKE '%9%' OR 
    name LIKE '%ã%' OR 
    name LIKE '%õ%' OR 
    name LIKE '%á%' OR 
    name LIKE '%é%' OR 
    name LIKE '%ó%' OR 
    name LIKE '%í%' OR 
    name LIKE '%ú%' OR 
    name LIKE '%â%' OR 
    name LIKE '%ê%' OR 
    name LIKE '%ô%' OR 
	name LIKE '%ü%';


-- 15 Altere todos os funcionários cujo turno seja matutino para vespertino
UPDATE employees SET shift = 2 WHERE shift = 1;
SELECT 
	employees.name AS Funcionario,
    employees.shift,
	shifts.name AS Turno
FROM employees
INNER JOIN shifts ON (shifts.id = employees.shift);


-- 16 Remova a coluna table dos funcionários
ALTER TABLE employees DROP CONSTRAINT fk_shift;
ALTER TABLE employees DROP COLUMN shift;
SELECT * FROM employees;


-- 17 Adicione uma coluna chamada 'AbleToWork' e coloque todos os funcionários com o valor '1'
ALTER TABLE employees ADD able_to_work NUMBER(1);
UPDATE employees SET able_to_work = 1;
SELECT * FROM employees;


-- 18 Mostre todos os países, estados e cidades na mesma tabela
SELECT name FROM countries
UNION
SELECT name FROM states
UNION
SELECT name from cities
ORDER BY name;


-- 19 Mostre todos os salários entre 3000 e 10000
SELECT * FROM roles WHERE salary BETWEEN 3000 AND 10000;


-- 20 Mude o nome da tabela Countries para Paises e Mude ela novamente para Countries
ALTER TABLE countries RENAME TO paises;
SELECT * FROM paises;
ALTER TABLE paises RENAME TO countries;
SELECT * FROM countries;


-- 21 Informe todos os salários, caso ele for acima de 5000, mostre como 'Bom', caso abaixo, 'Ruim'
SELECT
	roles.name AS Cargo,
	roles.salary AS Salário,
	(CASE WHEN roles.salary >= 5000 THEN 'Bom' ELSE 'Ruim' END) AS Situação
FROM roles;


-- 22 Mostre quantos funcionários trabalham em cada cargo
SELECT
	DISTINCT(roles.name) AS Cargo,
    COUNT(*) AS Quantidade
FROM employees
INNER JOIN roles ON (roles.id = employees.role)
GROUP BY roles.name;


-- 23 Mostre todos os países em que a empresa se encontra
SELECT * FROM countries;


-- 24 Mostre todas as cidade do Brasil em que a empresa se encontra
SELECT * FROM cities INNER JOIN states ON (states.id = cities.id) INNER JOIN countries ON (countries.id = states.id) WHERE countries.name = 'Brasil';


-- 25 Drope todas as tabelas
DROP TABLE employees;
DROP TABLE locations;
DROP TABLE addresses;
DROP TABLE cities;
DROP TABLE states;
DROP TABLE countries;
DROP TABLE sector_project;
DROP TABLE projects;
DROP TABLE sectors;
DROP TABLE roles;
DROP TABLE shifts;
