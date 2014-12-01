<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SdConfig
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.grpConfig = New System.Windows.Forms.GroupBox()
        Me.nudWS2812 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlDefaultState = New System.Windows.Forms.Panel()
        Me.rdoOff = New System.Windows.Forms.RadioButton()
        Me.rdoOn = New System.Windows.Forms.RadioButton()
        Me.pnlButtonType = New System.Windows.Forms.Panel()
        Me.rdoTimed = New System.Windows.Forms.RadioButton()
        Me.rdoPush = New System.Windows.Forms.RadioButton()
        Me.rdoToggle = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudServoOutput = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudServoMax = New System.Windows.Forms.NumericUpDown()
        Me.nudServoMin = New System.Windows.Forms.NumericUpDown()
        Me.nudToggleSeconds = New System.Windows.Forms.NumericUpDown()
        Me.chbServoSweep = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveSD = New System.Windows.Forms.Button()
        Me.btnReadSD = New System.Windows.Forms.Button()
        Me.cmbSDDrives = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpConfig.SuspendLayout()
        CType(Me.nudWS2812, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDefaultState.SuspendLayout()
        Me.pnlButtonType.SuspendLayout()
        CType(Me.nudServoOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudServoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudServoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudToggleSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(212, 408)
        Me.TreeView1.TabIndex = 0
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(230, 284)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(547, 136)
        Me.txtContent.TabIndex = 1
        '
        'grpConfig
        '
        Me.grpConfig.Controls.Add(Me.nudWS2812)
        Me.grpConfig.Controls.Add(Me.Label7)
        Me.grpConfig.Controls.Add(Me.pnlDefaultState)
        Me.grpConfig.Controls.Add(Me.pnlButtonType)
        Me.grpConfig.Controls.Add(Me.Label6)
        Me.grpConfig.Controls.Add(Me.nudServoOutput)
        Me.grpConfig.Controls.Add(Me.Label5)
        Me.grpConfig.Controls.Add(Me.Label4)
        Me.grpConfig.Controls.Add(Me.nudServoMax)
        Me.grpConfig.Controls.Add(Me.nudServoMin)
        Me.grpConfig.Controls.Add(Me.nudToggleSeconds)
        Me.grpConfig.Controls.Add(Me.chbServoSweep)
        Me.grpConfig.Controls.Add(Me.Label3)
        Me.grpConfig.Controls.Add(Me.Label2)
        Me.grpConfig.Controls.Add(Me.Label1)
        Me.grpConfig.Location = New System.Drawing.Point(230, 41)
        Me.grpConfig.Name = "grpConfig"
        Me.grpConfig.Size = New System.Drawing.Size(547, 237)
        Me.grpConfig.TabIndex = 11
        Me.grpConfig.TabStop = False
        Me.grpConfig.Text = "Config"
        '
        'nudWS2812
        '
        Me.nudWS2812.Location = New System.Drawing.Point(97, 211)
        Me.nudWS2812.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudWS2812.Name = "nudWS2812"
        Me.nudWS2812.Size = New System.Drawing.Size(120, 20)
        Me.nudWS2812.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "WS2812 Toggle"
        '
        'pnlDefaultState
        '
        Me.pnlDefaultState.Controls.Add(Me.rdoOff)
        Me.pnlDefaultState.Controls.Add(Me.rdoOn)
        Me.pnlDefaultState.Location = New System.Drawing.Point(81, 72)
        Me.pnlDefaultState.Name = "pnlDefaultState"
        Me.pnlDefaultState.Size = New System.Drawing.Size(200, 19)
        Me.pnlDefaultState.TabIndex = 31
        '
        'rdoOff
        '
        Me.rdoOff.AutoSize = True
        Me.rdoOff.Checked = True
        Me.rdoOff.Location = New System.Drawing.Point(63, 0)
        Me.rdoOff.Name = "rdoOff"
        Me.rdoOff.Size = New System.Drawing.Size(37, 17)
        Me.rdoOff.TabIndex = 21
        Me.rdoOff.TabStop = True
        Me.rdoOff.Text = "off"
        Me.rdoOff.UseVisualStyleBackColor = True
        '
        'rdoOn
        '
        Me.rdoOn.AutoSize = True
        Me.rdoOn.Location = New System.Drawing.Point(3, 0)
        Me.rdoOn.Name = "rdoOn"
        Me.rdoOn.Size = New System.Drawing.Size(37, 17)
        Me.rdoOn.TabIndex = 20
        Me.rdoOn.Text = "on"
        Me.rdoOn.UseVisualStyleBackColor = True
        '
        'pnlButtonType
        '
        Me.pnlButtonType.Controls.Add(Me.rdoTimed)
        Me.pnlButtonType.Controls.Add(Me.rdoPush)
        Me.pnlButtonType.Controls.Add(Me.rdoToggle)
        Me.pnlButtonType.Location = New System.Drawing.Point(81, 44)
        Me.pnlButtonType.Name = "pnlButtonType"
        Me.pnlButtonType.Size = New System.Drawing.Size(254, 30)
        Me.pnlButtonType.TabIndex = 30
        '
        'rdoTimed
        '
        Me.rdoTimed.AutoSize = True
        Me.rdoTimed.Location = New System.Drawing.Point(161, 5)
        Me.rdoTimed.Name = "rdoTimed"
        Me.rdoTimed.Size = New System.Drawing.Size(50, 17)
        Me.rdoTimed.TabIndex = 29
        Me.rdoTimed.Text = "timed"
        Me.rdoTimed.UseVisualStyleBackColor = True
        '
        'rdoPush
        '
        Me.rdoPush.AutoSize = True
        Me.rdoPush.Location = New System.Drawing.Point(3, 5)
        Me.rdoPush.Name = "rdoPush"
        Me.rdoPush.Size = New System.Drawing.Size(48, 17)
        Me.rdoPush.TabIndex = 26
        Me.rdoPush.Text = "push"
        Me.rdoPush.UseVisualStyleBackColor = True
        '
        'rdoToggle
        '
        Me.rdoToggle.AutoSize = True
        Me.rdoToggle.Location = New System.Drawing.Point(82, 5)
        Me.rdoToggle.Name = "rdoToggle"
        Me.rdoToggle.Size = New System.Drawing.Size(54, 17)
        Me.rdoToggle.TabIndex = 27
        Me.rdoToggle.Text = "toggle"
        Me.rdoToggle.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Button type"
        '
        'nudServoOutput
        '
        Me.nudServoOutput.Location = New System.Drawing.Point(97, 123)
        Me.nudServoOutput.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.nudServoOutput.Name = "nudServoOutput"
        Me.nudServoOutput.Size = New System.Drawing.Size(120, 20)
        Me.nudServoOutput.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Servo Output"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Default State"
        '
        'nudServoMax
        '
        Me.nudServoMax.Location = New System.Drawing.Point(287, 154)
        Me.nudServoMax.Maximum = New Decimal(New Integer() {550, 0, 0, 0})
        Me.nudServoMax.Minimum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.nudServoMax.Name = "nudServoMax"
        Me.nudServoMax.Size = New System.Drawing.Size(120, 20)
        Me.nudServoMax.TabIndex = 22
        Me.nudServoMax.Value = New Decimal(New Integer() {550, 0, 0, 0})
        '
        'nudServoMin
        '
        Me.nudServoMin.Location = New System.Drawing.Point(97, 151)
        Me.nudServoMin.Maximum = New Decimal(New Integer() {550, 0, 0, 0})
        Me.nudServoMin.Minimum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.nudServoMin.Name = "nudServoMin"
        Me.nudServoMin.Size = New System.Drawing.Size(120, 20)
        Me.nudServoMin.TabIndex = 21
        Me.nudServoMin.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'nudToggleSeconds
        '
        Me.nudToggleSeconds.Location = New System.Drawing.Point(97, 97)
        Me.nudToggleSeconds.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudToggleSeconds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudToggleSeconds.Name = "nudToggleSeconds"
        Me.nudToggleSeconds.Size = New System.Drawing.Size(120, 20)
        Me.nudToggleSeconds.TabIndex = 20
        Me.nudToggleSeconds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chbServoSweep
        '
        Me.chbServoSweep.AutoSize = True
        Me.chbServoSweep.Location = New System.Drawing.Point(287, 180)
        Me.chbServoSweep.Name = "chbServoSweep"
        Me.chbServoSweep.Size = New System.Drawing.Size(90, 17)
        Me.chbServoSweep.TabIndex = 17
        Me.chbServoSweep.Text = "Sweep Servo"
        Me.chbServoSweep.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Servo Max"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Servo Min"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Seconds"
        '
        'btnSaveSD
        '
        Me.btnSaveSD.Location = New System.Drawing.Point(472, 12)
        Me.btnSaveSD.Name = "btnSaveSD"
        Me.btnSaveSD.Size = New System.Drawing.Size(102, 23)
        Me.btnSaveSD.TabIndex = 12
        Me.btnSaveSD.Text = "Save to SD Card"
        Me.btnSaveSD.UseVisualStyleBackColor = True
        '
        'btnReadSD
        '
        Me.btnReadSD.Location = New System.Drawing.Point(355, 12)
        Me.btnReadSD.Name = "btnReadSD"
        Me.btnReadSD.Size = New System.Drawing.Size(111, 23)
        Me.btnReadSD.TabIndex = 13
        Me.btnReadSD.Text = "Read SD Card"
        Me.btnReadSD.UseVisualStyleBackColor = True
        '
        'cmbSDDrives
        '
        Me.cmbSDDrives.FormattingEnabled = True
        Me.cmbSDDrives.Location = New System.Drawing.Point(228, 14)
        Me.cmbSDDrives.Name = "cmbSDDrives"
        Me.cmbSDDrives.Size = New System.Drawing.Size(121, 21)
        Me.cmbSDDrives.TabIndex = 14
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 423)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(789, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'SdConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 445)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmbSDDrives)
        Me.Controls.Add(Me.btnReadSD)
        Me.Controls.Add(Me.btnSaveSD)
        Me.Controls.Add(Me.grpConfig)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.TreeView1)
        Me.MaximizeBox = False
        Me.Name = "SdConfig"
        Me.Text = "RailwayMaker"
        Me.grpConfig.ResumeLayout(False)
        Me.grpConfig.PerformLayout()
        CType(Me.nudWS2812, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDefaultState.ResumeLayout(False)
        Me.pnlDefaultState.PerformLayout()
        Me.pnlButtonType.ResumeLayout(False)
        Me.pnlButtonType.PerformLayout()
        CType(Me.nudServoOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudServoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudServoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudToggleSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents grpConfig As System.Windows.Forms.GroupBox
    Friend WithEvents chbServoSweep As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudServoMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudServoMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudToggleSeconds As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudServoOutput As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdoTimed As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdoToggle As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPush As System.Windows.Forms.RadioButton
    Friend WithEvents pnlButtonType As System.Windows.Forms.Panel
    Friend WithEvents pnlDefaultState As System.Windows.Forms.Panel
    Friend WithEvents rdoOff As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOn As System.Windows.Forms.RadioButton
    Friend WithEvents nudWS2812 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSaveSD As System.Windows.Forms.Button
    Friend WithEvents btnReadSD As System.Windows.Forms.Button
    Friend WithEvents cmbSDDrives As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
