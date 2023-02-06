Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            bb.Image = My.Resources.banana
        End If

        If ListBox1.SelectedItem = "cookies and creme" Then
            bb.Image = My.Resources.cookies_n_cream
        End If

        If ListBox1.SelectedItem = "vanilla" Then
            bb.Image = My.Resources.vanilla
        End If

        If ListBox1.SelectedItem = "pistachio" Then
            bb.Image = My.Resources.pistachio
        End If

        If ListBox1.SelectedItem = "rocky road" Then
            bb.Image = My.Resources.rocky_road
        End If
    End Sub
End Class
