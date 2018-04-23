# How to create a drill-through report that supports backward navigation to a primary report


<p>This example illustrates how to create a <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument7058">drill-through</a> report and display it in the same document viewer without creating addition <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument5184">Print Preview</a> forms and also implement a backward navigation from a child report to a parent report.</p>
<p>To show a child report instead of a parent one in the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument105">DocumentViewer</a> control, it is necessary to assign an instance of the child report to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingPreviewDocumentViewer_DocumentSourcetopic">DocumentViewer.DocumentSource</a> property.</p>
<p>For this, a custom <strong>IDrillThroughReportHelper</strong> interface is implemented. The interface contains the <strong>DocumentViewer</strong> instance where the child report should be loaded. The interface also contains a property that stores an instance of the parent report. This property is used to provide switching from the child report to the parent. Each report is inherited from the <strong>IDrillThroughReportHelper</strong> interface to provide the required functionality.</p>
<p>To switch from a parent report to a child report, the example uses an approach described in the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument4789">How to: Create a Drill-Through Report</a> article.</p>

<br/>


