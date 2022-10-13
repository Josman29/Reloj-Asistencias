Public Class frmMenu
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmPrincipal.AbrirFormulario(frmUSR)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPrincipal.AbrirFormulario(Form1)
    End Sub
End Class