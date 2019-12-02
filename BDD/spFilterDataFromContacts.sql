use Agenda
go

create proc spFilterDataFromContacts

	@str varchar(50)

AS

select * from Contacts where [name] like CONCAT('%', @str, '%') or lastName like CONCAT('%', @str, '%')