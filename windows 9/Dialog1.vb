Imports System.Windows.Forms
Public Class Dialog1

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value = 100 Then
            Me.ControlBox = True
            Me.Text = "DONT"
            Threading.Thread.Sleep(100)
            Me.Text = "Setup"
            Timer1.Enabled = False
        End If
    End Sub
End Class