<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leave_approval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(leave_approval))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LAR = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LASTATUS = New System.Windows.Forms.ComboBox
        Me.LAE = New System.Windows.Forms.TextBox
        Me.LAS = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LAEI = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LeaveDGV = New System.Windows.Forms.DataGridView
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.LeaveDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LAR)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.LASTATUS)
        Me.Panel1.Controls.Add(Me.LAE)
        Me.Panel1.Controls.Add(Me.LAS)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.LAEI)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LeaveDGV)
        Me.Panel1.Controls.Add(Me.Button4)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'LAR
        '
        Me.LAR.FormattingEnabled = True
        Me.LAR.Items.AddRange(New Object() {resources.GetString("LAR.Items"), resources.GetString("LAR.Items1"), resources.GetString("LAR.Items2"), resources.GetString("LAR.Items3")})
        resources.ApplyResources(Me.LAR, "LAR")
        Me.LAR.Name = "LAR"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LASTATUS
        '
        Me.LASTATUS.FormattingEnabled = True
        Me.LASTATUS.Items.AddRange(New Object() {resources.GetString("LASTATUS.Items"), resources.GetString("LASTATUS.Items1"), resources.GetString("LASTATUS.Items2")})
        resources.ApplyResources(Me.LASTATUS, "LASTATUS")
        Me.LASTATUS.Name = "LASTATUS"
        '
        'LAE
        '
        resources.ApplyResources(Me.LAE, "LAE")
        Me.LAE.Name = "LAE"
        '
        'LAS
        '
        resources.ApplyResources(Me.LAS, "LAS")
        Me.LAS.Name = "LAS"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'LAEI
        '
        resources.ApplyResources(Me.LAEI, "LAEI")
        Me.LAEI.Name = "LAEI"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.MintCream
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'LeaveDGV
        '
        Me.LeaveDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.LeaveDGV, "LeaveDGV")
        Me.LeaveDGV.Name = "LeaveDGV"
        Me.LeaveDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Turquoise
        Me.LeaveDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeaveDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Name = "Label8"
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.employee_managment.My.Resources.Resources.Apps_Dialog_Logout_icon
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'leave_approval
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "leave_approval"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LeaveDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LeaveDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LAEI As System.Windows.Forms.TextBox
    Friend WithEvents LASTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents LAE As System.Windows.Forms.TextBox
    Friend WithEvents LAS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LAR As System.Windows.Forms.ComboBox
End Class
