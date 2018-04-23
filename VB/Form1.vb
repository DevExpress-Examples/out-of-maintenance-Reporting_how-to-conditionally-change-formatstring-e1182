Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
' ...

Namespace FormatDecimals
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			CType(New myReport(), myReport).ShowPreviewDialog()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			CType(New myReport(), myReport).ShowDesignerDialog()
		End Sub

	End Class
End Namespace