CREATE TABLE Products
(
	[ID] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] NCHAR(30)
);
INSERT INTO Products VALUES 
	('Product1'),
	('Product2'),
	('Product3');
CREATE TABLE Categories
(
	[ID] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] NCHAR(30)
);
INSERT INTO Categories VALUES 
	('Category1'),
	('Category2'),
	('Category3');

CREATE TABLE ProductsAndCategories
(
	[ID] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[ProductID] INT FOREIGN KEY REFERENCES Products(ID),
	[CategoryID] INT FOREIGN KEY REFERENCES Categories(ID)
);

INSERT INTO ProductsAndCategories VALUES 
	(1,2),
	(2,1),
	(2,3);

SELECT Products.[Name] AS 'Имя продукта', Categories.[Name] AS 'Имя категории' FROM Products 
JOIN
	ProductsAndCategories ON Products.ID = ProductsAndCategories.ProductID
JOIN 
	Categories ON Categories.ID = ProductsAndCategories.CategoryID;
