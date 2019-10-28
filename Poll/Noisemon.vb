Public Class Noisemon
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Emphm.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Branchtxt.Text = ""
        Citytxt.Clear()
        Dtxt.Clear()
        CBM1txt.Text = ""

    End Sub

    Private Sub Branchtxt_TextChanged(sender As Object, e As EventArgs)
        Me.Text = "R & D"
    End Sub

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into Noisemon values('" & Branchtxt.Text & "','" & Citytxt.Text & "','" & Dtxt.Text & "','" & CBM1txt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Report Submitted Successfully", MsgBoxStyle.Information, "Record Submitted")
            Branchtxt.Text = ""
            Citytxt.Clear()
            Dtxt.Clear()
            CBM1txt.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class