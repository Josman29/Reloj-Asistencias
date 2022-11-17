
Imports Datos
Imports Entidades

Public Class FrmEMP
    Dim EmpleadosFun As New clsEMP
    Dim EmpleadosDatos As New EEMP
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
        CmbSector.Enabled = False
        GetActivos()
        rdActivos.Checked = True
        habilitaciones(Me.gbDatos, 1)
    End Sub
    Private Sub GetActivos()
        dgvEmpleados.DataSource = EmpleadosFun.GetEmpleados()

    End Sub
    Private Sub GetElimminados()
        dgvEmpleados.DataSource = EmpleadosFun.GetEliminados()
    End Sub
    Private Sub Determinar()
        If rdActivos.Checked = True Then
            GetActivos()
            tsbHabilitar.Enabled = False
        Else
            GetElimminados()
            tsbHabilitar.Enabled = True
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
        CmbSector.Enabled = True
        habilitaciones(Me.gbDatos, 2)
        txtDNI.Focus()
        CargarCmb()
    End Sub

#End Region


#Region "Eventos"
    Private Sub FrmEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        habilitar()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Inicio()
    End Sub

    Private Sub dgvEmpleados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentDoubleClick
        habilitar()
        bandera = False
        tsbEliminar.Enabled = True
        If rdEliminados.Checked = True Then
            tsbHabilitar.Enabled = True
        End If
        txtID.Text = dgvEmpleados.SelectedCells(0).Value.ToString()
        txtDNI.Text = dgvEmpleados.SelectedCells(1).Value.ToString()
        txtApellido.Text = dgvEmpleados.SelectedCells(2).Value.ToString()
        txtNombre.Text = dgvEmpleados.SelectedCells(3).Value.ToString()
        txtDireccion.Text = dgvEmpleados.SelectedCells(4).Value.ToString()
        CmbSector.Text = dgvEmpleados.SelectedCells(5).Value.ToString()

    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta por eliminar un registro, ¿Desea continuar?", "Eliminar usuario " & txtApellido.Text & "," & txtNombre.Text, MessageBoxButtons.YesNoCancel)
        If resultado = DialogResult.Yes Then
            If EmpleadosFun.DelEmp(txtID.Text, idUser) Then
                Inicio()
            Else
                MensajeError("Hubo un error al intentar eliminar el empleado " & txtID.Text)
            End If
        End If
    End Sub

    Private Sub tsbHabilitar_Click(sender As Object, e As EventArgs) Handles tsbHabilitar.Click
        If EmpleadosFun.RecEmp(txtID.Text) Then
            Inicio()
        Else
            MensajeError("Hubo un error al intentar recuperar el usuario " & txtID.Text)
        End If
    End Sub
    Private Sub CargarCmb()
        CmbSector.DataSource = EmpleadosFun.Sectores()
        CmbSector.ValueMember = "SEC_ID"
        CmbSector.DisplayMember = "SEC_NOM"
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        ep.Clear()
        If txtDNI.Text = " " Then
            ep.SetError(txtDNI, " DNI no existente")
            Return
        End If
        EmpleadosDatos.EMP_APE = txtApellido.Text
        EmpleadosDatos.EMP_NOM = txtNombre.Text
        EmpleadosDatos.EMP_DNI = txtDNI.Text
        EmpleadosDatos.EMP_DIR = txtDireccion.Text
        EmpleadosDatos.EMP_SEC_ID = CmbSector.SelectedIndex
        EmpleadosDatos.EMP_DAT_NAC = DtpFecNac.Value
        EmpleadosDatos.EMP_CRE_ID = idUser
        If bandera Then
            If EmpleadosFun.InsEmp(EmpleadosDatos) Then
                MensajeError("Registro grabado exitosamente.")
                Inicio()
            Else
                MensajeError("Sucedio un error al intentar grabar el usuario.")
            End If
        Else
            EmpleadosDatos.EMP_ID = txtID.Text
            If EmpleadosFun.UpdEmp(EmpleadosDatos) Then
                MensajeError("Registro actualizado exitosamente.")
                Inicio()
            Else
                MensajeError("Ocurrio un error al intentar guardar los cambios")
            End If
        End If
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        FrmReporteEmpleado.Show()
    End Sub


#End Region





End Class

