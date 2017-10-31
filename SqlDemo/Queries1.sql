--Get all employess order by highest salary
select * from emp order by salary desc
--Get row ids for each row
select row_number()  over (order by salary desc) [Number], * from emp
--Get Rank with gaps to employees salarywise
select rank()  over (order by salary desc) [Rank], * from emp
--Get Rank to employees salarywise
select dense_rank()  over (order by salary desc) [Rank], * from emp

--find out 2nd highest salary employeed
select min(salary) from emp
where salary in(select top 2 salary from emp order by salary desc)


with emps as(
select dense_rank()  over (order by salary desc) [Number], * from emp  
)
select salary from emps where number=2

-- find department wise salary rank
select dense_rank() over(partition by deptid order by salary desc),* from emp

--How to use transaction

begin tran mytran
declare @error int=0
--insert into dept(name) values('WFM') //Healthy call
--RAISERROR (15600,-1,-1, 'test error');  // error call
set IDENTITY_INSERT dept on
insert into dept(id,name) values(1,'testdata')
set @error=@@Error  --Save Error imediately after error code else it will loose its value
set IDENTITY_INSERT dept  off

if(@error<>0)
begin
rollback tran mytran
print 'transaction rollback'
end
else
begin
commit tran mytran
print 'transaction commit'
end


--How to insert and detect identity column
Go
set IDENTITY_INSERT dept on
insert into dept(id,name) values(8,'GAME')
set IDENTITY_INSERT dept  off

print @@identity --global scope
print scope_identity() -- query window scope
print IDENT_CURRENT('emp') --identity value only for given table
Go