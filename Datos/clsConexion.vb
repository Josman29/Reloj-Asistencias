Imports System.Data.SqlClient

Public Class clsConexion
    Public con As New SqlConnection

    Public Function Conectado()
        Try
            con = New SqlConnection("data source=DESKTOP-D5FL463\SQLEXPRESS;initial catalog=Sistema; Integrated Security = True")
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectado()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class