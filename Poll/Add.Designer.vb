<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.Branchtxt = New System.Windows.Forms.TextBox()
        Me.Addtxt = New System.Windows.Forms.TextBox()
        Me.Dettxt = New System.Windows.Forms.TextBox()
        Me.Btnsubmit = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Pollution Control Board"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Details"
        '
        'Branchtxt
        '
        Me.Branchtxt.Location = New System.Drawing.Point(513, 162)
        Me.Branchtxt.Name = "Branchtxt"
        Me.Branchtxt.Size = New System.Drawing.Size(224, 22)
        Me.Branchtxt.TabIndex = 4
        '
        'Addtxt
        '
        Me.Addtxt.Location = New System.Drawing.Point(513, 200)
        Me.Addtxt.Name = "Addtxt"
        Me.Addtxt.Size = New System.Drawing.Size(224, 22)
        Me.Addtxt.TabIndex = 5
        '
        'Dettxt
        '
        Me.Dettxt.Location = New System.Drawing.Point(513, 235)
        Me.Dettxt.Name = "Dettxt"
        Me.Dettxt.Size = New System.Drawing.Size(224, 22)
        Me.Dettxt.TabIndex = 6
        '
        'Btnsubmit
        '
        Me.Btnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsubmit.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnsubmit.Location = New System.Drawing.Point(383, 331)
        Me.Btnsubmit.Name = "Btnsubmit"
        Me.Btnsubmit.Size = New System.Drawing.Size(130, 47)
        Me.Btnsubmit.TabIndex = 7
        Me.Btnsubmit.Text = "Submit"
        Me.Btnsubmit.UseVisualStyleBackColor = False
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreset.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnreset.Location = New System.Drawing.Point(252, 397)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(130, 47)
        Me.Btnreset.TabIndex = 8
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnclose.Location = New System.Drawing.Point(513, 397)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(130, 47)
        Me.Btnclose.TabIndex = 9
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(923, 527)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnsubmit)
        Me.Controls.Add(Me.Dettxt)
        Me.Controls.Add(Me.Addtxt)
        Me.Controls.Add(Me.Branchtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin-[Add Branches]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Branchtxt As TextBox
    Friend WithEvents Addtxt As TextBox
    Friend WithEvents Dettxt As TextBox
    Friend WithEvents Btnsubmit As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents Btnclose As Button
End Class
