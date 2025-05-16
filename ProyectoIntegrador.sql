DROP DATABASE IF EXISTS Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE usuario(
idUsuario int auto_increment PRIMARY KEY,
nombreUsuario varchar (20),
passwordUsuario varchar (15)
);

CREATE TABLE socio(
	idSocio int auto_increment PRIMARY KEY,
	nombre varchar (20),
	apellido varchar (20),
	dni int,
	email varchar(40),
	fechaEmisionCarnet datetime
);

CREATE TABLE noSocio(
	idNoSocio int auto_increment PRIMARY KEY,
	nombre varchar (20),
	apellido varchar (20),
	dni int,
	email varchar(40)
);

CREATE TABLE actividad(
	idActividad int auto_increment PRIMARY KEY,
    nombre varchar(30),
    precio float,
    horario datetime,
    cupo int
);

CREATE TABLE noSocio_actividad(
	idNoSocio int,
    idActividad int,
    PRIMARY KEY(idNoSocio, idActividad),
    FOREIGN KEY (idNoSocio) REFERENCES noSocio(idNoSocio),
    FOREIGN KEY (idActividad) REFERENCES actividad(idActividad)
);

CREATE TABLE cuota (
    idCuota INT AUTO_INCREMENT PRIMARY KEY,
    valorCuota FLOAT NOT NULL,
    formaPago VARCHAR(30) NOT NULL,
    fechaVencimiento DATE NOT NULL,
    cuotasTarjeta INT DEFAULT 0,
    idSocio INT NOT NULL,
    FOREIGN KEY (idSocio) REFERENCES socio(idSocio)
);


INSERT INTO usuario (NombreUsuario,PasswordUsuario) values 
("admin","admin");


delimiter //
CREATE PROCEDURE IngresoLogin(
    IN Usu VARCHAR(20),
    IN Pass VARCHAR(15)
)
BEGIN
    SELECT 1 AS LoginValido
    FROM usuario u
    WHERE u.nombreUsuario = Usu
      AND u.passwordUsuario = Pass
    LIMIT 1;
END
//
delimiter ;

DELIMITER //
CREATE PROCEDURE AltaSocio(
    IN nombre VARCHAR(20),
    IN apellido VARCHAR(20),
    IN dni INT,
    IN email VARCHAR(100),
    OUT rta INT
)
BEGIN
    DECLARE existe INT;

    SELECT COUNT(*) INTO existe FROM socio WHERE socio.dni = dni;

    IF existe = 0 THEN
        INSERT INTO socio (nombre, apellido, dni, email, fechaEmisionCarnet)
        VALUES (nombre, apellido, dni, email, NOW());
        SET rta = LAST_INSERT_ID();
    ELSE
        SET rta = -1;
    END IF;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE AltaNoSocio(
    IN nombre VARCHAR(20),
    IN apellido VARCHAR(20),
    IN dni INT,
    IN email VARCHAR(100),
    OUT rta INT
)
BEGIN
    DECLARE existe INT;

    SELECT COUNT(*) INTO existe FROM noSocio WHERE noSocio.dni = dni;

    IF existe = 0 THEN
        INSERT INTO noSocio (nombre, apellido, dni, email)
        VALUES (nombre, apellido, dni, email);
        SET rta = LAST_INSERT_ID();
    ELSE
        SET rta = -1;
    END IF;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE RegistrarCuota(
    IN idSocio INT,
    IN fechaVencimiento DATE,
    IN monto DOUBLE,
    IN medioPago VARCHAR(30),
    IN cuotasTarjeta INT
)
BEGIN
    INSERT INTO cuota (valorCuota, formaPago, fechaVencimiento, idSocio, cuotasTarjeta) 
    VALUES (monto,  medioPago,fechaVencimiento, idSocio, cuotasTarjeta);
END //
DELIMITER ;

-- select * from nosocio;
-- select * from socio;
-- select * from cuota;

-- Query para ver socio y fecha vencimiento de la cuota
-- select s.*, c.fechaVencimiento from socio s join cuota c on s.idSocio = c.idSocio;