CREATE TABLE C_Department(
DepID VARCHAR(5) PRIMARY KEY,
DepName VARCHAR(20) NOT NULL);
CREATE TABLE C_Employee(
EmpID VARCHAR(5) PRIMARY KEY,
LastName VARCHAR(20) NOT NULL,
FirstName VARCHAR(20),
HourlyRate MONEY NOT NULL,
HoursWorked INT NOT NULL,
DepID VARCHAR(5) NOT NULL REFERENCES C_Department(DepID));


BEGIN TRANSACTION;
INSERT INTO C_Department VALUES('DP001', 'Sales');
INSERT INTO C_Department VALUES('DP002', 'Warehouse');
INSERT INTO C_Department VALUES('DP003', 'Finance');
INSERT INTO C_Department VALUES('DP004', 'Marketing');
INSERT INTO C_Department VALUES('DP005', 'Purchasing');
INSERT INTO C_Employee VALUES('E0001', 'Jones', 'Sally', 15.50, 40, 'DP001');
INSERT INTO C_Employee VALUES('E0002', 'James', 'Sonia', 16.50, 38, 'DP001');
INSERT INTO C_Employee VALUES('E0003', 'Hall', 'Adam', 14.50, 44, 'DP001');
INSERT INTO C_Employee VALUES('E0004', 'Smith', 'Sarah', 15.50, 40, 'DP002');
INSERT INTO C_Employee VALUES('E0005', 'Parker','Fred', 16.50, 40, 'DP002');
INSERT INTO C_Employee VALUES('E0006', 'Harris','Paul', 14.50, 42, 'DP002');
INSERT INTO C_Employee VALUES('E0007', 'Smith', 'Fred', 17.50, 39, 'DP003');
INSERT INTO C_Employee VALUES('E0008', 'Parkes','Paul', 15.50, 46, 'DP003');
INSERT INTO C_Employee VALUES('E0009', 'Burns', 'John', 18.50, 41, 'DP003');
INSERT INTO C_Employee VALUES('E0010', 'Green', 'Jack', 18.50, 40, 'DP004');
COMMIT TRANSACTION;