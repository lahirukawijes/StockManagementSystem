Public Class Form3
    Private con As New System.Data.SqlClient.SqlConnection
    Private com As New System.Data.SqlClient.SqlCommand
    Private adp As New System.Data.SqlClient.SqlDataAdapter
    Private DS As New DataSet
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtsupID.Select()
        btnedit.Enabled = False
        btnclr.Enabled = False
        btndel.Enabled = False
        Try
            con.ConnectionString = "Data Source=GLPWIJESINGHE-L;Initial Catalog=StockManagementSystem;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub clear()
        txtsupID.Clear()
        txtName.Clear()
        txtadd.Clear()
        txtEmail.Clear()
        txtTelM.Clear()
        txtTelF.Clear()
    End Sub

    Private Sub btnclr_Click(sender As System.Object, e As System.EventArgs) Handles btnclr.Click
        Dim MSG1 As Integer
        MSG1 = MsgBox("Do you want to clear the form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Clear")
        If MSG1 = vbYes Then
            clear()
            txtsupID.Focus()
        Else
            txtsupID.Focus()
        End If
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Dim MSG2 As Integer
        MSG2 = MsgBox("Do you want to close the form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Close")
        If MSG2 = vbYes Then
            Me.Close()
        Else
            txtsupID.Focus()
        End If
    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "insert into SUPREG(SupplierID, Name, Address, Email, TelM, TelF)values('" + txtsupID.Text + "','" + txtName.Text + "','" + txtadd.Text + "','" + txtEmail.Text + "','" + txtTelM.Text + "','" + txtTelF.Text + "') "
            If (MsgBox("Do you want Add New Item to the database?", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.YesNo, "Add New Item") = MsgBoxResult.Yes) Then
                com.ExecuteNonQuery()
                MsgBox("Item added to the database Successfully!", MsgBoxStyle.Information, "Item Added")
                clear()
                txtsupID.Focus()
            Else
                clear()
                txtsupID.Focus()
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
            com.CommandText = "Update SUPREG Set Name='" + txtName.Text + "', Address='" + txtadd.Text + "', Email='" + txtEmail.Text + "', TelM='" + txtTelM.Text + "', TelF='" + txtTelF.Text + "' Where SupplierID='" + txtsupID.Text + "'"
            If (MsgBox("Do you really want to update Item?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Update Item") = MsgBoxResult.Yes) Then
                com.ExecuteNonQuery()
                MsgBox("Updated successfully!", MsgBoxStyle.Information, "Updated")
                clear()
                txtsupID.Focus()
            Else
                txtsupID.Focus()
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
            com.CommandText = "Delete from SUPREG Where SupplierID='" + txtsupID.Text + "'"
            If (MsgBox("Do you really want to Delete this item?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete Item") = MsgBoxResult.Yes) Then
                com.ExecuteNonQuery()
                MsgBox("One Item Deleted!", MsgBoxStyle.Information, "Deleted")
                clear()
                txtsupID.Focus()
            Else
                txtsupID.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub
    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        Try
            btnclr.Enabled = True
            btnedit.Enabled = True
            btndel.Enabled = True
            con.Open()
            adp = New System.Data.SqlClient.SqlDataAdapter("Select * from SUPREG Where SupplierID='" + txtsupID.Text + "'", con)
            DS.Clear()
            adp.Fill(DS, "StockManagementSystem")
            Dim result As Integer
            result = DS.Tables(0).Rows.Count
            If result = 1 Then
                If MsgBox("Do you want to view record?", MsgBoxStyle.YesNo, "Record found") = MsgBoxResult.Yes Then
                    txtName.Text = DS.Tables("StockManagementSystem").Rows(0).Item(1)
                    txtadd.Text = DS.Tables("StockManagementSystem").Rows(0).Item(2)
                    txtEmail.Text = DS.Tables("StockManagementSystem").Rows(0).Item(3)
                    txtTelM.Text = DS.Tables("StockManagementSystem").Rows(0).Item(4)
                    txtTelF.Text = DS.Tables("StockManagementSystem").Rows(0).Item(5)
                Else
                    txtsupID.Clear()
                    txtsupID.Focus()
                End If
            Else
                MsgBox("Record not found.Please recheck the Supplier ID and try again.", MsgBoxStyle.Information, "Wrong Supplier ID")
                txtsupID.Clear()
                txtsupID.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub
    Private Sub btnsearch_MouseHover(sender As Object, e As System.EventArgs) Handles btnsearch.MouseHover
        Try
            Dim msg As Integer
            If txtsupID.Text = "" Then
                msg = MsgBox("Supplier ID cannot be blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtsupID.Focus()
                End If
            ElseIf Len(txtsupID.Text) <> 4 Then
                msg = MsgBox("Wrong Supplier ID length.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtsupID.Focus()
                    clear()
                End If
            ElseIf Not IsNumeric(txtsupID.Text) Then
                msg = MsgBox("Supplier ID must be numeric.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtsupID.Focus()
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
            If txtsupID.Text = "" Then
                msg = MsgBox("Supplier ID cannot be blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtsupID.Focus()
                End If
            ElseIf Len(txtsupID.Text) <> 4 Then
                msg = MsgBox("Wrong Supplier ID length.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtsupID.Focus()
                    txtsupID.Clear()
                End If
            ElseIf Not IsNumeric(txtsupID.Text) Then
                msg = MsgBox("Supplier ID must be numeric.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtsupID.Focus()
                    txtsupID.Clear()
                End If
            ElseIf txtName.Text = "" Then
                msg = MsgBox("Supplier Name cannot be blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtName.Focus()
                End If
            ElseIf txtadd.Text = "" Then
                msg = MsgBox("Supplier Address cannot be blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtadd.Focus()
                End If
            ElseIf txtEmail.Text = "" Then
                msg = MsgBox("Supplier Email cannot be blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtEmail.Focus()
                End If
            ElseIf txtTelM.Text = "" And txtTelF.Text = "" Then
                msg = MsgBox("At least one telephone number should be provided.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Incomplete record")
                If msg = vbOKCancel Then
                    txtTelM.Focus()
                End If

            ElseIf Len(txtTelM.Text) < 9 Or Len(txtTelF.Text) < 9 Then
                msg = MsgBox("Please provide a valied Telephone number", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Invalied record")
                If msg = vbOKCancel Then
                    txtTelM.Focus()
                    txtTelM.Clear()
                    txtTelF.Clear()
                End If
            End If

            con.Open()
            adp = New System.Data.SqlClient.SqlDataAdapter("Select * from SUPREG Where SupplierID='" + txtsupID.Text + "'", con)
            DS.Clear()
            adp.Fill(DS, "StockManagementSystem")
            Dim result As Integer
            result = DS.Tables(0).Rows.Count
            If result = 1 Then
                Dim Mssg As Integer
                Mssg = MsgBox("A record exists with reference to the Supplier ID you entered.Do you really want to overwrite record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Record Exists!")
                If Mssg = vbYes Then
                    com.Connection = con
                    com.CommandText = "insert into SUPREG(SupplierID, Name, Address, Email, TelM, TelF)values('" + txtsupID.Text + "','" + txtName.Text + "','" + txtadd.Text + "','" + txtEmail.Text + "','" + txtTelM.Text + "','" + txtTelF.Text + "') "
                    com.ExecuteNonQuery()
                    MsgBox("Updated successfully!", MsgBoxStyle.Information, "Updated.")
                    clear()
                Else
                    txtsupID.Clear()
                    txtsupID.Focus()
                End If
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtsupID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsupID.TextChanged
        btnclr.Enabled = True
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter
        btnedit.Enabled = True
        btndel.Enabled = True
    End Sub
End Class
