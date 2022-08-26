Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmOpciones

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Me.Opacity = TrackBar1.Value / 100
        Label1.Text = TrackBar1.Value & "%"

    End Sub

    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = TrackBar1.Value & "%"
    End Sub
End Class