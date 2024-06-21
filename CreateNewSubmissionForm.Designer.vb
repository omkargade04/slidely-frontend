<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewSubmissionForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Button2 = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(300, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(301, 25)
        Label1.TabIndex = 0
        Label1.Text = "Slidely Task 2 - Create Submission "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(359, 137)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(204, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(359, 194)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(204, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(359, 258)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(204, 27)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(359, 325)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(204, 27)
        TextBox4.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(242, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 25)
        Label2.TabIndex = 5
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(242, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 25)
        Label3.TabIndex = 6
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(223, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 25)
        Label4.TabIndex = 7
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(222, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 25)
        Label5.TabIndex = 8
        Label5.Text = "Github Link "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(223, 350)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 25)
        Label6.TabIndex = 9
        Label6.Text = "For Task 2"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LemonChiffon
        Button1.Location = New Point(174, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(239, 42)
        Button1.TabIndex = 10
        Button1.Text = "TOGGLE STOPWATCH (CTRL+T)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSkyBlue
        Button2.Location = New Point(254, 466)
        Button2.Name = "Button2"
        Button2.Size = New Size(386, 62)
        Button2.TabIndex = 11
        Button2.Text = "SUBMIT FORM(CTRL+S)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F)
        Label7.Location = New Point(557, 419)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 25)
        Label7.TabIndex = 12
        Label7.Text = "Time"
        ' 
        ' CreateNewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(899, 603)
        Controls.Add(Label7)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "CreateNewSubmissionForm"
        Text = "CreateNewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
End Class
