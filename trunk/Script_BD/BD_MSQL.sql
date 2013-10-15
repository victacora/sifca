USE [C:\ANTEPROYECTO\PROTOTIPO\SIFCA_APP\SIFCA\SIFCA\BIN\DEBUG\SIFCA_BD.MDF]
GO
/****** Object:  ForeignKey [FK_ESPECIE_PERTENECE_GRUPOCOM]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ESPECIE_PERTENECE_GRUPOCOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESPECIE]'))
ALTER TABLE [dbo].[ESPECIE] DROP CONSTRAINT [FK_ESPECIE_PERTENECE_GRUPOCOM]
GO
/****** Object:  ForeignKey [FK_IMAGEN_IMAGENE_ESPECIE]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IMAGEN_IMAGENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[IMAGEN]'))
ALTER TABLE [dbo].[IMAGEN] DROP CONSTRAINT [FK_IMAGEN_IMAGENE_ESPECIE]
GO
/****** Object:  ForeignKey [FK_TRANSACC_REGISTRA_USUARIO]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSACC_REGISTRA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSACCION]'))
ALTER TABLE [dbo].[TRANSACCION] DROP CONSTRAINT [FK_TRANSACC_REGISTRA_USUARIO]
GO
/****** Object:  ForeignKey [FK_PROYECTO_CREA_USUARIO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CREA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] DROP CONSTRAINT [FK_PROYECTO_CREA_USUARIO]
GO
/****** Object:  ForeignKey [FK_PROYECTO_ES_OBJETIVO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_ES_OBJETIVO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] DROP CONSTRAINT [FK_PROYECTO_ES_OBJETIVO]
GO
/****** Object:  ForeignKey [FK_PROYECTO_REALIZA_TIPODISE]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_REALIZA_TIPODISE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] DROP CONSTRAINT [FK_PROYECTO_REALIZA_TIPODISE]
GO
/****** Object:  ForeignKey [FK_PROYECTO_CONTENEDOR]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA] DROP CONSTRAINT [FK_PROYECTO_CONTENEDOR]
GO
/****** Object:  ForeignKey [FK_PROYECTO_CONTENIDOS]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENIDOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA] DROP CONSTRAINT [FK_PROYECTO_CONTENIDOS]
GO
/****** Object:  ForeignKey [FK_FORMULAR_DESARROLL_PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_DESARROLL_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] DROP CONSTRAINT [FK_FORMULAR_DESARROLL_PROYECTO]
GO
/****** Object:  ForeignKey [FK_FORMULAR_ES_REPONS_USUARIO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_ES_REPONS_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] DROP CONSTRAINT [FK_FORMULAR_ES_REPONS_USUARIO]
GO
/****** Object:  ForeignKey [FK_FORMULAR_MANEJA_ESTRATO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_MANEJA_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] DROP CONSTRAINT [FK_FORMULAR_MANEJA_ESTRATO]
GO
/****** Object:  ForeignKey [FK_LISTADOD_LISTAESTR_ESTRATO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTAESTR_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS] DROP CONSTRAINT [FK_LISTADOD_LISTAESTR_ESTRATO]
GO
/****** Object:  ForeignKey [FK_LISTAESTRATOS_PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTAESTRATOS_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS] DROP CONSTRAINT [FK_LISTAESTRATOS_PROYECTO]
GO
/****** Object:  ForeignKey [FK_LISTADOD_LISTADODE_ESPECIE]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTADODE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES] DROP CONSTRAINT [FK_LISTADOD_LISTADODE_ESPECIE]
GO
/****** Object:  ForeignKey [FK_LISTADOESPECIES_PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOESPECIES_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES] DROP CONSTRAINT [FK_LISTADOESPECIES_PROYECTO]
GO
/****** Object:  ForeignKey [FK_LINEAREG_COMPLETA_FORMULAR]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_COMPLETA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION] DROP CONSTRAINT [FK_LINEAREG_COMPLETA_FORMULAR]
GO
/****** Object:  ForeignKey [FK_LINEAREG_EVALUACIO_ESPECIE]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_EVALUACIO_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION] DROP CONSTRAINT [FK_LINEAREG_EVALUACIO_ESPECIE]
GO
/****** Object:  ForeignKey [FK_LINEANOM_RECOLECTA_FORMULAR]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEANOM_RECOLECTA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEANOMADERABLES]'))
ALTER TABLE [dbo].[LINEANOMADERABLES] DROP CONSTRAINT [FK_LINEANOM_RECOLECTA_FORMULAR]
GO
/****** Object:  ForeignKey [FK_LINEAINV_ASOCIADO_ESTADOSA]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_ASOCIADO_ESTADOSA]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_ASOCIADO_ESTADOSA]
GO
/****** Object:  ForeignKey [FK_LINEAINV_CONTIENE_ESPECIE]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_CONTIENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_CONTIENE_ESPECIE]
GO
/****** Object:  ForeignKey [FK_LINEAINV_LLENA_FORMULAR]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_LLENA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_LLENA_FORMULAR]
GO
/****** Object:  ForeignKey [FK_LINEAINV_POSEE_CALIDAD]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_POSEE_CALIDAD]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_POSEE_CALIDAD]
GO
/****** Object:  ForeignKey [FK_USO_TIPOUSO_TIPODEUS]    Script Date: 10/13/2013 20:44:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_TIPOUSO_TIPODEUS]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO] DROP CONSTRAINT [FK_USO_TIPOUSO_TIPODEUS]
GO
/****** Object:  ForeignKey [FK_USO_USADOPOR_LINEANOM]    Script Date: 10/13/2013 20:44:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_USADOPOR_LINEANOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO] DROP CONSTRAINT [FK_USO_USADOPOR_LINEANOM]
GO
/****** Object:  Table [dbo].[USO]    Script Date: 10/13/2013 20:44:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_TIPOUSO_TIPODEUS]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO] DROP CONSTRAINT [FK_USO_TIPOUSO_TIPODEUS]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_USADOPOR_LINEANOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO] DROP CONSTRAINT [FK_USO_USADOPOR_LINEANOM]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USO]') AND type in (N'U'))
DROP TABLE [dbo].[USO]
GO
/****** Object:  Table [dbo].[LINEAINVENTARIO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_ASOCIADO_ESTADOSA]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_ASOCIADO_ESTADOSA]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_CONTIENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_CONTIENE_ESPECIE]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_LLENA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_LLENA_FORMULAR]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_POSEE_CALIDAD]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] DROP CONSTRAINT [FK_LINEAINV_POSEE_CALIDAD]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]') AND type in (N'U'))
DROP TABLE [dbo].[LINEAINVENTARIO]
GO
/****** Object:  Table [dbo].[LINEANOMADERABLES]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEANOM_RECOLECTA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEANOMADERABLES]'))
ALTER TABLE [dbo].[LINEANOMADERABLES] DROP CONSTRAINT [FK_LINEANOM_RECOLECTA_FORMULAR]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LINEANOMADERABLES]') AND type in (N'U'))
DROP TABLE [dbo].[LINEANOMADERABLES]
GO
/****** Object:  Table [dbo].[LINEAREGENERACION]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_COMPLETA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION] DROP CONSTRAINT [FK_LINEAREG_COMPLETA_FORMULAR]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_EVALUACIO_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION] DROP CONSTRAINT [FK_LINEAREG_EVALUACIO_ESPECIE]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]') AND type in (N'U'))
DROP TABLE [dbo].[LINEAREGENERACION]
GO
/****** Object:  Table [dbo].[LISTADODEESPECIES]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTADODE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES] DROP CONSTRAINT [FK_LISTADOD_LISTADODE_ESPECIE]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOESPECIES_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES] DROP CONSTRAINT [FK_LISTADOESPECIES_PROYECTO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]') AND type in (N'U'))
DROP TABLE [dbo].[LISTADODEESPECIES]
GO
/****** Object:  Table [dbo].[LISTADODEESTRATOS]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTAESTR_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS] DROP CONSTRAINT [FK_LISTADOD_LISTAESTR_ESTRATO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTAESTRATOS_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS] DROP CONSTRAINT [FK_LISTAESTRATOS_PROYECTO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]') AND type in (N'U'))
DROP TABLE [dbo].[LISTADODEESTRATOS]
GO
/****** Object:  Table [dbo].[FORMULARIO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_DESARROLL_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] DROP CONSTRAINT [FK_FORMULAR_DESARROLL_PROYECTO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_ES_REPONS_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] DROP CONSTRAINT [FK_FORMULAR_ES_REPONS_USUARIO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_MANEJA_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] DROP CONSTRAINT [FK_FORMULAR_MANEJA_ESTRATO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FORMULARIO]') AND type in (N'U'))
DROP TABLE [dbo].[FORMULARIO]
GO
/****** Object:  Table [dbo].[PROYECTOSPORETAPA]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA] DROP CONSTRAINT [FK_PROYECTO_CONTENEDOR]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENIDOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA] DROP CONSTRAINT [FK_PROYECTO_CONTENIDOS]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]') AND type in (N'U'))
DROP TABLE [dbo].[PROYECTOSPORETAPA]
GO
/****** Object:  Table [dbo].[PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CREA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] DROP CONSTRAINT [FK_PROYECTO_CREA_USUARIO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_ES_OBJETIVO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] DROP CONSTRAINT [FK_PROYECTO_ES_OBJETIVO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_REALIZA_TIPODISE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] DROP CONSTRAINT [FK_PROYECTO_REALIZA_TIPODISE]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROYECTO]') AND type in (N'U'))
DROP TABLE [dbo].[PROYECTO]
GO
/****** Object:  Table [dbo].[TRANSACCION]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSACC_REGISTRA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSACCION]'))
ALTER TABLE [dbo].[TRANSACCION] DROP CONSTRAINT [FK_TRANSACC_REGISTRA_USUARIO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRANSACCION]') AND type in (N'U'))
DROP TABLE [dbo].[TRANSACCION]
GO
/****** Object:  Table [dbo].[IMAGEN]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IMAGEN_IMAGENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[IMAGEN]'))
ALTER TABLE [dbo].[IMAGEN] DROP CONSTRAINT [FK_IMAGEN_IMAGENE_ESPECIE]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IMAGEN]') AND type in (N'U'))
DROP TABLE [dbo].[IMAGEN]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USUARIO]') AND type in (N'U'))
DROP TABLE [dbo].[USUARIO]
GO
/****** Object:  Table [dbo].[ESPECIE]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ESPECIE_PERTENECE_GRUPOCOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESPECIE]'))
ALTER TABLE [dbo].[ESPECIE] DROP CONSTRAINT [FK_ESPECIE_PERTENECE_GRUPOCOM]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESPECIE]') AND type in (N'U'))
DROP TABLE [dbo].[ESPECIE]
GO
/****** Object:  Table [dbo].[ESTADOSANITARIO]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESTADOSANITARIO]') AND type in (N'U'))
DROP TABLE [dbo].[ESTADOSANITARIO]
GO
/****** Object:  Table [dbo].[ESTRATO]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESTRATO]') AND type in (N'U'))
DROP TABLE [dbo].[ESTRATO]
GO
/****** Object:  Table [dbo].[OBJETIVOINVENTARIO]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OBJETIVOINVENTARIO]') AND type in (N'U'))
DROP TABLE [dbo].[OBJETIVOINVENTARIO]
GO
/****** Object:  Table [dbo].[GRUPOCOMERCIAL]    Script Date: 10/13/2013 20:44:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GRUPOCOMERCIAL]') AND type in (N'U'))
DROP TABLE [dbo].[GRUPOCOMERCIAL]
GO
/****** Object:  StoredProcedure [dbo].[sp_BackupDB]    Script Date: 10/13/2013 20:44:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_BackupDB]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_BackupDB]
GO
/****** Object:  UserDefinedDataType [dbo].[TIPOARBOL]    Script Date: 10/13/2013 20:44:32 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOARBOL' AND ss.name = N'dbo')
DROP TYPE [dbo].[TIPOARBOL]
GO
/****** Object:  Table [dbo].[TIPODEUSO]    Script Date: 10/13/2013 20:44:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIPODEUSO]') AND type in (N'U'))
DROP TABLE [dbo].[TIPODEUSO]
GO
/****** Object:  Table [dbo].[TIPODISENOMUESTRAL]    Script Date: 10/13/2013 20:44:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIPODISENOMUESTRAL]') AND type in (N'U'))
DROP TABLE [dbo].[TIPODISENOMUESTRAL]
GO
/****** Object:  UserDefinedDataType [dbo].[TIPOOPERACION]    Script Date: 10/13/2013 20:44:32 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOOPERACION' AND ss.name = N'dbo')
DROP TYPE [dbo].[TIPOOPERACION]
GO
/****** Object:  UserDefinedDataType [dbo].[TIPOPROYECTO]    Script Date: 10/13/2013 20:44:32 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOPROYECTO' AND ss.name = N'dbo')
DROP TYPE [dbo].[TIPOPROYECTO]
GO
/****** Object:  UserDefinedDataType [dbo].[TIPOUSUARIO]    Script Date: 10/13/2013 20:44:32 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOUSUARIO' AND ss.name = N'dbo')
DROP TYPE [dbo].[TIPOUSUARIO]
GO
/****** Object:  Table [dbo].[TSTUDENT]    Script Date: 10/13/2013 20:44:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TSTUDENT]') AND type in (N'U'))
DROP TABLE [dbo].[TSTUDENT]
GO
/****** Object:  Table [dbo].[CALIDAD]    Script Date: 10/13/2013 20:44:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CALIDAD]') AND type in (N'U'))
DROP TABLE [dbo].[CALIDAD]
GO
/****** Object:  Rule [dbo].[R_TIPOARBOL]    Script Date: 10/13/2013 20:44:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOARBOL]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
DROP RULE [dbo].[R_TIPOARBOL]
GO
/****** Object:  Rule [dbo].[R_TIPOOPERACION]    Script Date: 10/13/2013 20:44:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOOPERACION]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
DROP RULE [dbo].[R_TIPOOPERACION]
GO
/****** Object:  Rule [dbo].[R_TIPOPROYECTO]    Script Date: 10/13/2013 20:44:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOPROYECTO]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
DROP RULE [dbo].[R_TIPOPROYECTO]
GO
/****** Object:  Rule [dbo].[R_TIPOUSUARIO]    Script Date: 10/13/2013 20:44:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOUSUARIO]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
DROP RULE [dbo].[R_TIPOUSUARIO]
GO
/****** Object:  Rule [dbo].[R_TIPOUSUARIO]    Script Date: 10/13/2013 20:44:27 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOUSUARIO]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
EXEC dbo.sp_executesql N'
create rule [dbo].[R_TIPOUSUARIO] as
      @column in (''AD'',''NA'')
'
GO
/****** Object:  Rule [dbo].[R_TIPOPROYECTO]    Script Date: 10/13/2013 20:44:27 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOPROYECTO]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
EXEC dbo.sp_executesql N'
create rule [dbo].[R_TIPOPROYECTO] as
      @column in (''CR'',''CO'',''IN'')
'
GO
/****** Object:  Rule [dbo].[R_TIPOOPERACION]    Script Date: 10/13/2013 20:44:27 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOOPERACION]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
EXEC dbo.sp_executesql N'
create rule [dbo].[R_TIPOOPERACION] as
      @column in (''I'',''A'',''E'')
'
GO
/****** Object:  Rule [dbo].[R_TIPOARBOL]    Script Date: 10/13/2013 20:44:27 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[R_TIPOARBOL]') AND OBJECTPROPERTY(object_id, N'IsRule') = 1)
EXEC dbo.sp_executesql N'
create rule [dbo].[R_TIPOARBOL] as
      @column in (''NBF'',''BFB'')
'
GO
/****** Object:  Table [dbo].[CALIDAD]    Script Date: 10/13/2013 20:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CALIDAD]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CALIDAD](
	[CODCALIDAD] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DESCRIPCALIDAD] [varchar](500) NULL,
 CONSTRAINT [PK_CALIDAD] PRIMARY KEY NONCLUSTERED 
(
	[CODCALIDAD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CALIDAD] ON
INSERT [dbo].[CALIDAD] ([CODCALIDAD], [DESCRIPCALIDAD]) VALUES (CAST(1 AS Numeric(18, 0)), N'Arbol sin calidad')
INSERT [dbo].[CALIDAD] ([CODCALIDAD], [DESCRIPCALIDAD]) VALUES (CAST(2 AS Numeric(18, 0)), N'Fuste tortuoso con defectos graves en su estructura')
INSERT [dbo].[CALIDAD] ([CODCALIDAD], [DESCRIPCALIDAD]) VALUES (CAST(3 AS Numeric(18, 0)), N'Fuste ligeramente corvado con defectos leves')
INSERT [dbo].[CALIDAD] ([CODCALIDAD], [DESCRIPCALIDAD]) VALUES (CAST(4 AS Numeric(18, 0)), N'Fuste recto sin defectos fisicos')
SET IDENTITY_INSERT [dbo].[CALIDAD] OFF
/****** Object:  Table [dbo].[TSTUDENT]    Script Date: 10/13/2013 20:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TSTUDENT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TSTUDENT](
	[N] [numeric](18, 0) NOT NULL,
	[ALPHA] [decimal](18, 3) NOT NULL,
	[VALOR] [decimal](18, 3) NOT NULL,
 CONSTRAINT [PK_TSTUDENT] PRIMARY KEY NONCLUSTERED 
(
	[N] ASC,
	[ALPHA] ASC,
	[VALOR] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  UserDefinedDataType [dbo].[TIPOUSUARIO]    Script Date: 10/13/2013 20:44:32 ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOUSUARIO' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TIPOUSUARIO] FROM [char](2) NOT NULL
GO
/****** Object:  UserDefinedDataType [dbo].[TIPOPROYECTO]    Script Date: 10/13/2013 20:44:32 ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOPROYECTO' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TIPOPROYECTO] FROM [varchar](2) NOT NULL
GO
/****** Object:  UserDefinedDataType [dbo].[TIPOOPERACION]    Script Date: 10/13/2013 20:44:32 ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOOPERACION' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TIPOOPERACION] FROM [char](1) NOT NULL
GO
/****** Object:  Table [dbo].[TIPODISENOMUESTRAL]    Script Date: 10/13/2013 20:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIPODISENOMUESTRAL]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TIPODISENOMUESTRAL](
	[NOMTIPODISEMUEST] [varchar](100) NOT NULL,
	[DESCRIPTIPODISEMUEST] [varchar](500) NULL,
 CONSTRAINT [PK_TIPODISENOMUESTRAL] PRIMARY KEY NONCLUSTERED 
(
	[NOMTIPODISEMUEST] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TIPODISENOMUESTRAL] ([NOMTIPODISEMUEST], [DESCRIPTIPODISEMUEST]) VALUES (N'SI', N'Diseño simple')
INSERT [dbo].[TIPODISENOMUESTRAL] ([NOMTIPODISEMUEST], [DESCRIPTIPODISEMUEST]) VALUES (N'ES', N'Diseño estratificado')
/****** Object:  Table [dbo].[TIPODEUSO]    Script Date: 10/13/2013 20:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIPODEUSO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TIPODEUSO](
	[NOMBRETIPOUSO] [varchar](100) NOT NULL,
	[DESCRIPCION] [varchar](500) NULL,
 CONSTRAINT [PK_TIPODEUSO] PRIMARY KEY NONCLUSTERED 
(
	[NOMBRETIPOUSO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TIPODEUSO] ([NOMBRETIPOUSO], [DESCRIPCION]) VALUES (N'AL', N'Alimenticia')
INSERT [dbo].[TIPODEUSO] ([NOMBRETIPOUSO], [DESCRIPCION]) VALUES (N'AR', N'Artesanal')
INSERT [dbo].[TIPODEUSO] ([NOMBRETIPOUSO], [DESCRIPCION]) VALUES (N'MD', N'Medicinal')
/****** Object:  UserDefinedDataType [dbo].[TIPOARBOL]    Script Date: 10/13/2013 20:44:32 ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TIPOARBOL' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TIPOARBOL] FROM [char](3) NOT NULL
GO
/****** Object:  StoredProcedure [dbo].[sp_BackupDB]    Script Date: 10/13/2013 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_BackupDB]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_BackupDB]
(   
    @BaseLocation   varchar(1024),
    @BackupType     varchar(32)

)
AS
BEGIN

    Declare @DBName     varchar(255) = db_name()
    
    Declare @HostName     varchar(255) = host_name()

    Declare @FileName   varchar(256)

    Declare @Date datetime = getdate()
    Set @BackupType = UPPER(@BackupType)

    Set @FileName = Cast(Year(@Date) as varchar(4)) + ''_'' + 
                    Right(''00'' + Cast(Month(@Date) as varchar(2)),2) + ''_'' +
                    Right(''00'' + Cast(Day(@Date) as varchar(2)),2) + ''_'' + 
                    Right(''00'' + Cast(DatePart(hh,@Date) as varchar(2)),2) + ''_'' + 
                    Right(''00'' + Cast(DatePart(mi,@Date) as varchar(2)),2) + ''_'' +
                    Right(''00'' + Cast(DatePart(ss,@Date) as varchar(2)),2) + ''_'' + 
                   @HostName+''_''+UPPER(@BackupType)+''_SIFCA_BD''+
                    (Case When @BackupType = ''FULL'' Or @BackupType = ''DIFFERENTIAL'' Then ''.BAK'' Else ''.TRN'' End)

    Declare @FullPath varchar(1280) = ''''

    If Right(@BaseLocation,1) <> ''\''
    Begin
        Set @BaseLocation = @BaseLocation + ''\''
    End
    Set @FullPath = @BaseLocation + @FileName
    Print @FullPath


    If @BackupType = ''FULL''
    Begin
        Backup database @DBName To Disk = @FullPath
    End
    Else If @BackupType = ''DIFFERENTIAL''
    Begin
        Backup database @DBName To Disk = @FullPath WITH DIFFERENTIAL
    End
    Else If @BackupType = ''LOG''
    Begin
        BACKUP LOG @DBName
             TO Disk = @FullPath
    End

END
' 
END
GO
/****** Object:  Table [dbo].[GRUPOCOMERCIAL]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GRUPOCOMERCIAL]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GRUPOCOMERCIAL](
	[GRUPOCOM] [char](2) NOT NULL,
	[DESCRIPGRUPO] [varchar](500) NULL,
 CONSTRAINT [PK_GRUPOCOMERCIAL] PRIMARY KEY NONCLUSTERED 
(
	[GRUPOCOM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[GRUPOCOMERCIAL] ([GRUPOCOM], [DESCRIPGRUPO]) VALUES (N'MV', N'Muy valiosas')
INSERT [dbo].[GRUPOCOMERCIAL] ([GRUPOCOM], [DESCRIPGRUPO]) VALUES (N'PV', N'Poco valiosas')
INSERT [dbo].[GRUPOCOMERCIAL] ([GRUPOCOM], [DESCRIPGRUPO]) VALUES (N'SV', N'Sin valor comercial')
INSERT [dbo].[GRUPOCOMERCIAL] ([GRUPOCOM], [DESCRIPGRUPO]) VALUES (N'VA', N'Valiosas')
/****** Object:  Table [dbo].[OBJETIVOINVENTARIO]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OBJETIVOINVENTARIO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OBJETIVOINVENTARIO](
	[NOMBRETIPOINV] [varchar](100) NOT NULL,
	[DESCRIPOBJETINV] [varchar](500) NULL,
 CONSTRAINT [PK_OBJETIVOINVENTARIO] PRIMARY KEY NONCLUSTERED 
(
	[NOMBRETIPOINV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[OBJETIVOINVENTARIO] ([NOMBRETIPOINV], [DESCRIPOBJETINV]) VALUES (N'MD', N'Maderables')
INSERT [dbo].[OBJETIVOINVENTARIO] ([NOMBRETIPOINV], [DESCRIPOBJETINV]) VALUES (N'NM', N'No Maderables')
/****** Object:  Table [dbo].[ESTRATO]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESTRATO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ESTRATO](
	[CODEST] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DESCRIPESTRATO] [varchar](500) NULL,
 CONSTRAINT [PK_ESTRATO] PRIMARY KEY NONCLUSTERED 
(
	[CODEST] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ESTRATO] ON
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(1 AS Numeric(18, 0)), N'Bosque Alto')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(2 AS Numeric(18, 0)), N'Bosque Alto Mediano')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(3 AS Numeric(18, 0)), N'Bosque Alto Bajo')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(4 AS Numeric(18, 0)), N'Bosque Mediano')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(5 AS Numeric(18, 0)), N'Bosque Mediano Bajo')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(6 AS Numeric(18, 0)), N'Bosque Bajo')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(7 AS Numeric(18, 0)), N'Bosque Inundado')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(8 AS Numeric(18, 0)), N'Primario Intervenido')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(9 AS Numeric(18, 0)), N'Primario Muy Intervenido')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(10 AS Numeric(18, 0)), N'Primario')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(11 AS Numeric(18, 0)), N'Primario Poco Intervenido')
INSERT [dbo].[ESTRATO] ([CODEST], [DESCRIPESTRATO]) VALUES (CAST(12 AS Numeric(18, 0)), N'Nadizal')
SET IDENTITY_INSERT [dbo].[ESTRATO] OFF
/****** Object:  Table [dbo].[ESTADOSANITARIO]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESTADOSANITARIO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ESTADOSANITARIO](
	[ESTADO] [char](2) NOT NULL,
	[DESCRIPESTADO] [varchar](500) NULL,
 CONSTRAINT [PK_ESTADOSANITARIO] PRIMARY KEY NONCLUSTERED 
(
	[ESTADO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AI', N'Arbol con insectos')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AD', N'Arbol dañado')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AF', N'Arbol con o sin flores')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AA', N'Arbol aprovechado')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AE', N'Arbol estrangulado por lianas')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AQ', N'Arbol quemado')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AM', N'Arbol muerto')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AC', N'Arbol caido')
INSERT [dbo].[ESTADOSANITARIO] ([ESTADO], [DESCRIPESTADO]) VALUES (N'AS', N'Arbol sano')
/****** Object:  Table [dbo].[ESPECIE]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESPECIE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ESPECIE](
	[CODESP] [uniqueidentifier] NOT NULL,
	[GRUPOCOM] [char](2) NOT NULL,
	[NOMCOMUN] [varchar](200) NULL,
	[NOMCIENTIFICO] [varchar](200) NULL,
	[FAMILIA] [varchar](200) NULL,
	[ZONAGEOGRAFICA] [varchar](200) NULL,
	[ZONADEVIDA] [varchar](200) NULL,
	[DIAMMINCORTE] [numeric](18, 0) NULL,
 CONSTRAINT [PK_ESPECIE] PRIMARY KEY NONCLUSTERED 
(
	[CODESP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ESPECIE]') AND name = N'PERTENECE_FK')
CREATE NONCLUSTERED INDEX [PERTENECE_FK] ON [dbo].[ESPECIE] 
(
	[GRUPOCOM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd66dcd31-d006-4b62-bd6a-001196c79653', N'SV', N'Amarilo de Bajura', N'Albizia niopioides', N'Mimosaceae', N'Lm', N'CE-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'e9d36c3a-16f7-4719-8b19-033d0b4f35b0', N'SV', N'Cari-Cari', N'Acacia polyphylla', N'Mimosoideae', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'b0aa95ee-db21-410a-9366-035eab3eaf92', N'PV', N'Tajibo Panza', N'Zeyheria tuberculosa', N'Bignoniaceae', N'Sr-Sm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'a06d1442-e0e0-4cf5-adc3-069ddfd0ecb2', N'MV', N'Moradillo', N'Machaerium sp', N'Papilionoide', N'Ne-Lm-Sr-Sm', N'BHS-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'cbfea9bb-ee72-467f-bf64-07a892dd0ee7', N'PV', N'Picana Blanca', N'Cordia alliodora', N'Borraginacea', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'50895cc2-2d4d-4313-a09e-11dc8aff9920', N'VA', N'Guayacán', N'Bulnesia sarmientoi', N'Zygophyllace', N'Lm-Tb-Sm-Sn', N'VC-BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd9abf32a-4650-468b-94ca-1485cf336e23', N'PV', N'Azucaró', N'Spondias mombin', N'Anacardiacea', N'Lm-Cp-Ne-Sj', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'3d293cb2-0e37-4e90-a881-166f7c254228', N'VA', N'Cedro Blanco', N'', N'', N'Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'f53d9628-d224-46c1-8385-1e7e5c623ec1', N'VA', N'Sirari', N'Peltogyne heterophylla', N'Caesalpinace', N'Lm-Sm-Sr-Cp-', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'704b61cc-556d-4182-ad05-1f3693a30459', N'SV', N'Mapabí', N'Neea hermaphrodita', N'Nyctaginacea', N'Lm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'642d8ed6-57ca-464b-bf78-204e086d1b5a', N'MV', N'Picana Negra', N'Cordia glabrata', N'Borraginacea', N'##', N'BS-BA', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'ab1f4047-a909-463f-8671-20768fe4c9fa', N'SV', N'Pequí de la Pampa', N'Pseudobombax marginatum', N'Bombacaceae', N'##', N'CE-AR-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd543fde6-8020-4c29-a680-221765ebb776', N'PV', N'Cacha', N'Aspidosperma quebracho blanco', N'Apocynaceae', N'Sr-Tb', N'BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'bb0d0df4-3633-4b02-ac2e-22f010e627e5', N'VA', N'Lucuma', N'Pouteria macrophyllla', N'Sapotaceae', N'Ne-Cp-Lm-Sj', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'6bc4d6e5-d8de-4033-8e3c-23537ecc962f', N'PV', N'Tajibo Mono', N'Zeyheria tuberculosa', N'Bignoniaceae', N'Lm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'86e4bdea-7eff-4f80-993d-243c15f96216', N'SV', N'Bi', N'Genipa americana', N'Rubiaceae', N'##', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'227ebcf3-5a1a-49a4-bc61-2550123303a6', N'SV', N'Pequí Colora·', N'Pseudobombax marginatum', N'Bombacaceae', N'Lm', N'AR-CE-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'847e429f-f870-4ae7-8a8f-2630ceb0ce01', N'VA', N'Verdolago Blanco', N'Terminalia sp', N'Combretaceae', N'Ne-Cp', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'741a5ee1-35e2-4690-8d09-2ecc9e7749a9', N'VA', N'Tarara colorada', N'Platymiscium fragrans', N'Papilionoide', N'Lm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'1563a0a9-6d49-48e7-bbaf-2f3151737863', N'VA', N'Tajibo Rosado', N'Tabebuia impetiginosa', N'Bignoniaceae', N'Cp-Ne-Sj-Lm', N'BS-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'57cda260-572f-46a9-9f57-325de836f750', N'VA', N'Tinto Negro', N'Qualea grandiflora', N'Vochysiaceae', N'Ne', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'eaefab80-32bd-41ef-8888-33ca02e4f894', N'PV', N'Cuquí', N'Lonchocarpus gullemineanus', N'Caesalpinoid', N'Lm-Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'18045d84-476d-4b58-8dfd-34f80b955b14', N'PV', N'Jopo de Mono', N'Zeyheria tuberculosa', N'Bignoniaceae', N'Ne', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'62fe95fd-72d8-4148-a083-362e21cd1826', N'SV', N'Sahuinto', N'Eugenia sp.', N'Myrtaceae', N'Sr-Sm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'ab13ceec-e93a-429b-9bd3-379ed72447a1', N'VA', N'Serebó', N'Schizolobium amazonicum', N'Caesalpinace', N'Mv', N'BST', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'99618e9c-50f1-4ba3-9aee-3800e5357c8f', N'PV', N'Chituriqui', N'Aspidosperma cylindrocarpon', N'Apocynaceae', N'Si-Sm-Sr', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'574e36ad-29c6-4928-8093-3946928ae85c', N'PV', N'Quina', N'Pogonomus tubulosus', N'Rubiaceae', N'Lm', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'c0f0a129-2bae-496f-a74a-3eb93bb82f4d', N'PV', N'Jichituriqui Negro', N'Aspidosperma cylindrocarpon', N'Apocynaceae', N'Lm-Cp', N'BS-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'2081e58f-7beb-40e4-90a6-3f8e0dfae52d', N'SV', N'Pequí Blanco', N'Eriotheca rosearun', N'Bombacaceae', N'Lm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'50772013-65b4-401c-9c58-443556b9289e', N'PV', N'Cuchi', N'Astronium urundeuva', N'Anacardiacea', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'1be9e432-b306-4e50-9693-45e9ab8e75a8', N'PV', N'Toco', N'Enterolobium contortisiliquum', N'Mimosaceae', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'98e55eac-a7c3-4c25-a3e1-48b57a2ee24e', N'SV', N'Pequí del Monte', N'Eriotheca rosearun', N'Bombacaceae', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'db146098-063d-4fa7-94a3-49229db86edd', N'PV', N'Blanquillo', N'', N'', N'Ne-Cp-Lm', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'02b4dc22-75c6-4a19-90a7-493b9d7b26f2', N'VA', N'Tajibo Amarillo', N'Tabebuia serratifolia', N'Bignoniaceae', N'Ne-Lm-Cp-Sj', N'BHS-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'3aff8cbc-5728-4e28-8b98-4a5c7510c5c8', N'SV', N'Tinto Negro', N'Callisthene sp.', N'Vochysiaceae', N'Lm-Cp', N'BS-CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'9dd459a6-8fb9-4a0e-a1fc-4d16e3c7f06b', N'PV', N'Cuse', N'Casearia gossypiosperma', N'Flacourtacea', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'3013ee6c-52eb-4966-ace3-4f7ce4fa7524', N'VA', N'Chituriqui Colorau', N'Aspidosperma pyrifolium', N'Apocynaceae', N'Si-Sm-Sr', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'6d7a8687-0d5b-4393-8f9c-528f137a09ae', N'PV', N'Garroncillo', N'Poeppigia procera', N'Caesalpinioi', N'Lm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'b0df41dd-921a-4fd2-829a-52e52be472f0', N'VA', N'Tarara Amarilla', N'Centrolobium microchaetei', N'Papilionoide', N'Cp-Lm-Ne-Sj', N'BS-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'88455c1c-bd9b-4776-b223-55228ac22d83', N'PV', N'Carandá', N'Dalbergia riparia', N'Papilinoidea', N'Ne-Cp', N'BHS-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'71305e9d-d6a2-4da8-b376-57115dc8025e', N'SV', N'Mururé', N'Sorocea saxicola', N'Moraceae', N'Lm-Cp', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'a45d9b17-d536-4dd0-9292-587dcc54e3d1', N'SV', N'Arka', N'Acacia sp', N'Mimosaceae', N'Lm-Cp-Sr', N'CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'5a4b1a63-aba6-4437-bcee-5ae37eb294b9', N'SV', N'Carne de Toro', N'Combretum leprosun', N'Combretaceae', N'##', N'BS-BHS-BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'bcc11d8e-efa0-44ce-9934-5cb1c957146c', N'SV', N'Espino Blanco', N'', N'', N'Lm', N'CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'e6be129b-8f8e-4ef4-b757-5d1549276439', N'SV', N'Coloradillo', N'Physocalimma scaraberrimun', N'Lytraceae', N'Lm-Cp-Ne', N'BHS-BS-CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'e4d35be1-cd4c-4e2e-80ab-5ebc2648c77a', N'PV', N'Sahuinto', N'Myrcianthes sp.', N'Myrtaceae', N'Lm-Cp-Ne-Sj', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'232dc119-9f4e-4424-97c0-60490e3635b2', N'PV', N'Gallito', N'Erythrina sp', N'Papilionoide', N'Ne', N'BS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'b69dadfe-3489-4499-bd69-64de66550782', N'VA', N'Verdolago', N'Calycophyllum  multiflorum', N'Rubiaceae', N'Lm-Sr-Sm-Sa', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'87ca97aa-a137-4b50-95f6-6538dc05238e', N'VA', N'Jorori', N'Swartzia jorori', N'Papilionoide', N'Cp-Ne-Sj-Lm', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'f4da4387-6e0f-4ba0-8869-6563857c86b3', N'VA', N'Tajibo Amarillo', N'Tabebuia impetiginosa', N'Bignoniaceae', N'Lm-Sr-Sm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'8f913304-0cea-4f7a-a114-65cfdb32b2a1', N'SV', N'Gabetillo', N'Sloanea rufa', N'Apocynaceae', N'Lm', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'fccc1654-c2c4-4b1c-8c88-65e00b6bacf8', N'PV', N'Peji', N'Cyclolobiun blanchetianum', N'Papilionoide', N'Lm', N'BS-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'9d205faa-454b-40bb-9bd1-687bf247667c', N'MV', N'Mara', N'Sweitenia macrophylla', N'Meliaceae', N'Mv', N'BSH-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'15f3c4eb-003e-4588-9ed0-6b1f8274fa73', N'PV', N'Ajunao', N'Pterogyne nitens', N'Caesalpinoid', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'02e89e21-a5db-42bb-a44c-6bc4c941c1e8', N'SV', N'Cabeza de Mono', N'Apeiba sp', N'Tiliaceae', N'Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'b0432b95-fe18-4b45-93b0-6c731c6fce47', N'SV', N'Alcormoque', N'Tabebuia aurea', N'Bignoniaceae', N'##', N'CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'7f85fa26-13a8-4d61-9898-71a7d1b0e81c', N'SV', N'Amarillo', N'Albizia niopioides', N'Mimosaceae', N'Sr-Si-Sm', N'CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'7998deca-78c0-46fb-9c9b-7a9e5427765c', N'PV', N'Coquino', N'', N'Sapindaceae', N'Lm-Cp', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'b9585379-7fcd-45cf-8c1f-7ba6d57a5019', N'PV', N'Bibosi', N'Ficus sp', N'Moraceae', N'##', N'BHS-AR', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'f233dcd7-1261-4471-988f-7cdd59b4a658', N'PV', N'Yesquero Blanco', N'Cariniana estrllensis', N'Lecythidacea', N'Cp-Ne-Cp-Sj', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'548ec0c7-1430-41bd-8a0e-7edb189284f7', N'PV', N'Tarumá', N'Vitex cimosa', N'Verbenaceae', N'##', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'44f5a042-6335-4cc8-81ff-8353c1c68a01', N'PV', N'Chituriqui Blanco', N'Aspidosperma rigidum', N'Apocynaceae', N'Si-Sm-Sr', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'34ac320d-0c05-469f-b60e-84015ea3373a', N'SV', N'Chirimoya', N'Guazuma ulmiflora', N'Sterculaceae', N'Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'78e0ad07-3f2e-46ab-97ff-8cd27c7b5c5a', N'VA', N'Curupaú Negro', N'Anadenanthera colubrina', N'Mimosaceae', N'Lm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'7debbaad-ac6b-429f-bcf1-8fd9b3a1692d', N'VA', N'Paquió', N'Hymenea courbaril', N'Caesalpinace', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'b9ccee52-0d85-4d8d-956e-92d78ef111d3', N'PV', N'Momoqui', N'Caesalpinia floribunda', N'Caesalpinace', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'5bbab49f-a53a-4b55-9c64-92f337306dd1', N'PV', N'Laurel', N'Ocotea sp', N'Lauraceae', N'Lm', N'BS-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'8017bfc4-1f9d-4dd3-8c57-963516454d3b', N'PV', N'Jichituriqui Amarillo', N'Aspidosperma rigidum', N'Apocynaceae', N'Lm-Cp-Ne-Sj', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'6d6d0da8-137f-49c1-802e-9668ca57c847', N'PV', N'Picana', N'Cordia sp', N'Borraginacea', N'##', N'BHS-CE-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'3d688304-6c80-4dde-a526-97fe25783bbf', N'SV', N'Gabetillo', N'Aspidosperma sp', N'Apocynaceae', N'Cp-Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'f9a8a229-ff45-4e7f-96ae-99cab14d9c92', N'SV', N'Maní', N'Sterculia apetala', N'Sterculaceae', N'Cp-Sj', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'fb24f8b1-cb5d-4a80-8c49-9b4c4939bc16', N'PV', N'Curupaú Blanco', N'Anadenanthera colubrina', N'Mimosaceae', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'286ca095-26da-406d-826a-9bb154105c4a', N'SV', N'Jorori', N'Andira inermis', N'Papilionoide', N'Lm', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'126efacf-7174-40d1-94fb-a0dfa1d922ee', N'PV', N'Copaibo', N'Copaifera sp', N'Caesalpinoid', N'Ne-Cp-Lm', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'ce012c83-c7a2-4866-b105-a1625aa92439', N'SV', N'Sujo', N'Sterculia apetala', N'Sterculiacea', N'Ne', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'b0568351-5717-47ab-b1dc-a2d47cafc239', N'PV', N'Soto', N'Schinopsis  brasiliensis', N'Anacardiacea', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'ee7ef0b6-2586-4dc9-929e-a3cf82375fd8', N'VA', N'Soriocó', N'Amburana cearensis', N'Papilionoida', N'Si-Sr-Sm-Sa', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'f74f5c5b-702e-44cf-881b-a43c6c3bb69d', N'VA', N'Verdolago Amarillo', N'Terminalia oblonga', N'Combretaceae', N'Ne-Cp-Mv', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd4f1eacc-3808-4a6f-82f7-a4660c598922', N'PV', N'Cuta', N'Phyllostylon rhamnoides', N'Ulmaceae', N'##', N'BS-BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'97da2a34-5d03-44b7-bdf9-a4f4ece67661', N'MV', N'Picana  Barcina', N'Cordia glabrata', N'Borraginacea', N'Sr-Sm-Sa-Si', N'BS-BA', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'69f74eeb-da83-410a-bb79-a51453b08daf', N'PV', N'Tipa', N'Machaerium acutifolium', N'Papilionoide', N'Lm-Ne-Cp', N'BS-CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'a10cba84-872a-4a36-b6e7-b00dfdb4fbb8', N'VA', N'Yesquero Negro 1', N'Cariniana sp. 1', N'Lecythidacea', N'Ne', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'f9ba44bc-4c3f-4198-8441-b1a30c9f40e6', N'PV', N'Tasaá', N'Poepiggia procera', N'Caesalpinoid', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'fa5107ff-2ac7-4dca-ab24-b558a3da7267', N'VA', N'Guayabochi', N'Callycophyllum spruceanum', N'Rubiaceae', N'Ne-Cp-Sj', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'4d15b2aa-28ca-46b8-a0a9-b6771c618935', N'PV', N'Jichituriqui Rosado', N'Aspidosperma australe', N'Apocynaceae', N'Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'17686023-d1ca-4640-834d-bb101f7d96f8', N'VA', N'Sirari', N'Ormosia sp', N'Papilionoide', N'Ne-Cp-Sj', N'BHS-BST', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'bae72445-9f89-4421-b8b3-bb42a1377c42', N'VA', N'Yesquero Negro 2', N'Cariniana sp. 2', N'Lecythidacea', N'Ne-Mv', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd4d68bf4-b21e-4355-9c1d-bcae01f274bb', N'PV', N'Sauco Negro', N'Fagara chiloperone', N'Rutaceae', N'Lm-Ne', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'2a324fbc-b14d-43c3-9d7e-beda8ca9392f', N'PV', N'Yesquero Colorado', N'Lonchocarpus guillemineanus', N'Papilionoide', N'Lm', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'acd1e42b-ffc8-4002-bab5-c16b8771c30f', N'VA', N'Siringa', N'Hevea brasiliensis', N'Euphorbiacea', N'Mv', N'BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd14ec77c-11fc-414a-b2d6-c2bccd108b5f', N'PV', N'Quebracho Blanco', N'Aspidosperma quebracho blanco', N'Apocynaceae', N'Tb-Lm', N'VC-BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'aa4ea3e9-156f-4fb7-986f-c61424fc3310', N'PV', N'Cupesí', N'Prosopis sp', N'Mimosaceae', N'Lm-Sr-Sm-Tb', N'BD-BS-VC', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'8f33d4c7-7951-4de6-ada4-c894b872dc30', N'VA', N'Tajibo Negro', N'Tabebuia impetiginosa', N'Bignoniaceae', N'Cp-Si-Sr-Sm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'71350948-3b56-47ab-bc4b-cab6167c9b47', N'PV', N'Isotoubo', N'Sapindus saponaria', N'Sapindaceae', N'Lm-Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'3c7fdd90-043d-4e3d-b3af-cbf868397eba', N'VA', N'Ochoó', N'Hura crepitans', N'Euphorbiacea', N'Ne-Cp-Sj-Lm', N'BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'af18a37f-c6af-4db8-b174-cc4532333a7a', N'VA', N'Tajibo Morado', N'Tabebuia impetiginosa', N'Bignoniaceae', N'Lm-Ne-Tb', N'BS-BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'979a4a90-4a2e-4233-a2e3-cf2e80bf8b0b', N'SV', N'Chirimoya', N'Rollinia herzogii R.E.', N'Annonaceae', N'##', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'9b4180b4-b380-4dcf-90c0-d2a06f02bda1', N'PV', N'Mururé', N'Clarisia biflora', N'Moraceae', N'Ne', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd45c1c64-b5fb-4bc9-9b7f-d33f8ed976e0', N'SV', N'Mapajo', N'Ceiba samauma', N'Bombacaceae', N'##', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'4826e72b-0beb-496d-bcbb-d35c63d93fb6', N'SV', N'Negrillo', N'Capparis capparis', N'Capparaceae', N'Sr-Sm', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'861d748b-cf0b-4a48-a13d-d6c61d3ebefc', N'PV', N'Turino', N'Spondias mombin', N'Anacardiacea', N'Si-Sr-Sm-Sa', N'BS', CAST(60 AS Numeric(18, 0)))
GO
print 'Processed 100 total records'
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'c56ab441-9c60-4297-8b7b-d89be99bd8ea', N'PV', N'Paraparaú', N'Jacaranda cuspidifolia', N'Bignoniaceae', N'Sr-Sm-Si-Cp-', N'CE', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'44296e63-a1e3-4e6a-8fcd-d90c1f918b5a', N'PV', N'Chachairu', N'', N'', N'Lm-Sm', N'CE-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'bd8b50b5-3692-423d-867d-dc70a82f7cee', N'MV', N'Morado', N'Machaerium scleroxylon', N'Papilionoide', N'##', N'BS-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'5133dbe1-a9cd-4c0c-ae6f-dedd51c7fec3', N'VA', N'Tarara colorada', N'Platymiscium ulei', N'Papilionoide', N'Lm-Ne-Cp', N'BHS-BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'bdb4a960-c46e-458c-bc44-e08a30d1e203', N'PV', N'Ajo Ajo', N'Gallesia integrifolia', N'Phytolacacea', N'##', N'BS-BHS-BSH', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'8ff3613a-c95b-444a-bff2-e0eaf8e7dbb1', N'SV', N'Coco', N'Guazuma ulmiflora', N'Sterculaceae', N'Lm', N'BS-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'4a0899fa-bc88-4fed-8ab1-e4ac304d7e01', N'VA', N'Jichituriqui Rosado', N'Aspidosperma pyrifolium', N'Apocynaceae', N'Lm-Cp', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'61c4bafe-a0ee-4728-b87b-e60f9dbf74cd', N'PV', N'Maní', N'Platypodium cf elegans', N'Papilionoide', N'Lm-Ne', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'0c3a2709-12a6-4719-9c30-e9d16905d8c0', N'SV', N'Pacobillo', N'Capparis capparis', N'Capparaceae', N'Lm-Cp', N'BHS-BS-BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'd2e9af1a-8bbe-4770-a485-eb36dd5d35d9', N'PV', N'Aguaí', N'Chrysophyllum gonocarpum', N'Sapotaceae', N'Lm-Ne-Cp-Sj', N'BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'0bca1d31-50f1-4b88-8e19-ec2db4905c03', N'VA', N'Cabeza de Mono', N'Zeyheria tuberculosa', N'Bignoniaceae', N'Lm-Cp-Sj', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'2cb73931-64e4-4305-aceb-f290710d4168', N'SV', N'Toborochi', N'Chorisia speciosa', N'Bombacaceae', N'##', N'BS-BD', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'74d66fcb-d678-49c7-8477-f77806e6c4b1', N'VA', N'Cedro', N'Cedrela fissilis', N'Meliaceae', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'51d99494-420c-4a43-a048-fa7f39a59146', N'MV', N'Roble', N'Amburana cearensis', N'Papilionoide', N'##', N'BS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'dd048510-b59c-4348-b6bc-fb8fb13898fd', N'PV', N'Mora', N'Maclura tinctoria', N'Moraceae', N'##', N'BHT-BHS', CAST(60 AS Numeric(18, 0)))
INSERT [dbo].[ESPECIE] ([CODESP], [GRUPOCOM], [NOMCOMUN], [NOMCIENTIFICO], [FAMILIA], [ZONAGEOGRAFICA], [ZONADEVIDA], [DIAMMINCORTE]) VALUES (N'ee80ec32-a0e6-4c13-8a2e-fc34a9680d16', N'PV', N'Tajibo Blanco', N'Cybistax antisyphilitica', N'Bignoniaceae', N'Lm-Ne', N'BHS-CE-BS', CAST(60 AS Numeric(18, 0)))
/****** Object:  Table [dbo].[USUARIO]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USUARIO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[USUARIO](
	[NROUSUARIO] [uniqueidentifier] NOT NULL,
	[NOMBRES] [varchar](100) NOT NULL,
	[APELLIDOS] [varchar](100) NOT NULL,
	[NOMBREUSUARIO] [varchar](100) NOT NULL,
	[CONTRASENA] [varchar](1000) NOT NULL,
	[CEDULA] [numeric](18, 0) NOT NULL,
	[TIPOUSUARIO] [dbo].[TIPOUSUARIO] NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY NONCLUSTERED 
(
	[NROUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[USUARIO] ([NROUSUARIO], [NOMBRES], [APELLIDOS], [NOMBREUSUARIO], [CONTRASENA], [CEDULA], [TIPOUSUARIO]) VALUES (N'dd15b0d2-7752-4d27-afe9-4827d05ce9d3', N'Admin', N'Admin', N'admin', N'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAo/kC398omUibC6RrgwQH+wAAAAACAAAAAAAQZgAAAAEAACAAAABNNMpqydm6W/XSqcl/PspTWvMlcw5Rx/Q+6kazvSlPMgAAAAAOgAAAAAIAACAAAAB1souKcp1Kl8y7UlPtUsdrw1/i3WeA59zV4asn6m2Y+hAAAADqJ0V5/06d/syAIbgrlJWzQAAAALywKwLxcZ9TdN6uUCmP6Ge2fC99zYD3oDYn6BrrRVBXhVoYd0ygVKq+uD4XWoiW6xavHYdDiQvLB+WhTcTq524=', CAST(1061730429 AS Numeric(18, 0)), N'AD')
/****** Object:  Table [dbo].[IMAGEN]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IMAGEN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IMAGEN](
	[IMAGENID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CODESP] [uniqueidentifier] NOT NULL,
	[DESCRIPCION] [varchar](1000) NULL,
	[NOMBRE] [varchar](250) NOT NULL,
	[RUTA] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_IMAGEN] PRIMARY KEY CLUSTERED 
(
	[IMAGENID] ASC,
	[CODESP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[IMAGEN]') AND name = N'IMAGENID')
CREATE NONCLUSTERED INDEX [IMAGENID] ON [dbo].[IMAGEN] 
(
	[IMAGENID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSACCION]    Script Date: 10/13/2013 20:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRANSACCION]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TRANSACCION](
	[NROTRANS] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NROUSUARIO] [uniqueidentifier] NOT NULL,
	[FECHA] [datetime] NOT NULL,
	[TABLA] [varchar](100) NOT NULL,
	[IDREGISTRO] [numeric](18, 0) NOT NULL,
	[OPERACION] [dbo].[TIPOOPERACION] NOT NULL,
	[VALORESVIEJOS] [varchar](1024) NULL,
	[VALORESNUEVOS] [varchar](1024) NULL,
 CONSTRAINT [PK_TRANSACCION] PRIMARY KEY NONCLUSTERED 
(
	[NROTRANS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[TRANSACCION]') AND name = N'REGISTRA_FK')
CREATE NONCLUSTERED INDEX [REGISTRA_FK] ON [dbo].[TRANSACCION] 
(
	[NROUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROYECTO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PROYECTO](
	[NROPROY] [uniqueidentifier] NOT NULL,
	[NROUSUARIO] [uniqueidentifier] NOT NULL,
	[NOMBRETIPOINV] [varchar](100) NOT NULL,
	[NOMTIPODISEMUEST] [varchar](100) NOT NULL,
	[LUGAR] [varchar](100) NOT NULL,
	[DESCRIPCION] [varchar](500) NULL,
	[SUPTOT] [decimal](18, 3) NOT NULL,
	[INTMUE] [decimal](18, 3) NOT NULL,
	[SUPMUE] [decimal](18, 3) NOT NULL,
	[TAMANO] [decimal](18, 3) NOT NULL,
	[LIMITINFDAP] [decimal](18, 3) NOT NULL,
	[LIMITSUPDAP] [decimal](18, 3) NOT NULL,
	[AREAFUSTALESPORPARCELA] [decimal](18, 3) NOT NULL,
	[FACTORDEFORMA] [decimal](18, 3) NOT NULL,
	[FECHA] [datetime] NOT NULL,
	[NUMEROETAPAS] [numeric](18, 0) NULL,
	[TIPOPROYECTO] [dbo].[TIPOPROYECTO] NOT NULL,
 CONSTRAINT [PK_PROYECTO] PRIMARY KEY NONCLUSTERED 
(
	[NROPROY] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[PROYECTO]') AND name = N'CREA_FK')
CREATE NONCLUSTERED INDEX [CREA_FK] ON [dbo].[PROYECTO] 
(
	[NROUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[PROYECTO]') AND name = N'ES_FK')
CREATE NONCLUSTERED INDEX [ES_FK] ON [dbo].[PROYECTO] 
(
	[NOMBRETIPOINV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[PROYECTO]') AND name = N'REALIZA_FK')
CREATE NONCLUSTERED INDEX [REALIZA_FK] ON [dbo].[PROYECTO] 
(
	[NOMTIPODISEMUEST] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROYECTOSPORETAPA]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PROYECTOSPORETAPA](
	[NROPROYCONTENEDOR] [uniqueidentifier] NOT NULL,
	[NROPROYCONTENIDO] [uniqueidentifier] NOT NULL,
	[PESO] [decimal](18, 3) NULL,
 CONSTRAINT [PK_PROYECTOSPORETAPA] PRIMARY KEY CLUSTERED 
(
	[NROPROYCONTENEDOR] ASC,
	[NROPROYCONTENIDO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[FORMULARIO]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FORMULARIO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FORMULARIO](
	[NROFORMULARIO] [uniqueidentifier] NOT NULL,
	[CODEST] [numeric](18, 0) NOT NULL,
	[NROUSUARIO] [uniqueidentifier] NOT NULL,
	[NROPROY] [uniqueidentifier] NOT NULL,
	[FECHACREACION] [datetime] NOT NULL,
	[HORAINICIO] [datetime] NULL,
	[HORAFINAL] [datetime] NULL,
	[PARCELA] [numeric](18, 0) NOT NULL,
	[LINEA] [numeric](18, 0) NOT NULL,
	[COORDENADAX] [numeric](18, 3) NULL,
	[COORDENADAY] [numeric](18, 3) NULL,
 CONSTRAINT [PK_FORMULARIO] PRIMARY KEY NONCLUSTERED 
(
	[NROFORMULARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FORMULARIO]') AND name = N'DESARROLLA_FK')
CREATE NONCLUSTERED INDEX [DESARROLLA_FK] ON [dbo].[FORMULARIO] 
(
	[NROPROY] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FORMULARIO]') AND name = N'ES_REPONSABLE_FK')
CREATE NONCLUSTERED INDEX [ES_REPONSABLE_FK] ON [dbo].[FORMULARIO] 
(
	[NROUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FORMULARIO]') AND name = N'MANEJA_FK')
CREATE NONCLUSTERED INDEX [MANEJA_FK] ON [dbo].[FORMULARIO] 
(
	[CODEST] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LISTADODEESTRATOS]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LISTADODEESTRATOS](
	[NROPROY] [uniqueidentifier] NOT NULL,
	[CODEST] [numeric](18, 0) NOT NULL,
	[PESO] [decimal](18, 3) NULL,
 CONSTRAINT [PK_LISTADODEESTRATOS] PRIMARY KEY CLUSTERED 
(
	[NROPROY] ASC,
	[CODEST] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[LISTADODEESPECIES]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LISTADODEESPECIES](
	[CODESP] [uniqueidentifier] NOT NULL,
	[NROPROY] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_LISTADODEESPECIES] PRIMARY KEY CLUSTERED 
(
	[CODESP] ASC,
	[NROPROY] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[LINEAREGENERACION]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LINEAREGENERACION](
	[LATIZAL] [numeric](18, 0) NOT NULL,
	[BRINZAL] [numeric](18, 0) NOT NULL,
	[LINEAREGEN] [uniqueidentifier] NOT NULL,
	[NROFORMULARIO] [uniqueidentifier] NOT NULL,
	[CODESP] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_LINEAREGENERACION] PRIMARY KEY NONCLUSTERED 
(
	[LINEAREGEN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]') AND name = N'COMPLETA_FK')
CREATE NONCLUSTERED INDEX [COMPLETA_FK] ON [dbo].[LINEAREGENERACION] 
(
	[NROFORMULARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]') AND name = N'EVALUACION_FK')
CREATE NONCLUSTERED INDEX [EVALUACION_FK] ON [dbo].[LINEAREGENERACION] 
(
	[CODESP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LINEANOMADERABLES]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LINEANOMADERABLES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LINEANOMADERABLES](
	[LINEANMAD] [uniqueidentifier] NOT NULL,
	[NROFORMULARIO] [uniqueidentifier] NOT NULL,
	[OBSERVACIONES] [varchar](500) NOT NULL,
 CONSTRAINT [PK_LINEANOMADERABLES] PRIMARY KEY NONCLUSTERED 
(
	[LINEANMAD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LINEANOMADERABLES]') AND name = N'RECOLECTA_FK')
CREATE NONCLUSTERED INDEX [RECOLECTA_FK] ON [dbo].[LINEANOMADERABLES] 
(
	[NROFORMULARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LINEAINVENTARIO]    Script Date: 10/13/2013 20:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LINEAINVENTARIO](
	[LINEAINV] [uniqueidentifier] NOT NULL,
	[CODCALIDAD] [numeric](18, 0) NOT NULL,
	[NROFORMULARIO] [uniqueidentifier] NOT NULL,
	[ESTADO] [char](2) NOT NULL,
	[CODESP] [uniqueidentifier] NOT NULL,
	[NROARB] [numeric](18, 0) NOT NULL,
	[ALTCOMER_M] [numeric](18, 3) NOT NULL,
	[ALTTOT_M] [numeric](18, 3) NOT NULL,
	[AREABASAL] [decimal](18, 3) NOT NULL,
	[VOLCOM] [decimal](18, 3) NOT NULL,
	[VOLTOT] [decimal](18, 3) NOT NULL,
	[CAP] [numeric](18, 3) NOT NULL,
	[DAP] [numeric](18, 3) NOT NULL,
	[TIPOARBOL] [dbo].[TIPOARBOL] NOT NULL,
 CONSTRAINT [PK_LINEAINVENTARIO] PRIMARY KEY NONCLUSTERED 
(
	[LINEAINV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]') AND name = N'ASOCIADO_FK')
CREATE NONCLUSTERED INDEX [ASOCIADO_FK] ON [dbo].[LINEAINVENTARIO] 
(
	[ESTADO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]') AND name = N'CONTIENE_FK')
CREATE NONCLUSTERED INDEX [CONTIENE_FK] ON [dbo].[LINEAINVENTARIO] 
(
	[CODESP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]') AND name = N'LLENA_FK')
CREATE NONCLUSTERED INDEX [LLENA_FK] ON [dbo].[LINEAINVENTARIO] 
(
	[NROFORMULARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]') AND name = N'POSEE_FK')
CREATE NONCLUSTERED INDEX [POSEE_FK] ON [dbo].[LINEAINVENTARIO] 
(
	[CODCALIDAD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USO]    Script Date: 10/13/2013 20:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[USO](
	[LINEANMAD] [uniqueidentifier] NOT NULL,
	[NOMBRETIPOUSO] [varchar](100) NOT NULL,
 CONSTRAINT [PK_USO] PRIMARY KEY CLUSTERED 
(
	[LINEANMAD] ASC,
	[NOMBRETIPOUSO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_ESPECIE_PERTENECE_GRUPOCOM]    Script Date: 10/13/2013 20:44:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ESPECIE_PERTENECE_GRUPOCOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESPECIE]'))
ALTER TABLE [dbo].[ESPECIE]  WITH CHECK ADD  CONSTRAINT [FK_ESPECIE_PERTENECE_GRUPOCOM] FOREIGN KEY([GRUPOCOM])
REFERENCES [dbo].[GRUPOCOMERCIAL] ([GRUPOCOM])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ESPECIE_PERTENECE_GRUPOCOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESPECIE]'))
ALTER TABLE [dbo].[ESPECIE] CHECK CONSTRAINT [FK_ESPECIE_PERTENECE_GRUPOCOM]
GO
/****** Object:  ForeignKey [FK_IMAGEN_IMAGENE_ESPECIE]    Script Date: 10/13/2013 20:44:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IMAGEN_IMAGENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[IMAGEN]'))
ALTER TABLE [dbo].[IMAGEN]  WITH CHECK ADD  CONSTRAINT [FK_IMAGEN_IMAGENE_ESPECIE] FOREIGN KEY([CODESP])
REFERENCES [dbo].[ESPECIE] ([CODESP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IMAGEN_IMAGENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[IMAGEN]'))
ALTER TABLE [dbo].[IMAGEN] CHECK CONSTRAINT [FK_IMAGEN_IMAGENE_ESPECIE]
GO
/****** Object:  ForeignKey [FK_TRANSACC_REGISTRA_USUARIO]    Script Date: 10/13/2013 20:44:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSACC_REGISTRA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSACCION]'))
ALTER TABLE [dbo].[TRANSACCION]  WITH CHECK ADD  CONSTRAINT [FK_TRANSACC_REGISTRA_USUARIO] FOREIGN KEY([NROUSUARIO])
REFERENCES [dbo].[USUARIO] ([NROUSUARIO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSACC_REGISTRA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSACCION]'))
ALTER TABLE [dbo].[TRANSACCION] CHECK CONSTRAINT [FK_TRANSACC_REGISTRA_USUARIO]
GO
/****** Object:  ForeignKey [FK_PROYECTO_CREA_USUARIO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CREA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO]  WITH CHECK ADD  CONSTRAINT [FK_PROYECTO_CREA_USUARIO] FOREIGN KEY([NROUSUARIO])
REFERENCES [dbo].[USUARIO] ([NROUSUARIO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CREA_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] CHECK CONSTRAINT [FK_PROYECTO_CREA_USUARIO]
GO
/****** Object:  ForeignKey [FK_PROYECTO_ES_OBJETIVO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_ES_OBJETIVO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO]  WITH CHECK ADD  CONSTRAINT [FK_PROYECTO_ES_OBJETIVO] FOREIGN KEY([NOMBRETIPOINV])
REFERENCES [dbo].[OBJETIVOINVENTARIO] ([NOMBRETIPOINV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_ES_OBJETIVO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] CHECK CONSTRAINT [FK_PROYECTO_ES_OBJETIVO]
GO
/****** Object:  ForeignKey [FK_PROYECTO_REALIZA_TIPODISE]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_REALIZA_TIPODISE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO]  WITH CHECK ADD  CONSTRAINT [FK_PROYECTO_REALIZA_TIPODISE] FOREIGN KEY([NOMTIPODISEMUEST])
REFERENCES [dbo].[TIPODISENOMUESTRAL] ([NOMTIPODISEMUEST])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_REALIZA_TIPODISE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTO]'))
ALTER TABLE [dbo].[PROYECTO] CHECK CONSTRAINT [FK_PROYECTO_REALIZA_TIPODISE]
GO
/****** Object:  ForeignKey [FK_PROYECTO_CONTENEDOR]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA]  WITH CHECK ADD  CONSTRAINT [FK_PROYECTO_CONTENEDOR] FOREIGN KEY([NROPROYCONTENEDOR])
REFERENCES [dbo].[PROYECTO] ([NROPROY])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA] CHECK CONSTRAINT [FK_PROYECTO_CONTENEDOR]
GO
/****** Object:  ForeignKey [FK_PROYECTO_CONTENIDOS]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENIDOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA]  WITH CHECK ADD  CONSTRAINT [FK_PROYECTO_CONTENIDOS] FOREIGN KEY([NROPROYCONTENIDO])
REFERENCES [dbo].[PROYECTO] ([NROPROY])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PROYECTO_CONTENIDOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROYECTOSPORETAPA]'))
ALTER TABLE [dbo].[PROYECTOSPORETAPA] CHECK CONSTRAINT [FK_PROYECTO_CONTENIDOS]
GO
/****** Object:  ForeignKey [FK_FORMULAR_DESARROLL_PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_DESARROLL_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO]  WITH CHECK ADD  CONSTRAINT [FK_FORMULAR_DESARROLL_PROYECTO] FOREIGN KEY([NROPROY])
REFERENCES [dbo].[PROYECTO] ([NROPROY])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_DESARROLL_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] CHECK CONSTRAINT [FK_FORMULAR_DESARROLL_PROYECTO]
GO
/****** Object:  ForeignKey [FK_FORMULAR_ES_REPONS_USUARIO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_ES_REPONS_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO]  WITH CHECK ADD  CONSTRAINT [FK_FORMULAR_ES_REPONS_USUARIO] FOREIGN KEY([NROUSUARIO])
REFERENCES [dbo].[USUARIO] ([NROUSUARIO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_ES_REPONS_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] CHECK CONSTRAINT [FK_FORMULAR_ES_REPONS_USUARIO]
GO
/****** Object:  ForeignKey [FK_FORMULAR_MANEJA_ESTRATO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_MANEJA_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO]  WITH CHECK ADD  CONSTRAINT [FK_FORMULAR_MANEJA_ESTRATO] FOREIGN KEY([CODEST])
REFERENCES [dbo].[ESTRATO] ([CODEST])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMULAR_MANEJA_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMULARIO]'))
ALTER TABLE [dbo].[FORMULARIO] CHECK CONSTRAINT [FK_FORMULAR_MANEJA_ESTRATO]
GO
/****** Object:  ForeignKey [FK_LISTADOD_LISTAESTR_ESTRATO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTAESTR_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS]  WITH CHECK ADD  CONSTRAINT [FK_LISTADOD_LISTAESTR_ESTRATO] FOREIGN KEY([CODEST])
REFERENCES [dbo].[ESTRATO] ([CODEST])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTAESTR_ESTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS] CHECK CONSTRAINT [FK_LISTADOD_LISTAESTR_ESTRATO]
GO
/****** Object:  ForeignKey [FK_LISTAESTRATOS_PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTAESTRATOS_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS]  WITH CHECK ADD  CONSTRAINT [FK_LISTAESTRATOS_PROYECTO] FOREIGN KEY([NROPROY])
REFERENCES [dbo].[PROYECTO] ([NROPROY])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTAESTRATOS_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESTRATOS]'))
ALTER TABLE [dbo].[LISTADODEESTRATOS] CHECK CONSTRAINT [FK_LISTAESTRATOS_PROYECTO]
GO
/****** Object:  ForeignKey [FK_LISTADOD_LISTADODE_ESPECIE]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTADODE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES]  WITH CHECK ADD  CONSTRAINT [FK_LISTADOD_LISTADODE_ESPECIE] FOREIGN KEY([CODESP])
REFERENCES [dbo].[ESPECIE] ([CODESP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOD_LISTADODE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES] CHECK CONSTRAINT [FK_LISTADOD_LISTADODE_ESPECIE]
GO
/****** Object:  ForeignKey [FK_LISTADOESPECIES_PROYECTO]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOESPECIES_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES]  WITH CHECK ADD  CONSTRAINT [FK_LISTADOESPECIES_PROYECTO] FOREIGN KEY([NROPROY])
REFERENCES [dbo].[PROYECTO] ([NROPROY])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LISTADOESPECIES_PROYECTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[LISTADODEESPECIES]'))
ALTER TABLE [dbo].[LISTADODEESPECIES] CHECK CONSTRAINT [FK_LISTADOESPECIES_PROYECTO]
GO
/****** Object:  ForeignKey [FK_LINEAREG_COMPLETA_FORMULAR]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_COMPLETA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION]  WITH CHECK ADD  CONSTRAINT [FK_LINEAREG_COMPLETA_FORMULAR] FOREIGN KEY([NROFORMULARIO])
REFERENCES [dbo].[FORMULARIO] ([NROFORMULARIO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_COMPLETA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION] CHECK CONSTRAINT [FK_LINEAREG_COMPLETA_FORMULAR]
GO
/****** Object:  ForeignKey [FK_LINEAREG_EVALUACIO_ESPECIE]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_EVALUACIO_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION]  WITH CHECK ADD  CONSTRAINT [FK_LINEAREG_EVALUACIO_ESPECIE] FOREIGN KEY([CODESP])
REFERENCES [dbo].[ESPECIE] ([CODESP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAREG_EVALUACIO_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAREGENERACION]'))
ALTER TABLE [dbo].[LINEAREGENERACION] CHECK CONSTRAINT [FK_LINEAREG_EVALUACIO_ESPECIE]
GO
/****** Object:  ForeignKey [FK_LINEANOM_RECOLECTA_FORMULAR]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEANOM_RECOLECTA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEANOMADERABLES]'))
ALTER TABLE [dbo].[LINEANOMADERABLES]  WITH CHECK ADD  CONSTRAINT [FK_LINEANOM_RECOLECTA_FORMULAR] FOREIGN KEY([NROFORMULARIO])
REFERENCES [dbo].[FORMULARIO] ([NROFORMULARIO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEANOM_RECOLECTA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEANOMADERABLES]'))
ALTER TABLE [dbo].[LINEANOMADERABLES] CHECK CONSTRAINT [FK_LINEANOM_RECOLECTA_FORMULAR]
GO
/****** Object:  ForeignKey [FK_LINEAINV_ASOCIADO_ESTADOSA]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_ASOCIADO_ESTADOSA]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_LINEAINV_ASOCIADO_ESTADOSA] FOREIGN KEY([ESTADO])
REFERENCES [dbo].[ESTADOSANITARIO] ([ESTADO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_ASOCIADO_ESTADOSA]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] CHECK CONSTRAINT [FK_LINEAINV_ASOCIADO_ESTADOSA]
GO
/****** Object:  ForeignKey [FK_LINEAINV_CONTIENE_ESPECIE]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_CONTIENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_LINEAINV_CONTIENE_ESPECIE] FOREIGN KEY([CODESP])
REFERENCES [dbo].[ESPECIE] ([CODESP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_CONTIENE_ESPECIE]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] CHECK CONSTRAINT [FK_LINEAINV_CONTIENE_ESPECIE]
GO
/****** Object:  ForeignKey [FK_LINEAINV_LLENA_FORMULAR]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_LLENA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_LINEAINV_LLENA_FORMULAR] FOREIGN KEY([NROFORMULARIO])
REFERENCES [dbo].[FORMULARIO] ([NROFORMULARIO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_LLENA_FORMULAR]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] CHECK CONSTRAINT [FK_LINEAINV_LLENA_FORMULAR]
GO
/****** Object:  ForeignKey [FK_LINEAINV_POSEE_CALIDAD]    Script Date: 10/13/2013 20:44:35 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_POSEE_CALIDAD]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_LINEAINV_POSEE_CALIDAD] FOREIGN KEY([CODCALIDAD])
REFERENCES [dbo].[CALIDAD] ([CODCALIDAD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LINEAINV_POSEE_CALIDAD]') AND parent_object_id = OBJECT_ID(N'[dbo].[LINEAINVENTARIO]'))
ALTER TABLE [dbo].[LINEAINVENTARIO] CHECK CONSTRAINT [FK_LINEAINV_POSEE_CALIDAD]
GO
/****** Object:  ForeignKey [FK_USO_TIPOUSO_TIPODEUS]    Script Date: 10/13/2013 20:44:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_TIPOUSO_TIPODEUS]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO]  WITH CHECK ADD  CONSTRAINT [FK_USO_TIPOUSO_TIPODEUS] FOREIGN KEY([NOMBRETIPOUSO])
REFERENCES [dbo].[TIPODEUSO] ([NOMBRETIPOUSO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_TIPOUSO_TIPODEUS]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO] CHECK CONSTRAINT [FK_USO_TIPOUSO_TIPODEUS]
GO
/****** Object:  ForeignKey [FK_USO_USADOPOR_LINEANOM]    Script Date: 10/13/2013 20:44:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_USADOPOR_LINEANOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO]  WITH CHECK ADD  CONSTRAINT [FK_USO_USADOPOR_LINEANOM] FOREIGN KEY([LINEANMAD])
REFERENCES [dbo].[LINEANOMADERABLES] ([LINEANMAD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USO_USADOPOR_LINEANOM]') AND parent_object_id = OBJECT_ID(N'[dbo].[USO]'))
ALTER TABLE [dbo].[USO] CHECK CONSTRAINT [FK_USO_USADOPOR_LINEANOM]
GO
