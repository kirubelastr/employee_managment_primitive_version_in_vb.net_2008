Imports System.Data.SqlClient
Public Class leave_approval
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kiru\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub populate()
        con.Open()
        Dim sql = "select * from LeaveTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        LeaveDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Dim key = 0
    Private Sub clear()
        LAEI.Text = ""
        LAS.Text = ""
        LAE.Text = ""
        LAR.Text = ""
        LASTATUS.Text = ""
        key = 0
    End Sub
    Private Sub leave_approval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub LeaveDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles LeaveDGV.CellMouseClick, LeaveDGV.CellMouseClick
        Dim row As DataGridViewRow = LeaveDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        LAEI.Text = row.Cells(1).Value.ToString()
        LAS.Text = row.Cells(2).Value.ToString()
        LAE.Text = row.Cells(3).Value.ToString()
        LAR.SelectedItem = row.Cells(4).Value.ToString()
        LASTATUS.SelectedItem = row.Cells(5).Value.ToString()
    End Sub

    Private Sub Lr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("select employee leave row to delete")
        End If
        Try
            con.Open()
            Dim query As String
            query = ("delete from LeaveTbl where ELID = " & key & "")
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee leave row Deleted Successfully")
            con.Close()
            populate()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LAEI.Text = "" Or LAE.Text = "" Or LASTATUS.Text = "" Or LAR.Text = "" Or LAS.Text = "" Then
            MsgBox("missing information")
        Else
            con.Open()
            Dim query As String
            query = "update LeaveTbl set EmpId='" & LAEI.Text & "',Leave_date_s='" & LAS.Text & "',Leave_date_e='" & LAE.Text & "',Leave_Reason='" & LAR.Text & "',Leave_Stutus='" & LASTATUS.SelectedItem.ToString() & "' where  ELID=" & key & " "
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("employee leave table  updated")
            con.Close()
            populate()
        End If
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim main = New mainform
        main.Show()
        Me.Hide()
    End Sub

    Private Sub LAS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAS.TextChanged

    End Sub

    Private Sub EmployeeDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub LeaveDGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LeaveDGV.CellContentClick
        Dim row As DataGridViewRow = LeaveDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        LAEI.Text = row.Cells(1).Value.ToString()
        LAS.Text = row.Cells(2).Value.ToString()
        LAE.Text = row.Cells(3).Value.ToString()
        LAR.SelectedItem = row.Cells(4).Value.ToString()
        LASTATUS.SelectedItem = row.Cells(5).Value.ToString()
    End Sub
End Class