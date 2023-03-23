using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepo.Command
{
    public class Model
    {
        public string ModelAdi { get; set; }
        public int ModelID { get; set; }
        public override string ToString()
        {
            return ModelAdi;
        }
    }
}
