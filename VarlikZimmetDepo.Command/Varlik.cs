using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepo.Command
{
    public class Varlik
    {
        public int KayitNo { get; set; }
        public Guid  Barkod { get; set; }
        public string  UrunTİpi { get; set; }
        public string  Marka { get; set; }
        public string  Model { get; set; }
        public decimal GuncelFiyat { get; set; }
        public override string ToString()
        {
            return KayitNo + Barkod.ToString() +UrunTİpi+Marka+Model+GuncelFiyat;
        }

    }
}
