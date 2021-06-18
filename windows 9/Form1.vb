Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value = 100 Then
            Threading.Thread.Sleep(1000)
            Form2.Visible = True
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.AppStarting
        MsgBox("This program is not malware, but it is a joke", 0 + 64, "ATTENTION")
        MsgBox("So if someone sent this to you telling you this is an actual windows 9 upgrade, they are lying", 0 + 64, "ATTENTION")
        MsgBox("But if you still want to go for the experience, then go right ahead! :)", 0 + 64, "ATTENTION")
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Close()
    End Sub
End Class
