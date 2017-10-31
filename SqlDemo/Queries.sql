--Get Employee From IT Department
select * from emp
where deptid=1

--Get all female candiadate name,address and department names

select emp.name [Employee Name],address [Address],dept.name [Department Name] from emp
join dept on emp.deptid=dept.id
where gender='F'

--Get employees whose salary greater than 150

select * from emp
where salary>=150

--Get employees where name starts with 's'
select * from emp where name like 's%'

--Get employees where charactes in name greater than 4
select * from emp where len(name) >4

--Get departmentwise count
select dept.name [Department Name],deptcount.[Count] from
(
select deptid, count(deptid) [Count]  from emp
group by deptid
) as deptcount
join dept on deptcount.deptid=dept.id

--Delete from department
delete from dept where id=4





/*

select * from emp
select * from dept

*/