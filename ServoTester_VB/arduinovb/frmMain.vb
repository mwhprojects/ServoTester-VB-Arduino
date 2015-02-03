' Servo Tester for Arduino
' This program connects to an Arduino via a serial connection. From the VB program, you can select a pin
' a servo is connected to and the position, or speed if it is a continuous rotation servo.
' 
' https://github.com/mwhprojects/ServoTester-VB-Arduino

Imports System.IO.Ports

Public Class frmMain

    ' Global variable for Zero value.
    Dim Zero As Integer = 90

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default COM Port selection.
        cboxCOMport.SelectedItem = "COM3"

        ' Set default Pin Number.
        cboxPin.SelectedItem = "11"

        ' Hide the controls.
        panelHide.Visible = True

        ' Set default Zero value.
        txtSpeed.Text = Zero
        txtZero.Text = Zero
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' Variable to set to false in case connection fails.
        Dim ConnectSuccess As Boolean = True

        ' The Try-Catch statement is going to test the serial connection. If it can't open the connect using the selected COM port, it will set the ConnectSuccess variable to false.
        Try
            SerialPort.Close()
            SerialPort.PortName = cboxCOMport.Text
            SerialPort.BaudRate = 9600
            SerialPort.DataBits = 8
            SerialPort.Parity = Parity.None
            SerialPort.StopBits = StopBits.One
            SerialPort.Handshake = Handshake.None
            SerialPort.Encoding = System.Text.Encoding.Default
            SerialPort.Open()
        Catch
            ConnectSuccess = False
            SerialPort.Close()
        End Try

        ' Check if ConnectSuccess is true or false...
        If ConnectSuccess = True Then
            ' Disable Connect button.
            btnConnect.Enabled = False
            btnConnect.Text = "Connected!"

            ' Message box success message.
            MsgBox("Connected to Arduino using " & cboxCOMport.Text & "!" & vbNewLine, MsgBoxStyle.Information, "Success")

            ' Remove panel that hides controls.
            panelHide.Visible = False

            ' Enable send timer.
            Timer1.Enabled = True
        Else
            ' Message box error alert.
            MsgBox("Could not connect using " & cboxCOMport.Text & "!" & vbNewLine & "Please try again!", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Zero the servo.
        If (SerialPort.IsOpen) Then
            SerialPort.DiscardInBuffer()
            SerialPort.DiscardOutBuffer()
            SerialPort.Write(cboxPin.Text)
            SerialPort.Write(Zero.ToString.PadLeft(3))
        End If

        ' Close the serial connection.
        SerialPort.Close()
    End Sub

    Private Sub trkSpeed_Scroll(sender As Object, e As EventArgs) Handles trkSpeed.Scroll
        ' Show speed in textbox.
        txtSpeed.Text = trkSpeed.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Clear the serial buffers.
        SerialPort.DiscardInBuffer()
        SerialPort.DiscardOutBuffer()
        ' Send the Pin Number value.
        SerialPort.Write(cboxPin.Text)
        ' Send the servo speed. PadLeft is used so that it is always three digits/characters long.
        ' That's important because Arduino is expecting 5 characters, so it wouldn't work without PadLeft if speed is <100.
        SerialPort.Write(trkSpeed.Value.ToString.PadLeft(3))
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        ' Set the Zero variable to the current speed.
        Zero = trkSpeed.Value
        txtZero.Text = Zero
    End Sub

    Private Sub btnSetZero_Click(sender As Object, e As EventArgs) Handles btnSetZero.Click
        ' Set the current speed to the Zero variable value.
        trkSpeed.Value = Zero
        txtSpeed.Text = Zero
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://github.com/mwhprojects/ServoTester-VB-Arduino")
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Cursor = Cursors.Default
    End Sub
End Class
