<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgottenPassword
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
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EnterEmailBtn = New System.Windows.Forms.TextBox()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.NewPasswordLabel = New System.Windows.Forms.Label()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(111, 134)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(35, 13)
        Me.EmailLabel.TabIndex = 0
        Me.EmailLabel.Text = "Email:"
        '
        'EnterEmailBtn
        '
        Me.EnterEmailBtn.Location = New System.Drawing.Point(167, 131)
        Me.EnterEmailBtn.Name = "EnterEmailBtn"
        Me.EnterEmailBtn.Size = New System.Drawing.Size(100, 20)
        Me.EnterEmailBtn.TabIndex = 1
        '
        'SendBtn
        '
        Me.SendBtn.Location = New System.Drawing.Point(434, 252)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(75, 23)
        Me.SendBtn.TabIndex = 2
        Me.SendBtn.Text = "Enter"
        Me.SendBtn.UseVisualStyleBackColor = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(29, 9)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(480, 44)
        Me.PasswordLabel.TabIndex = 13
        Me.PasswordLabel.Text = "Forgotten your password?"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NewPasswordLabel
        '
        Me.NewPasswordLabel.AutoSize = True
        Me.NewPasswordLabel.Location = New System.Drawing.Point(80, 182)
        Me.NewPasswordLabel.Name = "NewPasswordLabel"
        Me.NewPasswordLabel.Size = New System.Drawing.Size(81, 13)
        Me.NewPasswordLabel.TabIndex = 14
        Me.NewPasswordLabel.Text = "New Password:"
        '
        'NewPassword
        '
        Me.NewPassword.Location = New System.Drawing.Point(167, 175)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.Size = New System.Drawing.Size(100, 20)
        Me.NewPassword.TabIndex = 15
        '
        'ForgottenPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 296)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.NewPasswordLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.SendBtn)
        Me.Controls.Add(Me.EnterEmailBtn)
        Me.Controls.Add(Me.EmailLabel)
        Me.Name = "ForgottenPassword"
        Me.Text = "ForgottenPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents EnterEmailBtn As System.Windows.Forms.TextBox
    Friend WithEvents SendBtn As System.Windows.Forms.Button
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents NewPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents NewPassword As System.Windows.Forms.TextBox
End Class
