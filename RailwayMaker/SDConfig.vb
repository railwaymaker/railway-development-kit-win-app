
Public Class SdConfig

    Private Const PUSH_BUTTON As Integer = 1
    Private Const TOGGLE_BUTTON As Integer = 2
    Private Const TIMED_BUTTON As Integer = 3
    Private Const CONFIG_FILE_NAME As String = "config.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Else
            grpConfig.Enabled = False
        End If

    End Sub

    Private Sub rdoPush_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPush.CheckedChanged
        SetButtonType(PUSH_BUTTON)
    End Sub

    Private Sub rdoToggle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoToggle.CheckedChanged
        SetButtonType(TOGGLE_BUTTON)
    End Sub

    Private Sub rdoTimed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTimed.CheckedChanged
        SetButtonType(TIMED_BUTTON)
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

            Case TOGGLE_BUTTON

                Me.pnlDefaultState.Enabled = True
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

    End Sub



    Private Sub nudServoOutput_ValueChanged(sender As Object, e As EventArgs) Handles nudServoOutput.ValueChanged
        If nudServoOutput.Value > 0 Then
            Me.nudServoMin.Enabled = True
            Me.nudServoMax.Enabled = True
            Me.nudServoOutput.Enabled = True
            Me.chbServoSweep.Enabled = True
        Else
            Me.nudServoMin.Enabled = False
            Me.nudServoMax.Enabled = True
            Me.nudServoOutput.Enabled = False
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
                Me.txtContent.Text = sr.ReadToEnd()
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

    End Sub

    Private Sub btnSaveSD_Click(sender As Object, e As EventArgs) Handles btnSaveSD.Click
        Me.btnReadSD.Enabled = False
        Me.btnSaveSD.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Saving to SD"
        Try
            If System.IO.File.Exists(Me.cmbSDDrives.Text & "\" & CONFIG_FILE_NAME) = False Then

            End If

            Dim objWriter As New System.IO.StreamWriter(Me.cmbSDDrives.Text & "\" & CONFIG_FILE_NAME)

            objWriter.Write(txtContent.Text)
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
End Class
