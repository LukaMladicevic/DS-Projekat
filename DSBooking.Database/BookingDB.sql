GO
USE master;
GO
DROP DATABASE BookingDB
GO
CREATE DATABASE BookingDB;
GO
USE BookingDB;
CREATE TABLE Clients(
	id INT PRIMARY KEY IDENTITY(1,1),
	firstname VARCHAR(255) NOT NULL,
	lastname VARCHAR(255) NOT NULL,
	passport_no VARCHAR(13) NOT NULL,
	email_address VARCHAR(255) NOT NULL,
	phone_no VARCHAR(255) NOT NULL,
	CHECK(LEN(passport_no) = 13)
);


GO
CREATE TABLE Destinations(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE TransportTypes(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE AccomodationTypes(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE AdditionalActivites(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE Guides(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE Ships(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE Routes(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE CabinTypes(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL
);

GO
CREATE TABLE Packages(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL,
	price FLOAT NOT NULL,
	package_type INT NOT NULL,
	destination_id INT FOREIGN KEY REFERENCES Destinations(id),
	transport_type_id INT FOREIGN KEY REFERENCES TransportTypes(id),
	accomodation_type_id INT FOREIGN KEY REFERENCES AccomodationTypes(id),
	additional_acttivities_id INT FOREIGN KEY REFERENCES AdditionalActivites(id),
	guide_id INT FOREIGN KEY REFERENCES Guides(id),
	length_in_days INT,
	ship_id INT FOREIGN KEY REFERENCES Ships(id),
	route_id INT FOREIGN KEY REFERENCES Routes(id),
	date_of_departure DATE,
	cabin_type_id INT FOREIGN KEY REFERENCES CabinTypes(id),
);
-- Tipovi:
-- 1 -> More
-- 2-> Planine
-- 3-> Ekskurzije
-- 4-> Krstarenje
GO
CREATE TABLE Reservations(
	id INT PRIMARY KEY IDENTITY(1,1),
	client_id INT FOREIGN KEY REFERENCES Clients(id),
	package_id INT FOREIGN KEY REFERENCES Packages(id),
	date DATE NOT NULL
);


GO
CREATE OR ALTER TRIGGER TriggerPackageCheck
ON Packages
AFTER INSERT, UPDATE
AS
BEGIN
    -- Paket tipa 1 = More
    IF EXISTS(
        SELECT 1
        FROM inserted i
        WHERE i.package_type = 1 AND
              (
                i.destination_id IS NULL OR 
                i.transport_type_id IS NULL OR 
                i.accomodation_type_id IS NULL OR
                i.additional_acttivities_id IS NOT NULL OR
                i.guide_id IS NOT NULL OR
                i.length_in_days IS NOT NULL OR
                i.ship_id IS NOT NULL OR
                i.route_id IS NOT NULL OR
                i.date_of_departure IS NOT NULL OR
                i.cabin_type_id IS NOT NULL
              )
    )
    BEGIN
        RAISERROR('Invalid input/update for SeaPackage. Required: destination_id, transport_type_id, accomodation_type_id; all others must be NULL',16,1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Paket tipa 2 = Planine
    IF EXISTS(
        SELECT 1
        FROM inserted i
        WHERE i.package_type = 2 AND
              (
                i.destination_id IS NULL OR
                i.transport_type_id IS NULL OR
                i.accomodation_type_id IS NULL OR
                i.additional_acttivities_id IS NULL OR
                i.guide_id IS NOT NULL OR
                i.length_in_days IS NOT NULL OR
                i.ship_id IS NOT NULL OR
                i.route_id IS NOT NULL OR
                i.date_of_departure IS NOT NULL OR
                i.cabin_type_id IS NOT NULL
              )
    )
    BEGIN
        RAISERROR('Invalid input/update for MountainPackage. Required: destination_id, transport_type_id, accomodation_type_id, additional_activities_id; all others must be NULL',16,1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Paket tipa 3 = Ekskurzija
    IF EXISTS(
        SELECT 1
        FROM inserted i
        WHERE i.package_type = 3 AND
              (
                i.destination_id IS NULL OR
                i.transport_type_id IS NULL OR
                i.guide_id IS NULL OR
                i.length_in_days IS NULL OR
                i.additional_acttivities_id IS NULL OR
                i.accomodation_type_id IS NOT NULL OR
                i.ship_id IS NOT NULL OR
                i.route_id IS NOT NULL OR
                i.date_of_departure IS NOT NULL OR
                i.cabin_type_id IS NOT NULL
              )
    )
    BEGIN
        RAISERROR('Invalid input/update for ExcursionPackage. Required: destination_id, transport_type_id, guide_id, length_in_days, additional_activities_id; all others must be NULL',16,1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Paket tipa 4 = Krstarenje
    IF EXISTS(
        SELECT 1
        FROM inserted i
        WHERE i.package_type = 4 AND
              (
                i.ship_id IS NULL OR
                i.route_id IS NULL OR
                i.date_of_departure IS NULL OR
                i.cabin_type_id IS NULL OR
                i.destination_id IS NOT NULL OR
                i.transport_type_id IS NOT NULL OR
                i.accomodation_type_id IS NOT NULL OR
                i.additional_acttivities_id IS NOT NULL OR
                i.guide_id IS NOT NULL OR
                i.length_in_days IS NOT NULL
              )
    )
    BEGIN
        RAISERROR('Invalid input/update for CruisePackage. Required: ship_id, route_id, date_of_departure, cabin_type_id; all others must be NULL',16,1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
GO

--Test Podaci:

-- Clients
INSERT INTO Clients (firstname, lastname, passport_no, email_address, phone_no)
VALUES 
('Marko', 'Petrovic', 'RS12345678901', 'marko.petrovic@example.com', '+381601234567'),
('Ana', 'Jovanovic', 'RS98765432109', 'ana.jovanovic@example.com', '+381641112223'),
('Luka', 'Mladicevic', 'RS45678912345', 'luka.mladicevic@example.com', '+381621234567');

-- Destinations
INSERT INTO Destinations ([name]) VALUES
('Grcka'),
('Francuska'),
('Italija'),
('Spanija');

-- TransportTypes
INSERT INTO TransportTypes ([name]) VALUES
('Avion'),
('Autobus'),
('Brod');

-- AccomodationTypes
INSERT INTO AccomodationTypes ([name]) VALUES
('Hotel 3*'),
('Hotel 4*'),
('Apartman');

-- AdditionalActivites
INSERT INTO AdditionalActivites ([name]) VALUES
('Skijanje'),
('Ronjenje'),
('Obilazak muzeja'),
('Spa & Wellness');

-- Guides
INSERT INTO Guides ([name]) VALUES
('Dzimi Neutron'),
('Burgito Madre'),
('Igor Perovic');

-- Ships
INSERT INTO Ships ([name]) VALUES
('MSC Grandiosa'),
('Costa Venezia'),
('Norwegian Epic');

-- Routes
INSERT INTO Routes ([name]) VALUES
('Mediteranska ruta'),
('Karipska ruta'),
('Severna Evropa');

-- CabinTypes
INSERT INTO CabinTypes ([name]) VALUES
('Unutrašnja kabina'),
('Kabina s pogledom'),
('Suite');

-- Packages
-- 1 = More
INSERT INTO Packages ([name], price, package_type, destination_id, transport_type_id, accomodation_type_id)
VALUES ('Letovanje na Malti', 550.00, 1, 1, 1, 2);

-- 2 = Planine
INSERT INTO Packages ([name], price, package_type, destination_id, transport_type_id, accomodation_type_id, additional_acttivities_id)
VALUES ('Zimovanje na Alpima', 1200.00, 2, 2, 1, 1, 1);

-- 3 = Ekskurzija
INSERT INTO Packages ([name], price, package_type, destination_id, transport_type_id, guide_id, length_in_days, additional_acttivities_id)
VALUES ('Ekskurzija SNS-Valjevo', 800.00, 3, 3, 2, 3, 5, 3);

-- 4 = Krstarenje
INSERT INTO Packages ([name], price, package_type, ship_id, route_id, date_of_departure, cabin_type_id)
VALUES ('Krstarenje Mediteranom', 2000.00, 4, 1, 1, '2025-06-15', 2);

-- Reservations
INSERT INTO Reservations (client_id, package_id, date)
VALUES
(1, 1, '2025-07-01'),
(2, 2, '2025-01-10'),
(3, 3, '2025-04-05'),
(1, 4, '2025-06-15');

GO
SELECT * FROM Clients
SELECT * FROM Destinations
SELECT * FROM TransportTypes
SELECT * FROM AccomodationTypes
SELECT * FROM AdditionalActivites
SELECT * FROM Guides
SELECT * FROM Ships
SELECT * FROM Routes
SELECT * FROM CabinTypes
SELECT * FROM Packages
SELECT * FROM Reservations
