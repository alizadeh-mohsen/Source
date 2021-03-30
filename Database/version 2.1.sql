alter table [dbo].[Color] add Usage nvarchar(max);
alter table [dbo].[Color] add Accuracy tinyint not  null default 0;
