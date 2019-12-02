use Agenda
go

create table Contacts(
	contactID	int constraint Constraint_contactID_PrimaryKey primary key identity(1,1),
	[name]		varchar(15),
	lastName	varchar(30),
	homePhone	varchar(10),
	cellPhone	varchar(10),
	workPhone	varchar(10),
	email		varchar(50),
	workEmail	varchar(50),
	anotations	varchar(max),

	street		varchar(50),
	unit		varchar(5),
	sector		varchar(15),
	city		varchar(15),
	country		varchar(30),
	zip			varchar(10),
)

