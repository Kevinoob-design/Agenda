use Agenda
go

create proc spUpdateDataFromContacts
	
	@contactID		int,
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

UPDATE Contacts

SET 
[name] = @name, 
lastName = @lastName, 
homePhone = @homePhone, 
cellPhone = @cellPhone, 
workPhone = @workPhone,
email = @email,
workEmail = @workEmail,
anotations = @anotations,
street	= @street,
unit	= @unit,
sector	= @sector,
city	= @city,
country	= @country,
zip		= @zip	

WHERE contactID = @contactID;