create database Desktop;
use Desktop;
create table userr(
user_idd int primary key identity ,
Username varchar(50),
pasword varchar(10),
age int,
Gender varchar(10) ,
phone_number varchar(11) unique,
city varchar(50)
);
select * from userr
insert into userr values (1,'m','M0$tafaa',17,'Male','01110093256','Sadat')
insert into userr values (2,'m','M0$tafaa',17,'Male','01110093256','Berlin')
create table adminn(
admin_id int primary key,
admin_username varchar(50),
admin_pass varchar(10)
);
select * from adminn