Imports System.Data.OleDb

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FlightForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFlightNo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtAircraftReg = New System.Windows.Forms.TextBox()
        Me.dtpDepTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpArrTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpFlightDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvCrew = New System.Windows.Forms.DataGridView()
        Me.btnSaveFlight = New System.Windows.Forms.Button()
        Me.btnAssignCrew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvCrew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFlightNo
        '
        Me.txtFlightNo.Location = New System.Drawing.Point(352, 12)
        Me.txtFlightNo.Name = "txtFlightNo"
        Me.txtFlightNo.Size = New System.Drawing.Size(100, 20)
        Me.txtFlightNo.TabIndex = 0
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(352, 51)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtFrom.TabIndex = 1
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(352, 120)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(100, 20)
        Me.txtTo.TabIndex = 2
        '
        'txtAircraftReg
        '
        Me.txtAircraftReg.Location = New System.Drawing.Point(352, 185)
        Me.txtAircraftReg.Name = "txtAircraftReg"
        Me.txtAircraftReg.Size = New System.Drawing.Size(100, 20)
        Me.txtAircraftReg.TabIndex = 3
        '
        'dtpDepTime
        '
        Me.dtpDepTime.Location = New System.Drawing.Point(320, 87)
        Me.dtpDepTime.Name = "dtpDepTime"
        Me.dtpDepTime.Size = New System.Drawing.Size(200, 20)
        Me.dtpDepTime.TabIndex = 4
        '
        'dtpArrTime
        '
        Me.dtpArrTime.Location = New System.Drawing.Point(320, 148)
        Me.dtpArrTime.Name = "dtpArrTime"
        Me.dtpArrTime.Size = New System.Drawing.Size(200, 20)
        Me.dtpArrTime.TabIndex = 5
        '
        'dtpFlightDate
        '
        Me.dtpFlightDate.Location = New System.Drawing.Point(93, 15)
        Me.dtpFlightDate.Name = "dtpFlightDate"
        Me.dtpFlightDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpFlightDate.TabIndex = 6
        '
        'dgvCrew
        '
        Me.dgvCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCrew.Location = New System.Drawing.Point(227, 243)
        Me.dgvCrew.Name = "dgvCrew"
        Me.dgvCrew.Size = New System.Drawing.Size(351, 150)
        Me.dgvCrew.TabIndex = 7
        '
        'btnSaveFlight
        '
        Me.btnSaveFlight.Location = New System.Drawing.Point(445, 399)
        Me.btnSaveFlight.Name = "btnSaveFlight"
        Me.btnSaveFlight.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveFlight.TabIndex = 8
        Me.btnSaveFlight.Text = "حفظ الرحلة"
        Me.btnSaveFlight.UseVisualStyleBackColor = True
        '
        'btnAssignCrew
        '
        Me.btnAssignCrew.Location = New System.Drawing.Point(300, 399)
        Me.btnAssignCrew.Name = "btnAssignCrew"
        Me.btnAssignCrew.Size = New System.Drawing.Size(75, 23)
        Me.btnAssignCrew.TabIndex = 9
        Me.btnAssignCrew.Text = "إسناد الطاقم"
        Me.btnAssignCrew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "رحلة رقم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(481, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "من"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "إلى"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(481, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "الطائرة"
        '
        'FlightForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAssignCrew)
        Me.Controls.Add(Me.btnSaveFlight)
        Me.Controls.Add(Me.dgvCrew)
        Me.Controls.Add(Me.dtpFlightDate)
        Me.Controls.Add(Me.dtpArrTime)
        Me.Controls.Add(Me.dtpDepTime)
        Me.Controls.Add(Me.txtAircraftReg)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.txtFlightNo)
        Me.Name = "FlightForm"
        Me.Text = "FlightForm"
        CType(Me.dgvCrew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFlightNo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtAircraftReg As TextBox
    Friend WithEvents dtpDepTime As DateTimePicker
    Friend WithEvents dtpArrTime As DateTimePicker
    Friend WithEvents dtpFlightDate As DateTimePicker
    Friend WithEvents dgvCrew As DataGridView
    Friend WithEvents btnSaveFlight As Button
    Friend WithEvents btnAssignCrew As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label


    Private currentFlightID As Integer = 0

    Private Sub FlightForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        LoadCrewToGrid()
    End Sub



    Private Sub LoadCrewToGrid()

        Dim dt As DataTable = DbHelper.ExecuteQuery("SELECT CrewID, FullName, Email, Rank FROM Crew")
        dgvCrew.AutoGenerateColumns = True
        dgvCrew.Columns.Clear()
        dgvCrew.DataSource = dt


        Dim chk As New DataGridViewCheckBoxColumn()
        chk.Name = "SelectCrew"
        chk.HeaderText = "اختيار"
        dgvCrew.Columns.Insert(0, chk)

        dgvCrew.AllowUserToAddRows = False
        dgvCrew.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub




    Private Sub btnSaveFlight_Click(sender As Object, e As EventArgs) Handles btnSaveFlight.Click
        Dim sql As String =
              "INSERT INTO Flights (FlightNo, FromAirport, ToAirport, FlightDate, DepTime, ArrTime, AircraftReg) " &
              "VALUES (?,?,?,?,?,?,?)"

        Dim dep As DateTime = DateTime.Today.Add(dtpDepTime.Value.TimeOfDay)
        Dim arr As DateTime = DateTime.Today.Add(dtpArrTime.Value.TimeOfDay)

        Dim p As New List(Of OleDbParameter)

        Dim p1 As New OleDbParameter("@p1", OleDbType.VarWChar) : p1.Value = txtFlightNo.Text.Trim()
        Dim p2 As New OleDbParameter("@p2", OleDbType.VarWChar) : p2.Value = txtFrom.Text.Trim()
        Dim p3 As New OleDbParameter("@p3", OleDbType.VarWChar) : p3.Value = txtTo.Text.Trim()

        Dim p4 As New OleDbParameter("@p4", OleDbType.Date) : p4.Value = dtpFlightDate.Value.Date
        Dim p5 As New OleDbParameter("@p5", OleDbType.Date) : p5.Value = dep
        Dim p6 As New OleDbParameter("@p6", OleDbType.Date) : p6.Value = arr

        Dim p7 As New OleDbParameter("@p7", OleDbType.VarWChar) : p7.Value = txtAircraftReg.Text.Trim()

        p.AddRange({p1, p2, p3, p4, p5, p6, p7})

        DbHelper.ExecuteNonQuery(sql, p)

        currentFlightID = CInt(DbHelper.ExecuteScalar("SELECT TOP 1 FlightID FROM Flights ORDER BY FlightID DESC"))
        MessageBox.Show("Saved FlightID = " & currentFlightID)
    End Sub

    Private Sub btnAssignCrew_Click(sender As Object, e As EventArgs) Handles btnAssignCrew.Click

        If currentFlightID = 0 Then
            MessageBox.Show("احفظ الرحلة أولاً")
            Return
        End If

        Dim added As Integer = 0

        For Each row As DataGridViewRow In dgvCrew.Rows
            If row.IsNewRow Then Continue For

            Dim selected As Boolean = False
            If row.Cells("SelectCrew").Value IsNot Nothing Then
                selected = CBool(row.Cells("SelectCrew").Value)
            End If

            If selected Then
                Dim crewId As Integer = CInt(row.Cells("CrewID").Value)

                Dim sql As String = "INSERT INTO FlightCrew (FlightID, CrewID, Duty) VALUES (?,?,?)"
                Dim p As New List(Of OleDb.OleDbParameter) From {
                New OleDb.OleDbParameter("@p1", currentFlightID),
                New OleDb.OleDbParameter("@p2", crewId),
                New OleDb.OleDbParameter("@p3", "Cabin")
            }

                DbHelper.ExecuteNonQuery(sql, p)
                added += 1
            End If
        Next

        MessageBox.Show("تم إسناد الطاقم ✅ العدد: " & added)

    End Sub


    Private Sub dgvCrew_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrew.CellContentClick

    End Sub

    Private Sub FlightForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
