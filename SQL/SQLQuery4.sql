--use LPU_Db;

Select * from StudentInfo;


--SP_help StudentInfo;


Create default DF_HomeTown
as 'Pune'
go


Insert into StudentInfo(RollNo, Name, Age, PerAddress) values(106, 'Suddi',21  , 'Khakra');

Update StudentInfo set Age = 24 where RollNo = 104;

Alter table StudentInfo
Add Constraint Chk_Age
Check(Age >= 18 AND Age<=60)


Exec sp_bindefault DF_HomeTown,
'Person.Address'


select * from Person;


INSERT INTO Person (Id, Name, Age, PhoneNumber)
VALUES
(1, 'Parth', 21, 7983916321),
(2, 'Absk', 21, 1234567890);

DELETE FROM Person
WHERE Id = 2;



Alter Table Person 
Add SocialStatus varchar(10);

Create rule SocialStatus_Rule
AS @SocialStatus IN ('un-Married', 'Married', 'Widow', 'Divorcee')
GO


Exec sp_bindrule SocialStatus_Rule,
'Person.SocialStatus'
	