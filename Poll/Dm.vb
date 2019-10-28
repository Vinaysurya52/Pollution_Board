Public Class Dm


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Empr.Show()
    End Sub

    Private Sub Dm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PolDataSet.Polrec' table. You can move, or remove it, as needed.
        Me.PolrecTableAdapter.Fill(Me.PolDataSet.Polrec)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Pkvar = DataGridView1.CurrentRow.Cells(0).Value
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim cmd0 As New SqlClient.SqlCommand("Select * From Polrec Where EmpId ='" & Pkvar & "'", Con)
        Dim d1 As SqlClient.SqlDataReader = cmd0.ExecuteReader()
        If Con.State = ConnectionState.Open Then Con.Close()
        disrecord()
    End Sub
    Sub disrecord()
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim ds1 As New DataSet
        Dim adp = New SqlClient.SqlDataAdapter("Select EmpId,Name,Password,Email,Address,Qualification,Mobile From PolRec", Con)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If Con.State = ConnectionState.Open Then Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        If vbNo = MsgBox("Are you sure you want to Delete this record", MsgBoxStyle.YesNo, "Delete") Then
            Exit Sub
        End If

        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()

        Dim cmd1 As New SqlClient.SqlCommand("Delete from Polrec where EmpId= '" & Pkvar & "'", Con)
        Dim Index As Integer
        Index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(Index)
        cmd1.ExecuteNonQuery()

        If Con.State = ConnectionState.Open Then Con.Close()



    End Sub



    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Pkvar = DataGridView1.CurrentRow.Cells(0).Value

        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()

        Dim Cmd0 As New SqlClient.SqlCommand("select * from Polrec where EmpId = '" & Pkvar & "'", Con)
        Dim D1 As SqlClient.SqlDataReader = Cmd0.ExecuteReader()

        If D1.HasRows Then
            D1.Read()
            a = D1(0).ToString
            b = D1(1).ToString
            c = D1(2).ToString
            d = D1(3).ToString
            f = D1(4).ToString
            g = D1(5).ToString
            h = D1(6).ToString

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Modi.Show()
    End Sub
End Class