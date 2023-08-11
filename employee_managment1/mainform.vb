Public Class mainform

    Private Sub mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim det = New details
        det.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Dim Emp = New employee
        Emp.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim Emp = New employee
        Emp.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim det = New details
        det.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim sal = New salary
        sal.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Dim sal = New salary
        sal.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim lea = New leave_approval
        lea.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lea = New leave_approval
        lea.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim log = New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub LeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveToolStripMenuItem.Click
        Dim lea = New leave_approval
        lea.Show()
        Me.Hide()
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryToolStripMenuItem.Click
        Me.Hide()
        Dim sal = New salary
        sal.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        Me.Hide()
        Dim det = New details
        det.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Hide()
        Dim Emp = New employee
        Emp.Show()
    End Sub
End Class