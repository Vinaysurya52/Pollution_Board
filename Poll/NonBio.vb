﻿Public Class NonBio
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Emphm.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Branchtxt.Text = ""
        Citytxt.Clear()
        Wastetxt.Clear()
        Qtxt.Clear()
        Dumtxt.Text = ""
    End Sub

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into NonbioRec values('" & Branchtxt.Text & "','" & Citytxt.Text & "','" & Wastetxt.Text & "','" & Qtxt.Text & "','" & Dumtxt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Record Submitted Successfully", MsgBoxStyle.Information, "Record Submitted")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class