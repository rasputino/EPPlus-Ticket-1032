Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Xml.Serialization
Imports EPPlus_Ticket_1032_V8_Fix.My.Resources
Imports OfficeOpenXml.Attributes

<Serializable>
Public MustInherit Class RegistroBaseViewModel

    <EpplusTableColumn(Order:=-100)>
    Public ReadOnly Property Id As Integer

    <Display(Name:=NameOf(IdiomaRegistro.NumReg), ResourceType:=GetType(IdiomaRegistro), Order:=-90)>
    Public ReadOnly Property NumRegistro As Integer?

    <Display(Name:=NameOf(IdiomaComun.Resumen), ResourceType:=GetType(IdiomaComun), Order:=-60)>
    Public ReadOnly Property Resumen As String

    <Display(Name:=NameOf(IdiomaRegistro.Asunto), ResourceType:=GetType(IdiomaRegistro), Order:=-55)>
    Public ReadOnly Property Asunto As String

    <Display(Name:=NameOf(IdiomaRegistro.UnidadOrganica), ResourceType:=GetType(IdiomaRegistro), Order:=-50)>
    Public ReadOnly Property UnidadOrganica As String

    <Display(Name:=NameOf(IdiomaRegistro.Oficina), ResourceType:=GetType(IdiomaRegistro), Order:=-45)>
    Public ReadOnly Property OficinaOrigenDescripcion As String

    <Display(Name:=NameOf(IdiomaRegistro.Completo), ResourceType:=GetType(IdiomaRegistro), Order:=100)>
    Public ReadOnly Property FechaCompleto As Date?

    <Display(Name:=NameOf(IdiomaRegistro.Archivado), ResourceType:=GetType(IdiomaRegistro), Order:=110)>
    Public ReadOnly Property Archivado As Boolean

    <Display(Name:=NameOf(IdiomaRegistro.Completo), ResourceType:=GetType(IdiomaRegistro), Order:=120), UIHint("booleano")>
    Public ReadOnly Property Completo As Boolean

    <Display(Name:=NameOf(IdiomaRegistro.Factura), ResourceType:=GetType(IdiomaRegistro), Order:=130)>
    Public ReadOnly Property Factura As Boolean

    <Display(Name:=NameOf(IdiomaComun.Fecha), ResourceType:=GetType(IdiomaComun), Order:=-40)>
    Public ReadOnly Property FechaSistema As Date

    <Display(Name:=NameOf(IdiomaRegistro.NumFactura), ResourceType:=GetType(IdiomaRegistro), Order:=140)>
    Public ReadOnly Property NumFactura As String

    <Display(Name:=NameOf(IdiomaRegistro.ImporteFactura), ResourceType:=GetType(IdiomaRegistro), Order:=150)>
    Public ReadOnly Property ImporteFactura As Decimal?

    <Display(Name:=NameOf(IdiomaRegistro.SufijoRemiteDestino), ResourceType:=GetType(IdiomaRegistro), Order:=160)>
    Public ReadOnly Property SufijoRemiteDestino As String

    Public Enum TipoEstadoRegistroColumnaIndice
        Incompleto = 1
        Completo = 2
        PendienteEnvio = 3
        Devuelto = 4
        Archivado = 5
        Borrador = 6
        Sir = 7
    End Enum

    <Display(Name:=NameOf(IdiomaComun.Estado), ResourceType:=GetType(IdiomaComun), Order:=170)>
    Public ReadOnly Property EstadoRegistro As TipoEstadoRegistroColumnaIndice

    <EpplusTableColumn(Order:=180)>
    Public ReadOnly Property ArchivadoObservaciones As String

    <Display(Name:=NameOf(IdiomaRegistro.Devuelto), ResourceType:=GetType(IdiomaRegistro), Order:=190)>
    Public ReadOnly Property ObservacionesDevolucion As String

    Public ReadOnly Property SEGEX As String

    <Display(Name:=NameOf(IdiomaRegistro.Pago), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property Pago As String

    <Display(Name:=NameOf(IdiomaComun.Fecha), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property FechaPago As String

End Class