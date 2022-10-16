Module modVariables

    'Variables Publicas Datos Usuario
    Public nomUser As String
    Public apeUser As String
    Public nicUser As String
    Public idUser As Integer
    Public titulo As String = "Reloj de Asistencias"

    Public Sub habilitaciones(group As GroupBox, numero As Integer)
        For Each texto In group.Controls
            If numero = 1 Then
                If TypeOf texto Is TextBox Then
                    texto.clear()
                    texto.enabled = False
                    texto.forecolor = Color.Green
                    texto.backcolor = Color.Black
                End If
            Else
                If TypeOf texto Is TextBox Then
                    If texto.name.ToString <> "txtID" Then
                        texto.enabled = True
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub ClearLabel(labell As Label)
        labell.Text = ""
    End Sub
    Public Sub MensajeError(mensaje As String)
        frmPrincipal.niPrincipal.BalloonTipTitle = "Reloj de Asistencias"
        frmPrincipal.niPrincipal.BalloonTipText = mensaje
        frmPrincipal.niPrincipal.ShowBalloonTip(1000)
    End Sub
End Module
