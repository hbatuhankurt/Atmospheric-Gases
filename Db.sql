CREATE DATABASE HBK_Atmospheric_Gases
GO
USE HBK_Atmospheric_Gases
GO
CREATE TABLE Sensors(
	SensorId int identity Primary Key,
	SensorName Nvarchar(50)
)
CREATE TABLE DataType(
	DataId int identity Primary Key,
	DataType Nvarchar(50)
)
CREATE TABLE DataPublish(
	DataPublishId int identity Primary Key,
	SensorId int,
	DataId int,
	DataValue Nvarchar(50),
	PublishTime Datetime,
	CONSTRAINT FK_DataPublish_SensorId Foreign Key(SensorId) References Sensors(SensorId),
	CONSTRAINT FK_DataPublish_DataId Foreign Key(DataId) References DataType(DataId)
)