CREATE TABLE dbo.LemonadeStand
(
LemonadeStandID int IDENTITY (1,1) PRIMARY KEY,
name varchar(50) NOT NULL,
moneyOfPerson float,
dayOfGame int,
lemons float,
ice float,
sugar float,
cups float,
);
