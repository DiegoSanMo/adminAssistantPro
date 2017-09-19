Imports System.Data.SqlClient

Module Module1

    Public conexionsql As New SqlConnection("Data source = 'DESKTOP-B3IP6AD\MANI'; initial catalog = 'MasterEA'; integrated security = true")
    'Public conexionsql As New SqlConnection("Data source = 'PRO'; initial catalog = 'MasterEA'; integrated security = true")
    Public comando As SqlCommand = conexionsql.CreateCommand
    Public lector As SqlDataReader
    Public transaccion As SqlTransaction
    Public transaccion2 As SqlTransaction

    Public cadenaLetra As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public cadenaDomicilio As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ.- "

End Module
