using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace FormatDecimals {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        myReport report = new myReport();

        private void button1_Click(object sender, EventArgs e) {
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            ReportDesignTool designTool = new ReportDesignTool(report);
            designTool.ShowDesignerDialog();
        }

    }
}