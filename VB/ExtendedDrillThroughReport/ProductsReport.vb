Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview
Imports System.Windows.Forms
Imports System.Data

Namespace ExtendedDrillThroughReport
	Partial Public Class ProductsReport
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
			Me.ParentReport = parentReport
			Me.Viewer = viewer
		End Sub

		Private Sub xrTableCell5_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrTableCell5.PreviewMouseMove
			e.PreviewControl.Cursor = Cursors.Hand
		End Sub

		Private Sub xrTableCell5_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrTableCell5.BeforePrint
			DirectCast(sender, XRLabel).Tag = GetCurrentRow()
		End Sub

		Private Sub xrTableCell5_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrTableCell5.PreviewClick
			Dim orderDetailsReport As New OrderDetailsReport(Me, Viewer)
			orderDetailsReport.Parameters("ProductID").Value = DirectCast(DirectCast(e.Brick.Value, DataRowView).Row("ProductID"), Integer)
			orderDetailsReport.Parameters("ProductName").Value = DirectCast(e.Brick.Value, DataRowView).Row("ProductName").ToString()
			orderDetailsReport.CreateDocument()
			Viewer.DocumentSource = orderDetailsReport
		End Sub

	End Class
End Namespace
