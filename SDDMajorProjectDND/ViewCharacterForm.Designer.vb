<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCharacterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewCharacterForm))
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCharacterOwner = New System.Windows.Forms.Label()
        Me.lblCharacterName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCharacterLevel = New System.Windows.Forms.Label()
        Me.lblCharacterClass = New System.Windows.Forms.Label()
        Me.lblCharacterRace = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.PctCharacter = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BtnStats = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PctCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(269, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "𝕮𝖍𝖆𝖗𝖆𝖈𝖙𝖊𝖗"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblCharacterRace)
        Me.Panel1.Controls.Add(Me.lblCharacterClass)
        Me.Panel1.Controls.Add(Me.lblCharacterLevel)
        Me.Panel1.Controls.Add(Me.lblCharacterOwner)
        Me.Panel1.Controls.Add(Me.lblCharacterName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 242)
        Me.Panel1.TabIndex = 16
        '
        'lblCharacterOwner
        '
        Me.lblCharacterOwner.AutoSize = True
        Me.lblCharacterOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCharacterOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacterOwner.Location = New System.Drawing.Point(9, 62)
        Me.lblCharacterOwner.Name = "lblCharacterOwner"
        Me.lblCharacterOwner.Size = New System.Drawing.Size(55, 20)
        Me.lblCharacterOwner.TabIndex = 23
        Me.lblCharacterOwner.Text = "Owner"
        '
        'lblCharacterName
        '
        Me.lblCharacterName.AutoSize = True
        Me.lblCharacterName.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCharacterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacterName.Location = New System.Drawing.Point(7, 10)
        Me.lblCharacterName.Name = "lblCharacterName"
        Me.lblCharacterName.Size = New System.Drawing.Size(213, 31)
        Me.lblCharacterName.TabIndex = 22
        Me.lblCharacterName.Text = "Character Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "____________________________________"
        '
        'lblCharacterLevel
        '
        Me.lblCharacterLevel.AutoSize = True
        Me.lblCharacterLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCharacterLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacterLevel.Location = New System.Drawing.Point(9, 89)
        Me.lblCharacterLevel.Name = "lblCharacterLevel"
        Me.lblCharacterLevel.Size = New System.Drawing.Size(120, 20)
        Me.lblCharacterLevel.TabIndex = 24
        Me.lblCharacterLevel.Text = "Character Level"
        '
        'lblCharacterClass
        '
        Me.lblCharacterClass.AutoSize = True
        Me.lblCharacterClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCharacterClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacterClass.Location = New System.Drawing.Point(9, 119)
        Me.lblCharacterClass.Name = "lblCharacterClass"
        Me.lblCharacterClass.Size = New System.Drawing.Size(122, 20)
        Me.lblCharacterClass.TabIndex = 25
        Me.lblCharacterClass.Text = "Character Class"
        '
        'lblCharacterRace
        '
        Me.lblCharacterRace.AutoSize = True
        Me.lblCharacterRace.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCharacterRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacterRace.Location = New System.Drawing.Point(9, 149)
        Me.lblCharacterRace.Name = "lblCharacterRace"
        Me.lblCharacterRace.Size = New System.Drawing.Size(121, 20)
        Me.lblCharacterRace.TabIndex = 26
        Me.lblCharacterRace.Text = "Character Race"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "____________________________________"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.Location = New System.Drawing.Point(13, 192)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(216, 32)
        Me.txtDescription.TabIndex = 28
        Me.txtDescription.Text = "Description"
        '
        'PctCharacter
        '
        Me.PctCharacter.Location = New System.Drawing.Point(453, 79)
        Me.PctCharacter.Name = "PctCharacter"
        Me.PctCharacter.Size = New System.Drawing.Size(167, 241)
        Me.PctCharacter.TabIndex = 17
        Me.PctCharacter.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(12, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'BtnStats
        '
        Me.BtnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStats.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnStats.Location = New System.Drawing.Point(545, 333)
        Me.BtnStats.Name = "BtnStats"
        Me.BtnStats.Size = New System.Drawing.Size(75, 23)
        Me.BtnStats.TabIndex = 19
        Me.BtnStats.Text = "Stats"
        Me.BtnStats.UseVisualStyleBackColor = True
        '
        'ViewCharacterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 368)
        Me.Controls.Add(Me.BtnStats)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PctCharacter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnHelp)
        Me.Name = "ViewCharacterForm"
        Me.Text = "ViewCharacter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PctCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHelp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCharacterOwner As Label
    Friend WithEvents lblCharacterName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCharacterRace As Label
    Friend WithEvents lblCharacterClass As Label
    Friend WithEvents lblCharacterLevel As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents PctCharacter As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents BtnStats As Button
End Class
