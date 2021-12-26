<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlatTextBox1 = New System.Windows.Forms.TextBox()
        Me.FlatCheckBox1 = New System.Windows.Forms.RadioButton()
        Me.FlatCheckBox2 = New System.Windows.Forms.RadioButton()
        Me.FlatCheckBox3 = New System.Windows.Forms.RadioButton()
        Me.FlatCheckBox4 = New System.Windows.Forms.RadioButton()
        Me.r1 = New System.Windows.Forms.TextBox()
        Me.FlatCheckBox5 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlatTrackBar1 = New System.Windows.Forms.TrackBar()
        Me.key = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.FlatTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(444, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.SystemColors.WindowText
        Me.FlatTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlatTextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatTextBox1.ForeColor = System.Drawing.Color.Lime
        Me.FlatTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.FlatTextBox1.Multiline = True
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.Size = New System.Drawing.Size(426, 23)
        Me.FlatTextBox1.TabIndex = 1
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlatCheckBox1
        '
        Me.FlatCheckBox1.AutoSize = True
        Me.FlatCheckBox1.BackColor = System.Drawing.Color.Black
        Me.FlatCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FlatCheckBox1.ForeColor = System.Drawing.Color.Lime
        Me.FlatCheckBox1.Location = New System.Drawing.Point(444, 73)
        Me.FlatCheckBox1.Name = "FlatCheckBox1"
        Me.FlatCheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.FlatCheckBox1.TabIndex = 2
        Me.FlatCheckBox1.TabStop = True
        Me.FlatCheckBox1.Text = "Rijndael"
        Me.FlatCheckBox1.UseVisualStyleBackColor = False
        '
        'FlatCheckBox2
        '
        Me.FlatCheckBox2.AutoSize = True
        Me.FlatCheckBox2.BackColor = System.Drawing.Color.Black
        Me.FlatCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FlatCheckBox2.ForeColor = System.Drawing.Color.Lime
        Me.FlatCheckBox2.Location = New System.Drawing.Point(444, 122)
        Me.FlatCheckBox2.Name = "FlatCheckBox2"
        Me.FlatCheckBox2.Size = New System.Drawing.Size(45, 17)
        Me.FlatCheckBox2.TabIndex = 3
        Me.FlatCheckBox2.TabStop = True
        Me.FlatCheckBox2.Text = "MD5"
        Me.FlatCheckBox2.UseVisualStyleBackColor = False
        '
        'FlatCheckBox3
        '
        Me.FlatCheckBox3.AutoSize = True
        Me.FlatCheckBox3.BackColor = System.Drawing.Color.Black
        Me.FlatCheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FlatCheckBox3.ForeColor = System.Drawing.Color.Lime
        Me.FlatCheckBox3.Location = New System.Drawing.Point(444, 169)
        Me.FlatCheckBox3.Name = "FlatCheckBox3"
        Me.FlatCheckBox3.Size = New System.Drawing.Size(49, 17)
        Me.FlatCheckBox3.TabIndex = 4
        Me.FlatCheckBox3.TabStop = True
        Me.FlatCheckBox3.Text = "3DES"
        Me.FlatCheckBox3.UseVisualStyleBackColor = False
        '
        'FlatCheckBox4
        '
        Me.FlatCheckBox4.AutoSize = True
        Me.FlatCheckBox4.BackColor = System.Drawing.Color.Black
        Me.FlatCheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FlatCheckBox4.ForeColor = System.Drawing.Color.Lime
        Me.FlatCheckBox4.Location = New System.Drawing.Point(443, 221)
        Me.FlatCheckBox4.Name = "FlatCheckBox4"
        Me.FlatCheckBox4.Size = New System.Drawing.Size(45, 17)
        Me.FlatCheckBox4.TabIndex = 5
        Me.FlatCheckBox4.TabStop = True
        Me.FlatCheckBox4.Text = "XOR"
        Me.FlatCheckBox4.UseVisualStyleBackColor = False
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.SystemColors.WindowText
        Me.r1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Lime
        Me.r1.Location = New System.Drawing.Point(12, 73)
        Me.r1.Multiline = True
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(426, 222)
        Me.r1.TabIndex = 6
        Me.r1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlatCheckBox5
        '
        Me.FlatCheckBox5.AutoSize = True
        Me.FlatCheckBox5.BackColor = System.Drawing.Color.Black
        Me.FlatCheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FlatCheckBox5.ForeColor = System.Drawing.Color.Lime
        Me.FlatCheckBox5.Location = New System.Drawing.Point(444, 278)
        Me.FlatCheckBox5.Name = "FlatCheckBox5"
        Me.FlatCheckBox5.Size = New System.Drawing.Size(44, 17)
        Me.FlatCheckBox5.TabIndex = 7
        Me.FlatCheckBox5.TabStop = True
        Me.FlatCheckBox5.Text = "RC4"
        Me.FlatCheckBox5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(426, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Encrypt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FlatTrackBar1
        '
        Me.FlatTrackBar1.Location = New System.Drawing.Point(12, 329)
        Me.FlatTrackBar1.Maximum = 50
        Me.FlatTrackBar1.Name = "FlatTrackBar1"
        Me.FlatTrackBar1.Size = New System.Drawing.Size(426, 45)
        Me.FlatTrackBar1.TabIndex = 9
        '
        'key
        '
        Me.key.BackColor = System.Drawing.Color.Black
        Me.key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.key.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.key.ForeColor = System.Drawing.Color.Lime
        Me.key.Location = New System.Drawing.Point(12, 301)
        Me.key.Multiline = True
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(408, 22)
        Me.key.TabIndex = 10
        Me.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(421, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(17, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "S"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(510, 369)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.key)
        Me.Controls.Add(Me.FlatTrackBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FlatCheckBox5)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.FlatCheckBox4)
        Me.Controls.Add(Me.FlatCheckBox3)
        Me.Controls.Add(Me.FlatCheckBox2)
        Me.Controls.Add(Me.FlatCheckBox1)
        Me.Controls.Add(Me.FlatTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Crypt Server NjRAT\My Killua zoldek"
        CType(Me.FlatTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FlatTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FlatCheckBox1 As System.Windows.Forms.RadioButton
    Friend WithEvents FlatCheckBox2 As System.Windows.Forms.RadioButton
    Friend WithEvents FlatCheckBox3 As System.Windows.Forms.RadioButton
    Friend WithEvents FlatCheckBox4 As System.Windows.Forms.RadioButton
    Friend WithEvents r1 As System.Windows.Forms.TextBox
    Friend WithEvents FlatCheckBox5 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FlatTrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents key As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
