Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiSalir.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub tsmiOpciones_Click(sender As Object, e As EventArgs) Handles tsmiOpciones.Click
        frmOpciones.ShowDialog()
    End Sub
End Class
