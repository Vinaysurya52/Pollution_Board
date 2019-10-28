Public Class Awar
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Emphm.Show()

    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Dattxt.Clear()
        Protxt.Clear()
        Dettxt.Clear()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into AwarneesRec values('" & Dattxt.Text & "','" & Protxt.Text & "','" & Dettxt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Data Successfully Added", MsgBoxStyle.Information, "Data Added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class