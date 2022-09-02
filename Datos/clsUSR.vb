Imports System.Data.SqlClient
Public Class clsUSR

    Inherits clsConexion
    Dim cmd As New SqlCommand

    Public Function GetLogin(usu As String, pas As String) As DataTable
        With cmd
            Conectado()
            cmd = New SqlCommand("SP_USU_GET_LOG")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@USR_NIC", usu)
            cmd.Parameters.AddWithValue("@USR_PAS", pas)
            cmd.Connection = con
            cmd.CommandTimeout = 999999999


            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt

        End With
    End Function

End Class
