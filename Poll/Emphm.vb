Imports System.Windows.Forms

Public Class Emphm

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AirMoniteringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AirMoniteringToolStripMenuItem.Click
        Me.Hide()
        Airmon.Show()
    End Sub

    Private Sub WaterMoniteringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterMoniteringToolStripMenuItem.Click
        Me.Hide()
        Watermon.Show()
    End Sub

    Private Sub NoiseMoniteringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoiseMoniteringToolStripMenuItem.Click
        Me.Hide()
        Noisemon.Show()
    End Sub

    Private Sub HazardousWasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HazardousWasteToolStripMenuItem.Click
        Me.Hide()
        Hazar.Show()
    End Sub

    Private Sub BiodegradableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiodegradableToolStripMenuItem.Click
        Me.Hide()
        Biodeg.Show()
    End Sub

    Private Sub NonBiodegradableWasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonBiodegradableWasteToolStripMenuItem.Click
        Me.Hide()
        NonBio.Show()
    End Sub

    Private Sub AirLabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AirLabToolStripMenuItem.Click
        Me.Hide()
        Airlab.Show()
    End Sub

    Private Sub PublicNoticesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublicNoticesToolStripMenuItem.Click
        Me.Hide()
        PubNot.Show()
    End Sub

    Private Sub AwarenessProgrammesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AwarenessProgrammesToolStripMenuItem.Click
        Me.Hide()
        Awar.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub WaterLabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterLabToolStripMenuItem.Click
        Me.Hide()
        WaterLab.Show()
    End Sub
End Class
