/*CONFIGURACION*/
SET IDENTITY_INSERT Configuracion ON
INSERT INTO Configuracion (ConfiguracionID, Nombre, Valor)
VALUES (1,'Maximo actividades por asesor',5);
SET IDENTITY_INSERT Configuracion OFF

/*ROL*/
SET IDENTITY_INSERT Rol ON
INSERT INTO Rol (RolID,Nombre,Descripcion)
VALUES 
(1,'Alumno','Alumno de Pregrado'),
(2,'Docente','Docente de Pregrado'),
(3,'Administrador','Administrador del area de FAING');
SET IDENTITY_INSERT Rol OFF

/*FACULTAD*/
SET IDENTITY_INSERT Facultad ON
INSERT INTO Facultad (FacultadID,Nombre,Acronimo)
VALUES 
(1,'Faculta de Derecho', 'FADE'),
(2,'Faculta de Ingenieria', 'FAING');
SET IDENTITY_INSERT Facultad OFF

/*ESCUELA*/
SET IDENTITY_INSERT Escuela ON
INSERT INTO Escuela (EscuelaID,Nombre,Acronimo,FacultadID)
VALUES 
(1,'Escuela Profesional de Ingenieria de Sistemas', 'EPIS', 2),
(2,'Escuela Profesional de Ingenieria Electronica', 'EPIE', 2);
SET IDENTITY_INSERT Escuela OFF

/*CICLO*/
SET IDENTITY_INSERT Ciclo ON
INSERT INTO Ciclo (CicloID,Nombre,Anio)
VALUES 
(1, '2018-I', 2018),
(2, '2018-II', 2018),
(3, '2019-I', 2019),
(4, '2019-II', 2019);
SET IDENTITY_INSERT Ciclo OFF

/*ENTIDAD*/
SET IDENTITY_INSERT Entidad ON
INSERT INTO Entidad (EntidadID,RolID,EscuelaID,estaActivo)
VALUES 
(1,1,1,1),
(2,1,1,1),
(3,2,1,1),
(4,3,1,1),
(5,1,1,1),
(6,2,1,1),
(7,2,2,1),
(8,2,2,1),
(9,2,2,1),
(10,2,2,1),
(11,2,2,0),
(12,2,2,1);
SET IDENTITY_INSERT Entidad OFF

/*PERSONA*/
INSERT INTO Persona (EntidadID,Nombre,Apellido,FechaNacimiento,DNI)
VALUES 
(1, 'Aldo', 'Lopez', '1992-09-28', 47714976),
(2, 'Gary', 'Calle', '1111-11-11', 1111111),
(3, 'Enrique', 'Lanchipa Valencia', '2222-02-02', 2222222),
(4, 'Miguel', 'Fernandez', '3333-03-03', 33333333),
(5, 'Kevin', 'Montes De Oca', '3333-03-03', 44444444),
(6, 'Alberto', 'Flor', '4444-04-04', 55555555),
(7, 'Henry', 'Chaina', '5555-05-05', 66666666),
(8, 'Patrick', 'Cuadros Rodriguez', '1124-02-02', 2222222),
(9, 'Liliana', 'Vega', '2221-03-03', 33333333),
(10,'Martin', 'Alcantara', '1111-02-03', 44444444),
(11, 'Tito', 'Ale Nieto', '1899-05-12', 55555555),
(12, 'Martha', 'Paredes Vignola', '2000-09-28', 99999999);

/*ENTIDAD CICLO*/
SET IDENTITY_INSERT EntidadCiclo ON
INSERT INTO EntidadCiclo (EntidadCicloID,EntidadID,CicloID)
VALUES 
(1, 1, 2),(2, 1, 3),(3, 1, 4),
(4, 2, 2),(5, 2, 3),(6, 2, 4),
(7, 3, 2),(8, 3, 3),(9, 3, 4),
(10, 4, 2),(11, 4, 3),(12, 4, 4),
(13, 5, 2),(14, 5, 3),(15, 5, 4),
(16, 6, 2),(17, 6, 3),(18, 6, 4),
(19, 7, 2),(20, 7, 3),(21, 7, 4),
(22, 8, 2),(23, 8, 3),(24, 8, 4),
(25, 9, 2),(26, 9, 3),(27, 9, 4),
(28, 10, 2),(29, 10, 3),(30, 10, 4),
(31, 11, 2),(32, 11, 3),(33, 11, 4),
(34, 12, 2),(35, 12, 3),(36, 12, 4);
SET IDENTITY_INSERT EntidadCiclo OFF

/*ACCESO*/
INSERT INTO Acceso (EntidadID,CodigoInstitucional,Pass)
VALUES 
(1, 'aldo', '123456'),
(2, 'gary', '123456'),
(3, 'enrique', '123456'),
(4, 'miguel', '123456'),
(5, 'kevin', '123456'),
(6, 'Alberto', '123456'),
(7, 'Henry', '123456');

/*CONTACTO*/
INSERT INTO Contacto (EntidadID,Telefono,CorreoPersonal,CorreoInstitucional,Direccion)
VALUES 
(1, '933445566', 'aldo@gmail.com', 'aldo@upt.pe', 'celestino vargas 123'),
(2, '922115566', 'gary@gmail.com', 'gary@upt.pe', 'celestino vargas 5445'),
(3, '908898566', 'elanchipa@gmail.com', 'elanchipa@upt.pe', 'celestino vargas 32987'),
(4, '908898566', 'miguel@gmail.com', 'miguel@upt.pe', 'celestino vargas 0000'),
(5, '908898566', 'kevin@gmail.com', 'kevin@upt.pe', 'celestino vargas 55555');

/*ALUMNO*/
INSERT INTO Alumno (AlumnoID,CreditoAprobado)
VALUES 
(1, 190),
(2, 181),
(5, 195);

/*DOCENTE*/
INSERT INTO Docente (DocenteID,Titulo)
VALUES 
(3, 'Doctor'),
(4, 'PSD'),
(6, 'Maestro'),
(7, 'Doctor'),
(8, 'Maestro'),
(9, 'Maestro'),
(10, 'Maestro'),
(11, 'Maestro'),
(12, 'Doctor');

/*ASESOR*/
INSERT INTO Asesor (AsesorID,Disponibilidad)
VALUES 
(3,1),
(6,1),
(7,1),
(8,0);

/*AREA INVESTIGACION*/
SET IDENTITY_INSERT AreaInvestigacion ON
INSERT INTO AreaInvestigacion (AreaInvestigacionID,Nombre,Descripcion)
VALUES
(1,'Computación','DescripciónComputación'),
(2,'Sistemas Cognitivos','DescripciónCognitivo'),
(3,'Plataforma de TIC','DescripcióTIC'),
(4,'Variabilidad Climática','DescripciónCambioClimatico'),
(5,'Calidad Ambiental','DescripciónAmbiental'),
(6,'Ecosistemas y Recursos Naturales','DescripciónEcosistemas'),
(7,'Gestión de Riesgos','DescripciónRiesgos');
SET IDENTITY_INSERT AreaInvestigacion OFF

/*LINEA INVESTIGACION*/
SET IDENTITY_INSERT LineaInvestigacion ON
INSERT INTO LineaInvestigacion (LineaInvestigacionID,Nombre,AreaInvestigacionID,Descripcion)
VALUES
(1,'Sistemas de información',1,'inserte descripción'),
(2,'Interacción humano computador',1,'inserte descripción'),
(3,'Procesamiento digital de señales',2,'inserte descripción'),
(4,'Sistemas inteligentes',2,'inserte descripción'),
(5,'Redes TIC',3,'inserte descripción'),
(6,'Internet de las cosas',3,'inserte descripción');
SET IDENTITY_INSERT LineaInvestigacion OFF

/*LINEA INVESTIGACION DOCENTE*/
SET IDENTITY_INSERT LineaInvestigacionDocente ON
INSERT INTO LineaInvestigacionDocente(LineaInvestigacionDocenteID,DocenteID,LineaInvestigacionID)
VALUES 
(1,3,1),
(2,3,2),
(3,6,1),
(4,6,2),
(5,6,4),
(6,7,3),
(7,3,6),
(8,8,4),
(9,9,5),
(10,9,2),
(11,10,3),
(12,10,4),
(13,11,6),
(14,12,5);
SET IDENTITY_INSERT LineaInvestigacionDocente OFF

/*MEDALLA TIPO*/
SET IDENTITY_INSERT MedallaTipo ON
INSERT INTO MedallaTipo(MedallaTipoID, Nombre, Descripcion)
VALUES 
(1,'Oficiales', 'Medallas que se rigen al manual de la FAING'),
(2,'Libres', 'Medallas libres de acuerdo a la gamificacion para motivar al estudiante');
SET IDENTITY_INSERT MedallaTipo OFF

/*MEDALLA*/
SET IDENTITY_INSERT Medalla ON
INSERT INTO Medalla (MedallaID, Nombre, ImagenURL, MedallaTipoID, Descripcion)
VALUES
(1, 'Originalidad', '001-first-place', 1, 'El proyecto es original y no duplica otros esfuerzos en investigacion que se realizan en el pais.'),
(2, 'Contribucion', '002-silver-medal', 1, 'La propuesta contribuye a abrir otras posibilidades de investigacion.'),
(3, 'Impacto de Resultados', '003-bronze-medal', 1, 'Es posible medir el efecto/impacto de los resultados.'),
(4, 'Menor a 2 años', '004-medal', 1, 'El cronograma de ejecucion es menor de 2 años'),
(5, 'Incentivador', '005-medal-1', 1, 'Incentiva la investigacion cientifica para el desarrollo tecnologico e innovacion.'),
(6, 'Cronograma', '006-gold-medal', 1, 'El cronograma planteado es adecuado\r\npara el desarrollo del proyecto'),
(7, 'Presupuesto', '007-silver-medal-1', 1, 'En el presupuesto estructurado se\r\nencuentran adecuadamente distribuidos\r\nlos gastos.'),
(8, 'Titulo', '008-bronze-medal-1', 1, 'El título refleja la intención que se propone\r\nen la investigación');
SET IDENTITY_INSERT Medalla OFF

/*ACTIVIDAD TIPO*/
SET IDENTITY_INSERT ActividadTipo ON
INSERT INTO ActividadTipo (ActividadTipoID,Nombre,CreditoRequerido)
VALUES 
(1,'Tesis',200),
(2,'Articulo Cientifico',190),
(3,'Practicas Pre-Profesionales',190);
SET IDENTITY_INSERT ActividadTipo OFF

/*FALTAN DATOS DE ACTIVIDAD*/
