Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Visible = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value = 100 Then
            Threading.Thread.Sleep(1000)
            Cursor = Cursors.Default

            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
End Class