using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testnis
{
    public class Bane
    {
        #region Properties
        public int BaneID { get; set; } // 1, 2, 3
        public string BaneType { get; set; } // tennis / padel
        public int BaneStr { get; set; } // størrelse
        public DateTime SidstOrdnet { get; set; }
        #endregion

        public Bane() { }
        public Bane(int baneId, string baneType, int baneStr)
        {
            BaneID = baneId;
            BaneType = baneType;
            BaneStr = baneStr;
            SidstOrdnet = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Bane ID: {BaneID}\nBane Type: {BaneType}\nBane Størrelse: {BaneStr}\nSidst Ordnet: {SidstOrdnet}";
        }
    }
}
