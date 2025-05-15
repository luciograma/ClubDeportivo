use Proyecto;
delimiter //
CREATE PROCEDURE IngresoLogin(
    IN Usu VARCHAR(20),
    IN Pass VARCHAR(15)
)
BEGIN
    SELECT 1 AS LoginValido
    FROM usuario u
    WHERE u.nombreUsu = Usu
      AND u.passUsu = Pass
      AND u.activo = 1
    LIMIT 1;
END
//
delimiter ;