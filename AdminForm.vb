Imports System.Data.OleDb

Public Class AdminForm
    Private selectedCrewID As Integer = 0

    Private Sub cbRank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRank.SelectedIndexChanged

    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRank.Items.Clear()
        cbRank.Items.Add("Cabin Crew")
        cbRank.Items.Add("Senior Cabin Crew")
        cbRank.Items.Add("Supervisor")

    End Sub

    Private Sub LoadCrew()
        Dim dt = DbHelper.ExecuteQuery("SELECT CrewID, FullName, Email, Rank FROM Crew")
        dgvCrew.DataSource = dt
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtName.Text.Trim() = "" Then
            MessageBox.Show("اكتب الاسم")
            Return
        End If

        Dim sql As String = "INSERT INTO Crew (FullName, Email, Rank) VALUES (?,?,?)"
        Dim p As New List(Of OleDbParameter) From {
        New OleDbParameter("@p1", txtName.Text.Trim()),
        New OleDbParameter("@p2", txtEmail.Text.Trim()),
        New OleDbParameter("@p3", cbRank.Text.Trim())
    }

        DbHelper.ExecuteNonQuery(sql, p)

        MessageBox.Show("تمت الإضافة ✅")
        LoadCrew() 'يحدّث الجدول
    End Sub

    Private Sub dgvCrew_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrew.CellContentClick
        If e.RowIndex < 0 Then Return

        selectedCrewID = CInt(dgvCrew.Rows(e.RowIndex).Cells("CrewID").Value)
        txtName.Text = dgvCrew.Rows(e.RowIndex).Cells("FullName").Value.ToString()
        txtEmail.Text = dgvCrew.Rows(e.RowIndex).Cells("Email").Value.ToString()
        cbRank.Text = dgvCrew.Rows(e.RowIndex).Cells("Rank").Value.ToString()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadCrew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedCrewID = 0 Then
            MessageBox.Show("اختار موظف من الجدول أولاً")
            Return
        End If

        If MessageBox.Show("متأكد تبي تحذف؟", "تأكيد", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim sql As String = "DELETE FROM Crew WHERE CrewID=?"
        Dim p As New List(Of OleDbParameter) From {
            New OleDbParameter("@p1", selectedCrewID)
        }

        DbHelper.ExecuteNonQuery(sql, p)
        MessageBox.Show("تم الحذف ✅")

        selectedCrewID = 0
        txtName.Clear()
        txtEmail.Clear()
        cbRank.SelectedIndex = -1

        LoadCrew()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedCrewID = 0 Then
            MessageBox.Show("اختار موظف من الجدول أولاً")
            Return
        End If

        Dim sql As String = "UPDATE Crew SET FullName=?, Email=?, Rank=? WHERE CrewID=?"
        Dim p As New List(Of OleDbParameter) From {
            New OleDbParameter("@p1", txtName.Text.Trim()),
            New OleDbParameter("@p2", txtEmail.Text.Trim()),
            New OleDbParameter("@p3", cbRank.Text.Trim()),
            New OleDbParameter("@p4", selectedCrewID)
        }

        DbHelper.ExecuteNonQuery(sql, p)
        MessageBox.Show("تم التعديل ✅")
        LoadCrew()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        If selectedCrewID = 0 Then
            MessageBox.Show("اختار موظف من الجدول أولاً")
            Return
        End If

        If txtUsername.Text.Trim() = "" Or txtUserPass.Text.Trim() = "" Then
            MessageBox.Show("اكتب Username و Password")
            Return
        End If

        Dim sql As String = "INSERT INTO Users (Username, [Password], Role, CrewID) VALUES (?,?,?,?)"
        Dim p As New List(Of OleDbParameter) From {
            New OleDbParameter("@p1", txtUsername.Text.Trim()),
            New OleDbParameter("@p2", txtUserPass.Text.Trim()),
            New OleDbParameter("@p3", "Crew"),
            New OleDbParameter("@p4", selectedCrewID)
        }

        DbHelper.ExecuteNonQuery(sql, p)
        MessageBox.Show("تم إنشاء الحساب ✅")
    End Sub
End Class