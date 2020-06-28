Build started...
Build succeeded.
The EF Core tools version '3.1.4' is older than that of the runtime '3.1.5'. Update the tools for the latest features and bug fixes.
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200625100726_InitialCreate')
BEGIN
    CREATE TABLE [Contract] (
        [Id] bigint NOT NULL IDENTITY,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [Code] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        CONSTRAINT [PK_Contract] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200625100726_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200625100726_InitialCreate', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200626153216_updateprofile')
BEGIN
    CREATE TABLE [ProfileUser] (
        [Id] bigint NOT NULL IDENTITY,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [Code] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        CONSTRAINT [PK_ProfileUser] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200626153216_updateprofile')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200626153216_updateprofile', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    DROP TABLE [Contract];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    DROP TABLE [ProfileUser];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    CREATE TABLE [Address] (
        [Id] nvarchar(450) NOT NULL,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [AddressDetails] nvarchar(max) NULL,
        [ProvinceOrCityId] bigint NOT NULL,
        [DistrictId] bigint NOT NULL,
        [WardId] bigint NOT NULL,
        CONSTRAINT [PK_Address] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    CREATE TABLE [District] (
        [Id] nvarchar(450) NOT NULL,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [Name] nvarchar(max) NULL,
        [ProvinceId] nvarchar(max) NULL,
        CONSTRAINT [PK_District] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    CREATE TABLE [Province] (
        [Id] bigint NOT NULL IDENTITY,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Province] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    CREATE TABLE [Student] (
        [Id] nvarchar(450) NOT NULL,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [Code] nvarchar(max) NULL,
        [AddressId] nvarchar(max) NULL,
        [BirthDate] datetime2 NULL,
        [Fullname] nvarchar(max) NULL,
        CONSTRAINT [PK_Student] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    CREATE TABLE [Teacher] (
        [Id] nvarchar(450) NOT NULL,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [Code] nvarchar(max) NULL,
        [AddressId] nvarchar(max) NULL,
        [Fullname] nvarchar(max) NULL,
        [BirthDate] datetime2 NULL,
        [Mobile] nvarchar(max) NULL,
        CONSTRAINT [PK_Teacher] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    CREATE TABLE [Ward] (
        [Id] nvarchar(450) NOT NULL,
        [CreatedDate] datetime2 NULL,
        [UpdatedDate] datetime2 NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedBy] bigint NOT NULL,
        [UpdatedBy] bigint NOT NULL,
        [Status] int NOT NULL,
        [Name] nvarchar(max) NULL,
        [DistrictId] nvarchar(max) NULL,
        CONSTRAINT [PK_Ward] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200628142554_entiitesinit')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200628142554_entiitesinit', N'3.1.5');
END;

GO


