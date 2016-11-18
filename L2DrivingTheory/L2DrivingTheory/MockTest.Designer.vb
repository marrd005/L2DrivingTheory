<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MockTest
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
        Me.StartTestBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLeft = New System.Windows.Forms.TextBox()
        Me.Seconds = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLeftLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StartTestBtn
        '
        Me.StartTestBtn.Location = New System.Drawing.Point(286, 205)
        Me.StartTestBtn.Name = "StartTestBtn"
        Me.StartTestBtn.Size = New System.Drawing.Size(101, 48)
        Me.StartTestBtn.TabIndex = 0
        Me.StartTestBtn.Text = "Start Mock Test"
        Me.StartTestBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'TimeLeft
        '
        Me.TimeLeft.Location = New System.Drawing.Point(297, 12)
        Me.TimeLeft.Name = "TimeLeft"
        Me.TimeLeft.ReadOnly = True
        Me.TimeLeft.Size = New System.Drawing.Size(49, 20)
        Me.TimeLeft.TabIndex = 1
        Me.TimeLeft.Text = "56"
        '
        'Seconds
        '
        Me.Seconds.Location = New System.Drawing.Point(323, 12)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.ReadOnly = True
        Me.Seconds.Size = New System.Drawing.Size(26, 20)
        Me.Seconds.TabIndex = 2
        Me.Seconds.Text = "60"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TimeLeftLabel
        '
        Me.TimeLeftLabel.AutoSize = True
        Me.TimeLeftLabel.Location = New System.Drawing.Point(298, 35)
        Me.TimeLeftLabel.Name = "TimeLeftLabel"
        Me.TimeLeftLabel.Size = New System.Drawing.Size(51, 13)
        Me.TimeLeftLabel.TabIndex = 3
        Me.TimeLeftLabel.Text = "Time Left"
        '
        'MockTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 322)
        Me.Controls.Add(Me.TimeLeftLabel)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.TimeLeft)
        Me.Controls.Add(Me.StartTestBtn)
        Me.Name = "MockTest"
        Me.Text = "MockTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartTestBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TimeLeft As System.Windows.Forms.TextBox
    Friend WithEvents Seconds As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TimeLeftLabel As System.Windows.Forms.Label
End Class
