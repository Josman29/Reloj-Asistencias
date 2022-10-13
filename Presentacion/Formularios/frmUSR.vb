﻿Imports Datos
Imports Entidades

Public Class frmUSR
    Dim UsuarioFun As New clsUSR
    Dim UsuarioDatos As New EUSR
    Dim bandera As Boolean = True

#Region "Procesos"
    Private Sub Inicio()
        tsbCopiar.Enabled = False
        tsbPegar.Enabled = False
        tsbCortar.Enabled = False
        tsbEliminar.Enabled = False
        tsbCancelar.Enabled = False
        tsbGuardar.Enabled = False
        tsbNuevo.Enabled = True
        GetActivos()
        rdActivos.Checked = True
        habilitaciones(Me, 1)
    End Sub
    Private Sub GetActivos()
        dgvUsuarios.DataSource = UsuarioFun.GetUsuarios()
        dgvUsuarios.Columns(5).Visible = False
    End Sub
    Private Sub GetElimminados()
        dgvUsuarios.DataSource = UsuarioFun.GetEliminados()
    End Sub
    Private Sub Determinar()
        If rdActivos.Checked = True Then
            GetActivos()
        Else
            GetElimminados()
        End If
    End Sub
    Private Sub habilitar()
        tsbCopiar.Enabled = True
        tsbPegar.Enabled = True
        tsbCortar.Enabled = True
        tsbEliminar.Enabled = False
        tsbCancelar.Enabled = True
        tsbGuardar.Enabled = True
        tsbNuevo.Enabled = False
        tsbHabilitar.Enabled = False
        bandera = True
        habilitaciones(Me, 2)
        txtApellido.Focus()
    End Sub

#End Region

#Region "Eventos"
    Private Sub frmUSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()
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

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        habilitar()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Inicio()
    End Sub

    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        habilitar()
        bandera = False
        tsbEliminar.Enabled = True
        tsbHabilitar.Enabled = True
        txtID.Text = dgvUsuarios.SelectedCells(0).Value.ToString()
        txtApellido.Text = dgvUsuarios.SelectedCells(2).Value.ToString()
        txtNombre.Text = dgvUsuarios.SelectedCells(3).Value.ToString()
        txtNickName.Text = dgvUsuarios.SelectedCells(1).Value.ToString()
        txtPassword.Text = dgvUsuarios.SelectedCells(5).Value.ToString()
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If UsuarioFun.DelUsu(txtID.Text, idUser) Then
            Inicio()
        Else
            MsgBox("Hubo un error al intentar eliminar el usuario " & txtNickName.Text)
        End If
    End Sub

    Private Sub tsbHabilitar_Click(sender As Object, e As EventArgs) Handles tsbHabilitar.Click
        If UsuarioFun.RecUsu(txtID.Text) Then
            Inicio()
        Else
            MsgBox("Hubo un error al intentar recuperar el usuario " & txtNickName.Text)
        End If
    End Sub


    Private Sub MensajeError()
        MsgBox("Hubo un error.")
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click


        UsuarioDatos.USR_APE = txtApellido.Text
        UsuarioDatos.USR_NOM = txtNombre.Text
        UsuarioDatos.USR_PAS = txtPassword.Text
        UsuarioDatos.USR_NIC = txtNickName.Text
        UsuarioDatos.USR_CRE_ID = idUser

        If bandera Then

            If UsuarioFun.InsUsu(UsuarioDatos) Then
                Inicio()
            Else
                MensajeError()
            End If
        Else
            UsuarioDatos.USR_ID = txtID.Text
            If UsuarioFun.UpdUsu(UsuarioDatos) Then
                Inicio()
            Else
                MensajeError()
            End If
        End If
    End Sub
#End Region


End Class