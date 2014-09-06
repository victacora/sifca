/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     24/08/2014 8:16:34 a. m.                     */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BLOQUE') and o.name = 'FK_BLOQUE_TIENE_PROYECTO')
alter table BLOQUE
   drop constraint FK_BLOQUE_TIENE_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BLOQUE') and o.name = 'FK_PROYECTO_CONTENEDOR')
alter table BLOQUE
   drop constraint FK_PROYECTO_CONTENEDOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONFIGMAPACONFUNIDADMUESTRAL') and o.name = 'FK_CONFIGMAPA_TIENE_CONFIGUNIDADMUESTRAL')
alter table CONFIGMAPACONFUNIDADMUESTRAL
   drop constraint FK_CONFIGMAPA_TIENE_CONFIGUNIDADMUESTRAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONFIGMAPACONFUNIDADMUESTRAL') and o.name = 'FK_CONFIGUNIDADMUESTRALTIENECONFIGMAPA')
alter table CONFIGMAPACONFUNIDADMUESTRAL
   drop constraint FK_CONFIGUNIDADMUESTRALTIENECONFIGMAPA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEPARTAMENTO') and o.name = 'FK_DEPARTAMENTO_PERTENECE_PAIS')
alter table DEPARTAMENTO
   drop constraint FK_DEPARTAMENTO_PERTENECE_PAIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOMINIOVARIABLE') and o.name = 'FK_DOMINIO_APLICA_VARIABLE')
alter table DOMINIOVARIABLE
   drop constraint FK_DOMINIO_APLICA_VARIABLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOMINIOVARIABLE') and o.name = 'FK_VARIABLE_TIENE_DOMINIO')
alter table DOMINIOVARIABLE
   drop constraint FK_VARIABLE_TIENE_DOMINIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ESPECIE') and o.name = 'FK_ESPECIE_PERTENECE_GRUPOCOMERCIAL')
alter table ESPECIE
   drop constraint FK_ESPECIE_PERTENECE_GRUPOCOMERCIAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULA') and o.name = 'FK_FORMULA_ES_DE_TIPO_FORMULA')
alter table FORMULA
   drop constraint FK_FORMULA_ES_DE_TIPO_FORMULA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULA') and o.name = 'FK_FORMULA_VARIABLE_SALIDA')
alter table FORMULA
   drop constraint FK_FORMULA_VARIABLE_SALIDA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULAPROYECTO') and o.name = 'FK_FORMULA_SE_APLICA_A_PROYECTOS')
alter table FORMULAPROYECTO
   drop constraint FK_FORMULA_SE_APLICA_A_PROYECTOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULAPROYECTO') and o.name = 'FK_PROYECTO_TIENE_FORMULA')
alter table FORMULAPROYECTO
   drop constraint FK_PROYECTO_TIENE_FORMULA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_FORMULARIO_TIENE_ESTRATO')
alter table FORMULARIO
   drop constraint FK_FORMULARIO_TIENE_ESTRATO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_FORMULARIO_TIENE_PARCELA')
alter table FORMULARIO
   drop constraint FK_FORMULARIO_TIENE_PARCELA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_PROYECTO_TIENE_FORMULARIOS')
alter table FORMULARIO
   drop constraint FK_PROYECTO_TIENE_FORMULARIOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO') and o.name = 'FK_USUARIO_CREA_FOMULARIO')
alter table FORMULARIO
   drop constraint FK_USUARIO_CREA_FOMULARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULAVARIABLE') and o.name = 'FK_FORMULA_TIENE_VARIABLE')
alter table FORMULAVARIABLE
   drop constraint FK_FORMULA_TIENE_VARIABLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULAVARIABLE') and o.name = 'FK_VARIABLE_SE_APLICA_FORMULA')
alter table FORMULAVARIABLE
   drop constraint FK_VARIABLE_SE_APLICA_FORMULA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('IMAGEN') and o.name = 'FK_ESPECIE_TIENE_IMAGEN')
alter table IMAGEN
   drop constraint FK_ESPECIE_TIENE_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIO') and o.name = 'FK_FORMULARIO_CREA_LINEAINEVNTARIO')
alter table LINEAINVENTARIO
   drop constraint FK_FORMULARIO_CREA_LINEAINEVNTARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIO') and o.name = 'FK_LINEA_INVENTARIO_ES_DE_TIPOLINEAINV')
alter table LINEAINVENTARIO
   drop constraint FK_LINEA_INVENTARIO_ES_DE_TIPOLINEAINV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIOESPECIE') and o.name = 'FK_ESPECIE_PERTENECE_LINEAINVENTARIO')
alter table LINEAINVENTARIOESPECIE
   drop constraint FK_ESPECIE_PERTENECE_LINEAINVENTARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIOESPECIE') and o.name = 'FK_LINEA_INVENTARIO_TIENE_ESPECIE')
alter table LINEAINVENTARIOESPECIE
   drop constraint FK_LINEA_INVENTARIO_TIENE_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIOVARIABLE') and o.name = 'FK_LINEAINVENTARIO_TIENE_VARIABLES')
alter table LINEAINVENTARIOVARIABLE
   drop constraint FK_LINEAINVENTARIO_TIENE_VARIABLES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LINEAINVENTARIOVARIABLE') and o.name = 'FK_VARIABLES_SE_APLICA_LINEAINVENTARIO')
alter table LINEAINVENTARIOVARIABLE
   drop constraint FK_VARIABLES_SE_APLICA_LINEAINVENTARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODECOSTOS') and o.name = 'FK_LISTADODECOSTOS_TIENE_COSTO')
alter table LISTADODECOSTOS
   drop constraint FK_LISTADODECOSTOS_TIENE_COSTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODECOSTOS') and o.name = 'FK_PROYECTO_TIENE_LISTADODECOSTOS')
alter table LISTADODECOSTOS
   drop constraint FK_PROYECTO_TIENE_LISTADODECOSTOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_LISTADODEESPECIES_TIENE_ESPECIE')
alter table LISTADODEESPECIES
   drop constraint FK_LISTADODEESPECIES_TIENE_ESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESPECIES') and o.name = 'FK_PROYECTO_TIENE_LISTADODEESPECIE')
alter table LISTADODEESPECIES
   drop constraint FK_PROYECTO_TIENE_LISTADODEESPECIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_LISTADEESTRATOS_TIENE_ESTRATOS')
alter table LISTADODEESTRATOS
   drop constraint FK_LISTADEESTRATOS_TIENE_ESTRATOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTADODEESTRATOS') and o.name = 'FK_PROYECTO_TIENE_LISTADODEESTRATOS')
alter table LISTADODEESTRATOS
   drop constraint FK_PROYECTO_TIENE_LISTADODEESTRATOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MUNICIPIO') and o.name = 'FK_MUNICIPIO_PERTENECE_DEPARTAMENTO')
alter table MUNICIPIO
   drop constraint FK_MUNICIPIO_PERTENECE_DEPARTAMENTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PARCELA') and o.name = 'FK_PROYECTO_TIENE_PARCELAS')
alter table PARCELA
   drop constraint FK_PROYECTO_TIENE_PARCELAS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_ES_DEL_TIPODISENIOMUEST')
alter table PROYECTO
   drop constraint FK_PROYECTO_ES_DEL_TIPODISENIOMUEST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_TIENE_CONFIGURACIONMAPA')
alter table PROYECTO
   drop constraint FK_PROYECTO_TIENE_CONFIGURACIONMAPA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_TIENE_MUNICIPIO')
alter table PROYECTO
   drop constraint FK_PROYECTO_TIENE_MUNICIPIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_PROYECTO_TIENE_OBJETIVOINVENTARIO')
alter table PROYECTO
   drop constraint FK_PROYECTO_TIENE_OBJETIVOINVENTARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROYECTO') and o.name = 'FK_USUARIO_CREA_PROYECTO')
alter table PROYECTO
   drop constraint FK_USUARIO_CREA_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIPOLINEAINVENTARIOPROYECTO') and o.name = 'FK_PROYECTO_TIENE_TIPOLINEAINV')
alter table TIPOLINEAINVENTARIOPROYECTO
   drop constraint FK_PROYECTO_TIENE_TIPOLINEAINV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIPOLINEAINVENTARIOPROYECTO') and o.name = 'FK_TIPOLINEAINV_SE_APLICA_A_PROYECTO')
alter table TIPOLINEAINVENTARIOPROYECTO
   drop constraint FK_TIPOLINEAINV_SE_APLICA_A_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIPOLINEAINVENTARIOVARIABLE') and o.name = 'FK_TIPOLINEAINVVAR_PERTENECE_A_TIPOLINEAINV')
alter table TIPOLINEAINVENTARIOVARIABLE
   drop constraint FK_TIPOLINEAINVVAR_PERTENECE_A_TIPOLINEAINV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIPOLINEAINVENTARIOVARIABLE') and o.name = 'FK_TIPOLINEAINVVAR_TIENE_VARIABLE')
alter table TIPOLINEAINVENTARIOVARIABLE
   drop constraint FK_TIPOLINEAINVVAR_TIENE_VARIABLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BLOQUE')
            and   type = 'U')
   drop table BLOQUE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONFIGMAPACONFUNIDADMUESTRAL')
            and   name  = 'FK_CONFIGMAPACONFUNIDADMUESTRAL'
            and   indid > 0
            and   indid < 255)
   drop index CONFIGMAPACONFUNIDADMUESTRAL.FK_CONFIGMAPACONFUNIDADMUESTRAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONFIGMAPACONFUNIDADMUESTRAL')
            and   type = 'U')
   drop table CONFIGMAPACONFUNIDADMUESTRAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONFIGURACIONMAPA')
            and   name  = 'NROCONFIGURACIONMAPA'
            and   indid > 0
            and   indid < 255)
   drop index CONFIGURACIONMAPA.NROCONFIGURACIONMAPA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONFIGURACIONMAPA')
            and   type = 'U')
   drop table CONFIGURACIONMAPA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONFIGURACIONUNIDADMUESTRAL')
            and   name  = 'NROCONFIGURACIONUNIDADMUESTRAL'
            and   indid > 0
            and   indid < 255)
   drop index CONFIGURACIONUNIDADMUESTRAL.NROCONFIGURACIONUNIDADMUESTRAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONFIGURACIONUNIDADMUESTRAL')
            and   type = 'U')
   drop table CONFIGURACIONUNIDADMUESTRAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COSTO')
            and   type = 'U')
   drop table COSTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEPARTAMENTO')
            and   name  = 'CODDEPARTAMENTO'
            and   indid > 0
            and   indid < 255)
   drop index DEPARTAMENTO.CODDEPARTAMENTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPARTAMENTO')
            and   type = 'U')
   drop table DEPARTAMENTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOMINIO')
            and   name  = 'NRODOMINIO'
            and   indid > 0
            and   indid < 255)
   drop index DOMINIO.NRODOMINIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOMINIO')
            and   type = 'U')
   drop table DOMINIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOMINIOVARIABLE')
            and   name  = 'FK_DOMINIOVARIABLE'
            and   indid > 0
            and   indid < 255)
   drop index DOMINIOVARIABLE.FK_DOMINIOVARIABLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOMINIOVARIABLE')
            and   type = 'U')
   drop table DOMINIOVARIABLE
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
           where  id = object_id('ESTRATO')
            and   type = 'U')
   drop table ESTRATO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULA')
            and   name  = 'NROFORMULA'
            and   indid > 0
            and   indid < 255)
   drop index FORMULA.NROFORMULA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FORMULA')
            and   type = 'U')
   drop table FORMULA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULAPROYECTO')
            and   name  = 'FK_FORMULAPROYECTO'
            and   indid > 0
            and   indid < 255)
   drop index FORMULAPROYECTO.FK_FORMULAPROYECTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FORMULAPROYECTO')
            and   type = 'U')
   drop table FORMULAPROYECTO
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
            from  sysindexes
           where  id    = object_id('FORMULAVARIABLE')
            and   name  = 'FK_FORMULAVARIABLE'
            and   indid > 0
            and   indid < 255)
   drop index FORMULAVARIABLE.FK_FORMULAVARIABLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FORMULAVARIABLE')
            and   type = 'U')
   drop table FORMULAVARIABLE
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
            from  sysobjects
           where  id = object_id('LINEAINVENTARIO')
            and   type = 'U')
   drop table LINEAINVENTARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAINVENTARIOESPECIE')
            and   name  = 'FK_LINEAINVENTARIOESPECIE'
            and   indid > 0
            and   indid < 255)
   drop index LINEAINVENTARIOESPECIE.FK_LINEAINVENTARIOESPECIE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LINEAINVENTARIOESPECIE')
            and   type = 'U')
   drop table LINEAINVENTARIOESPECIE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LINEAINVENTARIOVARIABLE')
            and   name  = 'FK_LINEAINVENTARIOVARIABLE'
            and   indid > 0
            and   indid < 255)
   drop index LINEAINVENTARIOVARIABLE.FK_LINEAINVENTARIOVARIABLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LINEAINVENTARIOVARIABLE')
            and   type = 'U')
   drop table LINEAINVENTARIOVARIABLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LISTADODECOSTOS')
            and   type = 'U')
   drop table LISTADODECOSTOS
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
           where  id    = object_id('MUNICIPIO')
            and   name  = 'CODMUNICIPIO'
            and   indid > 0
            and   indid < 255)
   drop index MUNICIPIO.CODMUNICIPIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MUNICIPIO')
            and   type = 'U')
   drop table MUNICIPIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OBJETIVOINVENTARIO')
            and   type = 'U')
   drop table OBJETIVOINVENTARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PAIS')
            and   name  = 'CODPAIS'
            and   indid > 0
            and   indid < 255)
   drop index PAIS.CODPAIS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PAIS')
            and   type = 'U')
   drop table PAIS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PARCELA')
            and   name  = 'NROPARCELA'
            and   indid > 0
            and   indid < 255)
   drop index PARCELA.NROPARCELA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PARCELA')
            and   type = 'U')
   drop table PARCELA
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
           where  id = object_id('TIPODISENOMUESTRAL')
            and   type = 'U')
   drop table TIPODISENOMUESTRAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPOFORMULA')
            and   name  = 'NROTIPOFORMULA'
            and   indid > 0
            and   indid < 255)
   drop index TIPOFORMULA.NROTIPOFORMULA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOFORMULA')
            and   type = 'U')
   drop table TIPOFORMULA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPOLINEAINVENTARIO')
            and   name  = 'NROTIPOLINEINV'
            and   indid > 0
            and   indid < 255)
   drop index TIPOLINEAINVENTARIO.NROTIPOLINEINV
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOLINEAINVENTARIO')
            and   type = 'U')
   drop table TIPOLINEAINVENTARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPOLINEAINVENTARIOPROYECTO')
            and   name  = 'FK_TIPOLINEAINVENTARIOPROYECTO'
            and   indid > 0
            and   indid < 255)
   drop index TIPOLINEAINVENTARIOPROYECTO.FK_TIPOLINEAINVENTARIOPROYECTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOLINEAINVENTARIOPROYECTO')
            and   type = 'U')
   drop table TIPOLINEAINVENTARIOPROYECTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPOLINEAINVENTARIOVARIABLE')
            and   name  = 'FK_TIPOLINEAINVENTARIOVARIABLE'
            and   indid > 0
            and   indid < 255)
   drop index TIPOLINEAINVENTARIOVARIABLE.FK_TIPOLINEAINVENTARIOVARIABLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOLINEAINVENTARIOVARIABLE')
            and   type = 'U')
   drop table TIPOLINEAINVENTARIOVARIABLE
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

if exists (select 1
            from  sysindexes
           where  id    = object_id('VARIABLE')
            and   name  = 'NROVARIABLE'
            and   indid > 0
            and   indid < 255)
   drop index VARIABLE.NROVARIABLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VARIABLE')
            and   type = 'U')
   drop table VARIABLE
go

if exists(select 1 from systypes where name='FORMA')
   execute sp_unbindrule FORMA
go

if exists(select 1 from systypes where name='FORMA')
   drop type FORMA
go

if exists(select 1 from systypes where name='SINO')
   execute sp_unbindrule SINO
go

if exists(select 1 from systypes where name='SINO')
   drop type SINO
go

if exists(select 1 from systypes where name='TIPOCOSTO')
   execute sp_unbindrule TIPOCOSTO
go

if exists(select 1 from systypes where name='TIPOCOSTO')
   drop type TIPOCOSTO
go

if exists(select 1 from systypes where name='TIPOGRUPOECOLOGICO')
   execute sp_unbindrule TIPOGRUPOECOLOGICO
go

if exists(select 1 from systypes where name='TIPOGRUPOECOLOGICO')
   drop type TIPOGRUPOECOLOGICO
go

if exists(select 1 from systypes where name='TIPOPLAZO')
   execute sp_unbindrule TIPOPLAZO
go

if exists(select 1 from systypes where name='TIPOPLAZO')
   drop type TIPOPLAZO
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

if exists (select 1 from sysobjects where id=object_id('R_FORMA') and type='R')
   drop rule  R_FORMA
go

if exists (select 1 from sysobjects where id=object_id('R_SINO') and type='R')
   drop rule  R_SINO
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOCOSTO') and type='R')
   drop rule  R_TIPOCOSTO
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOGRUPOECOLOGICO') and type='R')
   drop rule  R_TIPOGRUPOECOLOGICO
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOPLAZO') and type='R')
   drop rule  R_TIPOPLAZO
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOPROYECTO') and type='R')
   drop rule  R_TIPOPROYECTO
go

if exists (select 1 from sysobjects where id=object_id('R_TIPOUSUARIO') and type='R')
   drop rule  R_TIPOUSUARIO
go

create rule R_FORMA as
      @column in ('CU','RE','CI')
go

create rule R_SINO as
      @column in ('S','N')
go

create rule R_TIPOCOSTO as
      @column in ('CF','CV')
go

create rule R_TIPOGRUPOECOLOGICO as
      @column in ('TL','NT')
go

create rule R_TIPOPLAZO as
      @column in ('H','D','S','M','A')
go

create rule R_TIPOPROYECTO as
      @column in ('CR','CO','IN')
go

create rule R_TIPOUSUARIO as
      @column in ('AD','NA')
go

/*==============================================================*/
/* Domain: FORMA                                                */
/*==============================================================*/
create type FORMA
   from varchar(2) not null
go

execute sp_bindrule R_FORMA, FORMA
go

/*==============================================================*/
/* Domain: SINO                                                 */
/*==============================================================*/
create type SINO
   from varchar(1) not null
go

execute sp_bindrule R_SINO, SINO
go

/*==============================================================*/
/* Domain: TIPOCOSTO                                            */
/*==============================================================*/
create type TIPOCOSTO
   from varchar(2) not null
go

execute sp_bindrule R_TIPOCOSTO, TIPOCOSTO
go

/*==============================================================*/
/* Domain: TIPOGRUPOECOLOGICO                                   */
/*==============================================================*/
create type TIPOGRUPOECOLOGICO
   from varchar(2) not null
go

execute sp_bindrule R_TIPOGRUPOECOLOGICO, TIPOGRUPOECOLOGICO
go

/*==============================================================*/
/* Domain: TIPOPLAZO                                            */
/*==============================================================*/
create type TIPOPLAZO
   from varchar(1) not null
go

execute sp_bindrule R_TIPOPLAZO, TIPOPLAZO
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
/* Table: BLOQUE                                                */
/*==============================================================*/
create table BLOQUE (
   NROPROYCONTENEDOR    uniqueidentifier     not null,
   NROPROYCONTENIDO     uniqueidentifier     not null,
   CODIGOBLOQUE         numeric              not null,
   COORDENDAX           decimal(18,6)        not null,
   COORDENDAY           decimal(18,6)        not null,
   PESO                 decimal(18,6)        not null,
   ETAPA                numeric              not null,
   constraint PK_BLOQUE primary key (NROPROYCONTENEDOR, NROPROYCONTENIDO)
)
go

/*==============================================================*/
/* Table: CONFIGMAPACONFUNIDADMUESTRAL                          */
/*==============================================================*/
create table CONFIGMAPACONFUNIDADMUESTRAL (
   NROCONFIGURACIONUNIDADMUESTRAL uniqueidentifier     not null,
   NROCONFIGURACIONMAPA uniqueidentifier     not null,
   constraint PK_CONFIGMAPACONFUNIDADMUESTRA primary key nonclustered (NROCONFIGURACIONUNIDADMUESTRAL, NROCONFIGURACIONMAPA)
)
go

/*==============================================================*/
/* Index: FK_CONFIGMAPACONFUNIDADMUESTRAL                       */
/*==============================================================*/
create index FK_CONFIGMAPACONFUNIDADMUESTRAL on CONFIGMAPACONFUNIDADMUESTRAL (
NROCONFIGURACIONUNIDADMUESTRAL ASC,
NROCONFIGURACIONMAPA ASC
)
go

/*==============================================================*/
/* Table: CONFIGURACIONMAPA                                     */
/*==============================================================*/
create table CONFIGURACIONMAPA (
   NROCONFIGURACIONMAPA uniqueidentifier     not null,
   EXTREMOSURX          decimal(18,6)        not null,
   EXTREMOSURY          decimal(18,6)        not null,
   EXTREMONORTEX        decimal(18,6)        not null,
   EXTREMONORTEY        decimal(18,6)        not null,
   EXTREMOORIENTEX      decimal(18,6)        not null,
   EXTREMOORIENTEY      decimal(18,6)        not null,
   EXTREMOOCCIDENTEX    decimal(18,6)        not null,
   EXTREMOOCCIDENTEY    decimal(18,6)        not null,
   EXTREMOINICIALX      decimal(18,6)        not null,
   EXTREMOINICIALY      decimal(18,6)        not null,
   EXTREMOFINALX        decimal(18,6)        not null,
   EXTREMOFINALY        decimal(18,6)        not null,
   constraint PK_CONFIGURACIONMAPA primary key (NROCONFIGURACIONMAPA)
)
go

/*==============================================================*/
/* Index: NROCONFIGURACIONMAPA                                  */
/*==============================================================*/
create index NROCONFIGURACIONMAPA on CONFIGURACIONMAPA (
NROCONFIGURACIONMAPA ASC
)
go

/*==============================================================*/
/* Table: CONFIGURACIONUNIDADMUESTRAL                           */
/*==============================================================*/
create table CONFIGURACIONUNIDADMUESTRAL (
   NROCONFIGURACIONUNIDADMUESTRAL uniqueidentifier     not null,
   ANCHO                decimal(18,6)        not null,
   LARGO                decimal(18,6)        not null,
   RADIO                decimal(18,6)        not null,
   FORMA                FORMA                not null,
   TIPOUNIDADMUESTRAL   varchar(1)           not null
      constraint CKC_TIPOUNIDADMUESTRA_CONFIGUR check (TIPOUNIDADMUESTRAL in ('P','B')),
   constraint PK_CONFIGURACIONUNIDADMUESTRAL primary key (NROCONFIGURACIONUNIDADMUESTRAL)
)
go

/*==============================================================*/
/* Index: NROCONFIGURACIONUNIDADMUESTRAL                        */
/*==============================================================*/
create index NROCONFIGURACIONUNIDADMUESTRAL on CONFIGURACIONUNIDADMUESTRAL (
NROCONFIGURACIONUNIDADMUESTRAL ASC
)
go

/*==============================================================*/
/* Table: COSTO                                                 */
/*==============================================================*/
create table COSTO (
   NROCOSTO             uniqueidentifier     not null,
   NOMBRE               varchar(150)         null,
   DESCRIPCION          varchar(500)         null,
   TIPO                 varchar(2)           null,
   constraint PK_COSTO primary key nonclustered (NROCOSTO)
)
go

/*==============================================================*/
/* Table: DEPARTAMENTO                                          */
/*==============================================================*/
create table DEPARTAMENTO (
   CODDEPARTAMENTO      numeric              not null,
   CODPAIS              numeric              null,
   NOMBRE               varchar(1500)        not null,
   constraint PK_DEPARTAMENTO primary key (CODDEPARTAMENTO)
)
go

/*==============================================================*/
/* Index: CODDEPARTAMENTO                                       */
/*==============================================================*/
create index CODDEPARTAMENTO on DEPARTAMENTO (
CODDEPARTAMENTO ASC
)
go

/*==============================================================*/
/* Table: DOMINIO                                               */
/*==============================================================*/
create table DOMINIO (
   NRODOMINIO           uniqueidentifier     not null,
   NOMBRE               varchar(150)         not null,
   DESCRIPCION          varchar(5000)        null,
   constraint PK_DOMINIO primary key nonclustered (NRODOMINIO)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Restringe los valores que una variable de tipo descriptivo puede tener asociados, ejemplo: Variable CALIDAD, dominio: Bueno o malo.',
   'user', @CurrentUser, 'table', 'DOMINIO'
go

/*==============================================================*/
/* Index: NRODOMINIO                                            */
/*==============================================================*/
create index NRODOMINIO on DOMINIO (
NRODOMINIO ASC
)
go

/*==============================================================*/
/* Table: DOMINIOVARIABLE                                       */
/*==============================================================*/
create table DOMINIOVARIABLE (
   NROVARIABLE          uniqueidentifier     not null,
   NRODOMINIO           uniqueidentifier     not null,
   constraint PK_DOMINIOVARIABLE primary key (NROVARIABLE, NRODOMINIO)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Clave primaria en la tabla variable',
   'user', @CurrentUser, 'table', 'DOMINIOVARIABLE', 'column', 'NROVARIABLE'
go

/*==============================================================*/
/* Index: FK_DOMINIOVARIABLE                                    */
/*==============================================================*/
create index FK_DOMINIOVARIABLE on DOMINIOVARIABLE (
NROVARIABLE ASC,
NRODOMINIO ASC
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
   DIAMMINCORTE         numeric(18,6)        null,
   GRUPOECOLOGICO       TIPOGRUPOECOLOGICO   not null,
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
/* Table: ESTRATO                                               */
/*==============================================================*/
create table ESTRATO (
   CODEST               numeric              identity,
   DESCRIPESTRATO       varchar(500)         null,
   constraint PK_ESTRATO primary key nonclustered (CODEST)
)
go

/*==============================================================*/
/* Table: FORMULA                                               */
/*==============================================================*/
create table FORMULA (
   NROFORMULA           uniqueidentifier     not null,
   NROTIPOFORMULA       uniqueidentifier     not null,
   NROVARIABLE          uniqueidentifier     not null,
   EXPRESION            varchar(5000)        not null,
   NOMBRE               varchar(150)         not null,
   DESCRIPCION          varchar(5000)        null,
   constraint PK_FORMULA primary key (NROFORMULA)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Establece las formulas que se pueden asociar a un proyecto para el ingreso de expresiones personalizables por el usuario. Esta podran estar disponibles para su posterior uso en la elaboracion de uno o mas proyectos. las formulas continen uno o mas variables o parametros que se encuentran almacenadas en la relacion formula variable y se utilizaran para evaluar la expresion que esta contiene y de esta forma obtener el valor de la variable de salida asociada a la formula.',
   'user', @CurrentUser, 'table', 'FORMULA'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Clave primaria en la tabla formulario',
   'user', @CurrentUser, 'table', 'FORMULA', 'column', 'NROFORMULA'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifica el proposito con que se creo esta, y permitira filtrar formulas',
   'user', @CurrentUser, 'table', 'FORMULA', 'column', 'NROTIPOFORMULA'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Llave foranea de la tabla variable identifica cual es la variable de salida',
   'user', @CurrentUser, 'table', 'FORMULA', 'column', 'NROVARIABLE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Expresion matematica asociada a la formula. Para su evaluacion se emplea el evaluador de expresiones AleParse http://www.aleprojects.com/en/doc/parser',
   'user', @CurrentUser, 'table', 'FORMULA', 'column', 'EXPRESION'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nombre descriptivo de la formula, que permite al usuario una mejor compresion a traves de su nombre del proposito con el que se creo',
   'user', @CurrentUser, 'table', 'FORMULA', 'column', 'NOMBRE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Campo opcional que brinda un mayor grado de detalle del proposito de la formula',
   'user', @CurrentUser, 'table', 'FORMULA', 'column', 'DESCRIPCION'
go

/*==============================================================*/
/* Index: NROFORMULA                                            */
/*==============================================================*/
create index NROFORMULA on FORMULA (
NROFORMULA ASC
)
go

/*==============================================================*/
/* Table: FORMULAPROYECTO                                       */
/*==============================================================*/
create table FORMULAPROYECTO (
   NROPROY              uniqueidentifier     not null,
   NROFORMULA           uniqueidentifier     not null,
   constraint PK_FORMULAPROYECTO primary key (NROPROY, NROFORMULA)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Clave primaria en la tabla formulario',
   'user', @CurrentUser, 'table', 'FORMULAPROYECTO', 'column', 'NROFORMULA'
go

/*==============================================================*/
/* Index: FK_FORMULAPROYECTO                                    */
/*==============================================================*/
create index FK_FORMULAPROYECTO on FORMULAPROYECTO (
NROPROY ASC,
NROFORMULA ASC
)
go

/*==============================================================*/
/* Table: FORMULARIO                                            */
/*==============================================================*/
create table FORMULARIO (
   NROFORMULARIO        uniqueidentifier     not null,
   CODEST               numeric              null,
   NROUSUARIO           uniqueidentifier     not null,
   NROPROY              uniqueidentifier     not null,
   NROPARCELA           uniqueidentifier     null,
   FECHACREACION        datetime             not null,
   HORAINICIO           datetime             null,
   HORAFINAL            datetime             null,
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
/* Table: FORMULAVARIABLE                                       */
/*==============================================================*/
create table FORMULAVARIABLE (
   NROVARIABLE          uniqueidentifier     not null,
   NROFORMULA           uniqueidentifier     not null,
   constraint PK_FORMULAVARIABLE primary key (NROVARIABLE, NROFORMULA)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Parametros de entrada para la formula, contiene la llave foranea de variable y formula.',
   'user', @CurrentUser, 'table', 'FORMULAVARIABLE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Clave primaria en la tabla formulario',
   'user', @CurrentUser, 'table', 'FORMULAVARIABLE', 'column', 'NROFORMULA'
go

/*==============================================================*/
/* Index: FK_FORMULAVARIABLE                                    */
/*==============================================================*/
create index FK_FORMULAVARIABLE on FORMULAVARIABLE (
NROVARIABLE ASC,
NROFORMULA ASC
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
   NROIMAGEN            uniqueidentifier     not null,
   CODESP               uniqueidentifier     not null,
   DESCRIPCION          varchar(1000)        null,
   NOMBRE               varchar(250)         not null,
   RUTA                 varchar(1500)        not null,
   constraint PK_IMAGEN primary key (NROIMAGEN, CODESP)
)
go

/*==============================================================*/
/* Index: IMAGENID                                              */
/*==============================================================*/
create index IMAGENID on IMAGEN (
NROIMAGEN ASC
)
go

/*==============================================================*/
/* Table: LINEAINVENTARIO                                       */
/*==============================================================*/
create table LINEAINVENTARIO (
   NROLINEAINVENTARIO   uniqueidentifier     not null,
   NROFORMULARIO        uniqueidentifier     not null,
   NROTIPOLINEAINV      uniqueidentifier     not null,
   constraint PK_LINEAINVENTARIO primary key nonclustered (NROLINEAINVENTARIO)
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
/* Table: LINEAINVENTARIOESPECIE                                */
/*==============================================================*/
create table LINEAINVENTARIOESPECIE (
   CODESP               uniqueidentifier     not null,
   NROLINEAINVENTARIO   uniqueidentifier     not null,
   constraint PK_LINEAINVENTARIOESPECIE primary key (CODESP, NROLINEAINVENTARIO)
)
go

/*==============================================================*/
/* Index: FK_LINEAINVENTARIOESPECIE                             */
/*==============================================================*/
create index FK_LINEAINVENTARIOESPECIE on LINEAINVENTARIOESPECIE (
CODESP ASC,
NROLINEAINVENTARIO ASC
)
go

/*==============================================================*/
/* Table: LINEAINVENTARIOVARIABLE                               */
/*==============================================================*/
create table LINEAINVENTARIOVARIABLE (
   NROVARIABLE          uniqueidentifier     not null,
   LINEAINV             uniqueidentifier     not null,
   VALOR                varchar(5000)        not null,
   constraint PK_LINEAINVENTARIOVARIABLE primary key (NROVARIABLE, LINEAINV)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Clave primaria en la tabla variable',
   'user', @CurrentUser, 'table', 'LINEAINVENTARIOVARIABLE', 'column', 'NROVARIABLE'
go

/*==============================================================*/
/* Index: FK_LINEAINVENTARIOVARIABLE                            */
/*==============================================================*/
create index FK_LINEAINVENTARIOVARIABLE on LINEAINVENTARIOVARIABLE (
NROVARIABLE ASC,
LINEAINV ASC
)
go

/*==============================================================*/
/* Table: LISTADODECOSTOS                                       */
/*==============================================================*/
create table LISTADODECOSTOS (
   NROCOSTO             uniqueidentifier     not null,
   NROPROY              uniqueidentifier     not null,
   VALOR                decimal(18,6)        not null,
   constraint PK_LISTADODECOSTOS primary key (NROCOSTO, NROPROY)
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
   PESO                 decimal(18,6)        null,
   TAMANIOMUESTRA       decimal(18,6)        null,
   constraint PK_LISTADODEESTRATOS primary key (NROPROY, CODEST)
)
go

/*==============================================================*/
/* Table: MUNICIPIO                                             */
/*==============================================================*/
create table MUNICIPIO (
   CODMUNICIPIO         numeric              not null,
   CODDEPARTAMENTO      numeric              null,
   NOMBRE               varchar(1500)        not null,
   constraint PK_MUNICIPIO primary key (CODMUNICIPIO)
)
go

/*==============================================================*/
/* Index: CODMUNICIPIO                                          */
/*==============================================================*/
create index CODMUNICIPIO on MUNICIPIO (
CODMUNICIPIO ASC
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
/* Table: PAIS                                                  */
/*==============================================================*/
create table PAIS (
   CODPAIS              numeric              not null,
   NOMBRE               varchar(1500)        not null,
   constraint PK_PAIS primary key (CODPAIS)
)
go

/*==============================================================*/
/* Index: CODPAIS                                               */
/*==============================================================*/
create index CODPAIS on PAIS (
CODPAIS ASC
)
go

/*==============================================================*/
/* Table: PARCELA                                               */
/*==============================================================*/
create table PARCELA (
   NROPARCELA           uniqueidentifier     not null,
   NROPROY              uniqueidentifier     not null,
   COORDENAX            decimal(18,6)        not null,
   COORDENAY            decimal(18,6)        not null,
   CODIGOPARCELA        numeric              not null,
   LINEAPARCELA         numeric              not null,
   constraint PK_PARCELA primary key (NROPARCELA)
)
go

/*==============================================================*/
/* Index: NROPARCELA                                            */
/*==============================================================*/
create index NROPARCELA on PARCELA (
NROPARCELA ASC
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
   CODMUNICIPIO         numeric              not null,
   NROCONFIGURACIONMAPA uniqueidentifier     null,
   FECHA                datetime             not null,
   NOMBRE               varchar(150)         not null,
   DETALLELUGAR         varchar(1500)        not null,
   DESCRIPCION          varchar(5000)        null,
   PRESUPUESTO          decimal(18,6)        not null,
   PLAZO                decimal(18,6)        not null,
   TIPOPLAZO            TIPOPLAZO            not null,
   TIPOPROYECTO         TIPOPROYECTO         not null,
   NUMEROPERSONAS       numeric              not null,
   CONFIANZA            decimal(18,6)        not null,
   NUMEROPARCELAS       numeric(18,0)        not null,
   NUMEROPARCELASAMUESTREAR numeric(18,0)        not null,
   TAMANIOPARCELA       decimal(18,6)        not null,
   AREATOTAL            decimal(18,6)        not null,
   INTMUESTREO          decimal(18,6)        not null,
   AREAMUESTREAR        decimal(18,6)        not null,
   LIMITINFDAP          decimal(18,6)        not null,
   AREAREGENERACION     decimal(18,6)        not null,
   FACTORDEFORMA        decimal(18,6)        not null,
   ETAPA                numeric              not null,
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
/* Table: TIPODISENOMUESTRAL                                    */
/*==============================================================*/
create table TIPODISENOMUESTRAL (
   NOMTIPODISEMUEST     varchar(100)         not null,
   DESCRIPTIPODISEMUEST varchar(500)         null,
   constraint PK_TIPODISENOMUESTRAL primary key nonclustered (NOMTIPODISEMUEST)
)
go

/*==============================================================*/
/* Table: TIPOFORMULA                                           */
/*==============================================================*/
create table TIPOFORMULA (
   NROTIPOFORMULA       uniqueidentifier     not null,
   NOMBRETIPO           varchar(150)         not null,
   DESCRIPCION          varchar(5000)        null,
   constraint PK_TIPOFORMULA primary key (NROTIPOFORMULA)
)
go

/*==============================================================*/
/* Index: NROTIPOFORMULA                                        */
/*==============================================================*/
create index NROTIPOFORMULA on TIPOFORMULA (
NROTIPOFORMULA ASC
)
go

/*==============================================================*/
/* Table: TIPOLINEAINVENTARIO                                   */
/*==============================================================*/
create table TIPOLINEAINVENTARIO (
   NROTIPOLINEAINV      uniqueidentifier     not null,
   NOMBRE               varchar(150)         not null,
   DESCRIPCION          varchar(5000)        null,
   REQUIEREESPECIE      SINO                 not null,
   constraint PK_TIPOLINEAINVENTARIO primary key nonclustered (NROTIPOLINEAINV)
)
go

/*==============================================================*/
/* Index: NROTIPOLINEINV                                        */
/*==============================================================*/
create index NROTIPOLINEINV on TIPOLINEAINVENTARIO (
NROTIPOLINEAINV ASC
)
go

/*==============================================================*/
/* Table: TIPOLINEAINVENTARIOPROYECTO                           */
/*==============================================================*/
create table TIPOLINEAINVENTARIOPROYECTO (
   NROTIPOLINEAINV      uniqueidentifier     not null,
   NROPROY              uniqueidentifier     not null,
   constraint PK_TIPOLINEAINVENTARIOPROYECTO primary key (NROTIPOLINEAINV, NROPROY)
)
go

/*==============================================================*/
/* Index: FK_TIPOLINEAINVENTARIOPROYECTO                        */
/*==============================================================*/
create index FK_TIPOLINEAINVENTARIOPROYECTO on TIPOLINEAINVENTARIOPROYECTO (
NROTIPOLINEAINV ASC,
NROPROY ASC
)
go

/*==============================================================*/
/* Table: TIPOLINEAINVENTARIOVARIABLE                           */
/*==============================================================*/
create table TIPOLINEAINVENTARIOVARIABLE (
   NROTIPOLINEAINV      uniqueidentifier     not null,
   NROVARIABLE          uniqueidentifier     not null,
   constraint PK_TIPOLINEAINVENTARIOVARIABLE primary key (NROTIPOLINEAINV, NROVARIABLE)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Clave primaria en la tabla variable',
   'user', @CurrentUser, 'table', 'TIPOLINEAINVENTARIOVARIABLE', 'column', 'NROVARIABLE'
go

/*==============================================================*/
/* Index: FK_TIPOLINEAINVENTARIOVARIABLE                        */
/*==============================================================*/
create index FK_TIPOLINEAINVENTARIOVARIABLE on TIPOLINEAINVENTARIOVARIABLE (
NROTIPOLINEAINV ASC,
NROVARIABLE ASC
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
   NOMBREUSUARIO        varchar(100)         not null,
   CONTRASENA           varchar(1000)        not null,
   CEDULA               numeric              not null,
   TIPOUSUARIO          TIPOUSUARIO          not null,
   constraint PK_USUARIO primary key nonclustered (NROUSUARIO)
)
go

/*==============================================================*/
/* Table: VARIABLE                                              */
/*==============================================================*/
create table VARIABLE (
   NROVARIABLE          uniqueidentifier     not null,
   NOMBRE               varchar(100)         not null,
   DESCRIPCION          varchar(5000)        null,
   VARIABLEENTRADASALIDA SINO                 not null,
   VARIABLEDESCRIPTIVA  SINO                 not null,
   MANEJADOMINIO        SINO                 not null,
   MULTIPLEDOMINIO      SINO                 not null,
   constraint PK_VARIABLE primary key (NROVARIABLE)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Establece las variables involucradas en el desarrollo de una expresion asociada con una formula. Las variables pueden ser de entrada o salida, que es lo mismo que si son calculadas o no. Las variables pueden ser descriptivas, o texto y puede estar restrigindas a un dominio, ejemplo: la variable CALIDAD, es descriptiva y esta amarrada a un dominio',
   'user', @CurrentUser, 'table', 'VARIABLE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Clave primaria en la tabla variable',
   'user', @CurrentUser, 'table', 'VARIABLE', 'column', 'NROVARIABLE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Establece el nombre la variable empleado para la construccion de expresiones asociados a la formula',
   'user', @CurrentUser, 'table', 'VARIABLE', 'column', 'NOMBRE'
go

/*==============================================================*/
/* Index: NROVARIABLE                                           */
/*==============================================================*/
create index NROVARIABLE on VARIABLE (
NROVARIABLE ASC
)
go

alter table BLOQUE
   add constraint FK_BLOQUE_TIENE_PROYECTO foreign key (NROPROYCONTENIDO)
      references PROYECTO (NROPROY)
go

alter table BLOQUE
   add constraint FK_PROYECTO_CONTENEDOR foreign key (NROPROYCONTENEDOR)
      references PROYECTO (NROPROY)
go

alter table CONFIGMAPACONFUNIDADMUESTRAL
   add constraint FK_CONFIGMAPA_TIENE_CONFIGUNIDADMUESTRAL foreign key (NROCONFIGURACIONUNIDADMUESTRAL)
      references CONFIGURACIONUNIDADMUESTRAL (NROCONFIGURACIONUNIDADMUESTRAL)
go

alter table CONFIGMAPACONFUNIDADMUESTRAL
   add constraint FK_CONFIGUNIDADMUESTRALTIENECONFIGMAPA foreign key (NROCONFIGURACIONMAPA)
      references CONFIGURACIONMAPA (NROCONFIGURACIONMAPA)
go

alter table DEPARTAMENTO
   add constraint FK_DEPARTAMENTO_PERTENECE_PAIS foreign key (CODPAIS)
      references PAIS (CODPAIS)
go

alter table DOMINIOVARIABLE
   add constraint FK_DOMINIO_APLICA_VARIABLE foreign key (NRODOMINIO)
      references DOMINIO (NRODOMINIO)
go

alter table DOMINIOVARIABLE
   add constraint FK_VARIABLE_TIENE_DOMINIO foreign key (NROVARIABLE)
      references VARIABLE (NROVARIABLE)
go

alter table ESPECIE
   add constraint FK_ESPECIE_PERTENECE_GRUPOCOMERCIAL foreign key (GRUPOCOM)
      references GRUPOCOMERCIAL (GRUPOCOM)
go

alter table FORMULA
   add constraint FK_FORMULA_ES_DE_TIPO_FORMULA foreign key (NROTIPOFORMULA)
      references TIPOFORMULA (NROTIPOFORMULA)
go

alter table FORMULA
   add constraint FK_FORMULA_VARIABLE_SALIDA foreign key (NROVARIABLE)
      references VARIABLE (NROVARIABLE)
go

alter table FORMULAPROYECTO
   add constraint FK_FORMULA_SE_APLICA_A_PROYECTOS foreign key (NROFORMULA)
      references FORMULA (NROFORMULA)
go

alter table FORMULAPROYECTO
   add constraint FK_PROYECTO_TIENE_FORMULA foreign key (NROPROY)
      references PROYECTO (NROPROY)
go

alter table FORMULARIO
   add constraint FK_FORMULARIO_TIENE_ESTRATO foreign key (CODEST)
      references ESTRATO (CODEST)
go

alter table FORMULARIO
   add constraint FK_FORMULARIO_TIENE_PARCELA foreign key (NROPARCELA)
      references PARCELA (NROPARCELA)
go

alter table FORMULARIO
   add constraint FK_PROYECTO_TIENE_FORMULARIOS foreign key (NROPROY)
      references PROYECTO (NROPROY)
go

alter table FORMULARIO
   add constraint FK_USUARIO_CREA_FOMULARIO foreign key (NROUSUARIO)
      references USUARIO (NROUSUARIO)
go

alter table FORMULAVARIABLE
   add constraint FK_FORMULA_TIENE_VARIABLE foreign key (NROFORMULA)
      references FORMULA (NROFORMULA)
go

alter table FORMULAVARIABLE
   add constraint FK_VARIABLE_SE_APLICA_FORMULA foreign key (NROVARIABLE)
      references VARIABLE (NROVARIABLE)
go

alter table IMAGEN
   add constraint FK_ESPECIE_TIENE_IMAGEN foreign key (CODESP)
      references ESPECIE (CODESP)
         on update cascade on delete cascade
go

alter table LINEAINVENTARIO
   add constraint FK_FORMULARIO_CREA_LINEAINEVNTARIO foreign key (NROFORMULARIO)
      references FORMULARIO (NROFORMULARIO)
go

alter table LINEAINVENTARIO
   add constraint FK_LINEA_INVENTARIO_ES_DE_TIPOLINEAINV foreign key (NROTIPOLINEAINV)
      references TIPOLINEAINVENTARIO (NROTIPOLINEAINV)
go

alter table LINEAINVENTARIOESPECIE
   add constraint FK_ESPECIE_PERTENECE_LINEAINVENTARIO foreign key (CODESP)
      references ESPECIE (CODESP)
go

alter table LINEAINVENTARIOESPECIE
   add constraint FK_LINEA_INVENTARIO_TIENE_ESPECIE foreign key (NROLINEAINVENTARIO)
      references LINEAINVENTARIO (NROLINEAINVENTARIO)
go

alter table LINEAINVENTARIOVARIABLE
   add constraint FK_LINEAINVENTARIO_TIENE_VARIABLES foreign key (NROVARIABLE)
      references VARIABLE (NROVARIABLE)
go

alter table LINEAINVENTARIOVARIABLE
   add constraint FK_VARIABLES_SE_APLICA_LINEAINVENTARIO foreign key (LINEAINV)
      references LINEAINVENTARIO (NROLINEAINVENTARIO)
go

alter table LISTADODECOSTOS
   add constraint FK_LISTADODECOSTOS_TIENE_COSTO foreign key (NROCOSTO)
      references COSTO (NROCOSTO)
go

alter table LISTADODECOSTOS
   add constraint FK_PROYECTO_TIENE_LISTADODECOSTOS foreign key (NROPROY)
      references PROYECTO (NROPROY)
go

alter table LISTADODEESPECIES
   add constraint FK_LISTADODEESPECIES_TIENE_ESPECIE foreign key (CODESP)
      references ESPECIE (CODESP)
go

alter table LISTADODEESPECIES
   add constraint FK_PROYECTO_TIENE_LISTADODEESPECIE foreign key (NROPROY)
      references PROYECTO (NROPROY)
go

alter table LISTADODEESTRATOS
   add constraint FK_LISTADEESTRATOS_TIENE_ESTRATOS foreign key (CODEST)
      references ESTRATO (CODEST)
go

alter table LISTADODEESTRATOS
   add constraint FK_PROYECTO_TIENE_LISTADODEESTRATOS foreign key (NROPROY)
      references PROYECTO (NROPROY)
go

alter table MUNICIPIO
   add constraint FK_MUNICIPIO_PERTENECE_DEPARTAMENTO foreign key (CODDEPARTAMENTO)
      references DEPARTAMENTO (CODDEPARTAMENTO)
go

alter table PARCELA
   add constraint FK_PROYECTO_TIENE_PARCELAS foreign key (NROPROY)
      references PROYECTO (NROPROY)
go

alter table PROYECTO
   add constraint FK_PROYECTO_ES_DEL_TIPODISENIOMUEST foreign key (NOMTIPODISEMUEST)
      references TIPODISENOMUESTRAL (NOMTIPODISEMUEST)
go

alter table PROYECTO
   add constraint FK_PROYECTO_TIENE_CONFIGURACIONMAPA foreign key (NROCONFIGURACIONMAPA)
      references CONFIGURACIONMAPA (NROCONFIGURACIONMAPA)
go

alter table PROYECTO
   add constraint FK_PROYECTO_TIENE_MUNICIPIO foreign key (CODMUNICIPIO)
      references MUNICIPIO (CODMUNICIPIO)
go

alter table PROYECTO
   add constraint FK_PROYECTO_TIENE_OBJETIVOINVENTARIO foreign key (NOMBRETIPOINV)
      references OBJETIVOINVENTARIO (NOMBRETIPOINV)
go

alter table PROYECTO
   add constraint FK_USUARIO_CREA_PROYECTO foreign key (NROUSUARIO)
      references USUARIO (NROUSUARIO)
go

alter table TIPOLINEAINVENTARIOPROYECTO
   add constraint FK_PROYECTO_TIENE_TIPOLINEAINV foreign key (NROTIPOLINEAINV)
      references TIPOLINEAINVENTARIO (NROTIPOLINEAINV)
go

alter table TIPOLINEAINVENTARIOPROYECTO
   add constraint FK_TIPOLINEAINV_SE_APLICA_A_PROYECTO foreign key (NROPROY)
      references PROYECTO (NROPROY)
go

alter table TIPOLINEAINVENTARIOVARIABLE
   add constraint FK_TIPOLINEAINVVAR_PERTENECE_A_TIPOLINEAINV foreign key (NROTIPOLINEAINV)
      references TIPOLINEAINVENTARIO (NROTIPOLINEAINV)
go

alter table TIPOLINEAINVENTARIOVARIABLE
   add constraint FK_TIPOLINEAINVVAR_TIENE_VARIABLE foreign key (NROVARIABLE)
      references VARIABLE (NROVARIABLE)
go

