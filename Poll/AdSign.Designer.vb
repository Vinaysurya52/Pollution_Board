<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdSign
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department of  Pollution Control Board"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Your Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Your Password"
        '
        'TextBoxName
        '
        Me.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName.Location = New System.Drawing.Point(539, 156)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(238, 22)
        Me.TextBoxName.TabIndex = 3
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(539, 200)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPass.Size = New System.Drawing.Size(238, 22)
        Me.TextBoxPass.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter Your Phone.no"
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Location = New System.Drawing.Point(539, 246)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(238, 22)
        Me.TextBoxPhone.TabIndex = 6
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnsave.Location = New System.Drawing.Point(403, 327)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(148, 45)
        Me.Btnsave.TabIndex = 7
        Me.Btnsave.Text = "Sign-up"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnreset.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnreset.Location = New System.Drawing.Point(263, 396)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(148, 45)
        Me.Btnreset.TabIndex = 8
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnclose.Location = New System.Drawing.Point(539, 396)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(148, 45)
        Me.Btnclose.TabIndex = 9
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sign-Up"
        '
        'AdSign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(954, 540)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.TextBoxPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdSign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin-[sign-up]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents Btnsave As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents Label5 As Label
End Class
