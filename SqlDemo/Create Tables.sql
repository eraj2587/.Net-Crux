create table dept
(
id int identity (1,1),
name nvarchar(100),
primary key(id))
Go

create table emp
(
id int identity(1,1),
name nvarchar(50),
address nvarchar(250),
gender char(1),
salary money,
deptid int,
primary key (id),
foreign key (deptid) references dept(id)
on delete cascade
on update cascade)
Go
