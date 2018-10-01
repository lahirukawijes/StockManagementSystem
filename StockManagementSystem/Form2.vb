Public Class Form2
    Private con As New System.Data.SqlClient.SqlConnection
    Private com As New System.Data.SqlClient.SqlCommand
    Private adp As New System.Data.SqlClient.SqlDataAdapter
    Private DS As New DataSet
    Public trtype As String
    Public Stockbal, quan, newstcbal, totprice, ItPrice As Integer


    Private Sub Form2_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Data Source=GLPWIJESINGHE-L;Initial Catalog=StockManagementSystem;Integrated Security=True"
            txtItCode.Select()
            btnCal.Enabled = False
            btnup.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub clear()
        txtItCode.Clear()
        txtItName.Clear()
        txtItPrice.Clear()
        txttotprice.Clear()
        txtQuan.Clear()
        txtStockBal.Clear()
        txtLDOT.Clear()
        txtNwStockBal.Clear()
    End Sub

    Private Sub btnclr_Click(sender As System.Object, e As System.EventArgs) Handles btnclr.Click
        Dim MSG1 As Integer
        MSG1 = MsgBox("Do you want to clear the form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Clear")
        If MSG1 = vbYes Then
            clear()
            txtItCode.Focus()
        Else
            txtItCode.Focus()
        End If
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Dim MSG2 As Integer
        MSG2 = MsgBox("Do you want to close the form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Close")
        If MSG2 = vbYes Then
            Me.Close()
        Else
            txtItCode.Focus()
        End If
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        Try
            con.Open()
            adp = New System.Data.SqlClient.SqlDataAdapter("Select * from SMF Where ItemCode='" + txtItCode.Text + "'", con)
            DS.Clear()
            adp.Fill(DS, "StockManagementSystem")
            Dim result As Integer
            result = DS.Tables(0).Rows.Count
            If result = 1 Then

                If MsgBox("Do you want to view record?", MsgBoxStyle.YesNo, "Record found") = MsgBoxResult.Yes Then
                    txtItName.Text = DS.Tables("StockManagementSystem").Rows(0).Item(1)
                    txtStockBal.Text = DS.Tables("StockManagementSystem").Rows(0).Item(3)
                    txtItPrice.Text = DS.Tables("StockManagementSystem").Rows(0).Item(2)
                Else
                    txtItCode.Clear()
                    txtItCode.Focus()
                End If
            Else
                MsgBox("Record not found", MsgBoxStyle.Information)
                clear()
                txtItCode.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub

    Private Sub IssuedIn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IssuedIn.CheckedChanged
        trtype = IssuedIn.Text
    End Sub

    Private Sub IssuedOut_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IssuedOut.CheckedChanged
        trtype = IssuedOut.Text
    End Sub

    Private Sub ReturnIn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ReturnIn.CheckedChanged
        trtype = ReturnIn.Text
    End Sub

    Private Sub Returnout_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Returnout.CheckedChanged
        trtype = Returnout.Text
    End Sub

    Private Sub txtQuan_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtQuan.TextChanged
        btnCal.Enabled = True
    End Sub

    Private Sub btnCal_Click(sender As System.Object, e As System.EventArgs) Handles btnCal.Click
        Stockbal = txtStockBal.Text
        quan = txtQuan.Text
        ItPrice = txtItPrice.Text
        If IssuedIn.Checked Then
            newstcbal = Stockbal + quan
        ElseIf IssuedOut.Checked Then
            newstcbal = Stockbal - quan
        ElseIf ReturnIn.Checked Then
            newstcbal = Stockbal + quan
        ElseIf Returnout.Checked Then
            newstcbal = Stockbal - quan
        End If
        txtNwStockBal.Text = newstcbal
        totprice = quan * ItPrice
        txttotprice.Text = totprice
    End Sub

    Private Sub txtLDOT_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLDOT.TextChanged
        btnup.Enabled = True
    End Sub

    Private Sub btnup_Click(sender As System.Object, e As System.EventArgs) Handles btnup.Click
        'updating SMF
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "Update SMF Set StockBalance='" + txtNwStockBal.Text + "',LastDateofTransaction='" + txtLDOT.Text + "' Where ItemCode='" + txtItCode.Text + "'"
            Dim Msg As Integer
            Msg = MsgBox("Do you really want to update SMF?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Update Item")
            If Msg = vbYes Then
                com.ExecuteNonQuery()
                MsgBox("Updated successfully", MsgBoxStyle.Information, "Updated")
            Else
                clear()
                txtItCode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()

        'UPDATING TRF
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "Insert into TRF (ItemCode, ItemName, ItemPrice, TransactionType, Quantity, TotalPrice, NewStockBalance, LastDateofTransaction) values('" + txtItCode.Text + "','" + txtItName.Text + "','" + txtItPrice.Text + "','" + trtype + "','" + txtQuan.Text + "','" + txttotprice.Text + "','" + txtNwStockBal.Text + "','" + txtLDOT.Text + "')"
            Dim Msg As Integer
            Msg = MsgBox("Do you really want to update TRF?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Update Item")
            If Msg = vbYes Then
                com.ExecuteNonQuery()
                MsgBox("Updated successfully", MsgBoxStyle.Information, "Updated")
                clear()
                txtItCode.Focus()
            Else
                clear()
                txtItCode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub

    Private Sub btnsearch_MouseHover(sender As Object, e As System.EventArgs) Handles btnsearch.MouseHover
        Try
            Dim msg As Integer
            If txtItCode.Text = "" Then
                msg = MsgBox("Item Code cannot be blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtItCode.Focus()
                    clear()
                End If
            ElseIf Len(txtItCode.Text) <> 4 Then
                msg = MsgBox("Wrong Item Code length.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtItCode.Focus()
                    clear()
                End If

            ElseIf Not IsNumeric(txtItCode.Text) Then
                msg = MsgBox("Item Code must be numeric.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtItCode.Focus()
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class
