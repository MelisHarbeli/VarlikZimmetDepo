using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepo.Command
{
    public class Marka
    {
        public string MarkaAdi { get; set; }
        public int MarkaID { get; set; }
        public override string ToString()
        {
            return MarkaAdi;
        }
    }
}
