
Imports System.IO

Public Class Tutorial

    Public Shared Sub CheckTutorialNumber()
        Select Case frmFirstTimeSetup.StepNumber
            Case 1
                frmFirstTimeSetup.LnkBack.Enabled = False
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "1.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 2
                frmFirstTimeSetup.LnkBack.Enabled = True
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "2.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 3
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "3.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 4
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "4.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 5
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "5.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 6
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "6.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 7
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "7.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 8
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "8.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 9
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "9.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 10
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "10.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 11
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "11.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 12
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "12.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 13
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "13.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 14
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "14.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 15
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "15.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 16
                frmFirstTimeSetup.LnkNext.Enabled = True
                frmFirstTimeSetup.LnkNext.Visible = True
                frmFirstTimeSetup.LnkContinue.Visible = False
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "16.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
            Case 17
                frmFirstTimeSetup.LnkContinue.Visible = False
                frmFirstTimeSetup.LnkNext.Enabled = False
                frmFirstTimeSetup.LnkContinue.Visible = True
                Dim Path As String = Application.StartupPath & "\frmTutorial\"
                Dim StepNo As String = "17.png"
                frmFirstTimeSetup.PbTutorial.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(Path & StepNo)), True, False)
        End Select
    End Sub

End Class
