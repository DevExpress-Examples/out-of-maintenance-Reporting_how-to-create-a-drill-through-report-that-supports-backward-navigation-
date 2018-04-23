using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExtendedDrillThroughReport {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            documentViewer1.DocumentChanged += documentViewer1_DocumentChanged;
            CategoriesReport report = new CategoriesReport(null, this.documentViewer1);
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }

        void documentViewer1_DocumentChanged(object sender, EventArgs e) {
            IDrillThroughReportHelper currentReport = documentViewer1.DocumentSource as IDrillThroughReportHelper;
            biBack.Enabled = !(currentReport == null || currentReport.ParentReport == null);
        }

        private void biBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            IDrillThroughReportHelper currentReport = documentViewer1.DocumentSource as IDrillThroughReportHelper;
            if(currentReport == null || currentReport.ParentReport == null)
                return;
            else
                documentViewer1.DocumentSource = currentReport.ParentReport;
        }
    }
}
