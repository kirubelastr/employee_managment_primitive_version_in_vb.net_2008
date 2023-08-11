Imports System.Data.SqlClient
Module Module1
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kiru\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim EmployeeDGV As New DataGridView
    Public Sub populate()
        con.Open()
        Dim sql = "select * from SalTbl"
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
End Module
