use SFE;

insert into Reactions (description) values ('love'), ('haha'), ('wow'), ('sad'), ('angry');

select * from Reactions;

insert into UserTypes (name) values ('Administrator'), ('Agent');

select * from UserTypes;

insert into Users (name, lastName, email, username, password, creationDate, country, active, FK_userType)
	values ('Maria', 'Rojas', 'mrojas@test.com', 'mrojas', 'Pernix123.', GETDATE(), 'Costa Rica', 1, 1),
		   ('Juan', 'Perez', 'jperez@test.com', 'jperez', 'Pernix123.', GETDATE(), 'Costa Rica', 1, 2);

select * from Users;

insert into ClientTypes (name) values ('Doctor'), ('Pharmacy'), ('Extra Doctor'), ('Extra Pharmacy');

select * from ClientTypes;

insert into Clients (name, lastName, maxNumVisits, creationDate, country, email, active, FK_clientType, FK_user)
	values ('Rodrigo', 'Hernandez', 2, GETDATE(), 'Costa Rica', 'rhernandez@test.com', 1, 1, 2),
		   ('Farmacia', 'Fishel', 2, GETDATE(), 'Costa Rica', 'ffishel@test.com', 1, 2, 2);

select * from Clients;

insert into Visits (FK_user, FK_client, FK_reaction, comment, date)
	values (2, 1, 1, 'Comment sample', GETDATE()),
		   (2, 2, 3, 'Comment sample', GETDATE());

select * from Visits;

insert into Products (name) values ('Acetaminophen'), ('Codeine');

select * from Products;



