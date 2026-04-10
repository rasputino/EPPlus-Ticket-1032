Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Xml.Serialization
Imports EPPlus_Ticket_1032_V8.My.Resources
Imports OfficeOpenXml.Attributes

Public Class RegistroExportacionExcel
    Inherits RegistroBaseViewModel


    <EpplusTableColumn(Order:=Integer.MaxValue - 20)>
    <Display(Name:=NameOf(IdiomaRegistro.OficinaDeRegistro), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property OficinaRegistro As String

    <EpplusTableColumn(Order:=Integer.MaxValue - 40)>
    <Display(Name:=NameOf(IdiomaRegistro.Remitente), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property RemiteDestino As String



    <EpplusTableColumn(Order:=Integer.MaxValue - 30)>
    <Display(Name:=NameOf(IdiomaComun.NombreCompleto), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property ApellidoNombre As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 31)>
    <Display(Name:=NameOf(IdiomaComun.Documento), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property Documento As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 35)>
    <Display(Name:=NameOf(IdiomaRegistro.Remitente), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property RemiteDestinoRepresentante As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 39)>
    <Display(Name:=NameOf(IdiomaRegistro.Remitente), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property OposicionInteroperabilidad As String



    <EpplusTableColumn(Order:=Integer.MaxValue - 28)>
    <Display(Name:=NameOf(IdiomaComun.CorreoElectronico), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property CorreoElectronico As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 27)>
    <Display(Name:=NameOf(IdiomaComun.Dehs), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property DEH As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 26)>
    <Display(Name:=NameOf(IdiomaComun.Direccion), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property Direccion As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 25)>
    <Display(Name:=NameOf(IdiomaComun.CodigoPostal), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property CodPostal As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 24)>
    <Display(Name:=NameOf(IdiomaComun.Municipio), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property Municipio As String



    <EpplusTableColumn(Order:=Integer.MaxValue - 23)>
    <Display(Name:=NameOf(IdiomaComun.Provincia), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property Provincia As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 22)>
    <Display(Name:=NameOf(IdiomaComun.Pais), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property Pais As String


    <EpplusTableColumn(Order:=Integer.MaxValue - 30)>
    <Display(Name:=NameOf(IdiomaRegistro.CanalContacto), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property CanalContacto As String



    <EpplusTableColumn(Order:=Integer.MaxValue - 10)>
    <Display(Name:=NameOf(IdiomaRegistro.Remitente), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property ContenedoresOrigenDestino As String


    <EpplusTableColumn(Order:=-80)>
    <Display(Name:=NameOf(IdiomaComun.Ejercicio), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property Ejercicio As String



    <EpplusTableColumn(Order:=Integer.MaxValue - 3)>
    Public Property Enlace As String

    <EpplusTableColumn(Order:=Integer.MaxValue - 7)>
    Public ReadOnly Property SEGEX As String



    <EpplusTableColumn(Order:=Integer.MaxValue - 5)>
    <Display(Name:=NameOf(IdiomaComun.RefProcedencia), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property ProcedenciaId As String


    <EpplusTableColumn(Order:=Integer.MaxValue-2)>
    <Display(Name:=NameOf(IdiomaRegistro.Pago), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property Pago As String


    <EpplusTableColumn(Order:=Integer.MaxValue-1)>
    <Display(Name:=NameOf(IdiomaComun.Fecha), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property FechaPago As String



End Class
