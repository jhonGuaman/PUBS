CREATE TABLE Autor
(
   id_autor          CHAR(11) NOT NULL
      CHECK (id_autor LIKE '[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]')
      CONSTRAINT UPKCL_auidind PRIMARY KEY CLUSTERED,

   nombre_autor       VARCHAR(40) NOT NULL,
   apellidi_autor       VARCHAR(20) NOT NULL,

   telefono          CHAR(12) NOT NULL 
      DEFAULT ('UNKNOWN'),

   direccion        VARCHAR(40) NULL,
   ciudad           VARCHAR(20) NULL,
   state          CHAR(2) NULL,

   cod_Postal            CHAR(5) NULL
      CHECK (cod_Postal LIKE '[0-9][0-9][0-9][0-9][0-9]'),

   contrato       BIT NOT NULL
);

CREATE TABLE Editores
(
   id_Editor         CHAR(4)           NOT NULL
      CONSTRAINT UPKCL_pubind PRIMARY KEY CLUSTERED
      CHECK (id_Editor IN ('1389', '0736', '0877', '1622', '1756')
             OR id_Editor LIKE '99[0-9][0-9]'),  

   nombre_editor       VARCHAR(40)       NULL,
   ciudad_editor           VARCHAR(20)       NULL,
   

   pais        VARCHAR(30)       NULL
      DEFAULT ('USA')  -
);

CREATE TABLE Titulos
(
   id_Titulo       CHAR(6)           NOT NULL  
      CONSTRAINT UPKCL_titleidind PRIMARY KEY CLUSTERED,

   Titulo          VARCHAR(80)       NOT NULL,

   type           CHAR(12)          NOT NULL
      DEFAULT ('UNDECIDED'),

   id_Editor         CHAR(4)           NULL
      REFERENCES Editores(id_Editor),

   precio          MONEY             NULL,
   avance        MONEY             NULL,
   ventas      INT               NULL,
   notas          VARCHAR(200)      NULL,

   fecha_publicacion        DATETIME          NOT NULL
      DEFAULT (GETDATE())
);

CREATE TABLE tituloAutor
(
   id_autor          CHAR(11) NOT NULL  
      REFERENCES Autor(id_autor),

   id_Titulo         CHAR(6) NOT NULL  
      REFERENCES Titulos(id_Titulo),

   orden_Autores     TINYINT NULL,
   regalias          INT NULL,

   CONSTRAINT UPKCL_taind PRIMARY KEY CLUSTERED (id_autor, id_Titulo)
);

IF OBJECT_ID('dbo.Tienda', 'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.Tienda
END;

CREATE TABLE Tienda
(
   id_tienda        CHAR(4)           NOT NULL
      CONSTRAINT UPK_storeid PRIMARY KEY CLUSTERED,

   nombre_tienda      VARCHAR(40)       NULL,
   direccion_tienda   VARCHAR(40)       NULL,
   ciudad_tienda          VARCHAR(20)       NULL,
  
   codpo_tienda         CHAR(5)           NULL
      CHECK (codpo_tienda LIKE '[0-9][0-9][0-9][0-9][0-9]'),
   
);

CREATE TABLE Ventas
(
   id_tienda          CHAR(4) NOT NULL
      REFERENCES Tienda(id_tienda),

   numero_ordenV      VARCHAR(20) NOT NULL,
   fecha_venta        DATETIME NOT NULL,
   canti_venta        SMALLINT NOT NULL
      CHECK (canti_venta > 0),

   payterms           VARCHAR(12) NOT NULL,
   id_Titulo          CHAR(6) NOT NULL
      REFERENCES Titulos(id_Titulo),

   CONSTRAINT UPKCL_Ventas PRIMARY KEY CLUSTERED (id_tienda, numero_ordenV, id_Titulo)
);

CREATE TABLE Regalias (
   id_Titulo        CHAR(6) NOT NULL       
      REFERENCES Titulos(id_Titulo),      

   limInf_ventas        INT NOT NULL,         
   limSup_ventas         INT NOT NULL,          
   porce_regalias         INT NOT NULL           
);

CREATE TABLE Descuentos
(
   tipo_descuento     VARCHAR(40) NOT NULL,    
   id_tienda          CHAR(4) NULL,           
      FOREIGN KEY (id_tienda) REFERENCES Tienda(id_tienda),

   cantMin_Productos  SMALLINT NULL,          
   cantMax_Productos  SMALLINT NULL,          
   porce_descuento    DECIMAL(4,2) NOT NULL   
);

CREATE TABLE Trabajos
(
   id_trabajo         SMALLINT          IDENTITY(1,1) PRIMARY KEY CLUSTERED,

   des_trabajo       VARCHAR(50)       NOT NULL
      DEFAULT 'New Position - title not formalized yet',

   min_nivel        TINYINT           NOT NULL
      CHECK (min_nivel >= 10),

   max_nivel        TINYINT           NOT NULL
      CHECK (max_nivel <= 250),

   CONSTRAINT CK_lvl_consistency CHECK (max_nivel <= max_nivel) -- Validación adicional
);

CREATE TABLE Info_Editores
(
   id_Editor         char(4)           NOT NULL

         REFERENCES Editores(id_Editor)

         CONSTRAINT UPKCL_pubinfo PRIMARY KEY CLUSTERED,

   logo           image                 NULL,
   inf_editor        text                  NULL
);

CREATE TABLE Empleado
(
   id_empleado         varchar(9)       
      CONSTRAINT PK_id_empleado PRIMARY KEY NONCLUSTERED,
   
   
   CONSTRAINT CK_emp_id CHECK (id_empleado LIKE '[A-Z][A-Z][A-Z][1-9][0-9][0-9][0-9][0-9][FM]' 
                               OR id_empleado LIKE '[A-Z]-[A-Z][1-9][0-9][0-9][0-9][0-9][FM]'),

   nombreEmpleado          varchar(20)       NOT NULL,
   inicial_SeguNombre          char(1)           NULL,
   apellidoEmpleado          varchar(30)       NOT NULL,

   id_trabajo         smallint          NOT NULL
      DEFAULT 1
      REFERENCES Trabajos(id_trabajo),

   nivel_trabajo        tinyint           DEFAULT 10,

   id_Editor         char(4)           NOT NULL
      DEFAULT '9952'
      REFERENCES Editores(id_Editor),

   fecha_contraato      datetime          NOT NULL
      DEFAULT (getdate())
);

INSERT INTO Autor (id_autor, nombre_autor, apellidi_autor, telefono, direccion, ciudad, state, cod_Postal, contrato)
VALUES 
('123-45-6789', 'Juan', 'Pérez', 'UNKNOWN', 'Calle Falsa 123', 'Madrid', 'MD', '28001', 1),
('987-65-4321', 'Ana', 'Gómez', 'UNKNOWN', 'Avenida Siempre Viva 456', 'Barcelona', 'BC', '08001', 0);

INSERT INTO Editores (id_Editor, nombre_editor, ciudad_editor, pais)
VALUES 
('1389', 'Editor1', 'Madrid', 'España'),
('0736', 'Editor2', 'Barcelona', 'España');

INSERT INTO Titulos (id_Titulo, Titulo, type, id_Editor, precio, avance, ventas, notas, fecha_publicacion)
VALUES 
('T00001', 'Libro de Prueba 1', 'Ficción', '1389', 19.99, 5.00, 1000, 'Primera edición', '2024-12-01'),
('T00002', 'Libro de Prueba 2', 'No Ficción', '0736', 25.99, 7.50, 500, 'Segunda edición', '2024-11-15');

INSERT INTO tituloAutor (id_autor, id_Titulo, orden_Autores, regalias)
VALUES 
('123-45-6789', 'T00001', 1, 10),
('987-65-4321', 'T00002', 1, 15);

INSERT INTO Tienda (id_tienda, nombre_tienda, direccion_tienda, ciudad_tienda, codpo_tienda)
VALUES 
('T001', 'Tienda A', 'Calle Falsa 123', 'Madrid', '28001'),
('T002', 'Tienda B', 'Avenida Siempre Viva 456', 'Barcelona', '08001');

INSERT INTO Ventas (id_tienda, numero_ordenV, fecha_venta, canti_venta, payterms, id_Titulo)
VALUES 
('T001', 'ORD001', '2024-12-01', 5, 'Contado', 'T00001'),
('T002', 'ORD002', '2024-12-02', 3, 'Crédito', 'T00002');

INSERT INTO Regalias (id_Titulo, limInf_ventas, limSup_ventas, porce_regalias)
VALUES 
('T00001', 0, 500, 10),
('T00002', 501, 1000, 12);

INSERT INTO Descuentos (tipo_descuento, id_tienda, cantMin_Productos, cantMax_Productos, porce_descuento)
VALUES 
('Temporada', 'T001', 1, 10, 5.00),
('Promoción', 'T002', 5, 20, 10.00);

INSERT INTO Trabajos (des_trabajo, min_nivel, max_nivel)
VALUES 
('Desarrollador', 10, 50),
('Gerente', 51, 100);

INSERT INTO Info_Editores (id_Editor, logo, inf_editor)
VALUES 
('1389', NULL, 'Información sobre el editor 1389'),
('0736', NULL, 'Información sobre el editor 0736');

INSERT INTO Empleado (id_empleado, nombreEmpleado, inicial_SeguNombre, apellidoEmpleado, id_trabajo, nivel_trabajo, id_Editor, fecha_contraato)
VALUES 
('ABC12345F', 'Carlos', 'A', 'Mendoza', 1, 10, '1389', '2024-12-01'),
('XYZ67890F', 'Laura', 'B', 'González', 2, 20, '0736', '2024-12-02');



select * from Empleado;