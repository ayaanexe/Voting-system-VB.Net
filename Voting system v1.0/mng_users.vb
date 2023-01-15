Imports System.Data.SqlClient
Public Class mng_users
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim i As Integer
        Dim con As New SqlConnection("Data Source=DESKTOP-1E8RE3O\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
        Dim cmd As New SqlCommand("INSERT INTO [dbo].[lgnTable]
           ([UserName]
           ,[Password]
           ,[Type]
           ,[name])
     VALUES
           ('" + usrname.Text + "','" + pword.Text + "','" + utyp.Text + "','" + name2.Text + "')", con)
        con.Open()
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("New user registered successfully!", vbInformation)
        Else
            MsgBox("Registration failed!", vbExclamation)
        End If
        name2.Clear()
        utyp.SelectedIndex = -1
        pword.Clear()
        usrname.Clear()
        con.Close()
    End Sub
End Class