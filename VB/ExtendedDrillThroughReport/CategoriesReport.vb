Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview

Namespace ExtendedDrillThroughReport
	Partial Public Class CategoriesReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Implements IDrillThroughReportHelper

		#Region "IDrillThroughReportHelper"
		Public Property Viewer() As DocumentViewer Implements IDrillThroughReportHelper.Viewer
		Public Property ParentReport() As XtraReport Implements IDrillThroughReportHelper.ParentReport
		#End Region

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal parentReport As XtraReport, ByVal viewer As DocumentViewer)
			InitializeComponent()
			Me.Viewer = viewer
		End Sub

		Private Sub xrLabel2_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel2.PreviewMouseMove
			e.PreviewControl.Cursor = Cursors.Hand
		End Sub

		Private Sub xrLabel2_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel2.PreviewClick
			Dim productReport As New ProductsReport(Me, Viewer)
			productReport.Parameters("CategoryID").Value = DirectCast(DirectCast(e.Brick.Value, DataRowView).Row("CategoryID"), Integer)
			productReport.Parameters("CategoryName").Value = DirectCast(e.Brick.Value, DataRowView).Row("CategoryName").ToString()
			productReport.CreateDocument()
			Viewer.DocumentSource = productReport
		End Sub

		Private Sub xrLabel2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel2.BeforePrint
			DirectCast(sender, XRLabel).Tag = GetCurrentRow()
		End Sub
	End Class
End Namespace
