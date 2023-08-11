Public NotInheritable Class myprogram
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        myprogress.Increment(4)

        If myprogress.Value = 100 Then
            Me.Hide()
            Dim log = New Form1
            log.Show()
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub myprogram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
