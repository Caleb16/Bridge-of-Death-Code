Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strName, strQuest, strColor As String
        strName = Me.txtName.Text
        strQuest = Me.txtQuest.Text
        strColor = Me.txtColor.Text

        If strName = "Caleb" Then
            Me.lblName.Text = "You May Pass."
        Else
            Me.lblName.Text = "Incorrect, You Die."
        End If

        If strQuest = "I Seek the Holy Grail" Then
            Me.lblQuest.Text = "You May Pass."
        Else
            Me.lblQuest.Text = "Incorrect, You Die."
        End If

        If strColor = "Forest Green" Then
            Me.lblColor.Text = "You May Pass."
        Else
            Me.lblColor.Text = "Incorrect, You Die."
        End If
    End Sub
End Class
