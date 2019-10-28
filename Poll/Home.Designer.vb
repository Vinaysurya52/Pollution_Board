<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AirQualityReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaterQualityReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoniteredNoiseReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAwarenessProgrammesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.AdminToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(948, 31)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(102, 27)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.SignupToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(78, 27)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(158, 28)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'SignupToolStripMenuItem
        '
        Me.SignupToolStripMenuItem.Name = "SignupToolStripMenuItem"
        Me.SignupToolStripMenuItem.Size = New System.Drawing.Size(158, 28)
        Me.SignupToolStripMenuItem.Text = "Sign-up"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AirQualityReportsToolStripMenuItem, Me.WaterQualityReportsToolStripMenuItem, Me.MoniteredNoiseReportsToolStripMenuItem, Me.ViewAwarenessProgrammesToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(86, 27)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'AirQualityReportsToolStripMenuItem
        '
        Me.AirQualityReportsToolStripMenuItem.Name = "AirQualityReportsToolStripMenuItem"
        Me.AirQualityReportsToolStripMenuItem.Size = New System.Drawing.Size(329, 28)
        Me.AirQualityReportsToolStripMenuItem.Text = "Air Quality Reports"
        '
        'WaterQualityReportsToolStripMenuItem
        '
        Me.WaterQualityReportsToolStripMenuItem.Name = "WaterQualityReportsToolStripMenuItem"
        Me.WaterQualityReportsToolStripMenuItem.Size = New System.Drawing.Size(329, 28)
        Me.WaterQualityReportsToolStripMenuItem.Text = "Water Quality Reports"
        '
        'MoniteredNoiseReportsToolStripMenuItem
        '
        Me.MoniteredNoiseReportsToolStripMenuItem.Name = "MoniteredNoiseReportsToolStripMenuItem"
        Me.MoniteredNoiseReportsToolStripMenuItem.Size = New System.Drawing.Size(329, 28)
        Me.MoniteredNoiseReportsToolStripMenuItem.Text = "Monitered Noise Reports"
        '
        'ViewAwarenessProgrammesToolStripMenuItem
        '
        Me.ViewAwarenessProgrammesToolStripMenuItem.Name = "ViewAwarenessProgrammesToolStripMenuItem"
        Me.ViewAwarenessProgrammesToolStripMenuItem.Size = New System.Drawing.Size(329, 28)
        Me.ViewAwarenessProgrammesToolStripMenuItem.Text = "View Awareness Programmes"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 492)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(948, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Poll.My.Resources.Resources.Karnataka_Flag_INDIA_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(948, 518)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AirQualityReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaterQualityReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoniteredNoiseReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAwarenessProgrammesToolStripMenuItem As ToolStripMenuItem
End Class
