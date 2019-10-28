Public Class PubNot
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Emphm.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        CBMtxt.Text = ""
        Citytxt.Clear()
        Dtxt.Clear()
        Pertxt.Clear()
        Nottxt.Clear()
    End Sub

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into PublicRec values('" & CBMtxt.Text & "','" & Citytxt.Text & "','" & Dtxt.Text & "','" & Pertxt.Text & "','" & Nottxt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Successfully Submitted", MsgBoxStyle.Information, "Record Submitted")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class