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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtbxContact = New System.Windows.Forms.TextBox()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.femaleButton = New System.Windows.Forms.RadioButton()
        Me.maleButton = New System.Windows.Forms.RadioButton()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtbxDate = New System.Windows.Forms.TextBox()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.txtbxFullName = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.noButton = New System.Windows.Forms.RadioButton()
        Me.YesButton = New System.Windows.Forms.RadioButton()
        Me.lblTravel = New System.Windows.Forms.Label()
        Me.checkbxloss = New System.Windows.Forms.CheckBox()
        Me.checkbxMuscle = New System.Windows.Forms.CheckBox()
        Me.checkbxSore = New System.Windows.Forms.CheckBox()
        Me.checkbxBreath = New System.Windows.Forms.CheckBox()
        Me.checkbxFever = New System.Windows.Forms.CheckBox()
        Me.checkbxCough = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(199, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(306, 38)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Contact Tracing Form"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtbxContact)
        Me.Panel1.Controls.Add(Me.txtbxAge)
        Me.Panel1.Controls.Add(Me.lblContact)
        Me.Panel1.Controls.Add(Me.femaleButton)
        Me.Panel1.Controls.Add(Me.maleButton)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.lblAge)
        Me.Panel1.Controls.Add(Me.txtbxDate)
        Me.Panel1.Controls.Add(Me.txtbxAddress)
        Me.Panel1.Controls.Add(Me.txtbxFullName)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(15, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 148)
        Me.Panel1.TabIndex = 2
        '
        'txtbxContact
        '
        Me.txtbxContact.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxContact.Location = New System.Drawing.Point(495, 100)
        Me.txtbxContact.Multiline = True
        Me.txtbxContact.Name = "txtbxContact"
        Me.txtbxContact.Size = New System.Drawing.Size(170, 27)
        Me.txtbxContact.TabIndex = 14
        '
        'txtbxAge
        '
        Me.txtbxAge.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAge.Location = New System.Drawing.Point(486, 13)
        Me.txtbxAge.Multiline = True
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.Size = New System.Drawing.Size(51, 27)
        Me.txtbxAge.TabIndex = 13
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(430, 101)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(75, 27)
        Me.lblContact.TabIndex = 12
        Me.lblContact.Text = "Contact: "
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'femaleButton
        '
        Me.femaleButton.AutoSize = True
        Me.femaleButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.femaleButton.Location = New System.Drawing.Point(584, 58)
        Me.femaleButton.Name = "femaleButton"
        Me.femaleButton.Size = New System.Drawing.Size(59, 17)
        Me.femaleButton.TabIndex = 11
        Me.femaleButton.TabStop = True
        Me.femaleButton.Text = "Female"
        Me.femaleButton.UseVisualStyleBackColor = True
        '
        'maleButton
        '
        Me.maleButton.AutoSize = True
        Me.maleButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.maleButton.Location = New System.Drawing.Point(512, 57)
        Me.maleButton.Name = "maleButton"
        Me.maleButton.Size = New System.Drawing.Size(48, 17)
        Me.maleButton.TabIndex = 10
        Me.maleButton.TabStop = True
        Me.maleButton.Text = "Male"
        Me.maleButton.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(430, 57)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(75, 27)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender:"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(421, 13)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(75, 27)
        Me.lblAge.TabIndex = 8
        Me.lblAge.Text = "Age:"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbxDate
        '
        Me.txtbxDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDate.Location = New System.Drawing.Point(110, 101)
        Me.txtbxDate.Multiline = True
        Me.txtbxDate.Name = "txtbxDate"
        Me.txtbxDate.Size = New System.Drawing.Size(224, 27)
        Me.txtbxDate.TabIndex = 7
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddress.Location = New System.Drawing.Point(158, 57)
        Me.txtbxAddress.Multiline = True
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.Size = New System.Drawing.Size(266, 27)
        Me.txtbxAddress.TabIndex = 6
        '
        'txtbxFullName
        '
        Me.txtbxFullName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFullName.Location = New System.Drawing.Point(110, 14)
        Me.txtbxFullName.Multiline = True
        Me.txtbxFullName.Name = "txtbxFullName"
        Me.txtbxFullName.Size = New System.Drawing.Size(224, 27)
        Me.txtbxFullName.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(14, 100)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(54, 27)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date: "
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(3, 57)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(165, 27)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Complete Address: "
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(3, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(119, 27)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Full Name: "
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.noButton)
        Me.Panel2.Controls.Add(Me.YesButton)
        Me.Panel2.Controls.Add(Me.lblTravel)
        Me.Panel2.Controls.Add(Me.checkbxloss)
        Me.Panel2.Controls.Add(Me.checkbxMuscle)
        Me.Panel2.Controls.Add(Me.checkbxSore)
        Me.Panel2.Controls.Add(Me.checkbxBreath)
        Me.Panel2.Controls.Add(Me.checkbxFever)
        Me.Panel2.Controls.Add(Me.checkbxCough)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(15, 224)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(681, 188)
        Me.Panel2.TabIndex = 3
        '
        'noButton
        '
        Me.noButton.AutoSize = True
        Me.noButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.noButton.Location = New System.Drawing.Point(362, 133)
        Me.noButton.Name = "noButton"
        Me.noButton.Size = New System.Drawing.Size(39, 17)
        Me.noButton.TabIndex = 24
        Me.noButton.TabStop = True
        Me.noButton.Text = "No"
        Me.noButton.UseVisualStyleBackColor = True
        '
        'YesButton
        '
        Me.YesButton.AutoSize = True
        Me.YesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.YesButton.Location = New System.Drawing.Point(362, 94)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(43, 17)
        Me.YesButton.TabIndex = 23
        Me.YesButton.TabStop = True
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'lblTravel
        '
        Me.lblTravel.BackColor = System.Drawing.Color.Transparent
        Me.lblTravel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTravel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTravel.Location = New System.Drawing.Point(319, 41)
        Me.lblTravel.Name = "lblTravel"
        Me.lblTravel.Size = New System.Drawing.Size(324, 49)
        Me.lblTravel.TabIndex = 22
        Me.lblTravel.Text = "Have you travelled domestically or internationally within the last 14 days?"
        Me.lblTravel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'checkbxloss
        '
        Me.checkbxloss.AutoSize = True
        Me.checkbxloss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkbxloss.Location = New System.Drawing.Point(18, 156)
        Me.checkbxloss.Name = "checkbxloss"
        Me.checkbxloss.Size = New System.Drawing.Size(133, 17)
        Me.checkbxloss.TabIndex = 21
        Me.checkbxloss.Text = "Loss of taste and smell"
        Me.checkbxloss.UseVisualStyleBackColor = True
        '
        'checkbxMuscle
        '
        Me.checkbxMuscle.AutoSize = True
        Me.checkbxMuscle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkbxMuscle.Location = New System.Drawing.Point(18, 133)
        Me.checkbxMuscle.Name = "checkbxMuscle"
        Me.checkbxMuscle.Size = New System.Drawing.Size(84, 17)
        Me.checkbxMuscle.TabIndex = 20
        Me.checkbxMuscle.Text = "Muscle Pain"
        Me.checkbxMuscle.UseVisualStyleBackColor = True
        '
        'checkbxSore
        '
        Me.checkbxSore.AutoSize = True
        Me.checkbxSore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkbxSore.Location = New System.Drawing.Point(18, 110)
        Me.checkbxSore.Name = "checkbxSore"
        Me.checkbxSore.Size = New System.Drawing.Size(82, 17)
        Me.checkbxSore.TabIndex = 19
        Me.checkbxSore.Text = "Sore Throat"
        Me.checkbxSore.UseVisualStyleBackColor = True
        '
        'checkbxBreath
        '
        Me.checkbxBreath.AutoSize = True
        Me.checkbxBreath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkbxBreath.Location = New System.Drawing.Point(18, 87)
        Me.checkbxBreath.Name = "checkbxBreath"
        Me.checkbxBreath.Size = New System.Drawing.Size(119, 17)
        Me.checkbxBreath.TabIndex = 18
        Me.checkbxBreath.Text = "Shortness of Breath"
        Me.checkbxBreath.UseVisualStyleBackColor = True
        '
        'checkbxFever
        '
        Me.checkbxFever.AutoSize = True
        Me.checkbxFever.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkbxFever.Location = New System.Drawing.Point(18, 64)
        Me.checkbxFever.Name = "checkbxFever"
        Me.checkbxFever.Size = New System.Drawing.Size(53, 17)
        Me.checkbxFever.TabIndex = 17
        Me.checkbxFever.Text = "Fever"
        Me.checkbxFever.UseVisualStyleBackColor = True
        '
        'checkbxCough
        '
        Me.checkbxCough.AutoSize = True
        Me.checkbxCough.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkbxCough.Location = New System.Drawing.Point(18, 41)
        Me.checkbxCough.Name = "checkbxCough"
        Me.checkbxCough.Size = New System.Drawing.Size(57, 17)
        Me.checkbxCough.TabIndex = 16
        Me.checkbxCough.Text = "Cough"
        Me.checkbxCough.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 27)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Check any recent symptoms you've had:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblTitle)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(12, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(713, 429)
        Me.Panel3.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(243, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MistyRose
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(435, 447)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(82, 44)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 503)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtbxContact As TextBox
    Friend WithEvents txtbxAge As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents femaleButton As RadioButton
    Friend WithEvents maleButton As RadioButton
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtbxDate As TextBox
    Friend WithEvents txtbxAddress As TextBox
    Friend WithEvents txtbxFullName As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents checkbxCough As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents checkbxloss As CheckBox
    Friend WithEvents checkbxMuscle As CheckBox
    Friend WithEvents checkbxSore As CheckBox
    Friend WithEvents checkbxBreath As CheckBox
    Friend WithEvents checkbxFever As CheckBox
    Friend WithEvents noButton As RadioButton
    Friend WithEvents YesButton As RadioButton
    Friend WithEvents lblTravel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSubmit As Button
End Class
