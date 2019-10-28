Public Class WatqulRep
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Pkvar = DataGridView1.CurrentRow.Cells(0).Value
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim cmd0 As New SqlClient.SqlCommand("Select * From WatermonRec", Con)
        Dim d1 As SqlClient.SqlDataReader = cmd0.ExecuteReader()
        If Con.State = ConnectionState.Open Then Con.Close()
        disrecord()
    End Sub
    Sub disrecord()
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim ds1 As New DataSet
        Dim adp = New SqlClient.SqlDataAdapter("Select Branch_Name,Water_Sample_no,Temperature,City_Name,Ph_value,Color,Ammonia,Potassium,Year From WatermonRec", Con)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If Con.State = ConnectionState.Open Then Con.Close()
    End Sub

    Private Sub WatqulRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disrecord()
    End Sub
End Class