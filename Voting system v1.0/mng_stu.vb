Imports System.Data.SqlClient
Public Class Mng_stu
    Dim result As Boolean
    Dim conn As New SqlConnection("Data Source=AYAAN\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
    Dim i As Integer
    Private Sub Mng_std_Load(Sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mng_stu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Sub Load_std_dat()
        Guna2DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd = New SqlCommand("select * from stdtbl", conn)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Guna2DataGridView1.Rows.Add(Guna2DataGridView1.Rows.Count + 1, dr.Item("studentid"), dr.Item("name"), dr.Item("course"), dr.Item("year"), dr.Item("status"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Srch_bar_TextChanged(sender As Object, e As EventArgs) Handles srch_bar.TextChanged

    End Sub
    Private Sub Reg_stu_Click(sender As Object, e As EventArgs) Handles reg_stu.Click
        Try
            conn.Open()
            Dim cmd As New SqlCommand("Insert into 'stdtbl'('studentid','name','course','year','status') values (@studentid,@name,@course,@year,@status)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@studentid", std_id.Text)
            cmd.Parameters.AddWithValue("@name", std_n.Text)
            cmd.Parameters.AddWithValue("@course", crs.Text)
            cmd.Parameters.AddWithValue("@year", year.Text)
            cmd.Parameters.AddWithValue("@status", "UN-VOTED")
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Student registered  successfully", vbInformation, "VOTE")
            Else
                MsgBox("Student registration failed", vbCritical, "VOTE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        filterdata("")
    End Sub
    Public Sub Filterdata(valuetosearch As String)
        Dim searchquery As String = "Select * from stdtbl where concat(studentid, name, course, year, status) like '%" & valuetosearch & "%'"
        Dim command As New SqlCommand(searchquery, conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Guna2DataGridView1.DataSource = table
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles src_std.Click
        filterdata(srch_bar.Text)
    End Sub
End Class