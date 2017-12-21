Imports System.Data.SqlClient
Imports System.Configuration
Module Module1

    Public conexionsql As New SqlConnection("Data source = 'DESKTOP-B3IP6AD\MANI'; initial catalog = 'MasterEA'; integrated security = true; MultipleActiveResultSets=True")
    'Public conexionsql As New SqlConnection("Data source = 'PRO'; initial catalog = 'MasterEA'; integrated security = true; MultipleActiveResultSets=True")

    Public comando As SqlCommand = conexionsql.CreateCommand
    Public lector As SqlDataReader
    Public transaccion As SqlTransaction
    Public transaccion2 As SqlTransaction

    Public transaccionMasterServidor As SqlTransaction

    Public cadenaLetra As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public cadenaDomicilio As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ.- "


    'conexion general 
    Public Conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public comandoGeneral As SqlCommand = Conexion.CreateCommand
    Public lectorGeneral As SqlDataReader

    Public conexionMasterServidor As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionMasterServidor").ConnectionString)
    Public comandoMasterServidor As SqlCommand = conexionMasterServidor.CreateCommand
    Public lectorMasterServidor As SqlDataReader

    Public Name As String
    Public canListas As Integer

    Public nombreBDCilo As String

    Public tipoAcceso As String


    Public kardexDetallado As Boolean = False
    Public constancia As Boolean = False
    Public constanciaNivAct As Boolean = False

    'Public conexionMasterServidor As New SqlConnection("Data source = 'DESKTOP-B3IP6AD\MANI'; initial catalog = 'master'; integrated security = true")
    'Public conexionMasterServidor As New SqlConnection("Data source = 'PRO'; initial catalog = 'master'; integrated security = true")
    Public contFalla As Integer
    Public frame As String = String.Empty
    Public descripcion As String = String.Empty
End Module
