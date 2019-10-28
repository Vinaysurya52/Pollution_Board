Public Class EmpLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            If Con.State = ConnectionState.Open Then Con.Close()
            Con.Open()
            If TextBoxUsername.Text = "" And TextBoxPassword.Text = "" Then
                MsgBox("Enter username and password", MsgBoxStyle.Information, "Warning")
                Exit Sub
            End If
            Dim cmd As New SqlClient.SqlCommand("select * from Polrec where Name='" & UCase(TextBoxUsername.Text) & "' and Password='" & TextBoxPassword.Text & "'", Con)
            Dim D1 As SqlClient.SqlDataReader = cmd.ExecuteReader()
            If D1.HasRows Then
                Me.Hide()
                Emphm.Show()
            Else

                MsgBox("username and password is incorrect", MsgBoxStyle.Information, "Warning")
                TextBoxUsername.Text = ""
                TextBoxPassword.Text = ""
                TextBoxUsername.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        EmpPass.Show()
    End Sub
End Class