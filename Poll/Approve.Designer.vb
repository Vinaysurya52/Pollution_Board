<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Approve
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
        Me.Emptxt = New System.Windows.Forms.TextBox()
        Me.Nametxt = New System.Windows.Forms.TextBox()
        Me.Mobtxt = New System.Windows.Forms.TextBox()
        Me.Etxt = New System.Windows.Forms.TextBox()
        Me.Btnapp = New System.Windows.Forms.Button()
        Me.Btnshow = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department of  Pollution Control Board"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Emp-Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mobile"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 185)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Emptxt
        '
        Me.Emptxt.Location = New System.Drawing.Point(292, 97)
        Me.Emptxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Emptxt.Name = "Emptxt"
        Me.Emptxt.Size = New System.Drawing.Size(98, 20)
        Me.Emptxt.TabIndex = 5
        '
        'Nametxt
        '
        Me.Nametxt.Location = New System.Drawing.Point(292, 124)
        Me.Nametxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(98, 20)
        Me.Nametxt.TabIndex = 6
        '
        'Mobtxt
        '
        Me.Mobtxt.Location = New System.Drawing.Point(292, 154)
        Me.Mobtxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Mobtxt.Name = "Mobtxt"
        Me.Mobtxt.Size = New System.Drawing.Size(98, 20)
        Me.Mobtxt.TabIndex = 7
        '
        'Etxt
        '
        Me.Etxt.Location = New System.Drawing.Point(292, 185)
        Me.Etxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Etxt.Name = "Etxt"
        Me.Etxt.Size = New System.Drawing.Size(98, 20)
        Me.Etxt.TabIndex = 8
        '
        'Btnapp
        '
        Me.Btnapp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnapp.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnapp.Location = New System.Drawing.Point(448, 96)
        Me.Btnapp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnapp.Name = "Btnapp"
        Me.Btnapp.Size = New System.Drawing.Size(122, 34)
        Me.Btnapp.TabIndex = 9
        Me.Btnapp.Text = "Approve"
        Me.Btnapp.UseVisualStyleBackColor = False
        '
        'Btnshow
        '
        Me.Btnshow.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnshow.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnshow.Location = New System.Drawing.Point(448, 140)
        Me.Btnshow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnshow.Name = "Btnshow"
        Me.Btnshow.Size = New System.Drawing.Size(122, 34)
        Me.Btnshow.TabIndex = 10
        Me.Btnshow.Text = "Show_All"
        Me.Btnshow.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnclose.Location = New System.Drawing.Point(448, 185)
        Me.Btnclose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(122, 34)
        Me.Btnclose.TabIndex = 11
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(148, 239)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(429, 162)
        Me.DataGridView1.TabIndex = 12
        '
        'Approve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 427)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnshow)
        Me.Controls.Add(Me.Btnapp)
        Me.Controls.Add(Me.Etxt)
        Me.Controls.Add(Me.Mobtxt)
        Me.Controls.Add(Me.Nametxt)
        Me.Controls.Add(Me.Emptxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Approve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin-[Approve Employee]"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Emptxt As TextBox
    Friend WithEvents Nametxt As TextBox
    Friend WithEvents Mobtxt As TextBox
    Friend WithEvents Etxt As TextBox
    Friend WithEvents Btnapp As Button
    Friend WithEvents Btnshow As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
