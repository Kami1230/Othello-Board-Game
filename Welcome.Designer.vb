<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.Lblload = New System.Windows.Forms.Label()
        Me.TimerWelcome = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lblload
        '
        Me.Lblload.AutoSize = True
        Me.Lblload.Location = New System.Drawing.Point(499, 354)
        Me.Lblload.Name = "Lblload"
        Me.Lblload.Size = New System.Drawing.Size(0, 13)
        Me.Lblload.TabIndex = 1
        '
        'TimerWelcome
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(286, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 116)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome To Othello"
        '
        'LblLabel
        '
        Me.LblLabel.AutoSize = True
        Me.LblLabel.BackColor = System.Drawing.Color.Transparent
        Me.LblLabel.Font = New System.Drawing.Font("Bradley Hand ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblLabel.Location = New System.Drawing.Point(528, 337)
        Me.LblLabel.Name = "LblLabel"
        Me.LblLabel.Size = New System.Drawing.Size(117, 30)
        Me.LblLabel.TabIndex = 3
        Me.LblLabel.Text = "Loading..."
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1253, 683)
        Me.Controls.Add(Me.LblLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lblload)
        Me.Name = "Welcome"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblload As Label
    Friend WithEvents TimerWelcome As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents LblLabel As Label
End Class
