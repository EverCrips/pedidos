create database Pedidos
drop database Pedidos
create table Proveedores(
	id_proveedor int identity(1,1) not null primary key,
	nombre_proveedor varchar(100) not null,
	rut_proveedor char(12) not null,
	giro_proveedor varchar(100) not null,
	direccion_proveedor varchar(100) not null
)
--EMPRESAS POR DEFECTO
insert into Proveedores values('FasTell','55.555.555-5','FABRICACI�N DE MUEBLES PRINCIPALMENTE DE MADERA','Villa Los Manantiales #123'),
								('Enterprise Comunication','66.666.666-6','VENTA AL POR MENOR DE APARATOS, ART�CULOS, EQUIPO DE USO DOM�STICO N.C.P.','Avenida Pajaritos #54'),
								('AdopT','77.777.777-7','PREPARACI�N DE HILATURA DE FIBRAS TEXTILES; TEJEDURA PROD. TEXTILES','Esquina Los Hermanos con Bailarines'),
								('Comercializadora Ismael','88.888.888-8','FABRICACI�N DE TAPICES Y ALFOMBRA','Galeria Comercial, local 4'),
								('Los Duendes','54.544.544-6','COMERCIO DE ART�CULOS DE SUMINISTROS DE OFICINAS Y ART�CULOS DE ESCRITORIO EN GENERAL','Sierra s/n'),
								('Importadora y Exportadora Luis Jara','65.234.346-6','COMERCIO AL POR MENOR DE ART�CULOS DEPORTIVOS','Avenida Cantantes con Pianistas s/n'),
								('Incruspit','76.435.234-4','COMERCIO AL POR MENOR DE ART�CULOS DEPORTIVOS','Los Principes #22'),
								('Casette','53.234.111-5','FABRICACI�N DE ROPA DE TRABAJO','Galer�a Infran, local 2'),
								('Importadora LOST','77.543.234-2','FABRICACI�N DE CALZADO','Avenida Chile #166'),
								('Family Inter','66.555.333-6','COMERCIO AL POR MENOR DE ART�CULOS DE JOYER�A, FANTAS�AS Y RELOJER�AS','Galer�a Infran, local 7'),
								('El �atito','76.343.345-6','FABRICACI�N DE MUEBLES PRINCIPALMENTE DE MADERA','Villa Los Manantiales #140'),
								('Confecciones Clara','54.344.555-6','FABRICACIONES DE JABONES Y DETERGENTES, PREPARADOS PARA LIMPIAR, PERFUMES Y PREPARADOS DE TOCADOR','Calle Humberto D�az #77'),
								('Caza & Rompe','87.455.777-4','FABRICACI�N DE MUEBLES PRINCIPALMENTE DE MADERA','El Se�orial s/n'),
								('Los Hipoteca','54.334.454-6','VENTA AL POR MAYOR DE PAPEL Y CART�N','Esquina Calle Independencia con Manuel'),
								('Fast 12','54.345.768-4','COMERCIO AL POR MENOR DE COMPUTADORAS, SOFTWARES Y SUMINISTROS','Los Chiguagua s/n'),
								('Muebles Manuel','66.546.765-8','COMERCIO AL POR MENOR DE COMPUTADORAS, SOFTWARES Y SUMINISTROS','Pasaje Los Copihues #11'),
								('Importadora Canarios Ltda.','66.556.657-2','COMERCIO DE ART�CULOS DE SUMINISTROS DE OFICINAS Y ART�CULOS DE ESCRITORIO EN GENERAL','Galer�a Inmaculada, local 1'),
								('Casa Anhis','76.345.222-4','FABRICACI�N DE MUEBLES PRINCIPALMENTE DE MADERA','Villa Los Pajaritos #12'),
								('Vida Social Ltda.','68.345.112-2','VENTA AL POR MAYOR DE MUEBLES','Villa El Remanso, psj. Mariano LaTorre #2222'),
								('Ban Ban & Sus Secuases','59.221.223-5','FABRICACI�N DE MUEBLES PRINCIPALMENTE DE MADERA','Villa Los Manantiales #150')

create table Productos(
	id_producto int identity(1,1) not null primary key,
	estado_producto bit not null,
	nombre_producto varchar(50) not null,
	descripcion_producto varchar(100) not null,
	precioCompra_producto int not null,
	stock_producto int not null,
	idProveedor_producto int not null,
	constraint Productos_Proveedor foreign key(idProveedor_producto) references Proveedores(id_proveedor)
)
--PRODUCTOS POR DEFECTO
insert into Productos values(1,'Silla Oficina Modelo 1', 'Silla econom�mica de madera barnizada modelo 1',22000,10,1),
							 (1,'Silla Oficina Modelo 2', 'Silla costosa de madera barnizada modelo 2',45000,5,1),
							 (1,'Resma de papel Tucan', 'Resma de papel tama�o oficio 300 hojas',5400,100,17),
							 (1,'Set L�pices Pasta', 'Set l�pices pasta (negro, rojo, azul, verde) 8 unidades',1300,40,17),
							 (1,'Notebook Samsung Blanco', 'Notebook marca samsung, color blanco, i5, 12gb ram',350000,4,15),
							 (0,'Set L�pices Pasta amarillos', 'Set l�pices pasta amarillos 8 unidades',1300,0,1),
							 (1,'Set L�pices Pasta amarillos', 'Set l�pices pasta amarillos 8 unidades',1300,0,1)

create table Vendedores(
	codigo_vendedor char(10) not null primary key,
	nombre_vendedor varchar(50) not null,
	run_vendedor char(12) not null
) 
--VENDEDOR POR DEFECTO
insert into Vendedores values('VENDE00001','Cristopher P�rez Vargas','18.973.714-9')

create table Clientes(
	id_cliente int identity(1,1) not null primary key,
	estado_cliente bit not null,
	nombre_cliente varchar(30) not null,
	apellidos_cliente varchar(50) not null,
	run_cliente char(12) not null,
	celular_cliente char(12) not null,
	lineaCredito_cliente int not null,
	descuento_cliente int not null,
)
--CLIENTES POR DEFECTO
insert into Clientes values(1,'Kevin','Labarca Mu�oz','19.343.234-5','+56922334455',3000000,10),
							(1, 'Francisca','D�az Jimenez','20.234.114-5','+56922114466',3000000,10), 
							(1, 'Humberto','Cotapo Gutierrez','16.432.244-5','+56922346655',3000000,10), 
							(1, 'Armando','Casas Chicas','17.555.244-8','+56922199155',3000000,10), 
							(1, 'Anah�s','Carvallo Carvallo','21.311.144-5','+56922198155',3000000,10) 

select cl.id_cliente as 'C�digo', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', 
                                cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Cr�dito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=1 
                                     and cl.nombre_cliente LIKE '%K%' or cl.run_cliente LIKE '%K%'
create table Direcciones(
	id_direccion int identity(1,1) not null primary key,
	nombre_direccion varchar(100) not null,
	ciudad_direccion varchar(50) not null,
	idCliente_direccion int not null,
	constraint Direcciones_Clientes foreign key(idCliente_direccion) references Clientes(id_cliente)
)
--DIRECCIONES POR DEFECTO A LOS DOS CLIENTES
insert into Direcciones values('Los Vaipanes con Los Loros #11','Los Andes',1),
								('Villa El Amanecer s/n','Los Andes',1),
								('El Amanecer bonito #1','San Felipe',2),
								('Avenida Pajaritos #123','Santiago',3),
								('Se�or Pobre s/n','Santiago',4),
								('El Horizonte, calle 3','Los Andes',5)
select cl.nombre_cliente, cl.apellidos_cliente, cl.celular_cliente, cl.descuento_cliente, cl.lineaCredito_cliente, id_direccion, dir.nombre_direccion, dir.ciudad_direccion from Direcciones dir, Clientes cl where dir.idCliente_direccion=1 and cl.id_cliente=dir.idCliente_direccion 

create table FormaPago(
	codigo_formaPago char(5) not null primary key,
	nombre_formaPago varchar(30) not null
)
--FORMAS DE PAGO PREDEFINIDAS
insert into FormaPago values('01EFE','EFECTIVO'),
								('02DEB','DEBITO'),
								('03CRE','LINEA CR�DITO'),							
								('04CHE','CHEQUE')

create table Pedidos(
	id_pedido int identity(1,1) not null primary key,
	fecha_pedido date not null,
	estado_pedido varchar(20) not null, --EN PROCESO-REALIZADO
	auxDireccion_pedido int not null,
	idCliente_pedido int not null,
	codigoVendedor_pedido char(10) not null,
	codigoFormaPago_pedido char(5) not null,
	constraint Pedidos_Clientes foreign key(idCliente_pedido) references Clientes(id_cliente),
	constraint Pedidos_Vendedor foreign key(codigoVendedor_pedido) references Vendedores(codigo_vendedor),
	constraint Pedidos_FormaPago foreign key(codigoFormaPago_pedido) references FormaPago(codigo_formaPago)
)

create table DetallesPedidos(
	id_detallePedido int identity(1,1) not null primary key,
	cantidadProducto_detallePedido int not null,
	precioUnitario_detallePedido int not null,
	precioTotal_detallePedido int not null,
	idPedido_detallePedido int not null,
	idProducto_detallePedido int not null,
	constraint DetallesPedidos_Pedidos foreign key(idPedido_detallePedido) references Pedidos(id_pedido),
	constraint DetallesPedidos_Productos foreign key(idProducto_detallePedido) references Productos(id_producto)
)
