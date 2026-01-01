Imports System.Data.OleDb

Public Class CrewForm
    Private Sub CrewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMyFlights()

        If Session.CrewID = 0 Then
            MessageBox.Show("هذا الحساب غير مربوط بموظف (CrewID)")
            Return
        End If

        Dim sql As String = "SELECT FullName, Email, Rank FROM Crew WHERE CrewID=?"
        Dim p As New List(Of OleDbParameter) From {
        New OleDbParameter("@p1", Session.CrewID)
    }

        Dim dt = DbHelper.ExecuteQuery(sql, p)

        If dt.Rows.Count = 1 Then
            lblName.Text = dt.Rows(0)("FullName").ToString()
            lblEmail.Text = dt.Rows(0)("Email").ToString()
            lblRank.Text = dt.Rows(0)("Rank").ToString()
        Else
            MessageBox.Show("لم يتم العثور على بيانات الموظف في جدول Crew")
        End If


    End Sub
    Private Sub LoadMyFlights()

        Dim sql As String =
            "SELECT F.FlightNo, F.FromAirport, F.ToAirport, F.FlightDate, F.DepTime, F.ArrTime, F.AircraftReg, FC.Duty " &
            "FROM (Flights AS F INNER JOIN FlightCrew AS FC ON F.FlightID = FC.FlightID) " &
            "WHERE FC.CrewID=? " &
            "ORDER BY F.FlightDate DESC, F.DepTime DESC"

        Dim p As New List(Of OleDb.OleDbParameter) From {
            New OleDb.OleDbParameter("@p1", Session.CrewID)
        }

        Dim dt = DbHelper.ExecuteQuery(sql, p)
        dgvMyFlights.DataSource = dt
        MessageBox.Show("عدد الرحلات: " & dt.Rows.Count)


    End Sub

    Private Sub btnCalcHours_Click(sender As Object, e As EventArgs) Handles btnCalcHours.Click

        Dim sql As String =
        "SELECT F.DepTime, F.ArrTime " &
        "FROM (Flights AS F INNER JOIN FlightCrew AS FC ON F.FlightID = FC.FlightID) " &
        "WHERE FC.CrewID=?"

        Dim p As New List(Of OleDb.OleDbParameter) From {
        New OleDb.OleDbParameter("@p1", Session.CrewID)
    }

        Dim dt = DbHelper.ExecuteQuery(sql, p)

        Dim totalMinutes As Double = 0

        For Each r As DataRow In dt.Rows
            If IsDBNull(r("DepTime")) OrElse IsDBNull(r("ArrTime")) Then Continue For

            Dim dep As DateTime = CDate(r("DepTime"))
            Dim arr As DateTime = CDate(r("ArrTime"))

            Dim mins As Double = (arr - dep).TotalMinutes
            If mins < 0 Then mins += 24 * 60 ' لو الرحلة تعدي منتصف الليل

            totalMinutes += mins
        Next

        Dim totalHours As Double = totalMinutes / 60.0
        lblTotalHours.Text = totalHours.ToString("0.00") & " ساعة"

    End Sub

End Class