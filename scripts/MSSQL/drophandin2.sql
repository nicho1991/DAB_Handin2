--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Feb 28 2018 20:34
-- Script Generated by Database Design Studio 2.21.2 
--

--
-- Select Database: 'db_name'
--
USE db_name
GO
 
IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
 
GO
EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO
--
-- Drop Table    : 'TypeOfAdr'   
--
DROP TABLE TypeOfAdr
GO
--
-- Drop Table    : 'Telephone'   
--
DROP TABLE Telephone
GO
--
-- Drop Table    : 'Person'   
--
DROP TABLE Person
GO
--
-- Drop Table    : 'AlternativeAdress'   
--
DROP TABLE AlternativeAdress
GO
--
-- Drop Table    : 'PrimaryAdress'   
--
DROP TABLE PrimaryAdress
GO
--
-- Drop Table    : 'Email'   
--
DROP TABLE Email
GO