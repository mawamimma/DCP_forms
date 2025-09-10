using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP.wpf.Model
{
    public class ExpendHead
    {
        public int Id { get; set; }
        public string ExpCode { get; set; }

        public string ExpDetails { get; set; }

        public string UserID { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
