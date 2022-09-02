Public Class Example
    Private Sub Example_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim coa As New Datos.clsUSR

        DataGridView1.DataSource = coa.GetLogin("rodo", "123")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim coa As New Datos.clsUSR

        DataGridView1.DataSource = coa.GetLogin("rodo", "123")
    End Sub
End Class