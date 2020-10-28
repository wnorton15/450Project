
USE IceDB;
/*
CREATE TABLE Users (
    UserID int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255),
    FirstName varchar(255),
    Username varchar(255),
    UserPassword varchar(255),
	Email varchar(255)
);


insert into Users (LastName, FirstName, Username, UserPassword, Email)
values ('pankow', 'liam', 'pankow602', '1337', 'zzrhydonzz1@gmail.com');
*/

select * from Users where Username = 'pankow602'