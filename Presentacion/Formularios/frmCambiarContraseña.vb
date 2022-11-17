Imports System.Data.Sql
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.CrystalReports.Engine
Imports Datos

Public Class frmCambiarContraseña
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrar.CheckedChanged
        If chkMostrar.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub frmCambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = nicUser
        txtUsuario.Enabled = False

    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        If txtpassnew.Text <> txtPassword2.Text Then
            Ep.SetError(txtPassword2, "La Contraseña no coincide")
            Return

        Else
            Dim Usuario As New clsUSR
            Dim Log As New DataTable
            Log = Usuario.UpdPasNew(txtUsuario.Text, txtpassword.Text, txtpassnew.Text)
            If Log(0)(0) = 0 Then
                MensajeError("Se ha Actualizado La Contraseña")
                Limpiar(Me.GroupBox1)
            Else
                MensajeError("Error de Autenticacion")
            End If

        End If
    End Sub
End Class