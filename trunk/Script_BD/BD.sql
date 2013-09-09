/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     09/09/2013 10:37:52 a.m.                     */
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
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_FORMULAR_ES_DE_TIPOFORM')
alter table FORMULARIO
   drop constraint FK_FORMULAR_ES_DE_TIPOFORM
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
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_LISTADOD_LISTESPEC_ESPECIE')
alter table LISTADODEESPECIES
   drop constraint FK_LISTADOD_LISTESPEC_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_LISTADOD_LISTESPEC_PROYECTO')
alter table LISTADODEESPECIES
   drop constraint FK_LISTADOD_LISTESPEC_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_LISTADOD_LISTESTRA_ESTRATO')
alter table LISTADODEESTRATOS
   drop constraint FK_LISTADOD_LISTESTRA_ESTRATO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_LISTADOD_LISTESTRA_PROYECTO')
alter table LISTADODEESTRATOS
   drop constraint FK_LISTADOD_LISTESTRA_PROYECTO
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
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_ES_DE_TIP_TIPOPROY')
alter table PROYECTO
   drop constraint FK_PROYECTO_ES_DE_TIP_TIPOPROY
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
   where r.fkeyid = object_id('SE_USA') and o.name = 'FK_SE_USA_SE_USA_LINEANOM')
alter table SE_USA
   drop constraint FK_SE_USA_SE_USA_LINEANOM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SE_USA') and o.name = 'FK_SE_USA_SE_USA2_TIPODEUS')
alter table SE_USA
   drop constraint FK_SE_USA_SE_USA2_TIPODEUS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_REGISTRA_USUARIO')
alter table TRANSACCION
   drop constraint FK_TRANSACC_REGISTRA_USUARIO
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
            and   name  = 'ES_DE_FK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO.ES_DE_FK
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
            from  sysindexes
           where  id    = object_id('FORMULARIO')
            and   name  = 'FORMULARIO_PK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO.FORMULARIO_PK
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
            from  sysobjects
           where  id = object_id('OBJETIVOINVENTARIO')
            and   type = 'U')
   drop table OBJETIVOINVENTARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROYECTO')
            and   name  = 'ES_DE_TIPO_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROYECTO.ES_DE_TIPO_FK
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
           where  id = object_id('SE_USA')
            and   type = 'U')
   drop table SE_USA
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
            from  sysobjects
           where  id = object_id('TIPOFORMULARIO')
            and   type = 'U')
   drop table TIPOFORMULARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOPROYECTO')
            and   type = 'U')
   drop table TIPOPROYECTO
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
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

if exists(select 1 from systypes where name='TIPOOPERACION')
   execute sp_unbindrule TIPOOPERACION
go

if exists(select 1 from systypes where name='TIPOOPERACION')
   drop type TIPOOPERACION
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOOPERACION') and type='R')
   drop rule  R_TIPOOPERACION
go

create rule R_TIPOOPERACION as
      @column in ('I','A','E')
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
   TIPFORM_ID           numeric              not null,
   CODEST               numeric              not null,
   NROUSUARIO           uniqueidentifier     not null,
   NROPROY              uniqueidentifier     not null,
   FECHACREACION        datetime             not null,
   HORAINICIO           datetime             not null,
   HORAFINAL            datetime             not null,
   PARCELA              numeric              not null,
   LINEA                numeric              not null,
   COORDENADAX          numeric              null,
   COORDENADAY          numeric              null,
   constraint PK_FORMULARIO primary key (NROFORMULARIO)
)
go

/*==============================================================*/
/* Index: FORMULARIO_PK                                         */
/*==============================================================*/
create unique index FORMULARIO_PK on FORMULARIO (
NROFORMULARIO ASC
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
/* Index: ES_DE_FK                                              */
/*==============================================================*/
create index ES_DE_FK on FORMULARIO (
TIPFORM_ID ASC
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
/* Table: LINEAINVENTARIO                                       */
/*==============================================================*/
create table LINEAINVENTARIO (
   LINEAINV             uniqueidentifier     not null,
   CODCALIDAD           numeric              not null,
   ESTADO               char(2)              not null,
   CODESP               uniqueidentifier     not null,
   NROFORMULARIO        uniqueidentifier     null,
   NROARB               numeric              null,
   CAP                  numeric              null,
   DAP                  numeric              null,
   ALTCOMER_M           numeric              null,
   ALTTOT_M             numeric              null,
   AREABASAL            decimal(18,3)        null,
   VOLCOM               decimal(18,3)        null,
   VOLTOT               decimal(18,3)        null,
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
   NROFORMULARIO        uniqueidentifier     null,
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
   NROARB               numeric              null,
   LATIZAL              numeric              null,
   BRINZAL              numeric              null,
   LINEAREGEN           uniqueidentifier     not null,
   CODESP               uniqueidentifier     not null,
   NROFORMULARIO        uniqueidentifier     null,
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
   TIPOPOYECTO_ID       numeric              not null,
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
/* Index: ES_DE_TIPO_FK                                         */
/*==============================================================*/
create index ES_DE_TIPO_FK on PROYECTO (
TIPOPOYECTO_ID ASC
)
go

/*==============================================================*/
/* Table: PROYECTOSPORETAPA                                     */
/*==============================================================*/
create table PROYECTOSPORETAPA (
   NROPROY              uniqueidentifier     not null,
   PRO_NROPROY          uniqueidentifier     not null,
   constraint PK_PROYECTOSPORETAPA primary key (NROPROY, PRO_NROPROY)
)
go

/*==============================================================*/
/* Table: SE_USA                                                */
/*==============================================================*/
create table SE_USA (
   LINEANMAD            uniqueidentifier     not null,
   NOMBRETIPOUSO        varchar(100)         not null,
   constraint PK_SE_USA primary key (LINEANMAD, NOMBRETIPOUSO)
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
/* Table: TIPOFORMULARIO                                        */
/*==============================================================*/
create table TIPOFORMULARIO (
   NOMBRETIPOFORM       varchar(100)         not null,
   DESCRIPCION          varchar(500)         null,
   TIPFORM_ID           numeric              identity,
   constraint PK_TIPOFORMULARIO primary key nonclustered (TIPFORM_ID)
)
go

/*==============================================================*/
/* Table: TIPOPROYECTO                                          */
/*==============================================================*/
create table TIPOPROYECTO (
   TIPOPOYECTO_ID       numeric              not null,
   DESCRIPCION          varchar(500)         not null,
   NOMBRETIPOPROYECTO   varchar(100)         null,
   constraint PK_TIPOPROYECTO primary key nonclustered (TIPOPOYECTO_ID)
)
go

/*==============================================================*/
/* Table: TRANSACCION                                           */
/*==============================================================*/
create table TRANSACCION (
   NROTRANS             uniqueidentifier     not null,
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
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   NROUSUARIO           uniqueidentifier     not null,
   NOMBRES              varchar(100)         not null,
   APELLIDOS            varchar(100)         not null,
   USUARIO              varchar(100)         not null,
   CONTRASENA           varchar(1000)        not null,
   CEDULA               numeric              not null,
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
   add constraint FK_FORMULAR_ES_DE_TIPOFORM foreign key (TIPFORM_ID)
      references TIPOFORMULARIO (TIPFORM_ID)
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
   add constraint FK_LISTADOD_LISTESPEC_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LISTADODEESPECIES
   add constraint FK_LISTADOD_LISTESPEC_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table LISTADODEESTRATOS
   add constraint FK_LISTADOD_LISTESTRA_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
         on update cascade on delete cascade
go

alter table LISTADODEESTRATOS
   add constraint FK_LISTADOD_LISTESTRA_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_CREA_USUARIO foreign key (NROUSUARIO)
      references USUARIO (NROUSUARIO)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_ES_OBJETIVO foreign key (NOMBRETIPOINV)
      references OBJETIVOINVENTARIO (NOMBRETIPOINV)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_ES_DE_TIP_TIPOPROY foreign key (TIPOPOYECTO_ID)
      references TIPOPROYECTO (TIPOPOYECTO_ID)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_REALIZA_TIPODISE foreign key (NOMTIPODISEMUEST)
      references TIPODISENOMUESTRAL (NOMTIPODISEMUEST)
         on update cascade on delete cascade
go

alter table PROYECTOSPORETAPA
   add constraint FK_PROYECTO_CONTENEDOR foreign key (PRO_NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table PROYECTOSPORETAPA
   add constraint FK_PROYECTO_CONTENIDOS foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table SE_USA
   add constraint FK_SE_USA_SE_USA_LINEANOM foreign key (LINEANMAD)
      references LINEANOMADERABLES (LINEANMAD)
         on update cascade on delete cascade
go

alter table SE_USA
   add constraint FK_SE_USA_SE_USA2_TIPODEUS foreign key (NOMBRETIPOUSO)
      references TIPODEUSO (NOMBRETIPOUSO)
         on update cascade on delete cascade
go

alter table TRANSACCION
   add constraint FK_TRANSACC_REGISTRA_USUARIO foreign key (NROUSUARIO)
      references USUARIO (NROUSUARIO)
         on update cascade on delete cascade
go

