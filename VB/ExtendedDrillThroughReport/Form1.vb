Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace ExtendedDrillThroughReport
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler documentViewer1.DocumentChanged, AddressOf documentViewer1_DocumentChanged
			Dim report As New CategoriesReport(Nothing, Me.documentViewer1)
			report.CreateDocument()
			documentViewer1.DocumentSource = report
		End Sub

		Private Sub documentViewer1_DocumentChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim currentReport As IDrillThroughReportHelper = TryCast(documentViewer1.DocumentSource, IDrillThroughReportHelper)
			biBack.Enabled = Not(currentReport Is Nothing OrElse currentReport.ParentReport Is Nothing)
		End Sub

		Private Sub biBack_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biBack.ItemClick
			Dim currentReport As IDrillThroughReportHelper = TryCast(documentViewer1.DocumentSource, IDrillThroughReportHelper)
			If currentReport Is Nothing OrElse currentReport.ParentReport Is Nothing Then
				Return
			Else
				documentViewer1.DocumentSource = currentReport.ParentReport
			End If
		End Sub
	End Class
End Namespace
