using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NPOI.HSSF.UserModel;

namespace Service
{
    public  class SheetManager
    {
        private List<HSSFSheet> sheets = new List<HSSFSheet>();

        public SheetManager(WorkBookManager workBookManager)
        {
            List<HSSFWorkbook> workbooks = workBookManager.Workbooks;
            int tempSheetCount = 0;
            HSSFSheet tempSheet = null;

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
        }

        public HSSFSheet this[int index]
        {
            get { return sheets[index]; }
        }

        public int Count
        {
            get { return sheets.Count; }
        }
    }
}
