using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using System.Windows.Forms;
using System.Data;

namespace ExtendedDrillThroughReport {
    public partial class ProductsReport : DevExpress.XtraReports.UI.XtraReport, IDrillThroughReportHelper {

        #region IDrillThroughReportHelper
        public DocumentViewer Viewer { get; set; }
        public XtraReport ParentReport { get; set; }
        #endregion

        public ProductsReport() {
            InitializeComponent();
        }

        public ProductsReport(XtraReport parentReport, DocumentViewer viewer) {
            InitializeComponent();
            this.ParentReport = parentReport;
            this.Viewer = viewer;
        }

        private void xrTableCell5_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }

        private void xrTableCell5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRLabel)sender).Tag = GetCurrentRow();
        }

        private void xrTableCell5_PreviewClick(object sender, PreviewMouseEventArgs e) {
            OrderDetailsReport orderDetailsReport = new OrderDetailsReport(this, Viewer);
            orderDetailsReport.Parameters["ProductID"].Value = (int)((DataRowView)e.Brick.Value).Row["ProductID"];
            orderDetailsReport.Parameters["ProductName"].Value = ((DataRowView)e.Brick.Value).Row["ProductName"].ToString();
            orderDetailsReport.CreateDocument();
            Viewer.DocumentSource = orderDetailsReport;
        }

    }
}
