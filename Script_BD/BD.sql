/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     03/10/2013 11:33:17 p.m.                     */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ESPECIE') and o.name = 'FK_ESPECIE_PERTENECE_GRUPOCOM')
alter table ESPECIE
   drop constraint FK_ESPECIE_PERTENECE_GRUPOCOM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_FORMULAR_DESARROLL_PROYECTO')
alter table FORMULARIO
   drop constraint FK_FORMULAR_DESARROLL_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_FORMULAR_ES_REPONS_USUARIO')
alter table FORMULARIO
   drop constraint FK_FORMULAR_ES_REPONS_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_FORMULAR_MANEJA_ESTRATO')
alter table FORMULARIO
   drop constraint FK_FORMULAR_MANEJA_ESTRATO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('IMAGEN') and o.name = 'FK_IMAGEN_IMAGENE_ESPECIE')
alter table IMAGEN
   drop constraint FK_IMAGEN_IMAGENE_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIO') and o.name = 'FK_LINEAINV_ASOCIADO_ESTADOSA')
alter table LINEAINVENTARIO
   drop constraint FK_LINEAINV_ASOCIADO_ESTADOSA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIO') and o.name = 'FK_LINEAINV_CONTIENE_ESPECIE')
alter table LINEAINVENTARIO
   drop constraint FK_LINEAINV_CONTIENE_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIO') and o.name = 'FK_LINEAINV_LLENA_FORMULAR')
alter table LINEAINVENTARIO
   drop constraint FK_LINEAINV_LLENA_FORMULAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIO') and o.name = 'FK_LINEAINV_POSEE_CALIDAD')
alter table LINEAINVENTARIO
   drop constraint FK_LINEAINV_POSEE_CALIDAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEANOMADERABLES') and o.name = 'FK_LINEANOM_RECOLECTA_FORMULAR')
alter table LINEANOMADERABLES
   drop constraint FK_LINEANOM_RECOLECTA_FORMULAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAREGENERACION') and o.name = 'FK_LINEAREG_COMPLETA_FORMULAR')
alter table LINEAREGENERACION
   drop constraint FK_LINEAREG_COMPLETA_FORMULAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAREGENERACION') and o.name = 'FK_LINEAREG_EVALUACIO_ESPECIE')
alter table LINEAREGENERACION
   drop constraint FK_LINEAREG_EVALUACIO_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_LISTADOD_LISTADODE_ESPECIE')
alter table LISTADODEESPECIES
   drop constraint FK_LISTADOD_LISTADODE_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_LISTADOESPECIES_PROYECTO')
alter table LISTADODEESPECIES
   drop constraint FK_LISTADOESPECIES_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_LISTAESTRATOS_PROYECTO')
alter table LISTADODEESTRATOS
   drop constraint FK_LISTAESTRATOS_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_LISTADOD_LISTAESTR_ESTRATO')
alter table LISTADODEESTRATOS
   drop constraint FK_LISTADOD_LISTAESTR_ESTRATO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDIDACAPYDAP') and o.name = 'FK_MEDIDA_LINEAINV')
alter table MEDIDACAPYDAP
   drop constraint FK_MEDIDA_LINEAINV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_CREA_USUARIO')
alter table PROYECTO
   drop constraint FK_PROYECTO_CREA_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_ES_OBJETIVO')
alter table PROYECTO
   drop constraint FK_PROYECTO_ES_OBJETIVO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_REALIZA_TIPODISE')
alter table PROYECTO
   drop constraint FK_PROYECTO_REALIZA_TIPODISE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTOSPORETAPA') and o.name = 'FK_PROYECTO_CONTENEDOR')
alter table PROYECTOSPORETAPA
   drop constraint FK_PROYECTO_CONTENEDOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTOSPORETAPA') and o.name = 'FK_PROYECTO_CONTENIDOS')
alter table PROYECTOSPORETAPA
   drop constraint FK_PROYECTO_CONTENIDOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_REGISTRA_USUARIO')
alter table TRANSACCION
   drop constraint FK_TRANSACC_REGISTRA_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USO') and o.name = 'FK_USO_TIPOUSO_TIPODEUS')
alter table USO
   drop constraint FK_USO_TIPOUSO_TIPODEUS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USO') and o.name = 'FK_USO_USADOPOR_LINEANOM')
alter table USO
   drop constraint FK_USO_USADOPOR_LINEANOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CALIDAD')
            and   type = 'U')
   drop table CALIDAD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ESPECIE')
            and   name  = 'PERTENECE_FK'
            and   indid > 0
            and   indid < 255)
   drop index ESPECIE.PERTENECE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESPECIE')
            and   type = 'U')
   drop table ESPECIE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESTADOSANITARIO')
            and   type = 'U')
   drop table ESTADOSANITARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESTRATO')
            and   type = 'U')
   drop table ESTRATO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULARIO')
            and   name  = 'DESARROLLA_FK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO.DESARROLLA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULARIO')
            and   name  = 'ES_REPONSABLE_FK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO.ES_REPONSABLE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULARIO')
            and   name  = 'MANEJA_FK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO.MANEJA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FORMULARIO')
            and   type = 'U')
   drop table FORMULARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GRUPOCOMERCIAL')
            and   type = 'U')
   drop table GRUPOCOMERCIAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('IMAGEN')
            and   name  = 'IMAGENID'
            and   indid > 0
            and   indid < 255)
   drop index IMAGEN.IMAGENID
go

if exists (select 1
            from  sysobjects
           where  id = object_id('IMAGEN')
            and   type = 'U')
   drop table IMAGEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAINVENTARIO')
            and   name  = 'LLENA_FK'
            and   indid > 0
            and   indid < 255)
   drop index LINEAINVENTARIO.LLENA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAINVENTARIO')
            and   name  = 'ASOCIADO_FK'
            and   indid > 0
            and   indid < 255)
   drop index LINEAINVENTARIO.ASOCIADO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAINVENTARIO')
            and   name  = 'POSEE_FK'
            and   indid > 0
            and   indid < 255)
   drop index LINEAINVENTARIO.POSEE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAINVENTARIO')
            and   name  = 'CONTIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index LINEAINVENTARIO.CONTIENE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LINEAINVENTARIO')
            and   type = 'U')
   drop table LINEAINVENTARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEANOMADERABLES')
            and   name  = 'RECOLECTA_FK'
            and   indid > 0
            and   indid < 255)
   drop index LINEANOMADERABLES.RECOLECTA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LINEANOMADERABLES')
            and   type = 'U')
   drop table LINEANOMADERABLES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAREGENERACION')
            and   name  = 'COMPLETA_FK'
            and   indid > 0
            and   indid < 255)
   drop index LINEAREGENERACION.COMPLETA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAREGENERACION')
            and   name  = 'EVALUACION_FK'
            and   indid > 0
            and   indid < 255)
   drop index LINEAREGENERACION.EVALUACION_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LINEAREGENERACION')
            and   type = 'U')
   drop table LINEAREGENERACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LISTADODEESPECIES')
            and   type = 'U')
   drop table LISTADODEESPECIES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LISTADODEESTRATOS')
            and   type = 'U')
   drop table LISTADODEESTRATOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MEDIDACAPYDAP')
            and   name  = 'MEDIDAID'
            and   indid > 0
            and   indid < 255)
   drop index MEDIDACAPYDAP.MEDIDAID
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEDIDACAPYDAP')
            and   type = 'U')
   drop table MEDIDACAPYDAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OBJETIVOINVENTARIO')
            and   type = 'U')
   drop table OBJETIVOINVENTARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROYECTO')
            and   name  = 'REALIZA_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROYECTO.REALIZA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROYECTO')
            and   name  = 'CREA_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROYECTO.CREA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROYECTO')
            and   name  = 'ES_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROYECTO.ES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROYECTO')
            and   type = 'U')
   drop table PROYECTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROYECTOSPORETAPA')
            and   type = 'U')
   drop table PROYECTOSPORETAPA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPODEUSO')
            and   type = 'U')
   drop table TIPODEUSO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPODISENOMUESTRAL')
            and   type = 'U')
   drop table TIPODISENOMUESTRAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSACCION')
            and   name  = 'REGISTRA_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSACCION.REGISTRA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRANSACCION')
            and   type = 'U')
   drop table TRANSACCION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TSTUDENT')
            and   type = 'U')
   drop table TSTUDENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USO')
            and   type = 'U')
   drop table USO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

if exists(select 1 from systypes where name='TIPOARBOL')
   execute sp_unbindrule TIPOARBOL
go

if exists(select 1 from systypes where name='TIPOARBOL')
   drop type TIPOARBOL
go

if exists(select 1 from systypes where name='TIPOOPERACION')
   execute sp_unbindrule TIPOOPERACION
go

if exists(select 1 from systypes where name='TIPOOPERACION')
   drop type TIPOOPERACION
go

if exists(select 1 from systypes where name='TIPOPROYECTO')
   execute sp_unbindrule TIPOPROYECTO
go

if exists(select 1 from systypes where name='TIPOPROYECTO')
   drop type TIPOPROYECTO
go

if exists(select 1 from systypes where name='TIPOUSUARIO')
   execute sp_unbindrule TIPOUSUARIO
go

if exists(select 1 from systypes where name='TIPOUSUARIO')
   drop type TIPOUSUARIO
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOARBOL') and type='R')
   drop rule  R_TIPOARBOL
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOOPERACION') and type='R')
   drop rule  R_TIPOOPERACION
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOPROYECTO') and type='R')
   drop rule  R_TIPOPROYECTO
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOUSUARIO') and type='R')
   drop rule  R_TIPOUSUARIO
go

create rule R_TIPOARBOL as
      @column in ('BF','NF')
go

create rule R_TIPOOPERACION as
      @column in ('I','A','E')
go

create rule R_TIPOPROYECTO as
      @column in ('CR','CO','IN')
go

create rule R_TIPOUSUARIO as
      @column in ('AD','NA')
go

/*==============================================================*/
/* Domain: TIPOARBOL                                            */
/*==============================================================*/
create type TIPOARBOL
   from char(2) not null
go

execute sp_bindrule R_TIPOARBOL, TIPOARBOL
go

/*==============================================================*/
/* Domain: TIPOOPERACION                                        */
/*==============================================================*/
create type TIPOOPERACION
   from char(1) not null
go

execute sp_bindrule R_TIPOOPERACION, TIPOOPERACION
go

/*==============================================================*/
/* Domain: TIPOPROYECTO                                         */
/*==============================================================*/
create type TIPOPROYECTO
   from varchar(2) not null
go

execute sp_bindrule R_TIPOPROYECTO, TIPOPROYECTO
go

/*==============================================================*/
/* Domain: TIPOUSUARIO                                          */
/*==============================================================*/
create type TIPOUSUARIO
   from char(2) not null
go

execute sp_bindrule R_TIPOUSUARIO, TIPOUSUARIO
go

/*==============================================================*/
/* Table: CALIDAD                                               */
/*==============================================================*/
create table CALIDAD (
   CODCALIDAD           numeric              identity,
   DESCRIPCALIDAD       varchar(500)         null,
   constraint PK_CALIDAD primary key nonclustered (CODCALIDAD)
)
go

/*==============================================================*/
/* Table: ESPECIE                                               */
/*==============================================================*/
create table ESPECIE (
   CODESP               uniqueidentifier     not null,
   GRUPOCOM             char(2)              not null,
   NOMCOMUN             varchar(200)         null,
   NOMCIENTIFICO        varchar(200)         null,
   FAMILIA              varchar(200)         null,
   ZONAGEOGRAFICA       varchar(200)         null,
   ZONADEVIDA           varchar(200)         null,
   DIAMMINCORTE         numeric              null,
   constraint PK_ESPECIE primary key nonclustered (CODESP)
)
go

/*==============================================================*/
/* Index: PERTENECE_FK                                          */
/*==============================================================*/
create index PERTENECE_FK on ESPECIE (
GRUPOCOM ASC
)
go

/*==============================================================*/
/* Table: ESTADOSANITARIO                                       */
/*==============================================================*/
create table ESTADOSANITARIO (
   ESTADO               char(2)              not null,
   DESCRIPESTADO        varchar(500)         null,
   constraint PK_ESTADOSANITARIO primary key nonclustered (ESTADO)
)
go

/*==============================================================*/
/* Table: ESTRATO                                               */
/*==============================================================*/
create table ESTRATO (
   CODEST               numeric              identity,
   DESCRIPESTRATO       varchar(500)         null,
   constraint PK_ESTRATO primary key nonclustered (CODEST)
)
go

/*==============================================================*/
/* Table: FORMULARIO                                            */
/*==============================================================*/
create table FORMULARIO (
   NROFORMULARIO        uniqueidentifier     not null,
   CODEST               numeric              not null,
   NROUSUARIO           uniqueidentifier     not null,
   NROPROY              uniqueidentifier     not null,
   FECHACREACION        datetime             not null,
   HORAINICIO           datetime             null,
   HORAFINAL            datetime             null,
   PARCELA              numeric              not null,
   LINEA                numeric              not null,
   COORDENADAX          numeric              null,
   COORDENADAY          numeric              null,
   constraint PK_FORMULARIO primary key nonclustered (NROFORMULARIO)
)
go

/*==============================================================*/
/* Index: MANEJA_FK                                             */
/*==============================================================*/
create index MANEJA_FK on FORMULARIO (
CODEST ASC
)
go

/*==============================================================*/
/* Index: ES_REPONSABLE_FK                                      */
/*==============================================================*/
create index ES_REPONSABLE_FK on FORMULARIO (
NROUSUARIO ASC
)
go

/*==============================================================*/
/* Index: DESARROLLA_FK                                         */
/*==============================================================*/
create index DESARROLLA_FK on FORMULARIO (
NROPROY ASC
)
go

/*==============================================================*/
/* Table: GRUPOCOMERCIAL                                        */
/*==============================================================*/
create table GRUPOCOMERCIAL (
   GRUPOCOM             char(2)              not null,
   DESCRIPGRUPO         varchar(500)         null,
   constraint PK_GRUPOCOMERCIAL primary key nonclustered (GRUPOCOM)
)
go

/*==============================================================*/
/* Table: IMAGEN                                                */
/*==============================================================*/
create table IMAGEN (
   IMAGENID             numeric              identity,
   CODESP               uniqueidentifier     not null,
   DESCRIPCION          varchar(1000)        null,
   NOMBRE               varchar(250)         not null,
   RUTA                 varchar(1000)        not null,
   constraint PK_IMAGEN primary key (IMAGENID, CODESP)
)
go

/*==============================================================*/
/* Index: IMAGENID                                              */
/*==============================================================*/
create index IMAGENID on IMAGEN (
IMAGENID ASC
)
go

/*==============================================================*/
/* Table: LINEAINVENTARIO                                       */
/*==============================================================*/
create table LINEAINVENTARIO (
   LINEAINV             uniqueidentifier     not null,
   CODCALIDAD           numeric              not null,
   NROFORMULARIO        uniqueidentifier     not null,
   ESTADO               char(2)              not null,
   CODESP               uniqueidentifier     not null,
   NROARB               numeric              null,
   ALTCOMER_M           numeric              null,
   ALTTOT_M             numeric              null,
   AREABASAL            decimal(18,3)        null,
   VOLCOM               decimal(18,3)        null,
   VOLTOT               decimal(18,3)        null,
   TIPOARBOL            TIPOARBOL            not null,
   constraint PK_LINEAINVENTARIO primary key nonclustered (LINEAINV)
)
go

/*==============================================================*/
/* Index: CONTIENE_FK                                           */
/*==============================================================*/
create index CONTIENE_FK on LINEAINVENTARIO (
CODESP ASC
)
go

/*==============================================================*/
/* Index: POSEE_FK                                              */
/*==============================================================*/
create index POSEE_FK on LINEAINVENTARIO (
CODCALIDAD ASC
)
go

/*==============================================================*/
/* Index: ASOCIADO_FK                                           */
/*==============================================================*/
create index ASOCIADO_FK on LINEAINVENTARIO (
ESTADO ASC
)
go

/*==============================================================*/
/* Index: LLENA_FK                                              */
/*==============================================================*/
create index LLENA_FK on LINEAINVENTARIO (
NROFORMULARIO ASC
)
go

/*==============================================================*/
/* Table: LINEANOMADERABLES                                     */
/*==============================================================*/
create table LINEANOMADERABLES (
   LINEANMAD            uniqueidentifier     not null,
   NROFORMULARIO        uniqueidentifier     not null,
   OBSERVACIONES        varchar(500)         null,
   constraint PK_LINEANOMADERABLES primary key nonclustered (LINEANMAD)
)
go

/*==============================================================*/
/* Index: RECOLECTA_FK                                          */
/*==============================================================*/
create index RECOLECTA_FK on LINEANOMADERABLES (
NROFORMULARIO ASC
)
go

/*==============================================================*/
/* Table: LINEAREGENERACION                                     */
/*==============================================================*/
create table LINEAREGENERACION (
   LATIZAL              numeric              not null,
   BRINZAL              numeric              not null,
   LINEAREGEN           uniqueidentifier     not null,
   NROFORMULARIO        uniqueidentifier     not null,
   CODESP               uniqueidentifier     not null,
   constraint PK_LINEAREGENERACION primary key nonclustered (LINEAREGEN)
)
go

/*==============================================================*/
/* Index: EVALUACION_FK                                         */
/*==============================================================*/
create index EVALUACION_FK on LINEAREGENERACION (
CODESP ASC
)
go

/*==============================================================*/
/* Index: COMPLETA_FK                                           */
/*==============================================================*/
create index COMPLETA_FK on LINEAREGENERACION (
NROFORMULARIO ASC
)
go

/*==============================================================*/
/* Table: LISTADODEESPECIES                                     */
/*==============================================================*/
create table LISTADODEESPECIES (
   CODESP               uniqueidentifier     not null,
   NROPROY              uniqueidentifier     not null,
   constraint PK_LISTADODEESPECIES primary key (CODESP, NROPROY)
)
go

/*==============================================================*/
/* Table: LISTADODEESTRATOS                                     */
/*==============================================================*/
create table LISTADODEESTRATOS (
   NROPROY              uniqueidentifier     not null,
   CODEST               numeric              not null,
   PESO                 decimal(18,3)        null,
   constraint PK_LISTADODEESTRATOS primary key (NROPROY, CODEST)
)
go

/*==============================================================*/
/* Table: MEDIDACAPYDAP                                         */
/*==============================================================*/
create table MEDIDACAPYDAP (
   CAP                  numeric              not null,
   DAP                  numeric              not null,
   MEDIDAID             numeric              identity,
   LINEAINV             uniqueidentifier     not null,
   constraint PK_MEDIDACAPYDAP primary key (MEDIDAID, LINEAINV)
)
go

/*==============================================================*/
/* Index: MEDIDAID                                              */
/*==============================================================*/
create index MEDIDAID on MEDIDACAPYDAP (
MEDIDAID ASC
)
go

/*==============================================================*/
/* Table: OBJETIVOINVENTARIO                                    */
/*==============================================================*/
create table OBJETIVOINVENTARIO (
   NOMBRETIPOINV        varchar(100)         not null,
   DESCRIPOBJETINV      varchar(500)         null,
   constraint PK_OBJETIVOINVENTARIO primary key nonclustered (NOMBRETIPOINV)
)
go

/*==============================================================*/
/* Table: PROYECTO                                              */
/*==============================================================*/
create table PROYECTO (
   NROPROY              uniqueidentifier     not null,
   NROUSUARIO           uniqueidentifier     not null,
   NOMBRETIPOINV        varchar(100)         not null,
   NOMTIPODISEMUEST     varchar(100)         not null,
   LUGAR                varchar(100)         not null,
   DESCRIPCION          varchar(500)         null,
   SUPTOT               decimal(18,3)        not null,
   INTMUE               decimal(18,3)        not null,
   SUPMUE               decimal(18,3)        not null,
   TAMANO               decimal(18,3)        not null,
   LIMITINFDAP          decimal(18,3)        not null,
   LIMITSUPDAP          decimal(18,3)        not null,
   AREAFUSTALESPORPARCELA decimal(18,3)        not null,
   FACTORDEFORMA        decimal(18,3)        not null,
   FECHA                datetime             not null,
   NUMEROETAPAS         numeric              null,
   TIPOPROYECTO         TIPOPROYECTO         not null,
   constraint PK_PROYECTO primary key nonclustered (NROPROY)
)
go

/*==============================================================*/
/* Index: ES_FK                                                 */
/*==============================================================*/
create index ES_FK on PROYECTO (
NOMBRETIPOINV ASC
)
go

/*==============================================================*/
/* Index: CREA_FK                                               */
/*==============================================================*/
create index CREA_FK on PROYECTO (
NROUSUARIO ASC
)
go

/*==============================================================*/
/* Index: REALIZA_FK                                            */
/*==============================================================*/
create index REALIZA_FK on PROYECTO (
NOMTIPODISEMUEST ASC
)
go

/*==============================================================*/
/* Table: PROYECTOSPORETAPA                                     */
/*==============================================================*/
create table PROYECTOSPORETAPA (
   NROPROYCONTENEDOR    uniqueidentifier     not null,
   NROPROYCONTENIDO     uniqueidentifier     not null,
   PESO                 decimal(18,3)        null,
   constraint PK_PROYECTOSPORETAPA primary key (NROPROYCONTENEDOR, NROPROYCONTENIDO)
)
go

/*==============================================================*/
/* Table: TIPODEUSO                                             */
/*==============================================================*/
create table TIPODEUSO (
   NOMBRETIPOUSO        varchar(100)         not null,
   DESCRIPCION          varchar(500)         null,
   constraint PK_TIPODEUSO primary key nonclustered (NOMBRETIPOUSO)
)
go

/*==============================================================*/
/* Table: TIPODISENOMUESTRAL                                    */
/*==============================================================*/
create table TIPODISENOMUESTRAL (
   NOMTIPODISEMUEST     varchar(100)         not null,
   DESCRIPTIPODISEMUEST varchar(500)         null,
   constraint PK_TIPODISENOMUESTRAL primary key nonclustered (NOMTIPODISEMUEST)
)
go

/*==============================================================*/
/* Table: TRANSACCION                                           */
/*==============================================================*/
create table TRANSACCION (
   NROTRANS             numeric              identity,
   NROUSUARIO           uniqueidentifier     not null,
   FECHA                datetime             not null,
   TABLA                varchar(100)         not null,
   IDREGISTRO           numeric              not null,
   OPERACION            TIPOOPERACION        not null,
   VALORESVIEJOS        varchar(1024)        null,
   VALORESNUEVOS        varchar(1024)        null,
   constraint PK_TRANSACCION primary key nonclustered (NROTRANS)
)
go

/*==============================================================*/
/* Index: REGISTRA_FK                                           */
/*==============================================================*/
create index REGISTRA_FK on TRANSACCION (
NROUSUARIO ASC
)
go

/*==============================================================*/
/* Table: TSTUDENT                                              */
/*==============================================================*/
create table TSTUDENT (
   N                    numeric              not null,
   ALPHA                decimal(18,3)        not null,
   VALOR                decimal(18,3)        not null,
   constraint PK_TSTUDENT primary key nonclustered (N, ALPHA, VALOR)
)
go

/*==============================================================*/
/* Table: USO                                                   */
/*==============================================================*/
create table USO (
   LINEANMAD            uniqueidentifier     not null,
   NOMBRETIPOUSO        varchar(100)         not null,
   constraint PK_USO primary key (LINEANMAD, NOMBRETIPOUSO)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   NROUSUARIO           uniqueidentifier     not null,
   NOMBRES              varchar(100)         not null,
   APELLIDOS            varchar(100)         not null,
   NOMBREUSUARIO        varchar(100)         not null,
   CONTRASENA           varchar(1000)        not null,
   CEDULA               numeric              not null,
   TIPOUSUARIO          TIPOUSUARIO          not null,
   constraint PK_USUARIO primary key nonclustered (NROUSUARIO)
)
go

alter table ESPECIE
   add constraint FK_ESPECIE_PERTENECE_GRUPOCOM foreign key (GRUPOCOM)
      references GRUPOCOMERCIAL (GRUPOCOM)
         on update cascade on delete cascade
go

alter table FORMULARIO
   add constraint FK_FORMULAR_DESARROLL_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table FORMULARIO
   add constraint FK_FORMULAR_ES_REPONS_USUARIO foreign key (NROUSUARIO)
      references USUARIO (NROUSUARIO)
         on update cascade on delete cascade
go

alter table FORMULARIO
   add constraint FK_FORMULAR_MANEJA_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
         on update cascade on delete cascade
go

alter table IMAGEN
   add constraint FK_IMAGEN_IMAGENE_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LINEAINVENTARIO
   add constraint FK_LINEAINV_ASOCIADO_ESTADOSA foreign key (ESTADO)
      references ESTADOSANITARIO (ESTADO)
         on update cascade on delete cascade
go

alter table LINEAINVENTARIO
   add constraint FK_LINEAINV_CONTIENE_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LINEAINVENTARIO
   add constraint FK_LINEAINV_LLENA_FORMULAR foreign key (NROFORMULARIO)
      references FORMULARIO (NROFORMULARIO)
         on update cascade on delete cascade
go

alter table LINEAINVENTARIO
   add constraint FK_LINEAINV_POSEE_CALIDAD foreign key (CODCALIDAD)
      references CALIDAD (CODCALIDAD)
         on update cascade on delete cascade
go

alter table LINEANOMADERABLES
   add constraint FK_LINEANOM_RECOLECTA_FORMULAR foreign key (NROFORMULARIO)
      references FORMULARIO (NROFORMULARIO)
         on update cascade on delete cascade
go

alter table LINEAREGENERACION
   add constraint FK_LINEAREG_COMPLETA_FORMULAR foreign key (NROFORMULARIO)
      references FORMULARIO (NROFORMULARIO)
         on update cascade on delete cascade
go

alter table LINEAREGENERACION
   add constraint FK_LINEAREG_EVALUACIO_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LISTADODEESPECIES
   add constraint FK_LISTADOD_LISTADODE_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LISTADODEESPECIES
   add constraint FK_LISTADOESPECIES_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table LISTADODEESTRATOS
   add constraint FK_LISTAESTRATOS_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table LISTADODEESTRATOS
   add constraint FK_LISTADOD_LISTAESTR_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
         on update cascade on delete cascade
go

alter table MEDIDACAPYDAP
   add constraint FK_MEDIDA_LINEAINV foreign key (LINEAINV)
      references LINEAINVENTARIO (LINEAINV)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_CREA_USUARIO foreign key (NROUSUARIO)
      references USUARIO (NROUSUARIO)
go

alter table PROYECTO
   add constraint FK_PROYECTO_ES_OBJETIVO foreign key (NOMBRETIPOINV)
      references OBJETIVOINVENTARIO (NOMBRETIPOINV)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_REALIZA_TIPODISE foreign key (NOMTIPODISEMUEST)
      references TIPODISENOMUESTRAL (NOMTIPODISEMUEST)
         on update cascade on delete cascade
go

alter table PROYECTOSPORETAPA
   add constraint FK_PROYECTO_CONTENEDOR foreign key (NROPROYCONTENEDOR)
      references PROYECTO (NROPROY)
go

alter table PROYECTOSPORETAPA
   add constraint FK_PROYECTO_CONTENIDOS foreign key (NROPROYCONTENIDO)
      references PROYECTO (NROPROY)
go

alter table TRANSACCION
   add constraint FK_TRANSACC_REGISTRA_USUARIO foreign key (NROUSUARIO)
      references USUARIO (NROUSUARIO)
         on update cascade on delete cascade
go

alter table USO
   add constraint FK_USO_TIPOUSO_TIPODEUS foreign key (NOMBRETIPOUSO)
      references TIPODEUSO (NOMBRETIPOUSO)
         on update cascade on delete cascade
go

alter table USO
   add constraint FK_USO_USADOPOR_LINEANOM foreign key (LINEANMAD)
      references LINEANOMADERABLES (LINEANMAD)
         on update cascade on delete cascade
go

