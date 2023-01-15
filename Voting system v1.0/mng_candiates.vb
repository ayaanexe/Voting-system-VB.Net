Imports System.Data.SqlClient
Public Class mng_candiates

    Private Sub mng_candiates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub candiatepic_Click(sender As Object, e As EventArgs) Handles candiatepic.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            candiatepic.Image = Image.FromFile(pop.FileName)
        End If
    End Sub


    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim a As Integer
        Dim con As New SqlConnection("Data Source=AYAAN\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
        Dim cmd As New SqlCommand("INSERT INTO [dbo].[candiTable]
         ([Name]
         ,[Course]
         ,[Year]
         ,[Position]
         ,[image])
       VALUES
           ('" + namecand.Text + "','" + course.Text + "','" + year.Text + "','" + position.Text + "," + candiatepic.Text + "')", con)
        con.Open()
        a = cmd.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("New Candiate registered successfully!", vbInformation)
        Else
            MsgBox("Registration failed!", vbExclamation)
        End If
        namecand.Clear()
        course.SelectedIndex = -1
        year.SelectedIndex = -1
        position.SelectedIndex = -1
        candiatepic.Visible = -1
        con.Close()
    End Sub
End Class