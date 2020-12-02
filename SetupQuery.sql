/*Script for creating tables.*/
/*Database name = IceDB*/

USE IceDB;

CREATE TABLE BusinessTypes (
	ID int IDENTITY(1,1) PRIMARY KEY,
	BusinessType varchar(50) NOT NULL
)

CREATE TABLE Customers (
	CustomerID int IDENTITY(1,1) PRIMARY KEY,
	CustomerName varchar(255) NOT NULL,
	StreetNumber int,
	StreetName varchar(50),
	City varchar(50),
	ZipCode int,
	BusinessType int FOREIGN KEY REFERENCES BusinessTypes(ID),
	Price float NOT NULL
)

INSERT INTO BusinessTypes VALUES('GAS STATION');
INSERT INTO BusinessTypes VALUES('GROCERY STORE');
INSERT INTO BusinessTypes VALUES('CAMPGROUND');
INSERT INTO BusinessTypes VALUES('OTHER');

CREATE TABLE Deliveries (
	DeliveryID int IDENTITY(1,1) PRIMARY KEY,
	CustomerID int FOREIGN KEY references Customers(CustomerID),
	NumberOfBags int NOT NULL,
	CustomerPaid varchar(50),
	DeliveryDate date
)

CREATE TABLE Orders (
	OrderID int IDENTITY(1,1) PRIMARY KEY,
	CustomerID int FOREIGN KEY references Customers(CustomerID),
	OrderDate date
)
