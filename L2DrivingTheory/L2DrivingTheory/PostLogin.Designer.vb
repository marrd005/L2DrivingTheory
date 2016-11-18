<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostLogin))
        Me.HighwayCodeBtn = New System.Windows.Forms.Button()
        Me.HazardPerceptionBtn = New System.Windows.Forms.Button()
        Me.MockTestBtn = New System.Windows.Forms.Button()
        Me.StudyBtn = New System.Windows.Forms.Button()
        Me.PracticeQuizBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.DateTime = New System.Windows.Forms.Label()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HighwayCodeBtn
        '
        Me.HighwayCodeBtn.Location = New System.Drawing.Point(374, 44)
        Me.HighwayCodeBtn.Name = "HighwayCodeBtn"
        Me.HighwayCodeBtn.Size = New System.Drawing.Size(90, 48)
        Me.HighwayCodeBtn.TabIndex = 11
        Me.HighwayCodeBtn.Text = "Highway Code"
        Me.HighwayCodeBtn.UseVisualStyleBackColor = True
        '
        'HazardPerceptionBtn
        '
        Me.HazardPerceptionBtn.Location = New System.Drawing.Point(264, 44)
        Me.HazardPerceptionBtn.Name = "HazardPerceptionBtn"
        Me.HazardPerceptionBtn.Size = New System.Drawing.Size(90, 48)
        Me.HazardPerceptionBtn.TabIndex = 10
        Me.HazardPerceptionBtn.Text = "Hazard Perception"
        Me.HazardPerceptionBtn.UseVisualStyleBackColor = True
        '
        'MockTestBtn
        '
        Me.MockTestBtn.Location = New System.Drawing.Point(153, 44)
        Me.MockTestBtn.Name = "MockTestBtn"
        Me.MockTestBtn.Size = New System.Drawing.Size(90, 48)
        Me.MockTestBtn.TabIndex = 9
        Me.MockTestBtn.Text = "Mock Test"
        Me.MockTestBtn.UseVisualStyleBackColor = True
        '
        'StudyBtn
        '
        Me.StudyBtn.Location = New System.Drawing.Point(210, 126)
        Me.StudyBtn.Name = "StudyBtn"
        Me.StudyBtn.Size = New System.Drawing.Size(90, 48)
        Me.StudyBtn.TabIndex = 8
        Me.StudyBtn.Text = "Study"
        Me.StudyBtn.UseVisualStyleBackColor = True
        '
        'PracticeQuizBtn
        '
        Me.PracticeQuizBtn.Location = New System.Drawing.Point(41, 44)
        Me.PracticeQuizBtn.Name = "PracticeQuizBtn"
        Me.PracticeQuizBtn.Size = New System.Drawing.Size(90, 48)
        Me.PracticeQuizBtn.TabIndex = 7
        Me.PracticeQuizBtn.Text = "Practice Quiz"
        Me.PracticeQuizBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(374, 219)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(90, 48)
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Location = New System.Drawing.Point(21, 291)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WelcomeLabel.Size = New System.Drawing.Size(0, 13)
        Me.WelcomeLabel.TabIndex = 12
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(12, 255)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(270, 55)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 13
        Me.Logo.TabStop = False
        '
        'DateTime
        '
        Me.DateTime.AutoSize = True
        Me.DateTime.Location = New System.Drawing.Point(424, 291)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(0, 13)
        Me.DateTime.TabIndex = 14
        '
        'PostLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 322)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.HighwayCodeBtn)
        Me.Controls.Add(Me.HazardPerceptionBtn)
        Me.Controls.Add(Me.MockTestBtn)
        Me.Controls.Add(Me.StudyBtn)
        Me.Controls.Add(Me.PracticeQuizBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Name = "PostLogin"
        Me.Text = "PostLogin"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HighwayCodeBtn As System.Windows.Forms.Button
    Friend WithEvents HazardPerceptionBtn As System.Windows.Forms.Button
    Friend WithEvents MockTestBtn As System.Windows.Forms.Button
    Friend WithEvents StudyBtn As System.Windows.Forms.Button
    Friend WithEvents PracticeQuizBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents DateTime As System.Windows.Forms.Label
End Class
