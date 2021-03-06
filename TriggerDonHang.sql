/*Cập nhật số lượng hàng còn lại sau khi sửa*/
GO
create Trigger [dbo].[KTSLSamPhamConLaiCapNhat]
ON [dbo].[OrderDetails] AFTER UPDATE AS
BEGIN
	UPDATE Products
	SET UnitsInStock = UnitsInStock 
	- (SELECT Quantity FROM inserted WHERE ProductID = Products.ProductID)
	+ (SELECT Quantity FROM deleted WHERE ProductID = Products.ProductID)
	FROM Products
	JOIN deleted ON Products.ProductID = deleted.ProductID
END
/*Cập nhật số lượng hàng còn lại sau khi thêm*/
GO
create Trigger [dbo].[KTSLSamPhamConLai]
ON [dbo].[OrderDetails] AFTER INSERT AS
BEGIN
	UPDATE Products
	SET UnitsInStock = UnitsInStock - (
		SELECT Quantity
		FROM inserted
		WHERE ProductID = Products.ProductID)
	FROM Products
	JOIN inserted ON Products.ProductID = inserted.ProductID
END
/*Cập nhật số lượng hàng còn lại sau khi xóa*/
GO
create Trigger [dbo].[KTSLSamPhamConLaiXoa]
ON [dbo].[OrderDetails] FOR DELETE AS
BEGIN
	UPDATE Products
	SET UnitsInStock = UnitsInStock 
	+ (SELECT Quantity FROM deleted WHERE ProductID = Products.ProductID)
	FROM Products
	JOIN deleted ON Products.ProductID = deleted.ProductID
END
GO