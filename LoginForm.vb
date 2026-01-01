Imports System.Data.OleDb

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim u As String = txtUser.Text.Trim()
        Dim p As String = txtPass.Text.Trim()

        If u = "" OrElse p = "" Then
            MessageBox.Show("أدخل اسم المستخدم وكلمة المرور")
            Return
        End If

        ' ✅ نعبي dt هنا
        Dim sql As String = "SELECT UserID, Username, [Password], [Role], CrewID FROM Users WHERE Username=? AND [Password]=?"
        Dim prms As New List(Of OleDbParameter) From {
        New OleDbParameter("@p1", u),
        New OleDbParameter("@p2", p)
    }

        Dim dt As DataTable = DbHelper.ExecuteQuery(sql, prms)

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MessageBox.Show("بيانات الدخول غير صحيحة")
            Return
        End If

        Dim role As String = dt.Rows(0)("Role").ToString().Trim().ToLower()

        Dim crewIdValue As Integer = 0
        If Not IsDBNull(dt.Rows(0)("CrewID")) Then
            crewIdValue = CInt(dt.Rows(0)("CrewID"))
        End If

        ' تخزين Session
        Session.Role = role
        Session.CrewID = crewIdValue
        Session.Username = u

        ' الشرط هذا فقط للـ Crew
        If role = "crew" AndAlso crewIdValue = 0 Then
            MessageBox.Show("هذا الحساب غير مربوط بموظف (CrewID)")
            Return
        End If

        ' فتح الفورم حسب الدور
        Select Case role
            Case "admin"
                AdminForm.Show()
            Case "operator"
                OperatorForm.Show()
            Case "crew"
                CrewForm.Show()
            Case Else
                MessageBox.Show("Role غير معروف: " & role)
                Return
        End Select

        Me.Hide()

    End Sub
End Class