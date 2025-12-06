<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HVACSmartHomeController
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
        Me.ReadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.SetTempTextBox = New System.Windows.Forms.TextBox()
        Me.SetTempLabel = New System.Windows.Forms.Label()
        Me.CurrentTempLabel = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.CurrentTempTextBox = New System.Windows.Forms.TextBox()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.SerialDataLabel = New System.Windows.Forms.Label()
        Me.COMButton = New System.Windows.Forms.Button()
        Me.PortsComboBox = New System.Windows.Forms.ComboBox()
        Me.PortsComboBoxLabel = New System.Windows.Forms.Label()
        Me.ConnectionStatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(641, 362)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(124, 76)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(492, 376)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(118, 62)
        Me.SetButton.TabIndex = 1
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'SetTempTextBox
        '
        Me.SetTempTextBox.Location = New System.Drawing.Point(57, 98)
        Me.SetTempTextBox.Name = "SetTempTextBox"
        Me.SetTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SetTempTextBox.TabIndex = 2
        '
        'SetTempLabel
        '
        Me.SetTempLabel.AutoSize = True
        Me.SetTempLabel.Location = New System.Drawing.Point(53, 78)
        Me.SetTempLabel.Name = "SetTempLabel"
        Me.SetTempLabel.Size = New System.Drawing.Size(188, 30)
        Me.SetTempLabel.TabIndex = 3
        Me.SetTempLabel.Text = "Set temperature"
        '
        'CurrentTempLabel
        '
        Me.CurrentTempLabel.AutoSize = True
        Me.CurrentTempLabel.Location = New System.Drawing.Point(359, 148)
        Me.CurrentTempLabel.Name = "CurrentTempLabel"
        Me.CurrentTempLabel.Size = New System.Drawing.Size(236, 30)
        Me.CurrentTempLabel.TabIndex = 4
        Me.CurrentTempLabel.Text = "Current Temperature"
        '
        'CurrentTempTextBox
        '
        Me.CurrentTempTextBox.Location = New System.Drawing.Point(363, 171)
        Me.CurrentTempTextBox.Name = "CurrentTempTextBox"
        Me.CurrentTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CurrentTempTextBox.TabIndex = 5
        '
        'SerialTextBox
        '
        Me.SerialTextBox.Location = New System.Drawing.Point(57, 171)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(260, 26)
        Me.SerialTextBox.TabIndex = 6
        '
        'SerialDataLabel
        '
        Me.SerialDataLabel.AutoSize = True
        Me.SerialDataLabel.Location = New System.Drawing.Point(63, 148)
        Me.SerialDataLabel.Name = "SerialDataLabel"
        Me.SerialDataLabel.Size = New System.Drawing.Size(132, 30)
        Me.SerialDataLabel.TabIndex = 7
        Me.SerialDataLabel.Text = "Serial Data"
        '
        'COMButton
        '
        Me.COMButton.Location = New System.Drawing.Point(285, 336)
        Me.COMButton.Name = "COMButton"
        Me.COMButton.Size = New System.Drawing.Size(178, 92)
        Me.COMButton.TabIndex = 9
        Me.COMButton.Text = "COM"
        Me.COMButton.UseVisualStyleBackColor = True
        '
        'PortsComboBox
        '
        Me.PortsComboBox.FormattingEnabled = True
        Me.PortsComboBox.Location = New System.Drawing.Point(50, 336)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(121, 28)
        Me.PortsComboBox.TabIndex = 10
        '
        'PortsComboBoxLabel
        '
        Me.PortsComboBoxLabel.AutoSize = True
        Me.PortsComboBoxLabel.Location = New System.Drawing.Point(53, 303)
        Me.PortsComboBoxLabel.Name = "PortsComboBoxLabel"
        Me.PortsComboBoxLabel.Size = New System.Drawing.Size(113, 20)
        Me.PortsComboBoxLabel.TabIndex = 11
        Me.PortsComboBoxLabel.Text = "Available Ports"
        '
        'ConnectionStatusLabel
        '
        Me.ConnectionStatusLabel.AutoSize = True
        Me.ConnectionStatusLabel.Location = New System.Drawing.Point(12, 418)
        Me.ConnectionStatusLabel.Name = "ConnectionStatusLabel"
        Me.ConnectionStatusLabel.Size = New System.Drawing.Size(212, 30)
        Me.ConnectionStatusLabel.TabIndex = 12
        Me.ConnectionStatusLabel.Text = "Connection Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConnectionStatusLabel)
        Me.Controls.Add(Me.PortsComboBoxLabel)
        Me.Controls.Add(Me.PortsComboBox)
        Me.Controls.Add(Me.COMButton)
        Me.Controls.Add(Me.SerialDataLabel)
        Me.Controls.Add(Me.SerialTextBox)
        Me.Controls.Add(Me.CurrentTempTextBox)
        Me.Controls.Add(Me.CurrentTempLabel)
        Me.Controls.Add(Me.SetTempLabel)
        Me.Controls.Add(Me.SetTempTextBox)
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReadTimer As Timer
    Friend WithEvents ExitButton As Button
    Friend WithEvents SetButton As Button
    Friend WithEvents SetTempTextBox As TextBox
    Friend WithEvents SetTempLabel As Label
    Friend WithEvents CurrentTempLabel As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents CurrentTempTextBox As TextBox
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents SerialDataLabel As Label
    Friend WithEvents COMButton As Button
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents PortsComboBoxLabel As Label
    Friend WithEvents ConnectionStatusLabel As Label
    Friend WithEvents Label1 As Label
End Class
