using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepo.Command
{
    public class ParaBirim
    {
        public string ParaBirimi { get; set; }
        public override string ToString()
        {
            return ParaBirimi;
        }
    }
}
