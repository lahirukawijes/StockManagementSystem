Public Class Form5
    'StockManagementSystem
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
    End Sub

    Private Sub StockMasterFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockMasterFileToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub TransactionProcessionFileToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles TransactionProcessionFileToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub SupplierRegistrationToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles SupplierRegistrationToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim msg As Integer
        msg = MsgBox("Do you really want to logout?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Logout")
        If msg = vbYes Then
            Form1.Close()
            Form2.Close()
            Form3.Close()
            'Form4.Close()
            Form6.Close()
            Form7.Close()
            Me.Close()
            MsgBox("Logged out successfully.Have a nice day!", MsgBoxStyle.Information, "Logged out!")
            Form4.Show()
        Else
            Form1.Close()
            Form2.Close()
            Form3.Close()
            Form6.Close()
            Form7.Close()
        End If
    End Sub

    Private Sub TransactionProToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransactionProToolStripMenuItem.Click
        Form6.MdiParent = Me
        Form6.Show()
    End Sub

    Private Sub SupplierDetailReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierDetailReportToolStripMenuItem.Click
        Form7.MdiParent = Me
        Form7.Show()
    End Sub
End Class
