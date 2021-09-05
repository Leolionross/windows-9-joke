Imports System.Windows.Forms

Public Class Dialog3

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        MsgBox("Sorry, there was an error displaying the tip, sorry about that.", 16, "Error")
        My.Computer.Audio.Play(My.Resources.noise, AudioPlayMode.Background)
        Button1.Visible = True
        OK_Button.Enabled = False
        Label2.Text = "ITS NOT TOO LATE"
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
