Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview
Imports System.Windows.Forms
Imports System.Data

Namespace ExtendedDrillThroughReport
	Partial Public Class OrderDetailsReport
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

		Private Sub xrTableCell1_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrTableCell1.PreviewMouseMove
			e.PreviewControl.Cursor = Cursors.Hand
		End Sub

		Private Sub xrTableCell1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrTableCell1.BeforePrint
			DirectCast(sender, XRLabel).Tag = GetCurrentRow()
		End Sub

		Private Sub xrTableCell1_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrTableCell1.PreviewClick
			Dim ordersReport As New OrdersReport(Me, Viewer)
			ordersReport.Parameters("OrderID").Value = DirectCast(DirectCast(e.Brick.Value, DataRowView).Row("OrderID"), Integer)
			ordersReport.CreateDocument()
			Viewer.DocumentSource = ordersReport
		End Sub

	End Class
End Namespace
