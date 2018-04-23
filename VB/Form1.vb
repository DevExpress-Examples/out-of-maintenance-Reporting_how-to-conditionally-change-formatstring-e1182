Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace FormatDecimals
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private report As New myReport()

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim designTool As New ReportDesignTool(report)
			designTool.ShowDesignerDialog()
		End Sub

	End Class
End Namespace