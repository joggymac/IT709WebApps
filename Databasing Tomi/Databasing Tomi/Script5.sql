﻿DROP TABLE EMPLOYEE
DROP TABLE PROJECT
DROP TABLE CUSTOMER
DROP TABLE DEPT


CREATE TABLE EMPLOYEE (
 EmpNo INTEGER NOT NULL,
 EmpFirstName VARCHAR(20) NOT NULL,
 EmpLastName VARCHAR(20) NOT NULL,
 DeptNo CHAR(2) NULL);
INSERT INTO EMPLOYEE VALUES (25348, 'Matthew', 'Smith' ,'d3')
INSERT INTO EMPLOYEE VALUES (10102, 'Ann' , 'Jones' ,'d3')
INSERT INTO EMPLOYEE VALUES (18316, 'John' , 'Barrimore','d1')
INSERT INTO EMPLOYEE VALUES (29346, 'James' , 'James' ,'d2')
INSERT INTO EMPLOYEE VALUES ( 9031, 'Elsa' , 'Bertoni' ,'d2')
INSERT INTO EMPLOYEE VALUES ( 2581, 'Elke' , 'Hansel' ,'d2')
INSERT INTO EMPLOYEE VALUES (28559, 'Sybill' , 'Moser' ,'d1')
 ProjNo CHAR(2) DEFAULT 'p1',
 ProjName VARCHAR (15) NOT NULL,
 ProjBudget DECIMAL (12,2) NULL);
 CustNo INTEGER NOT NULL,
 CustGroup CHAR(3) NULL,
 CustLimit MONEY NULL,
 CHECK (CustGroup IN ('c1', 'c2', 'c10')),
 CHECK (CustLimit <= 10000.00));
 DeptNo CHAR(2) NOT NULL,
 DeptName VARCHAR(20) NOT NULL,
 DeptLoc VARCHAR(20) NOT NULL
 PRIMARY KEY (DeptNo));