# projectVP

# sql code for the database and the data in departments 

use master ;
create database examvp ;

use examvp ;

create table employee (
id  int  identity(1,1) primary key ,
employee_name varchar(50),
employee_ssn varchar(12) unique , 
employee_dp varchar(50) ,
employee_dob date ,
);

create table departments(
id  int  identity(1,1) primary key ,
dp_name varchar(50),
);



inser into departments values('Networks');
inser into departments values('programmnig');   
inser into departments values('R&D');
inser into departments values('tec-support');


##just make sure to change the name of the sql server in sql connection in the shared functions 
