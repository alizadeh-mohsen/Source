alter table [dbo].[Color] add Usage nvarchar(max);
alter table [dbo].[Color] add Accuracy tinyint not  null default 0;
ALTER TABLE color ALTER COLUMN [LastUpdate] date;
update [ColorDb].[dbo].[Color]
set LastUpdate =  '01-01-1900'
where LastUpdate is null;

USE [ColorDb]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SelectUnit]

AS
BEGIN
SELECT [ID]
      ,[Name]
	   
  FROM [Unit]
END;
GO
ALTER PROCEDURE [dbo].[InsertUnit]
@name nvarchar(50)

AS
BEGIN
	INSERT INTO [Unit] 
	([Name]) 
	VALUES    
	(@name)
END;
GO
ALTER PROCEDURE [dbo].[UpdateUnit]
@name nvarchar(50),
@id int
AS
BEGIN
UPDATE [Unit] 
   SET [Name] = @name

 WHERE id=@id
END;
GO
USE [ColorDb]
GO
/****** Object:  StoredProcedure [dbo].[Search]    Script Date: 2/23/2021 11:52:14 AM ******/
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
		Color.comment Comment ,
		Color.usage Usage,
		case Color.LastUpdate when '01-01-1900' then null
		else Color.LastUpdate 
		end LastUpdate
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
			(@usage is null or usage like '%'+@usage +'%')
			AND
			LastUpdate=COALESCE(@date,lastupdate)

Order By 
			Color.Code
END


GO

USE [ColorDb]
GO
/****** Object:  StoredProcedure [dbo].[GetCodeInfo]    Script Date: 2/23/2021 4:53:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[GetCodeInfo] 
@colorId int
as
begin
SELECT  
		C.ID,
		C.CarID,
		C.ColorTypeID,
		C.Code,
		C.Comment,
		C.lock,
		case C.LastUpdate when '01-01-1900' then null
		else C.LastUpdate 
		end LastUpdate,
		C.UnitId,
		Car.Car,
		CT.[Type],
		U.[Name],
		
		c.Accuracy,
		c.Usage
FROM         
		Color C INNER JOIN
        Car ON C.CarID = Car.ID inner join 
		ColorType CT on C.ColorTypeID=CT.ID inner join
		Unit u on u.ID=C.UnitId
WHERE     
		C.ID = @colorId;

SELECT	F.ID as formulId,
		F.[Weight],
	    B.ID as baseId,
		B.Code
				
FROM    Formul F INNER JOIN
        BaseColor B ON F.BaseID = B.ID INNER JOIN
		Color C ON C.ID=F.ColorID
WHERE 
		F.ColorID=@ColorID
end

GO

ALTER PROCEDURE [dbo].[UpdateColor]
@ColorID int,
@carid int,
@ColorTypeID int,
@Code nvarchar(50),
@comment nvarchar(max),
@LastUpdate datetime =null,
@lock bit,
@UnitId int,
@usage nvarchar(max),
@accuracy tinyint

AS
BEGIN


UPDATE [Color]
   SET 
	   [CarID] = @carid
      ,[ColorTypeID] = @ColorTypeID
      ,[Code] = @Code
      ,[Comment] = @Comment
      ,[lock] = @lock
      ,[LastUpdate] = @LastUpdate
      ,[UnitId] = @UnitId
	  ,Usage=@usage
	  ,Accuracy	=@accuracy

 WHERE id=@ColorID
 
END

GO

--
-- Definition for stored procedure InsertColor : 
--

ALTER PROCEDURE [dbo].[InsertColor]
@carid int,
@typeid int,
@code nvarchar(50),
@comment nvarchar(4000),
@UnitId int,
@usage nvarchar(max),
@newid int output

as 
begin
INSERT INTO [Color]
       ([CarID],[ColorTypeID],[Code],[Comment],[lock],[LastUpdate],[UnitId],usage)
     VALUES
       (@CarID,@typeid,@Code,@Comment,0,GETDATE(),@UnitId,@usage)
set @newid=scope_identity()
end


