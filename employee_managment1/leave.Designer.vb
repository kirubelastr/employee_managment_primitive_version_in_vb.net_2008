<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leave
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Led = New System.Windows.Forms.DateTimePicker
        Me.Lr = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Lsd = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LEId = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Leave_Status = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Leave_Status_id = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 407)
        Me.Panel1.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Led)
        Me.GroupBox2.Controls.Add(Me.Lr)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Lsd)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LEId)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(707, 181)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "input leave details"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(517, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 46)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "APPLAY FOR LEAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "reason for leave"
        '
        'Led
        '
        Me.Led.Location = New System.Drawing.Point(247, 118)
        Me.Led.Name = "Led"
        Me.Led.Size = New System.Drawing.Size(200, 20)
        Me.Led.TabIndex = 43
        '
        'Lr
        '
        Me.Lr.FormattingEnabled = True
        Me.Lr.Items.AddRange(New Object() {"Medical", "Personal", "Vacation", "Emergency"})
        Me.Lr.Location = New System.Drawing.Point(274, 63)
        Me.Lr.Name = "Lr"
        Me.Lr.Size = New System.Drawing.Size(121, 21)
        Me.Lr.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "start date"
        '
        'Lsd
        '
        Me.Lsd.Location = New System.Drawing.Point(34, 118)
        Me.Lsd.Name = "Lsd"
        Me.Lsd.Size = New System.Drawing.Size(200, 20)
        Me.Lsd.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "employee ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "end date"
        '
        'LEId
        '
        Me.LEId.Location = New System.Drawing.Point(71, 63)
        Me.LEId.Name = "LEId"
        Me.LEId.Size = New System.Drawing.Size(100, 20)
        Me.LEId.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Leave_Status)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Leave_Status_id)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 127)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STATUS"
        '
        'Leave_Status
        '
        Me.Leave_Status.AutoSize = True
        Me.Leave_Status.BackColor = System.Drawing.Color.Cyan
        Me.Leave_Status.Location = New System.Drawing.Point(564, 49)
        Me.Leave_Status.Name = "Leave_Status"
        Me.Leave_Status.Size = New System.Drawing.Size(50, 13)
        Me.Leave_Status.TabIndex = 49
        Me.Leave_Status.Text = "STATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "employee ID"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Chartreuse
        Me.Button2.Location = New System.Drawing.Point(336, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 50)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "check leave status"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Leave_Status_id
        '
        Me.Leave_Status_id.Location = New System.Drawing.Point(145, 49)
        Me.Leave_Status_id.Name = "Leave_Status_id"
        Me.Leave_Status_id.Size = New System.Drawing.Size(100, 20)
        Me.Leave_Status_id.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(38, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "employee leave"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.employee_managment.My.Resources.Resources.Apps_Dialog_Logout_icon
        Me.PictureBox4.Location = New System.Drawing.Point(717, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(623, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 34)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'leave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(805, 481)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "leave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "leave"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LEId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lsd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Led As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lr As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Leave_Status_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Leave_Status As System.Windows.Forms.Label
End Class
