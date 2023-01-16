Imports System.Data.SqlClient
Imports System.IO
Public Class mng_candiates

    Private Sub mng_candiates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub candiatepic_Click(sender As Object, e As EventArgs) Handles candiatepic.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            candiatepic.Image = Image.FromFile(pop.FileName)
        End If
    End Sub
    Sub clear()
        namecand.Clear()
        course.SelectedIndex = -1
        year.SelectedIndex = -1
        position.SelectedIndex = -1
        candiatepic.Image = Nothing

    End Sub


    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Try
            Dim con As New SqlConnection("Data Source=AYAAN\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
            con.Open()
            Dim i As Integer
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[candiTable]
         ([Name]
         ,[Course]
         ,[Year]
         ,[Position]
         ,[Picture])
       VALUES (value1, value2, value3, value4)
           ('" = namecand.Text + "','" + course.Text + "','" + year.Text + "','" + position.Text + "','" + candiatepic.Text + ")", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_insertcandiates"
            cmd.Parameters.AddWithValue("@Name", namecand.Text)
            cmd.Parameters.AddWithValue("@Course", course.Text)
            cmd.Parameters.AddWithValue("@Year", year.Text)
            cmd.Parameters.AddWithValue("@Position", position.Text)
            Dim filesize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            candiatepic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim Picture() As Byte = mstream.GetBuffer
            filesize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@image", candiatepic.Text)
            i = cmd.ExecuteNonQuery()
            If i < 0 Then
                MsgBox("New Candiate registered successfully!", vbInformation, "VOTE")
            Else
                MsgBox("Registration is failed!", vbExclamation, "VOTE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        clear()
    End Sub

End Class