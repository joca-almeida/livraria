create database livraria
go

use livraria
go

create table Livros(
	CdLivro int primary key identity,
	TituloLivro varchar(80) not null,
	SinopseLivro varchar(150) not null,
	AutorLivro varchar(80) not null
	)