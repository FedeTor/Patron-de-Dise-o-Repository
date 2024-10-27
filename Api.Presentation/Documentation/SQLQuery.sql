CREATE DATABASE DBCrud;
GO

USE DBCrud;
GO

CREATE TABLE Product (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Columna Id auto incremental
    Name NVARCHAR(100) NOT NULL,       -- Columna Name con un l�mite de 100 caracteres
    Price DECIMAL(18, 2) NOT NULL      -- Columna Price con 18 d�gitos de precisi�n, 2 decimales
);
GO

---OPCIONAL: VERIFICAR SI LA TABLA SE CREO CORRECTAMENTE---
SELECT * FROM Product;
GO

select * from Product
