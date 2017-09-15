Imports System.Data.SqlClient

Module Module1

    Public conexionsql As New SqlConnection("Data source = 'DESKTOP-B3IP6AD\MANI'; initial catalog = 'EasyEnglish'; integrated security = true")
    Public comando As SqlCommand = conexionsql.CreateCommand
    Public lector As SqlDataReader
    Public transaccion As SqlTransaction

    Public cadenaLetra As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public cadenaDomicilio As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ.- "

End Module
