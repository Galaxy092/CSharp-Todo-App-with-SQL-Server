IF DB_ID('TodoList') IS NOT NULL
	DROP DATABASE TodoList

-- 1st run this
--Create Database
CREATE DATABASE TodoList
GO

--Use TodoList Database
USE TodoList
GO

-- 2nd run this
--Create Table
CREATE TABLE [dbo].[tb_TodoList]
(
	Id BigInt identity(1,1),
	Title varchar(100),
	Date datetime,
	completed varchar(1),
	[Description] varchar(max)
)

-- 3rd run this (create) and 4th change from (create) to (alter) 
alter procedure usp_TodoList
@id bigInt,
@title varchar(100),
@Date datetime,
@completed varchar(1),
@Description varchar(max),
@Mode varchar(10)
as
Begin
	--Insert Command
	if @Mode='ADD'
		Begin
			insert into tb_TodoList (title, [Date], completed, Description) 
			values(@title, @Date, @completed, @Description) 
		End
	if @Mode='UPDATE'
		Begin
			update tb_TodoList set completed='Y' where Id=@id
		End
	if @Mode='DELETE'
		Begin
			delete from tb_TodoList where Id=@id
		End
	if @Mode='VIEW'
		Begin
			SELECT * FROM tb_TodoList;
		End
End