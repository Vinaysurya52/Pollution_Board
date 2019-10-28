<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Airmon
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
        Me.CityName = New System.Windows.Forms.TextBox()
        Me.MQR = New System.Windows.Forms.TextBox()
        Me.AQI = New System.Windows.Forms.TextBox()
        Me.HI = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Branchtxt = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Air-Monitering-Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Measured-Quality-Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Air-Quality-Index"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Health-Impact"
        '
        'CityName
        '
        Me.CityName.Location = New System.Drawing.Point(557, 183)
        Me.CityName.Name = "CityName"
        Me.CityName.Size = New System.Drawing.Size(209, 24)
        Me.CityName.TabIndex = 7
        '
        'MQR
        '
        Me.MQR.Location = New System.Drawing.Point(557, 228)
        Me.MQR.Name = "MQR"
        Me.MQR.Size = New System.Drawing.Size(209, 24)
        Me.MQR.TabIndex = 8
        '
        'AQI
        '
        Me.AQI.Location = New System.Drawing.Point(557, 266)
        Me.AQI.Name = "AQI"
        Me.AQI.Size = New System.Drawing.Size(209, 24)
        Me.AQI.TabIndex = 9
        '
        'HI
        '
        Me.HI.Location = New System.Drawing.Point(557, 310)
        Me.HI.Name = "HI"
        Me.HI.Size = New System.Drawing.Size(209, 24)
        Me.HI.TabIndex = 10
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.SystemColors.Control
        Me.submit.Location = New System.Drawing.Point(398, 375)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(161, 51)
        Me.submit.TabIndex = 11
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.SystemColors.Control
        Me.reset.Location = New System.Drawing.Point(246, 433)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(161, 51)
        Me.reset.TabIndex = 12
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.SystemColors.Control
        Me.Back.Location = New System.Drawing.Point(557, 433)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(161, 51)
        Me.Back.TabIndex = 13
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Branchtxt
        '
        Me.Branchtxt.FormattingEnabled = True
        Me.Branchtxt.Items.AddRange(New Object() {"Environment_Monitering", "Waste_Management", "Industries", "Public"})
        Me.Branchtxt.Location = New System.Drawing.Point(557, 142)
        Me.Branchtxt.Name = "Branchtxt"
        Me.Branchtxt.Size = New System.Drawing.Size(209, 25)
        Me.Branchtxt.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(234, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(532, 32)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Department of Pollution Control Board"
        '
        'Airmon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(969, 534)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Branchtxt)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.HI)
        Me.Controls.Add(Me.AQI)
        Me.Controls.Add(Me.MQR)
        Me.Controls.Add(Me.CityName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Airmon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee-[Air-Monitering]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CityName As TextBox
    Friend WithEvents MQR As TextBox
    Friend WithEvents AQI As TextBox
    Friend WithEvents HI As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents reset As Button
    Friend WithEvents Back As Button
    Friend WithEvents Branchtxt As ComboBox
    Friend WithEvents Label7 As Label
End Class
