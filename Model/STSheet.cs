using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;

namespace Model
{
    public class STSheet  
    {
        private List<HSSFRow> headerRows = new List<HSSFRow>();
        private List<string> dataRowHeaderNames = new List<string>();
        private List<STInformationBlock> blocks = new List<STInformationBlock>();

        public STSheet(HSSFSheet src)
        {
            if (src == null)
            {
                return;
            }

            int rowsCount = src.PhysicalNumberOfRows;

            for (int i = 0; i < rowsCount; i++)
            {
                HSSFRow currentRow = src.GetRow(i) as HSSFRow;

                if (currentRow != null)
                {
                    int columnPrefix = 0;
                    foreach(HSSFCell cell in currentRow.Cells)
                    {
                        string cellStringValue = cell.StringCellValue;
                        decimal cellDecimalValue = 0;
                        if (decimal.TryParse(cellStringValue, out cellDecimalValue))
                        {

                        }
                        else
                        {
                            columnPrefix++;
                            if (columnPrefix >= currentRow.Cells.Count / 3)
                            {
                                headerRows.Add(currentRow);
                            }
                        }
                    }
                    
                
                }

            }
        }

        private void GetHeadersRows()
        { 
        
        
        }

        private void GetDataRowHeaderNames()
        { 
        
        
        
        }

        private void FillBlocks()
        { 
        
        
        }
    }
}
