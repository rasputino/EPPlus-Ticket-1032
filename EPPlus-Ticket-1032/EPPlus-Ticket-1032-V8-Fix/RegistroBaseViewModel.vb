Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Xml.Serialization
Imports EPPlus_Ticket_1032_V8_Fix.My.Resources
Imports OfficeOpenXml.Attributes

<Serializable>
Public MustInherit Class RegistroBaseViewModel

    <EpplusTableColumn(Order:=-100)>
    Public ReadOnly Property Id As Integer

    <EpplusTableColumn(Order:=-90)>
    <Display(Name:=NameOf(IdiomaRegistro.NumReg), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property NumRegistro As Integer?

    <EpplusTableColumn(Order:=-60)>
    <Display(Name:=NameOf(IdiomaComun.Resumen), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property Resumen As String


    <EpplusTableColumn(Order:=-55)>
    <Display(Name:=NameOf(IdiomaRegistro.Asunto), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property Asunto As String

    <EpplusTableColumn(Order:=-50)>
    <Display(Name:=NameOf(IdiomaRegistro.UnidadOrganica), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property UnidadOrganica As String

    <EpplusTableColumn(Order:=-45)>
    <Display(Name:=NameOf(IdiomaRegistro.Oficina), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property OficinaOrigenDescripcion As String


    <EpplusTableColumn(Order:=100)>
    <Display(Name:=NameOf(IdiomaRegistro.Completo), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property FechaCompleto As Date?

    <EpplusTableColumn(Order:=110)>
    <Display(Name:=NameOf(IdiomaRegistro.Archivado), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property Archivado As Boolean


    <EpplusTableColumn(Order:=120)>
    <Display(Name:=NameOf(IdiomaRegistro.Completo), ResourceType:=GetType(IdiomaRegistro)), UIHint("booleano")>
    Public ReadOnly Property Completo As Boolean

    <EpplusTableColumn(Order:=130)>
    <Display(Name:=NameOf(IdiomaRegistro.Factura), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property Factura As Boolean

    <EpplusTableColumn(Order:=-40)>
    <Display(Name:=NameOf(IdiomaComun.Fecha), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property FechaSistema As Date

    <EpplusTableColumn(Order:=140)>
    <Display(Name:=NameOf(IdiomaRegistro.NumFactura), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property NumFactura As String

    <EpplusTableColumn(Order:=150)>
    <Display(Name:=NameOf(IdiomaRegistro.ImporteFactura), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property ImporteFactura As Decimal?

    <EpplusTableColumn(Order:=160)>
    <Display(Name:=NameOf(IdiomaRegistro.SufijoRemiteDestino), ResourceType:=GetType(IdiomaRegistro))>
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

    <EpplusTableColumn(Order:=170)>
    <Display(Name:=NameOf(IdiomaComun.Estado), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property EstadoRegistro As TipoEstadoRegistroColumnaIndice


    <EpplusTableColumn(Order:=180)>
    Public ReadOnly Property ArchivadoObservaciones As String


    <EpplusTableColumn(Order:=190)>
    <Display(Name:=NameOf(IdiomaRegistro.Devuelto), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property ObservacionesDevolucion As String
    

    Public ReadOnly Property SEGEX As String

    <Display(Name:=NameOf(IdiomaRegistro.Pago), ResourceType:=GetType(IdiomaRegistro))>
    Public ReadOnly Property Pago As String


    <Display(Name:=NameOf(IdiomaComun.Fecha), ResourceType:=GetType(IdiomaComun))>
    Public ReadOnly Property FechaPago As String

End Class