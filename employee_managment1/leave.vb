Imports System.Data.SqlClient
Public Class leave
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kiru\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub ch()
    End Sub
    Private Sub check()
        con.Open()
        Dim query = "select * from EmployeeTbl where EmpId=" & LEId.Text & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Dim dt As DataTable
        dt = New DataTable
        Dim sda As SqlDataAdapter
        sda = New SqlDataAdapter(cmd)
        sda.Fill(dt)
        For Each dr As DataRow In dt.Rows
            Leave_Status.Text = dr(5).ToString()
        Next
        con.Close()
    End Sub
    Private Sub status()
        If Leave_Status_id.Text = "" Then
            MsgBox("enter the employee id")
        Else
            con.Open()
            Dim query = "select * from LeaveTbl where EmpId=" & Leave_Status_id.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                Leave_Status.Text = dr(5).ToString()
            Next
            con.Close()
        End If
    End Sub
    Private Sub s()
        If LEId.Text = "" Then
            MsgBox("enter the employee id")
        Else
            Try
                Dim query As String
                If Lsd.Value < Led.Value Then
                    con.Open()
                    query = "insert into LeaveTbl values('" & LEId.Text & "','" & Lsd.Value & "','" & Led.Value & "','" & Lr.SelectedItem.ToString() & "','Pending' )"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("leave request sent")
                    con.Close()
                Else
                    MsgBox(" please enter a valid start and end date for leave")
                End If

            Catch ex As Exception
                con.Close()
                MsgBox("exception message" & ex.ToString)
            End Try
        End If
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub SalaryTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub EmpIdTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEId.TextChanged

        ch()
    End Sub

    Private Sub TableLayoutPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        s()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        status()
    End Sub

    Private Sub leave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class