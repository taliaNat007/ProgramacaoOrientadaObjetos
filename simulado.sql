Create database simulado;
use simulado;

create table Alunos(
Id_Aluno int primary key auto_increment ,
Nome varchar(100),
Cpf varchar(15) ,
Email varchar(150) ,
Telefone varchar(13) ,
Data_Nascimento date 
);
select * from Alunos;
drop table Alunos;
