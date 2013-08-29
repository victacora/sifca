/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     29/08/2013 09:44:03 a.m.                     */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ESPECIE') and o.name = 'FK_ESPECIE_PERTENECE_GRUPOCOM')
alter table ESPECIE
   drop constraint FK_ESPECIE_PERTENECE_GRUPOCOM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INVENTARIO') and o.name = 'FK_INVENTAR_ASOCIADO_ESTADOSA')
alter table INVENTARIO
   drop constraint FK_INVENTAR_ASOCIADO_ESTADOSA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INVENTARIO') and o.name = 'FK_INVENTAR_CONTIENE_ESPECIE')
alter table INVENTARIO
   drop constraint FK_INVENTAR_CONTIENE_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INVENTARIO') and o.name = 'FK_INVENTAR_DESARROLL_PROYECTO')
alter table INVENTARIO
   drop constraint FK_INVENTAR_DESARROLL_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INVENTARIO') and o.name = 'FK_INVENTAR_MANEJA_ESTRATO')
alter table INVENTARIO
   drop constraint FK_INVENTAR_MANEJA_ESTRATO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INVENTARIO') and o.name = 'FK_INVENTAR_POSEE_CALIDAD')
alter table INVENTARIO
   drop constraint FK_INVENTAR_POSEE_CALIDAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INVENTARIO') and o.name = 'FK_INVENTAR_RECOGE_ESTACION')
alter table INVENTARIO
   drop constraint FK_INVENTAR_RECOGE_ESTACION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_LISTADOD_LISTADODE_ESPECIE')
alter table LISTADODEESPECIES
   drop constraint FK_LISTADOD_LISTADODE_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_LISTADOD_LISTESPEC_PROYECTO')
alter table LISTADODEESPECIES
   drop constraint FK_LISTADOD_LISTESPEC_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_LISTADOD_LISTADODE_ESTRATO')
alter table LISTADODEESTRATOS
   drop constraint FK_LISTADOD_LISTADODE_ESTRATO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_LISTADOD_LISTESTRA_PROYECTO')
alter table LISTADODEESTRATOS
   drop constraint FK_LISTADOD_LISTESTRA_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_CREA_ESTACION')
alter table PROYECTO
   drop constraint FK_PROYECTO_CREA_ESTACION
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
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_SE_HACE_ETAPA')
alter table PROYECTO
   drop constraint FK_PROYECTO_SE_HACE_ETAPA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTOSPORETAPA') and o.name = 'FK_PROYECTO_PROYECTOR_PROYECTO')
alter table PROYECTOSPORETAPA
   drop constraint FK_PROYECTO_PROYECTOR_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTOSPORETAPA') and o.name = 'FK_PROYECTO_PROYECTOS_PROYECTO')
alter table PROYECTOSPORETAPA
   drop constraint FK_PROYECTO_PROYECTOS_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_CAPTURA_ESTACION')
alter table REGENERACION
   drop constraint FK_REGENERA_CAPTURA_ESTACION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_EVALUACIO_ESPECIE')
alter table REGENERACION
   drop constraint FK_REGENERA_EVALUACIO_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_EXAMINA_PROYECTO')
alter table REGENERACION
   drop constraint FK_REGENERA_EXAMINA_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_SUBDIVIDE_ESTRATO')
alter table REGENERACION
   drop constraint FK_REGENERA_SUBDIVIDE_ESTRATO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_REGISTRA_ESTACION')
alter table TRANSACCION
   drop constraint FK_TRANSACC_REGISTRA_ESTACION
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
           where  id = object_id('ESTACION')
            and   type = 'U')
   drop table ESTACION
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
            from  sysobjects
           where  id = object_id('ETAPA')
            and   type = 'U')
   drop table ETAPA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GRUPOCOMERCIAL')
            and   type = 'U')
   drop table GRUPOCOMERCIAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INVENTARIO')
            and   name  = 'RECOGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index INVENTARIO.RECOGE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INVENTARIO')
            and   name  = 'MANEJA_FK'
            and   indid > 0
            and   indid < 255)
   drop index INVENTARIO.MANEJA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INVENTARIO')
            and   name  = 'ASOCIADO_FK'
            and   indid > 0
            and   indid < 255)
   drop index INVENTARIO.ASOCIADO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INVENTARIO')
            and   name  = 'POSEE_FK'
            and   indid > 0
            and   indid < 255)
   drop index INVENTARIO.POSEE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INVENTARIO')
            and   name  = 'CONTIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index INVENTARIO.CONTIENE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INVENTARIO')
            and   name  = 'DESARROLLA_FK'
            and   indid > 0
            and   indid < 255)
   drop index INVENTARIO.DESARROLLA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INVENTARIO')
            and   type = 'U')
   drop table INVENTARIO
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
            from  sysobjects
           where  id = object_id('OBJETIVOINVENTARIO')
            and   type = 'U')
   drop table OBJETIVOINVENTARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROYECTO')
            and   name  = 'SE_HACE_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROYECTO.SE_HACE_FK
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
            from  sysindexes
           where  id    = object_id('REGENERACION')
            and   name  = 'EXAMINA_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGENERACION.EXAMINA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGENERACION')
            and   name  = 'CAPTURA_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGENERACION.CAPTURA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGENERACION')
            and   name  = 'SUBDIVIDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGENERACION.SUBDIVIDE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGENERACION')
            and   name  = 'EVALUACION_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGENERACION.EVALUACION_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REGENERACION')
            and   type = 'U')
   drop table REGENERACION
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

if exists(select 1 from systypes where name='TIPOESTACION')
   execute sp_unbindrule TIPOESTACION
go

if exists(select 1 from systypes where name='TIPOESTACION')
   drop type TIPOESTACION
go

if exists(select 1 from systypes where name='TIPOOPERACION')
   execute sp_unbindrule TIPOOPERACION
go

if exists(select 1 from systypes where name='TIPOOPERACION')
   drop type TIPOOPERACION
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOESTACION') and type='R')
   drop rule  R_TIPOESTACION
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOOPERACION') and type='R')
   drop rule  R_TIPOOPERACION
go

create rule R_TIPOESTACION as
      @column in ('L','R')
go

create rule R_TIPOOPERACION as
      @column in ('I','A','E')
go

/*==============================================================*/
/* Domain: TIPOESTACION                                         */
/*==============================================================*/
create type TIPOESTACION
   from char(1) not null
go

execute sp_bindrule R_TIPOESTACION, TIPOESTACION
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
/* Table: CALIDAD                                               */
/*==============================================================*/
create table CALIDAD (
   CODCALIDAD           numeric              not null,
   DESCRIPCALIDAD       varchar(500)         null,
   constraint PK_CALIDAD primary key nonclustered (CODCALIDAD)
)
go

/*==============================================================*/
/* Table: ESPECIE                                               */
/*==============================================================*/
create table ESPECIE (
   CODESP               numeric              not null,
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
/* Table: ESTACION                                              */
/*==============================================================*/
create table ESTACION (
   NROEST               uniqueidentifier     not null,
   PERSONARESPONSABLE   varchar(100)         not null,
   NOMBRE               varchar(100)         not null,
   TIPOESTACION         TIPOESTACION         not null,
   constraint PK_ESTACION primary key nonclustered (NROEST)
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
   CODEST               numeric              not null,
   DESCRIPESTRATO       varchar(500)         null,
   constraint PK_ESTRATO primary key nonclustered (CODEST)
)
go

/*==============================================================*/
/* Table: ETAPA                                                 */
/*==============================================================*/
create table ETAPA (
   CODETAPA             numeric              not null,
   DESCRIPETAPA         varchar(500)         null,
   constraint PK_ETAPA primary key nonclustered (CODETAPA)
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
/* Table: INVENTARIO                                            */
/*==============================================================*/
create table INVENTARIO (
   NROPROY              numeric              not null,
   PARCELA              numeric              not null,
   NROARB               numeric              not null,
   LINEA                numeric              not null,
   CODCALIDAD           numeric              not null,
   ESTADO               char(2)              not null,
   CODEST               numeric              not null,
   CODESP               numeric              not null,
   NROEST               uniqueidentifier     not null,
   CAP                  numeric              null,
   DAP                  numeric              null,
   ALTCOMER_M           numeric              null,
   ALTTOT_M             numeric              null,
   AREABASAL            decimal(18,3)        null,
   VOLCOM               decimal(18,3)        null,
   VOLTOT               decimal(18,3)        null,
   constraint PK_INVENTARIO primary key (PARCELA, NROPROY, NROARB, LINEA)
)
go

/*==============================================================*/
/* Index: DESARROLLA_FK                                         */
/*==============================================================*/
create index DESARROLLA_FK on INVENTARIO (
NROPROY ASC
)
go

/*==============================================================*/
/* Index: CONTIENE_FK                                           */
/*==============================================================*/
create index CONTIENE_FK on INVENTARIO (
CODESP ASC
)
go

/*==============================================================*/
/* Index: POSEE_FK                                              */
/*==============================================================*/
create index POSEE_FK on INVENTARIO (
CODCALIDAD ASC
)
go

/*==============================================================*/
/* Index: ASOCIADO_FK                                           */
/*==============================================================*/
create index ASOCIADO_FK on INVENTARIO (
ESTADO ASC
)
go

/*==============================================================*/
/* Index: MANEJA_FK                                             */
/*==============================================================*/
create index MANEJA_FK on INVENTARIO (
CODEST ASC
)
go

/*==============================================================*/
/* Index: RECOGE_FK                                             */
/*==============================================================*/
create index RECOGE_FK on INVENTARIO (
NROEST ASC
)
go

/*==============================================================*/
/* Table: LISTADODEESPECIES                                     */
/*==============================================================*/
create table LISTADODEESPECIES (
   CODESP               numeric              not null,
   NROPROY              numeric              not null,
   constraint PK_LISTADODEESPECIES primary key (CODESP, NROPROY)
)
go

/*==============================================================*/
/* Table: LISTADODEESTRATOS                                     */
/*==============================================================*/
create table LISTADODEESTRATOS (
   NROPROY              numeric              not null,
   CODEST               numeric              not null,
   PESO                 decimal(18,3)        null,
   constraint PK_LISTADODEESTRATOS primary key (NROPROY, CODEST)
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
   NROPROY              numeric              not null,
   NROEST               uniqueidentifier     not null,
   NOMBRETIPOINV        varchar(100)         not null,
   CODETAPA             numeric              not null,
   NOMTIPODISEMUEST     varchar(100)         not null,
   LUGAR                varchar(100)         not null,
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
NROEST ASC
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
/* Index: SE_HACE_FK                                            */
/*==============================================================*/
create index SE_HACE_FK on PROYECTO (
CODETAPA ASC
)
go

/*==============================================================*/
/* Table: PROYECTOSPORETAPA                                     */
/*==============================================================*/
create table PROYECTOSPORETAPA (
   NROPROY              numeric              not null,
   PRO_NROPROY          numeric              not null,
   constraint PK_PROYECTOSPORETAPA primary key (NROPROY, PRO_NROPROY)
)
go

/*==============================================================*/
/* Table: REGENERACION                                          */
/*==============================================================*/
create table REGENERACION (
   NROPROY              numeric              not null,
   PARCELA              numeric              not null,
   NROARB               numeric              not null,
   LINEA                numeric              not null,
   NROEST               uniqueidentifier     not null,
   CODEST               numeric              not null,
   CODESP               numeric              not null,
   LATIZAL              numeric              null,
   BRINZAL              numeric              null,
   constraint PK_REGENERACION primary key (NROPROY, PARCELA, NROARB, LINEA)
)
go

/*==============================================================*/
/* Index: EVALUACION_FK                                         */
/*==============================================================*/
create index EVALUACION_FK on REGENERACION (
CODESP ASC
)
go

/*==============================================================*/
/* Index: SUBDIVIDE_FK                                          */
/*==============================================================*/
create index SUBDIVIDE_FK on REGENERACION (
CODEST ASC
)
go

/*==============================================================*/
/* Index: CAPTURA_FK                                            */
/*==============================================================*/
create index CAPTURA_FK on REGENERACION (
NROEST ASC
)
go

/*==============================================================*/
/* Index: EXAMINA_FK                                            */
/*==============================================================*/
create index EXAMINA_FK on REGENERACION (
NROPROY ASC
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
   NROTRANS             numeric              not null,
   NROEST               uniqueidentifier     not null,
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
NROEST ASC
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

alter table ESPECIE
   add constraint FK_ESPECIE_PERTENECE_GRUPOCOM foreign key (GRUPOCOM)
      references GRUPOCOMERCIAL (GRUPOCOM)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_ASOCIADO_ESTADOSA foreign key (ESTADO)
      references ESTADOSANITARIO (ESTADO)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_CONTIENE_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_DESARROLL_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_MANEJA_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_POSEE_CALIDAD foreign key (CODCALIDAD)
      references CALIDAD (CODCALIDAD)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_RECOGE_ESTACION foreign key (NROEST)
      references ESTACION (NROEST)
         on update cascade on delete cascade
go

alter table LISTADODEESPECIES
   add constraint FK_LISTADOD_LISTADODE_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LISTADODEESPECIES
   add constraint FK_LISTADOD_LISTESPEC_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table LISTADODEESTRATOS
   add constraint FK_LISTADOD_LISTADODE_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
         on update cascade on delete cascade
go

alter table LISTADODEESTRATOS
   add constraint FK_LISTADOD_LISTESTRA_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_CREA_ESTACION foreign key (NROEST)
      references ESTACION (NROEST)
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

alter table PROYECTO
   add constraint FK_PROYECTO_SE_HACE_ETAPA foreign key (CODETAPA)
      references ETAPA (CODETAPA)
         on update cascade on delete cascade
go

alter table PROYECTOSPORETAPA
   add constraint FK_PROYECTO_PROYECTOR_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table PROYECTOSPORETAPA
   add constraint FK_PROYECTO_PROYECTOS_PROYECTO foreign key (PRO_NROPROY)
      references PROYECTO (NROPROY)
go

alter table REGENERACION
   add constraint FK_REGENERA_CAPTURA_ESTACION foreign key (NROEST)
      references ESTACION (NROEST)
         on update cascade on delete cascade
go

alter table REGENERACION
   add constraint FK_REGENERA_EVALUACIO_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table REGENERACION
   add constraint FK_REGENERA_EXAMINA_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table REGENERACION
   add constraint FK_REGENERA_SUBDIVIDE_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
         on update cascade on delete cascade
go

alter table TRANSACCION
   add constraint FK_TRANSACC_REGISTRA_ESTACION foreign key (NROEST)
      references ESTACION (NROEST)
         on update cascade on delete cascade
go

