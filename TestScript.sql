insert into Reactions (description) values ('love'), ('haha'), ('wow'), ('sad'), ('angry');
insert into UserTypes (name) values ('Administrador'), ('Agente');
insert into Users (name, lastName, email, username, password, creationDate, country, active, FK_userType)
	values ('Maria', 'Rojas', 'mrojas@test.com', 'mrojas', 'Pernix123.', GETDATE(), 'Costa Rica', 1, 1),
		   ('Juan', 'Perez', 'jperez@test.com', 'jperez', 'Pernix123.', GETDATE(), 'Costa Rica', 1, 2);
insert into ClientTypes (name, hasProducts) values ('Doctor', 1), ('Farmacia', 0), ('Doctor extra', 1), ('Farmacia extra', 0);
insert into Adoptions (name) values ('A'), ('B'), ('C');
insert into Potentials (name) values ('Leal'), ('Probador'), ('Conocedor'), ('Usuario'); 

insert into Clients (name, lastName, maxNumVisits, creationDate, country, email, active, FK_clientType, FK_user, FK_potential, FK_adoption, latitude, longitude)
	values ('Rodrigo', 'Hernandez', 2, GETDATE(), 'Costa Rica', 'rhernandez@test.com', 1, 1, 2, 1, 1, 9.86223, -83.92296),
		   ('Farmacia', 'Fishel', 2, GETDATE(), 'Costa Rica', 'ffishel@test.com', 1, 2, 2, 1, 1, 9.86223, -83.92296);
insert into VisitTypes (name) values ('Gira'), ('Ciudad');
insert into Visits (FK_client, FK_reaction, comment, date, FK_visitType)
	values (1, 1, 'Comment sample', GETDATE(), 1),
		   (2, 3, 'Comment sample', GETDATE(), 2);
insert into Products (name) values ('Acetaminofen'), ('Paracetamol');

insert into Questions (question) values ('Calidad del servicio'), ('Atención del agente'), ('Satisfacción');

insert into Options (description, FK_question) values 
					('Excelente',1), ('Bueno',1), ('Regular',1), ('Malo',1),
					('Excelente',2), ('Bueno',2), ('Regular',2), ('Malo',2),
					('Excelente',3), ('Bueno',3), ('Regular',3), ('Malo',3)
