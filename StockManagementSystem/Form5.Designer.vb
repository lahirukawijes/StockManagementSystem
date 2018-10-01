<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMasterFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionProcessionFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupplierRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierDetailReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1590, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormsToolStripMenuItem
        '
        Me.FormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockMasterFileToolStripMenuItem, Me.TransactionProcessionFileToolStripMenuItem, Me.ToolStripSeparator1, Me.SupplierRegistrationToolStripMenuItem})
        Me.FormsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormsToolStripMenuItem.Name = "FormsToolStripMenuItem"
        Me.FormsToolStripMenuItem.Size = New System.Drawing.Size(69, 27)
        Me.FormsToolStripMenuItem.Text = "Forms"
        '
        'StockMasterFileToolStripMenuItem
        '
        Me.StockMasterFileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockMasterFileToolStripMenuItem.Image = CType(resources.GetObject("StockMasterFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockMasterFileToolStripMenuItem.Name = "StockMasterFileToolStripMenuItem"
        Me.StockMasterFileToolStripMenuItem.Size = New System.Drawing.Size(284, 28)
        Me.StockMasterFileToolStripMenuItem.Text = "Stock Master File"
        '
        'TransactionProcessionFileToolStripMenuItem
        '
        Me.TransactionProcessionFileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionProcessionFileToolStripMenuItem.Image = CType(resources.GetObject("TransactionProcessionFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransactionProcessionFileToolStripMenuItem.Name = "TransactionProcessionFileToolStripMenuItem"
        Me.TransactionProcessionFileToolStripMenuItem.Size = New System.Drawing.Size(284, 28)
        Me.TransactionProcessionFileToolStripMenuItem.Text = "Transaction Procession File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(281, 6)
        '
        'SupplierRegistrationToolStripMenuItem
        '
        Me.SupplierRegistrationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierRegistrationToolStripMenuItem.Image = CType(resources.GetObject("SupplierRegistrationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupplierRegistrationToolStripMenuItem.Name = "SupplierRegistrationToolStripMenuItem"
        Me.SupplierRegistrationToolStripMenuItem.Size = New System.Drawing.Size(284, 28)
        Me.SupplierRegistrationToolStripMenuItem.Text = "Supplier Registration"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierDetailReportToolStripMenuItem, Me.TransactionProToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(81, 27)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'SupplierDetailReportToolStripMenuItem
        '
        Me.SupplierDetailReportToolStripMenuItem.Image = CType(resources.GetObject("SupplierDetailReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupplierDetailReportToolStripMenuItem.Name = "SupplierDetailReportToolStripMenuItem"
        Me.SupplierDetailReportToolStripMenuItem.Size = New System.Drawing.Size(359, 28)
        Me.SupplierDetailReportToolStripMenuItem.Text = "Supplier Details Report"
        '
        'TransactionProToolStripMenuItem
        '
        Me.TransactionProToolStripMenuItem.Image = CType(resources.GetObject("TransactionProToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransactionProToolStripMenuItem.Name = "TransactionProToolStripMenuItem"
        Me.TransactionProToolStripMenuItem.Size = New System.Drawing.Size(359, 28)
        Me.TransactionProToolStripMenuItem.Text = "Transaction Processing Detail Report"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(76, 27)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1590, 680)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form5"
        Me.Text = "Smart Homes Pvt. Ltd."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockMasterFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionProcessionFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SupplierDetailReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionProToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
