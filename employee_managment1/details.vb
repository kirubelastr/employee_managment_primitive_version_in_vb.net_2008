Imports System.Data.SqlClient
Public Class details
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kiru\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub FetchEmployeeData()
        If EmpIdTb.Text = "" Then
            MsgBox("enter the employee id")
        Else
            con.Open()
            Dim query = "select * from EmployeeTbl where EmpId=" & EmpIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                EmpNameLbl.Text = dr(1).ToString()
                EmpAddLbl.Text = dr(2).ToString()
                EmpPosLbl.Text = dr(3).ToString()
                EmpDobLbl.Text = dr(4).ToString()
                EmpPhoneLbl.Text = dr(5).ToString()
                EmpEduLbl.Text = dr(6).ToString()
                EmpGenderLbl.Text = dr(7).ToString()
                EmpNameLbl.Visible = True
                EmpPhoneLbl.Visible = True
                EmpAddLbl.Visible = True
                EmpDobLbl.Visible = True
                EmpEduLbl.Visible = True
                EmpGenderLbl.Visible = True
                EmpPosLbl.Visible = True
            Next
            con.Close()
        End If
    End Sub
    Private Sub details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FetchEmployeeData()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim main = New mainform
        main.Show()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim s1 As String
        s1 = "NAME:      " + EmpNameLbl.Text + vbCrLf + "ADDRES:    " + EmpAddLbl.Text+ vbCrLf +"POSITION:  " + EmpPosLbl.Text+ vbCrLf +"EDUCATION: " + EmpEduLbl.Text+ vbCrLf +"PHONE:     " + EmpPhoneLbl.Text+ vbCrLf +"DOB:       " + EmpDobLbl.Text+ vbCrLf +"GENDER:   " + EmpGenderLbl.Text
        e.Graphics.DrawString("Employee Managment System", New Font("Century Gothic ", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("***employee summary***", New Font("Arial ", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(s1 + EmpNameLbl.Text, New Font("Century Gothic ", 20), Brushes.Black, 150, 190)
        e.Graphics.DrawString("!!!!!!!!! employee managment system version 1.0 !!!!!!!!!!", New Font("Century Gothic ", 15), Brushes.DarkGreen, 150, 500)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub
End Class