Imports System.Data.SqlClient
Public Class salary
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kiru\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub s()
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
                EmpNameLb.Text = dr(1).ToString()
                EmpPosLb.Text = dr(3).ToString()
                EmpNameLb.Visible = True
                EmpPosLb.Visible = True
            Next
            con.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim main = New mainform
        main.Show()
    End Sub

    Private Sub salary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        s()
    End Sub
    Dim dailyPay
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If EmpPosLb.Text = "" Then
            MsgBox("select an employee")
        ElseIf Workedtb.Text = "" Or Convert.ToInt32(Workedtb.Text) > 30 Then
            MsgBox("enter a valid number of days")
        Else
            If EmpPosLb.Text = "Manager" Then
                dailyPay = 1200
            ElseIf EmpPosLb.Text = "Accountant" Then
                dailyPay = 1200
            ElseIf EmpPosLb.Text = "Security" Then
                dailyPay = 600
            ElseIf EmpPosLb.Text = "IT" Then
                dailyPay = 850
            Else
                dailyPay = 500
            End If
            Dim total = dailyPay * Convert.ToInt32(Workedtb.Text)
            SalaryTb.Text = "Employee Id:    " + EmpIdTb.Text + vbCrLf + "Employee Name:    " + EmpNameLb.Text + vbCrLf + "Employee position:     " + EmpPosLb.Text + vbCrLf + "days worked     " + Workedtb.Text + vbCrLf + "daily salary birr:   " + Convert.ToString(dailyPay) + vbCrLf + "Total Amount Birr:    " + Convert.ToString(total)

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Managment System", New Font("Century Gothic ", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("***PAYSLIP***", New Font("Arial ", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(SalaryTb.Text, New Font("Century Gothic ", 20), Brushes.Black, 150, 190)
        e.Graphics.DrawString("!!!!!!!!! Thanks for your service !!!!!!!!!!", New Font("Century Gothic ", 15), Brushes.DarkGreen, 150, 500)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub EmpIdTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpIdTb.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class