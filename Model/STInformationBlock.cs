using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Model
{
    public class STInformationBlock
    {
        internal string blockName;
        private List<string> dataRowHeaderNames = new List<string>();
        internal List<IRow> dataRows = new List<IRow>();
        internal Dictionary<string, decimal> columnValues = new Dictionary<string, decimal>();


        public STInformationBlock()
        { 
        
        }

    }
}
