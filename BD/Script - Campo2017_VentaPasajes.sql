create table Aerolinea(aerolinea_id int not null primary key,
					   aerolinea_nombre varchar(100));

create table Destino(destino_id int not null primary key,
					 destino_nombre varchar(60));

create table Vuelo(vuelo_numero varchar(10) not null primary key,
				   vuelo_fecha date not null,
				   vuelo_hora time not null,
				   vuelo_destino_id int not null,
				   foreign key(vuelo_destino_id) references Destino(destino_id));

create table Asiento(asiento_numero int not null,
					 asiento_vuelo_numero varchar(10) not null,
					 asiento_ocupado bit not null,
					 primary key(asiento_numero, asiento_vuelo_numero),
					 foreign key(asiento_vuelo_numero) references Vuelo(vuelo_numero));

create table Pasajero(pasajero_id int not null primary key,
					  pasajero_nombre varchar(20) not null,
					  pasajero_apellido varchar(20) not null,
					  pasajero_dni int not null,
					  pasajero_pasaporte int not null,
					  pasajero_fechaNac date not null,
					  pasajero_telefono int not null,
					  pasajero_sexo varchar(10) not null,
					  pasajero_estadoCivil varchar(20));

create table VueloPasajero(vueloPasajero_vuelo varchar(10) not null,
						   vueloPasajero_pasajero int not null,
						   primary key(vueloPasajero_vuelo, vueloPasajero_pasajero),
						   foreign key(vueloPasajero_vuelo) references Vuelo(vuelo_numero),
						   foreign key(vueloPasajero_pasajero) references Pasajero(pasajero_id));

create table Paquete(paquete_id int not null primary key,
					 paquete_descripcion varchar(140));

create table Permiso(permiso_id int primary key not null,
					 permiso_nombre varchar(50) not null);

create table PermisoCompuesto(permisoPadre int not null,
							  permisoHijo int not null,
							  foreign key(permisoPadre) references Permiso(permiso_id),
							  foreign key(permisoHijo) references Permiso(permiso_id));

create table Rol(rol_id int primary key not null,
				 rol_nombre varchar(50) not null)

create table RolPermiso(rolPermiso_rol int not null,
						rolPermiso_permiso int not null,
						foreign key(rolPermiso_rol) references Rol(rol_id),
						foreign key(rolPermiso_permiso) references Permiso(permiso_id));

create table Usuario(usuario_id int primary key not null,
					 usuario_userName varchar(50) not null,
					 usuario_nombre varchar(50) not null,
					 usuario_apellido varchar(50) not null,
					 usuario_password varchar(50) not null,
					 usuario_rol int,
					 foreign key(usuario_rol) references Rol(rol_id));

create table Venta(venta_id int not null primary key,
				   venta_usuario int not null,
				   venta_fecha date not null,
				   venta_precio decimal(19,2) not null,
				   venta_paquete int,
				   foreign key(venta_paquete) references Paquete(paquete_id),
				   foreign key(venta_usuario) references Usuario(usuario_id));

create table VentaPasajero(ventaPasajero_venta int not null,
						   ventaPasajero_pasajero int not null,
						   primary key(ventaPasajero_venta, ventaPasajero_pasajero),
						   foreign key(ventaPasajero_venta) references Venta(venta_id),
						   foreign key(ventaPasajero_pasajero) references Pasajero(pasajero_id));

create table VentaVuelo(ventaVuelo_venta int not null,
						ventaVuelo_vuelo varchar(10) not null,
						primary key(ventaVuelo_venta, ventaVuelo_vuelo),
						foreign key(ventaVuelo_venta) references Venta(venta_id),
						foreign key(ventaVuelo_vuelo) references Vuelo(vuelo_numero));