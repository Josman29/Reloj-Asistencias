﻿Imports Datos

Public Class frmLogin
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrar.CheckedChanged
        If chkMostrar.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Login()

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If

    End Sub

    Private Sub Login()
        Dim Usuario As New clsUSR
        Dim tabla As New DataTable
        tabla = Usuario.GetLogin(txtUsuario.Text, txtPassword.Text)

        If tabla.Rows.Count > 0 Then
            nicUser = tabla(0)(0)
            apeUser = tabla(0)(1)
            nomUser = tabla(0)(2)
            idUser = tabla(0)(3)
            frmPrincipal.Text = titulo & " - " & apeUser & " " & nomUser
            frmPrincipal.tsslNombreUsuario.Text = nicUser
            frmPrincipal.tsslNombreUsuario.Visible = True
            frmPrincipal.tsslUsuariotext.Visible = True
            frmPrincipal.AbrirFormulario(frmMenu)
            frmPrincipal.tsmiIniciar.Enabled = False
            frmPrincipal.tsmiCerrar.Enabled = True
            Me.Close()
        Else
            MsgBox("Usuario incorrecto")
        End If
    End Sub

End Class