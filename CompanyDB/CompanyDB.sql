USE CompanyDB;
GO


--CREATE TABLE EMPLOYEE (
--    Ssn          CHAR(9)       NOT NULL,
--    Bdate        DATE,
--    Fname        VARCHAR(50),
--    Minit        CHAR(1),
--    Lname        VARCHAR(50),
--    Address      VARCHAR(100),
--    Sex          CHAR(1),
--    Salary       DECIMAL(10,2),
--    Depanumber   INT,
--    SuperviseSsn CHAR(9),
--    CONSTRAINT PK_EMPLOYEE PRIMARY KEY (Ssn)
--);

--CREATE TABLE DEPARTMENT (
--Depanumber INT NOT NULL,
--Depaname VARCHAR(50) NOT NULL,
--StartDate DATE,
--ManageSsn CHAR(9),
--CONSTRAINT PK_DEPARTMENT PRIMARY KEY (Depanumber)
--);

--CREATE TABLE LOCATION (
--Depanumber INT NOT NULL,
--Locations VARCHAR(50) NOT NULL,
--CONSTRAINT PK_LOCATION PRIMARY KEY (Depanumber, Locations)
--);

--CREATE TABLE PROJECT (
--Pnumber INT NOT NULL,
--Pname VARCHAR(50),
--Location VARCHAR(50),
--Depanumber INT,
--CONSTRAINT PK_PROJECT PRIMARY KEY (Pnumber)
--);

--CREATE TABLE DEPENDENT (
--Depename VARCHAR(50) NOT NULL,
--Sex CHAR(1),
--Birthday DATE,
--Relationship VARCHAR(30),
--Ssn CHAR(9) NOT NULL,
--CONSTRAINT PK_DEPENDENT PRIMARY KEY (Ssn, Depename)
--);

--CREATE TABLE WORK_ON(
--Ssn CHAR(9) NOT NULL,
--Pnumber INT NOT NULL,
--Hours DECIMAL(5,2),
--CONSTRAINT PK_WORK_ON PRIMARY KEY (Ssn, Pnumber)
--);
--GO

--ALTER TABLE EMPLOYEE
--    ADD CONSTRAINT FK_EMPLOYEE_DEPARTMENT
--        FOREIGN KEY (Depanumber) REFERENCES DEPARTMENT(Depanumber);

--ALTER TABLE EMPLOYEE
--    ADD CONSTRAINT FK_EMPLOYEE_SUPERVISOR
--        FOREIGN KEY (SuperviseSsn) REFERENCES EMPLOYEE(Ssn);

--ALTER TABLE DEPARTMENT
--    ADD CONSTRAINT FK_DEPARTMENT_MANAGER
--        FOREIGN KEY (ManageSsn) REFERENCES EMPLOYEE(Ssn);

--ALTER TABLE LOCATION
--    ADD CONSTRAINT FK_LOCATION_DEPARTMENT
--        FOREIGN KEY (Depanumber) REFERENCES DEPARTMENT (Depanumber);

--ALTER TABLE PROJECT
--    ADD CONSTRAINT FK_PROJECT_DEPARTMENT
--        FOREIGN KEY (Depanumber) REFERENCES DEPARTMENT(Depanumber);

--ALTER TABLE DEPENDENT
--    ADD CONSTRAINT FK_DEPENDENT_EMPLOYEE
--        FOREIGN KEY (Ssn) REFERENCES EMPLOYEE(Ssn);

--ALTER TABLE WORK_ON
--    ADD CONSTRAINT FK_WORK_ON_EMPLOYEE
--        FOREIGN KEY (Ssn) REFERENCES EMPLOYEE(Ssn);

--ALTER TABLE WORK_ON
--    ADD CONSTRAINT FK_WORK_ON_PROJECT
--        FOREIGN KEY (Pnumber) REFERENCES PROJECT(Pnumber);
--GO

--INSERT INTO DEPARTMENT (Depanumber, Depaname, StartDate, ManageSsn)
--VALUES
--    (1, 'Headquarters', '2020-01-01', NULL),
--    (2, 'Research',     '2021-06-15', NULL),
--    (3, 'Development',  '2022-03-10', NULL);

--INSERT INTO EMPLOYEE (Ssn, Bdate, Fname, Minit, Lname, Address, Sex, Salary, Depanumber, SuperviseSsn)
--VALUES
--    ('111111111', '1980-05-12', 'James', 'B', 'Borg',   'Muscat, Oman',  'M', 9000.00, 1, NULL),
--    ('222222222', '1988-09-30', 'Aisha', 'K', 'Said',   'Muscat, Oman',  'F', 6500.00, 2, '111111111'),
--    ('333333333', '1990-02-18', 'Omar',  'A', 'Habib',  'Sohar, Oman',   'M', 5500.00, 2, '222222222'),
--    ('444444444', '1992-11-05', 'Layla', 'M', 'Nasser', 'Salalah, Oman', 'F', 5000.00, 3, '111111111'),
--    ('555555555', '1995-07-22', 'Yusuf', 'S', 'Rashid', 'Nizwa, Oman',   'M', 4200.00, 3, '444444444');

--UPDATE DEPARTMENT SET ManageSsn = '111111111' WHERE Depanumber = 1;
--UPDATE DEPARTMENT SET ManageSsn = '222222222' WHERE Depanumber = 2;
--UPDATE DEPARTMENT SET ManageSsn = '444444444' WHERE Depanumber = 3;

--INSERT INTO LOCATION (Depanumber, Locations)
--VALUES (1, 'Muscat'), (2, 'Muscat'), (2, 'Sohar'), (3, 'Salalah');

--INSERT INTO PROJECT (Pnumber, Pname, Location, Depanumber)
--VALUES
--    (10, 'ProductX',    'Muscat',  2),
--    (20, 'ProductY',    'Sohar',   2),
--    (30, 'InternalWeb', 'Salalah', 3);

--INSERT INTO DEPENDENT (Depename, Sex, Birthday, Relationship, Ssn)
--VALUES
--    ('Sara', 'F', '2010-04-01', 'Daughter', '111111111'),
--    ('Ali',  'M', '2015-08-20', 'Son',      '222222222');

--INSERT INTO WORK_ON (Ssn, Pnumber, Hours)
--VALUES
--    ('333333333', 10, 20.00),
--    ('333333333', 20, 15.00),
--    ('444444444', 30, 30.00),
--    ('555555555', 30, 10.00);
--GO

UPDATE EMPLOYEE SET Salary = Salary + 500 WHERE Ssn = '333333333';
UPDATE EMPLOYEE SET Depanumber = 3 WHERE Ssn = '222222222';
UPDATE PROJECT SET Location = 'Muscat' WHERE Pnumber = 20;
UPDATE WORK_ON SET Hours = 25.00 WHERE Ssn = '333333333' AND Pnumber = 10;
UPDATE DEPENDENT SET Relationship = 'Stepdaughter' WHERE Ssn = '111111111' AND Depename = 'Sara';
GO