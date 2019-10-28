Public Class AdSign
    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        TextBoxName.Clear()
        TextBoxPass.Clear()
        TextBoxPhone.Clear()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into AdminRec values('" & TextBoxName.Text & "','" & TextBoxPass.Text & "','" & TextBoxPhone.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Successfully Saved Now you are officially registered", MsgBoxStyle.Information, "Record Registered")
            TextBoxName.Clear()
            TextBoxPass.Clear()
            TextBoxPhone.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class