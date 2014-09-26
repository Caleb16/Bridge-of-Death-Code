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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.lblQ3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(72, 40)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(306, 24)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to the Bridge of Death"
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(57, 114)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(155, 20)
        Me.lblQ1.TabIndex = 1
        Me.lblQ1.Text = "What is Your Name?"
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(56, 158)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(156, 20)
        Me.lblQ2.TabIndex = 2
        Me.lblQ2.Text = "What is Your Quest?"
        '
        'lblQ3
        '
        Me.lblQ3.AutoSize = True
        Me.lblQ3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ3.Location = New System.Drawing.Point(57, 202)
        Me.lblQ3.Name = "lblQ3"
        Me.lblQ3.Size = New System.Drawing.Size(211, 20)
        Me.lblQ3.TabIndex = 3
        Me.lblQ3.Text = "What is Your Favorite Color?"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(234, 114)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 20)
        Me.txtName.TabIndex = 4
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(234, 160)
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(148, 20)
        Me.txtQuest.TabIndex = 5
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(275, 201)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(107, 20)
        Me.txtColor.TabIndex = 6
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(153, 240)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(159, 27)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit Answers"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(43, 283)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Q1 Answer"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(153, 283)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(59, 13)
        Me.lblQuest.TabIndex = 9
        Me.lblQuest.Text = "Q2 Answer"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(272, 283)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(59, 13)
        Me.lblColor.TabIndex = 10
        Me.lblColor.Text = "Q3 Answer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 334)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblQuest)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtQuest)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblQ3)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.lblQ1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "Form1"
        Me.Text = "Bridge of Death"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents lblQ3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuest As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblQuest As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label

End Class
