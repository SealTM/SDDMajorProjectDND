<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateCampaignForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateCampaignForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.RBAscending = New System.Windows.Forms.RadioButton()
        Me.RBDescending = New System.Windows.Forms.RadioButton()
        Me.BtnCreateCampaign = New System.Windows.Forms.Button()
        Me.lblCampain1 = New System.Windows.Forms.Label()
        Me.lblCampain6 = New System.Windows.Forms.Label()
        Me.lblCampain2 = New System.Windows.Forms.Label()
        Me.lblCampain3 = New System.Windows.Forms.Label()
        Me.lblCampain4 = New System.Windows.Forms.Label()
        Me.lblCampain5 = New System.Windows.Forms.Label()
        Me.lblCampain7 = New System.Windows.Forms.Label()
        Me.lblCampain8 = New System.Windows.Forms.Label()
        Me.lblCampain9 = New System.Windows.Forms.Label()
        Me.lblCampain10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "𝕮𝖆𝖒𝖕𝖆𝖎𝖌𝖓 𝕮𝖗𝖊𝖆𝖙𝖎𝖔𝖓"
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.Tomato
        Me.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHelp.Location = New System.Drawing.Point(545, 12)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(75, 23)
        Me.BtnHelp.TabIndex = 11
        Me.BtnHelp.Text = "Help"
        Me.BtnHelp.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 78)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(216, 32)
        Me.txtSearch.TabIndex = 12
        Me.txtSearch.Text = "Search                         "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblCampain10)
        Me.Panel1.Controls.Add(Me.lblCampain9)
        Me.Panel1.Controls.Add(Me.lblCampain8)
        Me.Panel1.Controls.Add(Me.lblCampain7)
        Me.Panel1.Controls.Add(Me.lblCampain5)
        Me.Panel1.Controls.Add(Me.lblCampain4)
        Me.Panel1.Controls.Add(Me.lblCampain3)
        Me.Panel1.Controls.Add(Me.lblCampain2)
        Me.Panel1.Controls.Add(Me.lblCampain6)
        Me.Panel1.Controls.Add(Me.lblCampain1)
        Me.Panel1.Location = New System.Drawing.Point(12, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 212)
        Me.Panel1.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(12, 334)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RBAscending
        '
        Me.RBAscending.AutoSize = True
        Me.RBAscending.Location = New System.Drawing.Point(457, 93)
        Me.RBAscending.Name = "RBAscending"
        Me.RBAscending.Size = New System.Drawing.Size(75, 17)
        Me.RBAscending.TabIndex = 14
        Me.RBAscending.TabStop = True
        Me.RBAscending.Text = "Ascending"
        Me.RBAscending.UseVisualStyleBackColor = True
        '
        'RBDescending
        '
        Me.RBDescending.AutoSize = True
        Me.RBDescending.Location = New System.Drawing.Point(538, 93)
        Me.RBDescending.Name = "RBDescending"
        Me.RBDescending.Size = New System.Drawing.Size(82, 17)
        Me.RBDescending.TabIndex = 15
        Me.RBDescending.TabStop = True
        Me.RBDescending.Text = "Descending"
        Me.RBDescending.UseVisualStyleBackColor = True
        '
        'BtnCreateCampaign
        '
        Me.BtnCreateCampaign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateCampaign.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCreateCampaign.Location = New System.Drawing.Point(508, 334)
        Me.BtnCreateCampaign.Name = "BtnCreateCampaign"
        Me.BtnCreateCampaign.Size = New System.Drawing.Size(112, 23)
        Me.BtnCreateCampaign.TabIndex = 16
        Me.BtnCreateCampaign.Text = "Create Campaign"
        Me.BtnCreateCampaign.UseVisualStyleBackColor = True
        '
        'lblCampain1
        '
        Me.lblCampain1.BackColor = System.Drawing.Color.Silver
        Me.lblCampain1.Location = New System.Drawing.Point(8, 12)
        Me.lblCampain1.Name = "lblCampain1"
        Me.lblCampain1.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain1.TabIndex = 0
        Me.lblCampain1.Text = "Campaign Name"
        Me.lblCampain1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain6
        '
        Me.lblCampain6.BackColor = System.Drawing.Color.Silver
        Me.lblCampain6.Location = New System.Drawing.Point(8, 109)
        Me.lblCampain6.Name = "lblCampain6"
        Me.lblCampain6.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain6.TabIndex = 1
        Me.lblCampain6.Text = "Campaign Name"
        Me.lblCampain6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain2
        '
        Me.lblCampain2.BackColor = System.Drawing.Color.Silver
        Me.lblCampain2.Location = New System.Drawing.Point(127, 12)
        Me.lblCampain2.Name = "lblCampain2"
        Me.lblCampain2.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain2.TabIndex = 2
        Me.lblCampain2.Text = "Campaign Name"
        Me.lblCampain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain3
        '
        Me.lblCampain3.BackColor = System.Drawing.Color.Silver
        Me.lblCampain3.Location = New System.Drawing.Point(246, 12)
        Me.lblCampain3.Name = "lblCampain3"
        Me.lblCampain3.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain3.TabIndex = 3
        Me.lblCampain3.Text = "Campaign Name"
        Me.lblCampain3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain4
        '
        Me.lblCampain4.BackColor = System.Drawing.Color.Silver
        Me.lblCampain4.Location = New System.Drawing.Point(365, 12)
        Me.lblCampain4.Name = "lblCampain4"
        Me.lblCampain4.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain4.TabIndex = 4
        Me.lblCampain4.Text = "Campaign Name"
        Me.lblCampain4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain5
        '
        Me.lblCampain5.BackColor = System.Drawing.Color.Silver
        Me.lblCampain5.Location = New System.Drawing.Point(484, 12)
        Me.lblCampain5.Name = "lblCampain5"
        Me.lblCampain5.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain5.TabIndex = 5
        Me.lblCampain5.Text = "Campaign Name"
        Me.lblCampain5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain7
        '
        Me.lblCampain7.BackColor = System.Drawing.Color.Silver
        Me.lblCampain7.Location = New System.Drawing.Point(127, 109)
        Me.lblCampain7.Name = "lblCampain7"
        Me.lblCampain7.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain7.TabIndex = 17
        Me.lblCampain7.Text = "Campaign Name"
        Me.lblCampain7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain8
        '
        Me.lblCampain8.BackColor = System.Drawing.Color.Silver
        Me.lblCampain8.Location = New System.Drawing.Point(246, 109)
        Me.lblCampain8.Name = "lblCampain8"
        Me.lblCampain8.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain8.TabIndex = 18
        Me.lblCampain8.Text = "Campaign Name"
        Me.lblCampain8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain9
        '
        Me.lblCampain9.BackColor = System.Drawing.Color.Silver
        Me.lblCampain9.Location = New System.Drawing.Point(365, 109)
        Me.lblCampain9.Name = "lblCampain9"
        Me.lblCampain9.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain9.TabIndex = 19
        Me.lblCampain9.Text = "Campaign Name"
        Me.lblCampain9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCampain10
        '
        Me.lblCampain10.BackColor = System.Drawing.Color.Silver
        Me.lblCampain10.Location = New System.Drawing.Point(484, 109)
        Me.lblCampain10.Name = "lblCampain10"
        Me.lblCampain10.Size = New System.Drawing.Size(113, 90)
        Me.lblCampain10.TabIndex = 20
        Me.lblCampain10.Text = "Campaign Name"
        Me.lblCampain10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreateCampaignForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 368)
        Me.Controls.Add(Me.BtnCreateCampaign)
        Me.Controls.Add(Me.RBDescending)
        Me.Controls.Add(Me.RBAscending)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CreateCampaignForm"
        Me.Text = "CreateCampaign"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHelp As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents RBAscending As RadioButton
    Friend WithEvents RBDescending As RadioButton
    Friend WithEvents BtnCreateCampaign As Button
    Friend WithEvents lblCampain1 As Label
    Friend WithEvents lblCampain10 As Label
    Friend WithEvents lblCampain9 As Label
    Friend WithEvents lblCampain8 As Label
    Friend WithEvents lblCampain7 As Label
    Friend WithEvents lblCampain5 As Label
    Friend WithEvents lblCampain4 As Label
    Friend WithEvents lblCampain3 As Label
    Friend WithEvents lblCampain2 As Label
    Friend WithEvents lblCampain6 As Label
End Class
