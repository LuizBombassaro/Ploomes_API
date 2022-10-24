# Ploomes_API
 Teste prático para a empresa Ploomes - API

DATABASE - SQL

SQL:
==============================================================
Todas as incontáveis tabelas desta API

create table Pessoa(
	Id int not null identity(1,1),
	Nome varchar(80),
	Email varchar(80)
)

==================Valores base para dar GET================
Insert into Pessoa(Nome, Email) Values ('Luiz Bombassaro', 'Luiz.Bombassaro@outlook.com')
Insert into Pessoa(Nome, Email) Values ('Vinicius Bueno, 'Vinicius.bueno@ploomes.com')

===================================================================
StoredProcedure no banco para dar um Get pessoas

use PloomesAPI
Go

create procedure GetPessoas
as 
	set nocount on
	select A.Nome, A.Email
	from Pessoa A
go
===================================================================
StoredProcedure no banco para dar um Post

use PloomesAPI
Go

create procedure PostPessoas(@NOME Varchar(80),@EMAIL Varchar(80))
as 
	set nocount on

	Insert into Pessoa
	(
		Nome,
		Email
	)
	Values
	(
		@NOME,
		@EMAIL
	)
go
