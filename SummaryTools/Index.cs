using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using NPOI.HSSF;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SummaryTools
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnSelectSrc_Click(object sender, EventArgs e)
        {
            DialogResult drSrc = this.fbdSrc.ShowDialog(this);
            txtSrcPath.Text = fbdSrc.SelectedPath;
        }

        private void btnOpenTables_Click(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.Now;


            WorkBookManager wbm = new WorkBookManager(txtSrcPath.Text);
            SheetManager sm = new SheetManager(wbm);

            txtOutput.Text = string.Format("一共找到{0}个电子表格,其中共包含{1}个表.", 
                wbm.Count, sm.Count);
            DateTime dtEnd = DateTime.Now;

            txtUsedTime.Text = string.Format("{0}秒", (dtEnd - dtStart).TotalSeconds);
        }
    }
}
