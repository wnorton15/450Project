
USE IceDB;

CREATE TABLE Users (
    Username varchar(50) PRIMARY KEY,
    FirstName varchar(50) NOT NULL,
    LastName varchar(50) NOT NULL,
    Email varchar(50) NOT NULL,
    Password varchar(50) NOT NULL,
);

insert into Users (LastName, FirstName, Username, Password, Email)
values ('pankow', 'liam', 'pankow602', '1337', 'zzrhydonzz1@gmail.com');

select * from Users where Username = 'pankow602'