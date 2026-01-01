<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cbRank = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgvCrew = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtUserPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        CType(Me.dgvCrew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(172, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(172, 68)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 2
        '
        'cbRank
        '
        Me.cbRank.FormattingEnabled = True
        Me.cbRank.Location = New System.Drawing.Point(151, 110)
        Me.cbRank.Name = "cbRank"
        Me.cbRank.Size = New System.Drawing.Size(121, 21)
        Me.cbRank.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(376, 232)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "إضافة"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(279, 232)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "عرض الطاقم"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dgvCrew
        '
        Me.dgvCrew.AllowUserToAddRows = False
        Me.dgvCrew.AllowUserToDeleteRows = False
        Me.dgvCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCrew.Location = New System.Drawing.Point(62, 261)
        Me.dgvCrew.MultiSelect = False
        Me.dgvCrew.Name = "dgvCrew"
        Me.dgvCrew.ReadOnly = True
        Me.dgvCrew.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCrew.Size = New System.Drawing.Size(363, 150)
        Me.dgvCrew.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "الاسم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "الايميل"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "الرتبة"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(195, 232)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(114, 232)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "تعطيل"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(172, 140)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 12
        '
        'txtUserPass
        '
        Me.txtUserPass.Location = New System.Drawing.Point(172, 188)
        Me.txtUserPass.Name = "txtUserPass"
        Me.txtUserPass.Size = New System.Drawing.Size(100, 20)
        Me.txtUserPass.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "الرتبة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "الرتبة"
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(33, 232)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateAccount.TabIndex = 16
        Me.btnCreateAccount.Text = "إنشاء حساب"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUserPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCrew)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cbRank)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        CType(Me.dgvCrew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cbRank As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents dgvCrew As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtUserPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCreateAccount As Button
End Class
