Public Class LoginForm1

    Dim obj As SharedFunctions = New SharedFunctions

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim sql As String
        sql = "select * from users where user_name = N'" & UsernameTextBox.Text & "'and password = N'" & PasswordTextBox.Text & "'"

        If obj.isLogedIn(sql) Then
            sql = "select * from users where user_name = N'" & UsernameTextBox.Text & "'and level = N'admin'"
            If obj.isLogedIn(sql) Then
                user_role = "admin"
            Else
                user_role = "user"
            End If
            main_form.Show()
            Me.Hide()
        Else
            MsgBox("الرمز او اسم المستخدم غير صحيح")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
