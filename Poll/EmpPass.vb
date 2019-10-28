Public Class EmpPass
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        EmpLogin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnsave.Click


        Try
            If Con.State = ConnectionState.Open Then Con.Close()
            Con.Open()
            If Emptxt.Text = "" And Nametxt.Text = "" And Etxt.Text = "" And Mtxt.Text = "" Then
                MsgBox("Enter your credentials", MsgBoxStyle.Information, "Wraning")
            End If

            Dim cmd1 As New SqlClient.SqlCommand("update Polrec set Password='" & Passtxt.Text & "' where EmpId='" & Emptxt.Text & "'and Name='" & Nametxt.Text & "'and Email='" & Etxt.Text & "'and Mobile='" & Mtxt.Text & "'", Con)
            cmd1.ExecuteNonQuery()
            MsgBox("Password Recovered Successfully", MsgBoxStyle.Information, "Recovery")
            If Con.State = ConnectionState.Open Then Con.Close()
            Emptxt.Clear()
            Nametxt.Clear()
            Etxt.Clear()
            Mtxt.Clear()
            Passtxt.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            End Try


    End Sub

End Class