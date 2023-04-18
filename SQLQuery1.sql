create database agrenda
use  agrenda

	create table Agenda(
	    Id int  IDENTITY(1,1),
		Nombre varchar(50),
		Apellido varchar(50),
		Fecha_Nacimiento Datetime,
		direccion varchar(50),
		Genero varchar(50),
		Estado_Civil varchar(50),
		Movil varchar(15),
		Telefono varchar(15),
		Correo_Electronico varchar(50)
	);

	





	


select * from Agenda
