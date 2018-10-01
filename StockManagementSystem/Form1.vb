Public Class Form1
    Private con As New System.Data.SqlClient.SqlConnection
    Private com As New System.Data.SqlClient.SqlCommand
    Private adp As New System.Data.SqlClient.SqlDataAdapter
    Private DS As New DataSet

    Private Sub Form1_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Data Source=GLPWIJESINGHE-L;Initial Catalog=StockManagementSystem;Integrated Security=True"
            txtItCode.Select()
            btnedit.Enabled = False
            btnclr.Enabled = False
            btndel.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub clear()
        txtItCode.Clear()
        txtItName.Clear()
        txtItPrice.Clear()
        txtStockBal.Clear()
        txtStoreLoc.Clear()
        txtStockLevel.Clear()
        txtLDOT.Clear()
        txtItCode.Focus()
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

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dim MSG2 As Integer
        MSG2 = MsgBox("Do you want to close the form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Close")
        If MSG2 = vbYes Then
            Me.Close()
        Else
            txtItCode.Focus()
        End If
    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "insert into SMF (ItemCode,ItemName,ItemPrice,StockBalance,StoreLocation,StockLevel,LastDateofTransaction)values('" + txtItCode.Text + "','" + txtItName.Text + "','" + txtItPrice.Text + "','" + txtStockBal.Text + "','" + txtStoreLoc.Text + "','" + txtStockLevel.Text + "','" + txtLDOT.Text + "') "

            If (MsgBox("Do you want Add New Item to the database?", MsgBoxStyle.YesNo, "Add New Item") = MsgBoxResult.Yes) Then
                MsgBox("Item Added to the database Successfully!", MsgBoxStyle.Information, "Item Added")
                com.ExecuteNonQuery()
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
                    txtItPrice.Text = DS.Tables("StockManagementSystem").Rows(0).Item(2)
                    txtStockBal.Text = DS.Tables("StockManagementSystem").Rows(0).Item(3)
                    txtStoreLoc.Text = DS.Tables("StockManagementSystem").Rows(0).Item(4)
                    txtStockLevel.Text = DS.Tables("StockManagementSystem").Rows(0).Item(5)
                    txtLDOT.Text = DS.Tables("StockManagementSystem").Rows(0).Item(6)
                Else
                    txtItCode.Clear()
                    txtItCode.Focus()
                End If
            Else
                MsgBox("Record not found", MsgBoxStyle.Information, "No Record")
                txtItCode.Clear()
                txtItCode.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "Update SMF Set ItemName='" + txtItName.Text + "',ItemPrice='" + txtItPrice.Text + "',StockBalance='" + txtStockBal.Text + "',StoreLocation='" + txtStoreLoc.Text + "',StockLevel='" + txtStockLevel.Text + "',LastDateofTransaction='" + txtLDOT.Text + "' Where ItemCode='" + txtItCode.Text + "'"

            Dim Msg As Integer
            Msg = MsgBox("Do you really want to update Item?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Update Item")
            If Msg = vbYes Then
                com.ExecuteNonQuery()
                MsgBox("Updated successfully!", MsgBoxStyle.Information, "Updated.")
                clear()
            Else
                clear()
                txtItCode.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub

    Private Sub btndel_Click(sender As System.Object, e As System.EventArgs) Handles btndel.Click
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "Delete from SMF Where ItemCode='" + txtItCode.Text + "'"

            Dim Msg As Integer
            Msg = MsgBox("Do you really want to Delete this item?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete Item")
            If Msg = vbYes Then
                com.ExecuteNonQuery()
                MsgBox("One Item Deleted!", MsgBoxStyle.Information, "Deleted.")
                clear()
            Else
                clear()
                txtItCode.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub

    Private Sub txtItCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtItCode.TextChanged
        btnedit.Enabled = True
        btnclr.Enabled = True
        btndel.Enabled = True
    End Sub

    Private Sub btnsearch_MouseHover(sender As Object, e As System.EventArgs) Handles btnsearch.MouseHover
        Try
            Dim msg As Integer
            If txtItCode.Text = "" Then
                msg = MsgBox("Item Code cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtItCode.Focus()
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

    Private Sub btnadd_MouseHover(sender As Object, e As System.EventArgs) Handles btnadd.MouseHover
        Try
            Dim msg As Integer
            If txtItCode.Text = "" Then
                msg = MsgBox("Item Code cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtItCode.Focus()
                End If

            ElseIf Len(txtItCode.Text) <> 4 Then
                msg = MsgBox("Wrong Item Code length.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtItCode.Focus()
                    txtItCode.Clear()
                End If

            ElseIf Not IsNumeric(txtItCode.Text) Then
                msg = MsgBox("Item Code must be numeric.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtItCode.Focus()
                    txtItCode.Clear()
                End If

            ElseIf txtItName.Text = "" Then
                msg = MsgBox("Item Name cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtItName.Focus()
                End If

            ElseIf txtItPrice.Text = "" Then
                msg = MsgBox("Item Price cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtItPrice.Focus()
                End If

            ElseIf txtStockBal.Text = "" Then
                msg = MsgBox("Stock Balance cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtStockBal.Focus()
                End If

            ElseIf txtStoreLoc.Text = "" Then
                msg = MsgBox("Store Location cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtStoreLoc.Focus()
                End If

            ElseIf txtStockLevel.Text = "" Then
                msg = MsgBox("Stock Level cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtStockLevel.Focus()
                End If

            ElseIf txtLDOT.Text = "" Then
                msg = MsgBox("Last Date of Transaction cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtLDOT.Focus()
                End If
            End If

            con.Open()
            adp = New System.Data.SqlClient.SqlDataAdapter("Select * from SMF Where ItemCode='" + txtItCode.Text + "'", con)
            DS.Clear()
            adp.Fill(DS, "StockManagementSystem")
            Dim result As Integer
            result = DS.Tables(0).Rows.Count
            If result = 1 Then
                Dim Mssg As Integer
                Mssg = MsgBox("A record exists with reference to the Item Code you entered.Do you really want to overwrite record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Record Exists!")
                If Mssg = vbYes Then
                    com.Connection = con
                    com.CommandText = "insert into SMF (ItemCode,ItemName,ItemPrice,StockBalance,StoreLocation,StockLevel,LastDateofTransaction)values('" + txtItCode.Text + "','" + txtItName.Text + "','" + txtItPrice.Text + "','" + txtStockBal.Text + "','" + txtStoreLoc.Text + "','" + txtStockLevel.Text + "','" + txtLDOT.Text + "') "
                    com.ExecuteNonQuery()
                    MsgBox("Updated successfully!", MsgBoxStyle.Information, "Updated.")
                    clear()
                Else
                    txtItCode.Clear()
                    txtItCode.Focus()
                End If
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnedit_MouseHover(sender As Object, e As System.EventArgs) Handles btnedit.MouseHover
        Dim msg As Integer
        If txtItCode.Text = "" Then
            msg = MsgBox("Item Code cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
            If msg = vbOKCancel Then
                txtItCode.Focus()
            End If
        ElseIf Len(txtItCode.Text) <> 4 Then
            msg = MsgBox("Wrong Item Code length.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
            If msg = vbOKCancel Then
                txtItCode.Focus()
                txtItCode.Clear()
            End If
        ElseIf Not IsNumeric(txtItCode.Text) Then
            msg = MsgBox("Item Code must be numeric.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
            If msg = vbOKCancel Then
                txtItCode.Focus()
                txtItCode.Clear()
            End If
        ElseIf txtItName.Text = "" Then
            msg = MsgBox("Item Name cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
            If msg = vbOKCancel Then
                txtItName.Focus()
            End If
        ElseIf txtItPrice.Text = "" Then
            msg = MsgBox("Item Price cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
            If msg = vbOKCancel Then
                txtItPrice.Focus()
            End If
        ElseIf txtStockBal.Text = "" Then
            msg = MsgBox("Stock Balance cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
            If msg = vbOKCancel Then
                txtStockBal.Focus()
            End If
        ElseIf txtStoreLoc.Text = "" Then
            msg = MsgBox("Store Location cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
            If msg = vbOKCancel Then
                txtStoreLoc.Focus()
            End If
        ElseIf txtStockLevel.Text = "" Then
            msg = MsgBox("Stock Level cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
            If msg = vbOKCancel Then
                txtStockLevel.Focus()
            End If
        ElseIf txtLDOT.Text = "" Then
            msg = MsgBox("Last Date of Transaction cannot be blank.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
            If msg = vbOKCancel Then
                txtLDOT.Focus()
            End If
        End If
    End Sub
End Class
