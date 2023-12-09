-- Membuat database DB_Person
CREATE DATABASE DB_Person;
GO

-- Menggunakan database DB_Person
USE DB_Person;
GO

-- Menghapus tabel CountryRegion
DROP TABLE IF EXISTS CountryRegion;

-- Membuat tabel CountryRegion kembali dengan skema yang sama
CREATE TABLE CountryRegion (
    CountryRegionCode VARCHAR(2) PRIMARY KEY,
    Name NVARCHAR(100),
    ModifiedDate DATETIME
);
GO

-- Menambahkan contoh data ke dalam tabel CountryRegion untuk abjad A sampai Z
INSERT INTO CountryRegion (CountryRegionCode, Name, ModifiedDate)
VALUES 
    ('AF', 'Afghanistan', GETDATE()),
    ('BH', 'Bahrain', GETDATE()),
    ('CN', 'China', GETDATE()),
    ('DK', 'Denmark', GETDATE()),
    ('EG', 'Egypt', GETDATE()),
    ('FR', 'France', GETDATE()),
    ('DE', 'Germany', GETDATE()),
    ('HU', 'Hungary', GETDATE()),
    ('IN', 'India', GETDATE()),
    ('JP', 'Japan', GETDATE()),
    ('KR', 'Korea', GETDATE()),
    ('LB', 'Lebanon', GETDATE()),
    ('MY', 'Malaysia', GETDATE()),
    ('NL', 'Netherlands', GETDATE()),
    ('OM', 'Oman', GETDATE()),
    ('PK', 'Pakistan', GETDATE()),
    ('QA', 'Qatar', GETDATE()),
    ('RU', 'Russia', GETDATE()),
    ('SA', 'Saudi Arabia', GETDATE()),
    ('TH', 'Thailand', GETDATE()),
    ('TR', 'Turkey', GETDATE()),
    ('UA', 'Ukraine', GETDATE()),
    ('GB', 'United Kingdom', GETDATE()),
    ('US', 'United States', GETDATE()),
    ('VN', 'Vietnam', GETDATE()),
    ('YE', 'Yemen', GETDATE());


-- Menghapus tabel PhoneNumberType jika diperlukan
DROP TABLE IF EXISTS PhoneNumberType;
GO

-- Membuat tabel PhoneNumberType
CREATE TABLE PhoneNumberType (
    PhoneNumberTypeID INT PRIMARY KEY,
    Name NVARCHAR(50),
    ModifiedDate DATETIME
);
GO

-- Menambahkan contoh data ke dalam tabel PhoneNumberType
INSERT INTO PhoneNumberType (PhoneNumberTypeID, Name, ModifiedDate) VALUES (1, 'Cell', GETDATE());
INSERT INTO PhoneNumberType (PhoneNumberTypeID, Name, ModifiedDate) VALUES (2, 'Home', GETDATE());
INSERT INTO PhoneNumberType (PhoneNumberTypeID, Name, ModifiedDate) VALUES (3, 'Work', GETDATE());
-- Anda bisa menambahkan lebih banyak data dengan perintah INSERT INTO untuk tipe nomor telepon lainnya
GO

-- Menghapus tabel ContactType jika diperlukan
DROP TABLE IF EXISTS ContactType;
GO

-- Membuat tabel ContactType
CREATE TABLE ContactType (
    ContactTypeID INT PRIMARY KEY,
    Name NVARCHAR(100),
    ModifiedDate DATETIME
);
GO

-- Menambahkan contoh data ke dalam tabel ContactType
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (1, 'Accounting Manager', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (2, 'Assistant Sales Agent', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (3, 'Assistant Sales Representative', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (4, 'Coordinator Foreign Markets', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (5, 'Export Administrator', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (6, 'International Marketing Manager', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (7, 'Marketing Assistant', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (8, 'Marketing Manager', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (9, 'Marketing Representative', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (10, 'Order Administrator', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (11, 'Owner', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (12, 'Owner/Marketing Assistant', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (13, 'Product Manager', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (14, 'Purchasing Agent', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (15, 'Purchasing Manager', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (16, 'Regional Account Representative', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (17, 'Sales Agent', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (18, 'Sales Associate', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (19, 'Sales Manager', GETDATE());
INSERT INTO ContactType (ContactTypeID, Name, ModifiedDate) VALUES (20, 'Sales Representative', GETDATE());
-- Anda bisa menambahkan lebih banyak data dengan perintah INSERT INTO untuk jenis kontak lainnya
GO

-- Menghapus tabel AddressType jika diperlukan
DROP TABLE IF EXISTS AddressType;
GO

-- Membuat tabel AddressType
CREATE TABLE AddressType (
    AddressTypeID INT PRIMARY KEY,
    Name NVARCHAR(100),
    ModifiedDate DATETIME
);
GO

-- Menambahkan contoh data ke dalam tabel AddressType
INSERT INTO AddressType (AddressTypeID, Name, ModifiedDate) VALUES (1, 'Billing', GETDATE());
INSERT INTO AddressType (AddressTypeID, Name, ModifiedDate) VALUES (2, 'Home', GETDATE());
INSERT INTO AddressType (AddressTypeID, Name, ModifiedDate) VALUES (3, 'Main Office', GETDATE());
INSERT INTO AddressType (AddressTypeID, Name, ModifiedDate) VALUES (4, 'Primary', GETDATE());
INSERT INTO AddressType (AddressTypeID, Name, ModifiedDate) VALUES (5, 'Shipping', GETDATE());
INSERT INTO AddressType (AddressTypeID, Name, ModifiedDate) VALUES (6, 'Archive', GETDATE());
-- Anda bisa menambahkan lebih banyak data dengan perintah INSERT INTO untuk jenis alamat lainnya
GO

-- Menghapus tabel BusinessEntity jika diperlukan
DROP TABLE IF EXISTS BusinessEntity;
GO

-- Membuat tabel BusinessEntity
CREATE TABLE BusinessEntity (
    BusinessEntityID INT PRIMARY KEY,
    ModifiedDate DATETIME
);
GO

-- Menambahkan contoh data ke dalam tabel BusinessEntity
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (1, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (2, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (3, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (4, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (5, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (6, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (7, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (8, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (9, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (10, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (11, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (12, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (13, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (14, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (15, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (16, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (17, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (18, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (19, GETDATE());
INSERT INTO BusinessEntity (BusinessEntityID, ModifiedDate) VALUES (20, GETDATE());
-- Anda bisa menambahkan lebih banyak data dengan perintah INSERT INTO untuk ID bisnis entitas lainnya
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS StateProvince;
GO

-- Membuat tabel StateProvince
CREATE TABLE StateProvince (
    StateProvinceID INT PRIMARY KEY,
    StateProvinceCode VARCHAR(5),
    CountryRegionCode VARCHAR(2),
    isOnlyStateProvinceFlag BIT,
    Name NVARCHAR(100),
    TerritoryID INT,
    ModifiedDate DATETIME,
    CONSTRAINT FK_CountryRegion_StateProvince FOREIGN KEY (CountryRegionCode) REFERENCES CountryRegion (CountryRegionCode)
);
GO

-- Menambahkan contoh data ke dalam tabel StateProvince dengan kode negara yang ada dalam tabel CountryRegion
INSERT INTO StateProvince (StateProvinceID, StateProvinceCode, CountryRegionCode, isOnlyStateProvinceFlag, Name, TerritoryID, ModifiedDate)
VALUES 
    (1, 'AF01', 'AF', 1, 'Kabul', 1, GETDATE()),
    (2, 'BH01', 'BH', 1, 'Manama', 2, GETDATE()),
    (3, 'CN01', 'CN', 1, 'Beijing', 3, GETDATE()),
    (4, 'DE01', 'DE', 1, 'Berlin', 4, GETDATE()),
    (5, 'DK01', 'DK', 1, 'Copenhagen', 5, GETDATE()),
    (6, 'EG01', 'EG', 1, 'Cairo', 6, GETDATE()),
    (7, 'FR01', 'FR', 1, 'Paris', 7, GETDATE()),
    (8, 'GB01', 'GB', 1, 'London', 8, GETDATE()),
    (9, 'HU01', 'HU', 1, 'Budapest', 9, GETDATE()),
    (10, 'IN01', 'IN', 1, 'New Delhi', 10, GETDATE()),
    (11, 'JP01', 'JP', 1, 'Tokyo', 11, GETDATE()),
    (12, 'KR01', 'KR', 1, 'Seoul', 12, GETDATE()),
    (13, 'LB01', 'LB', 1, 'Beirut', 13, GETDATE()),
    (14, 'MY01', 'MY', 1, 'Kuala Lumpur', 14, GETDATE()),
    (15, 'NL01', 'NL', 1, 'Amsterdam', 15, GETDATE()),
    (16, 'OM01', 'OM', 1, 'Muscat', 16, GETDATE()),
    (17, 'PK01', 'PK', 1, 'Islamabad', 17, GETDATE()),
    (18, 'QA01', 'QA', 1, 'Doha', 18, GETDATE()),
    (19, 'RU01', 'RU', 1, 'Moscow', 19, GETDATE()),
    (20, 'SA01', 'SA', 1, 'Riyadh', 20, GETDATE());
-- Tambahkan entri untuk negara bagian lainnya dengan kode negara yang ada di tabel CountryRegion
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS Address;
GO

-- Membuat tabel Address
CREATE TABLE Address (
    AddressID INT PRIMARY KEY,
    AddressLine1 NVARCHAR(100),
    AddressLine2 NVARCHAR(100),
    City NVARCHAR(50),
    StateProvinceID INT,
    PostalCode NVARCHAR(20),
    ModifiedDate DATETIME,
    CONSTRAINT FK_StateProvince_Address FOREIGN KEY (StateProvinceID) REFERENCES StateProvince (StateProvinceID)
);
GO

-- Menambahkan contoh data ke dalam tabel Address sesuai dengan contoh negara
INSERT INTO Address (AddressID, AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, ModifiedDate)
VALUES 
    (1, 'Jalan Kabul 1', NULL, 'Kabul', 1, '12345', GETDATE()),
    (2, 'Jalan Manama 2', NULL, 'Manama', 2, '67890', GETDATE()),
    (3, 'Jalan Beijing 3', NULL, 'Beijing', 3, '10001', GETDATE()),
    (4, 'Jalan Berlin 4', NULL, 'Berlin', 4, '20001', GETDATE()),
    (5, 'Jalan Copenhagen 5', NULL, 'Copenhagen', 5, '30001', GETDATE()),
    (6, 'Jalan Cairo 6', NULL, 'Cairo', 6, '40001', GETDATE()),
    (7, 'Jalan Paris 7', NULL, 'Paris', 7, '50001', GETDATE()),
    (8, 'Jalan London 8', NULL, 'London', 8, '60001', GETDATE()),
    (9, 'Jalan Budapest 9', NULL, 'Budapest', 9, '70001', GETDATE()),
    (10, 'Jalan New Delhi 10', NULL, 'New Delhi', 10, '80001', GETDATE()),
    (11, 'Jalan Tokyo 11', NULL, 'Tokyo', 11, '90001', GETDATE()),
    (12, 'Jalan Seoul 12', NULL, 'Seoul', 12, '100001', GETDATE()),
    (13, 'Jalan Beirut 13', NULL, 'Beirut', 13, '110001', GETDATE()),
    (14, 'Jalan Kuala Lumpur 14', NULL, 'Kuala Lumpur', 14, '120001', GETDATE()),
    (15, 'Jalan Amsterdam 15', NULL, 'Amsterdam', 15, '130001', GETDATE()),
    (16, 'Jalan Muscat 16', NULL, 'Muscat', 16, '140001', GETDATE()),
    (17, 'Jalan Islamabad 17', NULL, 'Islamabad', 17, '150001', GETDATE()),
    (18, 'Jalan Doha 18', NULL, 'Doha', 18, '160001', GETDATE()),
    (19, 'Jalan Moscow 19', NULL, 'Moscow', 19, '170001', GETDATE()),
    (20, 'Jalan Riyadh 20', NULL, 'Riyadh', 20, '180001', GETDATE());
-- Tambahkan entri alamat lainnya dengan StateProvinceID yang benar dari tabel StateProvince
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS BusinessEntityAddress;
GO

-- Membuat tabel BusinessEntityAddress
CREATE TABLE BusinessEntityAddress (
    BusinessEntityID INT,
    AddressID INT,
    AddressTypeID INT,
    ModifiedDate DATETIME,
    CONSTRAINT FK_BE_Address_BusinessEntity FOREIGN KEY (BusinessEntityID) REFERENCES BusinessEntity(BusinessEntityID),
    CONSTRAINT FK_Address_AddressType_BusinessEntity FOREIGN KEY (AddressID) REFERENCES Address(AddressID),
    CONSTRAINT FK_AddressType_Address_BusinessEntity FOREIGN KEY (AddressTypeID) REFERENCES AddressType(AddressTypeID)
);
GO

-- Menambahkan data dummy ke dalam tabel BusinessEntityAddress untuk BusinessEntityID 1 hingga 10
INSERT INTO BusinessEntityAddress (BusinessEntityID, AddressID, AddressTypeID, ModifiedDate)
VALUES 
    (1, 2, 1, GETDATE()),
    (2, 4, 2, GETDATE()),
    (3, 6, 3, GETDATE()),
    (4, 8, 1, GETDATE()),
    (5, 10, 2, GETDATE()),
    (6, 11, 3, GETDATE()),
    (7, 12, 4, GETDATE()),
    (8, 13, 4, GETDATE()),
    (9, 1, 4, GETDATE()),
    (10, 3, 6, GETDATE());
-- Pastikan nilai-nilai AddressID dan AddressTypeID sesuai dengan data yang valid dalam tabel referensi
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS Person;
GO

-- Membuat tabel Person
CREATE TABLE Person (
    PersonID INT PRIMARY KEY,
    BusinessEntityID INT,
    PersonType NVARCHAR(2),
    Title NVARCHAR(10),
    FirstName NVARCHAR(50),
    MiddleName NVARCHAR(50),
    LastName NVARCHAR(50),
    Suffix NVARCHAR(10),
    EmailPromotion INT,
    ModifiedDate DATETIME,
    CONSTRAINT FK_BE_Person_BusinessEntity FOREIGN KEY (BusinessEntityID) REFERENCES BusinessEntity(BusinessEntityID)
);
GO

-- Menambahkan contoh data tambahan ke dalam tabel Person hingga 20 entri
INSERT INTO Person (PersonID, BusinessEntityID, PersonType, Title, FirstName, MiddleName, LastName, Suffix, EmailPromotion, ModifiedDate)
VALUES 
    (1, 1, 'EM', 'Mr.', 'John', 'Doe', NULL, NULL, 1, GETDATE()),
    (2, 2, 'SC', 'Ms.', 'Jane', 'Lee', NULL, 'Jr', 0, GETDATE()),
    (3, 3, 'VC', NULL, 'Alice', NULL, 'Smith', NULL, 2, GETDATE()),
    (4, 4, 'IN', NULL, 'David', 'James', 'Brown', 'IX', 3, GETDATE()),
    (5, 5, 'EM', 'Mr.', 'Michael', NULL, 'Anderson', NULL, 1, GETDATE()),
    (6, 6, 'SC', 'Ms.', 'Sophia', 'Grace', 'Clark', 'Sr', 0, GETDATE()),
    (7, 7, 'VC', NULL, 'Olivia', NULL, 'Taylor', NULL, 2, GETDATE()),
    (8, 8, 'IN', NULL, 'William', 'Robert', 'Johnson', 'III', 3, GETDATE()),
    (9, 9, 'EM', 'Ms.', 'Ava', NULL, 'Martinez', NULL, 1, GETDATE()),
    (10, 10, 'SC', 'Mr.', 'Noah', 'Ethan', 'Perez', 'Jr', 0, GETDATE()),
    (11, 11, 'VC', NULL, 'James', NULL, 'Garcia', NULL, 2, GETDATE()),
    (12, 12, 'IN', NULL, 'Isabella', 'Lily', 'Turner', 'II', 3, GETDATE()),
    (13, 13, 'EM', 'Mr.', 'Sophie', NULL, 'Harris', NULL, 1, GETDATE()),
    (14, 14, 'SC', 'Ms.', 'Mia', 'Evelyn', 'Lee', 'Sr', 0, GETDATE()),
    (15, 15, 'VC', NULL, 'Emily', NULL, 'Allen', NULL, 2, GETDATE()),
    (16, 16, 'IN', NULL, 'Lucas', 'Owen', 'Scott', 'III', 3, GETDATE()),
    (17, 17, 'EM', 'Ms.', 'Liam', NULL, 'Walker', NULL, 1, GETDATE()),
    (18, 18, 'SC', 'Mr.', 'Emma', 'Avery', 'Phillips', 'Jr', 0, GETDATE()),
    (19, 19, 'VC', NULL, 'Harper', NULL, 'Gonzalez', NULL, 2, GETDATE()),
    (20, 20, 'IN', NULL, 'Ella', 'Grace', 'White', 'II', 3, GETDATE());
-- Tambahkan entri Person lainnya sesuai kebutuhan
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS EmailAddress;
GO

-- Membuat tabel EmailAddress
CREATE TABLE EmailAddress (
    EmailAddressID INT PRIMARY KEY,
    BusinessEntityID INT,
    EmailAddress NVARCHAR(100),
    ModifiedDate DATETIME,
    CONSTRAINT FK_BE_EmailAddress_BusinessEntity FOREIGN KEY (BusinessEntityID) REFERENCES BusinessEntity(BusinessEntityID)
);
GO

-- Menambahkan contoh data ke dalam tabel EmailAddress
INSERT INTO EmailAddress (EmailAddressID, BusinessEntityID, EmailAddress, ModifiedDate)
VALUES 
    (1, 1, 'john.doe@example.com', GETDATE()),
    (2, 2, 'jane.lee@example.com', GETDATE()),
    (3, 3, 'alice.smith@example.com', GETDATE()),
    (4, 4, 'david.brown@example.com', GETDATE()),
    (5, 5, 'michael.anderson@example.com', GETDATE()),
    (6, 6, 'sophia.clark@example.com', GETDATE()),
    (7, 7, 'olivia.taylor@example.com', GETDATE()),
    (8, 8, 'william.johnson@example.com', GETDATE()),
    (9, 9, 'ava.martinez@example.com', GETDATE()),
    (10, 10, 'noah.perez@example.com', GETDATE()),
    (11, 11, 'james.garcia@example.com', GETDATE()),
    (12, 12, 'isabella.turner@example.com', GETDATE()),
    (13, 13, 'sophie.harris@example.com', GETDATE()),
    (14, 14, 'mia.lee@example.com', GETDATE()),
    (15, 15, 'emily.allen@example.com', GETDATE()),
    (16, 16, 'lucas.scott@example.com', GETDATE()),
    (17, 17, 'liam.walker@example.com', GETDATE()),
    (18, 18, 'emma.phillips@example.com', GETDATE()),
    (19, 19, 'harper.gonzalez@example.com', GETDATE()),
    (20, 20, 'ella.white@example.com', GETDATE());
-- Tambahkan entri EmailAddress lainnya sesuai kebutuhan
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS Password;
GO

-- Membuat tabel Password
CREATE TABLE Password (
    PasswordID INT PRIMARY KEY,
    BusinessEntityID INT,
    Password NVARCHAR(50),
    ModifiedDate DATETIME,
    CONSTRAINT FK_BE_Password_BusinessEntity FOREIGN KEY (BusinessEntityID) REFERENCES BusinessEntity(BusinessEntityID)
);
GO

-- Menambahkan contoh data ke dalam tabel Password
INSERT INTO Password (PasswordID, BusinessEntityID, Password, ModifiedDate)
VALUES 
    (1, 1, 'Passw0rd!', GETDATE()),
    (2, 2, 'Secure123', GETDATE()),
    (3, 3, 'P@ssw0rd', GETDATE()),
    (4, 4, 'StrongP@ss', GETDATE()),
    (5, 5, 'Secret123', GETDATE()),
    (6, 6, 'Passw0rd!', GETDATE()),
    (7, 7, 'Secure123', GETDATE()),
    (8, 8, 'P@ssw0rd', GETDATE()),
    (9, 9, 'StrongP@ss', GETDATE()),
    (10, 10, 'Secret123', GETDATE()),
    (11, 11, 'Passw0rd!', GETDATE()),
    (12, 12, 'Secure123', GETDATE()),
    (13, 13, 'P@ssw0rd', GETDATE()),
    (14, 14, 'StrongP@ss', GETDATE()),
    (15, 15, 'Secret123', GETDATE()),
    (16, 16, 'Passw0rd!', GETDATE()),
    (17, 17, 'Secure123', GETDATE()),
    (18, 18, 'P@ssw0rd', GETDATE()),
    (19, 19, 'StrongP@ss', GETDATE()),
    (20, 20, 'Secret123', GETDATE());
-- Tambahkan entri Password lainnya sesuai kebutuhan
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS BusinessEntityContact;
GO

-- Membuat tabel BusinessEntityContact
CREATE TABLE BusinessEntityContact (
    BusinessEntityID INT,
    PersonID INT,
    ContactTypeID INT,
    ModifiedDate DATETIME,
    CONSTRAINT FK_BEContact_BusinessEntity FOREIGN KEY (BusinessEntityID) REFERENCES BusinessEntity(BusinessEntityID),
    CONSTRAINT FK_BEContact_Person FOREIGN KEY (PersonID) REFERENCES Person(PersonID),
    CONSTRAINT FK_BEContact_ContactType FOREIGN KEY (ContactTypeID) REFERENCES ContactType(ContactTypeID)
);
GO

-- Menambahkan contoh data ke dalam tabel BusinessEntityContact
INSERT INTO BusinessEntityContact (BusinessEntityID, PersonID, ContactTypeID, ModifiedDate)
VALUES 
    (11, 1, 11, GETDATE()),
    (12, 2, 11, GETDATE()),
    (13, 3, 14, GETDATE()),
    (14, 4, 14, GETDATE()),
    (15, 5, 14, GETDATE()),
    (16, 6, 11, GETDATE()),
    (17, 7, 11, GETDATE()),
    (18, 8, 15, GETDATE()),
    (19, 9, 15, GETDATE()),
    (20, 10, 15, GETDATE());
-- Tambahkan entri BusinessEntityContact lainnya sesuai kebutuhan
GO

-- Menghapus tabel StateProvince jika diperlukan
DROP TABLE IF EXISTS PersonPhone;
GO

-- Membuat tabel PersonPhone
CREATE TABLE PersonPhone (
    BusinessEntityID INT,
    PhoneNumber NVARCHAR(20),
    PhoneNumberTypeID INT,
    ModifiedDate DATETIME,
    CONSTRAINT FK_PersonPhone_BusinessEntity FOREIGN KEY (BusinessEntityID) REFERENCES BusinessEntity(BusinessEntityID),
    CONSTRAINT FK_PersonPhone_PhoneNumberType FOREIGN KEY (PhoneNumberTypeID) REFERENCES PhoneNumberType(PhoneNumberTypeID)
);
GO

-- Menambahkan contoh data ke dalam tabel PersonPhone
INSERT INTO PersonPhone (BusinessEntityID, PhoneNumber, PhoneNumberTypeID, ModifiedDate)
VALUES 
    (1, '123456789', 1, GETDATE()),
    (2, '987654321', 2, GETDATE()),
    (3, '111222333', 3, GETDATE()),
    (4, '444555666', 1, GETDATE()),
    (5, '777888999', 2, GETDATE()),
    (6, '123450987', 3, GETDATE()),
    (7, '555444333', 1, GETDATE()),
    (8, '666777888', 2, GETDATE()),
    (9, '888999000', 3, GETDATE()),
    (10, '112233445', 1, GETDATE()),
    (11, '556677889', 2, GETDATE()),
    (12, '990011223', 3, GETDATE()),
    (13, '334455667', 1, GETDATE()),
    (14, '998877665', 2, GETDATE()),
    (15, '332211990', 3, GETDATE()),
    (16, '667788990', 1, GETDATE()),
    (17, '443322110', 2, GETDATE()),
    (18, '114477889', 3, GETDATE()),
    (19, '336699887', 1, GETDATE()),
    (20, '778899001', 2, GETDATE());
-- Tambahkan entri PersonPhone lainnya sesuai kebutuhan
GO

