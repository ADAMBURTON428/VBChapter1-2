﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JokeandPunchline
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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnPunchline = New System.Windows.Forms.Button()
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.btnSetup2 = New System.Windows.Forms.Button()
        Me.btnSetup3 = New System.Windows.Forms.Button()
        Me.btnPunchline2 = New System.Windows.Forms.Button()
        Me.btnPunchline3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(41, 141)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup "
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnPunchline
        '
        Me.btnPunchline.Location = New System.Drawing.Point(171, 141)
        Me.btnPunchline.Name = "btnPunchline"
        Me.btnPunchline.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchline.TabIndex = 1
        Me.btnPunchline.Text = "PunchLine"
        Me.btnPunchline.UseVisualStyleBackColor = True
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke.Location = New System.Drawing.Point(12, 20)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(214, 24)
        Me.lblJoke.TabIndex = 2
        Me.lblJoke.Text = "Click buttons for jokes"
        '
        'btnSetup2
        '
        Me.btnSetup2.Location = New System.Drawing.Point(41, 181)
        Me.btnSetup2.Name = "btnSetup2"
        Me.btnSetup2.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup2.TabIndex = 3
        Me.btnSetup2.Text = "Setup "
        Me.btnSetup2.UseVisualStyleBackColor = True
        '
        'btnSetup3
        '
        Me.btnSetup3.Location = New System.Drawing.Point(41, 227)
        Me.btnSetup3.Name = "btnSetup3"
        Me.btnSetup3.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup3.TabIndex = 4
        Me.btnSetup3.Text = "Setup "
        Me.btnSetup3.UseVisualStyleBackColor = True
        '
        'btnPunchline2
        '
        Me.btnPunchline2.Location = New System.Drawing.Point(171, 181)
        Me.btnPunchline2.Name = "btnPunchline2"
        Me.btnPunchline2.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchline2.TabIndex = 5
        Me.btnPunchline2.Text = "PunchLine"
        Me.btnPunchline2.UseVisualStyleBackColor = True
        '
        'btnPunchline3
        '
        Me.btnPunchline3.Location = New System.Drawing.Point(171, 227)
        Me.btnPunchline3.Name = "btnPunchline3"
        Me.btnPunchline3.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchline3.TabIndex = 6
        Me.btnPunchline3.Text = "PunchLine"
        Me.btnPunchline3.UseVisualStyleBackColor = True
        '
        'JokeandPunchline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 262)
        Me.Controls.Add(Me.btnPunchline3)
        Me.Controls.Add(Me.btnPunchline2)
        Me.Controls.Add(Me.btnSetup3)
        Me.Controls.Add(Me.btnSetup2)
        Me.Controls.Add(Me.lblJoke)
        Me.Controls.Add(Me.btnPunchline)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "JokeandPunchline"
        Me.Text = "Joke and Punchline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnPunchline As System.Windows.Forms.Button
    Friend WithEvents lblJoke As System.Windows.Forms.Label
    Friend WithEvents btnSetup2 As System.Windows.Forms.Button
    Friend WithEvents btnSetup3 As System.Windows.Forms.Button
    Friend WithEvents btnPunchline2 As System.Windows.Forms.Button
    Friend WithEvents btnPunchline3 As System.Windows.Forms.Button

End Class
