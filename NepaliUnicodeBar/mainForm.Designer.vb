<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.setTmer = New System.Windows.Forms.Timer(Me.components)
        Me.notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunAtStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunAtStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonotRunAtStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sysInfo = New System.Windows.Forms.Label()
        Me.langLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.notifyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.Red
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.White
        Me.exitBtn.Location = New System.Drawing.Point(0, -6)
        Me.exitBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(55, 49)
        Me.exitBtn.TabIndex = 0
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'setTmer
        '
        Me.setTmer.Enabled = True
        Me.setTmer.Interval = 500
        '
        'notify
        '
        Me.notify.ContextMenuStrip = Me.notifyMenu
        Me.notify.Icon = CType(resources.GetObject("notify.Icon"), System.Drawing.Icon)
        Me.notify.Text = "NotifyIcon1"
        Me.notify.Visible = True
        '
        'notifyMenu
        '
        Me.notifyMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.notifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunAtStartupToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.notifyMenu.Name = "notifyMenu"
        Me.notifyMenu.Size = New System.Drawing.Size(127, 82)
        '
        'RunAtStartupToolStripMenuItem
        '
        Me.RunAtStartupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunAtStartToolStripMenuItem, Me.DonotRunAtStartToolStripMenuItem, Me.CheckStatusToolStripMenuItem})
        Me.RunAtStartupToolStripMenuItem.Name = "RunAtStartupToolStripMenuItem"
        Me.RunAtStartupToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.RunAtStartupToolStripMenuItem.Text = "Startup"
        '
        'RunAtStartToolStripMenuItem
        '
        Me.RunAtStartToolStripMenuItem.Name = "RunAtStartToolStripMenuItem"
        Me.RunAtStartToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.RunAtStartToolStripMenuItem.Text = "Run at Start"
        '
        'DonotRunAtStartToolStripMenuItem
        '
        Me.DonotRunAtStartToolStripMenuItem.Name = "DonotRunAtStartToolStripMenuItem"
        Me.DonotRunAtStartToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DonotRunAtStartToolStripMenuItem.Text = "Donot Run at Start"
        '
        'CheckStatusToolStripMenuItem
        '
        Me.CheckStatusToolStripMenuItem.Name = "CheckStatusToolStripMenuItem"
        Me.CheckStatusToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CheckStatusToolStripMenuItem.Text = "Check Status"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'sysInfo
        '
        Me.sysInfo.AutoSize = True
        Me.sysInfo.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sysInfo.ForeColor = System.Drawing.Color.White
        Me.sysInfo.Location = New System.Drawing.Point(58, 4)
        Me.sysInfo.Name = "sysInfo"
        Me.sysInfo.Size = New System.Drawing.Size(243, 38)
        Me.sysInfo.TabIndex = 1
        Me.sysInfo.Text = "नेपाली Unicode Bar"
        '
        'langLbl
        '
        Me.langLbl.AutoSize = True
        Me.langLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.langLbl.ForeColor = System.Drawing.Color.White
        Me.langLbl.Location = New System.Drawing.Point(346, 5)
        Me.langLbl.Name = "langLbl"
        Me.langLbl.Size = New System.Drawing.Size(47, 32)
        Me.langLbl.TabIndex = 2
        Me.langLbl.Text = "...."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(326, -8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 70)
        Me.Panel1.TabIndex = 3
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(549, 40)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.langLbl)
        Me.Controls.Add(Me.sysInfo)
        Me.Controls.Add(Me.exitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "NepaliUnicodeBar"
        Me.TopMost = True
        Me.notifyMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitBtn As Button
    Friend WithEvents setTmer As Timer
    Friend WithEvents notify As NotifyIcon
    Friend WithEvents sysInfo As Label
    Friend WithEvents langLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents notifyMenu As ContextMenuStrip
    Friend WithEvents RunAtStartupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunAtStartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonotRunAtStartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CheckStatusToolStripMenuItem As ToolStripMenuItem
End Class
