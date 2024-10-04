Use mvcefcoreDb;

CREATE TABLE FirstTable(
	FirstTableId int IDENTITY(1,1) PRIMARY KEY,
	TextColumn varchar(15) NOT NULL);

	Insert into FirstTable (TextColumn)
		values ('TestColumn1');

	Insert into FirstTable (TextColumn)
		values ('TestColumn2');

	Select * from FirstTable;
