USE Tutoria;

INSERT INTO Rol (RolID,Nombre,Descripcion)
VALUES (1,"Alumno","Alumno de Pregrado");
INSERT INTO Rol (RolID,Nombre,Descripcion)
VALUES (2,"Docente","Docente de Pregrado");
INSERT INTO Rol (RolID,Nombre,Descripcion)
VALUES (3,"Administrador","Administrador del area de FAING");
SELECT*FROM Rol;


INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (1,1,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (2,1,2);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (3,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (4,3,1);
SELECT*FROM Entidad;


INSERT INTO Persona (EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (1, "Aldo", "Lopez", "1992-09-28", 47714976);
INSERT INTO Persona (EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (2, "Gary", "Calee", "1111-11-11", 1111111);
INSERT INTO Persona (EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (3, "Enrique", "Lanchipa", "2222-02-02", 2222222);
INSERT INTO Persona (EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (4, "Miguel", "Fernandez", "3333-03-03", 33333333);
SELECT*FROM Persona;


INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (1, "aldo", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (2, "gary", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (3, "enrique", "e10adc3949ba59abbe56e057f20f883e");
SELECT*FROM Acceso;