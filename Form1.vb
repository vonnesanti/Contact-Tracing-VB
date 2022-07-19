Imports WebCam_Capture
Imports MessagingToolkit
Imports MessagingToolkit.Barcode
Imports MessagingToolkit.QRCode.Codec
Imports QRCoder
Imports System.IO

Public Class Form1

    WithEvents Mycam As WebCamCapture
    Dim Decoder As QRCodeDecoder

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
        writefile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\fujjitsu\source\repos\Contact Tracing Form\ContactTracingForm.txt", True)
        writefile.WriteLine("CONTACT TRACING FORM")
        writefile.WriteLine("Full Name:" + txtbxFullName.Text)
        writefile.WriteLine("Complete Address:" + txtbxAddress.Text)
        writefile.WriteLine("Date:" + txtbxDate.Text)
        writefile.WriteLine("Age:" + txtbxAge.Text)
        If maleButton.Checked Then
            writefile.WriteLine(lblGender.Text & " " & "Male")
        ElseIf femaleButton.Checked Then
            writefile.WriteLine(lblGender.Text & " " & "Female")
        End If
        writefile.WriteLine("Contact:" + txtbxContact.Text)

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

    Private Sub genBtn_Click(sender As Object, e As EventArgs) Handles genBtn.Click
        QRtxtbx.Text = "Full Name:" + txtbxFullName.Text & vbCrLf &
           "Complete Address:" + txtbxAddress.Text & vbCrLf &
           "Date:" + txtbxDate.Text & vbCrLf &
           "Age:" + txtbxAge.Text & vbCrLf &
           "Gender:" + lblGender.Text & vbCrLf &
           "Contact:" + txtbxContact.Text & vbCrLf &
           "Check any recent symptoms you've had:" + Label7.Text & vbCrLf &
           "Have you travelled domestically or internationally within the last 14 days?" + lblTravel.Text & vbCrLf &

        Dim Gen As New QRCodeGenerator
        Dim data = Gen.CreateQrCode(QRtxtbx.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        picQRbx.Image = code.GetGraphic(6)
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim SD As New SaveFileDialog
        SD.FileName = "Saved QR Code"
        SD.Filter = "Png Files Only (*.png)|*.png"
        If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                picQRbx.Image.Save(SD.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("Saved!")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub scanBtn_Click(sender As Object, e As EventArgs) Handles scanBtn.Click
        Try
            StopWebCam()
            Mycam = New WebCamCapture
            Mycam.Start(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopWebCam()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Mycam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles Mycam.ImageCaptured
        picQRbx.Image = e.WebCamImage
    End Sub

    Private Sub capBtn_Click(sender As Object, e As EventArgs) Handles capBtn.Click
        Try
            StopWebCam()
            Decoder = New QRCodeDecoder
            QRtxtbx.Text = Decoder.decode(New Data.QRCodeBitmapImage(picQRbx.Image))
        Catch ex As Exception

        End Try
    End Sub
End Class
