using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Model;

namespace Service
{
    public  class SheetManager
    {
        private List<HSSFSheet> sheets = new List<HSSFSheet>();
        private STSheet[] sheetsAnalysised = null;
        private STFormat sheetFormat = null;

        private bool hasAnalysis = false;

        public SheetManager(WorkBookManager workBookManager, STFormat format)
        {
            List<HSSFWorkbook> workbooks = workBookManager.Workbooks;
            int tempSheetCount = 0;
            HSSFSheet tempSheet = null;
            sheetFormat = format;

            if (workbooks != null)
            {
                foreach (HSSFWorkbook workbook in workbooks)
                {
                    if (workbook != null)
                    {
                        tempSheetCount = workbook.NumberOfSheets;

                        for (int i = 0; i < tempSheetCount; i++)
                        {
                            tempSheet = workbook.GetSheetAt(i) as HSSFSheet;
                            if (tempSheet != null)
                            {
                                sheets.Add(tempSheet);
                            }
                        }
                    }
                }
            }
            sheetsAnalysised = new STSheet[sheets.Count];
        }

        private void AnalysisSheetAt(int index)
        {
            STSheet sheet = new STSheet(sheets[index], sheetFormat);
            sheetsAnalysised[index] = sheet;
        }

        public HSSFSheet this[int index]
        {
            get { return sheets[index]; }
        }

        public STSheet GetAnalysisSheetAt(int index)
        {
            if (sheetsAnalysised[index]==null)
            {
                AnalysisSheetAt(index);
            }
            return sheetsAnalysised[index];
        }

        public int Count
        {
            get { return sheets.Count; }
        }

        public int GetBlocksCount()
        {
            int blocks = 0;
            foreach (STSheet sheet in sheetsAnalysised)
            {
                blocks += sheet.GetBlocksCount();
            }

            return blocks;
        }
    }
}
