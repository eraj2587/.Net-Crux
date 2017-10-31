-------------------------------------------------------------------------------------------------
--TEMP TABLES
-------------------------------------------------------------------------------------------------

--Create temp backup of emp table 
--Both got created in tempdb
select * into #mytable from emp --create temp table with data in it
select * into ##myglobalTable from emp --global table
select * from ##myglobalTable -- available in all sessions of current user/ query window
select * from #mytable -- available only for current query window

-------------------------------------------------------------------------------------------------
--CTE (COMMON TABLE EXPRESSIONS)
-------------------------------------------------------------------------------------------------

with cte(id,name) as(
select id,name from emp
)
select id,name from cte
print 'Table created'

-------------------------------------------------------------------------------------------------
--TABLE VARIABLES
-------------------------------------------------------------------------------------------------
Go
declare @mytable table ( id int, name nvarchar(100))
insert  into @mytable select id,name from emp
print 'data added'
select * from @mytable
Go
-------------------------------------------------------------------------------------------------
--CREATE USER DEFINED TYPE
-------------------------------------------------------------------------------------------------
Go
Create Type myType as Table(
id int, name nvarchar(100)
)

declare @mytable as myType
insert  into @mytable select id,name from emp
print 'data added'
select * from @mytable
