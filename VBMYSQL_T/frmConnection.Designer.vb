<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConnection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabConn = New System.Windows.Forms.TabControl()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.lstConnections = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabConn.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabConn
        '
        Me.TabConn.Controls.Add(Me.TabSettings)
        Me.TabConn.Location = New System.Drawing.Point(12, 35)
        Me.TabConn.Name = "TabConn"
        Me.TabConn.SelectedIndex = 0
        Me.TabConn.Size = New System.Drawing.Size(932, 399)
        Me.TabConn.TabIndex = 0
        '
        'TabSettings
        '
        Me.TabSettings.Controls.Add(Me.Button4)
        Me.TabSettings.Controls.Add(Me.Button3)
        Me.TabSettings.Controls.Add(Me.Button2)
        Me.TabSettings.Controls.Add(Me.Button1)
        Me.TabSettings.Controls.Add(Me.GroupBox1)
        Me.TabSettings.Controls.Add(Me.Label1)
        Me.TabSettings.Controls.Add(Me.lstConnections)
        Me.TabSettings.Location = New System.Drawing.Point(4, 25)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(924, 370)
        Me.TabSettings.TabIndex = 0
        Me.TabSettings.Text = "Settings"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'lstConnections
        '
        Me.lstConnections.FormattingEnabled = True
        Me.lstConnections.ItemHeight = 16
        Me.lstConnections.Location = New System.Drawing.Point(6, 43)
        Me.lstConnections.Name = "lstConnections"
        Me.lstConnections.Size = New System.Drawing.Size(508, 276)
        Me.lstConnections.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddConnectionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(956, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddConnectionToolStripMenuItem
        '
        Me.AddConnectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConnectionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AddConnectionToolStripMenuItem.Name = "AddConnectionToolStripMenuItem"
        Me.AddConnectionToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.AddConnectionToolStripMenuItem.Text = "&File"
        '
        'NewConnectionToolStripMenuItem
        '
        Me.NewConnectionToolStripMenuItem.Name = "NewConnectionToolStripMenuItem"
        Me.NewConnectionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewConnectionToolStripMenuItem.Text = "New Connection"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Connection List"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(869, 440)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(30, 440)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 34)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "C&onnect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(532, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 299)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameters"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Database Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(15, 164)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(360, 22)
        Me.TextBox2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "User ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(15, 216)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(360, 22)
        Me.TextBox3.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(15, 266)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(360, 22)
        Me.TextBox4.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(751, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(832, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(439, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Port"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(14, 108)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(87, 22)
        Me.TextBox5.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(547, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 34)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 482)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabConn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmConnection"
        Me.Text = "Connection Form"
        Me.TabConn.ResumeLayout(False)
        Me.TabSettings.ResumeLayout(False)
        Me.TabSettings.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabConn As TabControl
    Friend WithEvents TabSettings As TabPage
    Friend WithEvents lstConnections As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button4 As Button
End Class
