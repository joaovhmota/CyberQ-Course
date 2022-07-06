-- DROPS
/*
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
INSERT INTO shifts (name, start_hour, end_hour) VALUES ('Matutino', 9, 18);
INSERT INTO shifts (name, start_hour, end_hour) VALUES ('Vespertino', 17, 00);
INSERT INTO shifts (name, start_hour, end_hour) VALUES ('Noturno', 00, 9);
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
INSERT INTO roles (name, salary) VALUES ('Analista de Sistemas', 6500);
INSERT INTO roles (name, salary) VALUES ('Gerente de TI', 10000);
INSERT INTO roles (name, salary) VALUES ('Designer', 5500);
INSERT INTO roles (name, salary) VALUES ('Secretário', 3500);
INSERT INTO roles (name, salary) VALUES ('Atendente de Suporte', 3500);
INSERT INTO roles (name, salary) VALUES ('Faxineiro', 2000);
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
INSERT INTO projects (name, start_date, end_date) VALUES ('QFome', '20-10-2017', '15-7-2019');
INSERT INTO projects (name, start_date, end_date) VALUES ('QEntregas', '22-04-2019', null);
INSERT INTO projects (name, start_date, end_date) VALUES ('QSaúde', '31-05-2021', null);
INSERT INTO projects (name, start_date, end_date) VALUES ('Desing da fachada', '03-03-2020', '04-04-2020');
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
INSERT INTO states (name, country) VALUES ('Ohio', 2);
INSERT INTO states (name, country) VALUES ('Kanto', 3);
INSERT INTO states (name, country) VALUES ('Hesse', 4);
INSERT INTO states (name, country) VALUES ('Anglesey', 5);


-- Cities
CREATE TABLE cities (
	id      NUMBER        GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
	name    VARCHAR2(155) NOT NULL,
	state INTEGER NOT NULL,
	CONSTRAINT pk_city PRIMARY KEY (id),
	CONSTRAINT fk_state FOREIGN KEY (state) REFERENCES states (id)
);
TRUNCATE TABLE cities;
INSERT INTO cities (name, state) VALUES ('Pomerode', 1);
INSERT INTO cities (name, state) VALUES ('Washington', 2);
INSERT INTO cities (name, state) VALUES ('Tóquio', 3);
INSERT INTO cities (name, state) VALUES ('Dillenburg', 4);
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
INSERT INTO addresses (street, number_, city) VALUES ('Rua Short', 172, 2);
INSERT INTO addresses (street, number_, city) VALUES ('Rua Yojuin', 173, 3);
INSERT INTO addresses (street, number_, city) VALUES ('Schlehenweg', 174, 4);
INSERT INTO addresses (street, number_, city) VALUES ('Rua Holyhead', 175, 5);


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
	birtyday DATE NOT NULL,
	role INTEGER NOT NULL,
	sector INTEGER NOT NULL,
	shift  INTEGER NOT NULL,
	supervisor INTEGER,
	CONSTRAINT pk_employee PRIMARY KEY(id),
	CONSTRAINT fk_role FOREIGN KEY (role) REFERENCES roles (id),
	CONSTRAINT fk_sector FOREIGN KEY (sector) REFERENCES sectors (id),
	CONSTRAINT fk_shift FOREIGN KEY (shift) REFERENCES shifts (id),
	CONSTRAINT fk_supervisor FOREIGN KEY (supervisor) REfERENCES employees (id)
);
TRUNCATE TABLE employees;
-- ATUALIZAR DADOS!!!!
/*
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('Ralf Lima', '1-1-0001', 1, 1, 1, null);
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('Samuca', '1-1-0001', 1, 1, 1, null);
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('Victor', '1-1-0001', 1, 1, 1, null);
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('Adegas', '1-1-0001', 1, 1, 1, null);
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('Aeges', '1-1-0001', 1, 1, 1, null);
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('Henrique', '1-1-0001', 1, 1, 1, null);
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('Rei da Sinuca', '1-1-0001', 1, 1, 1, null);
INSERT INTO employees (name, birthday, role, sector, shift, supervisor) VALUES ('William 5 Galinhas', '1-1-0001', 1, 1, 1, null);
*/

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
