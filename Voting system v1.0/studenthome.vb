Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Public Class studenthome
    Private WithEvents Pan As New Panel
    Private WithEvents Candi_pic As New Guna2CirclePictureBox
    Private WithEvents namelbl As New Label
    Dim con As New SqlConnection("Data Source=DESKTOP-1E8RE3O\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
    Dim dr As SqlDataReader
    Private Sub Studenthome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Load_controls()
        Dim dr As SqlDataReader
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))
        Pan = New Panel
        Pan.Width = 100
        Pan.Height = 128
        Pan.BackColor = Color.White

        Candi_pic = New Guna2CirclePictureBox
        Candi_pic.Width = 80
        Candi_pic.BackgroundImageLayout = ImageLayout.Stretch
        Candi_pic.Dock = DockStyle.Bottom
        namelbl = New Label
        namelbl.ForeColor = Color.White
        namelbl.BackColor = Color.White
        namelbl.TextAlign = ContentAlignment.MiddleCenter
        namelbl.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        namelbl.Dock = DockStyle.Top
        namelbl.Text = dr.Item("name").ToString
        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        Candi_pic.BackgroundImage = bitmap
    End Sub
    Sub Load_CRlist()
        FlowLayoutPanel1.Controls.Clear()
        Try
            con.Open()
            Dim cmd As New SqlCommand("select 'name',course','year','position','image' from 'candiTable' where 'position='='' ", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
                Pan.Controls.Add(Candi_pic)
                Pan.Controls.Add(namelbl)
                FlowLayoutPanel1.Controls.Add(Pan)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FlowLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel4.Paint

    End Sub
End Class