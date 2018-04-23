Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview

Namespace ExtendedDrillThroughReport
	Partial Public Class OrdersReport
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
	End Class
End Namespace
