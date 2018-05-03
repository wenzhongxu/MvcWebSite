create database MVCDB;
use MVCDB;

CREATE TABLE SysSample
(
Id varchar(50) not null constraint PK__SysSampl primary key,
Name varchar(50) null,
Age int NULL,
Bir datetime NULL,
Photo varchar(50) NULL,
Note text NULL,
CreateTime datetime NULL
)