Imports Datos

Public Class frmUSR
    Dim Usuario As New clsUSR
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

        Limpiar()
    End Sub
    Private Sub GetActivos()
        dgvUsuarios.DataSource = Usuario.GetUsuarios()
        dgvUsuarios.Columns(5).Visible = False
    End Sub
    Private Sub GetElimminados()
        dgvUsuarios.DataSource = Usuario.GetEliminados()
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

        txtApellido.Enabled = True
        txtNombre.Enabled = True
        txtNickName.Enabled = True
        txtPassword.Enabled = True
        txtApellido.Focus()


    End Sub
    Private Sub Limpiar()
        txtApellido.Clear()
        txtNombre.Clear()
        txtID.Clear()
        txtNickName.Clear()
        txtPassword.Clear()

        txtApellido.Enabled = False
        txtNombre.Enabled = False
        txtID.Enabled = False
        txtNickName.Enabled = False
        txtPassword.Enabled = False


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
        tsbEliminar.Enabled = True
        tsbHabilitar.Enabled = True
        txtID.Text = dgvUsuarios.SelectedCells(0).Value.ToString()
        txtApellido.Text = dgvUsuarios.SelectedCells(2).Value.ToString()
        txtNombre.Text = dgvUsuarios.SelectedCells(3).Value.ToString()
        txtNickName.Text = dgvUsuarios.SelectedCells(1).Value.ToString()
        txtPassword.Text = dgvUsuarios.SelectedCells(5).Value.ToString()
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If Usuario.DelUsu(txtID.Text, idUser) Then
            Inicio()
        Else
            MsgBox("Hubo un error al intentar eliminar el usuario " & txtNickName.Text)
        End If
    End Sub

    Private Sub tsbHabilitar_Click(sender As Object, e As EventArgs) Handles tsbHabilitar.Click
        If Usuario.RecUsu(txtID.Text) Then
            Inicio()
        Else
            MsgBox("Hubo un error al intentar recuperar el usuario " & txtNickName.Text)
        End If
    End Sub
#End Region


End Class