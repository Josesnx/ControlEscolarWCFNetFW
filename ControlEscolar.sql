CREATE DATABASE JSanchezControlEscolarWCF;
USE JSanchezControlEscolarWCF;

CREATE TABLE Alumno(
	IdAlumno INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50),
	ApellidoPaterno VARCHAR(50),
	ApellidoMaterno VARCHAR(50)
)
GO

CREATE TABLE Materia(
	IdMateria INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50),
	Costo DECIMAL
)
GO

CREATE PROCEDURE AlumnoAdd --'Luis','Lopez','Jimenez'
@Nombre VARCHAR(50),
@ApellidoPaterno VARCHAR(50),
@ApellidoMaterno VARCHAR(50)
AS
INSERT INTO Alumno(
				   Nombre,
				   ApellidoPaterno,
				   ApellidoMaterno) VALUES(
										   @Nombre,
										   @ApellidoPaterno,
										   @ApellidoMaterno)
GO

CREATE PROCEDURE AlumnoUpdate
@IdAlumno INT,
@Nombre VARCHAR(50),
@ApellidoPaterno VARCHAR(50),
@ApellidoMaterno VARCHAR(50)
AS
UPDATE Alumno 
SET
	Nombre = @Nombre,
	ApellidoPaterno = @ApellidoPaterno,
	ApellidoMaterno = @ApellidoMaterno
	WHERE IdAlumno = @IdAlumno
GO

CREATE PROCEDURE AlumnoDelete
@IdAlumno INT
AS
DELETE FROM Alumno WHERE IdAlumno = @IdAlumno
GO

ALTER PROCEDURE AlumnoGetAll
AS
SELECT IdAlumno,
	   Nombre,
	   ApellidoPaterno,
	   ApellidoMaterno 
	   FROM Alumno
GO

ALTER PROCEDURE AlumnoGetById
@IdAlumno INT
AS
SELECT 
	   Nombre,
	   ApellidoPaterno,
	   ApellidoMaterno 
	   FROM Alumno
	   WHERE IdAlumno = @IdAlumno
GO

CREATE PROCEDURE MateriaAdd
@Nombre VARCHAR(50),
@Costo DECIMAL
AS
INSERT INTO Materia(
					Nombre,
					Costo) VALUES (
								   @Nombre,
								   @Costo)
GO

CREATE PROCEDURE MateriaUpdate
@IdMateria INT,
@Nombre VARCHAR(50),
@Costo DECIMAL
AS
UPDATE Materia 
SET
	Nombre = @Nombre,
	Costo = @Costo
	WHERE IdMateria = @IdMateria
GO

CREATE PROCEDURE MateriaDelete
@IdMateria INT
AS
DELETE FROM Materia WHERE IdMateria = @IdMateria
GO

CREATE PROCEDURE MateriaGetAll
AS
SELECT IdMateria,
	   Nombre,
	   Costo 
	   FROM Materia
GO

CREATE PROCEDURE MateriaGetById
@IdMateria INT
AS
SELECT IdMateria,
	   Nombre,
	   Costo 
	   FROM Materia
	   WHERE IdMateria = @IdMateria
GO