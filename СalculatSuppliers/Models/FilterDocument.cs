using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace СalculatSuppliers.Models
{
    public class FilterDocument
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish{ get; set; }
    }
}
