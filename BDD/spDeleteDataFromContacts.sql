use Agenda
go

create proc spDeleteDataFromContacts
	
	@contactID int
AS

delete from Contacts where @contactID = contactID