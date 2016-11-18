<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeScreen))
        Me.UsernameTxtBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTxtBox = New System.Windows.Forms.TextBox()
        Me.ForgottenPasswordBtn = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameTxtBox
        '
        Me.UsernameTxtBox.Location = New System.Drawing.Point(297, 200)
        Me.UsernameTxtBox.Name = "UsernameTxtBox"
        Me.UsernameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTxtBox.TabIndex = 0
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(230, 207)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username"
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(384, 287)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoginBtn.TabIndex = 2
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Location = New System.Drawing.Point(465, 287)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(75, 23)
        Me.RegisterBtn.TabIndex = 3
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(230, 235)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordTxtBox
        '
        Me.PasswordTxtBox.Location = New System.Drawing.Point(297, 232)
        Me.PasswordTxtBox.Name = "PasswordTxtBox"
        Me.PasswordTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTxtBox.TabIndex = 5
        '
        'ForgottenPasswordBtn
        '
        Me.ForgottenPasswordBtn.Location = New System.Drawing.Point(465, 377)
        Me.ForgottenPasswordBtn.Name = "ForgottenPasswordBtn"
        Me.ForgottenPasswordBtn.Size = New System.Drawing.Size(172, 23)
        Me.ForgottenPasswordBtn.TabIndex = 6
        Me.ForgottenPasswordBtn.Text = "Forgotten your password?"
        Me.ForgottenPasswordBtn.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(97, 12)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(466, 100)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 7
        Me.Logo.TabStop = False
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 412)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.ForgottenPasswordBtn)
        Me.Controls.Add(Me.PasswordTxtBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.UsernameTxtBox)
        Me.Name = "HomeScreen"
        Me.Text = "Welcome to L2DrivingTheory"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents RegisterBtn As System.Windows.Forms.Button
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ForgottenPasswordBtn As System.Windows.Forms.Button
    Friend WithEvents Logo As System.Windows.Forms.PictureBox

End Class
