Imports System.Data.SqlClient
Imports System.Configuration
Module Module1

    Public conexionsql As New SqlConnection("Data source = 'DESKTOP-B3IP6AD\MANI'; initial catalog = 'MasterEA'; integrated security = true")
    'Public conexionsql As New SqlConnection("Data source = 'PRO'; initial catalog = 'MasterEA'; integrated security = true")

    Public comando As SqlCommand = conexionsql.CreateCommand
    Public lector As SqlDataReader
    Public transaccion As SqlTransaction
    Public transaccion2 As SqlTransaction

    Public cadenaLetra As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public cadenaDomicilio As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ.- "


    'conexion general 
    Public Conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public comandoGeneral As SqlCommand = Conexion.CreateCommand
    Public lectorGeneral As SqlDataReader

    Public Name As String
    Public canListas As Integer

    Public nombreBDCilo As String

    Public tipoAcceso As String

End Module
