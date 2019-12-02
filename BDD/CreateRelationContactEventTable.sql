use Agenda
go

CREATE TABLE RelationContactEvent
(
	contactID int constraint fk_ContactID_RelationContactEvent foreign key (contactID) references Contacts(ContactID),
	eventID int constraint fk_EventID_RelationContactEvent foreign key (eventID) references [Event](EventID),
	relationID int constraint compositePk_RelationID_RelationContactEvent primary key (contactID, eventID)
)