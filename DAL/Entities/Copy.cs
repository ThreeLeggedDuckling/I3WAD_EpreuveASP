using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Copy
    {
        public Guid Copy_Id { get; set; }
        public Guid Game { get; set; }
        public Guid? Owner { get; set; }
        public string State { get; set; }
    }
}
