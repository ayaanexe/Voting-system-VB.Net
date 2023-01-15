Imports System.Data.SqlClient
Public Class forgotpwd
    Dim conn As New SqlConnection("Data Source=AYAAN\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cmd As New SqlCommand("update lgnTable set Password = '" + Guna2TextBox2.Text + "' where UserName = '" + Guna2TextBox1.Text + "' ", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Password Updated")
        conn.Close()

    End Sub

    Private Sub forgotpwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class