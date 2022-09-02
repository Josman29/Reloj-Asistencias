Public Class Example
    Private Sub Example_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Login As New Datos.clsUSR
        DataGridView1.DataSource = Login.GetLogin("rodo", "123")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Login As New Datos.clsUSR
        DataGridView1.DataSource = Login.GetLogin("rodo", "123")
    End Sub
End Class