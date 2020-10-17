using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class Movie
    {
        public Movie()
        {
            //this.Users = new HashSet<Users>();
        }
        public int Id { get; set; }
        public string Title  { get; set; }
        public int TotalCapacity  { get; set; }
        /// <summary>
        /// Number of All capacities 
        /// </summary>
        public int BookedCapacity { get; set; }
        /// <summary>
        /// Number of booked items
        /// </summary>
        public string imgUrl { get; set; }
        public string PlotDsc { get; set; }

    }
}
