using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NPOI.HSSF.UserModel;


namespace Service
{
    public class WorkBookManager
    {
        private List<HSSFWorkbook> workbooks = new List<HSSFWorkbook>();

        internal List<HSSFWorkbook> Workbooks
        {
            get { return workbooks; }
        }

        public WorkBookManager(string directoryPath)
        {           
            DirectoryInfo di = new DirectoryInfo(directoryPath);
            FileInfo[] files  = null;
            FileStream tempSteam = null;
            HSSFWorkbook tempWorkBook = null;
            if (di != null)
            {
                files = di.GetFiles();
                if (files != null)
                {
                    foreach (FileInfo file in files)
                    {
                        if (file.Extension == ".xls" || file.Extension == ".xlsx")
                        {
                            try
                            {
                                tempSteam = new FileStream(file.FullName, FileMode.Open);
                                tempWorkBook = new HSSFWorkbook(tempSteam);
                                workbooks.Add(tempWorkBook);

                                tempSteam.Close();
                               // tempSteam.Dispose();
                            }
                            catch(Exception ex)
                            {
                                throw ex;
                            }
                        }                    
                    }
                }
            }
        }


        public HSSFWorkbook this[int index]
        {
            get { return workbooks[index]; }
        }

        public int Count
        {
            get { return workbooks.Count; }
        }
    }
}
