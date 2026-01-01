<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrewForm
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.dgvMyFlights = New System.Windows.Forms.DataGridView()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.btnCalcHours = New System.Windows.Forms.Button()
        CType(Me.dgvMyFlights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(385, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(385, 53)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 13)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Label2"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(385, 93)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(39, 13)
        Me.lblRank.TabIndex = 2
        Me.lblRank.Text = "Label3"
        '
        'dgvMyFlights
        '
        Me.dgvMyFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMyFlights.Location = New System.Drawing.Point(155, 222)
        Me.dgvMyFlights.Name = "dgvMyFlights"
        Me.dgvMyFlights.Size = New System.Drawing.Size(542, 150)
        Me.dgvMyFlights.TabIndex = 3
        '
        'lblTotalHours
        '
        Me.lblTotalHours.AutoSize = True
        Me.lblTotalHours.Location = New System.Drawing.Point(385, 134)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalHours.TabIndex = 4
        Me.lblTotalHours.Text = "0"
        '
        'btnCalcHours
        '
        Me.btnCalcHours.Location = New System.Drawing.Point(370, 177)
        Me.btnCalcHours.Name = "btnCalcHours"
        Me.btnCalcHours.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcHours.TabIndex = 5
        Me.btnCalcHours.Text = "حساب الساعات"
        Me.btnCalcHours.UseVisualStyleBackColor = True
        '
        'CrewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalcHours)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.dgvMyFlights)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Name = "CrewForm"
        Me.Text = "CrewForm"
        CType(Me.dgvMyFlights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents dgvMyFlights As DataGridView
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents btnCalcHours As Button
End Class
