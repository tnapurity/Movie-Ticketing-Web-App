using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class ReservedDetail
    {

        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieImg { get; set; }
        public int ResrvID { get; set; }
        public int Tickets { get; set; }

    }
}
