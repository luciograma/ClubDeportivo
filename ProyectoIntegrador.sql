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
    horario time,
    cupo int
);

CREATE TABLE pagoActividad(
	idNoSocio int,
    idActividad int,
    fechaDePago datetime,
    PRIMARY KEY(idNoSocio, idActividad),
    FOREIGN KEY (idNoSocio) REFERENCES noSocio(idNoSocio),
    FOREIGN KEY (idActividad) REFERENCES actividad(idActividad)
);

CREATE TABLE cuota (
    idCuota INT AUTO_INCREMENT PRIMARY KEY,
    valorCuota FLOAT NOT NULL,
    formaPago VARCHAR(30) NOT NULL,
    fechaVencimiento DATE NOT NULL,
    cuotasTarjeta INT,
    idSocio INT NOT NULL,
    FOREIGN KEY (idSocio) REFERENCES socio(idSocio)
);


INSERT INTO usuario (NombreUsuario,PasswordUsuario) values 
("admin","admin");

INSERT INTO actividad (Nombre,Precio,Horario,Cupo) values
("Fútbol", 3000, "14:30:00", 12),
("Basquet", 3000, "17:00:00", 15),
("Natación", 4000, "15:30:00", 10),
("Yoga", 3500, "11:30:00", 3),
("Tenis", 5000, "18:00:00", 5);


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

delimiter //
CREATE PROCEDURE GetActividades()
BEGIN
    SELECT idActividad, nombre, precio, cupo
    FROM actividad;
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
    VALUES (monto, medioPago, fechaVencimiento, idSocio, cuotasTarjeta);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE InscribirActividad(
    IN idNoSocio INT,
    IN idActividad INT,
    IN fechaDePago DATETIME
)
BEGIN
    INSERT INTO pagoActividad (idNoSocio, idActividad, fechaDePago)
    VALUES (idNoSocio, idActividad, fechaDePago);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE HayCupoDisponible(
    IN p_idActividad INT,
    OUT p_hayCupo BOOLEAN
)
BEGIN
    DECLARE v_cupo INT DEFAULT 0;
    DECLARE v_inscriptos INT DEFAULT 0;

    -- Si no encuentra la actividad, v_cupo queda en 0
    SELECT COALESCE(cupo, 0) INTO v_cupo
    FROM actividad
    WHERE idActividad = p_idActividad;

    SELECT COUNT(*) INTO v_inscriptos
    FROM pagoActividad
    WHERE idActividad = p_idActividad;

    SET p_hayCupo = (v_inscriptos < v_cupo);
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE ObtenerSocioPorId(IN p_idSocio INT)
BEGIN
    SELECT idSocio, nombre, apellido, dni, email, fechaEmisionCarnet
    FROM Socio
    WHERE idSocio = p_idSocio;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE ListarVencimientosDelDia()
BEGIN
    SELECT s.idSocio, s.nombre, s.apellido, s.dni, c.fechaVencimiento, c.valorCuota
    FROM socio scuotacuotacuota
    JOIN cuota c ON s.idSocio = c.idSocio
    WHERE c.fechaVencimiento = CURDATE();
END //
DELIMITER ;


-- select * from nosocio;
-- select * from socio;
-- select * from cuota; 
-- select * from actividad;
-- select * from nosocio_actividad;

-- Query para ver socio y fecha vencimiento de la cuota
-- select s.*, c.fechaVencimiento from socio s join cuota c on s.idSocio = c.idSocio;

-- Query para editar fechaVencimiento de cuota para probar ListarVencimientos
--UPDATE proyecto.cuota
--SET fechaVencimiento = DATE_SUB(CURDATE(), INTERVAL 1 MONTH)
--WHERE idCuota = 1;