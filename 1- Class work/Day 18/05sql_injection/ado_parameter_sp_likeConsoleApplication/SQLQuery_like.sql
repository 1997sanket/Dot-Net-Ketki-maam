Create Procedure spGetProductsByName

@ProductName nvarchar(50)
as
Begin
 Select * from Product
 where Name like @ProductName + '%'
End
