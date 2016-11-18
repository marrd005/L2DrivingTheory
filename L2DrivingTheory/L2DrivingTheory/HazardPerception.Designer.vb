<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HazardPerception
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
        Me.HPIntro = New System.Windows.Forms.WebBrowser()
        Me.Clip1Btn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Clip2Btn = New System.Windows.Forms.Button()
        Me.Clip3Btn = New System.Windows.Forms.Button()
        Me.Clip4Btn = New System.Windows.Forms.Button()
        Me.Clip5Btn = New System.Windows.Forms.Button()
        Me.Clip6Btn = New System.Windows.Forms.Button()
        Me.Clip7Btn = New System.Windows.Forms.Button()
        Me.Clip8Btn = New System.Windows.Forms.Button()
        Me.HazardSpottedBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Clip1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'HPIntro
        '
        Me.HPIntro.Location = New System.Drawing.Point(425, 57)
        Me.HPIntro.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HPIntro.Name = "HPIntro"
        Me.HPIntro.Size = New System.Drawing.Size(278, 195)
        Me.HPIntro.TabIndex = 0
        Me.HPIntro.Url = New System.Uri("https://www.youtube.com/v/SdQRkmdhwJs", System.UriKind.Absolute)
        '
        'Clip1Btn
        '
        Me.Clip1Btn.Location = New System.Drawing.Point(45, 57)
        Me.Clip1Btn.Name = "Clip1Btn"
        Me.Clip1Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip1Btn.TabIndex = 1
        Me.Clip1Btn.Text = "Clip 1"
        Me.Clip1Btn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(12, 263)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackBtn.TabIndex = 2
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(93, 263)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 3
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Clip2Btn
        '
        Me.Clip2Btn.Location = New System.Drawing.Point(126, 57)
        Me.Clip2Btn.Name = "Clip2Btn"
        Me.Clip2Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip2Btn.TabIndex = 4
        Me.Clip2Btn.Text = "Clip 2"
        Me.Clip2Btn.UseVisualStyleBackColor = True
        '
        'Clip3Btn
        '
        Me.Clip3Btn.Location = New System.Drawing.Point(207, 57)
        Me.Clip3Btn.Name = "Clip3Btn"
        Me.Clip3Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip3Btn.TabIndex = 5
        Me.Clip3Btn.Text = "Clip 3"
        Me.Clip3Btn.UseVisualStyleBackColor = True
        '
        'Clip4Btn
        '
        Me.Clip4Btn.Location = New System.Drawing.Point(288, 57)
        Me.Clip4Btn.Name = "Clip4Btn"
        Me.Clip4Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip4Btn.TabIndex = 6
        Me.Clip4Btn.Text = "Clip 4"
        Me.Clip4Btn.UseVisualStyleBackColor = True
        '
        'Clip5Btn
        '
        Me.Clip5Btn.Location = New System.Drawing.Point(45, 96)
        Me.Clip5Btn.Name = "Clip5Btn"
        Me.Clip5Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip5Btn.TabIndex = 7
        Me.Clip5Btn.Text = "Clip 5"
        Me.Clip5Btn.UseVisualStyleBackColor = True
        '
        'Clip6Btn
        '
        Me.Clip6Btn.Location = New System.Drawing.Point(126, 96)
        Me.Clip6Btn.Name = "Clip6Btn"
        Me.Clip6Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip6Btn.TabIndex = 8
        Me.Clip6Btn.Text = "Clip 6"
        Me.Clip6Btn.UseVisualStyleBackColor = True
        '
        'Clip7Btn
        '
        Me.Clip7Btn.Location = New System.Drawing.Point(207, 96)
        Me.Clip7Btn.Name = "Clip7Btn"
        Me.Clip7Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip7Btn.TabIndex = 9
        Me.Clip7Btn.Text = "Clip 7"
        Me.Clip7Btn.UseVisualStyleBackColor = True
        '
        'Clip8Btn
        '
        Me.Clip8Btn.Location = New System.Drawing.Point(288, 96)
        Me.Clip8Btn.Name = "Clip8Btn"
        Me.Clip8Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clip8Btn.TabIndex = 10
        Me.Clip8Btn.Text = "Clip 8"
        Me.Clip8Btn.UseVisualStyleBackColor = True
        '
        'HazardSpottedBtn
        '
        Me.HazardSpottedBtn.Location = New System.Drawing.Point(45, 167)
        Me.HazardSpottedBtn.Name = "HazardSpottedBtn"
        Me.HazardSpottedBtn.Size = New System.Drawing.Size(123, 55)
        Me.HazardSpottedBtn.TabIndex = 11
        Me.HazardSpottedBtn.Text = "Hazard Spotted"
        Me.HazardSpottedBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Clip1
        '
        Me.Clip1.Location = New System.Drawing.Point(218, 25)
        Me.Clip1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Clip1.Name = "Clip1"
        Me.Clip1.Size = New System.Drawing.Size(340, 250)
        Me.Clip1.TabIndex = 12
        Me.Clip1.Url = New System.Uri("https://www.youtube.com/v/V1xczr0D2Xo", System.UriKind.Absolute)
        '
        'HazardPerception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 307)
        Me.Controls.Add(Me.Clip1)
        Me.Controls.Add(Me.HazardSpottedBtn)
        Me.Controls.Add(Me.Clip8Btn)
        Me.Controls.Add(Me.Clip7Btn)
        Me.Controls.Add(Me.Clip6Btn)
        Me.Controls.Add(Me.Clip5Btn)
        Me.Controls.Add(Me.Clip4Btn)
        Me.Controls.Add(Me.Clip3Btn)
        Me.Controls.Add(Me.Clip2Btn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Clip1Btn)
        Me.Controls.Add(Me.HPIntro)
        Me.Name = "HazardPerception"
        Me.Text = "HazardPerception"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HPIntro As System.Windows.Forms.WebBrowser
    Friend WithEvents Clip1Btn As System.Windows.Forms.Button
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents Clip2Btn As System.Windows.Forms.Button
    Friend WithEvents Clip3Btn As System.Windows.Forms.Button
    Friend WithEvents Clip4Btn As System.Windows.Forms.Button
    Friend WithEvents Clip5Btn As System.Windows.Forms.Button
    Friend WithEvents Clip6Btn As System.Windows.Forms.Button
    Friend WithEvents Clip7Btn As System.Windows.Forms.Button
    Friend WithEvents Clip8Btn As System.Windows.Forms.Button
    Friend WithEvents HazardSpottedBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Clip1 As System.Windows.Forms.WebBrowser
End Class
