Imports System.Data.SqlClient

Module Module1

    Public conexionsql As New SqlConnection("Data source = 'PRO'; initial catalog = 'EasyEnglish'; integrate security = true")
    Public comando As SqlCommand = conexionsql.CreateCommand
    Public lector As SqlDataReader



    Public cadenaLetra As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public cadenaDomicilio As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ.- "

End Module
