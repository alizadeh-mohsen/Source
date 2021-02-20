ALTER TABLE [dbo].[Unit] ADD Fixed bit not null default 0;
alter table [dbo].[Color] add Usage nvarchar(max);
alter table [dbo].[Color] add Accuracy tinyint not  null default 0;

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

