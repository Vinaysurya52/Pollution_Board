Public Class Watermon
    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into WatermonRec values('" & Branchtxt.Text & "','" & Watertxt.Text & "','" & Temptxt.Text & "','" & Citytxt.Text & "','" & Phtxt.Text & "','" & Colortxt.Text & "','" & Ammontxt.Text & "','" & Potasstxt.Text & "','" & CBMtxt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox(" Record Submission Successful", MsgBoxStyle.Information, "Record Submitted")
            Branchtxt.Text = ""
            Watertxt.Clear()
            Temptxt.Clear()
            Citytxt.Clear()
            Phtxt.Clear()
            Colortxt.Clear()
            Ammontxt.Clear()
            Potasstxt.Clear()
            CBMtxt.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Emphm.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Branchtxt.Text = ""
        Watertxt.Clear()
        Temptxt.Clear()
        Citytxt.Clear()
        Phtxt.Clear()
        Colortxt.Clear()
        Ammontxt.Clear()
        Potasstxt.Clear()
        CBMtxt.Text = ""
    End Sub
End Class