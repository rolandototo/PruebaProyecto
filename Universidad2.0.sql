CREATE DATABASE Universidad_beta2
ON
(  
    NAME = Universidad_beta2_dat,
    FILENAME = 'C:\Bases de datos SQL\Universidad_beta2_dat.mdf',
	SIZE = 5MB,
	MAXSIZE = 25MB,
	FILEGROWTH = 10%
)
LOG ON
(
    NAME = Universidad_beta2_log,
    FILENAME = 'C:\Bases de datos SQL\Universidad_beta2_log.ldf',
	SIZE = 2MB,
	MAXSIZE = 25MB,
	FILEGROWTH = 10%
);

USE Universidad_beta2
GO
--login
CREATE TABLE LOGIN 
(
   Username VARCHAR(8) PRIMARY KEY NOT NULL,
   [Password] VARBINARY(256),
   Admin_Status bit not null,
   Alumn_Status bit not null,
   Teach_Status bit not null
)
GO
--login
--Universidad
CREATE TABLE Maestro
(
   ID_Maestro VARCHAR(8) NOT NULL,
   Nombres VARCHAR(100),
   Apellidos VARCHAR(100),
   Telefono INT,
   Correo VARCHAR(MAX),
   Fecha_De_Ingreso DATE,
   CONSTRAINT PK_Maestro PRIMARY KEY(ID_Maestro)
)
GO
CREATE TABLE UNIVERSIDAD
(
   ID_Universidad VARCHAR(15)NOT NULL,
   Nombre_Universidad VARCHAR(MAX),
   CONSTRAINT PK_Universidad PRIMARY KEY(ID_Universidad)
)
GO
CREATE TABLE SEDE
(
   ID_SEDE INT IDENTITY NOT NULL PRIMARY KEY,
   CODIGO_SEDE AS ('SD' +RIGHT('00' + CONVERT(VARCHAR,ID_SEDE),(2))),
   Nombre_SEDE VARCHAR(50),
   Direccion_SEDE VARCHAR(MAX),
   ID_Universidad VARCHAR(15) FOREIGN KEY REFERENCES UNIVERSIDAD(ID_Universidad),
   Telefono_SEDE INT,
)
GO

CREATE TABLE Facultades
(
  ID_Facultad INT IDENTITY NOT NULL PRIMARY KEY,
  CODIGO_Facultad AS ('CT' +RIGHT('00' + CONVERT(VARCHAR,ID_Facultad),(2))),
  Nombre_Facultad VARCHAR(MAX),
  ID_Sede int FOREIGN KEY REFERENCES SEDE(ID_SEDE),
)
GO
CREATE TABLE Ciclos
(
   ID_Ciclo INT IDENTITY NOT NULL PRIMARY KEY,
   CODIGO_Ciclo AS ('CIC' +RIGHT('00' + CONVERT(VARCHAR,ID_Ciclo),(2))),
   Detalle_Ciclo VARCHAR(MAX),
   ID_Sede INT,
   FechaInicio DATE,
   FechaFin DATE,
   FechaParaInscribir DATE,
   FechaRetiro DATE
   CONSTRAINT FK_IDESEDE_CICLOS FOREIGN KEY(ID_Sede) REFERENCES SEDE(ID_SEDE),

)
go
CREATE TABLE Carrera
(
    ID_Carrera INT IDENTITY NOT NULL PRIMARY KEY,
	CODIGO_Carrera AS ('CA' +RIGHT('00' + CONVERT(VARCHAR,ID_Carrera),(2))),
	Nombre_Carrera VARCHAR(MAX),
	ID_Facultad INT FOREIGN KEY REFERENCES Facultades(ID_Facultad),
)
GO
CREATE TABLE Pensum
(
   ID_Pensum INT IDENTITY NOT NULL PRIMARY KEY,
   CODIGO_Pensum AS ('PEN' +RIGHT('00' + CONVERT(VARCHAR,ID_Pensum),(2))),
   ID_Carrera INT FOREIGN KEY REFERENCES Carrera(ID_Carrera),
   Años INT,
   Ciclos INT,
)
go
CREATE TABLE Materia
(
   ID_Materia INT IDENTITY NOT NULL PRIMARY KEY,
   CODIGO_Materia AS ('MAT' +RIGHT('00' + CONVERT(VARCHAR,ID_Materia),(2))),
   Nombre_Materia VARCHAR(100),
   U_V INT,
   ID_Pensum INT FOREIGN KEY REFERENCES Pensum(ID_Pensum),
   ID_Ciclo INT FOREIGN KEY REFERENCES Ciclos(ID_Ciclo),
   Año INT,
   Requisitos VARCHAR(MAX),
)	
go
CREATE TABLE Alumno
(
   Carnet VARCHAR(8) NOT NULL PRIMARY KEY,
   Nombres VARCHAR(100),
   Apellidos VARCHAR(100),
   Telefono INT,
   Direccion text,
   Sexo VARCHAR(10),
   Correo VARCHAR(MAX),
   Correo_Alternativo VARCHAR(MAX),
   Fecha_De_Nacimiento DATE,
   ID_Sede INT FOREIGN KEY REFERENCES SEDE(ID_SEDE), 
   Fecha_de_Ingreso DATE,
)
GO
CREATE TABLE Cuota
(
   ID_Cuota INT IDENTITY not null PRIMARY KEY,
   Cuota decimal(18,2),
)
GO
CREATE TABLE Detalle_Cuota_Carrera
(
   ID_CUOTACARRERA INT IDENTITY not null PRIMARY KEY,
   ID_Carrera INT FOREIGN KEY REFERENCES Carrera(ID_Carrera),
   ID_Cuota INT FOREIGN KEY REFERENCES Cuota(ID_Cuota),
   Carnet VARCHAR(8) FOREIGN KEY REFERENCES Alumno(Carnet),
)
GO
CREATE TABLE Detalle_Sede
(
   ID_Detalle_SEDE INT IDENTITY not null PRIMARY KEY,
   ID_Maestro VARCHAR(8) FOREIGN KEY REFERENCES Maestro(ID_Maestro),
   ID_Sede INT FOREIGN KEY REFERENCES SEDE(ID_SEDE),
)
GO
CREATE TABLE Inscripcion
(
   ID_Inscripcion INT IDENTITY(10000,3) NOT NULL PRIMARY KEY,
   Carnet VARCHAR(8),
   Fecha_Inscripcion DATETIME,
   Cuota decimal(18,2),
   Total decimal(18,2),
   Fecha_INSCRIP_Vencimiento DATETIME,
   ID_Ciclo INT FOREIGN KEY REFERENCES Ciclos(ID_Ciclo) ,
)
GO
CREATE TABLE Horario
(
   ID_Horario INT IDENTITY not null PRIMARY KEY,
   CODIGO_Horario AS ('HOR' +RIGHT('00' + CONVERT(VARCHAR,ID_Horario),(2))),
   Informacion_Horario VARCHAR(MAX),
   DIAS VARCHAR(100),
   Hora_Inicio VARCHAR(30),
   Hora_Fin VARCHAR(30),
)
GO
CREATE TABLE Grupo
(
   ID_Grupo INT IDENTITY NOT NULL PRIMARY KEY,
   CODIGO_Grupo AS ('GT' +RIGHT('00' + CONVERT(VARCHAR,ID_Grupo),(2))),
   Nombre_Grupo VARCHAR(20),
   ID_Maestro VARCHAR(8) FOREIGN KEY REFERENCES Maestro(ID_Maestro),
   ID_Materia INT FOREIGN KEY REFERENCES Materia(ID_Materia),
   ID_Horario INT FOREIGN KEY REFERENCES Horario(ID_Horario),
   Maximo_Cupo INT,
)
GO

CREATE TABLE Grupo_Inscrito_Alumno
(
   Carnet VARCHAR(8) FOREIGN KEY REFERENCES Alumno(Carnet),
   ID_Grupo int FOREIGN KEY REFERENCES Grupo(ID_Grupo),
   Detalle VARCHAR(MAX),
   ID_Inscripcion INT FOREIGN KEY REFERENCES Inscripcion(ID_Inscripcion),
)
GO
CREATE TABLE Mensualidades
(
   ID_Mensualidad INT IDENTITY NOT NULL PRIMARY KEY,
   CODIGO_Mensualidad AS ('MEN' +RIGHT('00' + CONVERT(VARCHAR,ID_Mensualidad),(2))),
   Mes VARCHAR(15),
   Fecha_Inicio DATE,
   Fecha_Vencimiento DATE,
)
GO

CREATE TABLE Pagos
(
   ID_Pago INT IDENTITY(2000,1) NOT NULL PRIMARY KEY,
   Detalle_Pago VARCHAR(MAX),
   Monto decimal(18,2),
   ID_Inscripcion INT FOREIGN KEY REFERENCES Inscripcion(ID_Inscripcion),
   ID_Mensualidad INT FOREIGN KEY REFERENCES Mensualidades(ID_Mensualidad),
   Metodo_Pago VARCHAR(50),
   Carnet VARCHAR(8) FOREIGN KEY REFERENCES Alumno(Carnet),
   Fecha_Pago DATE,
   Pago_Status bit ,
)
GO

CREATE TABLE Grupo_Notas
(
   ID_Notas INT IDENTITY NOT NULL PRIMARY KEY ,
   CODIGO_Notas AS ('GPN' +RIGHT('00' + CONVERT(VARCHAR,ID_Notas),(2))),
   ID_Grupo INT FOREIGN KEY(ID_Grupo) REFERENCES Grupo(ID_Grupo) on update cascade on delete cascade,
   Evaluacion VARCHAR(MAX),
   Porcentaje_Nota FLOAT,
)
GO

CREATE TABLE Alumno_Grupos
(
   ID_Alumno_Grupo INT IDENTITY NOT NULL PRIMARY KEY ,
   CODIGO_Alumno_Grupo AS ('ALG' +RIGHT('00' + CONVERT(VARCHAR,ID_Alumno_Grupo),(2))),
   ID_Grupo INT FOREIGN KEY REFERENCES Grupo(ID_Grupo) on update cascade on delete cascade,
   Carnet VARCHAR(8) FOREIGN KEY REFERENCES Alumno(Carnet) on update cascade on delete cascade,
   ESTADO VARCHAR(30),
)
GO
CREATE TABLE Notas
(
   ID_Alumno_Grupo INT FOREIGN KEY REFERENCES Alumno_Grupos(ID_Alumno_Grupo) ,
   ID_Notas INT FOREIGN KEY REFERENCES Grupo_Notas(ID_Notas) ,
   Nota FLOAT
)
GO
