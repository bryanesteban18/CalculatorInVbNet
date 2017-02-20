<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDivide = New System.Windows.Forms.Button()
        Me.BtnEquals = New System.Windows.Forms.Button()
        Me.BtnMR = New System.Windows.Forms.Button()
        Me.BtnSubtract = New System.Windows.Forms.Button()
        Me.BtnMultiply = New System.Windows.Forms.Button()
        Me.BtnPi = New System.Windows.Forms.Button()
        Me.BtnMS = New System.Windows.Forms.Button()
        Me.BtnMC = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSign = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnPower = New System.Windows.Forms.Button()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.TextBoxResults = New System.Windows.Forms.TextBox()
        Me.TextBoxEquation = New System.Windows.Forms.TextBox()
        Me.TextBoxMemory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(223, 58)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDivide
        '
        Me.BtnDivide.Location = New System.Drawing.Point(304, 87)
        Me.BtnDivide.Name = "BtnDivide"
        Me.BtnDivide.Size = New System.Drawing.Size(75, 23)
        Me.BtnDivide.TabIndex = 1
        Me.BtnDivide.Text = "/"
        Me.BtnDivide.UseVisualStyleBackColor = True
        '
        'BtnEquals
        '
        Me.BtnEquals.Location = New System.Drawing.Point(385, 87)
        Me.BtnEquals.Name = "BtnEquals"
        Me.BtnEquals.Size = New System.Drawing.Size(75, 23)
        Me.BtnEquals.TabIndex = 2
        Me.BtnEquals.Text = "="
        Me.BtnEquals.UseVisualStyleBackColor = True
        '
        'BtnMR
        '
        Me.BtnMR.Location = New System.Drawing.Point(142, 87)
        Me.BtnMR.Name = "BtnMR"
        Me.BtnMR.Size = New System.Drawing.Size(75, 23)
        Me.BtnMR.TabIndex = 3
        Me.BtnMR.Text = "MR"
        Me.BtnMR.UseVisualStyleBackColor = True
        '
        'BtnSubtract
        '
        Me.BtnSubtract.Location = New System.Drawing.Point(304, 58)
        Me.BtnSubtract.Name = "BtnSubtract"
        Me.BtnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubtract.TabIndex = 4
        Me.BtnSubtract.Text = "-"
        Me.BtnSubtract.UseVisualStyleBackColor = True
        '
        'BtnMultiply
        '
        Me.BtnMultiply.Location = New System.Drawing.Point(385, 58)
        Me.BtnMultiply.Name = "BtnMultiply"
        Me.BtnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.BtnMultiply.TabIndex = 5
        Me.BtnMultiply.Text = "*"
        Me.BtnMultiply.UseVisualStyleBackColor = True
        '
        'BtnPi
        '
        Me.BtnPi.Location = New System.Drawing.Point(304, 116)
        Me.BtnPi.Name = "BtnPi"
        Me.BtnPi.Size = New System.Drawing.Size(75, 23)
        Me.BtnPi.TabIndex = 6
        Me.BtnPi.Text = "π "
        Me.BtnPi.UseVisualStyleBackColor = True
        '
        'BtnMS
        '
        Me.BtnMS.Location = New System.Drawing.Point(61, 87)
        Me.BtnMS.Name = "BtnMS"
        Me.BtnMS.Size = New System.Drawing.Size(75, 23)
        Me.BtnMS.TabIndex = 7
        Me.BtnMS.Text = "MS"
        Me.BtnMS.UseVisualStyleBackColor = True
        '
        'BtnMC
        '
        Me.BtnMC.Location = New System.Drawing.Point(385, 116)
        Me.BtnMC.Name = "BtnMC"
        Me.BtnMC.Size = New System.Drawing.Size(75, 23)
        Me.BtnMC.TabIndex = 8
        Me.BtnMC.Text = "MC"
        Me.BtnMC.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(99, 281)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSign
        '
        Me.BtnSign.Location = New System.Drawing.Point(223, 116)
        Me.BtnSign.Name = "BtnSign"
        Me.BtnSign.Size = New System.Drawing.Size(75, 23)
        Me.BtnSign.TabIndex = 10
        Me.BtnSign.Text = "+/-"
        Me.BtnSign.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(209, 281)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnPower
        '
        Me.BtnPower.Location = New System.Drawing.Point(223, 87)
        Me.BtnPower.Name = "BtnPower"
        Me.BtnPower.Size = New System.Drawing.Size(75, 23)
        Me.BtnPower.TabIndex = 12
        Me.BtnPower.Text = "^"
        Me.BtnPower.UseVisualStyleBackColor = True
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Location = New System.Drawing.Point(99, 58)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput.TabIndex = 13
        '
        'TextBoxResults
        '
        Me.TextBoxResults.Enabled = False
        Me.TextBoxResults.Location = New System.Drawing.Point(87, 240)
        Me.TextBoxResults.Name = "TextBoxResults"
        Me.TextBoxResults.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxResults.TabIndex = 14
        '
        'TextBoxEquation
        '
        Me.TextBoxEquation.Enabled = False
        Me.TextBoxEquation.Location = New System.Drawing.Point(87, 203)
        Me.TextBoxEquation.Name = "TextBoxEquation"
        Me.TextBoxEquation.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxEquation.TabIndex = 15
        '
        'TextBoxMemory
        '
        Me.TextBoxMemory.Enabled = False
        Me.TextBoxMemory.Location = New System.Drawing.Point(87, 157)
        Me.TextBoxMemory.Name = "TextBoxMemory"
        Me.TextBoxMemory.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxMemory.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Memory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Equation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Results"
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 370)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxMemory)
        Me.Controls.Add(Me.TextBoxEquation)
        Me.Controls.Add(Me.TextBoxResults)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Controls.Add(Me.BtnPower)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSign)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnMC)
        Me.Controls.Add(Me.BtnMS)
        Me.Controls.Add(Me.BtnPi)
        Me.Controls.Add(Me.BtnMultiply)
        Me.Controls.Add(Me.BtnSubtract)
        Me.Controls.Add(Me.BtnMR)
        Me.Controls.Add(Me.BtnEquals)
        Me.Controls.Add(Me.BtnDivide)
        Me.Controls.Add(Me.BtnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDivide As System.Windows.Forms.Button
    Friend WithEvents BtnEquals As System.Windows.Forms.Button
    Friend WithEvents BtnMR As System.Windows.Forms.Button
    Friend WithEvents BtnSubtract As System.Windows.Forms.Button
    Friend WithEvents BtnMultiply As System.Windows.Forms.Button
    Friend WithEvents BtnPi As System.Windows.Forms.Button
    Friend WithEvents BtnMS As System.Windows.Forms.Button
    Friend WithEvents BtnMC As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnSign As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnPower As System.Windows.Forms.Button
    Friend WithEvents TextBoxInput As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxResults As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEquation As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMemory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
