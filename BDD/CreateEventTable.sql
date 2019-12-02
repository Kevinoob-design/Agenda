use Agenda
go

create TABLE [Event]
(
	eventID int constraint pk_eventID_Event primary key identity(1,1),
	tittle  char(10),
	[location] char(50),
	starts datetime,
	ends   datetime, 
	[repeat] char(20), 
	invites int constraint default_invites_Event default 0,
	alert char(20)
)

alter table [Event]
add details char(500)
