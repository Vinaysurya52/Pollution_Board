Public Class Hazar
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Emphm.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Branchtxt.Text = ""
        Citytxt.Clear()
        Qtxt.Clear()
        Dumtxt.Text = ""
    End Sub

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into HazarRec values('" & Branchtxt.Text & "','" & Citytxt.Text & "','" & Qtxt.Text & "','" & Dumtxt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Report Submitted Successfully", MsgBoxStyle.Information, "Report Submitted")
            Branchtxt.Text = ""
            Citytxt.Clear()
            Qtxt.Clear()
            Dumtxt.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class