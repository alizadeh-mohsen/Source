ALTER TABLE [dbo].[Unit] ADD Fixed bit not null default 0;
alter table [dbo].[Color] add Usage nvarchar(max) default '';
alter table [dbo].[Color] add Accuracy tinyint not  null default 0;
ALTER TABLE color ALTER COLUMN [LastUpdate] date;
/*
ALTER PROCEDURE [dbo].[SelectUnit]

AS
BEGIN
SELECT [ID]
      ,[Name],
	   Fixed
  FROM [Unit]
END;
ALTER PROCEDURE [dbo].[InsertUnit]
@name nvarchar(50),
@fixed bit
AS
BEGIN
	INSERT INTO [Unit] 
	([Name],[Fixed]) 
	VALUES    
	(@name,@fixed)
END;
ALTER PROCEDURE [dbo].[UpdateUnit]
@name nvarchar(50),
@fixed bit,
@id int
AS
BEGIN
UPDATE [Unit] 
   SET [Name] = @name,
		Fixed= @fixed

 WHERE id=@id
END;

USE [ColorDb]
GO
/****** Object:  StoredProcedure [dbo].[Search]    Script Date: 2/22/2021 10:23:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Search]
@carid int=NULL,
@typeid int=NULL,
@code varchar(50)=NULL,
@desc1 nvarchar(200)=NULL,
@desc2 nvarchar(200)=NULL,
@usage nvarchar(200)=NULL,
@date date=NULL


as 
BEGIN

IF @code='' SET @code=NULL
IF @desc1='' SET @desc1=NULL
IF @desc2='' SET @desc2=NULL
IF @typeid='' SET @typeid=NULL
IF @carid='' SET @carid=NULL
IF @usage='' SET @usage=NULL
IF @date='' SET @date=NULL

SELECT	
		Color.ID as ColorId,
		Color.Code as [Color Code],
		Car.Car as [Make/Company],
		ColorType.[Type] as [Color Type],
		Color.comment ,
		Color.usage,
		Color.LastUpdate
FROM    
		Color inner join 
		ColorType on color.ColorTypeID=ColorType.ID inner join 
		Car on Color.CarID=Car.ID 
WHERE	
			comment like COALESCE('%'+@desc1 +'%',comment)
			AND
			comment like COALESCE('%'+@desc2 +'%',comment)
			AND
			[Color].Code like COALESCE(@code+'%',[Color].Code)
			AND
			ColorTypeID=COALESCE(@typeid,ColorTypeID)
			AND
			CarID=COALESCE(@carid,CarID)
			AND
			usage like COALESCE('%'+@usage +'%',usage)
			/*AND
			LastUpdate>=COALESCE(@date,lastupdate)*/

Order By 
			Color.Code
END

*/