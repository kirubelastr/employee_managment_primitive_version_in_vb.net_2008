Imports System.Data.SqlClient
Public Class employee
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kiru\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub populate()
        con.Open()
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmployeeDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        Dim query As String
        query = "insert into EmployeeTbl values('" & EmpNameTb.Text & "','" & EmpAdd.Text & "','" & PosCb.SelectedItem.ToString() & "','" & EmpDOB.Value & "','" & EmpPhoneTb.Text & "' , '" & EmpEdCb.SelectedItem.ToString() & "','" & GendCb.SelectedItem.ToString() & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Employee Added")
        con.Close()
        populate()
    End Sub
    Dim key = 0
    Private Sub clear()
        EmpNameTb.Clear()
        EmpAdd.Text = ""
        PosCb.Text = ""
        GendCb.Text = ""
        key = 0
        EmpPhoneTb.Text = ""
        EmpEdCb.Text = ""

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("select employee to delete")
        End If
        Try
            con.Open()
            Dim query As String
            query = ("delete from EmployeeTbl where EmpId = " & key & "")
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Deleted Successfully")
            con.Close()
            populate()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub EmployeeDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        EmpNameTb.Text = row.Cells(1).Value.ToString()
        EmpAdd.Text = row.Cells(2).Value.ToString()
        PosCb.Text = row.Cells(3).Value.ToString()
        EmpDOB.Text = row.Cells(4).Value.ToString()
        EmpPhoneTb.Text = row.Cells(5).Value.ToString()
        EmpEdCb.SelectedItem = row.Cells(6).Value.ToString()
        GendCb.SelectedItem = row.Cells(7).Value.ToString()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If EmpNameTb.Text = "" Or EmpPhoneTb.Text = "" Or EmpAdd.Text = "" Then
            MsgBox("missing information")
        Else
            con.Open()
            Dim query As String
            query = "update EmployeeTbl set EmpName='" & EmpNameTb.Text & "',EmpAdd='" & EmpAdd.Text & "',EmpPos='" & PosCb.SelectedItem.ToString() & "',EmpDob='" & EmpDOB.Value & "',EmpPhone='" & EmpPhoneTb.Text & "',EmpEdu='" & EmpEdCb.SelectedItem.ToString() & "',EmpGend='" & GendCb.SelectedItem.ToString() & "' where EmpId=" & key & " "
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("employee updated")
            con.Close()
            populate()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim main = New mainform
        main.Show()
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

    Private Sub EmployeeDGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDGV.CellContentClick

    End Sub
End Class