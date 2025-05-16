use Proyecto;
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