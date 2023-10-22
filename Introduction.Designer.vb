<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Introduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Introduction))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnGame = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.PicPause = New System.Windows.Forms.PictureBox()
        Me.PicPlay = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(172, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(891, 85)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(170, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 39)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "How to Win:"
        '
        'BtnGame
        '
        Me.BtnGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGame.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGame.Location = New System.Drawing.Point(922, 616)
        Me.BtnGame.Name = "BtnGame"
        Me.BtnGame.Size = New System.Drawing.Size(131, 39)
        Me.BtnGame.TabIndex = 17
        Me.BtnGame.Text = "Play"
        Me.BtnGame.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(368, 205)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 161)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(177, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(170, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(893, 64)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Once the tile is placed, the tiles of the opposite color that are now enclosed wi" &
    "thin the row will become the player's color. Then it will be player two´s turn t" &
    "o make a move."
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(172, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(891, 53)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "The tile must be placed next to one of the current tiles on the board and must be" &
    " gaining an opponent´s tile."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(162, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(891, 80)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(161, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "How to Play:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(451, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 42)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Instructions"
        '
        'BtnDone
        '
        Me.BtnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDone.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDone.Location = New System.Drawing.Point(1095, 641)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(131, 39)
        Me.BtnDone.TabIndex = 21
        Me.BtnDone.Text = "Done"
        Me.BtnDone.UseVisualStyleBackColor = False
        '
        'PicPause
        '
        Me.PicPause.BackColor = System.Drawing.Color.Transparent
        Me.PicPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPause.Image = CType(resources.GetObject("PicPause.Image"), System.Drawing.Image)
        Me.PicPause.Location = New System.Drawing.Point(1159, 55)
        Me.PicPause.Name = "PicPause"
        Me.PicPause.Size = New System.Drawing.Size(48, 40)
        Me.PicPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPause.TabIndex = 88
        Me.PicPause.TabStop = False
        '
        'PicPlay
        '
        Me.PicPlay.BackColor = System.Drawing.Color.Transparent
        Me.PicPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPlay.Image = CType(resources.GetObject("PicPlay.Image"), System.Drawing.Image)
        Me.PicPlay.Location = New System.Drawing.Point(1159, 55)
        Me.PicPlay.Name = "PicPlay"
        Me.PicPlay.Size = New System.Drawing.Size(48, 40)
        Me.PicPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPlay.TabIndex = 87
        Me.PicPlay.TabStop = False
        '
        'Introduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1238, 703)
        Me.Controls.Add(Me.PicPause)
        Me.Controls.Add(Me.PicPlay)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnGame)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Introduction"
        Me.Text = "Introduction"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnGame As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents BtnDone As Button
    Friend WithEvents PicPause As PictureBox
    Friend WithEvents PicPlay As PictureBox
End Class
