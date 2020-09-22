/*Script for creating tables.*/
/*Database name = IceDB*/

USE IceDB;

CREATE TABLE Customers (
	CustomerID int IDENTITY(1,1) PRIMARY KEY,
	CustomerName varchar(255) NOT NULL,
	CustomerAddress varchar(255),
	Price float NOT NULL
)