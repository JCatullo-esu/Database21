Public Class MainMenu


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim menu = New SalesLogin()
        menu.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmenu = New CustomerLogin()
        cmenu.Show()
    End Sub
End Class