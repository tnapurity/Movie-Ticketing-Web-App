using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class Users

    {
        public Users()
        {
            //this.Movies = new HashSet<Movie>();
        }
        [Key]
        public Guid UserId{ get; set; }
        public string UserName {get;set;}
        public string Name { get; set; }

        public string LastName { get; set; }

        public string AvatarimgUrl { get; set; }

      

    }
}



//test comment for GitHub