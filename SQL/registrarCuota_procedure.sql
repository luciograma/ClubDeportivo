use Proyecto;
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