<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnup = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtLDOT = New System.Windows.Forms.TextBox()
        Me.txtStockBal = New System.Windows.Forms.TextBox()
        Me.txtQuan = New System.Windows.Forms.TextBox()
        Me.txtItName = New System.Windows.Forms.TextBox()
        Me.txtItCode = New System.Windows.Forms.TextBox()
        Me.txtNwStockBal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IssuedOut = New System.Windows.Forms.RadioButton()
        Me.Returnout = New System.Windows.Forms.RadioButton()
        Me.ReturnIn = New System.Windows.Forms.RadioButton()
        Me.IssuedIn = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttotprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendar1.Location = New System.Drawing.Point(810, 55)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 53
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.ForeColor = System.Drawing.Color.Black
        Me.btnCal.Location = New System.Drawing.Point(637, 409)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(135, 31)
        Me.btnCal.TabIndex = 52
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnclr)
        Me.GroupBox2.Controls.Add(Me.btnclose)
        Me.GroupBox2.Location = New System.Drawing.Point(860, 503)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 127)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'btnclr
        '
        Me.btnclr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnclr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.ForeColor = System.Drawing.Color.Black
        Me.btnclr.Location = New System.Drawing.Point(39, 21)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(135, 31)
        Me.btnclr.TabIndex = 29
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(39, 75)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(135, 31)
        Me.btnclose.TabIndex = 30
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnup
        '
        Me.btnup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnup.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnup.ForeColor = System.Drawing.Color.Black
        Me.btnup.Location = New System.Drawing.Point(637, 578)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(135, 31)
        Me.btnup.TabIndex = 50
        Me.btnup.Text = "Update"
        Me.btnup.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(637, 55)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(135, 31)
        Me.btnsearch.TabIndex = 49
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtLDOT
        '
        Me.txtLDOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDOT.Location = New System.Drawing.Point(314, 559)
        Me.txtLDOT.Name = "txtLDOT"
        Me.txtLDOT.Size = New System.Drawing.Size(255, 27)
        Me.txtLDOT.TabIndex = 48
        '
        'txtStockBal
        '
        Me.txtStockBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockBal.Location = New System.Drawing.Point(314, 156)
        Me.txtStockBal.Name = "txtStockBal"
        Me.txtStockBal.Size = New System.Drawing.Size(255, 27)
        Me.txtStockBal.TabIndex = 47
        '
        'txtQuan
        '
        Me.txtQuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuan.Location = New System.Drawing.Point(314, 391)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.Size = New System.Drawing.Size(255, 27)
        Me.txtQuan.TabIndex = 46
        '
        'txtItName
        '
        Me.txtItName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItName.Location = New System.Drawing.Point(314, 99)
        Me.txtItName.Name = "txtItName"
        Me.txtItName.Size = New System.Drawing.Size(255, 27)
        Me.txtItName.TabIndex = 45
        '
        'txtItCode
        '
        Me.txtItCode.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtItCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItCode.ForeColor = System.Drawing.Color.Maroon
        Me.txtItCode.Location = New System.Drawing.Point(314, 42)
        Me.txtItCode.Name = "txtItCode"
        Me.txtItCode.Size = New System.Drawing.Size(255, 27)
        Me.txtItCode.TabIndex = 44
        '
        'txtNwStockBal
        '
        Me.txtNwStockBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNwStockBal.Location = New System.Drawing.Point(314, 503)
        Me.txtNwStockBal.Name = "txtNwStockBal"
        Me.txtNwStockBal.Size = New System.Drawing.Size(255, 27)
        Me.txtNwStockBal.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.IssuedOut)
        Me.GroupBox1.Controls.Add(Me.Returnout)
        Me.GroupBox1.Controls.Add(Me.ReturnIn)
        Me.GroupBox1.Controls.Add(Me.IssuedIn)
        Me.GroupBox1.Location = New System.Drawing.Point(314, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 97)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'IssuedOut
        '
        Me.IssuedOut.AutoSize = True
        Me.IssuedOut.Location = New System.Drawing.Point(137, 21)
        Me.IssuedOut.Name = "IssuedOut"
        Me.IssuedOut.Size = New System.Drawing.Size(104, 21)
        Me.IssuedOut.TabIndex = 10
        Me.IssuedOut.Text = "Issued OUT"
        Me.IssuedOut.UseVisualStyleBackColor = True
        '
        'Returnout
        '
        Me.Returnout.AutoSize = True
        Me.Returnout.Location = New System.Drawing.Point(137, 58)
        Me.Returnout.Name = "Returnout"
        Me.Returnout.Size = New System.Drawing.Size(106, 21)
        Me.Returnout.TabIndex = 11
        Me.Returnout.Text = "Return OUT"
        Me.Returnout.UseVisualStyleBackColor = True
        '
        'ReturnIn
        '
        Me.ReturnIn.AutoSize = True
        Me.ReturnIn.Location = New System.Drawing.Point(22, 58)
        Me.ReturnIn.Name = "ReturnIn"
        Me.ReturnIn.Size = New System.Drawing.Size(89, 21)
        Me.ReturnIn.TabIndex = 9
        Me.ReturnIn.Text = "Return IN"
        Me.ReturnIn.UseVisualStyleBackColor = True
        '
        'IssuedIn
        '
        Me.IssuedIn.AutoSize = True
        Me.IssuedIn.Location = New System.Drawing.Point(22, 21)
        Me.IssuedIn.Name = "IssuedIn"
        Me.IssuedIn.Size = New System.Drawing.Size(87, 21)
        Me.IssuedIn.TabIndex = 8
        Me.IssuedIn.Text = "Issued IN"
        Me.IssuedIn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 503)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "New Stock Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 566)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Last Date of Transacton"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Transaction Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Stock Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Item Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 450)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Total Price"
        '
        'txttotprice
        '
        Me.txttotprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotprice.Location = New System.Drawing.Point(314, 450)
        Me.txttotprice.Name = "txttotprice"
        Me.txttotprice.Size = New System.Drawing.Size(255, 27)
        Me.txttotprice.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Item Price"
        '
        'txtItPrice
        '
        Me.txtItPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItPrice.Location = New System.Drawing.Point(314, 220)
        Me.txtItPrice.Name = "txtItPrice"
        Me.txtItPrice.Size = New System.Drawing.Size(255, 27)
        Me.txtItPrice.TabIndex = 63
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1081, 642)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txttotprice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtItPrice)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtLDOT)
        Me.Controls.Add(Me.txtStockBal)
        Me.Controls.Add(Me.txtQuan)
        Me.Controls.Add(Me.txtItName)
        Me.Controls.Add(Me.txtItCode)
        Me.Controls.Add(Me.txtNwStockBal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction Procession File"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnup As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtLDOT As System.Windows.Forms.TextBox
    Friend WithEvents txtStockBal As System.Windows.Forms.TextBox
    Friend WithEvents txtQuan As System.Windows.Forms.TextBox
    Friend WithEvents txtItName As System.Windows.Forms.TextBox
    Friend WithEvents txtItCode As System.Windows.Forms.TextBox
    Friend WithEvents txtNwStockBal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IssuedOut As System.Windows.Forms.RadioButton
    Friend WithEvents Returnout As System.Windows.Forms.RadioButton
    Friend WithEvents ReturnIn As System.Windows.Forms.RadioButton
    Friend WithEvents IssuedIn As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttotprice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItPrice As System.Windows.Forms.TextBox
End Class
