use [Career180_DBD02]

--DDL --> Data Definition Language
create table Employee
(
	FName varchar(20) not null,
	MName varchar(20) null,
	LName varchar(20) not null,
	SSN int not null,
	BDate date not null,
	address varchar(60) null,
	sex varchar(6) not null,
	salary float(5),
)

alter table Employee
add constraint PK_Employee primary key (SSN)

alter table Employee
add superSSN int null

alter table Employee
add constraint FK_Employee foreign key (superSSN) 
references Employee (SSN)

create table Department
(
	Dname varchar(20) not null,
	Dnumber int not null,
	mgrSSN int not null,
	mgrStartDate date not null,
)

alter table Department
add constraint PK_Department primary key (dnumber)

alter table Department 
add constraint FK_Department foreign key (mgrSSN) references Employee(SSN)

alter table Employee
add DNO int not null

alter table Employee
add constraint FK_Employee_2 
foreign key (DNO)
references Department (Dnumber)

create table Dept_Locations
(
	Dnumber int not null,
	DLocation varchar(40) not null,
)

alter table Dept_Locations
add constraint PK_Dept_Locations primary key (Dnumber, DLocation)

alter table Dept_Locations
add constraint FK_Dept_Locations foreign key (Dnumber) references Department(Dnumber)

create table Project
(
	Pname varchar(20) not null,
	Pnumber int not null,
	PLocation varchar(40) not null,
	Dnumber int not null,
)

alter table Project
add constraint PK_Project primary key(Pnumber)

alter table Project
add constraint FK_Project foreign key(Dnumber) references Department(Dnumber)

create table Employee_Project
(
	ESSN int not null,
	PNO int not null,
	[Hours] tinyint not null,
	primary key (ESSN, PNO)
)

alter table Employee_Project
add constraint FK_Employee_Project foreign key (ESSN) references Employee (SSN)

alter table Employee_Project
add constraint FK_Employee_Project_2 foreign key (PNO) references Project (Pnumber)

create table Dependent
(
	ESSN int not null,
	Depndent_Name varchar(20) not null,
	sex varchar(6),
	Bdate date,
	relationship varchar(20),
	primary key (ESSN, Depndent_Name)
)

alter table [Dependent]
add constraint FK_Dependent foreign key (ESSN) references Employee (SSN)

alter table Employee
alter column dno int null

insert into Employee (FName, LName, SSN, BDate,[address], sex, salary, superssn)
values ('Mohamed', 'Aboushanab', 987324, '09-22-1994', 'Alex', 'Male', 14500, 987324),
('Alaa', 'Aly', 3498324, '09-22-1994', 'Cairo', 'Female', 14500, 3498324)

insert into Department 
values ('.NET', 10, 987324, '5-23-2023'), ('UI', 20, 3498324, '7-30-2023')

insert into Dept_Locations
values (10, 'Cairo'), (20, 'Alex')

insert into Project
values ('E-Commerece', 1, 'Confidential', 10), ('Clothing Store', 2, 'Alex', 20)

insert into Employee_Project
values (987324, 1, 40), (3498324, 2, 55)

insert into Dependent
values (987324, 'Gamal', 'male', '9-23-1984', 'brother'), 
		(3498324, 'Lamiaa', 'female', '5-20-1978', 'mother')


select * from Employee
select * from Department
select * from Dept_Locations
select * from Project
select * from Employee_Project
select * from Dependent