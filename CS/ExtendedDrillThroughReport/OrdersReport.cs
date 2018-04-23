using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;

namespace ExtendedDrillThroughReport {
    public partial class OrdersReport : DevExpress.XtraReports.UI.XtraReport, IDrillThroughReportHelper {

        #region IDrillThroughReportHelper
        public DocumentViewer Viewer { get; set; }
        public XtraReport ParentReport { get; set; }
        #endregion

        public OrdersReport() {
            InitializeComponent();
        }

        public OrdersReport(XtraReport parentReport, DocumentViewer viewer) {
            InitializeComponent();
            this.ParentReport = parentReport;
            this.Viewer = viewer;
        }
    }
}
