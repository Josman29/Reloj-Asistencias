Imports Datos

Public Class frmUSR

    Private Sub GetActivos()
        Dim Usuario As New clsUSR
        dgvUsuarios.DataSource = Usuario.GetUsuarios()
    End Sub
    Private Sub GetElimminados()
        Dim Usuario As New clsUSR
        dgvUsuarios.DataSource = Usuario.GetEliminados()
    End Sub
    Private Sub frmUSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdActivos.Checked = True
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
        frmPrincipal.AbrirFormulario(frmMenu)
    End Sub

    Private Sub rdActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rdActivos.CheckedChanged
        Determinar()
    End Sub

    Private Sub rdEliminados_CheckedChanged(sender As Object, e As EventArgs) Handles rdEliminados.CheckedChanged
        Determinar()
    End Sub
    Private Sub Determinar()
        If rdActivos.Checked = True Then
            GetActivos()
        Else
            GetElimminados()
        End If
    End Sub
End Class