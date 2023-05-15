DROP DATABASE IF EXISTS Torneito;
CREATE DATABASE Torneito;
USE Torneito;

CREATE TABLE Torneo(
	IdTorneo INT PRIMARY KEY,
	Deporte VARCHAR(100),
	Categoria VARCHAR(100),
	FechaInicio DATE,
	FechaFinal DATE,
	IdEquipo INT
);

CREATE TABLE Equipo(
	IdEquipo INT PRIMARY KEY,
	Nombre VARCHAR(100),
	Categoria VARCHAR(100),
	Patrocinador VARCHAR(100),
	IdDeportista INT
);

CREATE TABLE Deportista(
	IdDeportista INT PRIMARY KEY,
	Nombre VARCHAR(100),
	Genero VARCHAR(100),
	FechaNacimiento DATE,
	Edad INT,
	IdEquipo INT
);

ALTER TABLE Torneo ADD CONSTRAINT fk_IdEquipo FOREIGN KEY (IdEquipo) REFERENCES Equipo (IdEquipo);
ALTER TABLE Equipo ADD CONSTRAINT fk_IdDeportista FOREIGN KEY (IdDeportista) REFERENCES Deportista (IdDeportista);
ALTER TABLE Deportista ADD CONSTRAINT fk_IdEquipoDeportista FOREIGN KEY (IdEquipo) REFERENCES Equipo (IdEquipo);

/* Insertar un registro sin especificar los campos*/
INSERT INTO Equipo VALUES(23, 'Warriors', 'Libre', 'Éxito', NULL);

/* Insertar un registro especificando los campos */
INSERT INTO Torneo (IdTorneo, Deporte, Categoria, FechaInicio, FechaFinal, IdEquipo) 
VALUES(2654, 'Voleyball', 'Sub 18', '2023-05-20', '2023-05-23', NULL);

/* Insertar varios registros sin especificar los campos*/
INSERT INTO Deportista VALUES
(1, 'Pedro', 'Masculino', '2005-09-13', 17, 23),
(2, 'Juan', 'Masculino', '2004-08-17', 18, 23),
(3, 'José', 'Masculino', '2003-12-04', 19, 23);

/* Insertar varios registros especificando los campos en un orden diferente */
INSERT INTO deportista (IdDeportista, Edad, Nombre, Genero) VALUES
(4, 17, 'Ramiro', 'Masculino'),
(5, 19,  'Saul', 'Masculino'),
(6, 21, 'Moises', 'Masculino');

/* Updates*/
/* Update para todos los valores de una columna */
UPDATE equipo
SET Patrocinador = 'D1';

/* Update para todos los valores con una condicion */
UPDATE deportista
SET Edad = 18 WHERE Edad = 17;

/* Update para todos los valores con dos condiciones */
UPDATE deportista
SET Edad = 20 WHERE Edad = 18;

/* Delete y Truncate */
DELETE FROM deportista WHERE IdDeportista = 4;

DELETE FROM deportista WHERE IdDeportista BETWEEN 1 AND 3;

TRUNCATE TABLE torneo;

SELECT * FROM Torneo;
SELECT * FROM Equipo;
SELECT * FROM Deportista;