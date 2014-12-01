
Public Class SdConfig

    Public Class ioData

        'bool              enabled = 0               ' if active or not   
        Public defaultState As Boolean = 0          ' Default state of pin 1=on, 0=off
        Public currentState As Boolean = 0          ' Default state of pin 1=on, 0=off
        Public outputIO As Decimal = 0                ' > 0 Mux output pin to drive, < 0 servo to toggle
        Public servoMin As Integer = 0              ' 
        Public servoMax As Integer = 0              ' 
        Public ws2812id As Integer = 0
        'bool              servoSweep = 0            ' if the servo should constantly sweep
        ' Seconds to leave output on for.  
        ' -1 = input button, 0 means don't auto off, > 0 is a toggle switch, < -1 is a on for once period
        Public durationSeconds As Integer = 0

        'unsigned long     onMilli = 0            ' Used internally for timing if flasher

    End Class

    Private Const PUSH_BUTTON As Integer = 1
    Private Const TOGGLE_BUTTON As Integer = 2
    Private Const TIMED_BUTTON As Integer = 3
    Private Const CONFIG_FILE_NAME As String = "config.txt"

    Dim ioConfig() As ioData


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReDim ioConfig(32)

        Me.grpConfig.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Railway Development Kit SD file configurator - RailwayMaker.com"

        For Each di As IO.DriveInfo In IO.DriveInfo.GetDrives
            If di.DriveType = IO.DriveType.Removable Then
                If di.IsReady = True Then
                    cmbSDDrives.Items.Add(di.Name)

                    If System.IO.File.Exists(di.Name & "\" & CONFIG_FILE_NAME) Then
                        Me.cmbSDDrives.SelectedIndex = cmbSDDrives.Items.Count - 1
                    End If
                End If
            End If
        Next

        ' If there is only one SD and one isnt already selected
        If cmbSDDrives.Items.Count = 1 And cmbSDDrives.SelectedIndex = -1 Then
            Me.cmbSDDrives.SelectedIndex = 0
        End If


        Dim root = New TreeNode("Railway Maker V1.3 Board")
        TreeView1.Nodes.Add(root)
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("input and outputs"))
        'Creating child nodes under the first child
        For loopindex As Integer = 1 To 32
            TreeView1.Nodes(0).Nodes(0).Nodes.Add(New  _
                TreeNode("i/o " & Str(loopindex)))
            ioConfig(loopindex) = New ioData()
        Next loopindex

        TreeView1.ExpandAll()

        SetButtonType(0)

        'state01 = 0
        'out01 = 1
        'sec01 = 0
        'min01 = 0
        'max01 = 90
        'sweep01 = 0
        'ws01 = 0

    End Sub


    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        If TreeView1.SelectedNode.Text.IndexOf("i/o") > -1 Then
            grpConfig.Enabled = True
            Me.grpConfig.Text = TreeView1.SelectedNode.Text

            Dim io As Integer = CInt(TreeView1.SelectedNode.Text.Replace("i/o", ""))

            Me.rdoPush.Checked = False
            Me.rdoToggle.Checked = False
            Me.rdoTimed.Checked = False

            If ioConfig(io).durationSeconds = -1 Then
                Me.rdoPush.Checked = True
                Me.rdoToggle.Checked = False
                Me.rdoTimed.Checked = False
            ElseIf ioConfig(io).durationSeconds = -1 Then
                Me.rdoPush.Checked = False
                Me.rdoToggle.Checked = True
                Me.rdoTimed.Checked = False
            Else
                Me.rdoPush.Checked = False
                Me.rdoToggle.Checked = False
                Me.rdoTimed.Checked = True
            End If

            If ioConfig(io).defaultState Then
                Me.rdoOn.Checked = True
                Me.rdoOn.Checked = False
            Else
                Me.rdoOn.Checked = False
                Me.rdoOn.Checked = True
            End If
            If ioConfig(io).servoMax >= 150 And ioConfig(io).servoMax <= 550 Then Me.nudServoMax.Value = ioConfig(io).servoMax
            If ioConfig(io).servoMax >= 150 And ioConfig(io).servoMax <= 550 Then Me.nudServoMin.Value = ioConfig(io).servoMin
            Me.nudServoOutput.Value = ioConfig(io).outputIO
            'Me.nudToggleSeconds.Value = ioConfig(io).durationSeconds
            'Me.chbServoSweep.Enabled = False
            Me.nudWS2812.Value = ioConfig(io).ws2812id

        Else
            grpConfig.Enabled = False
        End If

        'updateConfig()

    End Sub

    Private Sub rdoPush_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPush.CheckedChanged
        SetButtonType(PUSH_BUTTON)
        'updateConfig()
    End Sub

    Private Sub rdoToggle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoToggle.CheckedChanged
        SetButtonType(TOGGLE_BUTTON)
        'updateConfig()
    End Sub

    Private Sub rdoTimed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTimed.CheckedChanged
        SetButtonType(TIMED_BUTTON)
        'updateConfig()
    End Sub

    Private Sub SetButtonType(button_type As Integer)

        ' Set default state
        Me.pnlDefaultState.Enabled = False
        Me.nudServoMax.Enabled = False
        Me.nudServoMin.Enabled = False
        Me.nudServoOutput.Enabled = False
        Me.nudToggleSeconds.Enabled = False
        Me.chbServoSweep.Enabled = False
        Me.nudWS2812.Enabled = False
        Me.lblServoWarning.Visible = False

        ' Default values
        Me.pnlDefaultState.Enabled = False
        Me.nudServoMax.Enabled = False
        Me.nudServoMin.Enabled = False
        Me.nudServoOutput.Enabled = False
        Me.nudToggleSeconds.Enabled = False
        Me.chbServoSweep.Enabled = False
        Me.nudWS2812.Enabled = False

        Select Case button_type

            Case PUSH_BUTTON

                Me.pnlDefaultState.Enabled = False
                Me.nudServoMax.Enabled = False
                Me.nudServoMin.Enabled = False
                Me.nudServoOutput.Enabled = True
                Me.nudToggleSeconds.Enabled = False
                Me.chbServoSweep.Enabled = False
                Me.nudWS2812.Enabled = True
                Me.lblServoWarning.Visible = True

            Case TOGGLE_BUTTON

                Me.pnlDefaultState.Enabled = False
                Me.nudServoMax.Enabled = False
                Me.nudServoMin.Enabled = False
                Me.nudServoOutput.Enabled = True
                Me.nudToggleSeconds.Enabled = False
                Me.chbServoSweep.Enabled = False
                Me.nudWS2812.Enabled = True

            Case TIMED_BUTTON

                Me.pnlDefaultState.Enabled = True
                Me.nudServoMax.Enabled = False
                Me.nudServoMin.Enabled = False
                Me.nudServoOutput.Enabled = False
                Me.nudToggleSeconds.Enabled = True
                Me.chbServoSweep.Enabled = False
                Me.nudWS2812.Enabled = True

        End Select

        'updateConfig()
    End Sub



    Private Sub nudServoOutput_ValueChanged(sender As Object, e As EventArgs) Handles nudServoOutput.ValueChanged
        If nudServoOutput.Value > 0 Then
            Me.nudServoMin.Enabled = True
            Me.nudServoMax.Enabled = True
            'Me.nudServoOutput.Enabled = True
            Me.chbServoSweep.Enabled = True
        Else
            Me.nudServoMin.Enabled = False
            Me.nudServoMax.Enabled = False
            'Me.nudServoOutput.Enabled = False
            Me.chbServoSweep.Enabled = False
        End If
    End Sub

    Private Sub btnReadSD_Click(sender As Object, e As EventArgs) Handles btnReadSD.Click
        Me.btnReadSD.Enabled = False
        Me.btnSaveSD.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Reading SD"
        Try
            Me.ToolStripStatusLabel1.Text = "Reading SD file " & Me.cmbSDDrives.Text & "\" & CONFIG_FILE_NAME
            Using sr As New System.IO.StreamReader(Me.cmbSDDrives.Text & "\" & CONFIG_FILE_NAME)
                Me.txtConfig.Text = sr.ReadToEnd()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "SD Card Error")
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(ex.Message)
            Me.btnReadSD.Enabled = True
            Me.btnSaveSD.Enabled = True
            Me.ToolStripStatusLabel1.Text = "Error reading SD"
        End Try
        Me.btnReadSD.Enabled = True
        Me.btnSaveSD.Enabled = True
        Me.ToolStripStatusLabel1.Text = "Openend " & Me.cmbSDDrives.Text & "\" & CONFIG_FILE_NAME

        Dim io As Integer
        Dim param As String
        Dim val As String

        Dim str As String() = txtConfig.Text.Split(New [Char]() {CChar(vbCrLf)})
        For Each s As String In str

            If s.IndexOf(" = ") > -1 Then

                If IsNumeric(s.Substring(s.IndexOf("=") - 3, 2)) Then
                    param = s.Substring(1, s.IndexOf("=") - 4) ' param
                    io = CInt(s.Substring(s.IndexOf("=") - 3, 2)) ' io
                    val = s.Substring(s.IndexOf("=") + 2) ' value

                    If param = "state" Then
                        ioConfig(io).defaultState = CBool(val)
                    End If
                    If param = "out" Then
                        ioConfig(io).outputIO = CInt(val)
                    End If
                    If param = "sec" Then
                        ioConfig(io).durationSeconds = CInt(val)
                    End If
                    If param = "min" Then
                        ioConfig(io).servoMin = CInt(val)
                    End If
                    If param = "max" Then
                        ioConfig(io).servoMax = CInt(val)
                    End If
                    If param = "ws" Then
                        ioConfig(io).ws2812id = CInt(val)
                    End If
                    If param = "sweep" Then
                        'ioConfig(io).ws2812id = CInt(val)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub btnSaveSD_Click(sender As Object, e As EventArgs) Handles btnSaveSD.Click
        Me.btnReadSD.Enabled = False
        Me.btnSaveSD.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Saving to SD"

        Try

            updateConfig()

            If System.IO.File.Exists(Me.cmbSDDrives.Text & "\" & CONFIG_FILE_NAME) = False Then

            End If

            Dim objWriter As New System.IO.StreamWriter(Me.cmbSDDrives.Text & "\" & CONFIG_FILE_NAME)

            objWriter.Write(txtConfig.Text)
            objWriter.Close()
            MsgBox("Text written to file")

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "SD Card Error")
            Console.WriteLine("The file could not be written:")
            Console.WriteLine(ex.Message)
            Me.btnReadSD.Enabled = True
            Me.btnSaveSD.Enabled = True
            Me.ToolStripStatusLabel1.Text = "Error saving to SD"
        End Try
        Me.btnReadSD.Enabled = True
        Me.btnSaveSD.Enabled = True
        Me.ToolStripStatusLabel1.Text = "File Saved"
    End Sub

    Sub updateConfig()

        Me.txtConfig.Text = Me.txtConfig.Text.Substring(0, Me.txtConfig.Text.IndexOf("[io]") + 4) & vbCrLf ' clear

        For i = 1 To 32

            If ioConfig(i).defaultState.ToString Then
                Me.txtConfig.Text &= "state" & padNumberString(i) & " = 1" & vbCrLf
            Else
                Me.txtConfig.Text &= "state" & padNumberString(i) & " = 0" & vbCrLf
            End If
            Me.txtConfig.Text &= "out" & padNumberString(i) & " = " & ioConfig(i).outputIO.ToString & vbCrLf
            Me.txtConfig.Text &= "sec" & padNumberString(i) & " = " & ioConfig(i).durationSeconds.ToString & vbCrLf
            Me.txtConfig.Text &= "min" & padNumberString(i) & " = " & ioConfig(i).servoMin.ToString & vbCrLf
            Me.txtConfig.Text &= "max" & padNumberString(i) & " = " & ioConfig(i).servoMax.ToString & vbCrLf
            Me.txtConfig.Text &= "ws" & padNumberString(i) & " = " & ioConfig(i).ws2812id.ToString & vbCrLf
            Me.txtConfig.Text &= vbCrLf


        Next

    End Sub

    Function padNumberString(i As Integer) As String

        If i < 10 Then
            Return "0" & i
        End If

        Return i.ToString

    End Function

End Class
