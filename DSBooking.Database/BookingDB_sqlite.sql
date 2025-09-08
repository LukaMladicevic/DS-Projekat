-- Clients
CREATE TABLE Clients(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  firstname TEXT NOT NULL,
  lastname TEXT NOT NULL,
  date_of_birth DATETIME NOT NULL,
  passport_no TEXT NOT NULL,
  email_address TEXT NOT NULL,
  phone_no TEXT NOT NULL,
  CHECK(length(passport_no) = 13)
);

-- Destinations
CREATE TABLE Destinations(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- TransportTypes
CREATE TABLE TransportTypes(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- AccommodationTypes (ispravljeno ime)
CREATE TABLE AccommodationTypes(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- AdditionalActivities (ispravljeno ime)
CREATE TABLE AdditionalActivities(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Guides
CREATE TABLE Guides(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Ships
CREATE TABLE Ships(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Routes
CREATE TABLE Routes(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- CabinTypes
CREATE TABLE CabinTypes(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Packages
CREATE TABLE Packages(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL,
  price REAL NOT NULL,
  package_type INTEGER NOT NULL,
  destination_id INTEGER REFERENCES Destinations(id),
  transport_type_id INTEGER REFERENCES TransportTypes(id),
  accommodation_type_id INTEGER REFERENCES AccommodationTypes(id),
  additional_activities_id INTEGER REFERENCES AdditionalActivities(id),
  guide_id INTEGER REFERENCES Guides(id),
  length_in_days INTEGER,
  ship_id INTEGER REFERENCES Ships(id),
  route_id INTEGER REFERENCES Routes(id),
  date_of_departure DATETIME,
  cabin_type_id INTEGER REFERENCES CabinTypes(id)
);

-- Reservations
CREATE TABLE Reservations(
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  client_id INTEGER REFERENCES Clients(id),
  package_id INTEGER REFERENCES Packages(id),
  date_of_reservation DATETIME NOT NULL
);

-- Trigger checks: koriste NEW.* (po jednoj vrsti po ubacivanju/izmeni)
-- 1) Sea packages (type = 1)
-- CREATE TRIGGER TriggerPackageCheck_Sea
-- BEFORE INSERT OR UPDATE ON Packages
-- FOR EACH ROW
-- WHEN (
--   NEW.package_type = 1 AND (
--     NEW.destination_id IS NULL OR
--     NEW.transport_type_id IS NULL OR
--     NEW.accommodation_type_id IS NULL OR
--     NEW.additional_activities_id IS NOT NULL OR
--     NEW.guide_id IS NOT NULL OR
--     NEW.length_in_days IS NOT NULL OR
--     NEW.ship_id IS NOT NULL OR
--     NEW.route_id IS NOT NULL OR
--     NEW.date_of_departure IS NOT NULL OR
--     NEW.cabin_type_id IS NOT NULL
--   )
-- )
-- BEGIN
--   SELECT RAISE(ABORT, 'Invalid input for SeaPackage: required destination_id, transport_type_id, accommodation_type_id; all others must be NULL.');
-- END;

-- 2) Mountain packages (type = 2)
-- CREATE TRIGGER TriggerPackageCheck_Mountain
-- BEFORE INSERT OR UPDATE ON Packages
-- FOR EACH ROW
-- WHEN (
--   NEW.package_type = 2 AND (
--     NEW.destination_id IS NULL OR
--     NEW.transport_type_id IS NULL OR
--     NEW.accommodation_type_id IS NULL OR
--     NEW.additional_activities_id IS NULL OR
--     NEW.guide_id IS NOT NULL OR
--     NEW.length_in_days IS NOT NULL OR
--     NEW.ship_id IS NOT NULL OR
--     NEW.route_id IS NOT NULL OR
--     NEW.date_of_departure IS NOT NULL OR
--     NEW.cabin_type_id IS NOT NULL
--   )
-- )
-- BEGIN
--   SELECT RAISE(ABORT, 'Invalid input for MountainPackage: required destination_id, transport_type_id, accommodation_type_id, additional_activities_id; others must be NULL.');
-- END;

-- 3) Excursion packages (type = 3)
-- CREATE TRIGGER TriggerPackageCheck_Excursion
-- BEFORE INSERT OR UPDATE ON Packages
-- FOR EACH ROW
-- WHEN (
--   NEW.package_type = 3 AND (
--     NEW.destination_id IS NULL OR
--     NEW.transport_type_id IS NULL OR
--     NEW.guide_id IS NULL OR
--     NEW.length_in_days IS NULL OR
--     NEW.additional_activities_id IS NULL OR
--     NEW.accommodation_type_id IS NOT NULL OR
--     NEW.ship_id IS NOT NULL OR
--     NEW.route_id IS NOT NULL OR
--     NEW.date_of_departure IS NOT NULL OR
--     NEW.cabin_type_id IS NOT NULL
--   )
-- )
-- BEGIN
--   SELECT RAISE(ABORT, 'Invalid input for ExcursionPackage: required destination_id, transport_type_id, guide_id, length_in_days, additional_activities_id; others must be NULL.');
-- END;

-- 4) Cruise packages (type = 4)
-- CREATE TRIGGER TriggerPackageCheck_Cruise
-- BEFORE INSERT OR UPDATE ON Packages
-- FOR EACH ROW
-- WHEN (
--   NEW.package_type = 4 AND (
--     NEW.ship_id IS NULL OR
--     NEW.route_id IS NULL OR
--     NEW.date_of_departure IS NULL OR
--     NEW.cabin_type_id IS NULL OR
--     NEW.destination_id IS NOT NULL OR
--     NEW.transport_type_id IS NOT NULL OR
--     NEW.accommodation_type_id IS NOT NULL OR
--     NEW.additional_activities_id IS NOT NULL OR
--     NEW.guide_id IS NOT NULL OR
--     NEW.length_in_days IS NOT NULL
--   )
-- )
-- BEGIN
--   SELECT RAISE(ABORT, 'Invalid input for CruisePackage: required ship_id, route_id, date_of_departure, cabin_type_id; others must be NULL.');
-- END;

-- Test podaci:

-- Clients
INSERT INTO Clients (firstname, lastname, date_of_birth, passport_no, email_address, phone_no) VALUES
('Marko', 'Petrovic', '1990-05-14 00:00:00', 'RS12345678901', 'marko.petrovic@example.com', '+381601234567'),
('Ana', 'Jovanovic', '1992-09-22 00:00:00', 'RS98765432109', 'ana.jovanovic@example.com', '+381641112223'),
('Luka', 'Mladicevic', '1988-03-05 00:00:00', 'RS45678912345', 'luka.mladicevic@example.com', '+381621234567');

-- Destinations
INSERT INTO Destinations (name) VALUES
('Grcka'),
('Francuska'),
('Italija'),
('Spanija');

-- TransportTypes
INSERT INTO TransportTypes (name) VALUES
('Avion'),
('Autobus'),
('Brod');

-- AccommodationTypes
INSERT INTO AccommodationTypes (name) VALUES
('Hotel 3*'),
('Hotel 4*'),
('Apartman');

-- AdditionalActivities
INSERT INTO AdditionalActivities (name) VALUES
('Skijanje'),
('Ronjenje'),
('Obilazak muzeja'),
('Spa & Wellness');

-- Guides
INSERT INTO Guides (name) VALUES
('Dzimi Neutron'),
('Burgito Madre'),
('Igor Perovic');

-- Ships
INSERT INTO Ships (name) VALUES
('MSC Grandiosa'),
('Costa Venezia'),
('Norwegian Epic');

-- Routes
INSERT INTO Routes (name) VALUES
('Mediteranska ruta'),
('Karipska ruta'),
('Severna Evropa');

-- CabinTypes
INSERT INTO CabinTypes (name) VALUES
('Unutrašnja kabina'),
('Kabina s pogledom'),
('Suite');

-- Packages
-- 1 = More (Sea)
INSERT INTO Packages (name, price, package_type, destination_id, transport_type_id, accommodation_type_id)
VALUES ('Letovanje na Malti', 550.00, 1, 1, 1, 2);

-- 2 = Planine (Mountain)
INSERT INTO Packages (name, price, package_type, destination_id, transport_type_id, accommodation_type_id, additional_activities_id)
VALUES ('Zimovanje na Alpima', 1200.00, 2, 2, 1, 1, 1);

-- 3 = Ekskurzija (Excursion)
INSERT INTO Packages (name, price, package_type, destination_id, transport_type_id, guide_id, length_in_days, additional_activities_id)
VALUES ('Ekskurzija SNS-Valjevo', 800.00, 3, 3, 2, 3, 5, 3);

-- 4 = Krstarenje (Cruise)
INSERT INTO Packages (name, price, package_type, ship_id, route_id, date_of_departure, cabin_type_id)
VALUES ('Krstarenje Mediteranom', 2000.00, 4, 1, 1, '2025-06-15 00:00:00', 2);

-- Reservations
INSERT INTO Reservations (client_id, package_id, date_of_reservation) VALUES
(1, 1, '2025-07-01 00:00:00'),
(2, 2, '2025-01-10 00:00:00'),
(3, 3, '2025-04-05 00:00:00'),
(1, 4, '2025-06-15 00:00:00');