use Agenda
go

create proc spSaveDataFromEvent
	
	@tittle		char(10),
	@location	char(50),
	@starts		datetime,
	@ends		datetime, 
	@repeat		char(20), 
	@invites	int,
	@alert		char(20),
	@details char(500)
AS

insert into [Event]
values
(
	@tittle, @location, @starts, @ends, @repeat, @invites, @alert, @details
)