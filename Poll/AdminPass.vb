Public Class AdminPass
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        AdLogin.Show()
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Admintxt.Text = "" And Ptxt.Text = "" Then
            MsgBox("Enter Admin-Name And Password", MsgBoxStyle.Information, "Warning")
            Admintxt.Clear()
            Ptxt.Clear()
        End If

        Try
            If Admintxt.Text = "" And Ptxt.Text = "" And Pstxt.Text = "" Then
                MsgBox("Enter your credentials", MsgBoxStyle.Information, "Warning")
            End If

            Try
                If Con.State = ConnectionState.Open Then Con.Close()
                Con.Open()

                Dim cmd1 As New SqlClient.SqlCommand("update AdminRec set AdMinPass='" & Pstxt.Text & "' where AdminName='" & Admintxt.Text & "'and AdMinPhone='" & Ptxt.Text & "'", Con)
                cmd1.ExecuteNonQuery()
                MsgBox("Password Successfully Recovered,Now You can login with your new password", MsgBoxStyle.Information, "Recovery")
                If Con.State = ConnectionState.Open Then Con.Close()
                Admintxt.Clear()
                Ptxt.Clear()
                Pstxt.Clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Catch ex As Exception

        End Try





    End Sub


End Class