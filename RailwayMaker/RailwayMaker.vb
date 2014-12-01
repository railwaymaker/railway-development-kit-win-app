Imports System
Imports System.IO.Ports

Public Class Form1

    Public Event DataReceived As SerialDataReceivedEventHandler
    Dim SERIALPORT_CONNECTION As SerialPort
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = "Railway Development Kit"

        GetSerialPortNames()

    End Sub


    Sub GetSerialPortNames()
        ' Show all available COM ports. 
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOM.Items.Add(sp)
        Next

        If cmbCOM.Items.Count = 1 Then
            cmbCOM.SelectedIndex = 0
        End If


    End Sub

    Private Sub btnCOMConnect_Click(sender As Object, e As EventArgs) Handles btnCOMConnect.Click
        If btnCOMConnect.Text = "connect" Then

            btnCOMConnect.Text = "disconnect"

            Try

                SERIALPORT_CONNECTION = New SerialPort(Me.cmbCOM.Text)

                SERIALPORT_CONNECTION.BaudRate = 115200
                'SERIALPORT_CONNECTION.Parity = Parity.None
                'SERIALPORT_CONNECTION.StopBits = StopBits.One
                'SERIALPORT_CONNECTION.DataBits = 8
                'SERIALPORT_CONNECTION.Handshake = Handshake.None
                SERIALPORT_CONNECTION.DtrEnable = True
                SERIALPORT_CONNECTION.RtsEnable = True

                AddHandler SERIALPORT_CONNECTION.DataReceived, AddressOf DataReceivedHandler

                SERIALPORT_CONNECTION.Open()
                SERIALPORT_CONNECTION.WriteLine("hello")

                btnCOMConnect.Text = "disconnect"

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Connection Error")
                btnCOMConnect.Text = "connect"
            End Try
        Else
            btnCOMConnect.Text = "connect"
            SERIALPORT_CONNECTION.Close()
        End If

    End Sub

    Private Shared Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)

        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Console.Write(indata)
        Application.DoEvents()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim oForm As SDConfig
        oForm = New SDConfig()
        oForm.Show()
        oForm = Nothing
    End Sub
End Class