USE master
GO
CREATE DATABASE Restaurantes_OpenLicense
GO
USE Restaurantes_OpenLicense
--USE master
--DROP DATABASE Restaurantes_OpenLicense
GO
CREATE TABLE db_style(
id INT PRIMARY KEY IDENTITY,
titulo VARCHAR(25),
telefono VARCHAR(20),
correo VARCHAR(50)
)
GO
--se crea el valor que se modifira en la personalizacion
INSERT INTO db_style VALUES ('Comedor Edith','+503 0000-0000','tucorreoEmpresarial@email.com');
GO
-------------------------------------------------------------TBLAS DE USUARIO----------------------------------------------------------------
create table Tipo_usuario(
idTipoUsuario int identity(1,1),
TipoUsuario varchar(100)
constraint pk_Tipo_usuario primary key (idTipoUsuario)
)
GO
--Insertanto tipos de usuario
INSERT INTO Tipo_usuario VALUES ('Administrador'),
('Empleado');
GO

create table Usuarios(
idUsuario int identity(1,1),
nombre varchar(50),
apellido varchar(50),
fechaNacimiento date ,
usuario varchar(50), 
contrasena varchar(30),
email varchar(100),
Telefono varchar(20),
idTipoUsuario int,
constraint pk_Idusuario primary key (idUsuario),
constraint fk_TipoUsuario foreign key (idTipoUsuario) references Tipo_usuario (idTipoUsuario)
)
GO

--Insertando usuarios de prueba
INSERT INTO Usuarios (nombre, apellido, fechaNacimiento, usuario, contrasena, email, Telefono, idTipoUsuario) 
VALUES ('Juan', 'Pérez', '2000-10-3', 'JuanP12', '123456', 'juan.perez@gmail.com', '7361839', 1),
('Pedro', 'Hernández', '2001-6-12', 'Pedro11', '123456', 'pedro.hndz@gmail.com', '7810385', 2),
('Santos', 'Lemus', '2000-10-3', 'santos', '123456', 'juan.perez@gmail.com', '60606600', 1);
GO



--------------------------------------------------------------------------FIN TABLAS DE USUARIO---------------------------------------------------------




--------------------------------------------------------------------------TABLAS PRODUCTOS
create table Productos(
idProducto int identity(1,1),
nombreProducto varchar(25),
codigoProducto varchar(5),
precioProducto float,
Descripcion varchar(255),
imgProducto image NULL,
constraint pk_Productos primary key (idProducto)
)
GO

--Insertando productos (No insertarlos deste aquí)
INSERT INTO Productos (nombreProducto, codigoProducto, precioProducto, Descripcion) VALUES 
('Pizza', 'PR775', '10', 'Aquí descripción'),
('Hambuerguesa', 'PR662', '7.25', 'Aquí descripción'),
('Ensalada', 'PR725', '5', 'Aquí descripción'),
('Pollo Asado', 'PR687', '6.5', 'Aquí descripción'),
('Paella', 'PR636', '7.25', 'Aquí descripción');
GO




create table Pedido(
idPedido int identity(1,1),
idUsuario int,
fechaPedido datetime,
estadoPedido int,
totalPedido float,
constraint pk_idPedidio primary key (idPedido)
)

ALTER TABLE Pedido
ADD CONSTRAINT DF_Fecha 
DEFAULT getdate() for fechaPedido

create table Detalle_pedido(
idDetalle int identity(1,1),
idProducto int,
cantidadProducto int,
precioDetalle float,
idPedido int
constraint pk_Detalle_pedido primary key (idDetalle),
constraint fk_Productos foreign key (idProducto) references Productos(idProducto),
constraint fk_idPedido foreign key (idPedido) references Pedido(idPedido)
)





----Consulta para obtener pedidos
--SELECT idPedido,fechaPedido,estadoPedido from Pedido


----Datos de testeo de pedidos
--INSERT INTO Pedido (idUsuario,fechaPedido,estadoPedido,totalPedido) VALUES 
--(2,'2021-02-25',0,125),
--(2,'2021-02-17',0,12),
--(2,'2021-02-12',0,1525),
--(2,'2021-02-01',0,1261.25),
--(2,'2021-02-18',0,125.75),
--(2,'2021-02-19',0,125.75)

--INSERT INTO Detalle_pedido(idProducto, cantidadProducto,precioDetalle,idPedido) VALUES (2,3,123,24)
--, (4,4,23,19), (5,4,23,21), (6,4,23,22), (2,4,23,23)
--SELECT P.idPedido as Id,nombreProducto as Producto, cantidadProducto as Cantidad, fechaPedido from Pedido as P inner join Detalle_pedido as DP on P.idPedido = DP.idPedido 
--inner join Productos as PR on DP.idProducto= PR.idProducto  WHERE estadoPedido=0 order by fechaPedido ASC

--DELETE from Pedido where idPedido=12

--SELECT P.idPedido as Id,nombreProducto as Producto, cantidadProducto as Cantidad, fechaPedido from Pedido as P inner join Detalle_pedido as DP on P.idPedido = DP.idPedido 
--inner join Productos as PR on DP.idProducto= PR.idProducto  WHERE estadoPedido=0 AND P.idPedido=22