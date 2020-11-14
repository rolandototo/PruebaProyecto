USE Universidad_beta2
GO
CREATE PROC SP_LOGUEO 
@Username VARCHAR(8),
@Password VARCHAR(256)
AS
Select * From LOGIN  Where Username = @Username and PwdCompare(@Password,[Password]) = 1 
GO

CREATE PROC SP_CARGARDATOSALUMNO
@CARNET VARCHAR(8)
AS
SELECT A.CARNET,Nombres,Apellidos,Telefono,Direccion,Correo,Correo_Alternativo,S.Nombre_SEDE AS SEDE,Nombre_Carrera FROM Alumno A
INNER JOIN SEDE S ON S.ID_SEDE = A.ID_Sede INNER JOIN Detalle_Cuota_Carrera DET ON DET.Carnet = A.Carnet 
INNER JOIN Cuota C ON C.ID_Cuota = DET.ID_Cuota INNER JOIN Carrera CAR ON CAR.ID_Carrera=DET.ID_Carrera 
WHERE A.Carnet = @CARNET
GO

CREATE PROC SP_ACTUALIZARDATOSALUMNO
@Carnet VARCHAR(8),
@Telefono INT,
@Direccion text,
@Correo VARCHAR(MAX),
@Correo_Alternativo VARCHAR(MAX)
AS
UPDATE Alumno SET Telefono =@Telefono,Direccion=@Direccion,Correo=@Correo,Correo_Alternativo=@Correo_Alternativo
WHERE Carnet =@Carnet
GO

CREATE PROC SP_CREARINSCRIPCION
@CARNET VARCHAR(8),
@Fecha_Inscripcion DATETIME,
@Cuota DECIMAL(18,2),
@Total DECIMAL(18,2),
@Fecha_INSCRIP_Vencimiento DATETIME,
@ID_Ciclo INT
as
INSERT INTO Inscripcion VALUES(@CARNET,@Fecha_Inscripcion ,@Cuota,@Total,@Fecha_INSCRIP_Vencimiento,@ID_Ciclo)
GO

CREATE PROC SP_FECHAINSCRIPCION
@FECHA DATE
AS
SELECT * FROM Ciclos WHERE FechaParaInscribir=@FECHA
GO

CREATE PROC SP_FECHARETIRO
@FECHA DATE
AS
SELECT * FROM Ciclos WHERE FechaRetiro=@FECHA
GO

CREATE PROC SP_MATERIAPORCARRERA
@IDCARRERA  INT
AS
SELECT ID_Materia,CODIGO_Materia,Nombre_Materia,U_V,P.ID_Pensum,ID_Ciclo,A�o,Requisitos FROM Materia M
INNER JOIN Pensum P ON P.ID_Pensum = M.ID_Pensum
WHERE ID_Carrera =@IDCARRERA
GO

CREATE PROC SP_MOSTRARGRUPOS
@IDMATERIA INT,
@IDCICLO INT
AS
SELECT ID_Grupo,CODIGO_Grupo,G.Nombre_Grupo,MAS.Nombres AS Maestro,Maximo_Cupo FROM Grupo G
INNER JOIN Materia M ON G.ID_Materia = M.ID_Materia
INNER JOIN Ciclos C ON C.ID_Ciclo = M.ID_Ciclo
INNER JOIN Horario H ON H.ID_Horario = G.ID_Horario
INNER JOIN Maestro MAS ON MAS.ID_Maestro = G.ID_Maestro
WHERE M.ID_Materia = @IDMATERIA AND M.ID_Ciclo = @IDCICLO
GO

CREATE PROC SP_MOSTRARHORARIOS
@IDGRUPO INT
AS
SELECT H.ID_Horario,Informacion_Horario,DIAS,Hora_Inicio,Hora_Fin FROM Horario H
INNER JOIN Grupo G ON G.ID_Horario = H.ID_Horario 
WHERE ID_Grupo = @IDGRUPO
GO

CREATE PROC SP_ESTUDIANTESACTUALEMENTEINSCRITOS
@IDGRUPO INT
AS
select O.Maximo_Cupo,count(G.ID_Grupo) as [Actuales Inscritos] from Grupo_Inscrito_Alumno G INNER JOIN Grupo O ON G.ID_Grupo = O.ID_Grupo
where G.ID_Grupo = @IDGRUPO GROUP BY G.ID_Grupo,O.Maximo_Cupo
GO

CREATE PROC SP_CUOTA
@CARNET VARCHAR(8)
AS
SELECT Cuota,CAR.ID_Carrera,Nombre_Carrera FROM Detalle_Cuota_Carrera DET
INNER JOIN Cuota C ON C.ID_Cuota = DET.ID_Cuota
INNER JOIN Carrera CAR ON CAR.ID_Carrera = DET.ID_Carrera
WHERE Carnet = @CARNET
GO

CREATE PROC SP_VERINSCRIPCIONESREALIZADA
@CARNET VARCHAR(8),
@FECHADEINSCRIPCION DATETIME
AS
SELECT ID_Inscripcion,Carnet,Fecha_Inscripcion,Cuota,Total,Fecha_INSCRIP_Vencimiento,ID_Ciclo FROM Inscripcion
WHERE Carnet = @CARNET AND Fecha_Inscripcion = @FECHADEINSCRIPCION
GO

CREATE PROC SP_CREARGRUPOALUMNOELEGIDO
@CARNET VARCHAR(8),
@IDGRUPO  INT,
@DETALLE VARCHAR(MAX),
@IDINSCRIPCION INT,
@IDMATERIA INT,
@ESTADO VARCHAR(30)
AS
IF NOT EXISTS
(SELECT ID_Materia FROM Grupo_Inscrito_Alumno DET INNER JOIN Grupo G ON G.ID_Grupo =DET.ID_Grupo WHERE ID_Materia = @IDMATERIA AND Carnet = @CARNET)
BEGIN
INSERT INTO Grupo_Inscrito_Alumno VALUES(@CARNET,@IDGRUPO,@DETALLE,@IDINSCRIPCION)
INSERT INTO Alumno_Grupos VALUES (@IDGRUPO,@CARNET,@ESTADO)
END
ELSE
BEGIN 
RAISERROR('NO PUEDE INSCRIBIR DOS VECES UN GRUPO PARA LA MISMA MATERIA !', 16, 1) WITH NOWAIT;
END
GO

CREATE PROC SP_VERGRUPOSYMATERIASINSCRITAS
@CARNET VARCHAR(8),
@IDGRUPO  INT
AS
SELECT ALUMG.ID_Grupo,ID_Alumno_Grupo,M.ID_Materia,CODIGO_Materia,Nombre_Materia,U_V,Requisitos,ESTADO 
FROM Alumno_Grupos ALUMG INNER JOIN Grupo G ON G.ID_Grupo = ALUMG.ID_Grupo
INNER JOIN Materia M ON M.ID_Materia = G.ID_Materia
WHERE Carnet = @CARNET AND ALUMG.ID_Grupo = @IDGRUPO
GO

CREATE PROC SP_VERGRUPONOTAS
@IDGRUPO INT
AS
SELECT * FROM Grupo_Notas WHERE ID_Grupo = @IDGRUPO
GO

CREATE PROC SP_CREANDOALUMNONOTAS
@IDAlumnoGrupo INT,
@IDNotas INT,
@NOTA FLOAT
AS
INSERT INTO Notas VALUES(@IDAlumnoGrupo,@IDNotas,@NOTA)
GO

CREATE PROC SP_MOSTRARGRUPOSINSCRITOS
@IDINSCRIPCION INT
AS
SELECT DET.ID_Grupo,CODIGO_Grupo,M.ID_Materia,Nombre_Grupo,Nombre_Materia,MAS.Nombres AS Maestro FROM Grupo_Inscrito_Alumno DET
INNER JOIN Grupo G ON DET.ID_Grupo = G.ID_Grupo
INNER JOIN Materia M ON M.ID_Materia = G.ID_Materia
INNER JOIN Maestro MAS ON MAS.ID_Maestro = G.ID_Maestro
WHERE DET.ID_Inscripcion = @IDINSCRIPCION
GO

CREATE PROC SP_BORRARGRUPOYMATERIASINSCRITAS
@IDINSCRIPCION INT,
@IDGRUPO  INT,
@CARNET VARCHAR(8),
@IDAlumnoGrupo INT
AS
DELETE Notas WHERE ID_Alumno_Grupo = @IDAlumnoGrupo
DELETE Grupo_Inscrito_Alumno WHERE ID_Grupo = @IDGRUPO AND ID_Inscripcion = @IDINSCRIPCION
DELETE Alumno_Grupos WHERE ID_Grupo =@IDGRUPO AND Carnet = @CARNET
GO

CREATE PROC SP_VERGRUPOSINSCRITOSTODOS
@CARNET VARCHAR(8),
@ID_Ciclo INT
AS
SELECT G.ID_Grupo,CODIGO_Grupo,Nombre_Grupo,Nombre_Materia,MAS.Nombres AS Maestro FROM Grupo_Inscrito_Alumno DET 
INNER JOIN Inscripcion I ON I.ID_Inscripcion = DET.ID_Inscripcion INNER JOIN Grupo G ON G.ID_Grupo = DET.ID_Grupo
INNER JOIN Materia M ON M.ID_Materia = G.ID_Materia INNER JOIN Maestro MAS ON MAS.ID_Maestro = G.ID_Maestro
WHERE DET.Carnet = @CARNET AND M.ID_Ciclo = @ID_Ciclo
GO

CREATE PROC SP_VERTODOSLOSCICLOS
@BUSCAR VARCHAR(30)
AS
SELECT * FROM Ciclos WHERE Detalle_Ciclo LIKE @BUSCAR + '%'
GO

CREATE PROC SP_VERMATERIASINSCRITAS
@CARNET VARCHAR(8)
AS
SELECT M.ID_Materia,CODIGO_Materia,Nombre_Materia,U_V,Requisitos,ESTADO FROM Grupo_Inscrito_Alumno GRUP
INNER JOIN Alumno_Grupos ALUM ON ALUM.ID_Grupo=GRUP.ID_Grupo
INNER JOIN Grupo G ON G.ID_Grupo = GRUP.ID_Grupo
INNER JOIN Materia M ON M.ID_Materia=G.ID_Materia
WHERE ALUM.Carnet = @CARNET
GO

CREATE PROC SP_VERREGISTROSDEMATERIAS
@CARNET VARCHAR(8)
AS
SELECT CODIGO_Materia,Nombre_Materia,U_V,ESTADO FROM Materia M INNER JOIN Grupo G ON G.ID_Materia = M.ID_Materia INNER JOIN Alumno_Grupos ALUM ON
ALUM.ID_Grupo = G.ID_Grupo WHERE Carnet = @CARNET
GO

CREATE PROC SP_VERMENSUALIDADES
@MES VARCHAR(15)
AS
SELECT * FROM Mensualidades WHERE Mes = @mes
GO

CREATE PROC SP_CREACIONDEPAGOS
@Detalle_Pago VARCHAR(MAX),
@Monto decimal(18,2),
@ID_Inscripcion INT,
@ID_Mensualidad INT,
@Carnet VARCHAR(8),
@Pago_Status BIT
AS
INSERT INTO Pagos(Detalle_Pago,Monto,ID_Inscripcion,ID_Mensualidad,Carnet,Pago_Status) 
VALUES (@Detalle_Pago,@Monto,@ID_Inscripcion,@ID_Mensualidad,@Carnet,@Pago_Status)
GO

CREATE PROC SP_VERPAGOSRESTANTES
@CARNET VARCHAR(8)
AS
SELECT ID_Pago,Mes,Detalle_Pago,Monto,Fecha_Vencimiento FROM Pagos P INNER JOIN Mensualidades M ON M.ID_Mensualidad=P.ID_Mensualidad
WHERE Carnet = @CARNET AND Pago_Status = 0
GO

CREATE PROC SP_PAGAR
@IDPAGO INT,
@DETALLEPAGO VARCHAR(MAX),
@METODODEPAGO VARCHAR(50),
@FECHAPAGO DATE,
@PAGOSTATUS BIT
AS
UPDATE Pagos SET Detalle_Pago = @DETALLEPAGO,Metodo_Pago =@METODODEPAGO,Fecha_Pago=@FECHAPAGO,Pago_Status=@PAGOSTATUS WHERE ID_Pago=@IDPAGO	 
GO

CREATE PROC SP_PAGARCONMORA
@IDPAGO INT,
@DETALLEPAGO VARCHAR(MAX),
@MONTO decimal(18,2),
@METODODEPAGO VARCHAR(50),
@FECHAPAGO DATE,
@PAGOSTATUS BIT
AS
UPDATE Pagos SET Detalle_Pago = @DETALLEPAGO,Monto =@MONTO,Metodo_Pago =@METODODEPAGO,Fecha_Pago=@FECHAPAGO,Pago_Status=@PAGOSTATUS WHERE ID_Pago=@IDPAGO	 
GO

CREATE PROC SP_FACTURA
@IDPAGO INT
AS 
SELECT ID_Pago,Mes,Detalle_Pago,Monto,Metodo_Pago,Fecha_Pago,Fecha_Vencimiento FROM Pagos P INNER JOIN Mensualidades M ON M.ID_Mensualidad=P.ID_Mensualidad
WHERE ID_Pago = @IDPAGO
GO

CREATE PROC SP_VERNOTAS
@CARNET VARCHAR(8),
@IDMATERIA INT
AS
SELECT Evaluacion,Porcentaje_Nota,Nota FROM Grupo_Inscrito_Alumno GRUPI INNER JOIN Grupo G ON
G.ID_Grupo = GRUPI.ID_Grupo INNER JOIN Alumno_Grupos ALUM ON ALUM.ID_Grupo = G.ID_Grupo 
INNER JOIN Notas N ON N.ID_Alumno_Grupo =ALUM.ID_Alumno_Grupo INNER JOIN Grupo_Notas GRUPN
ON GRUPN.ID_Notas = N.ID_Notas
WHERE ALUM.Carnet = @CARNET AND ID_Materia=@IDMATERIA
GO

CREATE PROC SP_MATERIASARETIRAR
@CARNET VARCHAR(8),
@ID_Ciclo INT
AS
SELECT ID_Inscripcion,ID_Alumno_Grupo,ALUM.ID_Grupo,M.ID_Materia,CODIGO_Materia,Nombre_Materia,U_V,Requisitos,ESTADO FROM Grupo_Inscrito_Alumno GRUP
INNER JOIN Alumno_Grupos ALUM ON ALUM.ID_Grupo=GRUP.ID_Grupo
INNER JOIN Grupo G ON G.ID_Grupo = GRUP.ID_Grupo
INNER JOIN Materia M ON M.ID_Materia=G.ID_Materia
WHERE GRUP.Carnet =  @CARNET AND M.ID_Ciclo = @ID_Ciclo
GO

CREATE PROC SP_RETIROMATERIAYGRUPO
@IDINSCRIPCION INT,
@IDGRUPO  INT,
@IDAlumnoGrupo INT
AS
DELETE Grupo_Inscrito_Alumno WHERE ID_Grupo = @IDGRUPO AND ID_Inscripcion = @IDINSCRIPCION
UPDATE Alumno_Grupos SET ESTADO='RETIRADA' WHERE ID_Grupo = @IDGRUPO
DELETE Notas WHERE ID_Alumno_Grupo = @IDAlumnoGrupo
GO
