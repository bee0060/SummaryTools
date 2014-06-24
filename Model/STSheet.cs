using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Model
{
    public class STSheet  
    {
        private List<IRow> headerRows = new List<IRow>();
        private List<string> dataRowHeaderNames = new List<string>();
        private List<STInformationBlock> blocks = new List<STInformationBlock>();

        private Dictionary<string, int> columnIndexMapping = new Dictionary<string, int>();

        public STSheet(HSSFSheet src, STFormat format)
        {
            if (src == null || format == null)
            {
                return;
            }
            #region 注释代码
            //int rowsCount = src.PhysicalNumberOfRows;
            //bool dataStart = false;


            //for (int i = 0; i < rowsCount; i++)
            //{
            //    HSSFRow currentRow = src.GetRow(i) as HSSFRow;

            //    if (currentRow != null)
            //    {
            //        int columnPrefix = 0;
            //        foreach(HSSFCell cell in currentRow.Cells)
            //        {
            //            string cellStringValue = cell.StringCellValue;
            //            decimal cellDecimalValue = 0;
            //            if (dataStart || decimal.TryParse(cellStringValue, out cellDecimalValue))
            //            {
            //                dataStart = true;
            //            }
            //            else
            //            {
            //                columnPrefix++;
            //                if (columnPrefix >= currentRow.Cells.Count / 3)
            //                {
            //                    headerRows.Add(currentRow);
            //                    break;
            //                }
            //            }
            //        }
                    
                
            //    }

            //}
            #endregion

            int rowsCount = src.PhysicalNumberOfRows;
            int headerRowIndex = rowsCount >= format.headerRowIndex ? format.headerRowIndex : -1;
            IRow headerRow = rowsCount >= format.headerRowIndex ? src.GetRow(format.headerRowIndex) : null;
            GetHeadersRows(src, headerRowIndex);
            GetDataRowHeaderNames(headerRow);



        }

        private void GetHeadersRows(HSSFSheet sheet,int headerRowIndex)
        {
            if (sheet != null)
            {
                for (int i = 0; i <= headerRowIndex; i++)
                {
                    this.headerRows.Add(sheet.GetRow(i));
                }            
            }        
        }

        private void GetDataRowHeaderNames(IRow headerRow)
        { 
            //columnIndexMapping
            if (headerRow != null)
            { 
                foreach(ICell cell in headerRow.Cells)
                {
                    if (string.IsNullOrWhiteSpace(cell.StringCellValue))
                    {
                        columnIndexMapping.Add(cell.StringCellValue, cell.ColumnIndex);
                    }
                }
            }        
        }

        private void FillBlocks(ISheet sheet, int dataStartRowIndex)
        {
            IRow dataStartRow = sheet.GetRow(dataStartRowIndex);


        
        }
    }
}
