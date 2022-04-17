
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/05/2021 17:35:16
-- Generated from EDMX file: D:\Projects\XOGProject\XOG.API\XOG.API\AppCode\DAL\XOGModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [xog_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Addresses_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Addresses] DROP CONSTRAINT [FK_Addresses_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_AdSenseAds_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdSenseAds] DROP CONSTRAINT [FK_AdSenseAds_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Carts_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carts] DROP CONSTRAINT [FK_Carts_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Carts_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carts] DROP CONSTRAINT [FK_Carts_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetails_Orders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Orders];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetails_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_Orders_Addresses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_Addresses];
GO
IF OBJECT_ID(N'[dbo].[FK_Orders_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_Brands]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Product_Brands];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_ProductGroups]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Product_ProductGroups];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_SubCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Product_SubCategory];
GO
IF OBJECT_ID(N'[dbo].[fk_ProductGroup_SubCategories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductGroups] DROP CONSTRAINT [fk_ProductGroup_SubCategories];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductImages_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductImages] DROP CONSTRAINT [FK_ProductImages_Products];
GO
IF OBJECT_ID(N'[dbo].[fk_productVariants_productId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductVariants] DROP CONSTRAINT [fk_productVariants_productId];
GO
IF OBJECT_ID(N'[dbo].[fk_productVariants_quantityMeasureId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductVariants] DROP CONSTRAINT [fk_productVariants_quantityMeasureId];
GO
IF OBJECT_ID(N'[dbo].[fk_SubCategory_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubCategories] DROP CONSTRAINT [fk_SubCategory_Category];
GO
IF OBJECT_ID(N'[dbo].[FK_Transactions_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_Transactions_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Transactions_orders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_Transactions_orders];
GO
IF OBJECT_ID(N'[dbo].[FK_WishList_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WishLists] DROP CONSTRAINT [FK_WishList_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_WishList_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WishLists] DROP CONSTRAINT [FK_WishList_Products];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID(N'[dbo].[AdSenseAds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdSenseAds];
GO
IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[Brands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brands];
GO
IF OBJECT_ID(N'[dbo].[C__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[C__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[Carts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carts];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[EmailTemplates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmailTemplates];
GO
IF OBJECT_ID(N'[dbo].[OrderDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderDetails];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[ProductGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductGroups];
GO
IF OBJECT_ID(N'[dbo].[ProductImages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductImages];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductVariants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductVariants];
GO
IF OBJECT_ID(N'[dbo].[QuantityMeasures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuantityMeasures];
GO
IF OBJECT_ID(N'[dbo].[SubCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubCategories];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[WishLists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WishLists];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AdSenseAds'
CREATE TABLE [dbo].[AdSenseAds] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Page] nvarchar(50)  NOT NULL,
    [Position] nvarchar(50)  NOT NULL,
    [SortOrder] tinyint  NOT NULL,
    [ValidTill] datetime  NOT NULL,
    [AdLink] nvarchar(max)  NOT NULL,
    [ImageUrl] nvarchar(max)  NOT NULL,
    [ViewCount] bigint  NOT NULL,
    [UpdatedByUserId] nvarchar(128)  NOT NULL,
    [LastUpdatedDate] datetime  NOT NULL
);
GO

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [BrandName] nvarchar(50)  NOT NULL,
    [BrandUrl] nvarchar(30)  NULL,
    [BrandDescription] nvarchar(max)  NULL,
    [BrandImage] nvarchar(150)  NULL
);
GO

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Carts'
CREATE TABLE [dbo].[Carts] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [AddedByUserId] nvarchar(128)  NOT NULL,
    [ProductId] bigint  NULL,
    [Quantity] smallint  NULL
);
GO

-- Creating table 'EmailTemplates'
CREATE TABLE [dbo].[EmailTemplates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TemplateName] nchar(30)  NOT NULL,
    [HtmlMarkup] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [TemplateCategory] int  NOT NULL
);
GO

-- Creating table 'OrderDetails'
CREATE TABLE [dbo].[OrderDetails] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [OrderId] bigint  NOT NULL,
    [ProductId] bigint  NOT NULL,
    [Quantity] int  NOT NULL,
    [Price] float  NOT NULL,
    [Discount] float  NOT NULL,
    [Gst] smallint  NOT NULL,
    [Cost] float  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [OrderedByUserId] nvarchar(128)  NOT NULL,
    [OrderDate] datetime  NOT NULL,
    [OrderState] tinyint  NOT NULL,
    [DeliveredDate] datetime  NULL,
    [DispatchedDate] datetime  NULL,
    [Returned] bit  NULL,
    [TotalAmount] float  NOT NULL,
    [OrderToAddressId] bigint  NOT NULL
);
GO

-- Creating table 'ProductImages'
CREATE TABLE [dbo].[ProductImages] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ProductId] bigint  NOT NULL,
    [ImageUrl] varchar(max)  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [BilledByUserId] nvarchar(128)  NOT NULL,
    [OrderId] bigint  NOT NULL,
    [TotalAmount] float  NOT NULL,
    [PaymentDateTime] datetime  NOT NULL,
    [Canceled] bit  NOT NULL
);
GO

-- Creating table 'WishLists'
CREATE TABLE [dbo].[WishLists] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [WishedByUserId] nvarchar(128)  NOT NULL,
    [ProductId] bigint  NULL,
    [Quantity] smallint  NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [UserType] nvarchar(max)  NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [FirstName] nvarchar(30)  NULL,
    [LastName] nvarchar(30)  NULL,
    [RegistrationDate] datetime  NULL,
    [AlternateMobileNumber] nvarchar(15)  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(50)  NOT NULL,
    [CategoryDescription] nvarchar(max)  NULL,
    [RouteKey] nvarchar(30)  NOT NULL,
    [CategoryImage] nvarchar(150)  NULL,
    [CategoryBanner] nvarchar(150)  NULL
);
GO

-- Creating table 'ProductGroups'
CREATE TABLE [dbo].[ProductGroups] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [SubCategoryId] smallint  NOT NULL,
    [ProductGroupName] nvarchar(50)  NOT NULL,
    [ProductGroupDescription] nvarchar(max)  NULL,
    [ImageUrl] nvarchar(150)  NULL,
    [RouteKey] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [SubCategoryId] smallint  NOT NULL,
    [BrandId] smallint  NOT NULL,
    [ProductName] nvarchar(50)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Enabled] bit  NOT NULL,
    [ImageUrl] nvarchar(150)  NULL,
    [ProductCode] varchar(50)  NULL,
    [ProductGroupId] smallint  NULL
);
GO

-- Creating table 'SubCategories'
CREATE TABLE [dbo].[SubCategories] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [CategoryId] smallint  NOT NULL,
    [SubCategoryName] nvarchar(50)  NOT NULL,
    [SubCategoryDescription] nvarchar(max)  NULL,
    [RouteKey] nvarchar(30)  NOT NULL,
    [SubCategoryImage] nvarchar(150)  NULL
);
GO

-- Creating table 'ProductVariants'
CREATE TABLE [dbo].[ProductVariants] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ProductId] bigint  NOT NULL,
    [Mrp] float  NOT NULL,
    [MeasureId] smallint  NOT NULL,
    [Volume] smallint  NOT NULL,
    [StocksAvailable] bigint  NOT NULL,
    [Gst] smallint  NOT NULL,
    [Cost] float  NOT NULL,
    [DiscountPercentage] float  NOT NULL,
    [Enabled] bit  NOT NULL,
    [MaxPurchase] int  NOT NULL,
    [HSNCode] varchar(20)  NULL
);
GO

-- Creating table 'QuantityMeasures'
CREATE TABLE [dbo].[QuantityMeasures] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [QuantityMeasureName] nvarchar(20)  NOT NULL,
    [Acronym] nvarchar(5)  NOT NULL,
    [Enabled] bit  NOT NULL
);
GO

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [AddressOfUserId] nvarchar(128)  NOT NULL,
    [FullName] nvarchar(128)  NOT NULL,
    [PhoneNumber] nvarchar(15)  NULL,
    [AreaCode] nvarchar(20)  NULL,
    [AddressLine1] nvarchar(300)  NULL,
    [AddressLine2] nvarchar(300)  NULL,
    [LandMark] nvarchar(150)  NULL,
    [Country] nvarchar(100)  NOT NULL,
    [GPS] nvarchar(40)  NULL,
    [IsDefault] bit  NOT NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AdSenseAds'
ALTER TABLE [dbo].[AdSenseAds]
ADD CONSTRAINT [PK_AdSenseAds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'Brands'
ALTER TABLE [dbo].[Brands]
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'Carts'
ALTER TABLE [dbo].[Carts]
ADD CONSTRAINT [PK_Carts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmailTemplates'
ALTER TABLE [dbo].[EmailTemplates]
ADD CONSTRAINT [PK_EmailTemplates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [PK_OrderDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductImages'
ALTER TABLE [dbo].[ProductImages]
ADD CONSTRAINT [PK_ProductImages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WishLists'
ALTER TABLE [dbo].[WishLists]
ADD CONSTRAINT [PK_WishLists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductGroups'
ALTER TABLE [dbo].[ProductGroups]
ADD CONSTRAINT [PK_ProductGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SubCategories'
ALTER TABLE [dbo].[SubCategories]
ADD CONSTRAINT [PK_SubCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductVariants'
ALTER TABLE [dbo].[ProductVariants]
ADD CONSTRAINT [PK_ProductVariants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'QuantityMeasures'
ALTER TABLE [dbo].[QuantityMeasures]
ADD CONSTRAINT [PK_QuantityMeasures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OrderId] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_OrderDetails_Orders]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetails_Orders'
CREATE INDEX [IX_FK_OrderDetails_Orders]
ON [dbo].[OrderDetails]
    ([OrderId]);
GO

-- Creating foreign key on [OrderId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_Transactions_orders]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transactions_orders'
CREATE INDEX [IX_FK_Transactions_orders]
ON [dbo].[Transactions]
    ([OrderId]);
GO

-- Creating foreign key on [UpdatedByUserId] in table 'AdSenseAds'
ALTER TABLE [dbo].[AdSenseAds]
ADD CONSTRAINT [FK_AdSenseAds_AspNetUsers]
    FOREIGN KEY ([UpdatedByUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdSenseAds_AspNetUsers'
CREATE INDEX [IX_FK_AdSenseAds_AspNetUsers]
ON [dbo].[AdSenseAds]
    ([UpdatedByUserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [AddedByUserId] in table 'Carts'
ALTER TABLE [dbo].[Carts]
ADD CONSTRAINT [FK_Carts_AspNetUsers]
    FOREIGN KEY ([AddedByUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Carts_AspNetUsers'
CREATE INDEX [IX_FK_Carts_AspNetUsers]
ON [dbo].[Carts]
    ([AddedByUserId]);
GO

-- Creating foreign key on [OrderedByUserId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_AspNetUsers]
    FOREIGN KEY ([OrderedByUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_AspNetUsers'
CREATE INDEX [IX_FK_Orders_AspNetUsers]
ON [dbo].[Orders]
    ([OrderedByUserId]);
GO

-- Creating foreign key on [BilledByUserId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_Transactions_AspNetUsers]
    FOREIGN KEY ([BilledByUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transactions_AspNetUsers'
CREATE INDEX [IX_FK_Transactions_AspNetUsers]
ON [dbo].[Transactions]
    ([BilledByUserId]);
GO

-- Creating foreign key on [WishedByUserId] in table 'WishLists'
ALTER TABLE [dbo].[WishLists]
ADD CONSTRAINT [FK_WishList_AspNetUsers]
    FOREIGN KEY ([WishedByUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WishList_AspNetUsers'
CREATE INDEX [IX_FK_WishList_AspNetUsers]
ON [dbo].[WishLists]
    ([WishedByUserId]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRole]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUser]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUser'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUser]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [BrandId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Product_Brands]
    FOREIGN KEY ([BrandId])
    REFERENCES [dbo].[Brands]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_Brands'
CREATE INDEX [IX_FK_Product_Brands]
ON [dbo].[Products]
    ([BrandId]);
GO

-- Creating foreign key on [ProductId] in table 'Carts'
ALTER TABLE [dbo].[Carts]
ADD CONSTRAINT [FK_Carts_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Carts_Products'
CREATE INDEX [IX_FK_Carts_Products]
ON [dbo].[Carts]
    ([ProductId]);
GO

-- Creating foreign key on [CategoryId] in table 'SubCategories'
ALTER TABLE [dbo].[SubCategories]
ADD CONSTRAINT [fk_SubCategory_Category]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_SubCategory_Category'
CREATE INDEX [IX_fk_SubCategory_Category]
ON [dbo].[SubCategories]
    ([CategoryId]);
GO

-- Creating foreign key on [ProductId] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_OrderDetails_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetails_Products'
CREATE INDEX [IX_FK_OrderDetails_Products]
ON [dbo].[OrderDetails]
    ([ProductId]);
GO

-- Creating foreign key on [ProductGroupId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Product_ProductGroups]
    FOREIGN KEY ([ProductGroupId])
    REFERENCES [dbo].[ProductGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_ProductGroups'
CREATE INDEX [IX_FK_Product_ProductGroups]
ON [dbo].[Products]
    ([ProductGroupId]);
GO

-- Creating foreign key on [SubCategoryId] in table 'ProductGroups'
ALTER TABLE [dbo].[ProductGroups]
ADD CONSTRAINT [fk_ProductGroup_SubCategories]
    FOREIGN KEY ([SubCategoryId])
    REFERENCES [dbo].[SubCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_ProductGroup_SubCategories'
CREATE INDEX [IX_fk_ProductGroup_SubCategories]
ON [dbo].[ProductGroups]
    ([SubCategoryId]);
GO

-- Creating foreign key on [ProductId] in table 'ProductImages'
ALTER TABLE [dbo].[ProductImages]
ADD CONSTRAINT [FK_ProductImages_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductImages_Products'
CREATE INDEX [IX_FK_ProductImages_Products]
ON [dbo].[ProductImages]
    ([ProductId]);
GO

-- Creating foreign key on [SubCategoryId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Product_SubCategory]
    FOREIGN KEY ([SubCategoryId])
    REFERENCES [dbo].[SubCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_SubCategory'
CREATE INDEX [IX_FK_Product_SubCategory]
ON [dbo].[Products]
    ([SubCategoryId]);
GO

-- Creating foreign key on [ProductId] in table 'WishLists'
ALTER TABLE [dbo].[WishLists]
ADD CONSTRAINT [FK_WishList_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WishList_Products'
CREATE INDEX [IX_FK_WishList_Products]
ON [dbo].[WishLists]
    ([ProductId]);
GO

-- Creating foreign key on [ProductId] in table 'ProductVariants'
ALTER TABLE [dbo].[ProductVariants]
ADD CONSTRAINT [fk_productVariants_productId]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_productVariants_productId'
CREATE INDEX [IX_fk_productVariants_productId]
ON [dbo].[ProductVariants]
    ([ProductId]);
GO

-- Creating foreign key on [MeasureId] in table 'ProductVariants'
ALTER TABLE [dbo].[ProductVariants]
ADD CONSTRAINT [fk_productVariants_quantityMeasureId]
    FOREIGN KEY ([MeasureId])
    REFERENCES [dbo].[QuantityMeasures]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_productVariants_quantityMeasureId'
CREATE INDEX [IX_fk_productVariants_quantityMeasureId]
ON [dbo].[ProductVariants]
    ([MeasureId]);
GO

-- Creating foreign key on [AddressOfUserId] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [FK_Addresses_AspNetUsers]
    FOREIGN KEY ([AddressOfUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Addresses_AspNetUsers'
CREATE INDEX [IX_FK_Addresses_AspNetUsers]
ON [dbo].[Addresses]
    ([AddressOfUserId]);
GO

-- Creating foreign key on [OrderToAddressId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_Addresses]
    FOREIGN KEY ([OrderToAddressId])
    REFERENCES [dbo].[Addresses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_Addresses'
CREATE INDEX [IX_FK_Orders_Addresses]
ON [dbo].[Orders]
    ([OrderToAddressId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------