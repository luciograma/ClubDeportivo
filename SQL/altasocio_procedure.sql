use Proyecto;
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