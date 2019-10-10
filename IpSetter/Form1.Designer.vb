<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblCurrentIpAddress = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Set IP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(151, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Return to DHCP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblCurrentIpAddress
        '
        Me.lblCurrentIpAddress.AutoSize = True
        Me.lblCurrentIpAddress.Location = New System.Drawing.Point(22, 9)
        Me.lblCurrentIpAddress.Name = "lblCurrentIpAddress"
        Me.lblCurrentIpAddress.Size = New System.Drawing.Size(39, 13)
        Me.lblCurrentIpAddress.TabIndex = 2
        Me.lblCurrentIpAddress.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(151, 81)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(99, 42)
        Me.BtnQuit.TabIndex = 3
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnAbout
        '
        Me.BtnAbout.Location = New System.Drawing.Point(26, 81)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(99, 42)
        Me.BtnAbout.TabIndex = 4
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 124)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.lblCurrentIpAddress)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IpSetter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblCurrentIpAddress As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnAbout As Button
End Class
