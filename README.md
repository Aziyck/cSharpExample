use ExampleDataBase;

Create table Users(
	user_id Int PRIMARY KEY identity(1,1),
	user_name varchar(50),
	user_surname varchar(50)
);

select * from Users;
