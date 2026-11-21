CREATE DATABASE Babel
GO

USE Babel
GO

-- 1. ALUMNOS
CREATE TABLE Alumnos (
    idAlumno INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(60) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    correo VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(20),
    fechaNacimiento DATE,
    fechaRegistro DATETIME DEFAULT GETDATE(),
    estado VARCHAR(20) DEFAULT 'Activo',

    CONSTRAINT CK_Alumnos_Estado
    CHECK (estado IN ('Activo', 'Inactivo'))
)
-- 2. CURSOS
CREATE TABLE Cursos (
    idCurso INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(80) NOT NULL,
    idioma VARCHAR(40) NOT NULL,
    nivel VARCHAR(30) NOT NULL,
    descripcion VARCHAR(250),
    precio DECIMAL(10,2) NOT NULL,
    estado VARCHAR(20) DEFAULT 'Activo',

    CONSTRAINT CK_Cursos_Precio
    CHECK (precio >= 0),

    CONSTRAINT CK_Cursos_Estado
    CHECK (estado IN ('Activo', 'Inactivo'))
)
CREATE TABLE Grupos (
    idGrupo INT IDENTITY(1,1) PRIMARY KEY,
    idCurso INT NOT NULL,
    nombreGrupo VARCHAR(30) NOT NULL,
    dia VARCHAR(20) NOT NULL,
    horaInicio TIME NOT NULL,
    horaFin TIME NOT NULL,
    cupoMaximo INT NOT NULL,
    fechaInicio DATE,
    fechaFin DATE,
    estado VARCHAR(20) DEFAULT 'Abierto',

    CONSTRAINT FK_Grupos_Cursos
    FOREIGN KEY (idCurso) REFERENCES Cursos(idCurso),

    CONSTRAINT CK_Grupos_Cupo
    CHECK (cupoMaximo > 0),

    CONSTRAINT CK_Grupos_Horario
    CHECK (horaFin > horaInicio),

    CONSTRAINT CK_Grupos_Estado
    CHECK (estado IN ('Abierto', 'Cerrado', 'Finalizado'))
)
-- 4. INSCRIPCIONES
CREATE TABLE Inscripciones (
    idInscripcion INT IDENTITY(1,1) PRIMARY KEY,
    idAlumno INT NOT NULL,
    idGrupo INT NOT NULL,
    fechaInscripcion DATETIME DEFAULT GETDATE(),
    precioInscripcion DECIMAL(10,2) NOT NULL,
    estado VARCHAR(20) DEFAULT 'Activa',

    CONSTRAINT FK_Inscripciones_Alumnos
    FOREIGN KEY (idAlumno) REFERENCES Alumnos(idAlumno),

    CONSTRAINT FK_Inscripciones_Grupos
    FOREIGN KEY (idGrupo) REFERENCES Grupos(idGrupo),

    CONSTRAINT UQ_Alumno_Grupo
    UNIQUE (idAlumno, idGrupo),

    CONSTRAINT CK_Inscripciones_Precio
    CHECK (precioInscripcion >= 0),

    CONSTRAINT CK_Inscripciones_Estado
    CHECK (estado IN ('Activa', 'Cancelada', 'Finalizada'))
)
-- 5. PAGOS
CREATE TABLE Pagos (
    idPago INT IDENTITY(1,1) PRIMARY KEY,
    idInscripcion INT NOT NULL,
    fechaPago DATETIME DEFAULT GETDATE(),
    monto DECIMAL(10,2) NOT NULL,
    metodoPago VARCHAR(30) NOT NULL,
    referencia VARCHAR(100),

    CONSTRAINT FK_Pagos_Inscripciones
    FOREIGN KEY (idInscripcion)
    REFERENCES Inscripciones(idInscripcion),

    CONSTRAINT CK_Pagos_Monto
    CHECK (monto > 0)
)

SELECT * FROM Alumnos;
SELECT * FROM Cursos;
SELECT * FROM Grupos;
SELECT * FROM Inscripciones;
SELECT * FROM Pagos;