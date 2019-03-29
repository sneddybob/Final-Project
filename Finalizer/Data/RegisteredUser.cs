using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalizer.Data
{
    public class RegisteredUser : IdentityUser
    {
        public RegisteredUser() : base()
        {
            this.Reviews = new HashSet<Review>();
        }

        public RegisteredUser(string userName) : base(userName)
        {
            this.Reviews = new HashSet<Review>();
        }

        //Individual values
        //public decimal? HatSize { get; set; } (currently none for my finalProj)

        //Relationships
        public ICollection<Review> Reviews { get; set; }

        public Cart Cart { get; set; }

        public int? CartID { get; set; }

    }
}