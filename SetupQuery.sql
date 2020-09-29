/*Script for creating tables.*/
/*Database name = IceDB*/

USE IceDB;

CREATE TABLE Customers (
	CustomerID int IDENTITY(1,1) PRIMARY KEY,
	CustomerName varchar(255) NOT NULL,
	CustomerAddress varchar(255),
	Price float NOT NULL
)

CREATE TABLE BusinessTypes (
	ID int IDENTITY(1,1) PRIMARY KEY,
	BusinessType varchar(50) NOT NULL
)

ALTER TABLE Customers DROP COLUMN CustomerAddress;
ALTER TABLE Customers ADD StreetNumber int;
ALTER TABLE Customers ADD StreetName varchar(50);
ALTER TABLE Customers ADD City varchar(50);
ALTER TABLE Customers ADD ZipCode int;
ALTER TABLE Customers ADD BusinessType int;
ALTER TABLE Customers ADD FOREIGN KEY (BusinessType) REFERENCES BusinessTypes(ID);

INSERT INTO BusinessTypes VALUES('GAS STATION');
INSERT INTO BusinessTypes VALUES('GROCERY STORE');
INSERT INTO BusinessTypes VALUES('CAMPGROUND');
INSERT INTO BusinessTypes VALUES('OTHER');
