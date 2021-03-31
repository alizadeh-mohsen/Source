USE [colordb]
GO
/****** Object:  StoredProcedure [dbo].[Search]    Script Date: 3/30/2021 6:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [Search]
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
		end LastUpdate,
		unit.Name as Unit
FROM    
		Color inner join 
		ColorType on color.ColorTypeID=ColorType.ID inner join 
		Car on Color.CarID=Car.ID inner join
		unit on color.UnitId=unit.id
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


CREATE PROCEDURE GetColorUnits
@colorCode nvarchar(50)
as
begin
SELECT  
		u.*
FROM         
		Color C INNER JOIN
		Unit u on u.ID=C.UnitId
WHERE     
		C.Code = @colorCode
END


GO


CREATE PROCEDURE GetCodeInfoByUnitId
@code nvarchar(50),
@unitId int
as 
begin
SELECT	F.ID as formulId,
		F.[Weight],
	    B.ID as baseId,
		B.Code
				
FROM    Formul F INNER JOIN
        BaseColor B ON F.BaseID = B.ID INNER JOIN
		Color C ON C.ID=F.ColorID
WHERE 
		c.Code=@code
		AND
		c.UnitId=@unitId
end

GO
CREATE TABLE Base(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Base] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
create PROCEDURE [InsertBase]
@name nvarchar(50)

AS
BEGIN
	INSERT INTO Base 
	([Name]) 
	VALUES    
	(@name)
END;


GO
create PROCEDURE [DeleteBase]
@id int
AS
BEGIN
	delete from Base where id=@id
END

GO

create PROCEDURE [SelectBase]

AS
BEGIN
SELECT [ID]
      ,[Name]
	   
  FROM Base
END;

go
CREATE PROCEDURE UpdateBase
@name nvarchar(50),
@id int
AS
BEGIN
UPDATE Base 
   SET [Name] = @name

 WHERE id=@id
END;

go
alter table [Color] add BaseId int;
go
ALTER TABLE [Color]  WITH CHECK ADD  CONSTRAINT [FK_Color_Base] FOREIGN KEY([BaseId])
REFERENCES [Base] ([ID])
GO

ALTER TABLE [Color] CHECK CONSTRAINT [FK_Color_Base]
GO

ALTER PROCEDURE [InsertColor]
@carid int,
@typeid int,
@code nvarchar(50),
@comment nvarchar(4000),
@UnitId int,
@BaseId int,
@usage nvarchar(max),
@newid int output

as 
begin
INSERT INTO [Color]
       ([CarID],[ColorTypeID],[Code],[Comment],[lock],[LastUpdate],[UnitId],usage,BaseId)
     VALUES
       (@CarID,@typeid,@Code,@Comment,0,GETDATE(),@UnitId,@usage,@BaseId)
set @newid=scope_identity()
end
GO
ALTER PROCEDURE [GetCodeInfo] 
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
		c.Usage,
		b.Name baseName
FROM         
		Color C INNER JOIN
        Car ON C.CarID = Car.ID inner join 
		ColorType CT on C.ColorTypeID=CT.ID inner join
		Unit u on u.ID=C.UnitId left join
		Base b on b.ID=c.BaseId
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

ALTER PROCEDURE [UpdateColor]
@ColorID int,
@carid int,
@ColorTypeID int,
@Code nvarchar(50),
@comment nvarchar(max),
@LastUpdate datetime =null,
@lock bit,
@UnitId int,
@usage nvarchar(max),
@accuracy tinyint,
@baseId int

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
	  ,BaseId=@baseId
 WHERE id=@ColorID
 
END

