Public Class Add
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Adminhm.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Branchtxt.Clear()
        Addtxt.Clear()
        Dettxt.Clear()
    End Sub

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into AdminBranch values('" & Branchtxt.Text & "','" & Addtxt.Text & "','" & Dettxt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Data Successfully Added", MsgBoxStyle.Information, "Data Added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class