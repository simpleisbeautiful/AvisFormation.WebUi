

CREATE TABLE dbo.Personne
	(
	UserId NVARCHAR (128) NOT NULL,
	Nom    VARCHAR (50) NOT NULL,
	PRIMARY KEY (UserId)
	)
GO




CREATE TABLE dbo.Formation
	(
	Id          INT IDENTITY NOT NULL,
	Nom         VARCHAR (100) NOT NULL,
	Url         VARCHAR (500),
	Description VARCHAR (1000) NOT NULL,
	NomSeo      VARCHAR (100),
	PRIMARY KEY (Id)
	)
GO




CREATE TABLE dbo.Avis
	(
	Id          INT IDENTITY NOT NULL,
	Nom         VARCHAR (100) NOT NULL,
	Description VARCHAR (500),
	Note        FLOAT NOT NULL,
	IdFormation INT NOT NULL,
	DateAvis    DATETIME2 NOT NULL,
	UserId      NVARCHAR (128) NOT NULL,
	PRIMARY KEY (Id),
	CONSTRAINT FK__Avis__IdFormatio__15502E78 FOREIGN KEY (IdFormation) REFERENCES dbo.Formation (Id)
	)
GO
