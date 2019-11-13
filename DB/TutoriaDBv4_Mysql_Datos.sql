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
INSERT INTO Persona (EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (1, "asdasd", "asdasd", "3333-03-03", 44444444);
SELECT*FROM Persona;




INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (1, "aldo", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (2, "gary", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (3, "enrique", "e10adc3949ba59abbe56e057f20f883e");
SELECT*FROM Acceso;


INSERT INTO Contacto (EntidadID,Telefono,CorreoPersonal,CorreoInstitucional,Direccion)
VALUES (1, "933445566", "aldo@gmail.com", "aldo@upt.pe", "celestino vargas 123");
INSERT INTO Contacto (EntidadID,Telefono,CorreoPersonal,CorreoInstitucional,Direccion)
VALUES (2, "922115566", "gary@gmail.com", "gary@upt.pe", "celestino vargas 5445");
INSERT INTO Contacto (EntidadID,Telefono,CorreoPersonal,CorreoInstitucional,Direccion)
VALUES (3, "908898566", "elanchipa@gmail.com", "elanchipa@upt.pe", "celestino vargas 32987");
SELECT*FROM Contacto;


INSERT INTO Facultad (FacultadID,Nombre,Acronimo)
VALUES (1, "Faculta de Derecho", "FADE");
INSERT INTO Facultad (FacultadID,Nombre,Acronimo)
VALUES (2, "Faculta de Ingenieria", "FAING");
SELECT*FROM Facultad;


INSERT INTO Escuela (EscuelaID,Nombre,Acronimo,FacultadID)
VALUES (1, "Escuela Profesional de Ingenieria de Sistemas", "EPIS", 2);
INSERT INTO Escuela (EscuelaID,Nombre,Acronimo,FacultadID)
VALUES (2, "Escuela Profesional de Ingenieria Electronica", "EPIE", 2);
SELECT*FROM Escuela;


INSERT INTO Ciclo (CicloID,Nombre,Anio)
VALUES (1, "primero", 2019);
INSERT INTO Ciclo (CicloID,Nombre,Anio)
VALUES (2, "segundo", 2019);
SELECT*FROM Ciclo;


INSERT INTO EntidadCiclo (EntidadCicloID,EntidadID,CicloID)
VALUES (1, 1, 1);
INSERT INTO EntidadCiclo (EntidadCicloID,EntidadID,CicloID)
VALUES (2, 1, 2);
SELECT*FROM EntidadCiclo;


INSERT INTO Alumno (AlumnoID,EscuelaID,CreditoAprobado)
VALUES (1, 1, 190);
INSERT INTO Alumno (AlumnoID,EscuelaID,CreditoAprobado)
VALUES (1, 1, 181);
SELECT*FROM Alumno;


INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (1, 1, "Maestro");
SELECT*FROM Docente;


INSERT INTO Especialidad (EspecialidadID,Nombre,Descripcion)
VALUES (1,"Realidad Aumentada", "gasdgasdfgsadfsadf");
INSERT INTO Especialidad (EspecialidadID,Nombre,Descripcion)
VALUES (2,"Big Data", "Dataaaaaa");
SELECT*FROM Especialidad;


INSERT INTO EspecialidadDocente (DocenteID,EspecialidadID)
VALUES (1, 1);
INSERT INTO EspecialidadDocente (DocenteID,EspecialidadID)
VALUES (1,2);
SELECT*FROM EspecialidadDocente;

