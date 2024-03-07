
BEGIN 

	DELETE FROM [xog_db].[dbo].[Addresses] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[AspNetUserRoles] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[AspNetUsers] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[AspNetRoles] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[QuantityMeasures] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[ProductVariants] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[Products] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[ProductGroups] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[SubCategories] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[Categories] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[ProductImages] WHERE 1=1;
	DELETE FROM [xog_db].[dbo].[Brands] WHERE 1=1;
	 
	INSERT INTO [xog_db].[dbo].[AspNetUsers] ([Id], [UserType], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [RegistrationDate], [AlternateMobileNumber] )
	SELECT [Id], [UserType], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [RegistrationDate], [AlternateMobileNumber] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[AspNetUsers]; 
     
	INSERT INTO [xog_db].[dbo].[AspNetRoles] ([Id], [Name])
	SELECT [Id], [Name] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[AspNetRoles]; 
	
	INSERT INTO [xog_db].[dbo].[AspNetUserRoles] ([RoleId], [UserId])
	SELECT [RoleId], [UserId]
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[AspNetUserRoles];
	
	SET IDENTITY_INSERT [xog_db].[dbo].[Addresses] ON;
	INSERT INTO [xog_db].[dbo].[Addresses] ([Id], [AddressOfUserId], [FullName], [PhoneNumber], [AreaCode], [AddressLine1], [AddressLine2], [LandMark], [Country], [GPS], [IsDefault])
	SELECT [Id], [AddressOfUserId], [FullName], [PhoneNumber], [AreaCode], [AddressLine1], [AddressLine2], [LandMark], [Country], [GPS], [IsDefault] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[Addresses];
	SET IDENTITY_INSERT [xog_db].[dbo].[Addresses] OFF;
	
	SET IDENTITY_INSERT [xog_db].[dbo].[Categories] ON;
	INSERT INTO [xog_db].[dbo].[Categories] ([Id], [CategoryName], [CategoryDescription], [RouteKey], [CategoryImage], [CategoryBanner])
	SELECT [Id], [CategoryName], [CategoryDescription], [RouteKey], [CategoryImage], [CategoryBanner] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[Categories];
	SET IDENTITY_INSERT [xog_db].[dbo].[Categories] OFF;

	SET IDENTITY_INSERT [xog_db].[dbo].[Brands] ON;
	INSERT INTO [xog_db].[dbo].[Brands] ([Id], [BrandName], [BrandUrl], [BrandDescription], [BrandImage])
	SELECT [Id], [BrandName], [BrandUrl], [BrandDescription], [BrandImage]
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[Brands];
	SET IDENTITY_INSERT [xog_db].[dbo].[Brands] OFF;

	SET IDENTITY_INSERT [xog_db].[dbo].[SubCategories] ON;
	INSERT INTO [xog_db].[dbo].[SubCategories] ([Id], [CategoryId], [SubCategoryName], [SubCategoryDescription], [RouteKey], [SubCategoryImage])
	SELECT [Id], [CategoryId], [SubCategoryName], [SubCategoryDescription], [RouteKey], [SubCategoryImage] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[SubCategories];
	SET IDENTITY_INSERT [xog_db].[dbo].[SubCategories] OFF;

	SET IDENTITY_INSERT [xog_db].[dbo].[QuantityMeasures] ON;
	INSERT INTO [xog_db].[dbo].[QuantityMeasures] ([Id], [QuantityMeasureName], [Acronym], [Enabled])
	SELECT [Id], [QuantityMeasureName], [Acronym], [Enabled] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[QuantityMeasures];
	SET IDENTITY_INSERT [xog_db].[dbo].[QuantityMeasures] OFF;
	
	SET IDENTITY_INSERT [xog_db].[dbo].[ProductGroups] ON;
	INSERT INTO [xog_db].[dbo].[ProductGroups] ([Id], [SubCategoryId], [ProductGroupName], [ProductGroupDescription], [ImageUrl], [RouteKey])
	SELECT [Id], [SubCategoryId], [ProductGroupName], [ProductGroupDescription], [ImageUrl], [RouteKey] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[ProductGroups];
	SET IDENTITY_INSERT [xog_db].[dbo].[ProductGroups] OFF;
	
	SET IDENTITY_INSERT [xog_db].[dbo].[Products] ON;
	INSERT INTO [xog_db].[dbo].[Products] ([Id], [SubCategoryId], [BrandId], [ProductName], [Description], [Enabled], [ImageUrl], [ProductCode], [ProductGroupId])
	SELECT [Id], [SubCategoryId], [BrandId], [ProductName], [Description], [Enabled], [ImageUrl], [ProductCode], [ProductGroupId] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[Products];
	SET IDENTITY_INSERT [xog_db].[dbo].[Products] OFF;
	
	SET IDENTITY_INSERT [xog_db].[dbo].[ProductVariants] ON;
	INSERT INTO [xog_db].[dbo].[ProductVariants] ([Id], [ProductId], [Mrp], [MeasureId], [Volume], [StocksAvailable], [Gst], [Cost], [DiscountPercentage], [Enabled], [MaxPurchase], [HSNCode]) 
	SELECT [Id], [ProductId], [Mrp], [MeasureId], [Volume], [StocksAvailable], [Gst], [Cost], [DiscountPercentage], [Enabled], [MaxPurchase], [HSNCode] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[ProductVariants] WHERE ProductId IN (SELECT Id from [xog_db].[dbo].[Products]);
	SET IDENTITY_INSERT [xog_db].[dbo].[ProductVariants] OFF;
	
	SET IDENTITY_INSERT [xog_db].[dbo].[ProductImages] ON;
	INSERT INTO [xog_db].[dbo].[ProductImages] ([Id], [ProductId], [ImageUrl])
	SELECT [Id], [ProductId], [ImageUrl] 
	FROM [A2NWPLSK14SQL-v04.shr.prod.iad2.secureserver.net].[xog_db].[dbo].[ProductImages] WHERE ProductId IN (SELECT Id from [xog_db].[dbo].[Products]);
	SET IDENTITY_INSERT [xog_db].[dbo].[ProductImages] OFF; 

END;

--SELECT SUBSTRING(
--(SELECT ', ' + QUOTENAME(COLUMN_NAME)
--    FROM INFORMATION_SCHEMA.COLUMNS
--    WHERE TABLE_NAME = 'Brands'
--    ORDER BY ORDINAL_POSITION
--    FOR XML path('')),
--3,
--200000);