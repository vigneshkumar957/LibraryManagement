﻿# LibraryManagement
update-database -verbose

INSERT INTO [dbo].[Users] ([Password],[PersonalNumber] ,[Email] ,[Address] ,[PicturePath] ,[Birthday] ,[DateIn] ,[DateOut] ,[FirstName] ,[LastName])
	VALUES ('123456', 1, 'vignesh@tets.com', 'coimbatore','','1991-03-06 00:00:00.0000000','2023-12-08 00:00:00.0000000','2023-12-08 00:00:00.0000000','Vignesh Kumar','A')

 INSERT INTO [dbo].[Customers] ([PersonalNumber] ,[Email] ,[Address] ,[PicturePath] ,[Birthday] ,[DateIn] ,[DateOut] ,[FirstName] ,[LastName])
	VALUES (1, 'vignesh@gmail.com', 'coimbatore','','1991-03-06 00:00:00.0000000','2023-12-08 00:00:00.0000000','2023-12-08 00:00:00.0000000','Vignesh Kumar','A')
