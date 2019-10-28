<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Awar
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
        Me.Protxt = New System.Windows.Forms.TextBox()
        Me.Dettxt = New System.Windows.Forms.TextBox()
        Me.Dattxt = New System.Windows.Forms.TextBox()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department of  Pollution Control Board"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Program Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Program Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Details"
        '
        'Protxt
        '
        Me.Protxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Protxt.Location = New System.Drawing.Point(489, 197)
        Me.Protxt.Name = "Protxt"
        Me.Protxt.Size = New System.Drawing.Size(228, 22)
        Me.Protxt.TabIndex = 4
        '
        'Dettxt
        '
        Me.Dettxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Dettxt.Location = New System.Drawing.Point(489, 242)
        Me.Dettxt.Name = "Dettxt"
        Me.Dettxt.Size = New System.Drawing.Size(228, 22)
        Me.Dettxt.TabIndex = 5
        '
        'Dattxt
        '
        Me.Dattxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Dattxt.Location = New System.Drawing.Point(489, 151)
        Me.Dattxt.Name = "Dattxt"
        Me.Dattxt.Size = New System.Drawing.Size(228, 22)
        Me.Dattxt.TabIndex = 6
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnadd.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnadd.Location = New System.Drawing.Point(369, 307)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(151, 47)
        Me.Btnadd.TabIndex = 7
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnreset.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnreset.Location = New System.Drawing.Point(236, 371)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(151, 47)
        Me.Btnreset.TabIndex = 8
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnclose.Location = New System.Drawing.Point(511, 371)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(151, 47)
        Me.Btnclose.TabIndex = 9
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Awar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 504)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Dattxt)
        Me.Controls.Add(Me.Dettxt)
        Me.Controls.Add(Me.Protxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Awar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee-[Awarness Programes]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Protxt As TextBox
    Friend WithEvents Dettxt As TextBox
    Friend WithEvents Dattxt As TextBox
    Friend WithEvents Btnadd As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents Btnclose As Button
End Class
