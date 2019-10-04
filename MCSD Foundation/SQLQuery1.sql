CREATE DATABASE MORGAN_BAY_PARADICE_RESORT;

CREATE TABLE Employee(

Emp_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Emp_Name varchar(30),
Emp_Address varchar(50),
Emp_Email varchar(40),
Emp_Num INT);

CREATE TABLE Rooms(
Room_Num INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Floor_Num INT,
Room_Description varchar(100) NOT NULL);


CREATE TABLE Customer(

Cust_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Cust_Name varchar(30),
Cust_Address varchar(50),
Cust_Email varchar(40),
Cust_Num INT);

CREATE TABLE Booking(

Booking_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Booking_Date varchar(30),
Cust_ID INT FOREIGN KEY REFERENCES Customer(Cust_ID),
Room_Num INT FOREIGN KEY REFERENCES Rooms(Room_Num));

CREATE TABLE Payment(

Payment_ID INT PRIMARY KEY NOT NULL,
Payment_Type varchar(20),
Payment_Date varchar(20),
Payment_Amount DECIMAL (18, 2),
Booking_ID INT FOREIGN KEY REFERENCES Booking(Booking_ID));




			    

