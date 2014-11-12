CREATE TABLE Usuario (
Nombre VARCHAR2(10),
Apellidos VARCHAR2(20),
Direccion VARCHAR2(30),
CONSTRAINT PK_Usuario_Nombre PRIMARY KEY (Nombre,Apellidos)
);
CREATE TABLE Empleado (
Nombre VARCHAR2(10),
Apellidos VARCHAR2(20),
Turno VARCHAR2(6),
CONSTRAINT PK_USUARIO_Nombre PRIMARY KEY (Nombre, Apellidos)
);
Categoria (
