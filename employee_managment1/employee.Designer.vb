<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView
        Me.EmpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.EmpEdCb = New System.Windows.Forms.ComboBox
        Me.PosCb = New System.Windows.Forms.ComboBox
        Me.GendCb = New System.Windows.Forms.ComboBox
        Me.EmpAdd = New System.Windows.Forms.TextBox
        Me.EmpPhoneTb = New System.Windows.Forms.TextBox
        Me.EmpNameTb = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.EmployeeDGV)
        Me.Panel1.Controls.Add(Me.EmpDOB)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.EmpEdCb)
        Me.Panel1.Controls.Add(Me.PosCb)
        Me.Panel1.Controls.Add(Me.GendCb)
        Me.Panel1.Controls.Add(Me.EmpAdd)
        Me.Panel1.Controls.Add(Me.EmpPhoneTb)
        Me.Panel1.Controls.Add(Me.EmpNameTb)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 390)
        Me.Panel1.TabIndex = 0
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDGV.Location = New System.Drawing.Point(13, 119)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Turquoise
        Me.EmployeeDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.EmployeeDGV.Size = New System.Drawing.Size(810, 230)
        Me.EmployeeDGV.TabIndex = 20
        '
        'EmpDOB
        '
        Me.EmpDOB.Location = New System.Drawing.Point(727, 68)
        Me.EmpDOB.Name = "EmpDOB"
        Me.EmpDOB.Size = New System.Drawing.Size(200, 20)
        Me.EmpDOB.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(757, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "employee date of birth"
        '
        'EmpEdCb
        '
        Me.EmpEdCb.FormattingEnabled = True
        Me.EmpEdCb.Items.AddRange(New Object() {"Diploma", "UG", "PG"})
        Me.EmpEdCb.Location = New System.Drawing.Point(591, 67)
        Me.EmpEdCb.Name = "EmpEdCb"
        Me.EmpEdCb.Size = New System.Drawing.Size(121, 21)
        Me.EmpEdCb.TabIndex = 17
        '
        'PosCb
        '
        Me.PosCb.FormattingEnabled = True
        Me.PosCb.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        Me.PosCb.Location = New System.Drawing.Point(453, 67)
        Me.PosCb.Name = "PosCb"
        Me.PosCb.Size = New System.Drawing.Size(121, 21)
        Me.PosCb.TabIndex = 16
        '
        'GendCb
        '
        Me.GendCb.FormattingEnabled = True
        Me.GendCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GendCb.Location = New System.Drawing.Point(140, 66)
        Me.GendCb.Name = "GendCb"
        Me.GendCb.Size = New System.Drawing.Size(84, 21)
        Me.GendCb.TabIndex = 15
        '
        'EmpAdd
        '
        Me.EmpAdd.Location = New System.Drawing.Point(230, 66)
        Me.EmpAdd.Name = "EmpAdd"
        Me.EmpAdd.Size = New System.Drawing.Size(100, 20)
        Me.EmpAdd.TabIndex = 14
        '
        'EmpPhoneTb
        '
        Me.EmpPhoneTb.Location = New System.Drawing.Point(342, 66)
        Me.EmpPhoneTb.Name = "EmpPhoneTb"
        Me.EmpPhoneTb.Size = New System.Drawing.Size(100, 20)
        Me.EmpPhoneTb.TabIndex = 13
        '
        'EmpNameTb
        '
        Me.EmpNameTb.Location = New System.Drawing.Point(29, 67)
        Me.EmpNameTb.Name = "EmpNameTb"
        Me.EmpNameTb.Size = New System.Drawing.Size(100, 20)
        Me.EmpNameTb.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(588, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "employee education"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "employee phone"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(852, 304)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "employee position"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(852, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "DELET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "employee gender"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(852, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "employee address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(852, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "employee name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(48, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "MANAGE EMPLOYEES"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(820, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 34)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.employee_managment.My.Resources.Resources.Apps_Dialog_Logout_icon
        Me.PictureBox4.Location = New System.Drawing.Point(901, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1001, 463)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EmpAdd As System.Windows.Forms.TextBox
    Friend WithEvents EmpPhoneTb As System.Windows.Forms.TextBox
    Friend WithEvents EmpNameTb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmpEdCb As System.Windows.Forms.ComboBox
    Friend WithEvents PosCb As System.Windows.Forms.ComboBox
    Friend WithEvents GendCb As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
