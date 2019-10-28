Public Class AdLogin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        TextBoxAdnm.Clear()
        TextBoxAdpass.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnlog.Click
        Try
            If Con.State = ConnectionState.Open Then Con.Close()
            Con.Open()
            If TextBoxAdnm.Text = "" And TextBoxAdpass.Text = "" Then
                MsgBox("Enter username and password", MsgBoxStyle.Information, "Warning")
                Exit Sub
            End If
            Dim cmd As New SqlClient.SqlCommand("select * from AdminRec where AdminName='" & UCase(TextBoxAdnm.Text) & "' and AdminPass='" & TextBoxAdpass.Text & "'", Con)
            Dim D1 As SqlClient.SqlDataReader = cmd.ExecuteReader()
            If D1.HasRows Then
                Me.Hide()
                Adminhm.Show()
            Else

                MsgBox("username and password is incorrect", MsgBoxStyle.Information, "Warning")
                TextBoxAdnm.Text = ""
                TextBoxAdpass.Text = ""
                TextBoxAdnm.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        AdminPass.Show()
    End Sub
End Class