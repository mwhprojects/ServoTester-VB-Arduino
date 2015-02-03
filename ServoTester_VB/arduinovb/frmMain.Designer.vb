<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cboxCOMport = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.panelHide = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSetZero = New System.Windows.Forms.Button()
        Me.txtZero = New System.Windows.Forms.TextBox()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.trkSpeed = New System.Windows.Forms.TrackBar()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.cboxPin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.panelHide.SuspendLayout()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnConnect)
        Me.GroupBox2.Controls.Add(Me.cboxCOMport)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 106)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Connect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(214, 61)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cboxCOMport
        '
        Me.cboxCOMport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCOMport.FormattingEnabled = True
        Me.cboxCOMport.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.cboxCOMport.Location = New System.Drawing.Point(87, 63)
        Me.cboxCOMport.Name = "cboxCOMport"
        Me.cboxCOMport.Size = New System.Drawing.Size(121, 21)
        Me.cboxCOMport.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(437, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select the COM port your Arduino is connected to, then click Connect. You can fin" & _
    "d the COM port your Arduino is connected to in your Device Manager or your Ardui" & _
    "no IDE."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.panelHide)
        Me.GroupBox3.Controls.Add(Me.btnSetZero)
        Me.GroupBox3.Controls.Add(Me.txtZero)
        Me.GroupBox3.Controls.Add(Me.btnZero)
        Me.GroupBox3.Controls.Add(Me.trkSpeed)
        Me.GroupBox3.Controls.Add(Me.txtSpeed)
        Me.GroupBox3.Controls.Add(Me.cboxPin)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 106)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Send"
        '
        'panelHide
        '
        Me.panelHide.Controls.Add(Me.Label3)
        Me.panelHide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelHide.Location = New System.Drawing.Point(3, 16)
        Me.panelHide.Name = "panelHide"
        Me.panelHide.Size = New System.Drawing.Size(437, 87)
        Me.panelHide.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Controls will appear after you connect to an Arduino."
        '
        'btnSetZero
        '
        Me.btnSetZero.Location = New System.Drawing.Point(261, 32)
        Me.btnSetZero.Name = "btnSetZero"
        Me.btnSetZero.Size = New System.Drawing.Size(28, 20)
        Me.btnSetZero.TabIndex = 9
        Me.btnSetZero.Text = "0"
        Me.btnSetZero.UseVisualStyleBackColor = True
        '
        'txtZero
        '
        Me.txtZero.Location = New System.Drawing.Point(340, 63)
        Me.txtZero.Name = "txtZero"
        Me.txtZero.ReadOnly = True
        Me.txtZero.Size = New System.Drawing.Size(97, 20)
        Me.txtZero.TabIndex = 8
        '
        'btnZero
        '
        Me.btnZero.Location = New System.Drawing.Point(340, 16)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(97, 41)
        Me.btnZero.TabIndex = 7
        Me.btnZero.Text = "Set current value as 0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'trkSpeed
        '
        Me.trkSpeed.Location = New System.Drawing.Point(154, 58)
        Me.trkSpeed.Maximum = 180
        Me.trkSpeed.Name = "trkSpeed"
        Me.trkSpeed.Size = New System.Drawing.Size(100, 45)
        Me.trkSpeed.TabIndex = 6
        Me.trkSpeed.Value = 90
        '
        'txtSpeed
        '
        Me.txtSpeed.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSpeed.Location = New System.Drawing.Point(154, 32)
        Me.txtSpeed.MaxLength = 4
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.ReadOnly = True
        Me.txtSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtSpeed.TabIndex = 5
        '
        'cboxPin
        '
        Me.cboxPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPin.FormattingEnabled = True
        Me.cboxPin.Items.AddRange(New Object() {"02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13"})
        Me.cboxPin.Location = New System.Drawing.Point(9, 32)
        Me.cboxPin.Name = "cboxPin"
        Me.cboxPin.Size = New System.Drawing.Size(121, 21)
        Me.cboxPin.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Servo Speed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pin Number"
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 352)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.Text = "Servo Tester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panelHide.ResumeLayout(False)
        Me.panelHide.PerformLayout()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cboxCOMport As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents cboxPin As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents trkSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSetZero As System.Windows.Forms.Button
    Friend WithEvents txtZero As System.Windows.Forms.TextBox
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents panelHide As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
