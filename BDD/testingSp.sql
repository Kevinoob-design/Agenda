use Agenda
go

exec spSaveDataFromContacts 'asdasd', 'asdasd', 'asdasd', 'asdasd', 'asdasd', 'asdasd', 'asdasd', 'asdasd'

exec spUpdateDataFromContacts 4, 'as', 'asdasd', 'as', 'asdasd', 'as', 'asdasd', 'as', 'asdasd'

exec spBringDataFromContacts

exec spFilterDataFromContacts 'hec'

exec spDeleteDataFromContacts 1

delete from contacts where contactID = 10

exec spSaveDataFromEvent 'Testing this', 'Ovethere',  '2019-11-19 5:57am', 'Sunday Dec  1 2019  8:44PM', 'EveryWeek', 2, 'HourBefore', 'skasdbaksbd kabsdk jabsdk jbaskdjb aksjbd kajsbd'

select * from [Event]

select CONCAT(DATENAME(dw, getdate()), ' ', CONVERT(varchar, getdate(), 0))
select CONVERT(datetime, '2019-12-02 02:30:00.000', 0)

select CONVERT(date, 'Sunday, December, 1, 2019, 12:00pm')

select getdate() as dia



