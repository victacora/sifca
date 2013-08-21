/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     20/08/2013 11:27:06 p.m.                     */
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
   where r.fkeyid = object_id('INVENTARIO') and o.name = 'FK_INVENTAR_SE_HACE_ETAPA')
alter table INVENTARIO
   drop constraint FK_INVENTAR_SE_HACE_ETAPA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LIGADO') and o.name = 'FK_LIGADO_LIGADOESP_ESPECIE')
alter table LIGADO
   drop constraint FK_LIGADO_LIGADOESP_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LIGADO') and o.name = 'FK_LIGADO_LIGADOLIS_LISTADOD')
alter table LIGADO
   drop constraint FK_LIGADO_LIGADOLIS_LISTADOD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_CREA_ESTACION')
alter table PROYECTO
   drop constraint FK_PROYECTO_CREA_ESTACION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_ES_TIPOINVE')
alter table PROYECTO
   drop constraint FK_PROYECTO_ES_TIPOINVE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_TIENE_LISTADO')
alter table PROYECTO
   drop constraint FK_PROYECTO_TIENE_LISTADO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_EVALUA_ESPECIE')
alter table REGENERACION
   drop constraint FK_REGENERA_EVALUA_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_EXAMINA_PROYECTO')
alter table REGENERACION
   drop constraint FK_REGENERA_EXAMINA_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_SE_EXAMIN_ETAPA')
alter table REGENERACION
   drop constraint FK_REGENERA_SE_EXAMIN_ETAPA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGENERACION') and o.name = 'FK_REGENERA_SUBDIVIDE_ESTRATO')
alter table REGENERACION
   drop constraint FK_REGENERA_SUBDIVIDE_ESTRATO
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
            and   name  = 'SE_HACE_FK'
            and   indid > 0
            and   indid < 255)
   drop index INVENTARIO.SE_HACE_FK
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
           where  id = object_id('LIGADO')
            and   type = 'U')
   drop table LIGADO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LISTADODEESPECIES')
            and   type = 'U')
   drop table LISTADODEESPECIES
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
            from  sysindexes
           where  id    = object_id('PROYECTO')
            and   name  = 'TIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROYECTO.TIENE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROYECTO')
            and   type = 'U')
   drop table PROYECTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGENERACION')
            and   name  = 'SE_EXAMINA_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGENERACION.SE_EXAMINA_FK
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
            and   name  = 'SUBDIVIDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGENERACION.SUBDIVIDE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGENERACION')
            and   name  = 'EVALUA_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGENERACION.EVALUA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REGENERACION')
            and   type = 'U')
   drop table REGENERACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOINVENTARIO')
            and   type = 'U')
   drop table TIPOINVENTARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TSTUDENT')
            and   type = 'U')
   drop table TSTUDENT
go

if exists(select 1 from systypes where name='ESTADOPROYECTO')
   execute sp_unbindrule ESTADOPROYECTO
go

if exists(select 1 from systypes where name='ESTADOPROYECTO')
   drop type ESTADOPROYECTO
go

if exists (select 1 from sysobjects where id=object_id('R_ESTADOPROYECTO') and type='R')
   drop rule  R_ESTADOPROYECTO
go

create rule R_ESTADOPROYECTO as
      @column in ('A','I')
go

/*==============================================================*/
/* Domain: ESTADOPROYECTO                                       */
/*==============================================================*/
create type ESTADOPROYECTO
   from char(1) not null
go

execute sp_bindrule R_ESTADOPROYECTO, ESTADOPROYECTO
go

/*==============================================================*/
/* Table: CALIDAD                                               */
/*==============================================================*/
create table CALIDAD (
   CALIDAD              numeric              identity,
   DESCRIPCALIDAD       varchar(500)         null,
   constraint PK_CALIDAD primary key nonclustered (CALIDAD)
)
go

/*==============================================================*/
/* Table: ESPECIE                                               */
/*==============================================================*/
create table ESPECIE (
   CODESP               numeric              identity,
   GRUPOCOM             char(2)              not null,
   NOMCOMUN             varchar(100)         null,
   NOMCIENTIFICO        varchar(100)         null,
   FAMILIA              varchar(100)         null,
   ZONAGEOGRAFICA       varchar(100)         null,
   ZONADEVIDA           varchar(100)         null,
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
   PERSONARESPONSABLE   varchar(100)         null,
   NOMBRE               varchar(100)         null,
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
   CODEST               numeric              identity,
   DESCRIPESTRATO       varchar(500)         null,
   constraint PK_ESTRATO primary key nonclustered (CODEST)
)
go

/*==============================================================*/
/* Table: ETAPA                                                 */
/*==============================================================*/
create table ETAPA (
   CODETAPA             numeric              identity,
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
   LINEAINVENT          numeric              identity,
   CALIDAD              numeric              not null,
   NROPROY              numeric              not null,
   ESTADO               char(2)              not null,
   CODEST               numeric              not null,
   CODESP               numeric              not null,
   CODETAPA             numeric              not null,
   NROEST               uniqueidentifier     not null,
   PARCELA              numeric              null,
   NROARB               numeric              null,
   CAP                  numeric              null,
   DAP                  numeric              null,
   ALTCOMER_M           numeric              null,
   ALTTOT_M             numeric              null,
   AREABASAL            decimal              null,
   VOLCOM               decimal              null,
   VOLTOT               decimal              null,
   constraint PK_INVENTARIO primary key nonclustered (LINEAINVENT)
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
CALIDAD ASC
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
/* Index: SE_HACE_FK                                            */
/*==============================================================*/
create index SE_HACE_FK on INVENTARIO (
CODETAPA ASC
)
go

/*==============================================================*/
/* Table: LIGADO                                                */
/*==============================================================*/
create table LIGADO (
   NOMARCH              varchar(60)          not null,
   CODESP               numeric              not null,
   constraint PK_LIGADO primary key (NOMARCH, CODESP)
)
go

/*==============================================================*/
/* Table: LISTADODEESPECIES                                     */
/*==============================================================*/
create table LISTADODEESPECIES (
   NOMARCH              varchar(60)          not null,
   DESCRIPLISTESPECIES  varchar(500)         null,
   constraint PK_LISTADODEESPECIES primary key nonclustered (NOMARCH)
)
go

/*==============================================================*/
/* Table: PROYECTO                                              */
/*==============================================================*/
create table PROYECTO (
   NROPROY              numeric              identity,
   NROEST               uniqueidentifier     not null,
   NOMBRETIPOINV        varchar(100)         not null,
   NOMARCH              varchar(60)          not null,
   LUGAR                varchar(100)         null,
   SUPTOT               decimal              null,
   INTMUE               decimal              null,
   SUPMUE               decimal              null,
   TAMANO               decimal              null,
   ESTADOPROY           ESTADOPROYECTO       not null,
   constraint PK_PROYECTO primary key nonclustered (NROPROY)
)
go

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/
create index TIENE_FK on PROYECTO (
NOMARCH ASC
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
/* Table: REGENERACION                                          */
/*==============================================================*/
create table REGENERACION (
   LINEAREGEN           numeric              identity,
   PARCELA              numeric              null,
   NROARB               numeric              null,
   LATIZAL              numeric              null,
   BRINZAL              numeric              null,
   CODEST               numeric              not null,
   CODETAPA             numeric              not null,
   NROPROY              numeric              not null,
   CODESP               numeric              not null,
   constraint PK_REGENERACION primary key nonclustered (LINEAREGEN)
)
go

/*==============================================================*/
/* Index: EVALUA_FK                                             */
/*==============================================================*/
create index EVALUA_FK on REGENERACION (
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
/* Index: EXAMINA_FK                                            */
/*==============================================================*/
create index EXAMINA_FK on REGENERACION (
NROPROY ASC
)
go

/*==============================================================*/
/* Index: SE_EXAMINA_FK                                         */
/*==============================================================*/
create index SE_EXAMINA_FK on REGENERACION (
CODETAPA ASC
)
go

/*==============================================================*/
/* Table: TIPOINVENTARIO                                        */
/*==============================================================*/
create table TIPOINVENTARIO (
   NOMBRETIPOINV        varchar(100)         not null,
   DESCRIPTIPOINV       varchar(500)         null,
   constraint PK_TIPOINVENTARIO primary key nonclustered (NOMBRETIPOINV)
)
go

/*==============================================================*/
/* Table: TSTUDENT                                              */
/*==============================================================*/
create table TSTUDENT (
   N                    numeric              not null,
   ALPHA                decimal              not null,
   VALOR                decimal              not null,
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
   add constraint FK_INVENTAR_POSEE_CALIDAD foreign key (CALIDAD)
      references CALIDAD (CALIDAD)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_RECOGE_ESTACION foreign key (NROEST)
      references ESTACION (NROEST)
         on update cascade on delete cascade
go

alter table INVENTARIO
   add constraint FK_INVENTAR_SE_HACE_ETAPA foreign key (CODETAPA)
      references ETAPA (CODETAPA)
         on update cascade on delete cascade
go

alter table LIGADO
   add constraint FK_LIGADO_LIGADOESP_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LIGADO
   add constraint FK_LIGADO_LIGADOLIS_LISTADOD foreign key (NOMARCH)
      references LISTADODEESPECIES (NOMARCH)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_CREA_ESTACION foreign key (NROEST)
      references ESTACION (NROEST)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_ES_TIPOINVE foreign key (NOMBRETIPOINV)
      references TIPOINVENTARIO (NOMBRETIPOINV)
         on update cascade on delete cascade
go

alter table PROYECTO
   add constraint FK_PROYECTO_TIENE_LISTADO foreign key (NOMARCH)
      references LISTADODEESPECIES (NOMARCH)
         on update cascade on delete cascade
go

alter table REGENERACION
   add constraint FK_REGENERA_EVALUA_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table REGENERACION
   add constraint FK_REGENERA_EXAMINA_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
         on update cascade on delete cascade
go

alter table REGENERACION
   add constraint FK_REGENERA_SE_EXAMIN_ETAPA foreign key (CODETAPA)
      references ETAPA (CODETAPA)
         on update cascade on delete cascade
go

alter table REGENERACION
   add constraint FK_REGENERA_SUBDIVIDE_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
         on update cascade on delete cascade
go

