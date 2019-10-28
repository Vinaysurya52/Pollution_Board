Public Class Empr
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        TextBoxEmpId.Clear()
        TextBoxName.Clear()
        TextBoxPassword.Clear()
        TextBoxEmail.Clear()
        TextBoxAddress.Clear()
        TextBoxQualification.Clear()
        TextBoxMobile.Clear()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dm.Show()
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If TextBoxMobile.Text > 10 Then
            MsgBox("Mobile number should be only 10 digits")
            TextBoxMobile.Clear()
        Else

            Cmd.Connection = Con
            Con.Close()
            Try
                Cmd.CommandType = System.Data.CommandType.Text
                Cmd.CommandText = "Insert into Polrec values('" & TextBoxEmpId.Text & "','" & TextBoxName.Text & "','" & TextBoxPassword.Text & "','" & TextBoxEmail.Text & "','" & TextBoxAddress.Text & "','" & TextBoxQualification.Text & "','" & TextBoxMobile.Text & "')"

                Cmd.Connection = Con
                Con.Open()
                Cmd.ExecuteNonQuery()
                MsgBox("Successfully Saved Now you are officially registered", MsgBoxStyle.Information, "Record Registered")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            TextBoxEmpId.Clear()
            TextBoxName.Clear()
            TextBoxPassword.Clear()
            TextBoxEmail.Clear()
            TextBoxAddress.Clear()
            TextBoxQualification.Clear()
            TextBoxMobile.Clear()

        End If


    End Sub

    Private Sub TextBoxEmpId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmpId.TextChanged
        TextBoxEmpId.Focus()
    End Sub

    Private Sub TextBoxMobile_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMobile.TextChanged
        Try
            If TextBoxMobile.Text > 10 Then
                MsgBox("Mobile number should be only 10 digits")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class