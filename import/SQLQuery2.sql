
CREATE PROCEDURE Get_Request_Master_ID (@Master_ID int)
AS
BEGIN
	SELECT Request_ID, Request_Date, Request_Master_ID
	FROM Request
	WHERE (Request_Master_ID = @Master_ID)
END
GO

EXEC Get_Request_Master_ID 105
EXEC Get_Request_Master_ID 106




