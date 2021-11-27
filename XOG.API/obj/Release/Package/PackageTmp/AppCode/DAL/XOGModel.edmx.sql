
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/24/2021 13:45:12
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
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRole];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUser];
GO
IF OBJECT_ID(N'[dbo].[FK_Carts_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carts] DROP CONSTRAINT [FK_Carts_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Carts_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carts] DROP CONSTRAINT [FK_Carts_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriesImages_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoriesImages] DROP CONSTRAINT [FK_CategoriesImages_Category];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[fk_MainCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubCategories] DROP CONSTRAINT [fk_MainCategory];
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
IF OBJECT_ID(N'[dbo].[fk_product_subcategoryId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [fk_product_subcategoryId];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductImages_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductImages] DROP CONSTRAINT [FK_ProductImages_Products];
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
IF OBJECT_ID(N'[dbo].[CategoriesImages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoriesImages];
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
IF OBJECT_ID(N'[dbo].[ProductImages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductImages];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
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

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [AddressOfUserId] nvarchar(128)  NOT NULL,
    [AreaCode] nvarchar(20)  NULL,
    [HouseApartment] nvarchar(200)  NOT NULL,
    [Locality] nvarchar(150)  NULL,
    [CityTown] nvarchar(100)  NULL,
    [StateProvinces] nvarchar(100)  NOT NULL,
    [Country] nvarchar(100)  NOT NULL,
    [GPS] nvarchar(40)  NULL,
    [PhoneNumber] nvarchar(15)  NULL
);
GO

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
    [RegistrationDate] datetime  NOT NULL,
    [AlternateMobileNumber] nvarchar(15)  NULL
);
GO

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [BrandName] nvarchar(50)  NOT NULL,
    [BrandUrl] nvarchar(30)  NULL,
    [BrandDescription] nvarchar(max)  NULL
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

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [ProductMainType] tinyint  NOT NULL,
    [CategoryName] nvarchar(50)  NOT NULL,
    [CategoryDescription] nvarchar(max)  NULL,
    [RouteKey] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'CategoriesImages'
CREATE TABLE [dbo].[CategoriesImages] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [CategoryId] smallint  NOT NULL,
    [ImageUrl] varchar(max)  NOT NULL
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

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [SubCategoryId] smallint  NOT NULL,
    [BrandId] smallint  NOT NULL,
    [ProductName] nvarchar(50)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Mrp] float  NOT NULL,
    [Measure] smallint  NOT NULL,
    [Volume] varchar(5)  NOT NULL,
    [StocksAvailable] bigint  NOT NULL,
    [Gst] smallint  NOT NULL,
    [Cost] float  NOT NULL,
    [DiscountPercentage] float  NOT NULL,
    [Enabled] bit  NOT NULL,
    [ImageUrl] varchar(max)  NULL,
    [MaxPurchase] int  NOT NULL
);
GO

-- Creating table 'SubCategories'
CREATE TABLE [dbo].[SubCategories] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [CategoryId] smallint  NOT NULL,
    [SubCategoryName] nvarchar(50)  NOT NULL,
    [SubCategoryDescription] nvarchar(max)  NULL,
    [RouteKey] nvarchar(30)  NOT NULL
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

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

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

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
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

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriesImages'
ALTER TABLE [dbo].[CategoriesImages]
ADD CONSTRAINT [PK_CategoriesImages]
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

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [CategoryId] in table 'CategoriesImages'
ALTER TABLE [dbo].[CategoriesImages]
ADD CONSTRAINT [FK_CategoriesImages_Category]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriesImages_Category'
CREATE INDEX [IX_FK_CategoriesImages_Category]
ON [dbo].[CategoriesImages]
    ([CategoryId]);
GO

-- Creating foreign key on [CategoryId] in table 'SubCategories'
ALTER TABLE [dbo].[SubCategories]
ADD CONSTRAINT [fk_MainCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_MainCategory'
CREATE INDEX [IX_fk_MainCategory]
ON [dbo].[SubCategories]
    ([CategoryId]);
GO

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
ADD CONSTRAINT [fk_product_subcategoryId]
    FOREIGN KEY ([SubCategoryId])
    REFERENCES [dbo].[SubCategories]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_product_subcategoryId'
CREATE INDEX [IX_fk_product_subcategoryId]
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

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUsers'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUsers]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------