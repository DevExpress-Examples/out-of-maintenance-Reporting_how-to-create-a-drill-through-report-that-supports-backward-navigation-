using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using System.Windows.Forms;
using System.Data;

namespace ExtendedDrillThroughReport {
    public partial class OrderDetailsReport : DevExpress.XtraReports.UI.XtraReport, IDrillThroughReportHelper {

        #region IDrillThroughReportHelper
        public DocumentViewer Viewer { get; set; }
        public XtraReport ParentReport { get; set; }
        #endregion

        public OrderDetailsReport() {
            InitializeComponent();
        }

        public OrderDetailsReport(XtraReport parentReport, DocumentViewer viewer) {
            InitializeComponent();
            this.ParentReport = parentReport;
            this.Viewer = viewer;
        }

        private void xrTableCell1_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRLabel)sender).Tag = GetCurrentRow();
        }

        private void xrTableCell1_PreviewClick(object sender, PreviewMouseEventArgs e) {
            OrdersReport ordersReport = new OrdersReport(this, Viewer);
            ordersReport.Parameters["OrderID"].Value = (int)((DataRowView)e.Brick.Value).Row["OrderID"];
            ordersReport.CreateDocument();
            Viewer.DocumentSource = ordersReport;
        }

    }
}
