use Proyecto;
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
