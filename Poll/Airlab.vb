Public Class Airlab
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Emphm.Show()
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Ltxt.Clear()
        Itxt.Clear()
        Dtxt.Clear()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Cmd.Connection = Con
        Con.Close()
        Try
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Insert into AirRec values('" & Ltxt.Text & "','" & Itxt.Text & "','" & Dtxt.Text & "')"

            Cmd.Connection = Con
            Con.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Data Successfully Added", MsgBoxStyle.Information, "Data Added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim Pkvar As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Pkvar = DataGridView1.CurrentRow.Cells(0).Value
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim cmd0 As New SqlClient.SqlCommand("Select * From AirRec Where Lab_Code ='" & Pkvar & "'", Con)
        Dim d1 As SqlClient.SqlDataReader = cmd0.ExecuteReader()
        If Con.State = ConnectionState.Open Then Con.Close()
        disrecord()
    End Sub
    Sub disrecord()
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim ds1 As New DataSet
        Dim adp = New SqlClient.SqlDataAdapter("Select Lab_Code,Infrastructure_Name,Details From AirRec", Con)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If Con.State = ConnectionState.Open Then Con.Close()
    End Sub

    Private Sub Airlab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disrecord()
    End Sub
End Class