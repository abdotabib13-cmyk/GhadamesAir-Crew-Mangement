Imports System.Data.OleDb

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sql As String =
        "SELECT Role, CrewID FROM Users WHERE Username=? AND [Password]=?"

        Dim p As New List(Of OleDbParameter) From {
        New OleDbParameter("@p1", txtUser.Text.Trim()),
        New OleDbParameter("@p2", txtPass.Text.Trim())
    }

        Dim dt = DbHelper.ExecuteQuery(sql, p)

        If dt.Rows.Count = 1 Then

            Dim role As String = dt.Rows(0)("Role").ToString()

            If role.Trim().ToLower() = "admin" Then

                AdminForm.Show()
            Else
                CrewForm.Show()
            End If

            Me.Hide()

        Else
            MessageBox.Show("اسم المستخدم أو كلمة المرور خطأ ❌")
        End If

    End Sub


End Class