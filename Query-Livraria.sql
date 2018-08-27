create database livraria
go

use livraria
go

create table Livros(
	CdLivro int primary key identity,
	TituloLivro varchar(30) not null,
	SinopseLivro varchar(80) not null,
	AutorLivro varchar(30) not null
	)