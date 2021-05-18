--Section 5.1 Joining tables

USE BikeStore
GO

CREATE SCHEMA hr;
GO

CREATE TABLE hr.candidates
(
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	fullname VARCHAR(100) NOT null
)

CREATE TABLE hr.employees
(
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	fullname VARCHAR(100) NOT null
)

INSERT INTO 
    hr.candidates(fullname)
VALUES
    ('John Doe'),
    ('Lily Bush'),
    ('Peter Drucker'),
    ('Jane Doe');


INSERT INTO 
    hr.employees(fullname)
VALUES
    ('John Doe'),
    ('Jane Doe'),
    ('Michael Scott'),
    ('Jack Sparrow');

SELECT * FROM hr.candidates c
INNER JOIN hr.employees e ON e.fullname = c.fullname

SELECT * FROM hr.candidates c
LEFT JOIN hr.employees e ON c.fullname  = e.fullname

SELECT * FROM hr.candidates c
RIGHT JOIN hr.employees e ON c.fullname  = e.fullname

SELECT * FROM hr.candidates c
LEFT JOIN hr.employees e ON c.fullname  = e.fullname WHERE e.id IS NULL

SELECT * FROM hr.candidates c
RIGHT JOIN hr.employees e ON c.fullname  = e.fullname WHERE e.id IS NULL

SELECT * FROM hr.candidates c
FULL JOIN hr.employees e ON c.fullname = e.fullname

SELECT * FROM hr.candidates c
FULL JOIN hr.employees e ON c.fullname = e.fullname
WHERE e.id IS NULL OR c.id IS NULL