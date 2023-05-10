Imports System.ComponentModel
Imports System.Data.OleDb
Public Class frmTransactionHistory_Admin

    Private Sub frmTransactionHistory_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin_Modify.TransactionHistory_AdminFilters(DgvTransactionHistory_Admin, 4)
    End Sub
    Private Sub BtnExportToExcel_TH_Click(sender As Object, e As EventArgs) Handles BtnExportToExcel_TH.Click
        If BtnExportToExcel_TH.Text = "Export to excel" Then
            With FolderBrowserDialog1
                .SelectedPath = "C:\"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    LblFileLocation_TH.Text = .SelectedPath

                    BtnExportToExcel_TH.Text = "Cancel"
                    BtnExportToExcel_TH.BackColor = Color.IndianRed

                    LblFileLocation_TH.Visible = True
                    BtnExportNow_TH.Visible = True
                    LblTextFileLocation.Visible = True
                End If
            End With
        Else
            LblFileLocation_TH.Text = "File Location"
            BtnExportToExcel_TH.Text = "Export to excel"
            BtnExportToExcel_TH.BackColor = Color.LimeGreen

            LblFileLocation_TH.Visible = False
            BtnExportNow_TH.Visible = False
            LblTextFileLocation.Visible = False
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub BtnExportNow_TH_Click(sender As Object, e As EventArgs) Handles BtnExportNow_TH.Click
        If MessageBox.Show("Do you want to continue exporting this transaction history?", "Confirm Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            Dim FileLocation As String = LblFileLocation_TH.Text

            xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")


            For i = 0 To DgvTransactionHistory_Admin.RowCount - 2
                For j = 0 To DgvTransactionHistory_Admin.ColumnCount - 1
                    For k As Integer = 1 To DgvTransactionHistory_Admin.Columns.Count
                        xlWorkSheet.Cells(1, k) = DgvTransactionHistory_Admin.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DgvTransactionHistory_Admin(j, i).Value.ToString()
                    Next
                Next
            Next

            xlWorkSheet.SaveAs(FileLocation & "\TransactionHistory_" & DateTime.Now.ToString("M-d-yy") & "_" & DateTime.Now.ToString("hh-mm-ss") & ".xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MessageBox.Show("Transaction history has been successfully exported!", "Transaction history to Excel success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BtnExportNow_TH.Visible = False
            LblFileLocation_TH.Text = "File Location"
            LblFileLocation_TH.Visible = False
            LblTextFileLocation.Visible = False

            BtnExportToExcel_TH.Text = "Export"
            BtnExportToExcel_TH.BackColor = Color.LimeGreen
        End If
    End Sub

    Private Sub BtnFilters_TH_Click(sender As Object, e As EventArgs) Handles BtnFilters_TH.Click
        If BtnFilters_TH.Text = "ALL" Then
            Admin_Modify.TransactionHistory_AdminFilters(DgvTransactionHistory_Admin, 1)
            BtnFilters_TH.Text = "TRANSPORTATION"
            BtnFilters_TH.BackColor = Color.Lime
        ElseIf BtnFilters_TH.Text = "TRANSPORTATION" Then
            Admin_Modify.TransactionHistory_AdminFilters(DgvTransactionHistory_Admin, 2)
            BtnFilters_TH.Text = "CASH IN (L-Credits)"
            BtnFilters_TH.BackColor = Color.Plum
        ElseIf BtnFilters_TH.Text = "CASH IN (L-Credits)" Then
            Admin_Modify.TransactionHistory_AdminFilters(DgvTransactionHistory_Admin, 3)
            BtnFilters_TH.Text = "PREMIUM MEMBERSHIP"
            BtnFilters_TH.BackColor = Color.Gold
        ElseIf BtnFilters_TH.Text = "PREMIUM MEMBERSHIP" Then
            Admin_Modify.TransactionHistory_AdminFilters(DgvTransactionHistory_Admin, 4)
            BtnFilters_TH.Text = "ALL"
            BtnFilters_TH.BackColor = Color.PaleTurquoise
        End If
    End Sub
End Class