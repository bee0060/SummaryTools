using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class STFormat
    {
        internal int headerRowIndex = -1;
        internal int dataStartRowIndex = -1;
        internal string[] columns = null;
        internal string groupByColumn = "";
    }
}
