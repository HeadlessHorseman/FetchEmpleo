drop database if exists proyectoFol;
create database if not exists proyectoFol;

use proyectoFol;

drop table if exists inscripcion;
drop table if exists oferta;
drop table if exists CV_CP;
drop table if exists demandante;
drop table if exists empresa;
drop table if exists administrador;
drop table if exists usuario;

create table usuario (
	login char(15) primary key,
	contrasena char(30) not null
);

create table administrador (
	id int primary key,
	login char(15),
	dni char(9) not null,
	nombre char(50) not null,
	apellidos char(50) not null,
	email char(50) not null,
	telefono char(9) default '\N',
	web char(50) default '\N',
	foreign key (login) references usuario(login) on update cascade
);

create table empresa (
	id int primary key,
	login char(15),
	cif char(20) not null,
	razonSocial char(50) not null,
	nombre char(50) not null,
	categoria char(50) not null,
	email char(50) not null,
	telefono char(9) default '\N',
	domicilio char(50) not null,
	localidad char(50) not null,
	web char(50) default '\N',
	logo varchar(255) default null,
	foreign key (login) references usuario(login) on update cascade
);

create table demandante (
	id int primary key,
	login char(15),
	dni char(9) not null,
	nombre char(50) not null,
	apellidos char(50) not null,
	discapacitado tinyint(1) not null,
	fechaNacimiento date not null,
	sexo enum('H', 'M'),
	domicilio char(100) default '\N',
	email char(50) not null,
	telefono char(9) default '\N',
	web char(50) default '\N',
	foreign key (login) references usuario(login) on update cascade
);

create table CV_CP (
	id int primary key,
	propietario int,
	tipo enum('CV', 'CP'),
	contenido blob,
	foreign key (propietario) references demandante (id) on update cascade
);

create table oferta (
	id int primary key,
	empresa int,
	titulo char(100) not null,
	requisitos varchar(5000) not null, -- Habría que ver si esto entra en la descripción, pero por ahora lo pongo
	descripcion varchar(15000) not null,
	discapacitado tinyint(1) not null,
	plazas int default null,
	foreign key (empresa) references empresa(id) on update cascade
);

create table inscripcion (
	numero int primary key,
	candidato int,
	oferta int,
	foreign key (candidato) references demandante(id) on update cascade,
	foreign key (oferta) references oferta(id) on update cascade
);


-- PRUEBAS 
insert into usuario values("heikki","usuario");
insert into usuario values("demandante","usuario");
insert into empresa values(1,'heikki',12345,'A','CicloHobby','B','email@gmail.com',654980523,'Portada Alta','Málaga','www.google.es','null');
insert into demandante values(2,'demandante','12345','Javier','Medinilla',1,'2000-01-01','M','Portada alta','email@email.com','66666666','www.google.com');