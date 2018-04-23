Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.XtraRichEdit

Namespace WpfApplication1
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub NewDocumentButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.CreateNewDocument()
		End Sub

		Private Sub SaveDocumentButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.SaveDocument("C:\Temp\SavedDocument.rtf", DocumentFormat.Rtf)
		End Sub

		Private Sub LoadDocumentButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.LoadDocument("C:\Temp\SavedDocument.rtf", DocumentFormat.Rtf)
		End Sub
	End Class
End Namespace
