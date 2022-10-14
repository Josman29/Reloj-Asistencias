Public Class frmRegistroAsistencias
    Private Sub frmRegistroAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblHora.Text = Date.Now
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
        txtCodigo.focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblHora.Text = Date.Now
    End Sub
End Class