Imports System.Data.SqlClient
Public Class clsConexion

    Public con As New SqlConnection

    Public Function Conectado()
        Try
            con = New SqlConnection("data source=NOTE01\RMEDINA;initial catalog=SGRM; Integrated Security = True")
            'con = New SqlConnection("data source=192.168.1.3,1433;initial catalog=SGRM; user id=sa;password=samsung")
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            End
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
