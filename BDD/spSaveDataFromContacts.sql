use Agenda
go

create proc spSaveDataFromContacts
	
	@name			varchar(15),
	@lastName		varchar(30),
	@homePhone		varchar(10),
	@cellPhone		varchar(10),
	@workPhone		varchar(10),
	@email			varchar(50),
	@workEmail		varchar(50),
	@anotations		varchar(max),
	@street			varchar(50),
	@unit			varchar(5),
	@sector			varchar(15),
	@city			varchar(15),
	@country		varchar(30),
	@zip			varchar(10)
AS

insert into Contacts
values
(@name, @lastName, @homePhone, @cellPhone, @workPhone, @email, @workEmail, @anotations, @street, @unit, @sector, @city, @country, @zip
)

--DBCC CHECKIDENT ('Contacts', RESEED, 1)