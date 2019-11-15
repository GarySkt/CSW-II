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
VALUES (2,1,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (3,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (4,3,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (5,1,2);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (6,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (7,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (8,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (9,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (10,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (11,2,1);
INSERT INTO Entidad (EntidadID,RolID,estaActivo)
VALUES (12,2,1);
SELECT*FROM Entidad;


INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (1,1, "Aldo", "Lopez", "1992-09-28", 47714976);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (2,2, "Gary", "Calle", "1111-11-11", 1111111);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (3,3, "Enrique", "Lanchipa Valencia", "2222-02-02", 2222222);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (4,4, "Miguel", "Fernandez", "3333-03-03", 33333333);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (5,5, "asdasd", "asdasd", "3333-03-03", 44444444);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (6,6, "Alberto", "Flor", "4444-04-04", 55555555);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (7,7, "Henry", "Chaina", "5555-05-05", 66666666);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (8,8, "Patrick", "Cuadros Rodriguez", "1124-02-02", 2222222);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (9,9, "Liliana", "Vega", "2221-03-03", 33333333);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (10,10, "Martin", "Alcantara", "1111-02-03", 44444444);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (11,11, "Tito", "Ale Nieto", "1899-05-12", 55555555);
INSERT INTO Persona (PersonaID,EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES (12,12, "Martha", "Paredes Vignola", "2000-09-28", 99999999);
SELECT*FROM Persona;


INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (1, "aldo", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (2, "gary", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (3, "enrique", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (4, "miguel", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (5, "asdasd", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (6, "Alberto", "123456");
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES (7, "Henry", "123456");
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
VALUES (2, 1, 181);
SELECT*FROM Alumno;

INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (3,1, "Doctor");
INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (6,1, "PSD");
INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (7,1, "Maestro");
INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (8,1, "Doctor");
INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (9,1, "Maestro");
INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (10,1, "Maestro");
INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (11,1, "Maestro");
INSERT INTO Docente (DocenteID,EscuelaID,Titulo)
VALUES (12,1, "Doctor");
SELECT*FROM Docente;


INSERT INTO Especialidad (EspecialidadID,Nombre,Descripcion)
VALUES (1,"Realidad Aumentada", "gasdgasdfgsadfsadf");
INSERT INTO Especialidad (EspecialidadID,Nombre,Descripcion)
VALUES (2,"Big Data", "Dataaaaaa");
INSERT INTO Especialidad (EspecialidadID,Nombre,Descripcion)
VALUES (3,"Redes", "Redes neuronales etc etc");
INSERT INTO Especialidad (EspecialidadID,Nombre,Descripcion)
VALUES (4,"Aplicaciones Moviles", "Desarrollo de aplicaciones para todo tipo de SO");
SELECT*FROM Especialidad;

INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (1,3,1);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (2,3,2);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (3,6,1);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (4,6,2);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (5,6,4);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (6,7,3);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (7,3,2);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (8,8,1);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (9,9,1);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (10,10,2);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (11,11,2);
INSERT INTO EspecialidadDocente (EspecialidadDocenteID,DocenteID,EspecialidadID)
VALUES (12,12,1);
SELECT*FROM EspecialidadDocente;


INSERT INTO MedallaTipo(Nombre, Descripcion)
VALUES ("oficiales", "Medallas que se rigen al manual de la FAING");
INSERT INTO MedallaTipo(Nombre, Descripcion)
VALUES ("libres", "Medallas libres de acuerdo a la gamificacion para motivar al estudiante");
SELECT*FROM MedallaTipo;

INSERT INTO Medalla (MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(1, "Originalidad", "001-first-place", 1, "El proyecto es original y no duplica otros esfuerzos en investigacion que se realizan en el pais.");
INSERT INTO Medalla(MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(2, "Contribucion", "002-silver-medal", 1, "La propuesta contribuye a abrir otras posibilidades de investigacion.");
INSERT INTO Medalla(MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(3, "Impacto de Resultados", "003-bronze-medal", 1, "Es posible medir el efecto/impacto de los resultados.");
INSERT INTO Medalla(MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(4, "Menor a 2 años", "004-medal", 1, "El cronograma de ejecucion es menor de 2 años");
INSERT INTO Medalla(MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(5, "Incentivador", "005-medal-1", 1, "Incentiva la investigacion cientifica para el desarrollo tecnologico e innovacion.");
INSERT INTO Medalla(MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(6, "Cronograma", "006-gold-medal", 1, "El cronograma planteado es adecuado\r\npara el desarrollo del proyecto");
INSERT INTO Medalla(MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(7, "Presupuesto", "007-silver-medal-1", 1, "En el presupuesto estructurado se\r\nencuentran adecuadamente distribuidos\r\nlos gastos.");
INSERT INTO Medalla(MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES(8, "Titulo", "008-bronze-medal-1", 1, "El título refleja la intención que se propone\r\nen la investigación");
SELECT*FROM Medalla;




INSERT INTO Asesor (AsesorID,Disponibilidad)
VALUES (3,1);
INSERT INTO Asesor (AsesorID,Disponibilidad)
VALUES (6,1);
INSERT INTO Asesor (AsesorID,Disponibilidad)
VALUES (7,1);
SELECT*FROM Asesor;


INSERT INTO ActividadTipo (ActividadTipoID,Nombre,CreditoRequerido)
VALUES (1,"Tesis",190);
INSERT INTO ActividadTipo (ActividadTipoID,Nombre,CreditoRequerido)
VALUES (2,"Investigacion",190);
INSERT INTO ActividadTipo (ActividadTipoID,Nombre,CreditoRequerido)
VALUES (3,"Practicas Pre-Profesionales",190);
SELECT*FROM ActividadTipo;


INSERT INTO Actividad
(ActividadID,Finalizada,AlumnoID,Titulo,Resumen,Descripcion,AsesorID,ActividadTipoID)
VALUES
(1,0,1,"Realidad aumentada para aumentar el interes de niños de 5 años en ciencia",
"La realidad auemntada nos permite una nmayo interaccion ........",
"Este proyecto utiliza se realizara en un app",3,1);
INSERT INTO Actividad
(ActividadID,Finalizada,AlumnoID,Titulo,Resumen,Descripcion,AsesorID,ActividadTipoID)
VALUES
(2,0,2,"Mejora en atencion de essalud a traves de telemedicina con aplicaciones moviles",
"En el peru la salud es un necesidad primaria que esta en deficit debido a la demora y ........",
"Este proyecto utilizara una aplicacion movil para el publi",6,1);
SELECT*FROM Actividad;


INSERT INTO Entregable(EntregableID,ActividadID,Descripcion,Comentario,NumeroOrden,FechaAprobado)
VALUES (1,1,"Entregable 1 de Realidad Aumentada","Marco teorico finalizado",1,"2222-02-02");
INSERT INTO Entregable(EntregableID,ActividadID,Descripcion,Comentario,NumeroOrden,FechaAprobado)
VALUES (2,1,"Entregable 2 de Realidad Aumentada","Correcion de marco teorico",1,"2222-02-03");
INSERT INTO Entregable(EntregableID,ActividadID,Descripcion,Comentario,NumeroOrden,FechaAprobado)
VALUES (3,2,"Entregable 1 de telemedicina","Antecedentes especificados",1,"2019-09-01");
INSERT INTO Entregable(EntregableID,ActividadID,Descripcion,Comentario,NumeroOrden,FechaAprobado)
VALUES (4,2,"Entregable 3 de telemedicina","Marco teorico de 2 variables terminado",1,"2019-10-08");
INSERT INTO Entregable(EntregableID,ActividadID,Descripcion,Comentario,NumeroOrden,FechaAprobado)
VALUES (5,1,"Entregable 3 de Realidad Aumentada","Correcion de titulo",1,"2222-03-25");
SELECT*FROM Entregable;


INSERT INTO EntregableMedalla (EntregableMedallaID,EntregableID,MedallaID,Fecha)
VALUES (1,2,2,"2222-02-03");
INSERT INTO EntregableMedalla (EntregableMedallaID,EntregableID,MedallaID,Fecha)
VALUES (2,5,8,"2222-03-25");
INSERT INTO EntregableMedalla (EntregableMedallaID,EntregableID,MedallaID,Fecha)
VALUES (3,4,1,"2019-10-10");
SELECT*FROM EntregableMedalla;

