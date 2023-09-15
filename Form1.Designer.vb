<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAdd = New Button()
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        Purple = New RadioButton()
        Blue = New RadioButton()
        ToLower = New RadioButton()
        ToUpper = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ControlLightLight
        btnAdd.Location = New Point(315, 336)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(261, 112)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(220, 204)
        ListBox1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(257, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(226, 31)
        TextBox1.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(488, 112)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 204)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(27, 33)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(146, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Purple)
        GroupBox2.Controls.Add(Blue)
        GroupBox2.Controls.Add(ToLower)
        GroupBox2.Controls.Add(ToUpper)
        GroupBox2.Location = New Point(487, 112)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 204)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox1"
        ' 
        ' Purple
        ' 
        Purple.AutoSize = True
        Purple.Location = New Point(28, 138)
        Purple.Name = "Purple"
        Purple.Size = New Size(87, 29)
        Purple.TabIndex = 0
        Purple.TabStop = True
        Purple.Text = "Purple"
        Purple.UseVisualStyleBackColor = True
        ' 
        ' Blue
        ' 
        Blue.AutoSize = True
        Blue.Location = New Point(28, 103)
        Blue.Name = "Blue"
        Blue.Size = New Size(70, 29)
        Blue.TabIndex = 0
        Blue.TabStop = True
        Blue.Text = "Blue"
        Blue.UseVisualStyleBackColor = True
        ' 
        ' ToLower
        ' 
        ToLower.AutoSize = True
        ToLower.Location = New Point(27, 68)
        ToLower.Name = "ToLower"
        ToLower.Size = New Size(102, 29)
        ToLower.TabIndex = 0
        ToLower.TabStop = True
        ToLower.Text = "ToLower"
        ToLower.UseVisualStyleBackColor = True
        ' 
        ' ToUpper
        ' 
        ToUpper.AutoSize = True
        ToUpper.Location = New Point(27, 33)
        ToUpper.Name = "ToUpper"
        ToUpper.Size = New Size(104, 29)
        ToUpper.TabIndex = 0
        ToUpper.TabStop = True
        ToUpper.Text = "ToUpper"
        ToUpper.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Purple As RadioButton
    Friend WithEvents Blue As RadioButton
    Friend WithEvents ToLower As RadioButton
    Friend WithEvents ToUpper As RadioButton
End Class
