Public Class Approve
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Hide()
        Adminhm.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Pkvar = DataGridView1.CurrentRow.Cells(0).Value
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim cmd0 As New SqlClient.SqlCommand("Select * From Polrec Where EmpId ='" & Pkvar & "'", Con)
        Dim d1 As SqlClient.SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            Emptxt.Text = d1(0).ToString
            Nametxt.Text = d1(1).ToString
            Mobtxt.Text = d1(6).ToString
            Etxt.Text = d1(3).ToString
        End If

        If Con.State = ConnectionState.Open Then Con.Close()
        disrecord()
    End Sub
    Sub disrecord()
        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Dim ds1 As New DataSet
        Dim adp = New SqlClient.SqlDataAdapter("Select EmpId,Name,Mobile,Email From PolRec", Con)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If Con.State = ConnectionState.Open Then Con.Close()
    End Sub

    Private Sub Approve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disrecord()

    End Sub

    Private Sub Btnshow_Click(sender As Object, e As EventArgs) Handles Btnshow.Click
        disrecord()
    End Sub

    Private Sub Btnapp_Click(sender As Object, e As EventArgs) Handles Btnapp.Click
        Try
            If Nametxt.Text <> "" And Emptxt.Text <> "" And Mobtxt.Text <> "" And Etxt.Text <> "" Then
                MsgBox("Employee Approved", MsgBoxStyle.Information, "Approval")
            Else
                MsgBox("Please Retrive the Registered Employee Details", MsgBoxStyle.Information, "Data Warning")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class