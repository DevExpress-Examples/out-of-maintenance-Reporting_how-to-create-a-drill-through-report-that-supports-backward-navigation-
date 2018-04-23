Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace ExtendedDrillThroughReport
	Public Interface IDrillThroughReportHelper
		Property Viewer() As DocumentViewer
		Property ParentReport() As XtraReport
	End Interface
End Namespace
