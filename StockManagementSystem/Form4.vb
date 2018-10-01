Public Class Form4

    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        If txtname.Text = "admin" And txtpwrd.Text = "11111" Then
            Form5.Show()
            Me.Hide()
            txtname.Clear()
            txtpwrd.Clear()
            txtname.Focus()
        Else
            MsgBox("Sorry, username or password Incorrect!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid")
            txtname.Clear()
            txtpwrd.Clear()
            txtname.Focus()
        End If
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtname.Select()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
End Class