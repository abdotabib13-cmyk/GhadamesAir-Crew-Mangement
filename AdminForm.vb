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
        Dim dt = DbHelper.ExecuteQuery("SELECT CrewID, FullName, Email, Rank FROM Crew WHERE IsActive=True")
        dgvCrew.DataSource = dt

        If dgvCrew.Rows.Count > 0 Then
            dgvCrew.ClearSelection()
            dgvCrew.Rows(0).Selected = True
        End If
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
        Try
            If dgvCrew.CurrentRow Is Nothing Then Return
            If dgvCrew.CurrentRow.IsNewRow Then Return

            selectedCrewID = CInt(dgvCrew.CurrentRow.Cells("CrewID").Value)
            txtName.Text = dgvCrew.CurrentRow.Cells("FullName").Value.ToString()
            txtEmail.Text = dgvCrew.CurrentRow.Cells("Email").Value.ToString()
            cbRank.Text = dgvCrew.CurrentRow.Cells("Rank").Value.ToString()
        Catch
            ' تجاهل لو الصف فاضي أو البيانات غير جاهزة
        End Try
    End Sub
    Private Sub dgvCrew_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCrew.SelectionChanged
        If dgvCrew.CurrentRow Is Nothing Then Return
        If dgvCrew.CurrentRow.IsNewRow Then Return

        selectedCrewID = CInt(dgvCrew.CurrentRow.Cells("CrewID").Value)

        txtName.Text = dgvCrew.CurrentRow.Cells("FullName").Value.ToString()
        txtEmail.Text = dgvCrew.CurrentRow.Cells("Email").Value.ToString()
        cbRank.Text = dgvCrew.CurrentRow.Cells("Rank").Value.ToString()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadCrew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCrew.CurrentRow Is Nothing Then
            MessageBox.Show("اختار موظف من الجدول أولاً")
            Return
        End If

        Dim crewId As Integer = CInt(dgvCrew.CurrentRow.Cells("CrewID").Value)

        Dim sql As String = "UPDATE Crew SET IsActive=False WHERE CrewID=?"
        Dim p As New List(Of OleDb.OleDbParameter) From {
        New OleDb.OleDbParameter("@p1", crewId)
    }

        DbHelper.ExecuteNonQuery(sql, p)

        MessageBox.Show("تم تعطيل الموظف ✅")
        LoadCrew() ' دالة تحديث الجدول عندك
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

        Dim sql As String = "INSERT INTO Crew (FullName, Email, Rank, IsActive) VALUES (?,?,?,?)"
        Dim p As New List(Of OleDbParameter) From {
        New OleDbParameter("@p1", txtName.Text.Trim()),
        New OleDbParameter("@p2", txtEmail.Text.Trim()),
        New OleDbParameter("@p3", cbRank.Text.Trim()),
        New OleDbParameter("@p4", True)
}


        DbHelper.ExecuteNonQuery(sql, p)
        MessageBox.Show("تم إنشاء الحساب ✅")
    End Sub
End Class