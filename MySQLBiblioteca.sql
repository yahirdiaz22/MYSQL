use biblioteca;
create table Actividad
(
	idActividad int auto_increment primary key,
    nombreActividad VARCHAR (50) ,
	fecha DATETIME,
	descripcion VARCHAR (50),
	estatus BIT DEFAULT 1 ,
    idEmpleado int not null
);
CREATE TABLE ActividadPrograma 
(
	idActividadPrograma int auto_increment primary key,
	nombre VARCHAR (50) not null,
	fecha DATETIME not null,
	estatus BIT DEFAULT 1 not null,
	idEmpleado INT not null
);
CREATE TABLE Biblioteca
(
	idBiblioteca INT auto_increment primary key,
	nombre VARCHAR (50) not null,
	calle VARCHAR (50) not null,
	colonia VARCHAR (50) not null,
	numeroExterior VARCHAR (50) not null,
	telefono INT not null,
	cuidad VARCHAR (50) not null,
	estado VARCHAR (50) not null,
	pais VARCHAR (50) not null,
	estatus BIT DEFAULT 1 not null
);
CREATE TABLE AreaMuseo 
(
	idAreaMuseo int auto_increment primary key,
	nombre VARCHAR (50) not null,
	descripcion VARCHAR (50) not null,
	idBiblioteca INT not null,
	estatus BIT DEFAULT 1 not null

);
CREATE TABLE Adquisicion
(
	idAdquisicion int auto_increment primary key,
	compra INT not null,
	suscripcion VARCHAR (50) not null,
	intercambio VARCHAR (50) not null,
	donacion VARCHAR (50) not null,
	estatus BIT DEFAULT 1 not null
);
CREATE TABLE Archivero
(
	idArchivero INT auto_increment primary key,
	folletos VARCHAR (50) not null,
	recortes VARCHAR (50) not null,
	ilustraciones VARCHAR (50) not null,
	volantes VARCHAR (50) not null,
	avisos VARCHAR (50) not null,
	estatus BIT DEFAULT 1 not null,
    idBiblioteca int
);
CREATE TABLE Articulo
(
	idArticulo	INT auto_increment primary key,
	nombreArticulo VARCHAR (50) not null,
	descripcion VARCHAR (50) not null,
	año DATETIME not null,
	estatus BIT DEFAULT 1 not null,
    idUsuario int,
    idEditorial int
);
CREATE TABLE Autor 
(
idAutor INT  auto_increment primary key,
nombre VARCHAR (50) not null,
apellidoPaterno VARCHAR (50) not null,
apellidoMaterno VARCHAR (50) not null,
calle VARCHAR (50) not null,
colonia VARCHAR (50) not null,
numeroExterior INT not null,
cuidad VARCHAR (50) not null,
estado VARCHAR (50) not null,
pais VARCHAR (50) not null,
telefono INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Boveda
(
idBoveda INT  auto_increment primary key,
nombreLibro VARCHAR (50) not null,
mobiliario VARCHAR (50) not null,
material VARCHAR (50) not null,
idBiblioteca INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Catalogo
(
idCatalogo INT  auto_increment primary key,
autor VARCHAR (50) not null,
materias VARCHAR (50) not null,
titulo VARCHAR (50) not null,
referenciaBibliografica VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca int not null
);
CREATE TABLE Clasificacion
(
idClasificacion INT  auto_increment primary key,
descripcion VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca INT not null
);
CREATE TABLE Coleccion
(
idColeccion INT auto_increment primary key,
descripcion VARCHAR (50) not null,
numeroColeccion INT not null,
estatus BIT DEFAULT 1 not null
); 
CREATE TABLE ColeccionLibro
(
idColeccionLibro INT  auto_increment primary key,
idColeccion INT not null,
idLibro INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Comite
(
idComite INT auto_increment primary key,
nombre VARCHAR (50) not NULL,
numeroPersonas INT not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca int not null
);
CREATE TABLE Convenio
(
idConvenio INT auto_increment primary key,
descripcion VARCHAR (50) not null,
fechaInicio DATETIME not null,
fechaFinal DATETIME not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca int not null
); 
CREATE TABLE Copias
(
idCopias INT auto_increment primary key,
numCopias INT not null,
descripcion VARCHAR (50) not null,
fecha DATETIME not null,
estatus BIT DEFAULT 1 not null,
idLibro INT not null
); 
CREATE TABLE Credencial
(
idCredencial INT auto_increment primary key,
nombre VARCHAR (50) not null,
apellidoPaterno VARCHAR (50) not null,
apellidoMaterno VARCHAR (50) not null,
calle VARCHAR (50) not null,
numeroExterior INT not null,
cuidad VARCHAR (50) not null,
estado VARCHAR (50) not null,
pais VARCHAR (50) not null,
claveElector VARCHAR (50) not null,
CURP VARCHAR (18) not null,
fechaNacimiento DATETIME not null,
vigencia INT not null,
sexo VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idUsuario INT not null
);
CREATE TABLE Devolucion
(
idDevolucion INT auto_increment primary key,
fechaEntrega DATETIME not null,
descripcion VARCHAR (50) not null,
cantidadDevolucion INT not null,
estatus BIT DEFAULT 1 not null,
idUsuario INT not null
);
CREATE TABLE DevolucionPrestamo 
(
idDevolucionPrestamo INT auto_increment primary key,
idDevolucion INT not null,
idPrestamo INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE DimensionLudica 
(
idDimensionLudica INT auto_increment primary key,
representacion VARCHAR (50) not null,
debates VARCHAR (50) not null,
proyeccionPeliculasDocumentos VARCHAR (50) not null,
seccionJuegoMesa VARCHAR (50) not null,
idBiblioteca INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Documento
(
idDocumento INT  auto_increment primary key,
videos VARCHAR (50) not null,
cds VARCHAR (50) not null,
dvd VARCHAR (50) not null,
mapas VARCHAR (50) not null,
planos VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca INT not null
);
CREATE TABLE Editorial
(
idEditorial INT  auto_increment primary key,
nombre VARCHAR (50) not null,
calle VARCHAR (50) not null,
colonia VARCHAR (50) not null,
numeroExterior INT not null,
cuidad VARCHAR (50) not null,
estado VARCHAR (50) not null,
pais VARCHAR (50) not null,
telefono INT not null,
estatus BIT DEFAULT 1 not null,
idLibro INT not null,
idRevista INT not null
);
CREATE TABLE EditorialLibro
(
idEditorialLibro INT  auto_increment primary key,
idEditorial INT not null,
idLibro INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE EditorialRevista
(
idEditorialRevista INT auto_increment primary key,
idEditorial INT not null,
idRevista INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Ejemplares 
(
idEjemplares INT auto_increment primary key,
totalEjemplares INT not null,
descripcion VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE EjemplaresLibro 
(
idEjemplaresLibro INT auto_increment primary key,
idEjemplares INT not null,
idLibro INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Empleado 
(
    idEmpleado INT auto_increment primary key,
    nombre VARCHAR(50) NOT NULL,
    apellidoPaterno VARCHAR(50) NOT NULL,
    apellidoMaterno VARCHAR(50) NOT NULL,
    rfc VARCHAR(13) NOT NULL,
    calle VARCHAR(50) NOT NULL,
    colonia VARCHAR(50) NOT NULL,
    numeroExterior VARCHAR(10) NOT NULL,
    cuidad VARCHAR(50) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    pais VARCHAR(50) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    estatus BIT DEFAULT 1 NOT NULL,
    idBiblioteca INT NOT NULL
);
CREATE TABLE EmpleadoActividad
( 
idEmpleadoActividad INT  auto_increment primary key,
idEmpleado INT not null,
idActividad INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE EquipoComputo
(
idEquipoComputo INT auto_increment primary key,
marca VARCHAR (50) not null,
numeroEquipo VARCHAR (50) not null,
fechaInicio DATETIME not null,
fechaFinal DATETIME not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca INT not null
);
CREATE TABLE Estanteria 
(
idEstanteria INT auto_increment primary key,
numeroEstanteria INT not null,
descripcion VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idClasificacion INT not null
);
CREATE TABLE FichaTecnica
(
idFichaTecnica INT auto_increment primary key,
año DATETIME not null,
sinopsis VARCHAR (50) not null,
idiomaOriginal VARCHAR (50) not null,
titulo VARCHAR (50) not null,
ilustradorOriginal VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idLibro INT not null
);
CREATE TABLE Galeria
(
idGaleria INT auto_increment primary key,
nombre VARCHAR (50) not null,
nombreArtista VARCHAR (50) not null,
fechaInicio DATETIME not null,
fechaFinal DATETIME not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca INT not null
);
CREATE TABLE Genero
(
idGenero INT  auto_increment primary key,
genero VARCHAR (50) not null,
descripcion VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idLibro INT NOT NULL
);
CREATE TABLE GrupoLectura
(
idGrupoLectura INT  auto_increment primary key,
descripcion VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idUsuario INT not null,
idBiblioteca INT not null
);
CREATE TABLE Idioma
(
idIdioma INT auto_increment primary key,
nombreIdioma VARCHAR(50) not null,
descripcion VARCHAR (50) not null,
paisOrigen VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idLibro INT not null
);
CREATE TABLE Imprenta 
(
idImprenta INT auto_increment primary key,
nombre VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
numeroImprenta INT not null,
descripcion VARCHAR (50) not null,
cantidadTotal INT not null,
idEditorial INT not null
);
CREATE TABLE Inventario 
(
idInventario INT  auto_increment primary key,
descripcion VARCHAR (50) not null,
fecha DATETIME not null,
estatus BIT DEFAULT 1 not null,
idEmpleado INT not null
);
CREATE TABLE Libro
(
idLibro INT auto_increment primary key,
nombre varchar (50) not null,
pais VARCHAR (50) not null,
cantidadPaginas INT not null,
estatus BIT DEFAULT 1 not null,
idTema INT not null,
idPasta INT not null,
idPrestamo INT not null,
idAutor INT not null,
idMaterial INT not null,
idUsuario INT not null,
idEstanteria INT not null,
idBiblioteca INT not null,
idAdquisicion INT not null
);
CREATE TABLE Material
(
idMaterial INT auto_increment primary key,
tipoMaterial VARCHAR (50) not null,
cantidadMaterial INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE MaterialDidactico
(
idMaterialDidactico INT auto_increment primary key,
globoTerraqueo VARCHAR (50) not null,
descripcion VARCHAR (50) not null,
juegosDidacticos VARCHAR (50) not null,
mapas VARCHAR (50) not null,
laminas VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca INT not null
);
CREATE TABLE Mobiliario 
(
idMobiliario INT auto_increment primary key,
sillas INT not null,
mesas INT not null,
estatus BIT DEFAULT 1 not null,
idBoveda INT not null
);
CREATE TABLE Multa 
(
idMulta INT auto_increment primary key,
descripcion VARCHAR (50) not null,
precio INT not null,
estatus BIT DEFAULT 1 not null,
idUsuario INT not null
);
CREATE TABLE Pasta
(
idPasta INT auto_increment primary key,
color VARCHAR (50) not null,
tipoPasta VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Piso
(
idPiso INT  auto_increment primary key,
descripcion VARCHAR (50) not null,
numPiso INT not null,
idBiblioteca INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Prestamo
(
idPrestamo INT auto_increment primary key,
fecha DATETIME not null,
fecheEntrega DATETIME not null,
estatus BIT DEFAULT 1 not null,
idCredencial INT not null
);
CREATE TABLE Proveedor
(
idProveedor INT  auto_increment primary key,
nombre VARCHAR (50) not null,
apellidoPaterno VARCHAR (50) not null,
apellidoMaterno VARCHAR (50) not null,
rfc VARCHAR (50) not null,
calle VARCHAR (50) not null,
colonia VARCHAR (50) not null,
numeroExterior INT not null,
cuidad VARCHAR (50) not null,
estado VARCHAR (50) not null,
pais VARCHAR (50) not null,
telefono INT not null,
estatus BIT DEFAULT 1 not null,
idPedido INT not null
);
CREATE TABLE ProveedorLibro 
(
idProveedorLibro INT  auto_increment primary key,
idProveedor INT not null,
idLibro INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE ProveedorRevista 
(
idProveedorRevista INT  auto_increment primary key,
idProveedor INT not null,
idRevista INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE RegistroVisita
(
idRegistroVisita INT  auto_increment primary key,
nombre VARCHAR (50) not null,
fechaLlegada datetime not null,
fechaIda datetime not null,
apellidoPaterno VARCHAR (50) not null,
apellidoMaterno VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idUsuario INT not null
);
CREATE TABLE Periodico
(
idPeriodico INT  auto_increment primary key,
nombre VARCHAR (50) not null,
nombreImprenta VARCHAR (50) not null,
fecha DATETIME not null,
descripcion VARCHAR (50) not null,
titulo VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idImprenta INT not null
);
CREATE TABLE Revista
(
idRevista INT auto_increment primary key,
nombre VARCHAR (50) not null,
editorial VARCHAR (50) not null,
numeroPagina INT not null,
pais VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Secciones 
(
idSecciones INT auto_increment primary key,
lecturaConsulta VARCHAR (50) not null,
videoteka VARCHAR (50) not null,
fonoteca VARCHAR (50) not null,
hemeroteca VARCHAR (50) not null,
coleccionLocal VARCHAR (50) not null,
autoServicioFotoCopias INT not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca INT not null
);
CREATE TABLE Socio
(
idSocio INT  auto_increment primary key,
nombre VARCHAR (50) not null,
apellidoPaterno VARCHAR (50) not null,
apellidoMaterno VARCHAR (50) not null,
calle VARCHAR (50) not null,
colonina VARCHAR (50) not null,
numeroExterior INT not null,
cuidad VARCHAR (50) not null,
estado VARCHAR (50) not null,
pais VARCHAR (50) not null,
telefono INT not null,
estatus BIT DEFAULT 1 not null,
idPrestamo INT not null
);
CREATE TABLE Taller
(
idTaller INT auto_increment primary key,
nombre VARCHAR (50) not null,
fecha DATETIME not null,
descripcion VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idBiblioteca INT not null
);
CREATE TABLE Tema 
(
idTema INT auto_increment primary key,
tema VARCHAR (50) not null,
desrcipcion VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE Traduccion
(
idTraduccion INT auto_increment not null,
traduccion VARCHAR (50) not null,
descripcion VARCHAR (50) not null,
nombre VARCHAR (50) not null,
año DATETIME not null,
pais VARCHAR (50) not null,
estatus BIT DEFAULT 1 not null,
idLibro INT not null,
primary key (idTraduccion)
);
CREATE TABLE Usuario
(
idUsuario INT auto_increment primary key,
nombre VARCHAR (50) not null,
apellidoPaterno VARCHAR (50) not null,
apellidoMaterno VARCHAR (50) not null,
fechaNacimiento DATETIME not null,
calle VARCHAR (50) not null,
numeroExterior INT  not null,
cuidad VARCHAR (50) not null,
estado VARCHAR (50) not null,
pais VARCHAR (50) not null,
telefono INT not null,
estatus BIT DEFAULT 1 not null
);
CREATE TABLE UsuarioPrestamo 
(
idUsuarioPrestamo INT auto_increment primary key,
idUsuario INT not null,
idPrestamo INT not null,
estatus BIT DEFAULT 1 not null
);
##Llave foraneas
#ACTIVIDAD
ALTER TABLE Actividad ADD CONSTRAINT FK_ActividadEmpleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado);
#ACTIVIDADPROGRAMA
ALTER TABLE ActividadPrograma ADD CONSTRAINT FK_ActividadProgramaEmpleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado);
#ARCHIVERO
ALTER TABLE Archivero ADD CONSTRAINT FK_ArchiveroBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#AREAMUSEO
ALTER TABLE AreaMuseo ADD CONSTRAINT FK_AreaMuseoBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#ARTICULO
ALTER TABLE Articulo ADD CONSTRAINT FK_ArticuloUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario);
ALTER TABLE Articulo ADD CONSTRAINT FK_ArticuloEditorial FOREIGN KEY (idEditorial) REFERENCES Editorial (idEditorial);
#BOBEDA
ALTER TABLE Boveda ADD CONSTRAINT FK_BovedaBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#CATALOGO
ALTER TABLE Catalogo ADD CONSTRAINT FK_CatalogoBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#CLASIFICACION 
ALTER TABLE Clasificacion ADD CONSTRAINT FK_ClasificacionBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#COLECCIONLIBRO
ALTER TABLE ColeccionLibro ADD CONSTRAINT FK_ColeccionLibroColeccion FOREIGN KEY (idColeccion) REFERENCES Coleccion (idColeccion);
ALTER TABLE ColeccionLibro ADD CONSTRAINT FK_ColeccionLibroLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
#COMITE
ALTER TABLE Comite ADD CONSTRAINT FK_ComiteBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#CONVENIO
ALTER TABLE Convenio ADD CONSTRAINT FK_ConvenioBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#COPIAS
ALTER TABLE Copias ADD CONSTRAINT FK_CopiasLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
#CREDENCIAL
ALTER TABLE Credencial ADD CONSTRAINT FK_CredencialUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario);
#DEVOLUCION
ALTER TABLE Devolucion ADD CONSTRAINT FK_DevolucionUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario);
#DEVOLUCIONPRESTAMO
ALTER TABLE DevolucionPrestamo ADD CONSTRAINT FK_DevolucionPrestamoDevolucion FOREIGN KEY (idDevolucion) REFERENCES Devolucion (idDevolucion);
ALTER TABLE DevolucionPrestamo ADD CONSTRAINT FK_DevolucionPrestamoPrestamo FOREIGN KEY (idPrestamo) REFERENCES Prestamo (idPrestamo);
#DIMENSIONLUDICA
ALTER TABLE DimensionLudica ADD CONSTRAINT FK_DimensionLudicaBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#DOCUMENTOS
ALTER TABLE Documento ADD CONSTRAINT FK_DocumentoBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#EDITORIAL
ALTER TABLE Editorial ADD CONSTRAINT FK_EditorialLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
ALTER TABLE Editorial ADD CONSTRAINT FK_EditorialRevista FOREIGN KEY (idRevista) REFERENCES Revista (idRevista);
#EDITORIALLIBRO
ALTER TABLE EditorialLibro ADD CONSTRAINT FK_EditorialLibroEditorial FOREIGN KEY (idEditorial) REFERENCES Editorial (idEditorial);
ALTER TABLE EditorialLibro ADD CONSTRAINT FK_EditorialLibroLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
#EDITORIALREVISTA
ALTER TABLE EditorialRevista ADD CONSTRAINT FK_EditorialRevistaEditorial FOREIGN KEY (idEditorial) REFERENCES Editorial (idEditorial);
ALTER TABLE EditorialRevista ADD CONSTRAINT FK_EditorialRevistaRevista FOREIGN KEY (idRevista) REFERENCES Revista (idRevista);
#EJEMPLARESLIBRO
ALTER TABLE EjemplaresLibro ADD CONSTRAINT FK_EjemplaresLibroEjemplares FOREIGN KEY (idEjemplares) REFERENCES Ejemplares (idEjemplares);
ALTER TABLE EjemplaresLibro ADD CONSTRAINT FK_EjemplaersLibroLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
#EMPLEADO
ALTER TABLE Empleado ADD CONSTRAINT FK_EmpleadoBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#EMPLEDOACTIVIDAD
ALTER TABLE EmpleadoActividad ADD CONSTRAINT FK_EmpleadoActividadEmpleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado) ;
ALTER TABLE EmpleadoActividad ADD CONSTRAINT FK_EmpleadoActividadActividad FOREIGN KEY (idActividad) REFERENCES Actividad (idActividad);
#EQUIPOCOMPUTO
ALTER TABLE EquipoComputo ADD CONSTRAINT FK_EquipoComputoBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#ESTANTERIA
ALTER TABLE Estanteria ADD CONSTRAINT FK_EstanteriaClasificacion FOREIGN KEY (idClasificacion) REFERENCES Clasificacion (idClasificacion);
#FICHATECNICA
ALTER TABLE FichaTecnica ADD CONSTRAINT FK_FichaTecnicaLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
#GALERIA 
ALTER TABLE Galeria ADD CONSTRAINT FK_GaleriaBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#GENERO
ALTER TABLE Genero ADD CONSTRAINT FK_GeneroLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
#GRUPOLECTURA
ALTER TABLE GrupoLectura ADD CONSTRAINT FK_GrupoLecturaUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario);
ALTER TABLE GrupoLectura ADD CONSTRAINT FK_GrupoLecturaBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#IDIOMA
ALTER TABLE Idioma ADD CONSTRAINT FK_IdiomaLibro FOREIGN KEY (idLibro)  REFERENCES Libro (idLibro);
#IMPRENTA
ALTER TABLE Imprenta ADD CONSTRAINT FK_ImprentaEditorial FOREIGN KEY (idEditorial) REFERENCES Editorial (idEditorial);
#INVENTARIO 
ALTER TABLE Inventario ADD CONSTRAINT FK_InventarioEmpleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado);
#LIBRO
ALTER TABLE Libro ADD CONSTRAINT FK_LibroTema FOREIGN KEY (idTema) REFERENCES Tema (idTema);
ALTER TABLE Libro ADD CONSTRAINT FK_LibroPasta FOREIGN KEY (idPasta) REFERENCES Pasta (idPasta);
ALTER TABLE Libro ADD CONSTRAINT FK_LibroPrestamo FOREIGN KEY (idPrestamo) REFERENCES Prestamo (idPrestamo);
ALTER TABLE Libro ADD CONSTRAINT FK_LibroAutor FOREIGN KEY (idAutor) REFERENCES Autor (idAutor) ;
ALTER TABLE Libro ADD CONSTRAINT FK_LibroUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario);
ALTER TABLE Libro ADD CONSTRAINT FK_LibroBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
ALTER TABLE Libro ADD CONSTRAINT FK_LibroMaterial FOREIGN KEY (idMaterial) REFERENCES Material (idMaterial);
ALTER TABLE Libro ADD CONSTRAINT FK_LibroAdquisicion FOREIGN KEY (idAdquisicion) REFERENCES Adquisicion (idAdquisicion);
#MATERIALDIDACTICO
ALTER TABLE MaterialDidactico ADD CONSTRAINT FK_MaterialDidacticoBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#MOBILIARIO
ALTER TABLE Mobiliario ADD CONSTRAINT FK_MobiliarioBoveda FOREIGN KEY (idBoveda) REFERENCES Boveda (idBoveda) ;
#Multa 
ALTER TABLE Multa ADD CONSTRAINT FK_MultaUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario);
#PERIODICO
ALTER TABLE Periodico ADD CONSTRAINT FK_PeriodicoImprenta FOREIGN KEY (idImprenta) REFERENCES Imprenta (idImprenta);
#PISO
ALTER TABLE Piso ADD CONSTRAINT FK_PisoBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#PRESTAMO
ALTER TABLE Prestamo ADD CONSTRAINT FK_PrestamoCredencial FOREIGN KEY (idCredencial) REFERENCES Credencial (idCredencial);
#PROVEEDORLIBRO
ALTER TABLE ProveedorLibro ADD CONSTRAINT FK_ProveedorLibroLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
ALTER TABLE ProveedorLibro ADD CONSTRAINT FK_ProveedorLibroProveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor (idProveedor);
#PROVEEDORREVISTA
ALTER TABLE ProveedorRevista ADD CONSTRAINT FK_ProveedorRevista FOREIGN KEY (idRevista) REFERENCES Revista (idRevista);
ALTER TABLE ProveedorRevista ADD CONSTRAINT FK_ProveedorRevistaProveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor (idProveedor);
#REGISTROVISITA
ALTER TABLE RegistroVisita ADD CONSTRAINT FK_RegistroVisitaUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario);
#SECCIONES
ALTER TABLE Secciones ADD CONSTRAINT FK_SeccionesBiblitoeca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#SOCIO
ALTER TABLE Socio ADD CONSTRAINT FK_SocioPrestamo FOREIGN KEY (idPrestamo) REFERENCES Prestamo (idPrestamo);
#TALLER 
ALTER TABLE Taller ADD CONSTRAINT FK_TallerBiblioteca FOREIGN KEY (idBiblioteca) REFERENCES Biblioteca (idBiblioteca);
#TRADUCCION
ALTER TABLE Traduccion ADD CONSTRAINT FK_TraduccionLibro FOREIGN KEY (idLibro) REFERENCES Libro (idLibro);
#USUARIOPRESTAMO
ALTER TABLE UsuarioPrestamo ADD CONSTRAINT FK_UsuarioPrestamo FOREIGN KEY (idPrestamo) REFERENCES Prestamo (idPrestamo);
ALTER TABLE UsuarioPrestamo ADD  FOREIGN KEY (idPrestamo) REFERENCES Prestamo (idPrestamo);
#INDEX
CREATE index IX_Actividad on Actividad (idActividad);
CREATE INDEX IX_ActividadPrograma  ON ActividadPrograma(idActividadPrograma);
create index IX_Adquisicion on Adquisicion (idAdquisicion);
create index IX_Archivero on Archivero (idArchivero);
create index IX_AreaMuseo on AreaMuseo (idAreaMuseo);
create index IX_Articulo on  Articulo (idArticulo);
create index IX_Autor on Autor (idAutor);
create index IX_Biblioteca on Biblioteca (idBiblioteca);
create index IX_Boveda on Boveda (idBoveda);
create index IX_Catalogo on Catalogo (idCatalogo);
create index IX_Clasificacion on Clasificacion (idClasificacion);
create index IX_Coleccion on Coleccion (idColeccion);
create index IX_Comite on Comite (idComite);
create index IX_Convenio on Convenio (idConvenio);
create index IX_Copias on Copias (idCopias);
create index IX_Credencial on Credencial (idCredencial);
create index IX_Devolucion on Devolucion (idDevolucion);
create index IX_DevolucionPrestamo on DevolucionPrestamo (idDevolucionPrestamo);
create index IX_DimensionLudica on DimensionLudica (idDimensionLudica);
create index IX_Documento on Documento (idDocumento);
create index IX_Editorial on Editorial (idEditorial);
create index IX_EditorialLibro on EditorialLibro (idEditorialLibro);
create index IX_EditorialRevista on EditorialRevista (idEditorialRevista);
create index IX_Ejemplares on Ejemplares (idEjemplares);
create index IX_EjemplaresLibro on EjemplaresLibro (idEjemplaresLibro);
create index IX_EquipoComputo on EquipoComputo (idEquipoComputo);
create index IX_Estanteria on Estanteria (idEstanteria);
create index IX_FichaTecnica on FichaTecnica (idFichaTecnica);
create index IX_Galeria on Galeria (idGaleria);
create index IX_Genero on Genero (idGenero);
create index IX_GrupoLectura on GrupoLectura (idGrupoLectura);
CREATE INDEX IX_Idioma ON Idioma (idIdioma);
CREATE INDEX IX_Imprenta ON Imprenta (idImprenta);
CREATE INDEX IX_Inventario ON Inventario (idInventario);
CREATE INDEX IX_Libro ON Libro (idLibro);
CREATE INDEX IX_Material ON Material (idMaterial);
CREATE INDEX IX_Mobiliario ON Mobiliario (idMobiliario);
CREATE INDEX IX_Multa ON Multa (idMulta);
CREATE INDEX IX_Pasta ON Pasta (idPasta);
CREATE INDEX IX_Periodico ON Periodico (idPeriodico);
CREATE INDEX IX_Piso ON Piso (idPiso);
CREATE INDEX IX_Prestamo ON Prestamo (idPrestamo);
CREATE INDEX IX_Proveedor ON Proveedor (idProveedor);
CREATE INDEX IX_ProveedorLibro ON ProveedorLibro (idProveedorLibro);
CREATE INDEX IX_ProveedorRevista on ProveedorRevista (idProveedorRevista);
CREATE INDEX IX_RegistroVisita ON RegistroVisita (idRegistroVisita);
CREATE INDEX IX_Revista ON Revista (idRevista);
CREATE INDEX IX_Secrevistaciones ON Secciones (idSecciones);
CREATE INDEX IX_Socio ON Socio (idSocio);
CREATE INDEX IX_Taller ON Taller (idTaller);
CREATE INDEX IX_Tema ON Tema (idTema);
CREATE INDEX IX_Traduccion ON Traduccion (idTraduccion);
CREATE INDEX IX_Usuario ON Usuario (idUsuario);
CREATE INDEX IX_UsuarioPrestamo ON UsuarioPrestamo (idUsuarioPrestamo);


insert into biblioteca (nombre,calle,colonia,numeroExterior,telefono,cuidad,estado,pais)
values ('biblioteca pape','progreso','flores','1242',12412512,'monclova','coahuila','mexico'),
('biblioteca central','nicolas bravo','zona centro','311',4124125,'saltillo','coahuila','mexico'),
('biblioteca 3','calle3','colonia3','41241',412412,'cuidad3','estado3','pais3'),
('biblioteca 4','calle4','colonia4','3145',283950,'cuidad4','estado4','pais4'),
('biblioteca 5','calle5','colonia5','21351',6205,'cuidad5','estado5','pais5'),
('biblioteca 6','calle6','colonia6','552315',2135890,'cuidad6','estado6','pais6'),
('biblioteca 7','calle7','colonia7','75452',62358,'cuidad7','estado7','pais7'),
('biblioteca 8','calle8','colonia8','17289',2789,'cuidad8','estado8','pais8'),
('biblioteca 9','calle9','colonia9','87152',23857,'cuidad9','estado9','pais9'),
('biblioteca 10','calle10','colonia10','817132',2378,'cuidad10','estado10','pais10');

select *from Biblioteca;

UPDATE Biblioteca set calle= 'calle12' where idBiblioteca = 5;


select * from Biblioteca;


INSERT INTO Autor (nombre,apellidoPaterno,apellidoMaterno,calle,colonia,numeroExterior,cuidad,estado,pais,telefono)
values ('Rodriguez','Hernandez','Guitierrez','lopez mateo','garza',4124,'Monterrey','Coahuila','Mexico',81149510),
('nombre2','apellidopaterno2','apellidomaterno2','calle2','colonia2',8894,'cuidad2','estado2','pais2',4124121),
('nombre3','apellidopaterno3','apellidomaterno3','calle3','colonia3',4124,'cuidad3','estado3','pais3',12512413),
('nombre4','apellidopaterno4','apellidomaterno4','calle4','colonia4',5123,'cuidad4','estado4','pais4',32512351),
('nombre5','apellidopaterno5','apellidomaterno5','calle5','colonia5',7257,'cuidad5','estado5','pais5',6914813),
('nombre6','apellidopaterno6','apellidomaterno6','calle6','colonia6',5132,'cuidad6','estado6','pais6',71982135),
('nombre7','apellidopaterno7','apellidomaterno7','calle7','colonia7',3151,'cuidad7','estado7','pais7',9106141),
('nombre8','apellidopaterno8','apellidomaterno8','calle8','colonia8',5324,'cuidad8','estado8','pais8',113496643),
('nombre9','apellidopaterno9','apellidomaterno9','calle9','colonia9',5123,'cuidad9','estado9','pais9',4136891),
('nombre10','apellidopaterno10','apellidomaterno10','calle10','colonia10',2351,'cuidad10','estado10','pais10',13611436);

SELECT *FROM Autor;

update Autor set nombre = 'jaime' where idAutor = 1;

INSERT INTO Autor (nombre,apellidoPaterno,apellidoMaterno,calle,colonia,numeroExterior,cuidad,estado,pais,telefono)
values ('Rodriguez','Hernandez','Guitierrez','lopez mateo','garza',4124,'saltillo','Coahuila','Mexico',81149510),
('nombre2','apellidopaterno2','apellidomaterno2','calle2','colonia2',8894,'cuidad2','estado2','pais2',4124121),
('nombre3','apellidopaterno3','apellidomaterno3','calle3','colonia3',4124,'cuidad3','estado3','pais3',12512413),
('nombre4','apellidopaterno4','apellidomaterno4','calle4','colonia4',5123,'cuidad4','estado4','pais4',32512351),
('nombre5','apellidopaterno5','apellidomaterno5','calle5','colonia5',7257,'cuidad5','estado5','pais5',6914813),
('nombre6','apellidopaterno6','apellidomaterno6','calle6','colonia6',5132,'cuidad6','estado6','pais6',71982135),
('nombre7','apellidopaterno7','apellidomaterno7','calle7','colonia7',3151,'cuidad7','estado7','pais7',9106141),
('nombre8','apellidopaterno8','apellidomaterno8','calle8','colonia8',5324,'cuidad8','estado8','pais8',113496643),
('nombre9','apellidopaterno9','apellidomaterno9','calle9','colonia9',5123,'cuidad9','estado9','pais9',4136891),
('nombre10','apellidopaterno10','apellidomaterno10','calle10','colonia10',2351,'cuidad10','estado10','pais10',13611436);


select *from Autor;

INSERT INTO Empleado (nombre,apellidoPaterno,apellidoMaterno,rfc,calle,colonia,numeroExterior,cuidad,estado,pais,telefono,idBiblioteca)
values ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',1234,'cuiadad1','estado1','pais1','1241241',1),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',4321,'cuiadad1','estado1','pais1','1241241',2),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',5123,'cuiadad1','estado1','pais1','1241241',3),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',6341,'cuiadad1','estado1','pais1','1241241',4),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',1643,'cuiadad1','estado1','pais1','1241241',5),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',1346,'cuiadad1','estado1','pais1','1241241',6),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',1345,'cuiadad1','estado1','pais1','1241241',7),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',6413,'cuiadad1','estado1','pais1','1241241',8),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',3461,'cuiadad1','estado1','pais1','1241241',9),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1',4214,'cuiadad1','estado1','pais1','1241241',10);
select *from Empleado;


insert into Actividad (nombreActividad,fecha,descripcion,idEmpleado)
values ('nombreActividad1','2022-12-12','descripcion1',1),
('nombreActividad2','2022-12-12','descripcion1',2),
('nombreActividad3','2022-11-12','descripcion1',3),
('nombreActividad4','2022-10-12','descripcion1',4),
('nombreActividad5','2022-9-12','descripcion1',5),
('nombreActividad6','2022-8-12','descripcion1',6),
('nombreActividad7','2022-7-12','descripcion1',7),
('nombreActividad8','2022-6-12','descripcion1',8),
('nombreActividad9','2022-5-12','descripcion1',9),
('nombreActividad10','2022-4-12','descripcion1',10);

select *from Actividad;

insert into ActividadPrograma (nombre,fecha,idEmpleado)
values ('nombre1','2022-10-5',1),
('nombre2','2022-10-5',2),
('nombre3','2022-10-5',3),
('nombre4','2022-10-5',4),
('nombre5','2022-10-5',5),
('nombre6','2022-10-5',6),
('nombre7','2022-10-5',7),
('nombre8','2022-10-5',8),
('nombre9','2022-10-5',9),
('nombre10','2022-10-5',10);

select *from ActividadPrograma;



insert into AreaMuseo (nombre,descripcion,idBiblioteca)
values ('nombre1','descripcion1',1),
('nombre2','descripcion2',2),
('nombre3','descripcion3',3),
('nombre4','descripcion4',4),
('nombre5','descripcion5',5),
('nombre6','descripcion6',6),
('nombre7','descripcion7',7),
('nombre8','descripcion8',8),
('nombre9','descripcion9',9),
('nombre10','descripcion10',10);

select *from AreaMuseo;


insert into Archivero (folletos,recortes,ilustraciones,volantes,avisos,idBiblioteca)
values ('folletos1','recores1','ilustraciones1','volantes1','avisos1',1),
('folletos2','recores1','ilustraciones2','volantes2','avisos2',2),
('folletos3','recores1','ilustraciones3','volantes3','avisos1',3),
('folletos4','recores1','ilustraciones4','volantes4','avisos1',4),
('folletos5','recores1','ilustraciones5','volantes5','avisos1',5),
('folletos6','recores1','ilustraciones6','volantes6','avisos1',6),
('folletos7','recores1','ilustraciones7','volantes7','avisos1',7),
('folletos8','recores1','ilustraciones8','volantes8','avisos1',8),
('folletos9','recores1','ilustraciones9','volantes9','avisos1',9),
('folletos10','recores1','ilustraciones10','volantes10','avisos1',10);

select *from Archivero;



insert into Boveda (nombreLibro,mobiliario,material,idBiblioteca)
values ('nombreLibro1','mobiliario1','material1',1),
('nombreLibro2','mobiliario2','material2',2),
('nombreLibro3','mobiliario3','material3',3),
('nombreLibro4','mobiliario4','material4',4),
('nombreLibro5','mobiliario5','material5',5),
('nombreLibro6','mobiliario6','material6',6),
('nombreLibro7','mobiliario7','material7',7),
('nombreLibro8','mobiliario8','material8',8),
('nombreLibro9','mobiliario9','material9',9),
('nombreLibro10','mobiliario10','material10',10);


select *from Boveda;



insert into Catalogo (autor,materias,titulo,referenciaBibliografica,idBiblioteca)
values ('autor1','materias1','titulo1','referenciaBibliografica1',1),
('autor2','materias2','titulo2','referenciaBibliografica2',2),
('autor3','materias3','titulo3','referenciaBibliografica3',3),
('autor4','materias4','titulo4','referenciaBibliografica4',4),
('autor5','materias5','titulo5','referenciaBibliografica5',5),
('autor6','materias6','titulo6','referenciaBibliografica6',6),
('autor7','materias7','titulo7','referenciaBibliografica7',7),
('autor8','materias8','titulo8','referenciaBibliografica8',8),
('autor9','materias9','titulo9','referenciaBibliografica9',9),
('autor10','materias10','titulo10','referenciaBibliografica10',10);

select *from Catalogo;


insert into Clasificacion (descripcion,idBiblioteca)
values ('descripcion1',1),
('descripcion2',2),
('descripcion3',3),
('descripcion4',4),
('descripcion5',5),
('descripcion6',6),
('descripcion7',7),
('descripcion8',8),
('descripcion9',9),
('descripcion10',10);

select *from Clasificacion;


insert into Convenio (descripcion,fechaInicio,fechaFinal,idBiblioteca)
values ('descripcion1','2022-8-28','2022-9-12',1),
('descripcion2','2022-8-25','2022-10-25',2),
('descripcion3','2022-8-22','2022-2-25',3),
('descripcion4','2022-8-28','2022-8-25',4),
('descripcion5','2022-8-12','2022-4-25',5),
('descripcion6','2022-8-4','2022-1-25',6),
('descripcion7','2022-8-5','2022-5-25',7),
('descripcion8','2022-8-12','2022-9-25',8),
('descripcion9','2022-8-5','2022-11-25',9),
('descripcion10','2022-8-1','2022-12-25',10);

select *from Convenio;


insert into Comite (nombre,numeroPersonas,idBiblioteca)
values ('nombre1',1,1),
('nombre2',1,2),
('nombre3',12,3),
('nombre4',13,4),
('nombre5',14,5),
('nombre6',15,6),
('nombre7',16,7),
('nombre8',17,1),
('nombre9',18,1),
('nombre10',19,1);


select *from Comite;



insert into DimensionLudica (representacion,debates,proyeccionPeliculasDocumentos,seccionJuegoMesa,idBiblioteca)
values ('representacion1','debates1','proyeccionPeliculasDocumentos1','seccionJuegoMesa1',1),
('representacion2','debates2','proyeccionPeliculasDocumentos2','seccionJuegoMesa2',2),
('representacion3','debates3','proyeccionPeliculasDocumentos3','seccionJuegoMesa3',3),
('representacion4','debates4','proyeccionPeliculasDocumentos4','seccionJuegoMesa4',4),
('representacion5','debates5','proyeccionPeliculasDocumentos5','seccionJuegoMesa5',5),
('representacion6','debates6','proyeccionPeliculasDocumentos6','seccionJuegoMesa6',6),
('representacion7','debates7','proyeccionPeliculasDocumentos7','seccionJuegoMesa7',7),
('representacion8','debates8','proyeccionPeliculasDocumentos8','seccionJuegoMesa8',8),
('representacion9','debates9','proyeccionPeliculasDocumentos9','seccionJuegoMesa9',9),
('representacion10','debates10','proyeccionPeliculasDocumentos10','seccionJuegoMesa10',10);


select *from DimensionLudica;


insert into Documento (videos,cds,mapas,planos,dvd,idBiblioteca)
values ('videos1','cds1','mapas1','planos1','dvd1',1),
('videos2','cds2','mapas2','planos2','dvd2',1),
('videos3','cds3','mapas3','planos3','dvd3',3),
('videos4','cds4','mapas4','planos4','dvd4',4),
('videos5','cds5','mapas5','planos5','dvd5',5),
('videos6','cds6','mapas6','planos6','dvd6',6),
('videos7','cds7','mapas7','planos7','dvd7',7),
('videos8','cds8','mapas8','planos8','dvd8',8),
('videos9','cds9','mapas9','planos9','dvd9',9),
('videos10','cds10','mapas10','planos10','dvd10',10);


select *from Documento;


insert into Pasta (color,tipoPasta)
values ('color1','tipoPasta1'),
('color2','tipoPasta2'),
('color3','tipoPasta3'),
('color4','tipoPasta4'),
('color5','tipoPasta5'),
('color6','tipoPasta6'),
('color7','tipoPasta7'),
('color8','tipoPasta8'),
('color9','tipoPasta9'),
('color10','tipoPasta10');


select *from Pasta;


insert into Piso (descripcion,numPiso,idBiblioteca)
values ('descripcion1',1,1),
('descripcion2',2,2),
('descripcion3',3,3),
('descripcion4',4,4),
('descripcion5',5,5),
('descripcion6',6,6),
('descripcion7',7,7),
('descripcion8',8,8),
('descripcion9',9,1),
('descripcion10',10,1);

select *from Piso;


insert into Revista (nombre,editorial,numeroPagina,pais)
values ('nombre1','editorial1',22,'pais1'),
('nombre2','editorial2',22,'pais2'),
('nombre3','editorial3',34,'pais3'),
('nombre4','editorial4',14,'pais4'),
('nombre5','editorial5',124,'pais5'),
('nombre6','editorial6',23,'pais6'),
('nombre7','editorial7',52,'pais7'),
('nombre8','editorial8',12,'pais8'),
('nombre9','editorial9',53,'pais9'),
('nombre10','editorial10',53,'pais10');


select *from Revista;


insert into Secciones (lecturaConsulta,videoteka,fonoteca,hemeroteca,coleccionLocal,autoServicioFotoCopias,idBiblioteca)
values ('lecturaConsulta1','videoteka1','fonoteca1','hemeroteca1','coleccionLocal1',2,1),
('lecturaConsulta2','videoteka2','fonoteca2','hemeroteca2','coleccionLocal2',5,1),
('lecturaConsulta3','videoteka3','fonoteca3','hemeroteca3','coleccionLocal3',5,1),
('lecturaConsulta4','videoteka4','fonoteca4','hemeroteca4','coleccionLocal4',8,1),
('lecturaConsulta5','videoteka5','fonoteca5','hemeroteca5','coleccionLocal5',1,1),
('lecturaConsulta6','videoteka6','fonoteca6','hemeroteca6','coleccionLocal6',8,1),
('lecturaConsulta7','videoteka7','fonoteca7','hemeroteca7','coleccionLocal7',3,1),
('lecturaConsulta8','videoteka8','fonoteca8','hemeroteca8','coleccionLocal8',9,1),
('lecturaConsulta9','videoteka9','fonoteca9','hemeroteca9','coleccionLocal9',2,1),
('lecturaConsulta10','videoteka10','fonoteca10','hemeroteca10','coleccionLocal10',8,1);


select *from Secciones;



insert into Usuario (nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento,calle,numeroExterior,cuidad,estado,pais,telefono)
values ('nombre1','apellidoPaterno1','apellidoMaterno1','2022-12-25','calle1',4124,'cuidad1','estado1','pais1',532525),
('nombre2','apellidoPaterno2','apellidoMaterno2','2022-12-25','calle2',4124,'cuidad2','estado2','pais2',532525),
('nombre3','apellidoPaterno3','apellidoMaterno3','2022-12-25','calle3',4124,'cuidad3','estado3','pais3',532525),
('nombre4','apellidoPaterno4','apellidoMaterno4','2022-12-25','calle4',4124,'cuidad4','estado4','pais4',532525),
('nombre5','apellidoPaterno5','apellidoMaterno5','2022-12-25','calle5',4124,'cuidad5','estado5','pais5',532525),
('nombre6','apellidoPaterno6','apellidoMaterno6','2022-12-25','calle6',4124,'cuidad6','estado6','pais6',532525),
('nombre7','apellidoPaterno7','apellidoMaterno7','2022-12-25','calle7',4124,'cuidad7','estado7','pais7',532525),
('nombre8','apellidoPaterno8','apellidoMaterno8','2022-12-25','calle8',4124,'cuidad8','estado8','pais8',532525),
('nombre9','apellidoPaterno9','apellidoMaterno9','2022-12-25','calle9',4124,'cuidad9','estado9','pais9',532525),
('nombre10','apellidoPaterno10','apellidoMaterno10','2022-12-25','calle10',4124,'cuidad10','estado10','pais10',532525);


select *from Usuario;



insert into Credencial (nombre,apellidoPaterno,apellidoMaterno,calle,numeroExterior,cuidad,estado,pais,claveElector,CURP,fechaNacimiento,vigencia,sexo,idUsuario)
values ('nombre1','apellidoPaterno1','apellidoMaterno','calle1',412412,'cuidad1','estado1','pais1','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre2','apellidoPaterno2','apellidoMaterno2','calle2',1241,'cuidad2','estado2','pais2','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre3','apellidoPaterno3','apellidoMaterno3','calle3',13241,'cuidad3','estado3','pais3','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre4','apellidoPaterno4','apellidoMaterno4','calle4',2135123,'cuidad4','estado4','pais4','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre5','apellidoPaterno5','apellidoMaterno5','calle5',3251,'cuidad5','estado5','pais5','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre6','apellidoPaterno6','apellidoMaterno6','calle6',1234,'cuidad6','estado6','pais6','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre7','apellidoPaterno7','apellidoMaterno7','calle7',51235,'cuidad7','estado7','pais7','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre8','apellidoPaterno8','apellidoMaterno8','calle8',134,'cuidad8','estado8','pais8','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre9','apellidoPaterno9','apellidoMaterno9','calle9',5123,'cuidad9','estado9','pais9','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre10','apellidoPaterno10','apellidoMaterno10','calle10',521235,'cuidad10','estado10','pais10','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1);

select * From Credencial;

insert into Devolucion (fechaEntrega,descripcion,cantidadDevolucion,idUsuario)
values ('2022-7-18','descricpcion1',2,5),
('2022-7-18','descricpcion2',5,5),
('2022-7-18','descricpcion3',6,5),
('2022-7-18','descricpcion4',5,2),
('2022-7-18','descricpcion5',1,1),
('2022-7-18','descricpcion6',6,4),
('2022-7-18','descricpcion7',9,8),
('2022-7-18','descricpcion8',10,10),
('2022-7-18','descricpcion9',1,2),
('2022-7-18','descricpcion10',6,7);

select *from Devolucion;

insert into EmpleadoActividad (idEmpleado,idActividad)
values (1,1),
(2,1),
(3,1),
(1,2),
(1,4),
(5,1),
(1,6),
(1,1),
(1,7),
(2,1);

select *from EmpleadoActividad;
insert into EquipoComputo (marca,numeroEquipo,fechaInicio,fechaFinal,idBiblioteca)
values ('marca1','5','2022-12-28','2022-10-14',5),
('marca2','5','2022-12-28','2022-10-14',2),
('marca3','5','2022-12-28','2022-10-14',6),
('marca4','5','2022-12-28','2022-10-14',1),
('marca5','5','2022-12-28','2022-10-14',2),
('marca6','5','2022-12-28','2022-10-14',8),
('marca7','5','2022-12-28','2022-10-14',9),
('marca8','5','2022-12-28','2022-10-14',10),
('marca9','5','2022-12-28','2022-10-14',1),
('marca10','5','2022-12-28','2022-10-14',4);
select *from EquipoComputo;
insert into Estanteria (numeroEstanteria,descripcion,idClasificacion)
values (12,'descripcion1',1),
(12,'descripcion1',1),
(14,'descripcion1',1),
(1,'descripcion1',1),
(52,'descripcion1',1),
(2,'descripcion1',1),
(89,'descripcion1',1),
(24,'descripcion1',1),
(34,'descripcion1',1),
(68,'descripcion1',1),
(97,'descripcion1',1);

select *from Estanteria;

insert into Galeria (nombre,nombreArtista,fechaInicio,fechaFinal,idBiblioteca)
values ('nombre1','nombreArtista','2022-12-24','2022-11-04',1),
('nombre2','nombreArtista2','2022-12-24','2022-11-04',1),
('nombre3','nombreArtista3','2022-12-24','2022-11-04',1),
('nombre4','nombreArtista4','2022-12-24','2022-11-04',1),
('nombre5','nombreArtista5','2022-12-24','2022-11-04',1),
('nombre6','nombreArtista6','2022-12-24','2022-11-04',1),
('nombre7','nombreArtista7','2022-12-24','2022-11-04',1),
('nombre8','nombreArtista8','2022-12-24','2022-11-04',1),
('nombre9','nombreArtista9','2022-12-24','2022-11-04',1),
('nombre10','nombreArtista10','2022-12-24','2022-11-04',1);

select *from Galeria;

insert into GrupoLectura (descripcion,idUsuario,idBiblioteca)
values ('descripcion1',1,1),
('descripcion2',1,1),
('descripcion3',2,1),
('descripcion4',3,1),
('descripcion5',4,1),
('descripcion6',5,1),
('descripcion7',6,1),
('descripcion8',7,1),
('descripcion9',8,1),
('descripcion10',10,1);

select * from GrupoLectura;

insert into Inventario (descripcion,fecha,idEmpleado)
values ('descripcion1','2019-12-30',1),
('descripcion2','2019-12-30',2),
('descripcion3','2019-12-30',3),
('descripcion4','2019-12-30',4),
('descripcion5','2019-12-30',5),
('descripcion6','2019-12-30',6),
('descripcion7','2019-12-30',7),
('descripcion8','2019-12-30',8),
('descripcion9','2019-12-30',9),
('descripcion10','2019-12-30',10);

select *from Inventario;

insert into Material (tipoMaterial,cantidadMaterial)
values ('tipoMaterial1',24),
 ('tipoMaterial2',24),
 ('tipoMaterial3',4),
 ('tipoMaterial4',12),
 ('tipoMaterial5',4),
 ('tipoMaterial6',12),
 ('tipoMaterial7',1),
 ('tipoMaterial8',42),
 ('tipoMaterial9',1),
 ('tipoMaterial10',51);

 select *from Material;

 insert into MaterialDidactico (globoTerraqueo,descripcion,juegosDidacticos,mapas,laminas,idBiblioteca)
values ('globoTerraqueo','descripcion','juegosDidacticos','mapas','laminas',6),
('globoTerraqueo1','descripcion1','juegosDidacticos1','mapas1','laminas1',6),
('globoTerraqueo2','descripcion2','juegosDidacticos2','mapas2','laminas2',6),
('globoTerraqueo3','descripcion3','juegosDidacticos3','mapas3','laminas3',6),
('globoTerraqueo4','descripcion4','juegosDidacticos4','mapas4','laminas4',6),
('globoTerraqueo5','descripcion5','juegosDidacticos5','mapas5','laminas5',6),
('globoTerraqueo6','descripcion6','juegosDidacticos6','mapas6','laminas6',6),
('globoTerraqueo7','descripcion7','juegosDidacticos7','mapas7','laminas7',6),
('globoTerraqueo8','descripcion8','juegosDidacticos8','mapas8','laminas8',6),
('globoTerraqueo9','descripcion9','juegosDidacticos9','mapas9','laminas9',6);

select *from MaterialDidactico;

insert into Mobiliario (sillas,mesas,idBoveda)
values (12,41,1),
(12,41,2),
(12,41,3),
(12,41,4),
(12,41,5),
(12,41,6),
(12,41,7),
(12,41,8),
(12,41,9),
(12,41,10);

select *from Mobiliario;

insert into Multa (descripcion,precio,idUsuario)
values ('descripcion1',124,1),
('descripcion2',124,1),
('descripcion3',643,1),
('descripcion4',51,1),
('descripcion5',35,1),
('descripcion6',135,1),
('descripcion7',61,1),
('descripcion8',413,1),
('descripcion9',71,1),
('descripcion10',151,1);

select *from Multa;

insert into Prestamo (fecha,fecheEntrega,idCredencial)
values ('2022-5-22','2022-12-14',1),
('2022-5-22','2022-12-14',2),
('2022-5-22','2022-12-14',3),
('2022-5-22','2022-12-14',4),
('2022-5-22','2022-12-14',5),
('2022-5-22','2022-12-14',6),
('2022-5-22','2022-12-14',7),
('2022-5-22','2022-12-14',8),
('2022-5-22','2022-12-14',9),
('2022-5-22','2022-12-14',10);

select *from Prestamo;

insert into Tema (tema,desrcipcion)
values ('tema1','descripcion1'),
('tema2','descripcion2'),
('tema3','descripcion3'),
('tema4','descripcion4'),
('tema5','descripcion5'),
('tema6','descripcion6'),
('tema7','descripcion7'),
('tema8','descripcion8'),
('tema9','descripcion9'),
('tema10','descripcion10');

select *from Tema;
insert into Adquisicion (compra,suscripcion,intercambio,donacion)
values (412,'suscripcion1','interacmobio1','donacion1'),
(412,'suscripcion2','interacmobio2','donacion2'),
(412,'suscripcion3','interacmobio3','donacion3'),
(412,'suscripcion4','interacmobio4','donacion4'),
(412,'suscripcion5','interacmobio5','donacion5'),
(412,'suscripcion6','interacmobio6','donacion6'),
(412,'suscripcion7','interacmobio7','donacion7'),
(412,'suscripcion8','interacmobio8','donacion8'),
(412,'suscripcion9','interacmobio9','donacion19'),
(412,'suscripcion10','interacmobio10','donacion10');

select *from Adquisicion;
insert into Libro (nombre,pais,cantidadPaginas,idTema,idPasta,idPrestamo,idAutor,idMaterial,idUsuario,idEstanteria,idBiblioteca,idAdquisicion)
values ('nombre1','pais1',41,1,1,1,1,1,1,1,1,1),
('nombre2','pais2',41,1,1,1,1,1,1,1,1,1),
('nombre3','pais3',41,1,1,1,2,1,1,1,1,1),
('nombre4','pais4',41,1,1,3,1,1,1,1,1,1),
('nombre5','pais5',41,1,1,1,1,4,1,1,1,2),
('nombre6','pais6',41,1,1,1,1,1,1,1,1,5),
('nombre7','pais7',41,1,1,1,5,1,1,1,1,1),
('nombre8','pais8',41,1,2,1,1,1,1,1,1,9),
('nombre9','pais9',41,1,1,1,1,8,1,1,1,1),
('nombre10','pais10',41,1,1,1,1,1,8,9,1,5);
select *from Libro;
insert into Coleccion (descripcion,numeroColeccion)
values ('descripcion',1),
('descripcion2',1),
('descripcion3',1),
('descripcion4',1),
('descripcion5',1),
('descripcion6',1),
('descripcion7',1),
('descripcion8',1),
('descripcion9',1),
('descripcion10',1);
select *from Coleccion;

insert into ColeccionLibro (idColeccion,idLibro)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);
select *from ColeccionLibro;


insert into Copias (numCopias,descripcion,fecha,idLibro)
values (12,'descripcion1','2022-10-23',1),
(12,'descripcion1','2022-10-23',2),
(12,'descripcion1','2022-10-23',3),
(12,'descripcion1','2022-10-23',4),
(12,'descripcion1','2022-10-23',5),
(12,'descripcion1','2022-10-23',6),
(12,'descripcion1','2022-10-23',7),
(12,'descripcion1','2022-10-23',8),
(12,'descripcion1','2022-10-23',9),
(12,'descripcion1','2022-10-23',10);



insert into DevolucionPrestamo (idDevolucion,idPrestamo)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select * from DevolucionPrestamo;



insert into FichaTecnica (año,sinopsis,idiomaOriginal,titulo,ilustradorOriginal,idLibro)
values ('2022-5-4','sinpsis','idiomaoriginal1','titulo1','ilustradorOriginal1',1),
('2022-5-4','sinpsis1','idiomaoriginal1','titulo1','ilustradorOriginal1',2),
('2022-5-4','sinpsis2','idiomaoriginal2','titulo2','ilustradorOriginal2',3),
('2022-5-4','sinpsis3','idiomaoriginal3','titulo3','ilustradorOriginal3',4),
('2022-5-4','sinpsis4','idiomaoriginal4','titulo4','ilustradorOriginal4',5),
('2022-5-4','sinpsis5','idiomaoriginal5','titulo5','ilustradorOriginal5',6),
('2022-5-4','sinpsis6','idiomaoriginal6','titulo6','ilustradorOriginal6',7),
('2022-5-4','sinpsis7','idiomaoriginal7','titulo7','ilustradorOriginal7',8),
('2022-5-4','sinpsis8','idiomaoriginal8','titulo8','ilustradorOriginal8',9),
('2022-5-4','sinpsis9','idiomaoriginal9','titulo9','ilustradorOriginal9',10);

select *from FichaTecnica;


insert into Idioma (nombreIdioma,descripcion,paisOrigen,idLibro)
values ('nombreIdioma1','descripcion1','paisorigen',1),
('nombreIdioma2','descripcion2','paisorigen2',2),
('nombreIdioma3','descripcion3','paisorigen3',3),
('nombreIdioma4','descripcion4','paisorigen4',4),
('nombreIdioma5','descripcion5','paisorigen5',5),
('nombreIdioma6','descripcion6','paisorigen6',6),
('nombreIdioma7','descripcion7','paisorigen7',7),
('nombreIdioma8','descripcion8','paisorigen8',8),
('nombreIdioma9','descripcion9','paisorigen9',9),
('nombreIdioma10','descripcion10','paisorigen10',10);


select *from Idioma;


insert into Editorial (nombre,calle,colonia,numeroExterior,cuidad,estado,pais,telefono,idLibro,idRevista)
values ('nombre1','calle1','colonia1',123,'cuidad1','estado1','pais1',412412,1,1),
('nombre2','calle2','colonia2',123,'cuidad2','estado1','pais1',412412,1,1),
('nombre3','calle3','colonia3',123,'cuidad3','estado1','pais1',412412,1,1),
('nombre','calle4','colonia4',123,'cuidad4','estado1','pais1',412412,1,1),
('nombre5','calle5','colonia5',123,'cuidad5','estado1','pais1',412412,1,1),
('nombre6','calle6','colonia6',123,'cuidad6','estado1','pais1',412412,1,1),
('nombre7','calle7','colonia7',123,'cuidad7','estado1','pais1',412412,1,1),
('nombre8','calle8','colonia8',123,'cuidad8','estado1','pais1',412412,1,1),
('nombre9','calle9','colonia9',123,'cuidad9','estado1','pais1',412412,1,1),
('nombre10','calle10','colonia10',123,'cuidad10y','estado1','pais1',412412,1,1);

select *from Editorial;

insert into EditorialLibro (idEditorial,idLibro)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select *from EditorialLibro;

insert into EditorialRevista (idEditorial,idRevista)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select *from EditorialRevista;
insert into Ejemplares (totalEjemplares,descripcion)
values (12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1');

select *from Ejemplares;


insert into EjemplaresLibro (idEjemplares,idLibro)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select *from EjemplaresLibro;

insert into Genero (genero,descripcion,idLibro)
values ('genero1','descripcion1',1),
('genero2','descripcion2',1),
('genero3','descripcion3',1),
('genero4','descripcion4',1),
('genero5','descripcion5',1),
('genero6','descripcion6',1),
('genero7','descripcion7',1),
('genero8','descripcion8',1),
('genero9','descripcion9',1),
('genero10','descripcion10',1);

select *from Genero;

insert into Proveedor (nombre,apellidoPaterno,apellidoMaterno,rfc,calle,colonia,numeroExterior,cuidad,estado,pais,telefono,idPedido)
values ('nombre1','apellidopaterno1','apellidomaterno1','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre2','apellidopaterno2','apellidomaterno2','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre3','apellidopaterno3','apellidomaterno3','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre4','apellidopaterno4','apellidomaterno4','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre5','apellidopaterno','apellidomaterno5','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre6','apellidopaterno61','apellidomaterno6','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre7','apellidopaterno7','apellidomaterno7','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre8','apellidopaterno8','apellidomaterno8','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre9','apellidopaterno9','apellidomaterno9','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre10','apellidopaterno1','apellidomaterno10','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1);


select *from Proveedor;


insert into ProveedorLibro (idLibro,idProveedor)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select *from ProveedorLibro;


insert into ProveedorRevista (idProveedor,idRevista)
values (1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,6),
(1,7),
(1,8),
(1,9),
(1,10);

select *from ProveedorRevista;


insert into RegistroVisita (fechaLlegada,fechaIda,nombre,apellidoPaterno,apellidoMaterno,idUsuario)
values ('2022-10-4','2022-8-23','nombre1','apellidopaterno','apellidomaterno1',1),
('2022-10-4','2022-8-23','nombre2','apellidopaterno2','apellidomaterno2',9),
('2022-10-4','2022-8-23','nombre3','apellidopaterno3','apellidomaterno3',7),
('2022-10-4','2022-8-23','nombre4','apellidopaterno4','apellidomaterno4',6),
('2022-10-4','2022-8-23','nombre5','apellidopaterno','apellidomaterno5',4),
('2022-10-4','2022-8-23','nombre6','apellidopaterno61','apellidomaterno6',1),
('2022-10-4','2022-8-23','nombre7','apellidopaterno7','apellidomaterno7',1),
('2022-10-4','2022-8-23','nombre8','apellidopaterno8','apellidomaterno8',1),
('2022-10-4','2022-8-23','nombre9','apellidopaterno9','apellidomaterno9',4),
('2022-10-4','2022-8-23','nombre10','apellidopaterno1','apellidomaterno1',5);


select *from RegistroVisita;


insert into Imprenta (nombre,numeroImprenta,descripcion,cantidadTotal,idEditorial)
values ('nombre1', 123,'descripcion1',4141,1),
('nombre2', 123,'descripcion2',4141,1),
('nombre3', 123,'descripcion3',4141,1),
('nombre4', 123,'descripcion4',4141,1),
('nombre5', 123,'descripcion5',4141,1),
('nombre6', 123,'descripcion6',4141,1),
('nombre7', 123,'descripcion7',4141,1),
('nombre8', 123,'descripcion8',4141,1),
('nombre9', 123,'descripcion9',4141,1),
('nombre10', 123,'descripcion10',4141,1);

select *from Imprenta ;


insert into  Periodico (nombre,nombreImprenta,fecha,descripcion,titulo,idImprenta)
values ('nombre1','nombreimprenta1','2022-5-4','descripcion1','titulo1',1),
('nombre2','nombreimprenta2','2022-5-4','descripcion2','titulo1',2),
('nombre3','nombreimprenta3','2022-5-4','descripcion3','titulo1',3),
('nombre4','nombreimprenta4','2022-5-4','descripcion4','titulo1',4),
('nombre5','nombreimprenta5','2022-5-4','descripcion5','titulo1',5),
('nombre6','nombreimprenta6','2022-5-4','descripcion6','titulo1',6),
('nombre7','nombreimprenta7','2022-5-4','descripcion7','titulo1',7),
('nombre8','nombreimprenta8','2022-5-4','descripcion8','titulo1',8),
('nombre9','nombreimprenta9','2022-5-4','descripcion9','titulo1',9),
('nombre10','nombreimprenta10','2022-5-4','descripcion10','titulo1',10);

select *from Periodico  ;


insert into Socio (nombre,apellidoPaterno,apellidoMaterno,calle,colonina,numeroExterior,cuidad,estado,pais,telefono,idPrestamo)
values ('nombre1','apellidopaterno1','apellidomaterno1','calle1','colonia1',123,'cuidad1','estado1','pais1',134,1),
('nombre2','apellidopaterno2','apellidomaterno2','calle1','colonia1',412,'cuidad1','estado1','pais1',1324,1),
('nombre3','apellidopaterno3','apellidomaterno3','calle1','colonia1',125,'cuidad1','estado1','pais1',236,1),
('nombre4','apellidopaterno4','apellidomaterno4','calle1','colonia1',5123,'cuidad1','estado1','pais1',623,1),
('nombre5','apellidopaterno','apellidomaterno5','calle1','colonia1',4123,'cuidad1','estado1','pais1',234,1),
('nombre6','apellidopaterno61','apellidomaterno6','calle1','colonia1',5123,'cuidad1','estado1','pais1',6,1),
('nombre7','apellidopaterno7','apellidomaterno7','calle1','colonia1',1234,'cuidad1','estado1','pais1',5,1),
('nombre8','apellidopaterno8','apellidomaterno8','calle1','colonia1',346,'cuidad1','estado1','pais1',514,1),
('nombre9','apellidopaterno9','apellidomaterno9','calle1','colonia1',5132,'cuidad1','estado1','pais1',2463,1),
('nombre10','apellidopaterno1','apellidomaterno10','calle1','colonia1',764,'cuidad1','estado1','pais1',4623,1);


select *from Socio;


insert into Traduccion (traduccion,descripcion,nombre,año,pais,idLibro)
values ('traduccion','descripcion','nombre','2022-7-22','pais',1),
('traduccion2','descripcion2','nombre1','2022-7-22','pais2',1),
('traduccion3','descripcion3','nombre2','2022-7-22','pais3',1),
('traduccion4','descripcion4','nombre3','2022-7-22','pais4',1),
('traduccion5','descripcion5','nombre4','2022-7-22','pais5',1),
('traduccion6','descripcion6','nombre5','2022-7-22','pais6',1),
('traduccion7','descripcion7','nombre6','2022-7-22','pais7',1),
('traduccion8','descripcion8','nombre7','2022-7-22','pais8',1),
('traduccion9','descripcion9','nombre8','2022-7-22','pais9',1),
('traduccion10','descripcion10','nombre9','2022-7-22','pais10',1),
('traduccion','descripcion','nombre10','2022-7-22','pais',1);


select *from Traduccion;


insert into Copias (numCopias,descripcion,fecha,idLibro)
values (142,'descripcion1','2022-9-28',1),
(142,'descripcion2','2022-9-28',2),
(142,'descripcion3','2022-9-28',3),
(142,'descripcion4','2022-9-28',4),
(142,'descripcion5','2022-9-28',5),
(142,'descripcion6','2022-9-28',6),
(142,'descripcion7','2022-9-28',7),
(142,'descripcion8','2022-9-28',8),
(142,'descripcion9','2022-9-28',9),
(142,'descripcion10','2022-9-28',10);

select *from Copias;


insert into Taller (nombre,fecha,descripcion,idBiblioteca)
values ('nombre','2022-4-25','descripcion1',1),
('nombre2','2022-4-25','descripcion2',1),
('nombre3','2022-4-25','descripcion3',1),
('nombre4','2022-4-25','descripcion4',1),
('nombre5','2022-4-25','descripcion5',1),
('nombre6','2022-4-25','descripcion6',1),
('nombre7','2022-4-25','descripcion7',1),
('nombre8','2022-4-25','descripcion8',1),
('nombre9','2022-4-25','descripcion9',1),
('nombre10','2022-4-25','descripcion10',1);

select *from Taller;


insert into UsuarioPrestamo (idUsuario,idPrestamo)
values (1,1),
(2,1),
(3,1),
(4,5),
(5,6),
(7,1),
(8,9),
(9,2),
(10,10);
select *from UsuarioPrestamo;


select * from Biblioteca;


INSERT INTO Autor (nombre,apellidoPaterno,apellidoMaterno,calle,colonia,numeroExterior,cuidad,estado,pais,telefono)
values ('Rodriguez','Hernandez','Guitierrez','lopez mateo','garza',4124,'Monterrey','Coahuila','Mexico',81149510),
('nombre2','apellidopaterno2','apellidomaterno2','calle2','colonia2',8894,'cuidad2','estado2','pais2',4124121),
('nombre3','apellidopaterno3','apellidomaterno3','calle3','colonia3',4124,'cuidad3','estado3','pais3',12512413),
('nombre4','apellidopaterno4','apellidomaterno4','calle4','colonia4',5123,'cuidad4','estado4','pais4',32512351),
('nombre5','apellidopaterno5','apellidomaterno5','calle5','colonia5',7257,'cuidad5','estado5','pais5',6914813),
('nombre6','apellidopaterno6','apellidomaterno6','calle6','colonia6',5132,'cuidad6','estado6','pais6',71982135),
('nombre7','apellidopaterno7','apellidomaterno7','calle7','colonia7',3151,'cuidad7','estado7','pais7',9106141),
('nombre8','apellidopaterno8','apellidomaterno8','calle8','colonia8',5324,'cuidad8','estado8','pais8',113496643),
('nombre9','apellidopaterno9','apellidomaterno9','calle9','colonia9',5123,'cuidad9','estado9','pais9',4136891),
('nombre10','apellidopaterno10','apellidomaterno10','calle10','colonia10',2351,'cuidad10','estado10','pais10',13611436);

SELECT *FROM Autor;

update Autor set nombre = 'jaime' where idAutor = 1;
INSERT INTO Autor (nombre,apellidoPaterno,apellidoMaterno,calle,colonia,numeroExterior,cuidad,estado,pais,telefono)
values ('Rodriguez','Hernandez','Guitierrez','lopez mateo','garza',4124,'saltillo','Coahuila','Mexico',81149510);

select *from Autor;


INSERT INTO Empleado (nombre,apellidoPaterno,apellidoMaterno,rfc,calle,colonia,numeroExterior,cuidad,estado,pais,telefono,idBiblioteca)
values ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',1),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',2),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',3),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',4),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',5),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',6),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',7),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',8),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',9),
 ('Empleado1','ApellidoPaterno1','ApellidoMaterno','DAGA1240412','calle1','colonia1','numero1','cuiadad1','estado1','pais1','1241241',10);
select *from Empleado;


insert into Actividad (nombreActividad,fecha,descripcion,idEmpleado)
values ('nombreActividad1','2022-12-12','descripcion1',1),
('nombreActividad2','2022-12-12','descripcion1',2),
('nombreActividad3','2022-11-12','descripcion1',3),
('nombreActividad4','2022-10-12','descripcion1',4),
('nombreActividad5','2022-9-12','descripcion1',5),
('nombreActividad6','2022-8-12','descripcion1',6),
('nombreActividad7','2022-7-12','descripcion1',7),
('nombreActividad8','2022-6-12','descripcion1',8),
('nombreActividad9','2022-5-12','descripcion1',9),
('nombreActividad10','2022-4-12','descripcion1',10);

select *from Actividad;


insert into ActividadPrograma (nombre,fecha,idEmpleado)
values ('nombre1','2022-10-5',1),
('nombre2','2022-10-5',2),
('nombre3','2022-10-5',3),
('nombre4','2022-10-5',4),
('nombre5','2022-10-5',5),
('nombre6','2022-10-5',6),
('nombre7','2022-10-5',7),
('nombre8','2022-10-5',8),
('nombre9','2022-10-5',9),
('nombre10','2022-10-5',10);

select *from ActividadPrograma;


insert into AreaMuseo (nombre,descripcion,idBiblioteca)
values ('nombre1','descripcion1',1),
('nombre2','descripcion2',2),
('nombre3','descripcion3',3),
('nombre4','descripcion4',4),
('nombre5','descripcion5',5),
('nombre6','descripcion6',6),
('nombre7','descripcion7',7),
('nombre8','descripcion8',8),
('nombre9','descripcion9',9),
('nombre10','descripcion10',10);

select *from AreaMuseo;

insert into Archivero (folletos,recortes,ilustraciones,volantes,avisos,idBiblioteca)
values ('folletos1','recores1','ilustraciones1','volantes1','avisos1',1),
('folletos2','recores1','ilustraciones2','volantes2','avisos2',2),
('folletos3','recores1','ilustraciones3','volantes3','avisos1',3),
('folletos4','recores1','ilustraciones4','volantes4','avisos1',4),
('folletos5','recores1','ilustraciones5','volantes5','avisos1',5),
('folletos6','recores1','ilustraciones6','volantes6','avisos1',6),
('folletos7','recores1','ilustraciones7','volantes7','avisos1',7),
('folletos8','recores1','ilustraciones8','volantes8','avisos1',8),
('folletos9','recores1','ilustraciones9','volantes9','avisos1',9),
('folletos10','recores1','ilustraciones10','volantes10','avisos1',10);

select *from Archivero;


insert into Boveda (nombreLibro,mobiliario,material,idBiblioteca)
values ('nombreLibro1','mobiliario1','material1',1),
('nombreLibro2','mobiliario2','material2',2),
('nombreLibro3','mobiliario3','material3',3),
('nombreLibro4','mobiliario4','material4',4),
('nombreLibro5','mobiliario5','material5',5),
('nombreLibro6','mobiliario6','material6',6),
('nombreLibro7','mobiliario7','material7',7),
('nombreLibro8','mobiliario8','material8',8),
('nombreLibro9','mobiliario9','material9',9),
('nombreLibro10','mobiliario10','material10',10);

select *from Boveda;



insert into Catalogo (autor,materias,titulo,referenciaBibliografica,idBiblioteca)
values ('autor1','materias1','titulo1','referenciaBibliografica1',1),
('autor2','materias2','titulo2','referenciaBibliografica2',2),
('autor3','materias3','titulo3','referenciaBibliografica3',3),
('autor4','materias4','titulo4','referenciaBibliografica4',4),
('autor5','materias5','titulo5','referenciaBibliografica5',5),
('autor6','materias6','titulo6','referenciaBibliografica6',6),
('autor7','materias7','titulo7','referenciaBibliografica7',7),
('autor8','materias8','titulo8','referenciaBibliografica8',8),
('autor9','materias9','titulo9','referenciaBibliografica9',9),
('autor10','materias10','titulo10','referenciaBibliografica10',10);

select *from Catalogo;



insert into Clasificacion (descripcion,idBiblioteca)
values ('descripcion1',1),
('descripcion2',2),
('descripcion3',3),
('descripcion4',4),
('descripcion5',5),
('descripcion6',6),
('descripcion7',7),
('descripcion8',8),
('descripcion9',9),
('descripcion10',10);

select *from Clasificacion;

insert into Convenio (descripcion,fechaInicio,fechaFinal,idBiblioteca)
values ('descripcion1','2022-8-28','2022-9-12',1),
('descripcion2','2022-8-25','2022-10-25',2),
('descripcion3','2022-8-22','2022-2-25',3),
('descripcion4','2022-8-28','2022-8-25',4),
('descripcion5','2022-8-12','2022-4-25',5),
('descripcion6','2022-8-4','2022-1-25',6),
('descripcion7','2022-8-5','2022-5-25',7),
('descripcion8','2022-8-12','2022-9-25',8),
('descripcion9','2022-8-5','2022-11-25',9),
('descripcion10','2022-8-1','2022-12-25',10);

select *from Convenio;

insert into Comite (nombre,numeroPersonas,idBiblioteca)
values ('nombre1',1,1),
('nombre2',1,2),
('nombre3',12,3),
('nombre4',13,4),
('nombre5',14,5),
('nombre6',15,6),
('nombre7',16,7),
('nombre8',17,1),
('nombre9',18,1),
('nombre10',19,1);

select *from Comite;

insert into DimensionLudica (representacion,debates,proyeccionPeliculasDocumentos,seccionJuegoMesa,idBiblioteca)
values ('representacion1','debates1','proyeccionPeliculasDocumentos1','seccionJuegoMesa1',1),
('representacion2','debates2','proyeccionPeliculasDocumentos2','seccionJuegoMesa2',2),
('representacion3','debates3','proyeccionPeliculasDocumentos3','seccionJuegoMesa3',3),
('representacion4','debates4','proyeccionPeliculasDocumentos4','seccionJuegoMesa4',4),
('representacion5','debates5','proyeccionPeliculasDocumentos5','seccionJuegoMesa5',5),
('representacion6','debates6','proyeccionPeliculasDocumentos6','seccionJuegoMesa6',6),
('representacion7','debates7','proyeccionPeliculasDocumentos7','seccionJuegoMesa7',7),
('representacion8','debates8','proyeccionPeliculasDocumentos8','seccionJuegoMesa8',8),
('representacion9','debates9','proyeccionPeliculasDocumentos9','seccionJuegoMesa9',9),
('representacion10','debates10','proyeccionPeliculasDocumentos10','seccionJuegoMesa10',10);

select *from DimensionLudica;

insert into Documento (videos,cds,mapas,planos,dvd,idBiblioteca)
values ('videos1','cds1','mapas1','planos1','dvd1',1),
('videos2','cds2','mapas2','planos2','dvd2',1),
('videos3','cds3','mapas3','planos3','dvd3',3),
('videos4','cds4','mapas4','planos4','dvd4',4),
('videos5','cds5','mapas5','planos5','dvd5',5),
('videos6','cds6','mapas6','planos6','dvd6',6),
('videos7','cds7','mapas7','planos7','dvd7',7),
('videos8','cds8','mapas8','planos8','dvd8',8),
('videos9','cds9','mapas9','planos9','dvd9',9),
('videos10','cds10','mapas10','planos10','dvd10',10);

select *from Documento;

insert into Pasta (color,tipoPasta)
values ('color1','tipoPasta1'),
('color2','tipoPasta2'),
('color3','tipoPasta3'),
('color4','tipoPasta4'),
('color5','tipoPasta5'),
('color6','tipoPasta6'),
('color7','tipoPasta7'),
('color8','tipoPasta8'),
('color9','tipoPasta9'),
('color10','tipoPasta10');

select *from Pasta;

insert into Piso (descripcion,numPiso,idBiblioteca)
values ('descripcion1',1,1),
('descripcion2',2,2),
('descripcion3',3,3),
('descripcion4',4,4),
('descripcion5',5,5),
('descripcion6',6,6),
('descripcion7',7,7),
('descripcion8',8,8),
('descripcion9',9,1),
('descripcion10',10,1);

select *from Piso;

insert into Revista (nombre,editorial,numeroPagina,pais)
values ('nombre1','editorial1',22,'pais1'),
('nombre2','editorial2',22,'pais2'),
('nombre3','editorial3',34,'pais3'),
('nombre4','editorial4',14,'pais4'),
('nombre5','editorial5',124,'pais5'),
('nombre6','editorial6',23,'pais6'),
('nombre7','editorial7',52,'pais7'),
('nombre8','editorial8',12,'pais8'),
('nombre9','editorial9',53,'pais9'),
('nombre10','editorial10',53,'pais10');
select *from Revista;
;
insert into Secciones (lecturaConsulta,videoteka,fonoteca,hemeroteca,coleccionLocal,autoServicioFotoCopias,idBiblioteca)
values ('lecturaConsulta1','videoteka1','fonoteca1','hemeroteca1','coleccionLocal1',2,1),
('lecturaConsulta2','videoteka2','fonoteca2','hemeroteca2','coleccionLocal2',5,1),
('lecturaConsulta3','videoteka3','fonoteca3','hemeroteca3','coleccionLocal3',5,1),
('lecturaConsulta4','videoteka4','fonoteca4','hemeroteca4','coleccionLocal4',8,1),
('lecturaConsulta5','videoteka5','fonoteca5','hemeroteca5','coleccionLocal5',1,1),
('lecturaConsulta6','videoteka6','fonoteca6','hemeroteca6','coleccionLocal6',8,1),
('lecturaConsulta7','videoteka7','fonoteca7','hemeroteca7','coleccionLocal7',3,1),
('lecturaConsulta8','videoteka8','fonoteca8','hemeroteca8','coleccionLocal8',9,1),
('lecturaConsulta9','videoteka9','fonoteca9','hemeroteca9','coleccionLocal9',2,1),
('lecturaConsulta10','videoteka10','fonoteca10','hemeroteca10','coleccionLocal10',8,1);

select *from Secciones;


insert into Usuario (nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento,calle,numeroExterior,cuidad,estado,pais,telefono)
values ('nombre1','apellidoPaterno1','apellidoMaterno1','2022-12-25','calle1',4124,'cuidad1','estado1','pais1',532525),
('nombre2','apellidoPaterno2','apellidoMaterno2','2022-12-25','calle2',4124,'cuidad2','estado2','pais2',532525),
('nombre3','apellidoPaterno3','apellidoMaterno3','2022-12-25','calle3',4124,'cuidad3','estado3','pais3',532525),
('nombre4','apellidoPaterno4','apellidoMaterno4','2022-12-25','calle4',4124,'cuidad4','estado4','pais4',532525),
('nombre5','apellidoPaterno5','apellidoMaterno5','2022-12-25','calle5',4124,'cuidad5','estado5','pais5',532525),
('nombre6','apellidoPaterno6','apellidoMaterno6','2022-12-25','calle6',4124,'cuidad6','estado6','pais6',532525),
('nombre7','apellidoPaterno7','apellidoMaterno7','2022-12-25','calle7',4124,'cuidad7','estado7','pais7',532525),
('nombre8','apellidoPaterno8','apellidoMaterno8','2022-12-25','calle8',4124,'cuidad8','estado8','pais8',532525),
('nombre9','apellidoPaterno9','apellidoMaterno9','2022-12-25','calle9',4124,'cuidad9','estado9','pais9',532525),
('nombre10','apellidoPaterno10','apellidoMaterno10','2022-12-25','calle10',4124,'cuidad10','estado10','pais10',532525);

select *from Usuario;


insert into Credencial (nombre,apellidoPaterno,apellidoMaterno,calle,numeroExterior,cuidad,estado,pais,claveElector,CURP,fechaNacimiento,vigencia,sexo,idUsuario)
values ('nombre1','apellidoPaterno1','apellidoMaterno','calle1',412412,'cuidad1','estado1','pais1','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre2','apellidoPaterno2','apellidoMaterno2','calle2',1241,'cuidad2','estado2','pais2','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre3','apellidoPaterno3','apellidoMaterno3','calle3',13241,'cuidad3','estado3','pais3','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre4','apellidoPaterno4','apellidoMaterno4','calle4',2135123,'cuidad4','estado4','pais4','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre5','apellidoPaterno5','apellidoMaterno5','calle5',3251,'cuidad5','estado5','pais5','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre6','apellidoPaterno6','apellidoMaterno6','calle6',1234,'cuidad6','estado6','pais6','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre7','apellidoPaterno7','apellidoMaterno7','calle7',51235,'cuidad7','estado7','pais7','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre8','apellidoPaterno8','apellidoMaterno8','calle8',134,'cuidad8','estado8','pais8','dmiaem1241','marc124121142','2022-10-24',2024,'Mujer',1),
('nombre9','apellidoPaterno9','apellidoMaterno9','calle9',5123,'cuidad9','estado9','pais9','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1),
('nombre10','apellidoPaterno10','apellidoMaterno10','calle10',521235,'cuidad10','estado10','pais10','dmiaem1241','marc124121142','2022-10-24',2024,'Hombre',1);

select * From Credencial;

insert into Devolucion (fechaEntrega,descripcion,cantidadDevolucion,idUsuario)
values ('2022-7-18','descricpcion1',2,5),
('2022-7-18','descricpcion2',5,5),
('2022-7-18','descricpcion3',6,5),
('2022-7-18','descricpcion4',5,2),
('2022-7-18','descricpcion5',1,1),
('2022-7-18','descricpcion6',6,4),
('2022-7-18','descricpcion7',9,8),
('2022-7-18','descricpcion8',10,10),
('2022-7-18','descricpcion9',1,2),
('2022-7-18','descricpcion10',6,7);

select *from Devolucion;

insert into EmpleadoActividad (idEmpleado,idActividad)
values (1,1),
(2,1),
(3,1),
(1,2),
(1,4),
(5,1),
(1,6),
(1,1),
(1,7),
(2,1);

select *from EmpleadoActividad;


insert into EquipoComputo (marca,numeroEquipo,fechaInicio,fechaFinal,idBiblioteca)
values ('marca1','5','2022-12-28','2022-10-14',5),
('marca2','5','2022-12-28','2022-10-14',2),
('marca3','5','2022-12-28','2022-10-14',6),
('marca4','5','2022-12-28','2022-10-14',1),
('marca5','5','2022-12-28','2022-10-14',2),
('marca6','5','2022-12-28','2022-10-14',8),
('marca7','5','2022-12-28','2022-10-14',9),
('marca8','5','2022-12-28','2022-10-14',10),
('marca9','5','2022-12-28','2022-10-14',1),
('marca10','5','2022-12-28','2022-10-14',4);

select *from EquipoComputo;

insert into Estanteria (numeroEstanteria,descripcion,idClasificacion)
values (12,'descripcion1',1),
(12,'descripcion1',1),
(14,'descripcion1',1),
(1,'descripcion1',1),
(52,'descripcion1',1),
(2,'descripcion1',1),
(89,'descripcion1',1),
(24,'descripcion1',1),
(34,'descripcion1',1),
(68,'descripcion1',1),
(97,'descripcion1',1);

select *from Estanteria;

insert into Galeria (nombre,nombreArtista,fechaInicio,fechaFinal,idBiblioteca)
values ('nombre1','nombreArtista','2022-12-24','2022-11-04',1),
('nombre2','nombreArtista2','2022-12-24','2022-11-04',1),
('nombre3','nombreArtista3','2022-12-24','2022-11-04',1),
('nombre4','nombreArtista4','2022-12-24','2022-11-04',1),
('nombre5','nombreArtista5','2022-12-24','2022-11-04',1),
('nombre6','nombreArtista6','2022-12-24','2022-11-04',1),
('nombre7','nombreArtista7','2022-12-24','2022-11-04',1),
('nombre8','nombreArtista8','2022-12-24','2022-11-04',1),
('nombre9','nombreArtista9','2022-12-24','2022-11-04',1),
('nombre10','nombreArtista10','2022-12-24','2022-11-04',1);


select *from Galeria;

insert into GrupoLectura (descripcion,idUsuario,idBiblioteca)
values ('descripcion1',1,1),
('descripcion2',1,1),
('descripcion3',2,1),
('descripcion4',3,1),
('descripcion5',4,1),
('descripcion6',5,1),
('descripcion7',6,1),
('descripcion8',7,1),
('descripcion9',8,1),
('descripcion10',10,1);

select * from GrupoLectura;

insert into Inventario (descripcion,fecha,idEmpleado)
values ('descripcion1','2019-12-30',1),
('descripcion2','2019-12-30',2),
('descripcion3','2019-12-30',3),
('descripcion4','2019-12-30',4),
('descripcion5','2019-12-30',5),
('descripcion6','2019-12-30',6),
('descripcion7','2019-12-30',7),
('descripcion8','2019-12-30',8),
('descripcion9','2019-12-30',9),
('descripcion10','2019-12-30',10);

select *from Inventario;

insert into Material (tipoMaterial,cantidadMaterial)
values ('tipoMaterial1',24),
 ('tipoMaterial2',24),
 ('tipoMaterial3',4),
 ('tipoMaterial4',12),
 ('tipoMaterial5',4),
 ('tipoMaterial6',12),
 ('tipoMaterial7',1),
 ('tipoMaterial8',42),
 ('tipoMaterial9',1),
 ('tipoMaterial10',51);

 select *from Material;

 insert into MaterialDidactico (globoTerraqueo,descripcion,juegosDidacticos,mapas,laminas,idBiblioteca)
values ('globoTerraqueo','descripcion','juegosDidacticos','mapas','laminas',6),
('globoTerraqueo1','descripcion1','juegosDidacticos1','mapas1','laminas1',6),
('globoTerraqueo2','descripcion2','juegosDidacticos2','mapas2','laminas2',6),
('globoTerraqueo3','descripcion3','juegosDidacticos3','mapas3','laminas3',6),
('globoTerraqueo4','descripcion4','juegosDidacticos4','mapas4','laminas4',6),
('globoTerraqueo5','descripcion5','juegosDidacticos5','mapas5','laminas5',6),
('globoTerraqueo6','descripcion6','juegosDidacticos6','mapas6','laminas6',6),
('globoTerraqueo7','descripcion7','juegosDidacticos7','mapas7','laminas7',6),
('globoTerraqueo8','descripcion8','juegosDidacticos8','mapas8','laminas8',6),
('globoTerraqueo9','descripcion9','juegosDidacticos9','mapas9','laminas9',6);


select *from MaterialDidactico;


insert into Mobiliario (sillas,mesas,idBoveda)
values (12,41,1),
(12,41,2),
(12,41,3),
(12,41,4),
(12,41,5),
(12,41,6),
(12,41,7),
(12,41,8),
(12,41,9),
(12,41,10);

select *from Mobiliario;

insert into Multa (descripcion,precio,idUsuario)
values ('descripcion1',124,1),
('descripcion2',124,1),
('descripcion3',643,1),
('descripcion4',51,1),
('descripcion5',35,1),
('descripcion6',135,1),
('descripcion7',61,1),
('descripcion8',413,1),
('descripcion9',71,1),
('descripcion10',151,1);

select *from Multa;

insert into Prestamo (fecha,fecheEntrega,idCredencial)
values ('2022-5-22','2022-12-14',1),
('2022-5-22','2022-12-14',2),
('2022-5-22','2022-12-14',3),
('2022-5-22','2022-12-14',4),
('2022-5-22','2022-12-14',5),
('2022-5-22','2022-12-14',6),
('2022-5-22','2022-12-14',7),
('2022-5-22','2022-12-14',8),
('2022-5-22','2022-12-14',9),
('2022-5-22','2022-12-14',10);

select *from Prestamo;

insert into Tema (tema,desrcipcion)
values ('tema1','descripcion1'),
('tema2','descripcion2'),
('tema3','descripcion3'),
('tema4','descripcion4'),
('tema5','descripcion5'),
('tema6','descripcion6'),
('tema7','descripcion7'),
('tema8','descripcion8'),
('tema9','descripcion9'),
('tema10','descripcion10');

select *from Tema;

insert into Adquisicion (compra,suscripcion,intercambio,donacion)
values (412,'suscripcion1','interacmobio1','donacion1'),
(412,'suscripcion2','interacmobio2','donacion2'),
(412,'suscripcion3','interacmobio3','donacion3'),
(412,'suscripcion4','interacmobio4','donacion4'),
(412,'suscripcion5','interacmobio5','donacion5'),
(412,'suscripcion6','interacmobio6','donacion6'),
(412,'suscripcion7','interacmobio7','donacion7'),
(412,'suscripcion8','interacmobio8','donacion8'),
(412,'suscripcion9','interacmobio9','donacion19'),
(412,'suscripcion10','interacmobio10','donacion10');

select *from Adquisicion;

insert into Libro (nombre,pais,cantidadPaginas,idTema,idPasta,idPrestamo,idAutor,idMaterial,idUsuario,idEstanteria,idBiblioteca,idAdquisicion)
values ('nombre1','pais1',41,1,1,1,1,1,1,1,1,1),
('nombre2','pais2',41,1,1,1,1,1,1,1,1,1),
('nombre3','pais3',41,1,1,1,2,1,1,1,1,1),
('nombre4','pais4',41,1,1,3,1,1,1,1,1,1),
('nombre5','pais5',41,1,1,1,1,4,1,1,1,2),
('nombre6','pais6',41,1,1,1,1,1,1,1,1,5),
('nombre7','pais7',41,1,1,1,5,1,1,1,1,1),
('nombre8','pais8',41,1,2,1,1,1,1,1,1,9),
('nombre9','pais9',41,1,1,1,1,8,1,1,1,1),
('nombre10','pais10',41,1,1,1,1,1,8,9,1,5);
select *from Libro;

drop table libro;





insert into Coleccion (descripcion,numeroColeccion)
values ('descripcion',11),
('descripcion2',12),
('descripcion3',13),
('descripcion4',14),
('descripcion5',15),
('descripcion6',16),
('descripcion7',17),
('descripcion8',18),
('descripcion9',19),
('descripcion10',20);

select *from Coleccion;


insert into ColeccionLibro (idColeccion,idLibro)
values (1,10),
(2,11),
(3,12),
(4,13),
(5,14),
(6,15),
(7,16),
(8,17),
(9,18),
(10,19);
select *from ColeccionLibro;

insert into Copias (numCopias,descripcion,fecha,idLibro)
values (12,'descripcion1','2022-10-23',11),
(12,'descripcion1','2022-10-23',12),
(12,'descripcion1','2022-10-23',13),
(12,'descripcion1','2022-10-23',14),
(12,'descripcion1','2022-10-23',15),
(12,'descripcion1','2022-10-23',16),
(12,'descripcion1','2022-10-23',17),
(12,'descripcion1','2022-10-23',18),
(12,'descripcion1','2022-10-23',19),
(12,'descripcion1','2022-10-23',20);

insert into DevolucionPrestamo (idDevolucion,idPrestamo)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select * from DevolucionPrestamo;


insert into FichaTecnica (año,sinopsis,idiomaOriginal,titulo,ilustradorOriginal,idLibro)
values ('2022-5-4','sinpsis','idiomaoriginal1','titulo1','ilustradorOriginal1',1),
('2022-5-4','sinpsis1','idiomaoriginal1','titulo1','ilustradorOriginal1',2),
('2022-5-4','sinpsis2','idiomaoriginal2','titulo2','ilustradorOriginal2',3),
('2022-5-4','sinpsis3','idiomaoriginal3','titulo3','ilustradorOriginal3',4),
('2022-5-4','sinpsis4','idiomaoriginal4','titulo4','ilustradorOriginal4',5),
('2022-5-4','sinpsis5','idiomaoriginal5','titulo5','ilustradorOriginal5',6),
('2022-5-4','sinpsis6','idiomaoriginal6','titulo6','ilustradorOriginal6',7),
('2022-5-4','sinpsis7','idiomaoriginal7','titulo7','ilustradorOriginal7',8),
('2022-5-4','sinpsis8','idiomaoriginal8','titulo8','ilustradorOriginal8',9),
('2022-5-4','sinpsis9','idiomaoriginal9','titulo9','ilustradorOriginal9',10);

select *from FichaTecnica;

insert into Idioma (nombreIdioma,descripcion,paisOrigen,idLibro)
values ('nombreIdioma1','descripcion1','paisorigen',1),
('nombreIdioma2','descripcion2','paisorigen2',2),
('nombreIdioma3','descripcion3','paisorigen3',3),
('nombreIdioma4','descripcion4','paisorigen4',4),
('nombreIdioma5','descripcion5','paisorigen5',5),
('nombreIdioma6','descripcion6','paisorigen6',6),
('nombreIdioma7','descripcion7','paisorigen7',7),
('nombreIdioma8','descripcion8','paisorigen8',8),
('nombreIdioma9','descripcion9','paisorigen9',9),
('nombreIdioma10','descripcion10','paisorigen10',10);

select *from Idioma;

insert into Editorial (nombre,calle,colonia,numeroExterior,cuidad,estado,pais,telefono,idLibro,idRevista)
values ('nombre1','calle1','colonia1',123,'cuidad1','estado1','pais1',412412,1,1),
('nombre2','calle2','colonia2',123,'cuidad2','estado1','pais1',412412,1,1),
('nombre3','calle3','colonia3',123,'cuidad3','estado1','pais1',412412,1,1),
('nombre','calle4','colonia4',123,'cuidad4','estado1','pais1',412412,1,1),
('nombre5','calle5','colonia5',123,'cuidad5','estado1','pais1',412412,1,1),
('nombre6','calle6','colonia6',123,'cuidad6','estado1','pais1',412412,1,1),
('nombre7','calle7','colonia7',123,'cuidad7','estado1','pais1',412412,1,1),
('nombre8','calle8','colonia8',123,'cuidad8','estado1','pais1',412412,1,1),
('nombre9','calle9','colonia9',123,'cuidad9','estado1','pais1',412412,1,1),
('nombre10','calle10','colonia10',123,'cuidad10y','estado1','pais1',412412,1,1);

select *from Editorial;

insert into EditorialLibro (idEditorial,idLibro)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);
select *from EditorialLibro;

insert into EditorialRevista (idEditorial,idRevista)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select *from EditorialRevista;
insert into Ejemplares (totalEjemplares,descripcion)
values (12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1'),
(12,'descripcion1');

select *from Ejemplares;


insert into EjemplaresLibro (idEjemplares,idLibro)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select *from EjemplaresLibro;

insert into Genero (genero,descripcion,idLibro)
values ('genero1','descripcion1',1),
('genero2','descripcion2',1),
('genero3','descripcion3',1),
('genero4','descripcion4',1),
('genero5','descripcion5',1),
('genero6','descripcion6',1),
('genero7','descripcion7',1),
('genero8','descripcion8',1),
('genero9','descripcion9',1),
('genero10','descripcion10',1);

select *from Genero;

insert into Proveedor (nombre,apellidoPaterno,apellidoMaterno,rfc,calle,colonia,numeroExterior,cuidad,estado,pais,telefono,idPedido)
values ('nombre1','apellidopaterno1','apellidomaterno1','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre2','apellidopaterno2','apellidomaterno2','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre3','apellidopaterno3','apellidomaterno3','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre4','apellidopaterno4','apellidomaterno4','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre5','apellidopaterno','apellidomaterno5','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre6','apellidopaterno61','apellidomaterno6','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre7','apellidopaterno7','apellidomaterno7','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre8','apellidopaterno8','apellidomaterno8','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre9','apellidopaterno9','apellidomaterno9','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1),
('nombre10','apellidopaterno1','apellidomaterno10','gasgmlsgp1412','calle1','colonia1',124124,'cuidad1','estado1','pais1',124124,1);

select *from Proveedor;


insert into ProveedorLibro (idLibro,idProveedor)
values (1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(9,1),
(10,1);

select *from ProveedorLibro;


insert into Proveedorrevista (idProveedor,idRevista)
values (1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,6),
(1,7),
(1,8),
(1,9),
(1,10);
select *from Proveedorrevista;


insert into RegistroVisita (nombre,fechaLlegada,fechaIda,apellidoPaterno,apellidoMaterno,idUsuario)
values ('nombre1','2022-05-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre1','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre2','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre3','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre4','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre5','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre6','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre7','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre8','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre9','2022-5-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1),
('nombre10','2022-05-14','2022-10-5','apelldioPaterno1','apellidoMaterno1',1);


select *from RegistroVisita;

insert into Imprenta (nombre,numeroImprenta,descripcion,cantidadTotal,idEditorial)
values ('nombre1', 123,'descripcion1',4141,1),
('nombre2', 123,'descripcion2',4141,1),
('nombre3', 123,'descripcion3',4141,1),
('nombre4', 123,'descripcion4',4141,1),
('nombre5', 123,'descripcion5',4141,1),
('nombre6', 123,'descripcion6',4141,1),
('nombre7', 123,'descripcion7',4141,1),
('nombre8', 123,'descripcion8',4141,1),
('nombre9', 123,'descripcion9',4141,1),
('nombre10', 123,'descripcion10',4141,1);

select *from Imprenta ;


insert into  Periodico (nombre,nombreImprenta,fecha,descripcion,titulo,idImprenta)
values ('nombre1','nombreimprenta1','2022-5-4','descripcion1','titulo1',1),
('nombre2','nombreimprenta2','2022-5-4','descripcion2','titulo1',2),
('nombre3','nombreimprenta3','2022-5-4','descripcion3','titulo1',3),
('nombre4','nombreimprenta4','2022-5-4','descripcion4','titulo1',4),
('nombre5','nombreimprenta5','2022-5-4','descripcion5','titulo1',5),
('nombre6','nombreimprenta6','2022-5-4','descripcion6','titulo1',6),
('nombre7','nombreimprenta7','2022-5-4','descripcion7','titulo1',7),
('nombre8','nombreimprenta8','2022-5-4','descripcion8','titulo1',8),
('nombre9','nombreimprenta9','2022-5-4','descripcion9','titulo1',9),
('nombre10','nombreimprenta10','2022-5-4','descripcion10','titulo1',10);

select *from Periodico  ;


insert into Socio (nombre,apellidoPaterno,apellidoMaterno,calle,colonina,numeroExterior,cuidad,estado,pais,telefono,idPrestamo)
values ('nombre1','apellidopaterno1','apellidomaterno1','calle1','colonia1',123,'cuidad1','estado1','pais1',134,1),
('nombre2','apellidopaterno2','apellidomaterno2','calle1','colonia1',412,'cuidad1','estado1','pais1',1324,1),
('nombre3','apellidopaterno3','apellidomaterno3','calle1','colonia1',125,'cuidad1','estado1','pais1',236,1),
('nombre4','apellidopaterno4','apellidomaterno4','calle1','colonia1',5123,'cuidad1','estado1','pais1',623,1),
('nombre5','apellidopaterno','apellidomaterno5','calle1','colonia1',4123,'cuidad1','estado1','pais1',234,1),
('nombre6','apellidopaterno61','apellidomaterno6','calle1','colonia1',5123,'cuidad1','estado1','pais1',6,1),
('nombre7','apellidopaterno7','apellidomaterno7','calle1','colonia1',1234,'cuidad1','estado1','pais1',5,1),
('nombre8','apellidopaterno8','apellidomaterno8','calle1','colonia1',346,'cuidad1','estado1','pais1',514,1),
('nombre9','apellidopaterno9','apellidomaterno9','calle1','colonia1',5132,'cuidad1','estado1','pais1',2463,1),
('nombre10','apellidopaterno1','apellidomaterno10','calle1','colonia1',764,'cuidad1','estado1','pais1',4623,1);


select *from Socio;


insert into Traduccion (traduccion,descripcion,nombre,año,pais,idLibro)
values ('traduccion','descripcion','nombre','2022-7-22','pais',1),
('traduccion2','descripcion2','nombre1','2022-7-22','pais2',1),
('traduccion3','descripcion3','nombre2','2022-7-22','pais3',1),
('traduccion4','descripcion4','nombre3','2022-7-22','pais4',1),
('traduccion5','descripcion5','nombre4','2022-7-22','pais5',1),
('traduccion6','descripcion6','nombre5','2022-7-22','pais6',1),
('traduccion7','descripcion7','nombre6','2022-7-22','pais7',1),
('traduccion8','descripcion8','nombre7','2022-7-22','pais8',1),
('traduccion9','descripcion9','nombre8','2022-7-22','pais9',1),
('traduccion10','descripcion10','nombre9','2022-7-22','pais10',1),
('traduccion','descripcion','nombre10','2022-7-22','pais',1);


select *from Traduccion;


insert into Copias (numCopias,descripcion,fecha,idLibro)
values (142,'descripcion1','2022-9-28',1),
(142,'descripcion2','2022-9-28',2),
(142,'descripcion3','2022-9-28',3),
(142,'descripcion4','2022-9-28',4),
(142,'descripcion5','2022-9-28',5),
(142,'descripcion6','2022-9-28',6),
(142,'descripcion7','2022-9-28',7),
(142,'descripcion8','2022-9-28',8),
(142,'descripcion9','2022-9-28',9),
(142,'descripcion10','2022-9-28',10);

select *from Copias;


insert into Taller (nombre,fecha,descripcion,idBiblioteca)
values ('nombre','2022-4-25','descripcion1',1),
('nombre2','2022-4-25','descripcion2',1),
('nombre3','2022-4-25','descripcion3',1),
('nombre4','2022-4-25','descripcion4',1),
('nombre5','2022-4-25','descripcion5',1),
('nombre6','2022-4-25','descripcion6',1),
('nombre7','2022-4-25','descripcion7',1),
('nombre8','2022-4-25','descripcion8',1),
('nombre9','2022-4-25','descripcion9',1),
('nombre10','2022-4-25','descripcion10',1);

select *from Taller;



insert into UsuarioPrestamo (idUsuario,idPrestamo)
values (1,1),
(2,1),
(3,1),
(4,5),
(5,6),
(7,1),
(8,9),
(9,2),
(10,10);

select *from UsuarioPrestamo;

