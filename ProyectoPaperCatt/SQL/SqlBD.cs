
// Codigo para SQL Server Management Studio

/* 
 
-- Limpiar si la DB ya existe (opcional, pero recomendado para pruebas)
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'PaperCatt')
    DROP DATABASE PaperCatt;

-- Crear la base de datos (SQL Server usa collation por defecto para UTF-8 en versiones recientes; ajusta si es necesario)
CREATE DATABASE PaperCatt;
GO

-- Usar la base de datos
USE PaperCatt;
GO

-- Tabla de Perfiles (creada PRIMERO para evitar issues con FK)
CREATE TABLE Perfiles (
    IdPerfil INT IDENTITY(1,1) PRIMARY KEY,
    NombrePerfil VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200)
);
GO

-- Tabla de Usuarios (ahora después de Perfiles)
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    ApellidoP VARCHAR(100) NOT NULL,
    ApellidoM VARCHAR(100) NULL,
    Correo VARCHAR(150) NOT NULL,
    Telefono VARCHAR(20),
    UserName VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(200) NOT NULL,
    IdPerfil INT NOT NULL,
    Estatus INT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FechaUltAcceso DATETIME NULL
);
GO

-- Tabla de Clientes
CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    No INT NOT NULL,
    NombreCompleto VARCHAR(200) NOT NULL,
    RFC VARCHAR(13) NULL,
    CURP VARCHAR(18) NULL,
    Correo VARCHAR(150),
    Celular VARCHAR(20),
    Domicilio VARCHAR(250),
    CodigoPostal VARCHAR(10),
    Pais VARCHAR(50),
    Estado VARCHAR(50),
    Ciudad VARCHAR(50),
    FechaNacimiento DATE
);
GO

-- Tabla de Productos
CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL,
    Costo DECIMAL(10,2) NOT NULL,
    Venta DECIMAL(10,2) NOT NULL,
    UnidadMedida VARCHAR(50),
    Proveedor VARCHAR(100),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    Stock INT DEFAULT 0,
    Imagen VARCHAR(MAX) NULL  -- TEXT no existe en SQL Server; usa VARCHAR(MAX) para texto largo
);
GO

-- Tabla de Configuración
CREATE TABLE Configuracion (
    IdConfig INT IDENTITY(1,1) PRIMARY KEY,
    NombreEmp VARCHAR(200) NOT NULL,
    RFCEmp VARCHAR(13) NOT NULL,
    DireccionEmp VARCHAR(250),
    NombreSucursal VARCHAR(200),
    DireccionSucursal VARCHAR(250),
    Correo VARCHAR(150),
    TasaIVA INT DEFAULT 16,
    Moneda VARCHAR(10) DEFAULT 'MXN'
);
GO

-- Llaves foráneas (agregada después de crear las tablas)
ALTER TABLE Usuarios
ADD CONSTRAINT FK_Usuarios_Perfiles
FOREIGN KEY (IdPerfil) REFERENCES Perfiles(IdPerfil)
ON DELETE NO ACTION  -- Equivalente a RESTRICT en MySQL
ON UPDATE CASCADE;
GO

-- INSERTs de ejemplo para probar (opcionales, pero verifica que funcione)
INSERT INTO Perfiles (NombrePerfil, Descripcion) VALUES 
('Admin', 'Administrador del sistema'),
('Usuario', 'Usuario estándar');

INSERT INTO Usuarios (Nombre, ApellidoP, ApellidoM, Correo, UserName, Password, IdPerfil)
VALUES ('Juan', 'Pérez', 'García', 'juan@example.com', 'juanp', 'password_segura_aqui', 1);

-- Verifica las tablas (estos SELECTs mostrarán los datos)
SELECT * FROM Perfiles;
SELECT * FROM Usuarios;
GO

 */













// Codigo para XAMP
/*


--Limpiar si la DB ya existe (opcional, pero recomendado para pruebas)
DROP DATABASE IF EXISTS PaperCatt;

--Crear la base de datos con soporte para caracteres especiales (acentos, etc.)
CREATE DATABASE PaperCatt CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

--Usar la base de datos
USE PaperCatt;

--Tabla de Perfiles(creada PRIMERO para evitar issues con FK)
CREATE TABLE Perfiles (
    IdPerfil INT AUTO_INCREMENT PRIMARY KEY,
    NombrePerfil VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--Tabla de Usuarios(ahora después de Perfiles)
CREATE TABLE Usuarios (
    IdUsuario INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    ApellidoP VARCHAR(100) NOT NULL,
    ApellidoM VARCHAR(100) NULL,
    Correo VARCHAR(150) NOT NULL,
    Telefono VARCHAR(20),
    UserName VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(200) NOT NULL,
    IdPerfil INT NOT NULL,
    Estatus INT DEFAULT 1,
    FechaRegistro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FechaUltAcceso TIMESTAMP NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--Tabla de Clientes
CREATE TABLE Clientes (
    IdCliente INT AUTO_INCREMENT PRIMARY KEY,
    No INT NOT NULL,
    NombreCompleto VARCHAR(200) NOT NULL,
    RFC VARCHAR(13) NULL,
    CURP VARCHAR(18) NULL,
    Correo VARCHAR(150),
    Celular VARCHAR(20),
    Domicilio VARCHAR(250),
    CodigoPostal VARCHAR(10),
    Pais VARCHAR(50),
    Estado VARCHAR(50),
    Ciudad VARCHAR(50),
    FechaNacimiento DATE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--Tabla de Productos
CREATE TABLE Productos (
    IdProducto INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL,
    Costo DECIMAL(10,2) NOT NULL,
    Venta DECIMAL(10,2) NOT NULL,
    UnidadMedida VARCHAR(50),
    Proveedor VARCHAR(100),
    FechaRegistro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Stock INT DEFAULT 0,
    Imagen TEXT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--Tabla de Configuración
CREATE TABLE Configuracion (
    IdConfig INT AUTO_INCREMENT PRIMARY KEY,
    NombreEmp VARCHAR(200) NOT NULL,
    RFCEmp VARCHAR(13) NOT NULL,
    DireccionEmp VARCHAR(250),
    NombreSucursal VARCHAR(200),
    DireccionSucursal VARCHAR(250),
    Correo VARCHAR(150),
    TasaIVA INT DEFAULT 16,
    Moneda VARCHAR(10) DEFAULT 'MXN'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--Llaves foráneas(agregada después de crear las tablas)
ALTER TABLE Usuarios
ADD CONSTRAINT FK_Usuarios_Perfiles
FOREIGN KEY (IdPerfil) REFERENCES Perfiles(IdPerfil)
ON DELETE RESTRICT ON UPDATE CASCADE;

--INSERTs de ejemplo para probar (opcionales, pero verifica que funcione)
INSERT INTO Perfiles (NombrePerfil, Descripcion) VALUES 
('Admin', 'Administrador del sistema'),
('Usuario', 'Usuario estándar');

INSERT INTO Usuarios (Nombre, ApellidoP, ApellidoM, Correo, UserName, Password, IdPerfil)
VALUES ('Juan', 'Pérez', 'García', 'juan@example.com', 'juanp', 'password_segura_aqui', 1);

--Verifica las tablas(estos SELECTs mostrarán los datos)
SELECT* FROM Perfiles;
SELECT* FROM Usuarios;


 */