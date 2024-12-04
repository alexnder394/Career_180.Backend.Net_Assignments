use Company_SD
--1.	Display the Department id, name and id and the name of its manager.

select d.Dnum, d.Dname, e.SSN, e.Fname
from Departments d
join Employee e on e.SSN = d.MGRSSN


--2.	Display the name of the departments and the name of the projects under its control.
select d.Dname, p.Pname
from Departments d
join Project p on d.Dnum = p.Dnum

--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select CONCAT(e.Fname, ' ', e.Lname) as [Employee Name], d.*
from Dependent d
join Employee e on d.ESSN = e.SSN

--4.	Display the Id, name and location of the projects in Cairo or Alex city.

select p.Pnumber, p.Pname, p.Plocation
from Project p
where LOWER(p.City) = 'cairo' or LOWER(p.City) = 'alex'

--5.	Display the Projects full data of the projects with a name starts with "a" letter.

select *
from Project p
where p.Pname like 'a%'

--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly

select *
from Employee e
where e.Salary between 1001 and 1999 
	and e.Dno = 30

--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.

select CONCAT(e.Fname, ' ', e.Lname) as [Employee Name], 
	p.Pname as [Project Name], 
	w.Hours as [Working Hours]
from Employee e
join 
	Works_for w on w.ESSn = e.SSN
join 
	Project p on w.Pno = p.Pnumber
where e.Dno = 10 
	and w.Hours >= 10 
	and p.Pname = 'AL Rabwah'

--8.	Find the names of the employees who directly supervised with Kamel Mohamed.

select CONCAT(e.Fname, ' ', e.Lname) as [Employee Name], 
	CONCAT(super.Fname, ' ', super.Lname) as [Supervisor Name]
from Employee e
join Employee super on e.Superssn = super.SSN
where super.Fname = 'Kamel' and super.Lname = 'Mohamed'

--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.

select CONCAT(e.Fname, ' ', e.Lname) as [Employee Name],
	p.Pname as [Project Name]
from Employee e
join Works_for w on w.ESSn = e.SSN
join Project p on p.Pnumber = w.Pno
order by 
	p.Pname desc


--10.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.

select 
	p.Pname, 
	p.City, 
	p.Pnumber, 
	d.Dname, 
	e.Lname, 
	e.Address, 
	e.Bdate
from 
	project p
join	
	Departments d on p.Dnum = d.Dnum
join 
	Employee e on d.MGRSSN = e.SSN
where p.City = 'Cairo'

--11.	Display All Data of the mangers

select e.*
from 
	Departments d
join
	Employee e on d.MGRSSN = e.SSN

--12.	Display All Employees data and the data of their dependents even if they have no dependents

select *
from Employee e
left join Dependent d on d.ESSN = e.SSN