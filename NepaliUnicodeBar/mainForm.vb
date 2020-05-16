Imports System.ComponentModel
Imports System.Security.Permissions
Imports changeLang
Public Class mainForm
    Dim kiLang As New MainWindow
    Dim workArea = Screen.PrimaryScreen.WorkingArea
    Private Sub mainForm_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args() As String = Environment.GetCommandLineArgs()
        For Each str As String In args
            Me.Top = workArea.Height * 1.5
            Try
                If (str = "addReg") Then
                    notify.Visible = False
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                    MsgBox("The Program now STARTS at StartUp", vbOKOnly + vbInformation, "Runs at Startup")
                    Me.Close()
                ElseIf (str = "delReg") Then
                    notify.Visible = False
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                    MsgBox("The Program now Doesnot STARTS at StartUp", vbOKOnly + vbExclamation, "NO Startup")
                    Me.Close()
                ElseIf (str = "checkReg") Then
                    notify.Visible = False
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                    MsgBox("The Program STARTS at StartUp", vbOKOnly + vbInformation, "Runs at Startup")
                    Me.Close()
                End If
            Catch
                If (str = "checkReg") Then
                    notify.Visible = False
                    MsgBox("The Program Doesnot STARTS at StartUp", vbOKOnly + vbExclamation, "NO Startup")
                End If
                Me.Close()
            End Try
        Next
        If (IsProcessRunning(Application.ProductName) > 1) Then
            notify.Visible = False
            Me.Activate()
            MsgBox("The Program doesnot allow multiple Instances.", vbOKOnly + vbExclamation, "Sorry!")
            Me.Close()
        End If
        makeForm()
        Dim strings() As String = {"आ", "ई", "ऊ", "ऋ", "ऐ", "ओ", "औ", "ज्ञ", "ञ", "क्ष", "ौ", "ॐ"}
        Dim count As Integer = 0
        Dim lengthStr = strings.Length - 1
        For count = (strings.Length - 1) To 0 Step -1
            Dim lbl = New Button()
            lbl.Name = "lbl_" & count
            lbl.Text = strings(count)
            lbl.Width = 40
            lbl.Font = New Font("Nirmala", 16, FontStyle.Regular)
            lbl.FlatStyle = FlatStyle.Flat
            lbl.BackColor = Color.Black
            lbl.ForeColor = Color.White
            lbl.Cursor = Cursors.Hand
            lbl.Height = 35
            lbl.Location = New Point(Me.Width - (lengthStr - count + 1) * 45, 2)
            AddHandler lbl.Click, AddressOf handleClick
            Me.Controls.Add(lbl)
        Next count
    End Sub


    Private Sub handleClick(sender As Button, e As EventArgs)
        SendKeys.Send(sender.Text)
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")>
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or CInt(&H8000000L)
            Return cp
        End Get
    End Property
#Region "Language"

#End Region
#Region "Make Form"
    Function makeForm() As Integer
        Me.BackColor = Color.Black
        Me.Left = 0
        Me.Height = 40
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        exitBtn.Height = Me.Height
        exitBtn.Width = 40
        exitBtn.Top = 0
        exitBtn.Left = 0
        exitBtn.Cursor = Cursors.Hand
        Return 1
    End Function
#End Region
#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub exitBtn_click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub

    Private Sub SetTmer_Tick(sender As Object, e As EventArgs) Handles setTmer.Tick
        'If (InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName = "ne") Then
        ' MsgBox(kiLang._currentLanaguge.TwoLetterISOLanguageName)
        Try
            kiLang.HandleCurrentLanguage()
            If (kiLang._currentLanaguge.TwoLetterISOLanguageName.Contains("ne") = True) Then
                langLbl.Text = "Nepali"
                Me.Show()
                'Me.Top = workArea.Height - 100
            Else
                langLbl.Text = "English"
                Me.Hide()
                'Me.Top = workArea.Height - Me.Height
            End If
        Catch err As Exception
            //do nothing
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub RunAtStartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunAtStartToolStripMenuItem.Click
        Dim procStartInfo As New ProcessStartInfo
        Dim procExecuting As New Process

        With procStartInfo
            .Arguments = "addReg"
            .UseShellExecute = True
            .FileName = Application.ExecutablePath
            .WindowStyle = ProcessWindowStyle.Minimized
            .Verb = "runas" 'add this to prompt for elevation
        End With

        procExecuting = Process.Start(procStartInfo)
    End Sub

    Private Sub DonotRunAtStartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonotRunAtStartToolStripMenuItem.Click
        Dim procStartInfo As New ProcessStartInfo
        Dim procExecuting As New Process

        With procStartInfo
            .Arguments = "delReg"
            .UseShellExecute = True
            .FileName = Application.ExecutablePath
            .WindowStyle = ProcessWindowStyle.Minimized
            .Verb = "runas" 'add this to prompt for elevation
        End With

        procExecuting = Process.Start(procStartInfo)
    End Sub

    Private Sub CheckStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckStatusToolStripMenuItem.Click
        Dim procStartInfo As New ProcessStartInfo
        Dim procExecuting As New Process

        With procStartInfo
            .Arguments = "checkReg"
            .UseShellExecute = True
            .FileName = Application.ExecutablePath
            .WindowStyle = ProcessWindowStyle.Minimized
            .Verb = "runas" 'add this to prompt for elevation
        End With

        procExecuting = Process.Start(procStartInfo)
    End Sub
#End Region
#Region "Process Twice"
    Public Function IsProcessRunning(name As String) As Integer
        'here we're going to get a list of all running processes on
        'the computer
        Dim count As Integer
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                'process found so it's running so return true
                count += 1
            End If
        Next
        'process not found, return false
        Return count
    End Function

    Private Sub langLbl_Click(sender As Object, e As EventArgs) Handles langLbl.Click

    End Sub

    Private Sub notifyMenu_Opening(sender As Object, e As CancelEventArgs) Handles notifyMenu.Opening

    End Sub
#End Region
End Class
