<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(details))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.EmpDobLbl = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.EmpEduLbl = New System.Windows.Forms.Label
        Me.EmpPosLbl = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.EmpNameLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.EmpGenderLbl = New System.Windows.Forms.Label
        Me.EmpPhoneLbl = New System.Windows.Forms.Label
        Me.EmpAddLbl = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.EmpIdTb = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.EmpIdTb)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(35, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 390)
        Me.Panel1.TabIndex = 22
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35664!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64336!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.EmpDobLbl, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.EmpEduLbl, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.EmpPosLbl, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(459, 89)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.99145!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.00855!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(286, 194)
        Me.TableLayoutPanel2.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "employee position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "employee education"
        '
        'EmpDobLbl
        '
        Me.EmpDobLbl.AutoSize = True
        Me.EmpDobLbl.ForeColor = System.Drawing.Color.Blue
        Me.EmpDobLbl.Location = New System.Drawing.Point(126, 127)
        Me.EmpDobLbl.Name = "EmpDobLbl"
        Me.EmpDobLbl.Size = New System.Drawing.Size(111, 13)
        Me.EmpDobLbl.TabIndex = 27
        Me.EmpDobLbl.Text = "employee date of birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "employee date of birth"
        '
        'EmpEduLbl
        '
        Me.EmpEduLbl.AutoSize = True
        Me.EmpEduLbl.ForeColor = System.Drawing.Color.Blue
        Me.EmpEduLbl.Location = New System.Drawing.Point(126, 67)
        Me.EmpEduLbl.Name = "EmpEduLbl"
        Me.EmpEduLbl.Size = New System.Drawing.Size(102, 13)
        Me.EmpEduLbl.TabIndex = 26
        Me.EmpEduLbl.Text = "employee education"
        '
        'EmpPosLbl
        '
        Me.EmpPosLbl.AutoSize = True
        Me.EmpPosLbl.ForeColor = System.Drawing.Color.Blue
        Me.EmpPosLbl.Location = New System.Drawing.Point(126, 0)
        Me.EmpPosLbl.Name = "EmpPosLbl"
        Me.EmpPosLbl.Size = New System.Drawing.Size(91, 13)
        Me.EmpPosLbl.TabIndex = 25
        Me.EmpPosLbl.Text = "employee position"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.86007!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.13993!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EmpNameLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EmpGenderLbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EmpPhoneLbl, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.EmpAddLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(115, 89)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(293, 237)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "employee name"
        '
        'EmpNameLbl
        '
        Me.EmpNameLbl.AutoSize = True
        Me.EmpNameLbl.ForeColor = System.Drawing.Color.Blue
        Me.EmpNameLbl.Location = New System.Drawing.Point(111, 0)
        Me.EmpNameLbl.Name = "EmpNameLbl"
        Me.EmpNameLbl.Size = New System.Drawing.Size(81, 13)
        Me.EmpNameLbl.TabIndex = 21
        Me.EmpNameLbl.Text = "employee name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "employee gender"
        '
        'EmpGenderLbl
        '
        Me.EmpGenderLbl.AutoSize = True
        Me.EmpGenderLbl.ForeColor = System.Drawing.Color.Blue
        Me.EmpGenderLbl.Location = New System.Drawing.Point(111, 60)
        Me.EmpGenderLbl.Name = "EmpGenderLbl"
        Me.EmpGenderLbl.Size = New System.Drawing.Size(88, 13)
        Me.EmpGenderLbl.TabIndex = 23
        Me.EmpGenderLbl.Text = "employee gender"
        '
        'EmpPhoneLbl
        '
        Me.EmpPhoneLbl.AutoSize = True
        Me.EmpPhoneLbl.ForeColor = System.Drawing.Color.Blue
        Me.EmpPhoneLbl.Location = New System.Drawing.Point(111, 181)
        Me.EmpPhoneLbl.Name = "EmpPhoneLbl"
        Me.EmpPhoneLbl.Size = New System.Drawing.Size(85, 13)
        Me.EmpPhoneLbl.TabIndex = 24
        Me.EmpPhoneLbl.Text = "employee phone"
        '
        'EmpAddLbl
        '
        Me.EmpAddLbl.AutoSize = True
        Me.EmpAddLbl.ForeColor = System.Drawing.Color.Blue
        Me.EmpAddLbl.Location = New System.Drawing.Point(111, 120)
        Me.EmpAddLbl.Name = "EmpAddLbl"
        Me.EmpAddLbl.Size = New System.Drawing.Size(92, 13)
        Me.EmpAddLbl.TabIndex = 22
        Me.EmpAddLbl.Text = "employee address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "employee address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "employee phone"
        '
        'EmpIdTb
        '
        Me.EmpIdTb.Location = New System.Drawing.Point(356, 29)
        Me.EmpIdTb.Name = "EmpIdTb"
        Me.EmpIdTb.Size = New System.Drawing.Size(100, 20)
        Me.EmpIdTb.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(274, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "employee ID"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(311, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(489, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(70, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "employee details"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.employee_managment.My.Resources.Resources.Apps_Dialog_Logout_icon
        Me.PictureBox4.Location = New System.Drawing.Point(770, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(676, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 34)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(873, 475)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EmpIdTb As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EmpDobLbl As System.Windows.Forms.Label
    Friend WithEvents EmpEduLbl As System.Windows.Forms.Label
    Friend WithEvents EmpPosLbl As System.Windows.Forms.Label
    Friend WithEvents EmpPhoneLbl As System.Windows.Forms.Label
    Friend WithEvents EmpGenderLbl As System.Windows.Forms.Label
    Friend WithEvents EmpAddLbl As System.Windows.Forms.Label
    Friend WithEvents EmpNameLbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
