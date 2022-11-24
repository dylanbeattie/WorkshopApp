print @@VERSION
GO
CREATE DATABASE [workshop] COLLATE Latin1_General_CI_AS
GO
CREATE LOGIN [workshop_user] WITH 
	PASSWORD=N'workshop_pass', 
	DEFAULT_DATABASE=[workshop], 
	CHECK_EXPIRATION=OFF, 
	CHECK_POLICY=OFF
GO
USE [workshop]
GO
print 'Adding user [workshop_user] to database [workshop]'
CREATE USER [workshop_user] FOR LOGIN [workshop_user]
print 'Done.'
GO
print 'Adding user [workshop_user] to role [db-owner] in [workshop] database'
ALTER ROLE [db_owner] ADD MEMBER [workshop_user]
print 'Done'
GO