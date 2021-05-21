<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCampaignForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewCampaignForm))
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BtnCreateCampaign = New System.Windows.Forms.Button()
        Me.BtnCreateCharacter = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCampaignName = New System.Windows.Forms.Label()
        Me.lblCampaignDesc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.lblName4 = New System.Windows.Forms.Label()
        Me.lblName5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "𝖁𝖎𝖊𝖜 𝕮𝖆𝖒𝖕𝖆𝖎𝖌𝖓"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblCampaignDesc)
        Me.Panel1.Controls.Add(Me.lblCampaignName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 242)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblName5)
        Me.Panel2.Controls.Add(Me.lblName4)
        Me.Panel2.Controls.Add(Me.lblName3)
        Me.Panel2.Controls.Add(Me.lblName2)
        Me.Panel2.Controls.Add(Me.lblName1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnView)
        Me.Panel2.Controls.Add(Me.BtnCreateCharacter)
        Me.Panel2.Location = New System.Drawing.Point(453, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(167, 242)
        Me.Panel2.TabIndex = 15
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(12, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'BtnCreateCampaign
        '
        Me.BtnCreateCampaign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateCampaign.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCreateCampaign.Location = New System.Drawing.Point(509, 326)
        Me.BtnCreateCampaign.Name = "BtnCreateCampaign"
        Me.BtnCreateCampaign.Size = New System.Drawing.Size(111, 23)
        Me.BtnCreateCampaign.TabIndex = 17
        Me.BtnCreateCampaign.Text = "Create Campaign"
        Me.BtnCreateCampaign.UseVisualStyleBackColor = True
        '
        'BtnCreateCharacter
        '
        Me.BtnCreateCharacter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateCharacter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCreateCharacter.Location = New System.Drawing.Point(87, 212)
        Me.BtnCreateCharacter.Name = "BtnCreateCharacter"
        Me.BtnCreateCharacter.Size = New System.Drawing.Size(75, 23)
        Me.BtnCreateCharacter.TabIndex = 18
        Me.BtnCreateCharacter.Text = "Create"
        Me.BtnCreateCharacter.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnView.Location = New System.Drawing.Point(6, 212)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 19
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(351, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "______________________________________"
        '
        'lblCampaignName
        '
        Me.lblCampaignName.AutoSize = True
        Me.lblCampaignName.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCampaignName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampaignName.Location = New System.Drawing.Point(7, 10)
        Me.lblCampaignName.Name = "lblCampaignName"
        Me.lblCampaignName.Size = New System.Drawing.Size(216, 31)
        Me.lblCampaignName.TabIndex = 22
        Me.lblCampaignName.Text = "Campaign Name"
        '
        'lblCampaignDesc
        '
        Me.lblCampaignDesc.AutoSize = True
        Me.lblCampaignDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCampaignDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampaignDesc.Location = New System.Drawing.Point(5, 55)
        Me.lblCampaignDesc.Name = "lblCampaignDesc"
        Me.lblCampaignDesc.Size = New System.Drawing.Size(165, 20)
        Me.lblCampaignDesc.TabIndex = 23
        Me.lblCampaignDesc.Text = "Campaign Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "_________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Character List"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.Location = New System.Drawing.Point(52, 55)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(51, 20)
        Me.lblName1.TabIndex = 24
        Me.lblName1.Text = "Name"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName2.Location = New System.Drawing.Point(52, 75)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(51, 20)
        Me.lblName2.TabIndex = 25
        Me.lblName2.Text = "Name"
        '
        'lblName3
        '
        Me.lblName3.AutoSize = True
        Me.lblName3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName3.Location = New System.Drawing.Point(52, 95)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(51, 20)
        Me.lblName3.TabIndex = 26
        Me.lblName3.Text = "Name"
        '
        'lblName4
        '
        Me.lblName4.AutoSize = True
        Me.lblName4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName4.Location = New System.Drawing.Point(52, 115)
        Me.lblName4.Name = "lblName4"
        Me.lblName4.Size = New System.Drawing.Size(51, 20)
        Me.lblName4.TabIndex = 27
        Me.lblName4.Text = "Name"
        '
        'lblName5
        '
        Me.lblName5.AutoSize = True
        Me.lblName5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName5.Location = New System.Drawing.Point(52, 135)
        Me.lblName5.Name = "lblName5"
        Me.lblName5.Size = New System.Drawing.Size(51, 20)
        Me.lblName5.TabIndex = 28
        Me.lblName5.Text = "Name"
        '
        'ViewCampaignForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 368)
        Me.Controls.Add(Me.BtnCreateCampaign)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnHelp)
        Me.Name = "ViewCampaignForm"
        Me.Text = "ViewCampaign"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHelp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCampaignDesc As Label
    Friend WithEvents lblCampaignName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnView As Button
    Friend WithEvents BtnCreateCharacter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents BtnCreateCampaign As Button
    Friend WithEvents lblName5 As Label
    Friend WithEvents lblName4 As Label
    Friend WithEvents lblName3 As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents lblName1 As Label
End Class
