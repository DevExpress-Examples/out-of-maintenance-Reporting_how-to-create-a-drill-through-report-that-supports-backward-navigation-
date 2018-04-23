using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;

namespace ExtendedDrillThroughReport {
    public partial class CategoriesReport : DevExpress.XtraReports.UI.XtraReport, IDrillThroughReportHelper {

        #region IDrillThroughReportHelper
        public DocumentViewer Viewer { get; set; }
        public XtraReport ParentReport { get; set; }
        #endregion

        public CategoriesReport() {
            InitializeComponent();
        }

        public CategoriesReport(XtraReport parentReport, DocumentViewer viewer) {
            InitializeComponent();
            Viewer = viewer;
        }

        private void xrLabel2_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }

        private void xrLabel2_PreviewClick(object sender, PreviewMouseEventArgs e) {
            ProductsReport productReport = new ProductsReport(this, Viewer);
            productReport.Parameters["CategoryID"].Value = (int)((DataRowView)e.Brick.Value).Row["CategoryID"];
            productReport.Parameters["CategoryName"].Value = ((DataRowView)e.Brick.Value).Row["CategoryName"].ToString();
            productReport.CreateDocument();
            Viewer.DocumentSource = productReport;
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRLabel)sender).Tag = GetCurrentRow();
        }
    }
}
