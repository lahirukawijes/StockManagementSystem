<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStockLevel = New System.Windows.Forms.TextBox()
        Me.txtStoreLoc = New System.Windows.Forms.TextBox()
        Me.txtStockBal = New System.Windows.Forms.TextBox()
        Me.txtItPrice = New System.Windows.Forms.TextBox()
        Me.txtItName = New System.Windows.Forms.TextBox()
        Me.txtItCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtLDOT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MonthCalendar1.Location = New System.Drawing.Point(812, 61)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 49
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Turquoise
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.Firebrick
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(628, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "SR1/SR2/SR3/SR4/SR5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(628, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 18)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "H-High  M-Medium  L-low"
        '
        'txtStockLevel
        '
        Me.txtStockLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockLevel.Location = New System.Drawing.Point(342, 336)
        Me.txtStockLevel.Name = "txtStockLevel"
        Me.txtStockLevel.Size = New System.Drawing.Size(255, 27)
        Me.txtStockLevel.TabIndex = 45
        '
        'txtStoreLoc
        '
        Me.txtStoreLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoreLoc.Location = New System.Drawing.Point(342, 279)
        Me.txtStoreLoc.Name = "txtStoreLoc"
        Me.txtStoreLoc.Size = New System.Drawing.Size(255, 27)
        Me.txtStoreLoc.TabIndex = 44
        '
        'txtStockBal
        '
        Me.txtStockBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockBal.Location = New System.Drawing.Point(342, 222)
        Me.txtStockBal.Name = "txtStockBal"
        Me.txtStockBal.Size = New System.Drawing.Size(255, 27)
        Me.txtStockBal.TabIndex = 43
        '
        'txtItPrice
        '
        Me.txtItPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItPrice.Location = New System.Drawing.Point(342, 165)
        Me.txtItPrice.Name = "txtItPrice"
        Me.txtItPrice.Size = New System.Drawing.Size(255, 27)
        Me.txtItPrice.TabIndex = 42
        '
        'txtItName
        '
        Me.txtItName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItName.Location = New System.Drawing.Point(342, 108)
        Me.txtItName.Name = "txtItName"
        Me.txtItName.Size = New System.Drawing.Size(255, 27)
        Me.txtItName.TabIndex = 41
        '
        'txtItCode
        '
        Me.txtItCode.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtItCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItCode.ForeColor = System.Drawing.Color.Maroon
        Me.txtItCode.Location = New System.Drawing.Point(342, 51)
        Me.txtItCode.Name = "txtItCode"
        Me.txtItCode.Size = New System.Drawing.Size(255, 27)
        Me.txtItCode.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(74, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Stock Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(74, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 20)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Store Location"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(74, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Last Date of Transaction"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(74, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Stock Balance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(74, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Item Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(74, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(74, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Item Code"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(912, 470)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(135, 31)
        Me.btnclose.TabIndex = 32
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnclr
        '
        Me.btnclr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnclr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.ForeColor = System.Drawing.Color.Black
        Me.btnclr.Location = New System.Drawing.Point(731, 470)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(135, 31)
        Me.btnclr.TabIndex = 31
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btndel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.Black
        Me.btndel.Location = New System.Drawing.Point(78, 470)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(135, 31)
        Me.btndel.TabIndex = 30
        Me.btndel.Text = "Delete Item"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.Black
        Me.btnedit.Location = New System.Drawing.Point(442, 470)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(135, 31)
        Me.btnedit.TabIndex = 29
        Me.btnedit.Text = "Edit Current"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(631, 61)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(135, 31)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Black
        Me.btnadd.Location = New System.Drawing.Point(260, 470)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(135, 31)
        Me.btnadd.TabIndex = 27
        Me.btnadd.Text = "Add New"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'txtLDOT
        '
        Me.txtLDOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDOT.Location = New System.Drawing.Point(342, 393)
        Me.txtLDOT.Name = "txtLDOT"
        Me.txtLDOT.Size = New System.Drawing.Size(255, 27)
        Me.txtLDOT.TabIndex = 46
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1081, 553)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLDOT)
        Me.Controls.Add(Me.txtStockLevel)
        Me.Controls.Add(Me.txtStoreLoc)
        Me.Controls.Add(Me.txtStockBal)
        Me.Controls.Add(Me.txtItPrice)
        Me.Controls.Add(Me.txtItName)
        Me.Controls.Add(Me.txtItCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Master File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtStockLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtStoreLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtStockBal As System.Windows.Forms.TextBox
    Friend WithEvents txtItPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItName As System.Windows.Forms.TextBox
    Friend WithEvents txtItCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtLDOT As System.Windows.Forms.TextBox

End Class
