use LPU_Db;


Create Table Dummy(
	dummyID uniqueIdentifier,
	name varchar(15)
	);

Select * from Dummy;


insert into Dummy(name) values('Parth');

insert into Dummy(name) values('Alok');

insert into Dummy(name) values('Ajay');


create type Address from Varchar(50) Not Null;

Drop table Dummy;

Select * from Dummy;


Create Table StudentInfo (RollNo int Primary Key,
							Name varchar(15) Not Null,
							Age smallint not Null,
							LocalAddr Address,
							PerAddress Address);


Insert into StudentInfo(Name, Age, PerAddress, LocalAddr, RollNo) values
																	('Parth Sharma', 21, 'Jama MasJid', 'LPU', '12209301');


Insert into StudentInfo(Name, Age, PerAddress, LocalAddr, RollNo) values
																	('Megha Thakur', 21, 'Hmairpur', 'LPU', '12209302');



select * from StudentInfo;

