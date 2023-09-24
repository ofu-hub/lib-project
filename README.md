# SQL Code
## Поиск
```
SELECT p.name AS product, c.name AS category FROM Products AS p
LEFT JOIN ProdCat AS pc ON p.id = pc.products_id
INNER JOIN Category AS c ON c.id = pc.category_id
ORDER BY product;
```
## Создание БД
```
// Таблица продуктов
CREATE TABLE Products(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

// Таблица категорий
CREATE TABLE Category(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

// Связь идентификаторов
CREATE TABLE ProdCat(
products_id INT NOT NULL,
category_id INT NOT NULL,
FOREIGN KEY(products_id) REFERENCES Products(id) ON DELETE CASCADE,
FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE CASCADE);

// Создание уникальных индексов 
CREATE UNIQUE INDEX prod_cat ON ProdCat(products_id, category_id);
```
## Вставка в БД
```
INSERT INTO Products VALUES('Бумага'), ('Ножницы'), ('Ложка');
INSERT INTO Category VALUES('Канцелярия'), ('Столовые приборы');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 2);
```