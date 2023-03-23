using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepo.Command
{
    public class UrunTipi
    {
        public string UrunTipiAdi { get; set; }
        public int UrunTipiID { get; set; }
        public override string ToString()
        {
            return UrunTipiAdi;
        }
    }
}
