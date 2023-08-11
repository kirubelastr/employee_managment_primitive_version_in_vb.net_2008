Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("enter the username and password")
        ElseIf txtusername.Text = "admin" And txtpassword.Text = "pass" Then
            Dim main = New mainform
            main.Show()
            Me.Hide()
        ElseIf txtusername.Text = "user" And txtpassword.Text = "pass" Then
            Dim l = New leave
            l.Show()
            Me.Hide()
        Else
            MsgBox("wrong username and password")
        End If
    End Sub
End Class
