<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.RegisterPasswordTxtBox = New System.Windows.Forms.TextBox()
        Me.RegisterPasswordLabel = New System.Windows.Forms.Label()
        Me.RegisterUsernameLabel = New System.Windows.Forms.Label()
        Me.RegisterUsernameTxtBox = New System.Windows.Forms.TextBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.SurnameTxtBox = New System.Windows.Forms.TextBox()
        Me.ForenameTxtBox = New System.Windows.Forms.TextBox()
        Me.ForenameLabel = New System.Windows.Forms.Label()
        Me.SurnameLabel = New System.Windows.Forms.Label()
        Me.RegisterBtnForm = New System.Windows.Forms.Button()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegisterPasswordTxtBox
        '
        Me.RegisterPasswordTxtBox.Location = New System.Drawing.Point(233, 282)
        Me.RegisterPasswordTxtBox.Name = "RegisterPasswordTxtBox"
        Me.RegisterPasswordTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterPasswordTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.RegisterPasswordTxtBox.TabIndex = 11
        '
        'RegisterPasswordLabel
        '
        Me.RegisterPasswordLabel.AutoSize = True
        Me.RegisterPasswordLabel.Location = New System.Drawing.Point(167, 285)
        Me.RegisterPasswordLabel.Name = "RegisterPasswordLabel"
        Me.RegisterPasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.RegisterPasswordLabel.TabIndex = 10
        Me.RegisterPasswordLabel.Text = "Password"
        '
        'RegisterUsernameLabel
        '
        Me.RegisterUsernameLabel.AutoSize = True
        Me.RegisterUsernameLabel.Location = New System.Drawing.Point(165, 235)
        Me.RegisterUsernameLabel.Name = "RegisterUsernameLabel"
        Me.RegisterUsernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.RegisterUsernameLabel.TabIndex = 7
        Me.RegisterUsernameLabel.Text = "Username"
        '
        'RegisterUsernameTxtBox
        '
        Me.RegisterUsernameTxtBox.Location = New System.Drawing.Point(233, 232)
        Me.RegisterUsernameTxtBox.Name = "RegisterUsernameTxtBox"
        Me.RegisterUsernameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.RegisterUsernameTxtBox.TabIndex = 6
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(41, 12)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(466, 100)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 12
        Me.Logo.TabStop = False
        '
        'SurnameTxtBox
        '
        Me.SurnameTxtBox.Location = New System.Drawing.Point(233, 183)
        Me.SurnameTxtBox.Name = "SurnameTxtBox"
        Me.SurnameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTxtBox.TabIndex = 13
        '
        'ForenameTxtBox
        '
        Me.ForenameTxtBox.Location = New System.Drawing.Point(233, 142)
        Me.ForenameTxtBox.Name = "ForenameTxtBox"
        Me.ForenameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ForenameTxtBox.TabIndex = 14
        '
        'ForenameLabel
        '
        Me.ForenameLabel.AutoSize = True
        Me.ForenameLabel.Location = New System.Drawing.Point(165, 145)
        Me.ForenameLabel.Name = "ForenameLabel"
        Me.ForenameLabel.Size = New System.Drawing.Size(54, 13)
        Me.ForenameLabel.TabIndex = 15
        Me.ForenameLabel.Text = "Forename"
        '
        'SurnameLabel
        '
        Me.SurnameLabel.AutoSize = True
        Me.SurnameLabel.Location = New System.Drawing.Point(167, 186)
        Me.SurnameLabel.Name = "SurnameLabel"
        Me.SurnameLabel.Size = New System.Drawing.Size(49, 13)
        Me.SurnameLabel.TabIndex = 16
        Me.SurnameLabel.Text = "Surname"
        '
        'RegisterBtnForm
        '
        Me.RegisterBtnForm.Location = New System.Drawing.Point(389, 282)
        Me.RegisterBtnForm.Name = "RegisterBtnForm"
        Me.RegisterBtnForm.Size = New System.Drawing.Size(75, 23)
        Me.RegisterBtnForm.TabIndex = 9
        Me.RegisterBtnForm.Text = "Register"
        Me.RegisterBtnForm.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 364)
        Me.Controls.Add(Me.SurnameLabel)
        Me.Controls.Add(Me.ForenameLabel)
        Me.Controls.Add(Me.ForenameTxtBox)
        Me.Controls.Add(Me.SurnameTxtBox)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.RegisterPasswordTxtBox)
        Me.Controls.Add(Me.RegisterPasswordLabel)
        Me.Controls.Add(Me.RegisterBtnForm)
        Me.Controls.Add(Me.RegisterUsernameLabel)
        Me.Controls.Add(Me.RegisterUsernameTxtBox)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegisterPasswordTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents RegisterPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterUsernameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents SurnameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ForenameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ForenameLabel As System.Windows.Forms.Label
    Friend WithEvents SurnameLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterBtnForm As System.Windows.Forms.Button
End Class
