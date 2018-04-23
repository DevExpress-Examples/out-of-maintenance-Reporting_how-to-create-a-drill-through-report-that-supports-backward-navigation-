using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtendedDrillThroughReport {
    public interface IDrillThroughReportHelper {
        DocumentViewer Viewer { get; set; }
        XtraReport ParentReport { get; set; }
    }
}
