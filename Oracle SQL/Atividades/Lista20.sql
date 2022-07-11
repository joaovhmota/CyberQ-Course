CREATE TABLE borrows (
	client_name VARCHAR2(155),
	book VARCHAR2(155),
	borrow_date DATE,
	return_date DATE,
	total_to_pay NUMBER
);

CREATE OR REPLACE FUNCTION getPrice(borrow_date DATE, return_date DATE) RETURN NUMBER
IS 
	total NUMBER;
BEGIN
	SELECT TRUNC(return_date - borrow_date) INTO total FROM dual;
	RETURN total;
END;

CREATE OR REPLACE PROCEDURE addBorrow(client_name VARCHAR2, book VARCHAR2, borrow_date DATE, return_date DATE) AS
total_to_pay NUMBER;
BEGIN
	total_to_pay := getPrice(borrow_date, return_date);
	INSERT INTO borrows VALUES (client_name, book, borrow_date, return_date, total_to_pay);
END;

BEGIN addBorrow('Jo�o', 'One piece', '1-7-2022', SYSDATE); END;
BEGIN addBorrow('William', 'Como conversar com seu cachorro sobre homossexualidade e comunismo', '1-6-2022', SYSDATE); END;
BEGIN addBorrow('Henrique', 'Guia de mang�: Banco de dados', '10-7-2022', SYSDATE); END;
SELECT * FROM borrows;
