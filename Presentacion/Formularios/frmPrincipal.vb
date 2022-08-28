'Formulario Principal del proyecto
'Autor: Medina Rodolfo
'Descripción: Practica de Orquestación de Aplicaciones

Public Class frmPrincipal

#Region "Botones"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiSalir.Click
        'Cierro aplicacion
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        'Cierro aplicacion
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub tsmiOpciones_Click(sender As Object, e As EventArgs) Handles tsmiOpciones.Click
        'Utilizo la funcion abrir Formulario frmOpciones
        AbrirFormulario(frmOpciones)
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Utilizo la funcion abrir Formulario frmLogin
        AbrirFormulario(frmLogin)
    End Sub

    Public Sub AbrirFormulario(f As Form)
        'Limpio los controles existentes en el panel
        pnlPrincipal.Controls.Clear()
        'Establezco la propiedad toplevel del formualrio en falso para poder agregar un formulario dentro de otro
        f.TopLevel = False
        'Quito los bordes del formulario a abrir dentro del panel
        f.FormBorderStyle = FormBorderStyle.None
        'Agrego el control al panel
        pnlPrincipal.Controls.Add(f)
        'Muestro el formulario en pantalla
        f.Show()
        f.Dock = DockStyle.Fill
    End Sub

    Private Sub tsmiIniciar_Click(sender As Object, e As EventArgs) Handles tsmiIniciar.Click
        'Utilizo la funcion abrir Formulario frmLogin
        AbrirFormulario(frmLogin)
    End Sub

#End Region



End Class
