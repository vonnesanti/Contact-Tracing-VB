Public Class Form1

    Dim G As String
    Dim Q1 As String
    Dim Q2 As String

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
        Panel2.BackColor = Color.FromArgb(100, 0, 0, 0)
        Panel3.BackColor = Color.FromArgb(100, 0, 0, 0)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles checkbxloss.CheckedChanged

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim writefile As System.IO.StreamWriter
        writefile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\fujjitsu\source\repos\VB_TicTacToe\ContactTracingForm.txt", True)
        writefile.WriteLine("CONTACT TRACING FORM")
        writefile.WriteLine("Full Name:" + txtbxFullName.Text)
        writefile.WriteLine("Complete Address:" + txtbxAddress.Text)
        writefile.WriteLine("Date:" + txtbxDate.Text)
        writefile.WriteLine("Age" + txtbxAge.Text)
        If maleButton.Checked Then
            writefile.WriteLine(lblGender.Text & " " & "Male")
        ElseIf femaleButton.Checked Then
            writefile.WriteLine(lblGender.Text & " " & "Female")
        End If
        writefile.WriteLine("Contact" + txtbxContact.Text)

        If checkbxCough.CheckState = CheckState.Checked Then
            writefile.WriteLine("Check any recent symptoms you've had: Cough")
        Else
            'Do Nothing
        End If
        If checkbxFever.CheckState = CheckState.Checked Then
            writefile.WriteLine("Check any recent symptoms you've had: Fever")
        Else
            'Do Nothing
        End If
        If checkbxBreath.CheckState = CheckState.Checked Then
            writefile.WriteLine("Check any recent symptoms you've had: Shortness of Breath")
        Else
            'Do Nothing
        End If
        If checkbxSore.CheckState = CheckState.Checked Then
            writefile.WriteLine("Check any recent symptoms you've had: Sore Throat")
        Else
            'Do Nothing
        End If

        If checkbxMuscle.CheckState = CheckState.Checked Then
            writefile.WriteLine("Check any recent symptoms you've had: Muscle Pain")
        Else
            'Do Nothing
        End If
        If checkbxloss.CheckState = CheckState.Checked Then
            writefile.WriteLine("Check any recent symptoms you've had: Loss of taste and smell")
        Else
            'Do Nothing
        End If

        If YesButton.Checked Then
            writefile.WriteLine(lblTravel.Text & " " & YesButton.Text)
        ElseIf noButton.Checked Then
            writefile.WriteLine(lblTravel.Text & " " & noButton.Text)
        End If

        writefile.WriteLine("")
        txtbxFullName.Clear()
        txtbxAddress.Clear()
        txtbxDate.Clear()
        txtbxAge.Clear()
        txtbxContact.Clear()



        checkbxCough.Checked = False
        checkbxFever.Checked = False
        checkbxBreath.Checked = False
        checkbxSore.Checked = False
        checkbxMuscle.Checked = False
        checkbxloss.Checked = False

        MessageBox.Show("Your Form was submitted!", "CONTACT TRACING FORM")

        writefile.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GameExit As DialogResult = MessageBox.Show("Are you sure you want to exit?", "CONTACT TRACING FORM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If GameExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
