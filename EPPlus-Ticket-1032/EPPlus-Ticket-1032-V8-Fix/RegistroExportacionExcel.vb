Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Xml.Serialization
Imports EPPlus_Ticket_1032_V8_Fix.My.Resources
Imports OfficeOpenXml.Attributes

Public Class RegistroExportacionExcel
    Inherits RegistroBaseViewModel

    <Display(Name:=NameOf(IdiomaRegistro.OficinaDeRegistro), ResourceType:=GetType(IdiomaRegistro), Order:=Integer.MaxValue - 20)>
    Public ReadOnly Property OficinaRegistro As String

    <Display(Name:=NameOf(IdiomaRegistro.Remitente), ResourceType:=GetType(IdiomaRegistro), Order:=Integer.MaxValue - 40)>
    Public ReadOnly Property RemiteDestino As String

    <Display(Name:=NameOf(IdiomaComun.NombreCompleto), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 30)>
    Public ReadOnly Property ApellidoNombre As String

    <Display(Name:=NameOf(IdiomaComun.Documento), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 31)>
    Public ReadOnly Property Documento As String

    <Display(Name:=NameOf(IdiomaComun.Representante), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 35)>
    Public ReadOnly Property RemiteDestinoRepresentante As String

    <Display(Name:=NameOf(IdiomaRegistro.OposicionInteroperabilidad), ResourceType:=GetType(IdiomaRegistro), Order:=Integer.MaxValue - 39)>
    Public ReadOnly Property OposicionInteroperabilidad As String

    <Display(Name:=NameOf(IdiomaComun.CorreoElectronico), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 28)>
    Public ReadOnly Property CorreoElectronico As String

    <Display(Name:=NameOf(IdiomaComun.Dehs), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 27)>
    Public ReadOnly Property DEH As String

    <Display(Name:=NameOf(IdiomaComun.Direccion), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 26)>
    Public ReadOnly Property Direccion As String

    <Display(Name:=NameOf(IdiomaComun.CodigoPostal), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 25)>
    Public ReadOnly Property CodPostal As String

    <Display(Name:=NameOf(IdiomaComun.Municipio), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 24)>
    Public ReadOnly Property Municipio As String

    <Display(Name:=NameOf(IdiomaComun.Provincia), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 23)>
    Public ReadOnly Property Provincia As String

    <Display(Name:=NameOf(IdiomaComun.Pais), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 22)>
    Public ReadOnly Property Pais As String

    <Display(Name:=NameOf(IdiomaRegistro.CanalContacto), ResourceType:=GetType(IdiomaRegistro), Order:=Integer.MaxValue - 30)>
    Public ReadOnly Property CanalContacto As String

    <Display(Name:=NameOf(IdiomaRegistro.ContenedoresDeOrigen), ResourceType:=GetType(IdiomaRegistro), Order:=Integer.MaxValue - 10)>
    Public ReadOnly Property ContenedoresOrigenDestino As String

    <Display(Name:=NameOf(IdiomaComun.Ejercicio), ResourceType:=GetType(IdiomaComun), Order:=-80)>
    Public ReadOnly Property Ejercicio As String

    <EpplusTableColumn(Order:=Integer.MaxValue - 3)>
    Public Property Enlace As String

    <EpplusTableColumn(Order:=Integer.MaxValue - 7)>
    Public ReadOnly Property SEGEX As String

    <Display(Name:=NameOf(IdiomaComun.RefProcedencia), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 5)>
    Public ReadOnly Property ProcedenciaId As String

    <Display(Name:=NameOf(IdiomaRegistro.Pago), ResourceType:=GetType(IdiomaRegistro), Order:=Integer.MaxValue - 2)>
    Public ReadOnly Property Pago As String

    <Display(Name:=NameOf(IdiomaComun.Fecha), ResourceType:=GetType(IdiomaComun), Order:=Integer.MaxValue - 1)>
    Public ReadOnly Property FechaPago As String

End Class