<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPass
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
        Me.Admintxt = New System.Windows.Forms.TextBox()
        Me.Ptxt = New System.Windows.Forms.TextBox()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pstxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department of Pollution Control  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Admin-Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Admin Phone.no"
        '
        'Admintxt
        '
        Me.Admintxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Admintxt.Location = New System.Drawing.Point(428, 150)
        Me.Admintxt.Name = "Admintxt"
        Me.Admintxt.Size = New System.Drawing.Size(191, 22)
        Me.Admintxt.TabIndex = 3
        '
        'Ptxt
        '
        Me.Ptxt.Location = New System.Drawing.Point(428, 187)
        Me.Ptxt.Name = "Ptxt"
        Me.Ptxt.Size = New System.Drawing.Size(191, 22)
        Me.Ptxt.TabIndex = 4
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnsave.Location = New System.Drawing.Point(261, 303)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(122, 48)
        Me.Btnsave.TabIndex = 5
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnclose.Location = New System.Drawing.Point(408, 303)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(122, 48)
        Me.Btnclose.TabIndex = 6
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter New Password"
        '
        'Pstxt
        '
        Me.Pstxt.Location = New System.Drawing.Point(428, 229)
        Me.Pstxt.Name = "Pstxt"
        Me.Pstxt.Size = New System.Drawing.Size(191, 22)
        Me.Pstxt.TabIndex = 8
        '
        'AdminPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 457)
        Me.Controls.Add(Me.Pstxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Ptxt)
        Me.Controls.Add(Me.Admintxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin-[password Recovery]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Admintxt As TextBox
    Friend WithEvents Ptxt As TextBox
    Friend WithEvents Btnsave As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Pstxt As TextBox
End Class
