create database CINE
use CINE

CREATE TABLE Roles (
    Roles_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Rol VARCHAR(50),
    Descripcion VARCHAR(255)
);


CREATE TABLE Usuarios (
    Usuarios_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nombre_Usuario varchar(20),
    Contraseña VARCHAR(255),
    Roles_ID INT,
    FOREIGN KEY (Roles_ID) REFERENCES Roles(Roles_ID)
);
-- Inserta los roles en la tabla Roles
INSERT INTO Roles (Rol, Descripcion) VALUES ('admin', 'Administrador del sistema');
INSERT INTO Roles (Rol, Descripcion) VALUES ('trabajador', 'Trabajador del sistema');

-- Inserta los usuarios en la tabla Usuarios
INSERT INTO Usuarios (Nombre_Usuario, Contraseña, Roles_ID) VALUES ('Oseguera', 'Oseguera', 1); -- Rol admin
INSERT INTO Usuarios (Nombre_Usuario, Contraseña, Roles_ID) VALUES ('Fercho', 'fercho', 2); -- Rol trabajador





CREATE TABLE salaDEADpol (
    SillaId INT PRIMARY KEY,
    Estado NVARCHAR(50) NOT NULL
);

INSERT INTO salaDEADpol (SillaId, Estado) VALUES (1, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (2, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (3, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (4, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (5, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (6, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (7, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (8, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (9, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (10, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (11, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (12, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (13, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (14, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (15, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (16, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (17, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (18, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (19, 'disponible');
INSERT INTO salaDEADpol (SillaId, Estado) VALUES (20, 'disponible');

CREATE TABLE salaIntensamente (
    SillaId INT PRIMARY KEY,
    Estado NVARCHAR(50) NOT NULL
);


INSERT INTO salaIntensamente (SillaId, Estado) VALUES (1, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (2, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (3, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (4, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (5, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (6, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (7, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (8, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (9, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (10, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (11, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (12, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (13, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (14, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (15, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (16, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (17, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (18, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (19, 'disponible');
INSERT INTO salaIntensamente (SillaId, Estado) VALUES (20, 'disponible');

CREATE TABLE Reservas (
    ReservaId INT PRIMARY KEY IDENTITY(1,1),
    Pelicula NVARCHAR(100) NOT NULL,
    NombreCliente NVARCHAR(100) NOT NULL,
    DNI NVARCHAR(20) NOT NULL,
    Silla NVARCHAR(20) NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    Suelto DECIMAL(10, 2) NOT NULL
);




UPDATE salaDEADpol SET Estado = 'disponible' WHERE SillaId BETWEEN 1 AND 20;

UPDATE salaIntensamente SET Estado = 'disponible' WHERE SillaId BETWEEN 1 AND 20;

























