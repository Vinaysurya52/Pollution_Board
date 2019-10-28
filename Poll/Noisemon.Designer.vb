<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Noisemon
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Citytxt = New System.Windows.Forms.TextBox()
        Me.Btnsubmit = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Dtxt = New System.Windows.Forms.TextBox()
        Me.CBM1txt = New System.Windows.Forms.ComboBox()
        Me.Branchtxt = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department of pollution Control Board"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Noise Monitering Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Branch Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(180, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Observed Sound level"
        '
        'Citytxt
        '
        Me.Citytxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Citytxt.Location = New System.Drawing.Point(531, 180)
        Me.Citytxt.Name = "Citytxt"
        Me.Citytxt.Size = New System.Drawing.Size(199, 22)
        Me.Citytxt.TabIndex = 7
        '
        'Btnsubmit
        '
        Me.Btnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnsubmit.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnsubmit.Location = New System.Drawing.Point(387, 336)
        Me.Btnsubmit.Name = "Btnsubmit"
        Me.Btnsubmit.Size = New System.Drawing.Size(143, 43)
        Me.Btnsubmit.TabIndex = 10
        Me.Btnsubmit.Text = "Submit"
        Me.Btnsubmit.UseVisualStyleBackColor = False
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnreset.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnreset.Location = New System.Drawing.Point(245, 396)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(143, 43)
        Me.Btnreset.TabIndex = 11
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnclose.Location = New System.Drawing.Point(518, 396)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(143, 43)
        Me.Btnclose.TabIndex = 12
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Dtxt
        '
        Me.Dtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Dtxt.Location = New System.Drawing.Point(531, 219)
        Me.Dtxt.Name = "Dtxt"
        Me.Dtxt.Size = New System.Drawing.Size(199, 22)
        Me.Dtxt.TabIndex = 13
        '
        'CBM1txt
        '
        Me.CBM1txt.FormattingEnabled = True
        Me.CBM1txt.Items.AddRange(New Object() {"Below_Harming", "Medium_Harming", "Harming"})
        Me.CBM1txt.Location = New System.Drawing.Point(531, 258)
        Me.CBM1txt.Name = "CBM1txt"
        Me.CBM1txt.Size = New System.Drawing.Size(199, 24)
        Me.CBM1txt.TabIndex = 14
        '
        'Branchtxt
        '
        Me.Branchtxt.FormattingEnabled = True
        Me.Branchtxt.Items.AddRange(New Object() {"Environment_Monitering", "Waste_Management", "Industries", "Public"})
        Me.Branchtxt.Location = New System.Drawing.Point(531, 138)
        Me.Branchtxt.Name = "Branchtxt"
        Me.Branchtxt.Size = New System.Drawing.Size(199, 24)
        Me.Branchtxt.TabIndex = 15
        '
        'Noisemon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 537)
        Me.Controls.Add(Me.Branchtxt)
        Me.Controls.Add(Me.CBM1txt)
        Me.Controls.Add(Me.Dtxt)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnsubmit)
        Me.Controls.Add(Me.Citytxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Noisemon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee-[Noise Monitering]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Citytxt As TextBox
    Friend WithEvents Btnsubmit As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents Dtxt As TextBox
    Friend WithEvents CBM1txt As ComboBox
    Friend WithEvents Branchtxt As ComboBox
End Class
