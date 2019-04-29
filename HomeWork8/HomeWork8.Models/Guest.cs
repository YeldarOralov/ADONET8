using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Models
{
    public class Guest:Entity
    {
        public string FullName { get; set; }
        public string DocumentNumber { get; set; }
        public string Purpose { get; set; }
        public DateTime ComeInTime { get; set; }
        public DateTime? GoOutTime { get; set; }
        public Guest()
        {
            ComeInTime = DateTime.Now;
        }
    }
}
