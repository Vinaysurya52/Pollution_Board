Public Class Airmon


    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        Branchtxt.Text = ""
        CityName.Clear()
        MQR.Clear()
        AQI.Clear()
        HI.Clear()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Emphm.Show()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into AirmonRec values('" & Branchtxt.Text & "','" & CityName.Text & "','" & MQR.Text & "','" & AQI.Text & "','" & HI.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Successfully Recorded", MsgBoxStyle.Information, "Record Saved")
            Branchtxt.Text = ""
            CityName.Clear()
            MQR.Clear()
            AQI.Clear()
            HI.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class