use LPU_Db;

Select * from StudentInfo;

ALTER Table StudentInfo Add PhoneNo Varchar(10);
Alter Table StudentInfo Add SchoolName Varchar(10) default 'DPS';

Insert into StudentInfo(RollNo, Name, Age, LocalAddr, PerAddress, PhoneNo) values (103, 'Rahul',42, 'Pbt', 'Pbt', 7899552);



Create Table StudentMarks(
							srNo int identity(1000, 1), 
							RollNo int references dbo.StudentInfo(RollNo),
							Phy int Not Null,
							Chem int Not Null,
							Maths int Not Null,
							Total as (Phy+Chem+Maths),
							Perc as (Phy+Chem+Maths)/3
							);


insert into StudentMarks(RollNo, Phy, Chem, Maths) values (12209301, 65, 65, 75);

select * from StudentMarks;




														
				
							