<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaterLab
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
        Me.Dtxt = New System.Windows.Forms.TextBox()
        Me.Itxt = New System.Windows.Forms.TextBox()
        Me.Ltxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtxt
        '
        Me.Dtxt.Location = New System.Drawing.Point(418, 233)
        Me.Dtxt.Name = "Dtxt"
        Me.Dtxt.Size = New System.Drawing.Size(209, 22)
        Me.Dtxt.TabIndex = 15
        '
        'Itxt
        '
        Me.Itxt.Location = New System.Drawing.Point(418, 188)
        Me.Itxt.Name = "Itxt"
        Me.Itxt.Size = New System.Drawing.Size(209, 22)
        Me.Itxt.TabIndex = 14
        '
        'Ltxt
        '
        Me.Ltxt.Location = New System.Drawing.Point(418, 144)
        Me.Ltxt.Name = "Ltxt"
        Me.Ltxt.Size = New System.Drawing.Size(209, 22)
        Me.Ltxt.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Infrastucture Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Lab Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Water Lab Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Department of Pollution Control Board"
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnclose.Location = New System.Drawing.Point(692, 224)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(158, 31)
        Me.Btnclose.TabIndex = 18
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnreset.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnreset.Location = New System.Drawing.Point(692, 179)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(158, 31)
        Me.Btnreset.TabIndex = 17
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnadd.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnadd.Location = New System.Drawing.Point(692, 135)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(158, 31)
        Me.Btnadd.TabIndex = 16
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(195, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(601, 197)
        Me.DataGridView1.TabIndex = 19
        '
        'WaterLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(973, 536)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Dtxt)
        Me.Controls.Add(Me.Itxt)
        Me.Controls.Add(Me.Ltxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WaterLab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee-[WaterLab]"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dtxt As TextBox
    Friend WithEvents Itxt As TextBox
    Friend WithEvents Ltxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnclose As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
