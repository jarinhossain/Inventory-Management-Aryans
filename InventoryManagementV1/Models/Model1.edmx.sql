
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/29/2020 21:14:51
-- Generated from EDMX file: G:\Using soft\programming\Programmings\Github Repos\Inventory-Management-Aryans\InventoryManagementV1\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [InventoryManagement];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Customer_CommissionType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [FK_Customer_CommissionType];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Gender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [FK_Customer_Gender];
GO
IF OBJECT_ID(N'[dbo].[FK_Order_CommissionType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_Order_CommissionType];
GO
IF OBJECT_ID(N'[dbo].[FK_Order_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_Order_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_Order_OrderStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_Order_OrderStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetails_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetails_ProductQuantityMap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_ProductQuantityMap];
GO
IF OBJECT_ID(N'[dbo].[FK_Payment_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payment] DROP CONSTRAINT [FK_Payment_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_Payment_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payment] DROP CONSTRAINT [FK_Payment_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_Country]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Country];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_Gender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Gender];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductQuantityMap_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductQuantityMap] DROP CONSTRAINT [FK_ProductQuantityMap_Category];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductQuantityMap_Color]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductQuantityMap] DROP CONSTRAINT [FK_ProductQuantityMap_Color];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductQuantityMap_Material]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductQuantityMap] DROP CONSTRAINT [FK_ProductQuantityMap_Material];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductQuantityMap_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductQuantityMap] DROP CONSTRAINT [FK_ProductQuantityMap_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductQuantityMap_SizeGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductQuantityMap] DROP CONSTRAINT [FK_ProductQuantityMap_SizeGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Job]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Job];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Color]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Color];
GO
IF OBJECT_ID(N'[dbo].[CommissionType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommissionType];
GO
IF OBJECT_ID(N'[dbo].[Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Country];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[Gender]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gender];
GO
IF OBJECT_ID(N'[dbo].[Job]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Job];
GO
IF OBJECT_ID(N'[dbo].[Material]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Material];
GO
IF OBJECT_ID(N'[dbo].[Order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Order];
GO
IF OBJECT_ID(N'[dbo].[OrderDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderDetails];
GO
IF OBJECT_ID(N'[dbo].[OrderStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderStatus];
GO
IF OBJECT_ID(N'[dbo].[Payment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payment];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[ProductQuantityMap]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductQuantityMap];
GO
IF OBJECT_ID(N'[dbo].[SizeGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SizeGroup];
GO
IF OBJECT_ID(N'[dbo].[Supplier]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Supplier];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Category_Name] varchar(50)  NULL
);
GO

-- Creating table 'Colors'
CREATE TABLE [dbo].[Colors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Color_Name] varchar(50)  NULL
);
GO

-- Creating table 'CommissionTypes'
CREATE TABLE [dbo].[CommissionTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Customer_Name] varchar(50)  NULL,
    [Mobile1] varchar(20)  NULL,
    [Gender_Id] int  NULL,
    [Address] varchar(50)  NULL,
    [Mobile2] varchar(20)  NULL,
    [Guarantor_Name] varchar(50)  NULL,
    [Guarantor_Mobile] varchar(20)  NULL,
    [Guarantor_Address] varchar(50)  NULL,
    [Created_By] int  NULL,
    [Created_On] datetime  NULL,
    [Updated_By] int  NULL,
    [Updated_On] datetime  NULL,
    [Commission_Type_Id] int  NULL
);
GO

-- Creating table 'Genders'
CREATE TABLE [dbo].[Genders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL
);
GO

-- Creating table 'Jobs'
CREATE TABLE [dbo].[Jobs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Job_Title] varchar(50)  NULL,
    [Salary] float  NULL
);
GO

-- Creating table 'Materials'
CREATE TABLE [dbo].[Materials] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Material_Name] varchar(50)  NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Order_Date] datetime  NULL,
    [Order_Status_Id] int  NULL,
    [Customer_Id] int  NULL,
    [Packaging_Charge] float  NULL,
    [Discount] float  NULL,
    [Commission_Type_Id] int  NULL,
    [Commission] float  NULL,
    [Delivery_Date] datetime  NULL,
    [Created_By] int  NULL,
    [Updated_On] datetime  NULL,
    [Updated_By] int  NULL
);
GO

-- Creating table 'OrderDetails'
CREATE TABLE [dbo].[OrderDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Order_Id] int  NULL,
    [Product_Quantity_Id] int  NULL,
    [Sold_Price] float  NULL,
    [Purchase_Price] float  NULL,
    [Quantity] int  NULL
);
GO

-- Creating table 'OrderStatus'
CREATE TABLE [dbo].[OrderStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] varchar(50)  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Product_No] varchar(50)  NULL,
    [Product_Name] varchar(50)  NULL,
    [Product_Details] varchar(50)  NULL,
    [Gender_Id] int  NULL,
    [Country_Id] int  NULL,
    [Image_Path] varchar(200)  NULL,
    [Is_Active] bit  NULL,
    [Is_Delete] bit  NULL,
    [Created_By] int  NULL,
    [Created_On] datetime  NULL,
    [Updated_By] int  NULL,
    [Updated_On] datetime  NULL
);
GO

-- Creating table 'ProductQuantityMaps'
CREATE TABLE [dbo].[ProductQuantityMaps] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Color_Id] int  NULL,
    [Quantity] int  NULL,
    [Material_Id] int  NULL,
    [Category_Id] int  NULL,
    [Size_Group_Id] int  NULL,
    [Product_Id] int  NULL,
    [Price] float  NULL,
    [Created_By] int  NULL,
    [Created_On] datetime  NULL,
    [Updated_By] int  NULL,
    [Updated_On] datetime  NULL,
    [Selling_Price] float  NULL
);
GO

-- Creating table 'SizeGroups'
CREATE TABLE [dbo].[SizeGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Size_Group_Range] varchar(50)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [User_Name] varchar(50)  NULL,
    [Password] varchar(50)  NULL,
    [Mobile_No] varchar(50)  NULL,
    [Email] varchar(50)  NULL,
    [Address] varchar(50)  NULL,
    [Job_Id] int  NULL,
    [Hired_Date] datetime  NULL,
    [Voter_Id] varchar(50)  NULL,
    [Image_Path] varchar(200)  NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ref_No] varchar(50)  NULL,
    [Customer_Id] int  NULL,
    [Order_Id] int  NULL,
    [Remarks] varchar(50)  NULL,
    [Created_By] int  NULL,
    [Created_On] datetime  NULL,
    [Updated_By] int  NULL,
    [Updated_On] datetime  NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Company_Name] varchar(50)  NULL,
    [Company_Address] varchar(100)  NULL,
    [Company_Mobile] varchar(50)  NULL,
    [Contact_Name] varchar(50)  NULL,
    [Contact_Person_Number] varchar(50)  NULL,
    [Contact_Person_Address] varchar(50)  NULL,
    [Email] varchar(50)  NULL,
    [Website] varchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Colors'
ALTER TABLE [dbo].[Colors]
ADD CONSTRAINT [PK_Colors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CommissionTypes'
ALTER TABLE [dbo].[CommissionTypes]
ADD CONSTRAINT [PK_CommissionTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Genders'
ALTER TABLE [dbo].[Genders]
ADD CONSTRAINT [PK_Genders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [PK_Jobs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [PK_Materials]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [PK_OrderDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderStatus'
ALTER TABLE [dbo].[OrderStatus]
ADD CONSTRAINT [PK_OrderStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductQuantityMaps'
ALTER TABLE [dbo].[ProductQuantityMaps]
ADD CONSTRAINT [PK_ProductQuantityMaps]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SizeGroups'
ALTER TABLE [dbo].[SizeGroups]
ADD CONSTRAINT [PK_SizeGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Category_Id] in table 'ProductQuantityMaps'
ALTER TABLE [dbo].[ProductQuantityMaps]
ADD CONSTRAINT [FK_ProductQuantityMap_Category]
    FOREIGN KEY ([Category_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductQuantityMap_Category'
CREATE INDEX [IX_FK_ProductQuantityMap_Category]
ON [dbo].[ProductQuantityMaps]
    ([Category_Id]);
GO

-- Creating foreign key on [Color_Id] in table 'ProductQuantityMaps'
ALTER TABLE [dbo].[ProductQuantityMaps]
ADD CONSTRAINT [FK_ProductQuantityMap_Color]
    FOREIGN KEY ([Color_Id])
    REFERENCES [dbo].[Colors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductQuantityMap_Color'
CREATE INDEX [IX_FK_ProductQuantityMap_Color]
ON [dbo].[ProductQuantityMaps]
    ([Color_Id]);
GO

-- Creating foreign key on [Commission_Type_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Order_CommissionType]
    FOREIGN KEY ([Commission_Type_Id])
    REFERENCES [dbo].[CommissionTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Order_CommissionType'
CREATE INDEX [IX_FK_Order_CommissionType]
ON [dbo].[Orders]
    ([Commission_Type_Id]);
GO

-- Creating foreign key on [Country_Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Product_Country]
    FOREIGN KEY ([Country_Id])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_Country'
CREATE INDEX [IX_FK_Product_Country]
ON [dbo].[Products]
    ([Country_Id]);
GO

-- Creating foreign key on [Gender_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_Customer_Gender]
    FOREIGN KEY ([Gender_Id])
    REFERENCES [dbo].[Genders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Gender'
CREATE INDEX [IX_FK_Customer_Gender]
ON [dbo].[Customers]
    ([Gender_Id]);
GO

-- Creating foreign key on [Customer_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Order_Customer]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Order_Customer'
CREATE INDEX [IX_FK_Order_Customer]
ON [dbo].[Orders]
    ([Customer_Id]);
GO

-- Creating foreign key on [Gender_Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Product_Gender]
    FOREIGN KEY ([Gender_Id])
    REFERENCES [dbo].[Genders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_Gender'
CREATE INDEX [IX_FK_Product_Gender]
ON [dbo].[Products]
    ([Gender_Id]);
GO

-- Creating foreign key on [Job_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_User_Job]
    FOREIGN KEY ([Job_Id])
    REFERENCES [dbo].[Jobs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Job'
CREATE INDEX [IX_FK_User_Job]
ON [dbo].[Users]
    ([Job_Id]);
GO

-- Creating foreign key on [Material_Id] in table 'ProductQuantityMaps'
ALTER TABLE [dbo].[ProductQuantityMaps]
ADD CONSTRAINT [FK_ProductQuantityMap_Material]
    FOREIGN KEY ([Material_Id])
    REFERENCES [dbo].[Materials]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductQuantityMap_Material'
CREATE INDEX [IX_FK_ProductQuantityMap_Material]
ON [dbo].[ProductQuantityMaps]
    ([Material_Id]);
GO

-- Creating foreign key on [Order_Status_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Order_OrderStatus]
    FOREIGN KEY ([Order_Status_Id])
    REFERENCES [dbo].[OrderStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Order_OrderStatus'
CREATE INDEX [IX_FK_Order_OrderStatus]
ON [dbo].[Orders]
    ([Order_Status_Id]);
GO

-- Creating foreign key on [Order_Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_OrderDetails_Order]
    FOREIGN KEY ([Order_Id])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetails_Order'
CREATE INDEX [IX_FK_OrderDetails_Order]
ON [dbo].[OrderDetails]
    ([Order_Id]);
GO

-- Creating foreign key on [Product_Id] in table 'ProductQuantityMaps'
ALTER TABLE [dbo].[ProductQuantityMaps]
ADD CONSTRAINT [FK_ProductQuantityMap_Product]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductQuantityMap_Product'
CREATE INDEX [IX_FK_ProductQuantityMap_Product]
ON [dbo].[ProductQuantityMaps]
    ([Product_Id]);
GO

-- Creating foreign key on [Size_Group_Id] in table 'ProductQuantityMaps'
ALTER TABLE [dbo].[ProductQuantityMaps]
ADD CONSTRAINT [FK_ProductQuantityMap_SizeGroup]
    FOREIGN KEY ([Size_Group_Id])
    REFERENCES [dbo].[SizeGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductQuantityMap_SizeGroup'
CREATE INDEX [IX_FK_ProductQuantityMap_SizeGroup]
ON [dbo].[ProductQuantityMaps]
    ([Size_Group_Id]);
GO

-- Creating foreign key on [Product_Quantity_Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_OrderDetails_ProductQuantityMap]
    FOREIGN KEY ([Product_Quantity_Id])
    REFERENCES [dbo].[ProductQuantityMaps]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetails_ProductQuantityMap'
CREATE INDEX [IX_FK_OrderDetails_ProductQuantityMap]
ON [dbo].[OrderDetails]
    ([Product_Quantity_Id]);
GO

-- Creating foreign key on [Customer_Id] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_Payment_Customer]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_Customer'
CREATE INDEX [IX_FK_Payment_Customer]
ON [dbo].[Payments]
    ([Customer_Id]);
GO

-- Creating foreign key on [Order_Id] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_Payment_Order]
    FOREIGN KEY ([Order_Id])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_Order'
CREATE INDEX [IX_FK_Payment_Order]
ON [dbo].[Payments]
    ([Order_Id]);
GO

-- Creating foreign key on [Commission_Type_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_Customer_CommissionType]
    FOREIGN KEY ([Commission_Type_Id])
    REFERENCES [dbo].[CommissionTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_CommissionType'
CREATE INDEX [IX_FK_Customer_CommissionType]
ON [dbo].[Customers]
    ([Commission_Type_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------