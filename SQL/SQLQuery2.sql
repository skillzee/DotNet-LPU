use LPU_Db;


declare @num1 as int
set @num1=100;

declare @num2 as int
set @num2=200;

declare @numResult as int
set @numResult=@num1+@num2;
print 'The sum of '+cast(@num1 as varchar)+' and ' + cast(@num2 as varchar) + ' is ' + cast(@numResult as varchar)

