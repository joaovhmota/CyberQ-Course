-- Tables
CREATE TABLE products (
	product_id INTEGER,
	product_name VARCHAR2(155),
	product_price NUMBER
);

CREATE TABLE stores (
	store_id INTEGER,
	store_name VARCHAR2(155),
	store_city VARCHAR2(155)
);

CREATE TABLE clients (
	client_id INTEGER,
	client_name VARCHAR2(155)
);

CREATE TABLE status (
	clients_amount INTEGER,
	stores_amount INTEGER,
	products_amount INTEGER,
	lastUpdate DATE
);

-- Sequences
CREATE SEQUENCE sq_products MINVALUE 1 START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE sq_stores MINVALUE 1 START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE sq_clients MINVALUE 1 START WITH 1 INCREMENT BY 1;

-- Auto increments
CREATE OR REPLACE TRIGGER products_auto_increment BEFORE INSERT ON products FOR EACH ROW
BEGIN
	:new.product_id := sq_products.nextval;
END;

CREATE OR REPLACE TRIGGER stores_auto_increment BEFORE INSERT ON stores FOR EACH ROW
BEGIN
	:new.store_id := sq_stores.nextval;
END;

CREATE OR REPLACE TRIGGER clients_auto_increment BEFORE INSERT ON clients FOR EACH ROW
BEGIN
	:new.client_id := sq_clients.nextval;
END;


-- Procedures
CREATE OR REPLACE PROCEDURE printLog(message IN VARCHAR2) AS
BEGIN
	dbms_output.put_line(message);
END;

CREATE OR REPLACE PROCEDURE doesProductExists(target IN VARCHAR2, has OUT INTEGER) AS
BEGIN
	SELECT COUNT(*) INTO has FROM products WHERE product_name = target;
END;

CREATE OR REPLACE PROCEDURE doesStoreExists(target IN VARCHAR2, has OUT INTEGER) AS
BEGIN
	SELECT COUNT(*) INTO has FROM stores WHERE store_name = target;
END;

CREATE OR REPLACE PROCEDURE doesClientExists(target IN VARCHAR2, has OUT INTEGER) AS
BEGIN
	SELECT COUNT(*) INTO has FROM clients WHERE client_name = target;
END;

CREATE OR REPLACE PROCEDURE registerProduct(input_name IN VARCHAR2, input_price IN NUMBER) AS 
has INTEGER;
BEGIN
	doesProductExists(input_name, has);
	printLog(has);
	IF has <> 0 THEN
		printLog('Produto já existe no banco');
	ELSE
		INSERT INTO products (product_name, product_price) VALUES (input_name, input_price);
	END IF;
END;

CREATE OR REPLACE PROCEDURE registerStore(input_name IN VARCHAR2, input_city IN VARCHAR2) AS 
has INTEGER;
BEGIN
	doesStoreExists(input_name, has);
	printLog(has);
	IF has <> 0 THEN
		printLog('Loja já existe no banco');
	ELSE
		INSERT INTO stores (store_name, store_city) VALUES (input_name, input_city);
	END IF;
END;

CREATE OR REPLACE PROCEDURE registerClient(input_name IN VARCHAR2) AS 
has INTEGER;
BEGIN
	doesClientExists(input_name, has);
	printLog(has);
	IF has <> 0 THEN
		printLog('Cliente já existe no banco');
	ELSE
		INSERT INTO clients (client_name) VALUES (input_name);
	END IF;
END;

CREATE OR REPLACE PROCEDURE getClientsAmount(quant IN OUT INTEGER) AS
BEGIN
	SELECT COUNT(*) INTO quant FROM clients;
END;

CREATE OR REPLACE PROCEDURE getStoresAmount(quant IN OUT INTEGER) AS
BEGIN
	SELECT COUNT(*) INTO quant FROM stores;
END;

CREATE OR REPLACE PROCEDURE getProductsAmount(quant IN OUT INTEGER) AS
BEGIN
	SELECT COUNT(*) INTO quant FROM products;
END;

CREATE OR REPLACE PROCEDURE updateStatusTable AS
quant_clients INTEGER;
quant_stores INTEGER;
quant_products INTEGER;
BEGIN

    quant_clients := 0;
    quant_stores := 0;
    quant_products := 0;

	getClientsAmount(quant_clients);
    getStoresAmount(quant_stores);
    getProductsAmount(quant_products);
    
    INSERT INTO status VALUES (quant_clients, quant_stores, quant_products, SYSDATE);
END;

-- Main
BEGIN registerProduct('Pão de Mamão', 9999999); END;
BEGIN registerProduct('Mamão de pão', 9); END;
BEGIN registerProduct('Willliam', 100000000000000000); END;
SELECT * FROM products;

BEGIN registerStore('Alles Store', 'Pomerode'); END;
BEGIN registerStore('百万円だけ屋', '東京'); END;
BEGIN registerStore('Allesnt Store', 'Blumenau'); END;
SELECT * FROM stores;

BEGIN registerClient('João'); END;
BEGIN registerClient('Henrique'); END;
BEGIN registerClient('Wesley'); END;
SELECT * FROM clients;

BEGIN updateStatusTable(); END;
SELECT * FROM status;
