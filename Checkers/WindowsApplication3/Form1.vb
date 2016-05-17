Public Class frmCheckerBoard

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        grpRules.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        grpRules.Visible = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged
        lblRed.Text = txtRed.Text
    End Sub

    Private Sub txtBlack_TextChanged(sender As Object, e As EventArgs) Handles txtBlack.TextChanged
        lblBlack.Text = txtBlack.Text
    End Sub


    Private Sub picRchecker4_Click(sender As Object, e As EventArgs) Handles picRchecker4.GotFocus

    End Sub

    Private Sub picRchecker4_Click_1(sender As Object, e As EventArgs) Handles picRchecker4.Click
        picRchecker4.Tag = "red"

    End Sub
End Class

Class Pieces
    Structure Mikeys
        Dim reds() As Integer
        Dim blacks() As Integer 'im not racist, I swear!
        Dim blacksquare() As Integer
        Dim whitesquare() As Integer
    End Structure

End Class
