Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection = New SqlConnection("Data Source=AYAAN\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub LoginPage(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        If lgn_usr.Text = "" Then
            MsgBox("Enter User Name", MsgBoxStyle.Critical)
        ElseIf lgn_pwd.Text = "" Then
            MsgBox("Enter Password", MsgBoxStyle.Critical)
        Else
            Dim query As String
            query = "select * from lgntable where UserName collate latin1_general_cs_as='" + lgn_usr.Text + "'and Password collate latin1_general_cs_as='" + lgn_pwd.Text + "'and Type='" + Guna2ComboBox1.SelectedItem + "'"
            cmd = New SqlCommand(query, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Login Failed. Enter valid information!", MsgBoxStyle.Critical)
            ElseIf Guna2ComboBox1.SelectedItem = "Admin" Then
                adminhome.Show()
                Me.Hide()
            ElseIf Guna2ComboBox1.SelectedItem = "Student" Then
                studenthome.Show()
                Me.Hide()

            End If
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        forgotpwd.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub lgn_usr_TextChanged(sender As Object, e As EventArgs) Handles lgn_usr.TextChanged

    End Sub
End Class
