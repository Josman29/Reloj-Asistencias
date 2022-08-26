'Formulario Principal del proyecto
'Autor: Medina Rodolfo
'Descripción: Practica de Orquestación de Aplicaciones

Public Class frmPrincipal

#Region "Botones"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiSalir.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub tsmiOpciones_Click(sender As Object, e As EventArgs) Handles tsmiOpciones.Click
        frmOpciones.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormulario(frmOpciones)
    End Sub

#End Region

#Region "Procesos"

    Private Sub AbrirFormulario(f As Form)
        pnlPrincipal.Controls.Clear()
        f.TopLevel = False
        f.FormBorderStyle = BorderStyle.None
        pnlPrincipal.Controls.Add(f)
        f.Show()
    End Sub

#End Region

End Class
