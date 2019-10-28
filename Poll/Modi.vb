Public Class Modi
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Hide()
        Dm.Show()

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

    Private Sub Modi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxEmpId.Text = a
        TextBoxName.Text = b
        TextBoxPassword.Text = c
        TextBoxEmail.Text = d
        TextBoxAddress.Text = f
        TextBoxQualification.Text = g
        TextBoxMobile.Text = h

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnmodify.Click
        If vbNo = MsgBox("Are you sure you want to modify this record", MsgBoxStyle.YesNo, "Modify") Then
            Exit Sub
        End If

        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()

        Dim cmd1 As New SqlClient.SqlCommand("Delete from Polrec where EmpId= '" & Pkvar & "'", Con)
        cmd1.ExecuteNonQuery()

        If Con.State = ConnectionState.Open Then Con.Close()
        saverecord()

    End Sub
    Sub saverecord()
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into Polrec values('" & TextBoxEmpId.Text & "','" & TextBoxName.Text & "','" & TextBoxPassword.Text & "','" & TextBoxEmail.Text & "','" & TextBoxAddress.Text & "','" & TextBoxQualification.Text & "','" & TextBoxMobile.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Successfully Modified", MsgBoxStyle.Information, "Record Modified")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class