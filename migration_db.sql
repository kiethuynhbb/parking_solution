IF OBJECT_ID ('dbo.Vehicle') IS NOT NULL
	DROP TABLE dbo.Vehicle
GO

CREATE TABLE dbo.Vehicle
	(
	Id           INT IDENTITY NOT NULL,
	Type         INT NULL,
	Name         NVARCHAR (50) NULL,
	Brand        NVARCHAR (50) NULL,
	LicenseNo    NVARCHAR (20) NULL,
	ProvidedDate DATE NULL,
	ProvidedBy   INT NULL,
	DeleteOn     DATE NULL,
	CONSTRAINT PK_Vehicle PRIMARY KEY (Id)
	)
GO

IF OBJECT_ID ('dbo.[Level]') IS NOT NULL
	DROP TABLE dbo.[Level]
GO

CREATE TABLE dbo.[Level]
	(
	Id      INT IDENTITY NOT NULL,
	LevelNo INT NULL,
	CONSTRAINT PK_Level PRIMARY KEY (Id)
	)
GO

IF OBJECT_ID ('dbo.Capacity') IS NOT NULL
	DROP TABLE dbo.Capacity
GO

CREATE TABLE dbo.Capacity
	(
	Id       INT IDENTITY NOT NULL,
	Amount   INT NULL,
	LevelId  INT NULL,
	InActive BIT NULL,
	CONSTRAINT PK_Capacity PRIMARY KEY (Id)
	)
GO

IF OBJECT_ID ('dbo.Parking') IS NOT NULL
	DROP TABLE dbo.Parking
GO

CREATE TABLE dbo.Parking
	(
	Id        INT IDENTITY NOT NULL,
	LevelId   INT NOT NULL,
	VehicleId INT NOT NULL,
	CardNo    INT NOT NULL,
	FromDate  DATE NOT NULL,
	EndDate   DATE NULL,
	CONSTRAINT PK_Parking PRIMARY KEY (Id)
	)
GO


